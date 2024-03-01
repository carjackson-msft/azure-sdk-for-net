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

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A class representing a collection of <see cref="DevTestLabScheduleResource"/> and their operations.
    /// Each <see cref="DevTestLabScheduleResource"/> in the collection will belong to the same instance of <see cref="DevTestLabResource"/>.
    /// To get a <see cref="DevTestLabScheduleCollection"/> instance call the GetDevTestLabSchedules method from an instance of <see cref="DevTestLabResource"/>.
    /// </summary>
    public partial class DevTestLabScheduleCollection : ArmCollection, IEnumerable<DevTestLabScheduleResource>, IAsyncEnumerable<DevTestLabScheduleResource>
    {
        private readonly ClientDiagnostics _devTestLabScheduleSchedulesClientDiagnostics;
        private readonly SchedulesRestOperations _devTestLabScheduleSchedulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DevTestLabScheduleCollection"/> class for mocking. </summary>
        protected DevTestLabScheduleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DevTestLabScheduleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DevTestLabScheduleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _devTestLabScheduleSchedulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevTestLabs", DevTestLabScheduleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DevTestLabScheduleResource.ResourceType, out string devTestLabScheduleSchedulesApiVersion);
            _devTestLabScheduleSchedulesRestClient = new SchedulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devTestLabScheduleSchedulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DevTestLabResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DevTestLabResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or replace an existing schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="data"> A schedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DevTestLabScheduleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, DevTestLabScheduleData data, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _devTestLabScheduleSchedulesClientDiagnostics.CreateScope("DevTestLabScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _devTestLabScheduleSchedulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DevTestLabsArmOperation<DevTestLabScheduleResource>(Response.FromValue(new DevTestLabScheduleResource(Client, response), response.GetRawResponse()));
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
        /// Create or replace an existing schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="data"> A schedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DevTestLabScheduleResource> CreateOrUpdate(WaitUntil waitUntil, string name, DevTestLabScheduleData data, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _devTestLabScheduleSchedulesClientDiagnostics.CreateScope("DevTestLabScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _devTestLabScheduleSchedulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var operation = new DevTestLabsArmOperation<DevTestLabScheduleResource>(Response.FromValue(new DevTestLabScheduleResource(Client, response), response.GetRawResponse()));
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
        /// Get schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<DevTestLabScheduleResource>> GetAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _devTestLabScheduleSchedulesClientDiagnostics.CreateScope("DevTestLabScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = await _devTestLabScheduleSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DevTestLabScheduleResource> Get(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _devTestLabScheduleSchedulesClientDiagnostics.CreateScope("DevTestLabScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = _devTestLabScheduleSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List schedules in a given lab.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/schedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevTestLabScheduleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevTestLabScheduleResource> GetAllAsync(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devTestLabScheduleSchedulesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devTestLabScheduleSchedulesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, filter, top, orderby);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DevTestLabScheduleResource(Client, DevTestLabScheduleData.DeserializeDevTestLabScheduleData(e)), _devTestLabScheduleSchedulesClientDiagnostics, Pipeline, "DevTestLabScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List schedules in a given lab.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/schedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevTestLabScheduleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevTestLabScheduleResource> GetAll(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devTestLabScheduleSchedulesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devTestLabScheduleSchedulesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, filter, top, orderby);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DevTestLabScheduleResource(Client, DevTestLabScheduleData.DeserializeDevTestLabScheduleData(e)), _devTestLabScheduleSchedulesClientDiagnostics, Pipeline, "DevTestLabScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all applicable schedules
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/schedules/{name}/listApplicable</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_ListApplicable</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <returns> An async collection of <see cref="DevTestLabScheduleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevTestLabScheduleResource> GetApplicableAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            HttpMessage FirstPageRequest(int? pageSizeHint) => _devTestLabScheduleSchedulesRestClient.CreateListApplicableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devTestLabScheduleSchedulesRestClient.CreateListApplicableNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DevTestLabScheduleResource(Client, DevTestLabScheduleData.DeserializeDevTestLabScheduleData(e)), _devTestLabScheduleSchedulesClientDiagnostics, Pipeline, "DevTestLabScheduleCollection.GetApplicable", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all applicable schedules
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/schedules/{name}/listApplicable</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_ListApplicable</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <returns> A collection of <see cref="DevTestLabScheduleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevTestLabScheduleResource> GetApplicable(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            HttpMessage FirstPageRequest(int? pageSizeHint) => _devTestLabScheduleSchedulesRestClient.CreateListApplicableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devTestLabScheduleSchedulesRestClient.CreateListApplicableNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DevTestLabScheduleResource(Client, DevTestLabScheduleData.DeserializeDevTestLabScheduleData(e)), _devTestLabScheduleSchedulesClientDiagnostics, Pipeline, "DevTestLabScheduleCollection.GetApplicable", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _devTestLabScheduleSchedulesClientDiagnostics.CreateScope("DevTestLabScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _devTestLabScheduleSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _devTestLabScheduleSchedulesClientDiagnostics.CreateScope("DevTestLabScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = _devTestLabScheduleSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<DevTestLabScheduleResource>> GetIfExistsAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _devTestLabScheduleSchedulesClientDiagnostics.CreateScope("DevTestLabScheduleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _devTestLabScheduleSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DevTestLabScheduleResource>(response.GetRawResponse());
                return Response.FromValue(new DevTestLabScheduleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<DevTestLabScheduleResource> GetIfExists(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _devTestLabScheduleSchedulesClientDiagnostics.CreateScope("DevTestLabScheduleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _devTestLabScheduleSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DevTestLabScheduleResource>(response.GetRawResponse());
                return Response.FromValue(new DevTestLabScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DevTestLabScheduleResource> IEnumerable<DevTestLabScheduleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DevTestLabScheduleResource> IAsyncEnumerable<DevTestLabScheduleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
