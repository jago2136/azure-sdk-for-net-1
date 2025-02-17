// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="WebSiteHybridConnectionResource" /> and their operations.
    /// Each <see cref="WebSiteHybridConnectionResource" /> in the collection will belong to the same instance of <see cref="WebSiteResource" />.
    /// To get a <see cref="WebSiteHybridConnectionCollection" /> instance call the GetWebSiteHybridConnections method from an instance of <see cref="WebSiteResource" />.
    /// </summary>
    public partial class WebSiteHybridConnectionCollection : ArmCollection
    {
        private readonly ClientDiagnostics _webSiteHybridConnectionWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteHybridConnectionWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSiteHybridConnectionCollection"/> class for mocking. </summary>
        protected WebSiteHybridConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteHybridConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WebSiteHybridConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteHybridConnectionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", WebSiteHybridConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WebSiteHybridConnectionResource.ResourceType, out string webSiteHybridConnectionWebAppsApiVersion);
            _webSiteHybridConnectionWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteHybridConnectionWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Creates a new hybrid connection configuration (PUT), or updates an existing one (PATCH).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hybridconnection/{entityName}
        /// Operation Id: WebApps_CreateOrUpdateRelayServiceConnection
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="entityName"> Name of the hybrid connection configuration. </param>
        /// <param name="data"> Details of the hybrid connection configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WebSiteHybridConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string entityName, RelayServiceConnectionEntityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSiteHybridConnectionWebAppsClientDiagnostics.CreateScope("WebSiteHybridConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webSiteHybridConnectionWebAppsRestClient.CreateOrUpdateRelayServiceConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, entityName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<WebSiteHybridConnectionResource>(Response.FromValue(new WebSiteHybridConnectionResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Creates a new hybrid connection configuration (PUT), or updates an existing one (PATCH).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hybridconnection/{entityName}
        /// Operation Id: WebApps_CreateOrUpdateRelayServiceConnection
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="entityName"> Name of the hybrid connection configuration. </param>
        /// <param name="data"> Details of the hybrid connection configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WebSiteHybridConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string entityName, RelayServiceConnectionEntityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSiteHybridConnectionWebAppsClientDiagnostics.CreateScope("WebSiteHybridConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webSiteHybridConnectionWebAppsRestClient.CreateOrUpdateRelayServiceConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, entityName, data, cancellationToken);
                var operation = new AppServiceArmOperation<WebSiteHybridConnectionResource>(Response.FromValue(new WebSiteHybridConnectionResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a hybrid connection configuration by its name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hybridconnection/{entityName}
        /// Operation Id: WebApps_GetRelayServiceConnection
        /// </summary>
        /// <param name="entityName"> Name of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> is null. </exception>
        public virtual async Task<Response<WebSiteHybridConnectionResource>> GetAsync(string entityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));

            using var scope = _webSiteHybridConnectionWebAppsClientDiagnostics.CreateScope("WebSiteHybridConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _webSiteHybridConnectionWebAppsRestClient.GetRelayServiceConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, entityName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteHybridConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a hybrid connection configuration by its name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hybridconnection/{entityName}
        /// Operation Id: WebApps_GetRelayServiceConnection
        /// </summary>
        /// <param name="entityName"> Name of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> is null. </exception>
        public virtual Response<WebSiteHybridConnectionResource> Get(string entityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));

            using var scope = _webSiteHybridConnectionWebAppsClientDiagnostics.CreateScope("WebSiteHybridConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _webSiteHybridConnectionWebAppsRestClient.GetRelayServiceConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, entityName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteHybridConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hybridconnection/{entityName}
        /// Operation Id: WebApps_GetRelayServiceConnection
        /// </summary>
        /// <param name="entityName"> Name of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string entityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));

            using var scope = _webSiteHybridConnectionWebAppsClientDiagnostics.CreateScope("WebSiteHybridConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _webSiteHybridConnectionWebAppsRestClient.GetRelayServiceConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, entityName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hybridconnection/{entityName}
        /// Operation Id: WebApps_GetRelayServiceConnection
        /// </summary>
        /// <param name="entityName"> Name of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> is null. </exception>
        public virtual Response<bool> Exists(string entityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));

            using var scope = _webSiteHybridConnectionWebAppsClientDiagnostics.CreateScope("WebSiteHybridConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _webSiteHybridConnectionWebAppsRestClient.GetRelayServiceConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, entityName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
