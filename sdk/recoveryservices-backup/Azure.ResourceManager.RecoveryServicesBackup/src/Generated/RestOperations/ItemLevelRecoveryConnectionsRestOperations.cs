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
using Azure.ResourceManager.RecoveryServicesBackup.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    internal partial class ItemLevelRecoveryConnectionsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ItemLevelRecoveryConnectionsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ItemLevelRecoveryConnectionsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateProvisionRequest(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string containerName, string protectedItemName, string recoveryPointId, ProvisionIlrConnectionContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(vaultName, true);
            uri.AppendPath("/backupFabrics/", false);
            uri.AppendPath(fabricName, true);
            uri.AppendPath("/protectionContainers/", false);
            uri.AppendPath(containerName, true);
            uri.AppendPath("/protectedItems/", false);
            uri.AppendPath(protectedItemName, true);
            uri.AppendPath("/recoveryPoints/", false);
            uri.AppendPath(recoveryPointId, true);
            uri.AppendPath("/provisionInstantItemRecovery", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary>
        /// Provisions a script which invokes an iSCSI connection to the backup data. Executing this script opens a file
        /// explorer displaying all the recoverable files and folders. This is an asynchronous operation. To know the status of
        /// provisioning, call GetProtectedItemOperationResult API.
        /// </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the backed up items. </param>
        /// <param name="containerName"> Container name associated with the backed up items. </param>
        /// <param name="protectedItemName"> Backed up item name whose files/folders are to be restored. </param>
        /// <param name="recoveryPointId">
        /// Recovery point ID which represents backed up data. iSCSI connection will be provisioned
        /// for this backed up data.
        /// </param>
        /// <param name="content"> resource ILR request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="containerName"/>, <paramref name="protectedItemName"/>, <paramref name="recoveryPointId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="containerName"/>, <paramref name="protectedItemName"/> or <paramref name="recoveryPointId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> ProvisionAsync(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string containerName, string protectedItemName, string recoveryPointId, ProvisionIlrConnectionContent content, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (containerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(containerName));
            }
            if (protectedItemName == null)
            {
                throw new ArgumentNullException(nameof(protectedItemName));
            }
            if (protectedItemName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(protectedItemName));
            }
            if (recoveryPointId == null)
            {
                throw new ArgumentNullException(nameof(recoveryPointId));
            }
            if (recoveryPointId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(recoveryPointId));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var message = CreateProvisionRequest(subscriptionId, resourceGroupName, vaultName, fabricName, containerName, protectedItemName, recoveryPointId, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary>
        /// Provisions a script which invokes an iSCSI connection to the backup data. Executing this script opens a file
        /// explorer displaying all the recoverable files and folders. This is an asynchronous operation. To know the status of
        /// provisioning, call GetProtectedItemOperationResult API.
        /// </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the backed up items. </param>
        /// <param name="containerName"> Container name associated with the backed up items. </param>
        /// <param name="protectedItemName"> Backed up item name whose files/folders are to be restored. </param>
        /// <param name="recoveryPointId">
        /// Recovery point ID which represents backed up data. iSCSI connection will be provisioned
        /// for this backed up data.
        /// </param>
        /// <param name="content"> resource ILR request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="containerName"/>, <paramref name="protectedItemName"/>, <paramref name="recoveryPointId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="containerName"/>, <paramref name="protectedItemName"/> or <paramref name="recoveryPointId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Provision(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string containerName, string protectedItemName, string recoveryPointId, ProvisionIlrConnectionContent content, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (containerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(containerName));
            }
            if (protectedItemName == null)
            {
                throw new ArgumentNullException(nameof(protectedItemName));
            }
            if (protectedItemName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(protectedItemName));
            }
            if (recoveryPointId == null)
            {
                throw new ArgumentNullException(nameof(recoveryPointId));
            }
            if (recoveryPointId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(recoveryPointId));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var message = CreateProvisionRequest(subscriptionId, resourceGroupName, vaultName, fabricName, containerName, protectedItemName, recoveryPointId, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRevokeRequest(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string containerName, string protectedItemName, string recoveryPointId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(vaultName, true);
            uri.AppendPath("/backupFabrics/", false);
            uri.AppendPath(fabricName, true);
            uri.AppendPath("/protectionContainers/", false);
            uri.AppendPath(containerName, true);
            uri.AppendPath("/protectedItems/", false);
            uri.AppendPath(protectedItemName, true);
            uri.AppendPath("/recoveryPoints/", false);
            uri.AppendPath(recoveryPointId, true);
            uri.AppendPath("/revokeInstantItemRecovery", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary>
        /// Revokes an iSCSI connection which can be used to download a script. Executing this script opens a file explorer
        /// displaying all recoverable files and folders. This is an asynchronous operation.
        /// </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the backed up items. </param>
        /// <param name="containerName"> Container name associated with the backed up items. </param>
        /// <param name="protectedItemName"> Backed up item name whose files/folders are to be restored. </param>
        /// <param name="recoveryPointId">
        /// Recovery point ID which represents backed up data. iSCSI connection will be revoked for
        /// this backed up data.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="containerName"/>, <paramref name="protectedItemName"/> or <paramref name="recoveryPointId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="containerName"/>, <paramref name="protectedItemName"/> or <paramref name="recoveryPointId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> RevokeAsync(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string containerName, string protectedItemName, string recoveryPointId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (containerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(containerName));
            }
            if (protectedItemName == null)
            {
                throw new ArgumentNullException(nameof(protectedItemName));
            }
            if (protectedItemName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(protectedItemName));
            }
            if (recoveryPointId == null)
            {
                throw new ArgumentNullException(nameof(recoveryPointId));
            }
            if (recoveryPointId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(recoveryPointId));
            }

            using var message = CreateRevokeRequest(subscriptionId, resourceGroupName, vaultName, fabricName, containerName, protectedItemName, recoveryPointId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary>
        /// Revokes an iSCSI connection which can be used to download a script. Executing this script opens a file explorer
        /// displaying all recoverable files and folders. This is an asynchronous operation.
        /// </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the backed up items. </param>
        /// <param name="containerName"> Container name associated with the backed up items. </param>
        /// <param name="protectedItemName"> Backed up item name whose files/folders are to be restored. </param>
        /// <param name="recoveryPointId">
        /// Recovery point ID which represents backed up data. iSCSI connection will be revoked for
        /// this backed up data.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="containerName"/>, <paramref name="protectedItemName"/> or <paramref name="recoveryPointId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="containerName"/>, <paramref name="protectedItemName"/> or <paramref name="recoveryPointId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Revoke(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string containerName, string protectedItemName, string recoveryPointId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (containerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(containerName));
            }
            if (protectedItemName == null)
            {
                throw new ArgumentNullException(nameof(protectedItemName));
            }
            if (protectedItemName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(protectedItemName));
            }
            if (recoveryPointId == null)
            {
                throw new ArgumentNullException(nameof(recoveryPointId));
            }
            if (recoveryPointId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(recoveryPointId));
            }

            using var message = CreateRevokeRequest(subscriptionId, resourceGroupName, vaultName, fabricName, containerName, protectedItemName, recoveryPointId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
