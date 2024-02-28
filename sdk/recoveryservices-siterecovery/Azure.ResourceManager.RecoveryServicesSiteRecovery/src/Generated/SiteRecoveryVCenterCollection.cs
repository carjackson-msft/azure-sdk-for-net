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
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteRecoveryVCenterResource"/> and their operations.
    /// Each <see cref="SiteRecoveryVCenterResource"/> in the collection will belong to the same instance of <see cref="SiteRecoveryFabricResource"/>.
    /// To get a <see cref="SiteRecoveryVCenterCollection"/> instance call the GetSiteRecoveryVCenters method from an instance of <see cref="SiteRecoveryFabricResource"/>.
    /// </summary>
    public partial class SiteRecoveryVCenterCollection : ArmCollection, IEnumerable<SiteRecoveryVCenterResource>, IAsyncEnumerable<SiteRecoveryVCenterResource>
    {
        private readonly ClientDiagnostics _siteRecoveryVCenterReplicationvCentersClientDiagnostics;
        private readonly ReplicationvCentersRestOperations _siteRecoveryVCenterReplicationvCentersRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryVCenterCollection"/> class for mocking. </summary>
        protected SiteRecoveryVCenterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryVCenterCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteRecoveryVCenterCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteRecoveryVCenterReplicationvCentersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", SiteRecoveryVCenterResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteRecoveryVCenterResource.ResourceType, out string siteRecoveryVCenterReplicationvCentersApiVersion);
            _siteRecoveryVCenterReplicationvCentersRestClient = new ReplicationvCentersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteRecoveryVCenterReplicationvCentersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteRecoveryFabricResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteRecoveryFabricResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create a vCenter object..
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationvCenters/{vcenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationvCenters_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryVCenterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vCenterName"> vcenter name. </param>
        /// <param name="content"> The input to the add vCenter operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vCenterName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteRecoveryVCenterResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string vCenterName, SiteRecoveryVCenterCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            if (vCenterName == null)
            {
                throw new ArgumentNullException(nameof(vCenterName));
            }
            if (vCenterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vCenterName));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = _siteRecoveryVCenterReplicationvCentersClientDiagnostics.CreateScope("SiteRecoveryVCenterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteRecoveryVCenterReplicationvCentersRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vCenterName, content, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<SiteRecoveryVCenterResource>(new SiteRecoveryVCenterOperationSource(Client), _siteRecoveryVCenterReplicationvCentersClientDiagnostics, Pipeline, _siteRecoveryVCenterReplicationvCentersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vCenterName, content).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to create a vCenter object..
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationvCenters/{vcenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationvCenters_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryVCenterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vCenterName"> vcenter name. </param>
        /// <param name="content"> The input to the add vCenter operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vCenterName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<SiteRecoveryVCenterResource> CreateOrUpdate(WaitUntil waitUntil, string vCenterName, SiteRecoveryVCenterCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            if (vCenterName == null)
            {
                throw new ArgumentNullException(nameof(vCenterName));
            }
            if (vCenterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vCenterName));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = _siteRecoveryVCenterReplicationvCentersClientDiagnostics.CreateScope("SiteRecoveryVCenterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteRecoveryVCenterReplicationvCentersRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vCenterName, content, cancellationToken);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<SiteRecoveryVCenterResource>(new SiteRecoveryVCenterOperationSource(Client), _siteRecoveryVCenterReplicationvCentersClientDiagnostics, Pipeline, _siteRecoveryVCenterReplicationvCentersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vCenterName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the details of a registered vCenter server(Add vCenter server).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationvCenters/{vcenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationvCenters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryVCenterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vCenterName"> vcenter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vCenterName"/> is null. </exception>
        public virtual async Task<Response<SiteRecoveryVCenterResource>> GetAsync(string vCenterName, CancellationToken cancellationToken = default)
        {
            if (vCenterName == null)
            {
                throw new ArgumentNullException(nameof(vCenterName));
            }
            if (vCenterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vCenterName));
            }

            using var scope = _siteRecoveryVCenterReplicationvCentersClientDiagnostics.CreateScope("SiteRecoveryVCenterCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteRecoveryVCenterReplicationvCentersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vCenterName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryVCenterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of a registered vCenter server(Add vCenter server).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationvCenters/{vcenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationvCenters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryVCenterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vCenterName"> vcenter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vCenterName"/> is null. </exception>
        public virtual Response<SiteRecoveryVCenterResource> Get(string vCenterName, CancellationToken cancellationToken = default)
        {
            if (vCenterName == null)
            {
                throw new ArgumentNullException(nameof(vCenterName));
            }
            if (vCenterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vCenterName));
            }

            using var scope = _siteRecoveryVCenterReplicationvCentersClientDiagnostics.CreateScope("SiteRecoveryVCenterCollection.Get");
            scope.Start();
            try
            {
                var response = _siteRecoveryVCenterReplicationvCentersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vCenterName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryVCenterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the vCenter servers registered in a fabric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationvCenters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationvCenters_ListByReplicationFabrics</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryVCenterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteRecoveryVCenterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteRecoveryVCenterResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteRecoveryVCenterReplicationvCentersRestClient.CreateListByReplicationFabricsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteRecoveryVCenterReplicationvCentersRestClient.CreateListByReplicationFabricsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteRecoveryVCenterResource(Client, SiteRecoveryVCenterData.DeserializeSiteRecoveryVCenterData(e)), _siteRecoveryVCenterReplicationvCentersClientDiagnostics, Pipeline, "SiteRecoveryVCenterCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the vCenter servers registered in a fabric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationvCenters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationvCenters_ListByReplicationFabrics</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryVCenterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteRecoveryVCenterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteRecoveryVCenterResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteRecoveryVCenterReplicationvCentersRestClient.CreateListByReplicationFabricsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteRecoveryVCenterReplicationvCentersRestClient.CreateListByReplicationFabricsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteRecoveryVCenterResource(Client, SiteRecoveryVCenterData.DeserializeSiteRecoveryVCenterData(e)), _siteRecoveryVCenterReplicationvCentersClientDiagnostics, Pipeline, "SiteRecoveryVCenterCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationvCenters/{vcenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationvCenters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryVCenterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vCenterName"> vcenter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vCenterName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vCenterName, CancellationToken cancellationToken = default)
        {
            if (vCenterName == null)
            {
                throw new ArgumentNullException(nameof(vCenterName));
            }
            if (vCenterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vCenterName));
            }

            using var scope = _siteRecoveryVCenterReplicationvCentersClientDiagnostics.CreateScope("SiteRecoveryVCenterCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteRecoveryVCenterReplicationvCentersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vCenterName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationvCenters/{vcenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationvCenters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryVCenterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vCenterName"> vcenter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vCenterName"/> is null. </exception>
        public virtual Response<bool> Exists(string vCenterName, CancellationToken cancellationToken = default)
        {
            if (vCenterName == null)
            {
                throw new ArgumentNullException(nameof(vCenterName));
            }
            if (vCenterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vCenterName));
            }

            using var scope = _siteRecoveryVCenterReplicationvCentersClientDiagnostics.CreateScope("SiteRecoveryVCenterCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteRecoveryVCenterReplicationvCentersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vCenterName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationvCenters/{vcenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationvCenters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryVCenterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vCenterName"> vcenter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vCenterName"/> is null. </exception>
        public virtual async Task<NullableResponse<SiteRecoveryVCenterResource>> GetIfExistsAsync(string vCenterName, CancellationToken cancellationToken = default)
        {
            if (vCenterName == null)
            {
                throw new ArgumentNullException(nameof(vCenterName));
            }
            if (vCenterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vCenterName));
            }

            using var scope = _siteRecoveryVCenterReplicationvCentersClientDiagnostics.CreateScope("SiteRecoveryVCenterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteRecoveryVCenterReplicationvCentersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vCenterName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SiteRecoveryVCenterResource>(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryVCenterResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationvCenters/{vcenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationvCenters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryVCenterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vCenterName"> vcenter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vCenterName"/> is null. </exception>
        public virtual NullableResponse<SiteRecoveryVCenterResource> GetIfExists(string vCenterName, CancellationToken cancellationToken = default)
        {
            if (vCenterName == null)
            {
                throw new ArgumentNullException(nameof(vCenterName));
            }
            if (vCenterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vCenterName));
            }

            using var scope = _siteRecoveryVCenterReplicationvCentersClientDiagnostics.CreateScope("SiteRecoveryVCenterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteRecoveryVCenterReplicationvCentersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vCenterName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SiteRecoveryVCenterResource>(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryVCenterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteRecoveryVCenterResource> IEnumerable<SiteRecoveryVCenterResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteRecoveryVCenterResource> IAsyncEnumerable<SiteRecoveryVCenterResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
