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

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="MachineLearningRegistryCodeContainerResource"/> and their operations.
    /// Each <see cref="MachineLearningRegistryCodeContainerResource"/> in the collection will belong to the same instance of <see cref="MachineLearningRegistryResource"/>.
    /// To get a <see cref="MachineLearningRegistryCodeContainerCollection"/> instance call the GetMachineLearningRegistryCodeContainers method from an instance of <see cref="MachineLearningRegistryResource"/>.
    /// </summary>
    public partial class MachineLearningRegistryCodeContainerCollection : ArmCollection, IEnumerable<MachineLearningRegistryCodeContainerResource>, IAsyncEnumerable<MachineLearningRegistryCodeContainerResource>
    {
        private readonly ClientDiagnostics _machineLearningRegistryCodeContainerRegistryCodeContainersClientDiagnostics;
        private readonly RegistryCodeContainersRestOperations _machineLearningRegistryCodeContainerRegistryCodeContainersRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningRegistryCodeContainerCollection"/> class for mocking. </summary>
        protected MachineLearningRegistryCodeContainerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningRegistryCodeContainerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineLearningRegistryCodeContainerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningRegistryCodeContainerRegistryCodeContainersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearningRegistryCodeContainerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MachineLearningRegistryCodeContainerResource.ResourceType, out string machineLearningRegistryCodeContainerRegistryCodeContainersApiVersion);
            _machineLearningRegistryCodeContainerRegistryCodeContainersRestClient = new RegistryCodeContainersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningRegistryCodeContainerRegistryCodeContainersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningRegistryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningRegistryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update Code container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/codes/{codeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryCodeContainers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryCodeContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="codeName"> Container name. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="codeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="codeName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningRegistryCodeContainerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string codeName, MachineLearningCodeContainerData data, CancellationToken cancellationToken = default)
        {
            if (codeName == null)
            {
                throw new ArgumentNullException(nameof(codeName));
            }
            if (codeName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(codeName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _machineLearningRegistryCodeContainerRegistryCodeContainersClientDiagnostics.CreateScope("MachineLearningRegistryCodeContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryCodeContainerRegistryCodeContainersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, codeName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<MachineLearningRegistryCodeContainerResource>(new MachineLearningRegistryCodeContainerOperationSource(Client), _machineLearningRegistryCodeContainerRegistryCodeContainersClientDiagnostics, Pipeline, _machineLearningRegistryCodeContainerRegistryCodeContainersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, codeName, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Create or update Code container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/codes/{codeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryCodeContainers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryCodeContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="codeName"> Container name. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="codeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="codeName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningRegistryCodeContainerResource> CreateOrUpdate(WaitUntil waitUntil, string codeName, MachineLearningCodeContainerData data, CancellationToken cancellationToken = default)
        {
            if (codeName == null)
            {
                throw new ArgumentNullException(nameof(codeName));
            }
            if (codeName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(codeName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _machineLearningRegistryCodeContainerRegistryCodeContainersClientDiagnostics.CreateScope("MachineLearningRegistryCodeContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryCodeContainerRegistryCodeContainersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, codeName, data, cancellationToken);
                var operation = new MachineLearningArmOperation<MachineLearningRegistryCodeContainerResource>(new MachineLearningRegistryCodeContainerOperationSource(Client), _machineLearningRegistryCodeContainerRegistryCodeContainersClientDiagnostics, Pipeline, _machineLearningRegistryCodeContainerRegistryCodeContainersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, codeName, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Get Code container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/codes/{codeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryCodeContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryCodeContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="codeName"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="codeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="codeName"/> is null. </exception>
        public virtual async Task<Response<MachineLearningRegistryCodeContainerResource>> GetAsync(string codeName, CancellationToken cancellationToken = default)
        {
            if (codeName == null)
            {
                throw new ArgumentNullException(nameof(codeName));
            }
            if (codeName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(codeName));
            }

            using var scope = _machineLearningRegistryCodeContainerRegistryCodeContainersClientDiagnostics.CreateScope("MachineLearningRegistryCodeContainerCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryCodeContainerRegistryCodeContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, codeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryCodeContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Code container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/codes/{codeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryCodeContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryCodeContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="codeName"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="codeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="codeName"/> is null. </exception>
        public virtual Response<MachineLearningRegistryCodeContainerResource> Get(string codeName, CancellationToken cancellationToken = default)
        {
            if (codeName == null)
            {
                throw new ArgumentNullException(nameof(codeName));
            }
            if (codeName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(codeName));
            }

            using var scope = _machineLearningRegistryCodeContainerRegistryCodeContainersClientDiagnostics.CreateScope("MachineLearningRegistryCodeContainerCollection.Get");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryCodeContainerRegistryCodeContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, codeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryCodeContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List containers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/codes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryCodeContainers_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryCodeContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningRegistryCodeContainerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningRegistryCodeContainerResource> GetAllAsync(string skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningRegistryCodeContainerRegistryCodeContainersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningRegistryCodeContainerRegistryCodeContainersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MachineLearningRegistryCodeContainerResource(Client, MachineLearningCodeContainerData.DeserializeMachineLearningCodeContainerData(e)), _machineLearningRegistryCodeContainerRegistryCodeContainersClientDiagnostics, Pipeline, "MachineLearningRegistryCodeContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List containers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/codes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryCodeContainers_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryCodeContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningRegistryCodeContainerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningRegistryCodeContainerResource> GetAll(string skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningRegistryCodeContainerRegistryCodeContainersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningRegistryCodeContainerRegistryCodeContainersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MachineLearningRegistryCodeContainerResource(Client, MachineLearningCodeContainerData.DeserializeMachineLearningCodeContainerData(e)), _machineLearningRegistryCodeContainerRegistryCodeContainersClientDiagnostics, Pipeline, "MachineLearningRegistryCodeContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/codes/{codeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryCodeContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryCodeContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="codeName"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="codeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="codeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string codeName, CancellationToken cancellationToken = default)
        {
            if (codeName == null)
            {
                throw new ArgumentNullException(nameof(codeName));
            }
            if (codeName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(codeName));
            }

            using var scope = _machineLearningRegistryCodeContainerRegistryCodeContainersClientDiagnostics.CreateScope("MachineLearningRegistryCodeContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryCodeContainerRegistryCodeContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, codeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/codes/{codeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryCodeContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryCodeContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="codeName"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="codeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="codeName"/> is null. </exception>
        public virtual Response<bool> Exists(string codeName, CancellationToken cancellationToken = default)
        {
            if (codeName == null)
            {
                throw new ArgumentNullException(nameof(codeName));
            }
            if (codeName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(codeName));
            }

            using var scope = _machineLearningRegistryCodeContainerRegistryCodeContainersClientDiagnostics.CreateScope("MachineLearningRegistryCodeContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryCodeContainerRegistryCodeContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, codeName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/codes/{codeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryCodeContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryCodeContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="codeName"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="codeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="codeName"/> is null. </exception>
        public virtual async Task<NullableResponse<MachineLearningRegistryCodeContainerResource>> GetIfExistsAsync(string codeName, CancellationToken cancellationToken = default)
        {
            if (codeName == null)
            {
                throw new ArgumentNullException(nameof(codeName));
            }
            if (codeName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(codeName));
            }

            using var scope = _machineLearningRegistryCodeContainerRegistryCodeContainersClientDiagnostics.CreateScope("MachineLearningRegistryCodeContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryCodeContainerRegistryCodeContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, codeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningRegistryCodeContainerResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryCodeContainerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/codes/{codeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryCodeContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryCodeContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="codeName"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="codeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="codeName"/> is null. </exception>
        public virtual NullableResponse<MachineLearningRegistryCodeContainerResource> GetIfExists(string codeName, CancellationToken cancellationToken = default)
        {
            if (codeName == null)
            {
                throw new ArgumentNullException(nameof(codeName));
            }
            if (codeName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(codeName));
            }

            using var scope = _machineLearningRegistryCodeContainerRegistryCodeContainersClientDiagnostics.CreateScope("MachineLearningRegistryCodeContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryCodeContainerRegistryCodeContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, codeName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningRegistryCodeContainerResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryCodeContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineLearningRegistryCodeContainerResource> IEnumerable<MachineLearningRegistryCodeContainerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MachineLearningRegistryCodeContainerResource> IAsyncEnumerable<MachineLearningRegistryCodeContainerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
