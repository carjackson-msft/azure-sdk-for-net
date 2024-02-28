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

namespace Azure.ResourceManager.Blueprint
{
    /// <summary>
    /// A Class representing a PublishedBlueprint along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="PublishedBlueprintResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetPublishedBlueprintResource method.
    /// Otherwise you can get one from its parent resource <see cref="BlueprintResource"/> using the GetPublishedBlueprint method.
    /// </summary>
    public partial class PublishedBlueprintResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PublishedBlueprintResource"/> instance. </summary>
        /// <param name="resourceScope"> The resourceScope. </param>
        /// <param name="blueprintName"> The blueprintName. </param>
        /// <param name="versionId"> The versionId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceScope, string blueprintName, string versionId)
        {
            var resourceId = $"{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _publishedBlueprintClientDiagnostics;
        private readonly PublishedBlueprintsRestOperations _publishedBlueprintRestClient;
        private readonly PublishedBlueprintData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Blueprint/blueprints/versions";

        /// <summary> Initializes a new instance of the <see cref="PublishedBlueprintResource"/> class for mocking. </summary>
        protected PublishedBlueprintResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PublishedBlueprintResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PublishedBlueprintResource(ArmClient client, PublishedBlueprintData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PublishedBlueprintResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PublishedBlueprintResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _publishedBlueprintClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Blueprint", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string publishedBlueprintApiVersion);
            _publishedBlueprintRestClient = new PublishedBlueprintsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, publishedBlueprintApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PublishedBlueprintData Data
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

        /// <summary> Gets a collection of BlueprintVersionArtifactResources in the PublishedBlueprint. </summary>
        /// <returns> An object representing collection of BlueprintVersionArtifactResources and their operations over a BlueprintVersionArtifactResource. </returns>
        public virtual BlueprintVersionArtifactCollection GetBlueprintVersionArtifacts()
        {
            return GetCachedClient(client => new BlueprintVersionArtifactCollection(client, Id));
        }

        /// <summary>
        /// Get an artifact for a published blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedArtifacts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BlueprintVersionArtifactResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="artifactName"> Name of the blueprint artifact. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="artifactName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<BlueprintVersionArtifactResource>> GetBlueprintVersionArtifactAsync(string artifactName, CancellationToken cancellationToken = default)
        {
            return await GetBlueprintVersionArtifacts().GetAsync(artifactName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get an artifact for a published blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedArtifacts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BlueprintVersionArtifactResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="artifactName"> Name of the blueprint artifact. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="artifactName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<BlueprintVersionArtifactResource> GetBlueprintVersionArtifact(string artifactName, CancellationToken cancellationToken = default)
        {
            return GetBlueprintVersionArtifacts().Get(artifactName, cancellationToken);
        }

        /// <summary>
        /// Get a published version of a blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedBlueprints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublishedBlueprintResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PublishedBlueprintResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _publishedBlueprintClientDiagnostics.CreateScope("PublishedBlueprintResource.Get");
            scope.Start();
            try
            {
                var response = await _publishedBlueprintRestClient.GetAsync(Id.Parent.Parent, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PublishedBlueprintResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a published version of a blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedBlueprints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublishedBlueprintResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PublishedBlueprintResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _publishedBlueprintClientDiagnostics.CreateScope("PublishedBlueprintResource.Get");
            scope.Start();
            try
            {
                var response = _publishedBlueprintRestClient.Get(Id.Parent.Parent, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PublishedBlueprintResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a published version of a blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedBlueprints_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublishedBlueprintResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<PublishedBlueprintResource>> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _publishedBlueprintClientDiagnostics.CreateScope("PublishedBlueprintResource.Delete");
            scope.Start();
            try
            {
                var response = await _publishedBlueprintRestClient.DeleteAsync(Id.Parent.Parent, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new BlueprintArmOperation<PublishedBlueprintResource>(Response.FromValue(new PublishedBlueprintResource(Client, response), response.GetRawResponse()));
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
        /// Delete a published version of a blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedBlueprints_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublishedBlueprintResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<PublishedBlueprintResource> Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _publishedBlueprintClientDiagnostics.CreateScope("PublishedBlueprintResource.Delete");
            scope.Start();
            try
            {
                var response = _publishedBlueprintRestClient.Delete(Id.Parent.Parent, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new BlueprintArmOperation<PublishedBlueprintResource>(Response.FromValue(new PublishedBlueprintResource(Client, response), response.GetRawResponse()));
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
        /// Publish a new version of the blueprint definition with the latest artifacts. Published blueprint definitions are immutable.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedBlueprints_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublishedBlueprintResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Published Blueprint to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PublishedBlueprintResource>> UpdateAsync(WaitUntil waitUntil, PublishedBlueprintData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _publishedBlueprintClientDiagnostics.CreateScope("PublishedBlueprintResource.Update");
            scope.Start();
            try
            {
                var response = await _publishedBlueprintRestClient.CreateAsync(Id.Parent.Parent, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new BlueprintArmOperation<PublishedBlueprintResource>(Response.FromValue(new PublishedBlueprintResource(Client, response), response.GetRawResponse()));
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
        /// Publish a new version of the blueprint definition with the latest artifacts. Published blueprint definitions are immutable.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedBlueprints_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublishedBlueprintResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Published Blueprint to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PublishedBlueprintResource> Update(WaitUntil waitUntil, PublishedBlueprintData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _publishedBlueprintClientDiagnostics.CreateScope("PublishedBlueprintResource.Update");
            scope.Start();
            try
            {
                var response = _publishedBlueprintRestClient.Create(Id.Parent.Parent, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new BlueprintArmOperation<PublishedBlueprintResource>(Response.FromValue(new PublishedBlueprintResource(Client, response), response.GetRawResponse()));
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
    }
}
