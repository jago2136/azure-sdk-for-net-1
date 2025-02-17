// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.ProviderHub.Models;

namespace Azure.ResourceManager.ProviderHub
{
    public partial class Sample_NestedResourceTypeFirstSkuCollection
    {
        // Skus_GetNestedResourceTypeFirst
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SkusGetNestedResourceTypeFirst()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/preview/2021-09-01-preview/examples/Skus_GetNestedResourceTypeFirst.json
            // this example is just showing the usage of "Skus_GetNestedResourceTypeFirst" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceTypeRegistrationResource created on azure
            // for more information of creating ResourceTypeRegistrationResource, please refer to the document of ResourceTypeRegistrationResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string resourceType = "testResourceType";
            ResourceIdentifier resourceTypeRegistrationResourceId = ResourceTypeRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace, resourceType);
            ResourceTypeRegistrationResource resourceTypeRegistration = client.GetResourceTypeRegistrationResource(resourceTypeRegistrationResourceId);

            // get the collection of this NestedResourceTypeFirstSkuResource
            string nestedResourceTypeFirst = "nestedResourceTypeFirst";
            NestedResourceTypeFirstSkuCollection collection = resourceTypeRegistration.GetNestedResourceTypeFirstSkus(nestedResourceTypeFirst);

            // invoke the operation
            string sku = "testSku";
            NestedResourceTypeFirstSkuResource result = await collection.GetAsync(sku);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SkuResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Skus_GetNestedResourceTypeFirst
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_SkusGetNestedResourceTypeFirst()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/preview/2021-09-01-preview/examples/Skus_GetNestedResourceTypeFirst.json
            // this example is just showing the usage of "Skus_GetNestedResourceTypeFirst" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceTypeRegistrationResource created on azure
            // for more information of creating ResourceTypeRegistrationResource, please refer to the document of ResourceTypeRegistrationResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string resourceType = "testResourceType";
            ResourceIdentifier resourceTypeRegistrationResourceId = ResourceTypeRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace, resourceType);
            ResourceTypeRegistrationResource resourceTypeRegistration = client.GetResourceTypeRegistrationResource(resourceTypeRegistrationResourceId);

            // get the collection of this NestedResourceTypeFirstSkuResource
            string nestedResourceTypeFirst = "nestedResourceTypeFirst";
            NestedResourceTypeFirstSkuCollection collection = resourceTypeRegistration.GetNestedResourceTypeFirstSkus(nestedResourceTypeFirst);

            // invoke the operation
            string sku = "testSku";
            bool result = await collection.ExistsAsync(sku);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Skus_CreateOrUpdateNestedResourceTypeFirst
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_SkusCreateOrUpdateNestedResourceTypeFirst()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/preview/2021-09-01-preview/examples/Skus_CreateOrUpdateNestedResourceTypeFirst.json
            // this example is just showing the usage of "Skus_CreateOrUpdateNestedResourceTypeFirst" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceTypeRegistrationResource created on azure
            // for more information of creating ResourceTypeRegistrationResource, please refer to the document of ResourceTypeRegistrationResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string resourceType = "testResourceType";
            ResourceIdentifier resourceTypeRegistrationResourceId = ResourceTypeRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace, resourceType);
            ResourceTypeRegistrationResource resourceTypeRegistration = client.GetResourceTypeRegistrationResource(resourceTypeRegistrationResourceId);

            // get the collection of this NestedResourceTypeFirstSkuResource
            string nestedResourceTypeFirst = "nestedResourceTypeFirst";
            NestedResourceTypeFirstSkuCollection collection = resourceTypeRegistration.GetNestedResourceTypeFirstSkus(nestedResourceTypeFirst);

            // invoke the operation
            string sku = "testSku";
            SkuResourceData data = new SkuResourceData()
            {
                Properties = new SkuResourceProperties(new SkuSetting[]
            {
new SkuSetting("freeSku")
{
Tier = "Tier1",
Kind = "Standard",
},new SkuSetting("premiumSku")
{
Tier = "Tier2",
Kind = "Premium",
Costs =
{
new SkuCost("xxx")
},
}
            }),
            };
            ArmOperation<NestedResourceTypeFirstSkuResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, sku, data);
            NestedResourceTypeFirstSkuResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SkuResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Skus_ListByResourceTypeRegistrationsNestedResourceTypeFirst
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_SkusListByResourceTypeRegistrationsNestedResourceTypeFirst()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/preview/2021-09-01-preview/examples/Skus_ListByResourceTypeRegistrationsNestedResourceTypeFirst.json
            // this example is just showing the usage of "Skus_ListByResourceTypeRegistrationsNestedResourceTypeFirst" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceTypeRegistrationResource created on azure
            // for more information of creating ResourceTypeRegistrationResource, please refer to the document of ResourceTypeRegistrationResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string resourceType = "testResourceType";
            ResourceIdentifier resourceTypeRegistrationResourceId = ResourceTypeRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace, resourceType);
            ResourceTypeRegistrationResource resourceTypeRegistration = client.GetResourceTypeRegistrationResource(resourceTypeRegistrationResourceId);

            // get the collection of this NestedResourceTypeFirstSkuResource
            string nestedResourceTypeFirst = "nestedResourceTypeFirst";
            NestedResourceTypeFirstSkuCollection collection = resourceTypeRegistration.GetNestedResourceTypeFirstSkus(nestedResourceTypeFirst);

            // invoke the operation and iterate over the result
            await foreach (NestedResourceTypeFirstSkuResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SkuResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
