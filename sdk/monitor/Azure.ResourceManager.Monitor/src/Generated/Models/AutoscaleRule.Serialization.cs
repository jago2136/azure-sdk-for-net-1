// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class AutoscaleRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("metricTrigger");
            writer.WriteObjectValue(MetricTrigger);
            writer.WritePropertyName("scaleAction");
            writer.WriteObjectValue(ScaleAction);
            writer.WriteEndObject();
        }

        internal static AutoscaleRule DeserializeAutoscaleRule(JsonElement element)
        {
            MetricTrigger metricTrigger = default;
            MonitorScaleAction scaleAction = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricTrigger"))
                {
                    metricTrigger = MetricTrigger.DeserializeMetricTrigger(property.Value);
                    continue;
                }
                if (property.NameEquals("scaleAction"))
                {
                    scaleAction = MonitorScaleAction.DeserializeMonitorScaleAction(property.Value);
                    continue;
                }
            }
            return new AutoscaleRule(metricTrigger, scaleAction);
        }
    }
}
