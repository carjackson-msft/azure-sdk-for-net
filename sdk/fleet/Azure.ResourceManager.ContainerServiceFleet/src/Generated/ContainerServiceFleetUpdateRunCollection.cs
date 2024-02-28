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

namespace Azure.ResourceManager.ContainerServiceFleet
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerServiceFleetUpdateRunResource"/> and their operations.
    /// Each <see cref="ContainerServiceFleetUpdateRunResource"/> in the collection will belong to the same instance of <see cref="ContainerServiceFleetResource"/>.
    /// To get a <see cref="ContainerServiceFleetUpdateRunCollection"/> instance call the GetContainerServiceFleetUpdateRuns method from an instance of <see cref="ContainerServiceFleetResource"/>.
    /// </summary>
    public partial class ContainerServiceFleetUpdateRunCollection : ArmCollection, IEnumerable<ContainerServiceFleetUpdateRunResource>, IAsyncEnumerable<ContainerServiceFleetUpdateRunResource>
    {
        private readonly ClientDiagnostics _containerServiceFleetUpdateRunUpdateRunsClientDiagnostics;
        private readonly UpdateRunsRestOperations _containerServiceFleetUpdateRunUpdateRunsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerServiceFleetUpdateRunCollection"/> class for mocking. </summary>
        protected ContainerServiceFleetUpdateRunCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerServiceFleetUpdateRunCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerServiceFleetUpdateRunCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerServiceFleetUpdateRunUpdateRunsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerServiceFleet", ContainerServiceFleetUpdateRunResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerServiceFleetUpdateRunResource.ResourceType, out string containerServiceFleetUpdateRunUpdateRunsApiVersion);
            _containerServiceFleetUpdateRunUpdateRunsRestClient = new UpdateRunsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerServiceFleetUpdateRunUpdateRunsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerServiceFleetResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerServiceFleetResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a UpdateRun
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateRuns/{updateRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateRuns_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetUpdateRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="updateRunName"> The name of the UpdateRun resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="ifMatch"> The request should only proceed if an entity matches this string. </param>
        /// <param name="ifNoneMatch"> The request should only proceed if no entity matches this string. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateRunName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerServiceFleetUpdateRunResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string updateRunName, ContainerServiceFleetUpdateRunData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (updateRunName == null)
            {
                throw new ArgumentNullException(nameof(updateRunName));
            }
            if (updateRunName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(updateRunName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _containerServiceFleetUpdateRunUpdateRunsClientDiagnostics.CreateScope("ContainerServiceFleetUpdateRunCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerServiceFleetUpdateRunUpdateRunsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateRunName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerServiceFleetArmOperation<ContainerServiceFleetUpdateRunResource>(new ContainerServiceFleetUpdateRunOperationSource(Client), _containerServiceFleetUpdateRunUpdateRunsClientDiagnostics, Pipeline, _containerServiceFleetUpdateRunUpdateRunsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateRunName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.AzureAsyncOperation, apiVersionOverrideValue: "2016-03-30");
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
        /// Create a UpdateRun
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateRuns/{updateRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateRuns_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetUpdateRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="updateRunName"> The name of the UpdateRun resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="ifMatch"> The request should only proceed if an entity matches this string. </param>
        /// <param name="ifNoneMatch"> The request should only proceed if no entity matches this string. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateRunName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerServiceFleetUpdateRunResource> CreateOrUpdate(WaitUntil waitUntil, string updateRunName, ContainerServiceFleetUpdateRunData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (updateRunName == null)
            {
                throw new ArgumentNullException(nameof(updateRunName));
            }
            if (updateRunName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(updateRunName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _containerServiceFleetUpdateRunUpdateRunsClientDiagnostics.CreateScope("ContainerServiceFleetUpdateRunCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerServiceFleetUpdateRunUpdateRunsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateRunName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new ContainerServiceFleetArmOperation<ContainerServiceFleetUpdateRunResource>(new ContainerServiceFleetUpdateRunOperationSource(Client), _containerServiceFleetUpdateRunUpdateRunsClientDiagnostics, Pipeline, _containerServiceFleetUpdateRunUpdateRunsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateRunName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.AzureAsyncOperation, apiVersionOverrideValue: "2016-03-30");
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
        /// Get a UpdateRun
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateRuns/{updateRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateRuns_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetUpdateRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateRunName"> The name of the UpdateRun resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateRunName"/> is null. </exception>
        public virtual async Task<Response<ContainerServiceFleetUpdateRunResource>> GetAsync(string updateRunName, CancellationToken cancellationToken = default)
        {
            if (updateRunName == null)
            {
                throw new ArgumentNullException(nameof(updateRunName));
            }
            if (updateRunName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(updateRunName));
            }

            using var scope = _containerServiceFleetUpdateRunUpdateRunsClientDiagnostics.CreateScope("ContainerServiceFleetUpdateRunCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerServiceFleetUpdateRunUpdateRunsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateRunName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceFleetUpdateRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a UpdateRun
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateRuns/{updateRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateRuns_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetUpdateRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateRunName"> The name of the UpdateRun resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateRunName"/> is null. </exception>
        public virtual Response<ContainerServiceFleetUpdateRunResource> Get(string updateRunName, CancellationToken cancellationToken = default)
        {
            if (updateRunName == null)
            {
                throw new ArgumentNullException(nameof(updateRunName));
            }
            if (updateRunName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(updateRunName));
            }

            using var scope = _containerServiceFleetUpdateRunUpdateRunsClientDiagnostics.CreateScope("ContainerServiceFleetUpdateRunCollection.Get");
            scope.Start();
            try
            {
                var response = _containerServiceFleetUpdateRunUpdateRunsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateRunName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceFleetUpdateRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List UpdateRun resources by Fleet
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateRuns</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateRuns_ListByFleet</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetUpdateRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerServiceFleetUpdateRunResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerServiceFleetUpdateRunResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerServiceFleetUpdateRunUpdateRunsRestClient.CreateListByFleetRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerServiceFleetUpdateRunUpdateRunsRestClient.CreateListByFleetNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerServiceFleetUpdateRunResource(Client, ContainerServiceFleetUpdateRunData.DeserializeContainerServiceFleetUpdateRunData(e)), _containerServiceFleetUpdateRunUpdateRunsClientDiagnostics, Pipeline, "ContainerServiceFleetUpdateRunCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List UpdateRun resources by Fleet
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateRuns</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateRuns_ListByFleet</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetUpdateRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerServiceFleetUpdateRunResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerServiceFleetUpdateRunResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerServiceFleetUpdateRunUpdateRunsRestClient.CreateListByFleetRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerServiceFleetUpdateRunUpdateRunsRestClient.CreateListByFleetNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerServiceFleetUpdateRunResource(Client, ContainerServiceFleetUpdateRunData.DeserializeContainerServiceFleetUpdateRunData(e)), _containerServiceFleetUpdateRunUpdateRunsClientDiagnostics, Pipeline, "ContainerServiceFleetUpdateRunCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateRuns/{updateRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateRuns_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetUpdateRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateRunName"> The name of the UpdateRun resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateRunName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string updateRunName, CancellationToken cancellationToken = default)
        {
            if (updateRunName == null)
            {
                throw new ArgumentNullException(nameof(updateRunName));
            }
            if (updateRunName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(updateRunName));
            }

            using var scope = _containerServiceFleetUpdateRunUpdateRunsClientDiagnostics.CreateScope("ContainerServiceFleetUpdateRunCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerServiceFleetUpdateRunUpdateRunsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateRunName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateRuns/{updateRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateRuns_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetUpdateRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateRunName"> The name of the UpdateRun resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateRunName"/> is null. </exception>
        public virtual Response<bool> Exists(string updateRunName, CancellationToken cancellationToken = default)
        {
            if (updateRunName == null)
            {
                throw new ArgumentNullException(nameof(updateRunName));
            }
            if (updateRunName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(updateRunName));
            }

            using var scope = _containerServiceFleetUpdateRunUpdateRunsClientDiagnostics.CreateScope("ContainerServiceFleetUpdateRunCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerServiceFleetUpdateRunUpdateRunsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateRunName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateRuns/{updateRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateRuns_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetUpdateRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateRunName"> The name of the UpdateRun resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateRunName"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerServiceFleetUpdateRunResource>> GetIfExistsAsync(string updateRunName, CancellationToken cancellationToken = default)
        {
            if (updateRunName == null)
            {
                throw new ArgumentNullException(nameof(updateRunName));
            }
            if (updateRunName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(updateRunName));
            }

            using var scope = _containerServiceFleetUpdateRunUpdateRunsClientDiagnostics.CreateScope("ContainerServiceFleetUpdateRunCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerServiceFleetUpdateRunUpdateRunsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateRunName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerServiceFleetUpdateRunResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceFleetUpdateRunResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateRuns/{updateRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateRuns_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceFleetUpdateRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateRunName"> The name of the UpdateRun resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateRunName"/> is null. </exception>
        public virtual NullableResponse<ContainerServiceFleetUpdateRunResource> GetIfExists(string updateRunName, CancellationToken cancellationToken = default)
        {
            if (updateRunName == null)
            {
                throw new ArgumentNullException(nameof(updateRunName));
            }
            if (updateRunName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(updateRunName));
            }

            using var scope = _containerServiceFleetUpdateRunUpdateRunsClientDiagnostics.CreateScope("ContainerServiceFleetUpdateRunCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerServiceFleetUpdateRunUpdateRunsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateRunName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerServiceFleetUpdateRunResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceFleetUpdateRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerServiceFleetUpdateRunResource> IEnumerable<ContainerServiceFleetUpdateRunResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerServiceFleetUpdateRunResource> IAsyncEnumerable<ContainerServiceFleetUpdateRunResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
