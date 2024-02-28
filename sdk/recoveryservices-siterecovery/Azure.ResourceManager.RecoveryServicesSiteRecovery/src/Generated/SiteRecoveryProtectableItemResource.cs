// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A Class representing a SiteRecoveryProtectableItem along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SiteRecoveryProtectableItemResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSiteRecoveryProtectableItemResource method.
    /// Otherwise you can get one from its parent resource <see cref="SiteRecoveryProtectionContainerResource"/> using the GetSiteRecoveryProtectableItem method.
    /// </summary>
    public partial class SiteRecoveryProtectableItemResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteRecoveryProtectableItemResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="resourceName"> The resourceName. </param>
        /// <param name="fabricName"> The fabricName. </param>
        /// <param name="protectionContainerName"> The protectionContainerName. </param>
        /// <param name="protectableItemName"> The protectableItemName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string protectableItemName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectableItems/{protectableItemName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteRecoveryProtectableItemReplicationProtectableItemsClientDiagnostics;
        private readonly ReplicationProtectableItemsRestOperations _siteRecoveryProtectableItemReplicationProtectableItemsRestClient;
        private readonly SiteRecoveryProtectableItemData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.RecoveryServices/vaults/replicationFabrics/replicationProtectionContainers/replicationProtectableItems";

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryProtectableItemResource"/> class for mocking. </summary>
        protected SiteRecoveryProtectableItemResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryProtectableItemResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteRecoveryProtectableItemResource(ArmClient client, SiteRecoveryProtectableItemData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryProtectableItemResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteRecoveryProtectableItemResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteRecoveryProtectableItemReplicationProtectableItemsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteRecoveryProtectableItemReplicationProtectableItemsApiVersion);
            _siteRecoveryProtectableItemReplicationProtectableItemsRestClient = new ReplicationProtectableItemsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteRecoveryProtectableItemReplicationProtectableItemsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SiteRecoveryProtectableItemData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to get the details of a protectable item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectableItems/{protectableItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectableItems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryProtectableItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteRecoveryProtectableItemResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteRecoveryProtectableItemReplicationProtectableItemsClientDiagnostics.CreateScope("SiteRecoveryProtectableItemResource.Get");
            scope.Start();
            try
            {
                var response = await _siteRecoveryProtectableItemReplicationProtectableItemsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryProtectableItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the details of a protectable item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectableItems/{protectableItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectableItems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryProtectableItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteRecoveryProtectableItemResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteRecoveryProtectableItemReplicationProtectableItemsClientDiagnostics.CreateScope("SiteRecoveryProtectableItemResource.Get");
            scope.Start();
            try
            {
                var response = _siteRecoveryProtectableItemReplicationProtectableItemsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryProtectableItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
