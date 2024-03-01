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

namespace Azure.ResourceManager.Sphere
{
    /// <summary>
    /// A class representing a collection of <see cref="SphereProductResource"/> and their operations.
    /// Each <see cref="SphereProductResource"/> in the collection will belong to the same instance of <see cref="SphereCatalogResource"/>.
    /// To get a <see cref="SphereProductCollection"/> instance call the GetSphereProducts method from an instance of <see cref="SphereCatalogResource"/>.
    /// </summary>
    public partial class SphereProductCollection : ArmCollection, IEnumerable<SphereProductResource>, IAsyncEnumerable<SphereProductResource>
    {
        private readonly ClientDiagnostics _sphereProductProductsClientDiagnostics;
        private readonly ProductsRestOperations _sphereProductProductsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SphereProductCollection"/> class for mocking. </summary>
        protected SphereProductCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SphereProductCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SphereProductCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sphereProductProductsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sphere", SphereProductResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SphereProductResource.ResourceType, out string sphereProductProductsApiVersion);
            _sphereProductProductsRestClient = new ProductsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sphereProductProductsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SphereCatalogResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SphereCatalogResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a Product. '.default' and '.unassigned' are system defined values and cannot be used for product name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Products_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereProductResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="productName"> Name of product. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="productName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="productName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SphereProductResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string productName, SphereProductData data, CancellationToken cancellationToken = default)
        {
            if (productName == null)
            {
                throw new ArgumentNullException(nameof(productName));
            }
            if (productName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(productName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _sphereProductProductsClientDiagnostics.CreateScope("SphereProductCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sphereProductProductsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, productName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SphereArmOperation<SphereProductResource>(new SphereProductOperationSource(Client), _sphereProductProductsClientDiagnostics, Pipeline, _sphereProductProductsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, productName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a Product. '.default' and '.unassigned' are system defined values and cannot be used for product name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Products_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereProductResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="productName"> Name of product. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="productName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="productName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SphereProductResource> CreateOrUpdate(WaitUntil waitUntil, string productName, SphereProductData data, CancellationToken cancellationToken = default)
        {
            if (productName == null)
            {
                throw new ArgumentNullException(nameof(productName));
            }
            if (productName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(productName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _sphereProductProductsClientDiagnostics.CreateScope("SphereProductCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sphereProductProductsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, productName, data, cancellationToken);
                var operation = new SphereArmOperation<SphereProductResource>(new SphereProductOperationSource(Client), _sphereProductProductsClientDiagnostics, Pipeline, _sphereProductProductsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, productName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a Product. '.default' and '.unassigned' are system defined values and cannot be used for product name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Products_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereProductResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="productName"> Name of product. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="productName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="productName"/> is null. </exception>
        public virtual async Task<Response<SphereProductResource>> GetAsync(string productName, CancellationToken cancellationToken = default)
        {
            if (productName == null)
            {
                throw new ArgumentNullException(nameof(productName));
            }
            if (productName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(productName));
            }

            using var scope = _sphereProductProductsClientDiagnostics.CreateScope("SphereProductCollection.Get");
            scope.Start();
            try
            {
                var response = await _sphereProductProductsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, productName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SphereProductResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Product. '.default' and '.unassigned' are system defined values and cannot be used for product name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Products_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereProductResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="productName"> Name of product. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="productName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="productName"/> is null. </exception>
        public virtual Response<SphereProductResource> Get(string productName, CancellationToken cancellationToken = default)
        {
            if (productName == null)
            {
                throw new ArgumentNullException(nameof(productName));
            }
            if (productName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(productName));
            }

            using var scope = _sphereProductProductsClientDiagnostics.CreateScope("SphereProductCollection.Get");
            scope.Start();
            try
            {
                var response = _sphereProductProductsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, productName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SphereProductResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Product resources by Catalog
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Products_ListByCatalog</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereProductResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SphereProductResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SphereProductResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sphereProductProductsRestClient.CreateListByCatalogRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sphereProductProductsRestClient.CreateListByCatalogNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SphereProductResource(Client, SphereProductData.DeserializeSphereProductData(e)), _sphereProductProductsClientDiagnostics, Pipeline, "SphereProductCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Product resources by Catalog
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Products_ListByCatalog</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereProductResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SphereProductResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SphereProductResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sphereProductProductsRestClient.CreateListByCatalogRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sphereProductProductsRestClient.CreateListByCatalogNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SphereProductResource(Client, SphereProductData.DeserializeSphereProductData(e)), _sphereProductProductsClientDiagnostics, Pipeline, "SphereProductCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Products_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereProductResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="productName"> Name of product. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="productName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="productName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string productName, CancellationToken cancellationToken = default)
        {
            if (productName == null)
            {
                throw new ArgumentNullException(nameof(productName));
            }
            if (productName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(productName));
            }

            using var scope = _sphereProductProductsClientDiagnostics.CreateScope("SphereProductCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sphereProductProductsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, productName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Products_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereProductResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="productName"> Name of product. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="productName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="productName"/> is null. </exception>
        public virtual Response<bool> Exists(string productName, CancellationToken cancellationToken = default)
        {
            if (productName == null)
            {
                throw new ArgumentNullException(nameof(productName));
            }
            if (productName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(productName));
            }

            using var scope = _sphereProductProductsClientDiagnostics.CreateScope("SphereProductCollection.Exists");
            scope.Start();
            try
            {
                var response = _sphereProductProductsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, productName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Products_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereProductResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="productName"> Name of product. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="productName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="productName"/> is null. </exception>
        public virtual async Task<NullableResponse<SphereProductResource>> GetIfExistsAsync(string productName, CancellationToken cancellationToken = default)
        {
            if (productName == null)
            {
                throw new ArgumentNullException(nameof(productName));
            }
            if (productName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(productName));
            }

            using var scope = _sphereProductProductsClientDiagnostics.CreateScope("SphereProductCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sphereProductProductsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, productName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SphereProductResource>(response.GetRawResponse());
                return Response.FromValue(new SphereProductResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Products_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereProductResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="productName"> Name of product. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="productName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="productName"/> is null. </exception>
        public virtual NullableResponse<SphereProductResource> GetIfExists(string productName, CancellationToken cancellationToken = default)
        {
            if (productName == null)
            {
                throw new ArgumentNullException(nameof(productName));
            }
            if (productName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(productName));
            }

            using var scope = _sphereProductProductsClientDiagnostics.CreateScope("SphereProductCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sphereProductProductsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, productName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SphereProductResource>(response.GetRawResponse());
                return Response.FromValue(new SphereProductResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SphereProductResource> IEnumerable<SphereProductResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SphereProductResource> IAsyncEnumerable<SphereProductResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
