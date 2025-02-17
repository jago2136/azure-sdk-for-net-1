// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.ManagedServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedServices
{
    /// <summary> A class representing the ManagedServicesRegistrationAssignment data model. </summary>
    public partial class ManagedServicesRegistrationAssignmentData : ResourceData
    {
        /// <summary> Initializes a new instance of ManagedServicesRegistrationAssignmentData. </summary>
        public ManagedServicesRegistrationAssignmentData()
        {
        }

        /// <summary> Initializes a new instance of ManagedServicesRegistrationAssignmentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The properties of a registration assignment. </param>
        internal ManagedServicesRegistrationAssignmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ManagedServicesRegistrationAssignmentProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> The properties of a registration assignment. </summary>
        public ManagedServicesRegistrationAssignmentProperties Properties { get; set; }
    }
}
