// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Confluent;

namespace Azure.ResourceManager.Confluent.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableConfluentResourceGroupResource : ArmResource
    {
        private ClientDiagnostics _validationsClientDiagnostics;
        private ValidationsRestOperations _validationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableConfluentResourceGroupResource"/> class for mocking. </summary>
        protected MockableConfluentResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableConfluentResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableConfluentResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ValidationsClientDiagnostics => _validationsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Confluent", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ValidationsRestOperations ValidationsRestClient => _validationsRestClient ??= new ValidationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ConfluentOrganizationResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ConfluentOrganizationResources and their operations over a ConfluentOrganizationResource. </returns>
        public virtual ConfluentOrganizationCollection GetConfluentOrganizations()
        {
            return GetCachedClient(client => new ConfluentOrganizationCollection(client, Id));
        }

        /// <summary>
        /// Get the properties of a specific Organization resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Confluent/organizations/{organizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organization_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConfluentOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="organizationName"> Organization resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="organizationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="organizationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ConfluentOrganizationResource>> GetConfluentOrganizationAsync(string organizationName, CancellationToken cancellationToken = default)
        {
            return await GetConfluentOrganizations().GetAsync(organizationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the properties of a specific Organization resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Confluent/organizations/{organizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organization_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConfluentOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="organizationName"> Organization resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="organizationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="organizationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ConfluentOrganizationResource> GetConfluentOrganization(string organizationName, CancellationToken cancellationToken = default)
        {
            return GetConfluentOrganizations().Get(organizationName, cancellationToken);
        }

        /// <summary>
        /// Organization Validate proxy resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Confluent/validations/{organizationName}/orgvalidate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Validations_ValidateOrganization</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-12-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="organizationName"> Organization resource name. </param>
        /// <param name="data"> Organization resource model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="organizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="organizationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<ConfluentOrganizationResource>> ValidateOrganizationAsync(string organizationName, ConfluentOrganizationData data, CancellationToken cancellationToken = default)
        {
            if (organizationName == null)
            {
                throw new ArgumentNullException(nameof(organizationName));
            }
            if (organizationName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(organizationName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = ValidationsClientDiagnostics.CreateScope("MockableConfluentResourceGroupResource.ValidateOrganization");
            scope.Start();
            try
            {
                var response = await ValidationsRestClient.ValidateOrganizationAsync(Id.SubscriptionId, Id.ResourceGroupName, organizationName, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ConfluentOrganizationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Organization Validate proxy resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Confluent/validations/{organizationName}/orgvalidate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Validations_ValidateOrganization</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-12-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="organizationName"> Organization resource name. </param>
        /// <param name="data"> Organization resource model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="organizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="organizationName"/> or <paramref name="data"/> is null. </exception>
        public virtual Response<ConfluentOrganizationResource> ValidateOrganization(string organizationName, ConfluentOrganizationData data, CancellationToken cancellationToken = default)
        {
            if (organizationName == null)
            {
                throw new ArgumentNullException(nameof(organizationName));
            }
            if (organizationName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(organizationName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = ValidationsClientDiagnostics.CreateScope("MockableConfluentResourceGroupResource.ValidateOrganization");
            scope.Start();
            try
            {
                var response = ValidationsRestClient.ValidateOrganization(Id.SubscriptionId, Id.ResourceGroupName, organizationName, data, cancellationToken);
                return Response.FromValue(new ConfluentOrganizationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
