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
using Azure.ResourceManager.CosmosDB;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_CassandraClusterResource
    {
        // CosmosDBManagedCassandraClusterListBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetCassandraClusters_CosmosDBManagedCassandraClusterListBySubscription()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBManagedCassandraClusterListBySubscription.json
            // this example is just showing the usage of "CassandraClusters_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (CassandraClusterResource item in subscriptionResource.GetCassandraClustersAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CassandraClusterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBManagedCassandraClusterGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CosmosDBManagedCassandraClusterGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBManagedCassandraClusterGet.json
            // this example is just showing the usage of "CassandraClusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraClusterResource created on azure
            // for more information of creating CassandraClusterResource, please refer to the document of CassandraClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "cassandra-prod-rg";
            string clusterName = "cassandra-prod";
            ResourceIdentifier cassandraClusterResourceId = CassandraClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CassandraClusterResource cassandraCluster = client.GetCassandraClusterResource(cassandraClusterResourceId);

            // invoke the operation
            CassandraClusterResource result = await cassandraCluster.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CassandraClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBManagedCassandraClusterDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_CosmosDBManagedCassandraClusterDelete()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBManagedCassandraClusterDelete.json
            // this example is just showing the usage of "CassandraClusters_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraClusterResource created on azure
            // for more information of creating CassandraClusterResource, please refer to the document of CassandraClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "cassandra-prod-rg";
            string clusterName = "cassandra-prod";
            ResourceIdentifier cassandraClusterResourceId = CassandraClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CassandraClusterResource cassandraCluster = client.GetCassandraClusterResource(cassandraClusterResourceId);

            // invoke the operation
            await cassandraCluster.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBManagedCassandraClusterPatch
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CosmosDBManagedCassandraClusterPatch()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBManagedCassandraClusterPatch.json
            // this example is just showing the usage of "CassandraClusters_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraClusterResource created on azure
            // for more information of creating CassandraClusterResource, please refer to the document of CassandraClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "cassandra-prod-rg";
            string clusterName = "cassandra-prod";
            ResourceIdentifier cassandraClusterResourceId = CassandraClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CassandraClusterResource cassandraCluster = client.GetCassandraClusterResource(cassandraClusterResourceId);

            // invoke the operation
            CassandraClusterData data = new CassandraClusterData(new AzureLocation("placeholder"))
            {
                Properties = new CassandraClusterProperties()
                {
                    AuthenticationMethod = CassandraAuthenticationMethod.None,
                    ExternalGossipCertificates =
{
new CassandraCertificate()
{
Pem = "-----BEGIN CERTIFICATE-----\n...Base64 encoded certificate...\n-----END CERTIFICATE-----",
}
},
                    ExternalSeedNodes =
{
new CassandraDataCenterSeedNode()
{
IPAddress = "10.52.221.2",
},new CassandraDataCenterSeedNode()
{
IPAddress = "10.52.221.3",
},new CassandraDataCenterSeedNode()
{
IPAddress = "10.52.221.4",
}
},
                    HoursBetweenBackups = 12,
                },
                Tags =
{
["owner"] = "mike",
},
            };
            ArmOperation<CassandraClusterResource> lro = await cassandraCluster.UpdateAsync(WaitUntil.Completed, data);
            CassandraClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CassandraClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBManagedCassandraCommand
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task InvokeCommand_CosmosDBManagedCassandraCommand()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBManagedCassandraCommand.json
            // this example is just showing the usage of "CassandraClusters_InvokeCommand" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraClusterResource created on azure
            // for more information of creating CassandraClusterResource, please refer to the document of CassandraClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "cassandra-prod-rg";
            string clusterName = "cassandra-prod";
            ResourceIdentifier cassandraClusterResourceId = CassandraClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CassandraClusterResource cassandraCluster = client.GetCassandraClusterResource(cassandraClusterResourceId);

            // invoke the operation
            CassandraCommandPostBody body = new CassandraCommandPostBody("nodetool", "10.0.1.12")
            {
                Arguments =
{
["status"] = "",
},
            };
            ArmOperation<CassandraCommandOutput> lro = await cassandraCluster.InvokeCommandAsync(WaitUntil.Completed, body);
            CassandraCommandOutput result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // CosmosDBManagedCassandraListCommand
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetCommand_CosmosDBManagedCassandraListCommand()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBManagedCassandraListCommand.json
            // this example is just showing the usage of "CassandraClusters_ListCommand" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraClusterResource created on azure
            // for more information of creating CassandraClusterResource, please refer to the document of CassandraClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "cassandra-prod-rg";
            string clusterName = "cassandra-prod";
            ResourceIdentifier cassandraClusterResourceId = CassandraClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CassandraClusterResource cassandraCluster = client.GetCassandraClusterResource(cassandraClusterResourceId);

            // invoke the operation and iterate over the result
            await foreach (CommandPublicResource item in cassandraCluster.GetCommandAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBManagedCassandraCommandResult
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetCommandAsync_CosmosDBManagedCassandraCommandResult()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBManagedCassandraCommandResult.json
            // this example is just showing the usage of "CassandraClusters_GetCommandAsync" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraClusterResource created on azure
            // for more information of creating CassandraClusterResource, please refer to the document of CassandraClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "cassandra-prod-rg";
            string clusterName = "cassandra-prod";
            ResourceIdentifier cassandraClusterResourceId = CassandraClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CassandraClusterResource cassandraCluster = client.GetCassandraClusterResource(cassandraClusterResourceId);

            // invoke the operation and iterate over the result
            string commandId = "318653d0-3da5-4814-b8f6-429f2af0b2a4";
            await foreach (CommandPublicResource item in cassandraCluster.GetCommandAsyncAsync(commandId))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBManagedCassandraBackupsList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetBackups_CosmosDBManagedCassandraBackupsList()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBManagedCassandraBackupsList.json
            // this example is just showing the usage of "CassandraClusters_ListBackups" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraClusterResource created on azure
            // for more information of creating CassandraClusterResource, please refer to the document of CassandraClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "cassandra-prod-rg";
            string clusterName = "cassandra-prod";
            ResourceIdentifier cassandraClusterResourceId = CassandraClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CassandraClusterResource cassandraCluster = client.GetCassandraClusterResource(cassandraClusterResourceId);

            // invoke the operation and iterate over the result
            await foreach (CassandraClusterBackupResourceInfo item in cassandraCluster.GetBackupsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBManagedCassandraBackup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetBackup_CosmosDBManagedCassandraBackup()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBManagedCassandraBackup.json
            // this example is just showing the usage of "CassandraClusters_GetBackup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraClusterResource created on azure
            // for more information of creating CassandraClusterResource, please refer to the document of CassandraClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "cassandra-prod-rg";
            string clusterName = "cassandra-prod";
            ResourceIdentifier cassandraClusterResourceId = CassandraClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CassandraClusterResource cassandraCluster = client.GetCassandraClusterResource(cassandraClusterResourceId);

            // invoke the operation
            string backupId = "1611250348";
            CassandraClusterBackupResourceInfo result = await cassandraCluster.GetBackupAsync(backupId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // CosmosDBManagedCassandraClusterDeallocate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Deallocate_CosmosDBManagedCassandraClusterDeallocate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBManagedCassandraClusterDeallocate.json
            // this example is just showing the usage of "CassandraClusters_Deallocate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraClusterResource created on azure
            // for more information of creating CassandraClusterResource, please refer to the document of CassandraClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "cassandra-prod-rg";
            string clusterName = "cassandra-prod";
            ResourceIdentifier cassandraClusterResourceId = CassandraClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CassandraClusterResource cassandraCluster = client.GetCassandraClusterResource(cassandraClusterResourceId);

            // invoke the operation
            await cassandraCluster.DeallocateAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBManagedCassandraClusterStart
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Start_CosmosDBManagedCassandraClusterStart()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBManagedCassandraClusterStart.json
            // this example is just showing the usage of "CassandraClusters_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraClusterResource created on azure
            // for more information of creating CassandraClusterResource, please refer to the document of CassandraClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "cassandra-prod-rg";
            string clusterName = "cassandra-prod";
            ResourceIdentifier cassandraClusterResourceId = CassandraClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CassandraClusterResource cassandraCluster = client.GetCassandraClusterResource(cassandraClusterResourceId);

            // invoke the operation
            await cassandraCluster.StartAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBManagedCassandraStatus
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Status_CosmosDBManagedCassandraStatus()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBManagedCassandraStatus.json
            // this example is just showing the usage of "CassandraClusters_Status" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraClusterResource created on azure
            // for more information of creating CassandraClusterResource, please refer to the document of CassandraClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "cassandra-prod-rg";
            string clusterName = "cassandra-prod";
            ResourceIdentifier cassandraClusterResourceId = CassandraClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CassandraClusterResource cassandraCluster = client.GetCassandraClusterResource(cassandraClusterResourceId);

            // invoke the operation
            CassandraClusterPublicStatus result = await cassandraCluster.StatusAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
