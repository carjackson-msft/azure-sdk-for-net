// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="MongoClusterResource"/> and their operations.
    /// Each <see cref="MongoClusterResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="MongoClusterCollection"/> instance call the GetMongoClusters method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class MongoClusterCollection : ArmCollection, IEnumerable<MongoClusterResource>, IAsyncEnumerable<MongoClusterResource>
    {
        private readonly ClientDiagnostics _mongoClusterClientDiagnostics;
        private readonly MongoClustersRestOperations _mongoClusterRestClient;

        /// <summary> Initializes a new instance of the <see cref="MongoClusterCollection"/> class for mocking. </summary>
        protected MongoClusterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MongoClusterCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MongoClusterCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mongoClusterClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", MongoClusterResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MongoClusterResource.ResourceType, out string mongoClusterApiVersion);
            _mongoClusterRestClient = new MongoClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mongoClusterApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a mongo cluster. Update overwrites all properties for the resource. To only modify some of the properties, use PATCH.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters/{mongoClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoClusters_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="mongoClusterName"> The name of the mongo cluster. </param>
        /// <param name="data"> The required parameters for creating or updating a mongo cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoClusterName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MongoClusterResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string mongoClusterName, MongoClusterData data, CancellationToken cancellationToken = default)
        {
            if (mongoClusterName == null)
            {
                throw new ArgumentNullException(nameof(mongoClusterName));
            }
            if (mongoClusterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(mongoClusterName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _mongoClusterClientDiagnostics.CreateScope("MongoClusterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mongoClusterRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, mongoClusterName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<MongoClusterResource>(new MongoClusterOperationSource(Client), _mongoClusterClientDiagnostics, Pipeline, _mongoClusterRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, mongoClusterName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update a mongo cluster. Update overwrites all properties for the resource. To only modify some of the properties, use PATCH.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters/{mongoClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoClusters_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="mongoClusterName"> The name of the mongo cluster. </param>
        /// <param name="data"> The required parameters for creating or updating a mongo cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoClusterName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MongoClusterResource> CreateOrUpdate(WaitUntil waitUntil, string mongoClusterName, MongoClusterData data, CancellationToken cancellationToken = default)
        {
            if (mongoClusterName == null)
            {
                throw new ArgumentNullException(nameof(mongoClusterName));
            }
            if (mongoClusterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(mongoClusterName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _mongoClusterClientDiagnostics.CreateScope("MongoClusterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mongoClusterRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, mongoClusterName, data, cancellationToken);
                var operation = new CosmosDBArmOperation<MongoClusterResource>(new MongoClusterOperationSource(Client), _mongoClusterClientDiagnostics, Pipeline, _mongoClusterRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, mongoClusterName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about a mongo cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters/{mongoClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mongoClusterName"> The name of the mongo cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoClusterName"/> is null. </exception>
        public virtual async Task<Response<MongoClusterResource>> GetAsync(string mongoClusterName, CancellationToken cancellationToken = default)
        {
            if (mongoClusterName == null)
            {
                throw new ArgumentNullException(nameof(mongoClusterName));
            }
            if (mongoClusterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(mongoClusterName));
            }

            using var scope = _mongoClusterClientDiagnostics.CreateScope("MongoClusterCollection.Get");
            scope.Start();
            try
            {
                var response = await _mongoClusterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, mongoClusterName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MongoClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a mongo cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters/{mongoClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mongoClusterName"> The name of the mongo cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoClusterName"/> is null. </exception>
        public virtual Response<MongoClusterResource> Get(string mongoClusterName, CancellationToken cancellationToken = default)
        {
            if (mongoClusterName == null)
            {
                throw new ArgumentNullException(nameof(mongoClusterName));
            }
            if (mongoClusterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(mongoClusterName));
            }

            using var scope = _mongoClusterClientDiagnostics.CreateScope("MongoClusterCollection.Get");
            scope.Start();
            try
            {
                var response = _mongoClusterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, mongoClusterName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MongoClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the mongo clusters in a given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoClusters_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MongoClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MongoClusterResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mongoClusterRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mongoClusterRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MongoClusterResource(Client, MongoClusterData.DeserializeMongoClusterData(e)), _mongoClusterClientDiagnostics, Pipeline, "MongoClusterCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the mongo clusters in a given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoClusters_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MongoClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MongoClusterResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mongoClusterRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mongoClusterRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MongoClusterResource(Client, MongoClusterData.DeserializeMongoClusterData(e)), _mongoClusterClientDiagnostics, Pipeline, "MongoClusterCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters/{mongoClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mongoClusterName"> The name of the mongo cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoClusterName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string mongoClusterName, CancellationToken cancellationToken = default)
        {
            if (mongoClusterName == null)
            {
                throw new ArgumentNullException(nameof(mongoClusterName));
            }
            if (mongoClusterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(mongoClusterName));
            }

            using var scope = _mongoClusterClientDiagnostics.CreateScope("MongoClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mongoClusterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, mongoClusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters/{mongoClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mongoClusterName"> The name of the mongo cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoClusterName"/> is null. </exception>
        public virtual Response<bool> Exists(string mongoClusterName, CancellationToken cancellationToken = default)
        {
            if (mongoClusterName == null)
            {
                throw new ArgumentNullException(nameof(mongoClusterName));
            }
            if (mongoClusterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(mongoClusterName));
            }

            using var scope = _mongoClusterClientDiagnostics.CreateScope("MongoClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = _mongoClusterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, mongoClusterName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters/{mongoClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mongoClusterName"> The name of the mongo cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoClusterName"/> is null. </exception>
        public virtual async Task<NullableResponse<MongoClusterResource>> GetIfExistsAsync(string mongoClusterName, CancellationToken cancellationToken = default)
        {
            if (mongoClusterName == null)
            {
                throw new ArgumentNullException(nameof(mongoClusterName));
            }
            if (mongoClusterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(mongoClusterName));
            }

            using var scope = _mongoClusterClientDiagnostics.CreateScope("MongoClusterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mongoClusterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, mongoClusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MongoClusterResource>(response.GetRawResponse());
                return Response.FromValue(new MongoClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters/{mongoClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mongoClusterName"> The name of the mongo cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoClusterName"/> is null. </exception>
        public virtual NullableResponse<MongoClusterResource> GetIfExists(string mongoClusterName, CancellationToken cancellationToken = default)
        {
            if (mongoClusterName == null)
            {
                throw new ArgumentNullException(nameof(mongoClusterName));
            }
            if (mongoClusterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(mongoClusterName));
            }

            using var scope = _mongoClusterClientDiagnostics.CreateScope("MongoClusterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mongoClusterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, mongoClusterName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MongoClusterResource>(response.GetRawResponse());
                return Response.FromValue(new MongoClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MongoClusterResource> IEnumerable<MongoClusterResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MongoClusterResource> IAsyncEnumerable<MongoClusterResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
