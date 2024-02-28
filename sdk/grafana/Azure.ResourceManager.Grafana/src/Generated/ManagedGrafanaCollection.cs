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

namespace Azure.ResourceManager.Grafana
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagedGrafanaResource"/> and their operations.
    /// Each <see cref="ManagedGrafanaResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="ManagedGrafanaCollection"/> instance call the GetManagedGrafanas method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class ManagedGrafanaCollection : ArmCollection, IEnumerable<ManagedGrafanaResource>, IAsyncEnumerable<ManagedGrafanaResource>
    {
        private readonly ClientDiagnostics _managedGrafanaGrafanaClientDiagnostics;
        private readonly GrafanaRestOperations _managedGrafanaGrafanaRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedGrafanaCollection"/> class for mocking. </summary>
        protected ManagedGrafanaCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedGrafanaCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedGrafanaCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedGrafanaGrafanaClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Grafana", ManagedGrafanaResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedGrafanaResource.ResourceType, out string managedGrafanaGrafanaApiVersion);
            _managedGrafanaGrafanaRestClient = new GrafanaRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedGrafanaGrafanaApiVersion);
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
        /// Create or update a workspace for Grafana resource. This API is idempotent, so user can either create a new grafana or update an existing grafana.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Grafana_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedGrafanaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="workspaceName"> The workspace name of Azure Managed Grafana. </param>
        /// <param name="data"> The <see cref="ManagedGrafanaData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedGrafanaResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string workspaceName, ManagedGrafanaData data, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _managedGrafanaGrafanaClientDiagnostics.CreateScope("ManagedGrafanaCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedGrafanaGrafanaRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new GrafanaArmOperation<ManagedGrafanaResource>(new ManagedGrafanaOperationSource(Client), _managedGrafanaGrafanaClientDiagnostics, Pipeline, _managedGrafanaGrafanaRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update a workspace for Grafana resource. This API is idempotent, so user can either create a new grafana or update an existing grafana.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Grafana_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedGrafanaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="workspaceName"> The workspace name of Azure Managed Grafana. </param>
        /// <param name="data"> The <see cref="ManagedGrafanaData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedGrafanaResource> CreateOrUpdate(WaitUntil waitUntil, string workspaceName, ManagedGrafanaData data, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _managedGrafanaGrafanaClientDiagnostics.CreateScope("ManagedGrafanaCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedGrafanaGrafanaRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, data, cancellationToken);
                var operation = new GrafanaArmOperation<ManagedGrafanaResource>(new ManagedGrafanaOperationSource(Client), _managedGrafanaGrafanaClientDiagnostics, Pipeline, _managedGrafanaGrafanaRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get the properties of a specific workspace for Grafana resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Grafana_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedGrafanaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The workspace name of Azure Managed Grafana. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual async Task<Response<ManagedGrafanaResource>> GetAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }

            using var scope = _managedGrafanaGrafanaClientDiagnostics.CreateScope("ManagedGrafanaCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedGrafanaGrafanaRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedGrafanaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the properties of a specific workspace for Grafana resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Grafana_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedGrafanaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The workspace name of Azure Managed Grafana. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual Response<ManagedGrafanaResource> Get(string workspaceName, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }

            using var scope = _managedGrafanaGrafanaClientDiagnostics.CreateScope("ManagedGrafanaCollection.Get");
            scope.Start();
            try
            {
                var response = _managedGrafanaGrafanaRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedGrafanaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all resources of workspaces for Grafana under the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Grafana_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedGrafanaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedGrafanaResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedGrafanaResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedGrafanaGrafanaRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedGrafanaGrafanaRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ManagedGrafanaResource(Client, ManagedGrafanaData.DeserializeManagedGrafanaData(e)), _managedGrafanaGrafanaClientDiagnostics, Pipeline, "ManagedGrafanaCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all resources of workspaces for Grafana under the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Grafana_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedGrafanaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedGrafanaResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedGrafanaResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedGrafanaGrafanaRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedGrafanaGrafanaRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ManagedGrafanaResource(Client, ManagedGrafanaData.DeserializeManagedGrafanaData(e)), _managedGrafanaGrafanaClientDiagnostics, Pipeline, "ManagedGrafanaCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Grafana_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedGrafanaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The workspace name of Azure Managed Grafana. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }

            using var scope = _managedGrafanaGrafanaClientDiagnostics.CreateScope("ManagedGrafanaCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managedGrafanaGrafanaRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Grafana_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedGrafanaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The workspace name of Azure Managed Grafana. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual Response<bool> Exists(string workspaceName, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }

            using var scope = _managedGrafanaGrafanaClientDiagnostics.CreateScope("ManagedGrafanaCollection.Exists");
            scope.Start();
            try
            {
                var response = _managedGrafanaGrafanaRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Grafana_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedGrafanaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The workspace name of Azure Managed Grafana. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual async Task<NullableResponse<ManagedGrafanaResource>> GetIfExistsAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }

            using var scope = _managedGrafanaGrafanaClientDiagnostics.CreateScope("ManagedGrafanaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managedGrafanaGrafanaRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ManagedGrafanaResource>(response.GetRawResponse());
                return Response.FromValue(new ManagedGrafanaResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Grafana_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedGrafanaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The workspace name of Azure Managed Grafana. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual NullableResponse<ManagedGrafanaResource> GetIfExists(string workspaceName, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }

            using var scope = _managedGrafanaGrafanaClientDiagnostics.CreateScope("ManagedGrafanaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedGrafanaGrafanaRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ManagedGrafanaResource>(response.GetRawResponse());
                return Response.FromValue(new ManagedGrafanaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedGrafanaResource> IEnumerable<ManagedGrafanaResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedGrafanaResource> IAsyncEnumerable<ManagedGrafanaResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
