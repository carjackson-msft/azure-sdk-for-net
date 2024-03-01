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
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A Class representing a HybridRunbookWorker along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="HybridRunbookWorkerResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetHybridRunbookWorkerResource method.
    /// Otherwise you can get one from its parent resource <see cref="HybridRunbookWorkerGroupResource"/> using the GetHybridRunbookWorker method.
    /// </summary>
    public partial class HybridRunbookWorkerResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="HybridRunbookWorkerResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="automationAccountName"> The automationAccountName. </param>
        /// <param name="hybridRunbookWorkerGroupName"> The hybridRunbookWorkerGroupName. </param>
        /// <param name="hybridRunbookWorkerId"> The hybridRunbookWorkerId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string automationAccountName, string hybridRunbookWorkerGroupName, string hybridRunbookWorkerId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}/hybridRunbookWorkers/{hybridRunbookWorkerId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _hybridRunbookWorkerClientDiagnostics;
        private readonly HybridRunbookWorkersRestOperations _hybridRunbookWorkerRestClient;
        private readonly HybridRunbookWorkerData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Automation/automationAccounts/hybridRunbookWorkerGroups/hybridRunbookWorkers";

        /// <summary> Initializes a new instance of the <see cref="HybridRunbookWorkerResource"/> class for mocking. </summary>
        protected HybridRunbookWorkerResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HybridRunbookWorkerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal HybridRunbookWorkerResource(ArmClient client, HybridRunbookWorkerData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="HybridRunbookWorkerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HybridRunbookWorkerResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hybridRunbookWorkerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string hybridRunbookWorkerApiVersion);
            _hybridRunbookWorkerRestClient = new HybridRunbookWorkersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hybridRunbookWorkerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual HybridRunbookWorkerData Data
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
        /// Retrieve a hybrid runbook worker.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}/hybridRunbookWorkers/{hybridRunbookWorkerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridRunbookWorkerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HybridRunbookWorkerResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _hybridRunbookWorkerClientDiagnostics.CreateScope("HybridRunbookWorkerResource.Get");
            scope.Start();
            try
            {
                var response = await _hybridRunbookWorkerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridRunbookWorkerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a hybrid runbook worker.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}/hybridRunbookWorkers/{hybridRunbookWorkerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridRunbookWorkerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HybridRunbookWorkerResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _hybridRunbookWorkerClientDiagnostics.CreateScope("HybridRunbookWorkerResource.Get");
            scope.Start();
            try
            {
                var response = _hybridRunbookWorkerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridRunbookWorkerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a hybrid runbook worker.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}/hybridRunbookWorkers/{hybridRunbookWorkerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkers_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridRunbookWorkerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _hybridRunbookWorkerClientDiagnostics.CreateScope("HybridRunbookWorkerResource.Delete");
            scope.Start();
            try
            {
                var response = await _hybridRunbookWorkerRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a hybrid runbook worker.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}/hybridRunbookWorkers/{hybridRunbookWorkerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkers_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridRunbookWorkerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _hybridRunbookWorkerClientDiagnostics.CreateScope("HybridRunbookWorkerResource.Delete");
            scope.Start();
            try
            {
                var response = _hybridRunbookWorkerRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AutomationArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a hybrid runbook worker.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}/hybridRunbookWorkers/{hybridRunbookWorkerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkers_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridRunbookWorkerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The create or update parameters for hybrid runbook worker. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<HybridRunbookWorkerResource>> UpdateAsync(WaitUntil waitUntil, HybridRunbookWorkerCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = _hybridRunbookWorkerClientDiagnostics.CreateScope("HybridRunbookWorkerResource.Update");
            scope.Start();
            try
            {
                var response = await _hybridRunbookWorkerRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation<HybridRunbookWorkerResource>(Response.FromValue(new HybridRunbookWorkerResource(Client, response), response.GetRawResponse()));
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
        /// Create a hybrid runbook worker.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}/hybridRunbookWorkers/{hybridRunbookWorkerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkers_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridRunbookWorkerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The create or update parameters for hybrid runbook worker. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<HybridRunbookWorkerResource> Update(WaitUntil waitUntil, HybridRunbookWorkerCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = _hybridRunbookWorkerClientDiagnostics.CreateScope("HybridRunbookWorkerResource.Update");
            scope.Start();
            try
            {
                var response = _hybridRunbookWorkerRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new AutomationArmOperation<HybridRunbookWorkerResource>(Response.FromValue(new HybridRunbookWorkerResource(Client, response), response.GetRawResponse()));
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
        /// Move a hybrid worker to a different group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}/hybridRunbookWorkers/{hybridRunbookWorkerId}/move</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkers_Move</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridRunbookWorkerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The hybrid runbook worker move parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response> MoveAsync(HybridRunbookWorkerMoveContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = _hybridRunbookWorkerClientDiagnostics.CreateScope("HybridRunbookWorkerResource.Move");
            scope.Start();
            try
            {
                var response = await _hybridRunbookWorkerRestClient.MoveAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Move a hybrid worker to a different group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}/hybridRunbookWorkers/{hybridRunbookWorkerId}/move</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkers_Move</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridRunbookWorkerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The hybrid runbook worker move parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response Move(HybridRunbookWorkerMoveContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = _hybridRunbookWorkerClientDiagnostics.CreateScope("HybridRunbookWorkerResource.Move");
            scope.Start();
            try
            {
                var response = _hybridRunbookWorkerRestClient.Move(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
