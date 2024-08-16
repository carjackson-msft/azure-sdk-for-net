// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_CassandraTableResource
    {
        // CosmosDBCassandraTableGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CosmosDBCassandraTableGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBCassandraTableGet.json
            // this example is just showing the usage of "CassandraResources_GetCassandraTable" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraTableResource created on azure
            // for more information of creating CassandraTableResource, please refer to the document of CassandraTableResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string keyspaceName = "keyspaceName";
            string tableName = "tableName";
            ResourceIdentifier cassandraTableResourceId = CassandraTableResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, keyspaceName, tableName);
            CassandraTableResource cassandraTable = client.GetCassandraTableResource(cassandraTableResourceId);

            // invoke the operation
            CassandraTableResource result = await cassandraTable.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CassandraTableData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBCassandraTableCreateUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CosmosDBCassandraTableCreateUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBCassandraTableCreateUpdate.json
            // this example is just showing the usage of "CassandraResources_CreateUpdateCassandraTable" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraTableResource created on azure
            // for more information of creating CassandraTableResource, please refer to the document of CassandraTableResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string keyspaceName = "keyspaceName";
            string tableName = "tableName";
            ResourceIdentifier cassandraTableResourceId = CassandraTableResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, keyspaceName, tableName);
            CassandraTableResource cassandraTable = client.GetCassandraTableResource(cassandraTableResourceId);

            // invoke the operation
            CassandraTableCreateOrUpdateContent content = new CassandraTableCreateOrUpdateContent(new AzureLocation("West US"), new CassandraTableResourceInfo("tableName")
            {
                DefaultTtl = 100,
                Schema = new CassandraSchema()
                {
                    Columns =
{
new CassandraColumn()
{
Name = "columnA",
CassandraColumnType = "Ascii",
}
},
                    PartitionKeys =
{
new CassandraPartitionKey()
{
Name = "columnA",
}
},
                    ClusterKeys =
{
new CassandraClusterKey()
{
Name = "columnA",
OrderBy = "Asc",
}
},
                },
                AnalyticalStorageTtl = 500,
            })
            {
                Options = new CosmosDBCreateUpdateConfig(),
                Tags =
{
},
            };
            ArmOperation<CassandraTableResource> lro = await cassandraTable.UpdateAsync(WaitUntil.Completed, content);
            CassandraTableResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CassandraTableData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBCassandraTableDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_CosmosDBCassandraTableDelete()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBCassandraTableDelete.json
            // this example is just showing the usage of "CassandraResources_DeleteCassandraTable" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraTableResource created on azure
            // for more information of creating CassandraTableResource, please refer to the document of CassandraTableResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string keyspaceName = "keyspaceName";
            string tableName = "tableName";
            ResourceIdentifier cassandraTableResourceId = CassandraTableResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, keyspaceName, tableName);
            CassandraTableResource cassandraTable = client.GetCassandraTableResource(cassandraTableResourceId);

            // invoke the operation
            await cassandraTable.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
