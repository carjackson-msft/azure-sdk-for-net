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

namespace Azure.ResourceManager.DefenderEasm
{
    /// <summary>
    /// A class representing a collection of <see cref="EasmLabelResource"/> and their operations.
    /// Each <see cref="EasmLabelResource"/> in the collection will belong to the same instance of <see cref="EasmWorkspaceResource"/>.
    /// To get an <see cref="EasmLabelCollection"/> instance call the GetEasmLabels method from an instance of <see cref="EasmWorkspaceResource"/>.
    /// </summary>
    public partial class EasmLabelCollection : ArmCollection, IEnumerable<EasmLabelResource>, IAsyncEnumerable<EasmLabelResource>
    {
        private readonly ClientDiagnostics _easmLabelLabelsClientDiagnostics;
        private readonly LabelsRestOperations _easmLabelLabelsRestClient;

        /// <summary> Initializes a new instance of the <see cref="EasmLabelCollection"/> class for mocking. </summary>
        protected EasmLabelCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EasmLabelCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EasmLabelCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _easmLabelLabelsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DefenderEasm", EasmLabelResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EasmLabelResource.ResourceType, out string easmLabelLabelsApiVersion);
            _easmLabelLabelsRestClient = new LabelsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, easmLabelLabelsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != EasmWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, EasmWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a Label.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}/labels/{labelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labels_CreateAndUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EasmLabelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="labelName"> The name of the Label. </param>
        /// <param name="data"> Label details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="labelName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="labelName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EasmLabelResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string labelName, EasmLabelData data, CancellationToken cancellationToken = default)
        {
            if (labelName == null)
            {
                throw new ArgumentNullException(nameof(labelName));
            }
            if (labelName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(labelName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _easmLabelLabelsClientDiagnostics.CreateScope("EasmLabelCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _easmLabelLabelsRestClient.CreateAndUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, labelName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DefenderEasmArmOperation<EasmLabelResource>(new EasmLabelOperationSource(Client), _easmLabelLabelsClientDiagnostics, Pipeline, _easmLabelLabelsRestClient.CreateCreateAndUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, labelName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update a Label.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}/labels/{labelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labels_CreateAndUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EasmLabelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="labelName"> The name of the Label. </param>
        /// <param name="data"> Label details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="labelName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="labelName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EasmLabelResource> CreateOrUpdate(WaitUntil waitUntil, string labelName, EasmLabelData data, CancellationToken cancellationToken = default)
        {
            if (labelName == null)
            {
                throw new ArgumentNullException(nameof(labelName));
            }
            if (labelName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(labelName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _easmLabelLabelsClientDiagnostics.CreateScope("EasmLabelCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _easmLabelLabelsRestClient.CreateAndUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, labelName, data, cancellationToken);
                var operation = new DefenderEasmArmOperation<EasmLabelResource>(new EasmLabelOperationSource(Client), _easmLabelLabelsClientDiagnostics, Pipeline, _easmLabelLabelsRestClient.CreateCreateAndUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, labelName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Returns a label in the given workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}/labels/{labelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labels_GetByWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EasmLabelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="labelName"> The name of the Label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="labelName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="labelName"/> is null. </exception>
        public virtual async Task<Response<EasmLabelResource>> GetAsync(string labelName, CancellationToken cancellationToken = default)
        {
            if (labelName == null)
            {
                throw new ArgumentNullException(nameof(labelName));
            }
            if (labelName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(labelName));
            }

            using var scope = _easmLabelLabelsClientDiagnostics.CreateScope("EasmLabelCollection.Get");
            scope.Start();
            try
            {
                var response = await _easmLabelLabelsRestClient.GetByWorkspaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, labelName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EasmLabelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a label in the given workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}/labels/{labelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labels_GetByWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EasmLabelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="labelName"> The name of the Label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="labelName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="labelName"/> is null. </exception>
        public virtual Response<EasmLabelResource> Get(string labelName, CancellationToken cancellationToken = default)
        {
            if (labelName == null)
            {
                throw new ArgumentNullException(nameof(labelName));
            }
            if (labelName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(labelName));
            }

            using var scope = _easmLabelLabelsClientDiagnostics.CreateScope("EasmLabelCollection.Get");
            scope.Start();
            try
            {
                var response = _easmLabelLabelsRestClient.GetByWorkspace(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, labelName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EasmLabelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a list of labels in the given workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}/labels</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labels_ListByWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EasmLabelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EasmLabelResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EasmLabelResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _easmLabelLabelsRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _easmLabelLabelsRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EasmLabelResource(Client, EasmLabelData.DeserializeEasmLabelData(e)), _easmLabelLabelsClientDiagnostics, Pipeline, "EasmLabelCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of labels in the given workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}/labels</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labels_ListByWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EasmLabelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EasmLabelResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EasmLabelResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _easmLabelLabelsRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _easmLabelLabelsRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EasmLabelResource(Client, EasmLabelData.DeserializeEasmLabelData(e)), _easmLabelLabelsClientDiagnostics, Pipeline, "EasmLabelCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}/labels/{labelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labels_GetByWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EasmLabelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="labelName"> The name of the Label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="labelName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="labelName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string labelName, CancellationToken cancellationToken = default)
        {
            if (labelName == null)
            {
                throw new ArgumentNullException(nameof(labelName));
            }
            if (labelName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(labelName));
            }

            using var scope = _easmLabelLabelsClientDiagnostics.CreateScope("EasmLabelCollection.Exists");
            scope.Start();
            try
            {
                var response = await _easmLabelLabelsRestClient.GetByWorkspaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, labelName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}/labels/{labelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labels_GetByWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EasmLabelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="labelName"> The name of the Label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="labelName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="labelName"/> is null. </exception>
        public virtual Response<bool> Exists(string labelName, CancellationToken cancellationToken = default)
        {
            if (labelName == null)
            {
                throw new ArgumentNullException(nameof(labelName));
            }
            if (labelName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(labelName));
            }

            using var scope = _easmLabelLabelsClientDiagnostics.CreateScope("EasmLabelCollection.Exists");
            scope.Start();
            try
            {
                var response = _easmLabelLabelsRestClient.GetByWorkspace(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, labelName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}/labels/{labelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labels_GetByWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EasmLabelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="labelName"> The name of the Label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="labelName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="labelName"/> is null. </exception>
        public virtual async Task<NullableResponse<EasmLabelResource>> GetIfExistsAsync(string labelName, CancellationToken cancellationToken = default)
        {
            if (labelName == null)
            {
                throw new ArgumentNullException(nameof(labelName));
            }
            if (labelName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(labelName));
            }

            using var scope = _easmLabelLabelsClientDiagnostics.CreateScope("EasmLabelCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _easmLabelLabelsRestClient.GetByWorkspaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, labelName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<EasmLabelResource>(response.GetRawResponse());
                return Response.FromValue(new EasmLabelResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}/labels/{labelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labels_GetByWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EasmLabelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="labelName"> The name of the Label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="labelName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="labelName"/> is null. </exception>
        public virtual NullableResponse<EasmLabelResource> GetIfExists(string labelName, CancellationToken cancellationToken = default)
        {
            if (labelName == null)
            {
                throw new ArgumentNullException(nameof(labelName));
            }
            if (labelName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(labelName));
            }

            using var scope = _easmLabelLabelsClientDiagnostics.CreateScope("EasmLabelCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _easmLabelLabelsRestClient.GetByWorkspace(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, labelName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<EasmLabelResource>(response.GetRawResponse());
                return Response.FromValue(new EasmLabelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EasmLabelResource> IEnumerable<EasmLabelResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EasmLabelResource> IAsyncEnumerable<EasmLabelResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
