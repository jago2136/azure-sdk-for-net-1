[CmdletBinding()]
param (
    [Parameter(Position=0)]
    [ValidateNotNullOrEmpty()]
    [string] $ProjectDirectory
)

$ErrorActionPreference = "Stop"
. $PSScriptRoot/../common/scripts/Helpers/PSModule-Helpers.ps1
Install-ModuleIfNotInstalled "powershell-yaml" "0.4.1" | Import-Module

function NpmInstallForProject([string]$workingDirectory) {
    Push-Location $workingDirectory
    try {
        $currentDur = Resolve-Path "."
        Write-Host "Generating from $currentDur"
        if (Test-Path "package.json") {
            Remove-Item -Path "package.json" -Force
        }
        if (Test-Path ".npmrc") {
            Remove-Item -Path ".npmrc" -Force
        }
        Copy-Item -Path "$PSScriptRoot/../csharp-emitter-package.json" -Destination "package.json" -Force
        npm install
        if ($LASTEXITCODE) { exit $LASTEXITCODE }
    }
    finally {
        Pop-Location
    }
}

$cadlConfigurationFile = Resolve-Path "$ProjectDirectory/src/cadl-location.yaml"

Write-Host "Reading configuration from $cadlConfigurationFile"
$configuration = Get-Content -Path $cadlConfigurationFile -Raw | ConvertFrom-Yaml

$specSubDirectory = $configuration["directory"]
$innerFolder = Split-Path $specSubDirectory -Leaf

$tempFolder = "$ProjectDirectory/TempCadlFiles"
$npmWorkingDir = Resolve-Path $tempFolder/$innerFolder
$mainCadlFile = If (Test-Path "$npmWorkingDir/client.cadl") { Resolve-Path "$npmWorkingDir/client.cadl" } Else { Resolve-Path "$npmWorkingDir/main.cadl"}
$resolvedProjectDirectory = Resolve-Path "$ProjectDirectory/src"

if (Test-Path "$npmWorkingDir/cadl-project.yaml") {
    $cadlProjectYaml = Get-Content -Path "$npmWorkingDir/cadl-project.yaml" -Raw
    $yml = ConvertFrom-YAML $cadlProjectYaml
    if ( $yml["emitters"]["@azure-tools/cadl-csharp"]["sdk-folder"]) {
        $yml["emitters"]["@azure-tools/cadl-csharp"]["sdk-folder"] = ""
    }
    (ConvertTo-Yaml $yml) | Out-File "$npmWorkingDir/cadl-project.yaml"
}

try {
    Push-Location $npmWorkingDir
    NpmInstallForProject $npmWorkingDir
    Write-Host("npx cadl compile $mainCadlFile --emit `"`@azure-tools/cadl-csharp`" --output-path `"$resolvedProjectDirectory`"")
    npx cadl compile $mainCadlFile --emit "@azure-tools/cadl-csharp" --output-path "$resolvedProjectDirectory"
}
finally {
    Pop-Location
}

$shouldCleanUp = $configuration["cleanup"] ?? $true
if ($shouldCleanUp) {
    Remove-Item $tempFolder -Recurse -Force
}