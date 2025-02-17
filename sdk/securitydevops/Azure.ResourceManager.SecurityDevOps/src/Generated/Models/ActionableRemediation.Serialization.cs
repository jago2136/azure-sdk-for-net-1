// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    public partial class ActionableRemediation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state");
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsCollectionDefined(SeverityLevels))
            {
                writer.WritePropertyName("severityLevels");
                writer.WriteStartArray();
                foreach (var item in SeverityLevels)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Categories))
            {
                writer.WritePropertyName("categories");
                writer.WriteStartArray();
                foreach (var item in Categories)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BranchConfiguration))
            {
                writer.WritePropertyName("branchConfiguration");
                writer.WriteObjectValue(BranchConfiguration);
            }
            writer.WriteEndObject();
        }

        internal static ActionableRemediation DeserializeActionableRemediation(JsonElement element)
        {
            Optional<ActionableRemediationState> state = default;
            Optional<IList<string>> severityLevels = default;
            Optional<IList<ActionableRemediationRuleCategory>> categories = default;
            Optional<TargetBranchConfiguration> branchConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    state = new ActionableRemediationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("severityLevels"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    severityLevels = array;
                    continue;
                }
                if (property.NameEquals("categories"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ActionableRemediationRuleCategory> array = new List<ActionableRemediationRuleCategory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ActionableRemediationRuleCategory(item.GetString()));
                    }
                    categories = array;
                    continue;
                }
                if (property.NameEquals("branchConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    branchConfiguration = TargetBranchConfiguration.DeserializeTargetBranchConfiguration(property.Value);
                    continue;
                }
            }
            return new ActionableRemediation(Optional.ToNullable(state), Optional.ToList(severityLevels), Optional.ToList(categories), branchConfiguration.Value);
        }
    }
}
