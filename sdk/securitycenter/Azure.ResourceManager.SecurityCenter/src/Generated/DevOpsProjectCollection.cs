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

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="DevOpsProjectResource"/> and their operations.
    /// Each <see cref="DevOpsProjectResource"/> in the collection will belong to the same instance of <see cref="DevOpsOrgResource"/>.
    /// To get a <see cref="DevOpsProjectCollection"/> instance call the GetDevOpsProjects method from an instance of <see cref="DevOpsOrgResource"/>.
    /// </summary>
    public partial class DevOpsProjectCollection : ArmCollection, IEnumerable<DevOpsProjectResource>, IAsyncEnumerable<DevOpsProjectResource>
    {
        private readonly ClientDiagnostics _devOpsProjectAzureDevOpsProjectsClientDiagnostics;
        private readonly AzureDevOpsProjectsRestOperations _devOpsProjectAzureDevOpsProjectsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DevOpsProjectCollection"/> class for mocking. </summary>
        protected DevOpsProjectCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DevOpsProjectCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DevOpsProjectCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _devOpsProjectAzureDevOpsProjectsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", DevOpsProjectResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DevOpsProjectResource.ResourceType, out string devOpsProjectAzureDevOpsProjectsApiVersion);
            _devOpsProjectAzureDevOpsProjectsRestClient = new AzureDevOpsProjectsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devOpsProjectAzureDevOpsProjectsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DevOpsOrgResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DevOpsOrgResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a monitored Azure DevOps project resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/azureDevOpsOrgs/{orgName}/projects/{projectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsProjects_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsProjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="projectName"> The project name. </param>
        /// <param name="data"> The Azure DevOps project resource payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DevOpsProjectResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string projectName, DevOpsProjectData data, CancellationToken cancellationToken = default)
        {
            if (projectName == null)
            {
                throw new ArgumentNullException(nameof(projectName));
            }
            if (projectName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(projectName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _devOpsProjectAzureDevOpsProjectsClientDiagnostics.CreateScope("DevOpsProjectCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _devOpsProjectAzureDevOpsProjectsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, projectName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<DevOpsProjectResource>(new DevOpsProjectOperationSource(Client), _devOpsProjectAzureDevOpsProjectsClientDiagnostics, Pipeline, _devOpsProjectAzureDevOpsProjectsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, projectName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a monitored Azure DevOps project resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/azureDevOpsOrgs/{orgName}/projects/{projectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsProjects_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsProjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="projectName"> The project name. </param>
        /// <param name="data"> The Azure DevOps project resource payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DevOpsProjectResource> CreateOrUpdate(WaitUntil waitUntil, string projectName, DevOpsProjectData data, CancellationToken cancellationToken = default)
        {
            if (projectName == null)
            {
                throw new ArgumentNullException(nameof(projectName));
            }
            if (projectName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(projectName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _devOpsProjectAzureDevOpsProjectsClientDiagnostics.CreateScope("DevOpsProjectCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _devOpsProjectAzureDevOpsProjectsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, projectName, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<DevOpsProjectResource>(new DevOpsProjectOperationSource(Client), _devOpsProjectAzureDevOpsProjectsClientDiagnostics, Pipeline, _devOpsProjectAzureDevOpsProjectsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, projectName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Returns a monitored Azure DevOps project resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/azureDevOpsOrgs/{orgName}/projects/{projectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsProjects_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsProjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectName"> The project name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> is null. </exception>
        public virtual async Task<Response<DevOpsProjectResource>> GetAsync(string projectName, CancellationToken cancellationToken = default)
        {
            if (projectName == null)
            {
                throw new ArgumentNullException(nameof(projectName));
            }
            if (projectName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(projectName));
            }

            using var scope = _devOpsProjectAzureDevOpsProjectsClientDiagnostics.CreateScope("DevOpsProjectCollection.Get");
            scope.Start();
            try
            {
                var response = await _devOpsProjectAzureDevOpsProjectsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, projectName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevOpsProjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a monitored Azure DevOps project resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/azureDevOpsOrgs/{orgName}/projects/{projectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsProjects_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsProjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectName"> The project name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> is null. </exception>
        public virtual Response<DevOpsProjectResource> Get(string projectName, CancellationToken cancellationToken = default)
        {
            if (projectName == null)
            {
                throw new ArgumentNullException(nameof(projectName));
            }
            if (projectName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(projectName));
            }

            using var scope = _devOpsProjectAzureDevOpsProjectsClientDiagnostics.CreateScope("DevOpsProjectCollection.Get");
            scope.Start();
            try
            {
                var response = _devOpsProjectAzureDevOpsProjectsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, projectName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevOpsProjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a list of Azure DevOps projects onboarded to the connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/azureDevOpsOrgs/{orgName}/projects</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsProjects_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsProjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevOpsProjectResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevOpsProjectResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devOpsProjectAzureDevOpsProjectsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devOpsProjectAzureDevOpsProjectsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DevOpsProjectResource(Client, DevOpsProjectData.DeserializeDevOpsProjectData(e)), _devOpsProjectAzureDevOpsProjectsClientDiagnostics, Pipeline, "DevOpsProjectCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of Azure DevOps projects onboarded to the connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/azureDevOpsOrgs/{orgName}/projects</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsProjects_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsProjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevOpsProjectResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevOpsProjectResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devOpsProjectAzureDevOpsProjectsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devOpsProjectAzureDevOpsProjectsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DevOpsProjectResource(Client, DevOpsProjectData.DeserializeDevOpsProjectData(e)), _devOpsProjectAzureDevOpsProjectsClientDiagnostics, Pipeline, "DevOpsProjectCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/azureDevOpsOrgs/{orgName}/projects/{projectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsProjects_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsProjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectName"> The project name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string projectName, CancellationToken cancellationToken = default)
        {
            if (projectName == null)
            {
                throw new ArgumentNullException(nameof(projectName));
            }
            if (projectName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(projectName));
            }

            using var scope = _devOpsProjectAzureDevOpsProjectsClientDiagnostics.CreateScope("DevOpsProjectCollection.Exists");
            scope.Start();
            try
            {
                var response = await _devOpsProjectAzureDevOpsProjectsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, projectName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/azureDevOpsOrgs/{orgName}/projects/{projectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsProjects_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsProjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectName"> The project name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> is null. </exception>
        public virtual Response<bool> Exists(string projectName, CancellationToken cancellationToken = default)
        {
            if (projectName == null)
            {
                throw new ArgumentNullException(nameof(projectName));
            }
            if (projectName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(projectName));
            }

            using var scope = _devOpsProjectAzureDevOpsProjectsClientDiagnostics.CreateScope("DevOpsProjectCollection.Exists");
            scope.Start();
            try
            {
                var response = _devOpsProjectAzureDevOpsProjectsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, projectName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/azureDevOpsOrgs/{orgName}/projects/{projectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsProjects_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsProjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectName"> The project name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> is null. </exception>
        public virtual async Task<NullableResponse<DevOpsProjectResource>> GetIfExistsAsync(string projectName, CancellationToken cancellationToken = default)
        {
            if (projectName == null)
            {
                throw new ArgumentNullException(nameof(projectName));
            }
            if (projectName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(projectName));
            }

            using var scope = _devOpsProjectAzureDevOpsProjectsClientDiagnostics.CreateScope("DevOpsProjectCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _devOpsProjectAzureDevOpsProjectsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, projectName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DevOpsProjectResource>(response.GetRawResponse());
                return Response.FromValue(new DevOpsProjectResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/azureDevOpsOrgs/{orgName}/projects/{projectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsProjects_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsProjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectName"> The project name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> is null. </exception>
        public virtual NullableResponse<DevOpsProjectResource> GetIfExists(string projectName, CancellationToken cancellationToken = default)
        {
            if (projectName == null)
            {
                throw new ArgumentNullException(nameof(projectName));
            }
            if (projectName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(projectName));
            }

            using var scope = _devOpsProjectAzureDevOpsProjectsClientDiagnostics.CreateScope("DevOpsProjectCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _devOpsProjectAzureDevOpsProjectsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, projectName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DevOpsProjectResource>(response.GetRawResponse());
                return Response.FromValue(new DevOpsProjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DevOpsProjectResource> IEnumerable<DevOpsProjectResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DevOpsProjectResource> IAsyncEnumerable<DevOpsProjectResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
