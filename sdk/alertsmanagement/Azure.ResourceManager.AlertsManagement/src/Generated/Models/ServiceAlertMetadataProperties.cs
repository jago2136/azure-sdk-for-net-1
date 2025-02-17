// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary>
    /// alert meta data property bag
    /// Please note <see cref="ServiceAlertMetadataProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MonitorServiceList"/>.
    /// </summary>
    public abstract partial class ServiceAlertMetadataProperties
    {
        /// <summary> Initializes a new instance of ServiceAlertMetadataProperties. </summary>
        protected ServiceAlertMetadataProperties()
        {
        }

        /// <summary> Initializes a new instance of ServiceAlertMetadataProperties. </summary>
        /// <param name="metadataIdentifier"> Identification of the information to be retrieved by API call. </param>
        internal ServiceAlertMetadataProperties(ServiceAlertMetadataIdentifier metadataIdentifier)
        {
            MetadataIdentifier = metadataIdentifier;
        }

        /// <summary> Identification of the information to be retrieved by API call. </summary>
        internal ServiceAlertMetadataIdentifier MetadataIdentifier { get; set; }
    }
}
