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
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="GalleryImageVersionResource"/> and their operations.
    /// Each <see cref="GalleryImageVersionResource"/> in the collection will belong to the same instance of <see cref="GalleryImageResource"/>.
    /// To get a <see cref="GalleryImageVersionCollection"/> instance call the GetGalleryImageVersions method from an instance of <see cref="GalleryImageResource"/>.
    /// </summary>
    public partial class GalleryImageVersionCollection : ArmCollection, IEnumerable<GalleryImageVersionResource>, IAsyncEnumerable<GalleryImageVersionResource>
    {
        private readonly ClientDiagnostics _galleryImageVersionClientDiagnostics;
        private readonly GalleryImageVersionsRestOperations _galleryImageVersionRestClient;

        /// <summary> Initializes a new instance of the <see cref="GalleryImageVersionCollection"/> class for mocking. </summary>
        protected GalleryImageVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GalleryImageVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GalleryImageVersionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _galleryImageVersionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", GalleryImageVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GalleryImageVersionResource.ResourceType, out string galleryImageVersionApiVersion);
            _galleryImageVersionRestClient = new GalleryImageVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, galleryImageVersionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != GalleryImageResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, GalleryImageResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a gallery image version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}/versions/{galleryImageVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryImageVersions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryImageVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="data"> Parameters supplied to the create or update gallery image version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GalleryImageVersionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string galleryImageVersionName, GalleryImageVersionData data, CancellationToken cancellationToken = default)
        {
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }
            if (galleryImageVersionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(galleryImageVersionName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _galleryImageVersionClientDiagnostics.CreateScope("GalleryImageVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _galleryImageVersionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryImageVersionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<GalleryImageVersionResource>(new GalleryImageVersionOperationSource(Client), _galleryImageVersionClientDiagnostics, Pipeline, _galleryImageVersionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryImageVersionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a gallery image version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}/versions/{galleryImageVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryImageVersions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryImageVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="data"> Parameters supplied to the create or update gallery image version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GalleryImageVersionResource> CreateOrUpdate(WaitUntil waitUntil, string galleryImageVersionName, GalleryImageVersionData data, CancellationToken cancellationToken = default)
        {
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }
            if (galleryImageVersionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(galleryImageVersionName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _galleryImageVersionClientDiagnostics.CreateScope("GalleryImageVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _galleryImageVersionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryImageVersionName, data, cancellationToken);
                var operation = new ComputeArmOperation<GalleryImageVersionResource>(new GalleryImageVersionOperationSource(Client), _galleryImageVersionClientDiagnostics, Pipeline, _galleryImageVersionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryImageVersionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Retrieves information about a gallery image version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}/versions/{galleryImageVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryImageVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryImageVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> is null. </exception>
        public virtual async Task<Response<GalleryImageVersionResource>> GetAsync(string galleryImageVersionName, ReplicationStatusType? expand = null, CancellationToken cancellationToken = default)
        {
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }
            if (galleryImageVersionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(galleryImageVersionName));
            }

            using var scope = _galleryImageVersionClientDiagnostics.CreateScope("GalleryImageVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _galleryImageVersionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryImageVersionName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GalleryImageVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about a gallery image version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}/versions/{galleryImageVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryImageVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryImageVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> is null. </exception>
        public virtual Response<GalleryImageVersionResource> Get(string galleryImageVersionName, ReplicationStatusType? expand = null, CancellationToken cancellationToken = default)
        {
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }
            if (galleryImageVersionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(galleryImageVersionName));
            }

            using var scope = _galleryImageVersionClientDiagnostics.CreateScope("GalleryImageVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _galleryImageVersionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryImageVersionName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GalleryImageVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List gallery image versions in a gallery image definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryImageVersions_ListByGalleryImage</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryImageVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GalleryImageVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GalleryImageVersionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _galleryImageVersionRestClient.CreateListByGalleryImageRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _galleryImageVersionRestClient.CreateListByGalleryImageNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new GalleryImageVersionResource(Client, GalleryImageVersionData.DeserializeGalleryImageVersionData(e)), _galleryImageVersionClientDiagnostics, Pipeline, "GalleryImageVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List gallery image versions in a gallery image definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryImageVersions_ListByGalleryImage</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryImageVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GalleryImageVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GalleryImageVersionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _galleryImageVersionRestClient.CreateListByGalleryImageRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _galleryImageVersionRestClient.CreateListByGalleryImageNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new GalleryImageVersionResource(Client, GalleryImageVersionData.DeserializeGalleryImageVersionData(e)), _galleryImageVersionClientDiagnostics, Pipeline, "GalleryImageVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}/versions/{galleryImageVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryImageVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryImageVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string galleryImageVersionName, ReplicationStatusType? expand = null, CancellationToken cancellationToken = default)
        {
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }
            if (galleryImageVersionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(galleryImageVersionName));
            }

            using var scope = _galleryImageVersionClientDiagnostics.CreateScope("GalleryImageVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _galleryImageVersionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryImageVersionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}/versions/{galleryImageVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryImageVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryImageVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> is null. </exception>
        public virtual Response<bool> Exists(string galleryImageVersionName, ReplicationStatusType? expand = null, CancellationToken cancellationToken = default)
        {
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }
            if (galleryImageVersionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(galleryImageVersionName));
            }

            using var scope = _galleryImageVersionClientDiagnostics.CreateScope("GalleryImageVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _galleryImageVersionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryImageVersionName, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}/versions/{galleryImageVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryImageVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryImageVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> is null. </exception>
        public virtual async Task<NullableResponse<GalleryImageVersionResource>> GetIfExistsAsync(string galleryImageVersionName, ReplicationStatusType? expand = null, CancellationToken cancellationToken = default)
        {
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }
            if (galleryImageVersionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(galleryImageVersionName));
            }

            using var scope = _galleryImageVersionClientDiagnostics.CreateScope("GalleryImageVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _galleryImageVersionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryImageVersionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<GalleryImageVersionResource>(response.GetRawResponse());
                return Response.FromValue(new GalleryImageVersionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}/versions/{galleryImageVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryImageVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryImageVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> is null. </exception>
        public virtual NullableResponse<GalleryImageVersionResource> GetIfExists(string galleryImageVersionName, ReplicationStatusType? expand = null, CancellationToken cancellationToken = default)
        {
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }
            if (galleryImageVersionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(galleryImageVersionName));
            }

            using var scope = _galleryImageVersionClientDiagnostics.CreateScope("GalleryImageVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _galleryImageVersionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryImageVersionName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<GalleryImageVersionResource>(response.GetRawResponse());
                return Response.FromValue(new GalleryImageVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GalleryImageVersionResource> IEnumerable<GalleryImageVersionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GalleryImageVersionResource> IAsyncEnumerable<GalleryImageVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
