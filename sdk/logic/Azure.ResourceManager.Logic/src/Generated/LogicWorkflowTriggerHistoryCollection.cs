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

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A class representing a collection of <see cref="LogicWorkflowTriggerHistoryResource"/> and their operations.
    /// Each <see cref="LogicWorkflowTriggerHistoryResource"/> in the collection will belong to the same instance of <see cref="LogicWorkflowTriggerResource"/>.
    /// To get a <see cref="LogicWorkflowTriggerHistoryCollection"/> instance call the GetLogicWorkflowTriggerHistories method from an instance of <see cref="LogicWorkflowTriggerResource"/>.
    /// </summary>
    public partial class LogicWorkflowTriggerHistoryCollection : ArmCollection, IEnumerable<LogicWorkflowTriggerHistoryResource>, IAsyncEnumerable<LogicWorkflowTriggerHistoryResource>
    {
        private readonly ClientDiagnostics _logicWorkflowTriggerHistoryWorkflowTriggerHistoriesClientDiagnostics;
        private readonly WorkflowTriggerHistoriesRestOperations _logicWorkflowTriggerHistoryWorkflowTriggerHistoriesRestClient;

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowTriggerHistoryCollection"/> class for mocking. </summary>
        protected LogicWorkflowTriggerHistoryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowTriggerHistoryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LogicWorkflowTriggerHistoryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _logicWorkflowTriggerHistoryWorkflowTriggerHistoriesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", LogicWorkflowTriggerHistoryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LogicWorkflowTriggerHistoryResource.ResourceType, out string logicWorkflowTriggerHistoryWorkflowTriggerHistoriesApiVersion);
            _logicWorkflowTriggerHistoryWorkflowTriggerHistoriesRestClient = new WorkflowTriggerHistoriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logicWorkflowTriggerHistoryWorkflowTriggerHistoriesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LogicWorkflowTriggerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LogicWorkflowTriggerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a workflow trigger history.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}/histories/{historyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowTriggerHistories_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowTriggerHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="historyName"> The workflow trigger history name. Corresponds to the run name for triggers that resulted in a run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="historyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="historyName"/> is null. </exception>
        public virtual async Task<Response<LogicWorkflowTriggerHistoryResource>> GetAsync(string historyName, CancellationToken cancellationToken = default)
        {
            if (historyName == null)
            {
                throw new ArgumentNullException(nameof(historyName));
            }
            if (historyName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(historyName));
            }

            using var scope = _logicWorkflowTriggerHistoryWorkflowTriggerHistoriesClientDiagnostics.CreateScope("LogicWorkflowTriggerHistoryCollection.Get");
            scope.Start();
            try
            {
                var response = await _logicWorkflowTriggerHistoryWorkflowTriggerHistoriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, historyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowTriggerHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a workflow trigger history.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}/histories/{historyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowTriggerHistories_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowTriggerHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="historyName"> The workflow trigger history name. Corresponds to the run name for triggers that resulted in a run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="historyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="historyName"/> is null. </exception>
        public virtual Response<LogicWorkflowTriggerHistoryResource> Get(string historyName, CancellationToken cancellationToken = default)
        {
            if (historyName == null)
            {
                throw new ArgumentNullException(nameof(historyName));
            }
            if (historyName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(historyName));
            }

            using var scope = _logicWorkflowTriggerHistoryWorkflowTriggerHistoriesClientDiagnostics.CreateScope("LogicWorkflowTriggerHistoryCollection.Get");
            scope.Start();
            try
            {
                var response = _logicWorkflowTriggerHistoryWorkflowTriggerHistoriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, historyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowTriggerHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of workflow trigger histories.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}/histories</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowTriggerHistories_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowTriggerHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="filter"> The filter to apply on the operation. Options for filters include: Status, StartTime, and ClientTrackingId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LogicWorkflowTriggerHistoryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LogicWorkflowTriggerHistoryResource> GetAllAsync(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _logicWorkflowTriggerHistoryWorkflowTriggerHistoriesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, top, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _logicWorkflowTriggerHistoryWorkflowTriggerHistoriesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, top, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new LogicWorkflowTriggerHistoryResource(Client, LogicWorkflowTriggerHistoryData.DeserializeLogicWorkflowTriggerHistoryData(e)), _logicWorkflowTriggerHistoryWorkflowTriggerHistoriesClientDiagnostics, Pipeline, "LogicWorkflowTriggerHistoryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of workflow trigger histories.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}/histories</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowTriggerHistories_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowTriggerHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="filter"> The filter to apply on the operation. Options for filters include: Status, StartTime, and ClientTrackingId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LogicWorkflowTriggerHistoryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LogicWorkflowTriggerHistoryResource> GetAll(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _logicWorkflowTriggerHistoryWorkflowTriggerHistoriesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, top, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _logicWorkflowTriggerHistoryWorkflowTriggerHistoriesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, top, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new LogicWorkflowTriggerHistoryResource(Client, LogicWorkflowTriggerHistoryData.DeserializeLogicWorkflowTriggerHistoryData(e)), _logicWorkflowTriggerHistoryWorkflowTriggerHistoriesClientDiagnostics, Pipeline, "LogicWorkflowTriggerHistoryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}/histories/{historyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowTriggerHistories_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowTriggerHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="historyName"> The workflow trigger history name. Corresponds to the run name for triggers that resulted in a run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="historyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="historyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string historyName, CancellationToken cancellationToken = default)
        {
            if (historyName == null)
            {
                throw new ArgumentNullException(nameof(historyName));
            }
            if (historyName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(historyName));
            }

            using var scope = _logicWorkflowTriggerHistoryWorkflowTriggerHistoriesClientDiagnostics.CreateScope("LogicWorkflowTriggerHistoryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _logicWorkflowTriggerHistoryWorkflowTriggerHistoriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, historyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}/histories/{historyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowTriggerHistories_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowTriggerHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="historyName"> The workflow trigger history name. Corresponds to the run name for triggers that resulted in a run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="historyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="historyName"/> is null. </exception>
        public virtual Response<bool> Exists(string historyName, CancellationToken cancellationToken = default)
        {
            if (historyName == null)
            {
                throw new ArgumentNullException(nameof(historyName));
            }
            if (historyName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(historyName));
            }

            using var scope = _logicWorkflowTriggerHistoryWorkflowTriggerHistoriesClientDiagnostics.CreateScope("LogicWorkflowTriggerHistoryCollection.Exists");
            scope.Start();
            try
            {
                var response = _logicWorkflowTriggerHistoryWorkflowTriggerHistoriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, historyName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}/histories/{historyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowTriggerHistories_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowTriggerHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="historyName"> The workflow trigger history name. Corresponds to the run name for triggers that resulted in a run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="historyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="historyName"/> is null. </exception>
        public virtual async Task<NullableResponse<LogicWorkflowTriggerHistoryResource>> GetIfExistsAsync(string historyName, CancellationToken cancellationToken = default)
        {
            if (historyName == null)
            {
                throw new ArgumentNullException(nameof(historyName));
            }
            if (historyName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(historyName));
            }

            using var scope = _logicWorkflowTriggerHistoryWorkflowTriggerHistoriesClientDiagnostics.CreateScope("LogicWorkflowTriggerHistoryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _logicWorkflowTriggerHistoryWorkflowTriggerHistoriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, historyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<LogicWorkflowTriggerHistoryResource>(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowTriggerHistoryResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}/histories/{historyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowTriggerHistories_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowTriggerHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="historyName"> The workflow trigger history name. Corresponds to the run name for triggers that resulted in a run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="historyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="historyName"/> is null. </exception>
        public virtual NullableResponse<LogicWorkflowTriggerHistoryResource> GetIfExists(string historyName, CancellationToken cancellationToken = default)
        {
            if (historyName == null)
            {
                throw new ArgumentNullException(nameof(historyName));
            }
            if (historyName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(historyName));
            }

            using var scope = _logicWorkflowTriggerHistoryWorkflowTriggerHistoriesClientDiagnostics.CreateScope("LogicWorkflowTriggerHistoryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _logicWorkflowTriggerHistoryWorkflowTriggerHistoriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, historyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<LogicWorkflowTriggerHistoryResource>(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowTriggerHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LogicWorkflowTriggerHistoryResource> IEnumerable<LogicWorkflowTriggerHistoryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LogicWorkflowTriggerHistoryResource> IAsyncEnumerable<LogicWorkflowTriggerHistoryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
