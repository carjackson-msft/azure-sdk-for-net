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

namespace Azure.ResourceManager.ProviderHub
{
    /// <summary>
    /// A class representing a collection of <see cref="ResourceTypeRegistrationResource"/> and their operations.
    /// Each <see cref="ResourceTypeRegistrationResource"/> in the collection will belong to the same instance of <see cref="ProviderRegistrationResource"/>.
    /// To get a <see cref="ResourceTypeRegistrationCollection"/> instance call the GetResourceTypeRegistrations method from an instance of <see cref="ProviderRegistrationResource"/>.
    /// </summary>
    public partial class ResourceTypeRegistrationCollection : ArmCollection, IEnumerable<ResourceTypeRegistrationResource>, IAsyncEnumerable<ResourceTypeRegistrationResource>
    {
        private readonly ClientDiagnostics _resourceTypeRegistrationClientDiagnostics;
        private readonly ResourceTypeRegistrationsRestOperations _resourceTypeRegistrationRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceTypeRegistrationCollection"/> class for mocking. </summary>
        protected ResourceTypeRegistrationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceTypeRegistrationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ResourceTypeRegistrationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceTypeRegistrationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ProviderHub", ResourceTypeRegistrationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceTypeRegistrationResource.ResourceType, out string resourceTypeRegistrationApiVersion);
            _resourceTypeRegistrationRestClient = new ResourceTypeRegistrationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceTypeRegistrationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ProviderRegistrationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ProviderRegistrationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a resource type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceTypeRegistrations_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceTypeRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="data"> The required request body parameters supplied to the resource type registration CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceType"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ResourceTypeRegistrationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string resourceType, ResourceTypeRegistrationData data, CancellationToken cancellationToken = default)
        {
            if (resourceType == null)
            {
                throw new ArgumentNullException(nameof(resourceType));
            }
            if (resourceType.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceType));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _resourceTypeRegistrationClientDiagnostics.CreateScope("ResourceTypeRegistrationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _resourceTypeRegistrationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.Name, resourceType, data, cancellationToken).ConfigureAwait(false);
                var operation = new ProviderHubArmOperation<ResourceTypeRegistrationResource>(new ResourceTypeRegistrationOperationSource(Client), _resourceTypeRegistrationClientDiagnostics, Pipeline, _resourceTypeRegistrationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.Name, resourceType, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a resource type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceTypeRegistrations_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceTypeRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="data"> The required request body parameters supplied to the resource type registration CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceType"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ResourceTypeRegistrationResource> CreateOrUpdate(WaitUntil waitUntil, string resourceType, ResourceTypeRegistrationData data, CancellationToken cancellationToken = default)
        {
            if (resourceType == null)
            {
                throw new ArgumentNullException(nameof(resourceType));
            }
            if (resourceType.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceType));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _resourceTypeRegistrationClientDiagnostics.CreateScope("ResourceTypeRegistrationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _resourceTypeRegistrationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.Name, resourceType, data, cancellationToken);
                var operation = new ProviderHubArmOperation<ResourceTypeRegistrationResource>(new ResourceTypeRegistrationOperationSource(Client), _resourceTypeRegistrationClientDiagnostics, Pipeline, _resourceTypeRegistrationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.Name, resourceType, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets a resource type details in the given subscription and provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceTypeRegistrations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceTypeRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceType"/> is null. </exception>
        public virtual async Task<Response<ResourceTypeRegistrationResource>> GetAsync(string resourceType, CancellationToken cancellationToken = default)
        {
            if (resourceType == null)
            {
                throw new ArgumentNullException(nameof(resourceType));
            }
            if (resourceType.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceType));
            }

            using var scope = _resourceTypeRegistrationClientDiagnostics.CreateScope("ResourceTypeRegistrationCollection.Get");
            scope.Start();
            try
            {
                var response = await _resourceTypeRegistrationRestClient.GetAsync(Id.SubscriptionId, Id.Name, resourceType, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceTypeRegistrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a resource type details in the given subscription and provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceTypeRegistrations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceTypeRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceType"/> is null. </exception>
        public virtual Response<ResourceTypeRegistrationResource> Get(string resourceType, CancellationToken cancellationToken = default)
        {
            if (resourceType == null)
            {
                throw new ArgumentNullException(nameof(resourceType));
            }
            if (resourceType.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceType));
            }

            using var scope = _resourceTypeRegistrationClientDiagnostics.CreateScope("ResourceTypeRegistrationCollection.Get");
            scope.Start();
            try
            {
                var response = _resourceTypeRegistrationRestClient.Get(Id.SubscriptionId, Id.Name, resourceType, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceTypeRegistrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of the resource types for the given provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceTypeRegistrations_ListByProviderRegistration</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceTypeRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceTypeRegistrationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceTypeRegistrationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourceTypeRegistrationRestClient.CreateListByProviderRegistrationRequest(Id.SubscriptionId, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resourceTypeRegistrationRestClient.CreateListByProviderRegistrationNextPageRequest(nextLink, Id.SubscriptionId, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ResourceTypeRegistrationResource(Client, ResourceTypeRegistrationData.DeserializeResourceTypeRegistrationData(e)), _resourceTypeRegistrationClientDiagnostics, Pipeline, "ResourceTypeRegistrationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of the resource types for the given provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceTypeRegistrations_ListByProviderRegistration</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceTypeRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceTypeRegistrationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceTypeRegistrationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourceTypeRegistrationRestClient.CreateListByProviderRegistrationRequest(Id.SubscriptionId, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resourceTypeRegistrationRestClient.CreateListByProviderRegistrationNextPageRequest(nextLink, Id.SubscriptionId, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ResourceTypeRegistrationResource(Client, ResourceTypeRegistrationData.DeserializeResourceTypeRegistrationData(e)), _resourceTypeRegistrationClientDiagnostics, Pipeline, "ResourceTypeRegistrationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceTypeRegistrations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceTypeRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceType"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceType, CancellationToken cancellationToken = default)
        {
            if (resourceType == null)
            {
                throw new ArgumentNullException(nameof(resourceType));
            }
            if (resourceType.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceType));
            }

            using var scope = _resourceTypeRegistrationClientDiagnostics.CreateScope("ResourceTypeRegistrationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _resourceTypeRegistrationRestClient.GetAsync(Id.SubscriptionId, Id.Name, resourceType, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceTypeRegistrations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceTypeRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceType"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceType, CancellationToken cancellationToken = default)
        {
            if (resourceType == null)
            {
                throw new ArgumentNullException(nameof(resourceType));
            }
            if (resourceType.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceType));
            }

            using var scope = _resourceTypeRegistrationClientDiagnostics.CreateScope("ResourceTypeRegistrationCollection.Exists");
            scope.Start();
            try
            {
                var response = _resourceTypeRegistrationRestClient.Get(Id.SubscriptionId, Id.Name, resourceType, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceTypeRegistrations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceTypeRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceType"/> is null. </exception>
        public virtual async Task<NullableResponse<ResourceTypeRegistrationResource>> GetIfExistsAsync(string resourceType, CancellationToken cancellationToken = default)
        {
            if (resourceType == null)
            {
                throw new ArgumentNullException(nameof(resourceType));
            }
            if (resourceType.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceType));
            }

            using var scope = _resourceTypeRegistrationClientDiagnostics.CreateScope("ResourceTypeRegistrationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _resourceTypeRegistrationRestClient.GetAsync(Id.SubscriptionId, Id.Name, resourceType, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ResourceTypeRegistrationResource>(response.GetRawResponse());
                return Response.FromValue(new ResourceTypeRegistrationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceTypeRegistrations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceTypeRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceType"/> is null. </exception>
        public virtual NullableResponse<ResourceTypeRegistrationResource> GetIfExists(string resourceType, CancellationToken cancellationToken = default)
        {
            if (resourceType == null)
            {
                throw new ArgumentNullException(nameof(resourceType));
            }
            if (resourceType.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceType));
            }

            using var scope = _resourceTypeRegistrationClientDiagnostics.CreateScope("ResourceTypeRegistrationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _resourceTypeRegistrationRestClient.Get(Id.SubscriptionId, Id.Name, resourceType, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ResourceTypeRegistrationResource>(response.GetRawResponse());
                return Response.FromValue(new ResourceTypeRegistrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResourceTypeRegistrationResource> IEnumerable<ResourceTypeRegistrationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResourceTypeRegistrationResource> IAsyncEnumerable<ResourceTypeRegistrationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
