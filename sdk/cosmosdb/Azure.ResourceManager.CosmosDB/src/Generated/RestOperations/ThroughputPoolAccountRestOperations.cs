// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.CosmosDB
{
    internal partial class ThroughputPoolAccountRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ThroughputPoolAccountRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ThroughputPoolAccountRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-02-15-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string throughputPoolName, string throughputPoolAccountName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DocumentDB/throughputPools/", false);
            uri.AppendPath(throughputPoolName, true);
            uri.AppendPath("/throughputPoolAccounts/", false);
            uri.AppendPath(throughputPoolAccountName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieves the properties of an existing Azure Cosmos DB Throughput Pool. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="throughputPoolName"> Cosmos DB Throughput Pool name. </param>
        /// <param name="throughputPoolAccountName"> Cosmos DB global database account in a Throughput Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="throughputPoolName"/> or <paramref name="throughputPoolAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="throughputPoolName"/> or <paramref name="throughputPoolAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ThroughputPoolAccountResourceData>> GetAsync(string subscriptionId, string resourceGroupName, string throughputPoolName, string throughputPoolAccountName, CancellationToken cancellationToken = default)
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
            if (throughputPoolName == null)
            {
                throw new ArgumentNullException(nameof(throughputPoolName));
            }
            if (throughputPoolName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(throughputPoolName));
            }
            if (throughputPoolAccountName == null)
            {
                throw new ArgumentNullException(nameof(throughputPoolAccountName));
            }
            if (throughputPoolAccountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(throughputPoolAccountName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, throughputPoolName, throughputPoolAccountName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ThroughputPoolAccountResourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ThroughputPoolAccountResourceData.DeserializeThroughputPoolAccountResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ThroughputPoolAccountResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieves the properties of an existing Azure Cosmos DB Throughput Pool. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="throughputPoolName"> Cosmos DB Throughput Pool name. </param>
        /// <param name="throughputPoolAccountName"> Cosmos DB global database account in a Throughput Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="throughputPoolName"/> or <paramref name="throughputPoolAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="throughputPoolName"/> or <paramref name="throughputPoolAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ThroughputPoolAccountResourceData> Get(string subscriptionId, string resourceGroupName, string throughputPoolName, string throughputPoolAccountName, CancellationToken cancellationToken = default)
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
            if (throughputPoolName == null)
            {
                throw new ArgumentNullException(nameof(throughputPoolName));
            }
            if (throughputPoolName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(throughputPoolName));
            }
            if (throughputPoolAccountName == null)
            {
                throw new ArgumentNullException(nameof(throughputPoolAccountName));
            }
            if (throughputPoolAccountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(throughputPoolAccountName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, throughputPoolName, throughputPoolAccountName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ThroughputPoolAccountResourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ThroughputPoolAccountResourceData.DeserializeThroughputPoolAccountResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ThroughputPoolAccountResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string throughputPoolName, string throughputPoolAccountName, ThroughputPoolAccountResourceData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DocumentDB/throughputPools/", false);
            uri.AppendPath(throughputPoolName, true);
            uri.AppendPath("/throughputPoolAccounts/", false);
            uri.AppendPath(throughputPoolAccountName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates or updates an Azure Cosmos DB ThroughputPool account. The "Update" method is preferred when performing updates on an account. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="throughputPoolName"> Cosmos DB Throughput Pool name. </param>
        /// <param name="throughputPoolAccountName"> Cosmos DB global database account in a Throughput Pool. </param>
        /// <param name="data"> The parameters to provide for the current ThroughputPoolAccount. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="throughputPoolName"/>, <paramref name="throughputPoolAccountName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="throughputPoolName"/> or <paramref name="throughputPoolAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateAsync(string subscriptionId, string resourceGroupName, string throughputPoolName, string throughputPoolAccountName, ThroughputPoolAccountResourceData data, CancellationToken cancellationToken = default)
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
            if (throughputPoolName == null)
            {
                throw new ArgumentNullException(nameof(throughputPoolName));
            }
            if (throughputPoolName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(throughputPoolName));
            }
            if (throughputPoolAccountName == null)
            {
                throw new ArgumentNullException(nameof(throughputPoolAccountName));
            }
            if (throughputPoolAccountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(throughputPoolAccountName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, throughputPoolName, throughputPoolAccountName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates an Azure Cosmos DB ThroughputPool account. The "Update" method is preferred when performing updates on an account. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="throughputPoolName"> Cosmos DB Throughput Pool name. </param>
        /// <param name="throughputPoolAccountName"> Cosmos DB global database account in a Throughput Pool. </param>
        /// <param name="data"> The parameters to provide for the current ThroughputPoolAccount. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="throughputPoolName"/>, <paramref name="throughputPoolAccountName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="throughputPoolName"/> or <paramref name="throughputPoolAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Create(string subscriptionId, string resourceGroupName, string throughputPoolName, string throughputPoolAccountName, ThroughputPoolAccountResourceData data, CancellationToken cancellationToken = default)
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
            if (throughputPoolName == null)
            {
                throw new ArgumentNullException(nameof(throughputPoolName));
            }
            if (throughputPoolName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(throughputPoolName));
            }
            if (throughputPoolAccountName == null)
            {
                throw new ArgumentNullException(nameof(throughputPoolAccountName));
            }
            if (throughputPoolAccountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(throughputPoolAccountName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, throughputPoolName, throughputPoolAccountName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string throughputPoolName, string throughputPoolAccountName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DocumentDB/throughputPools/", false);
            uri.AppendPath(throughputPoolName, true);
            uri.AppendPath("/throughputPoolAccounts/", false);
            uri.AppendPath(throughputPoolAccountName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Removes an existing Azure Cosmos DB database account from a throughput pool. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="throughputPoolName"> Cosmos DB Throughput Pool name. </param>
        /// <param name="throughputPoolAccountName"> Cosmos DB global database account in a Throughput Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="throughputPoolName"/> or <paramref name="throughputPoolAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="throughputPoolName"/> or <paramref name="throughputPoolAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string throughputPoolName, string throughputPoolAccountName, CancellationToken cancellationToken = default)
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
            if (throughputPoolName == null)
            {
                throw new ArgumentNullException(nameof(throughputPoolName));
            }
            if (throughputPoolName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(throughputPoolName));
            }
            if (throughputPoolAccountName == null)
            {
                throw new ArgumentNullException(nameof(throughputPoolAccountName));
            }
            if (throughputPoolAccountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(throughputPoolAccountName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, throughputPoolName, throughputPoolAccountName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Removes an existing Azure Cosmos DB database account from a throughput pool. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="throughputPoolName"> Cosmos DB Throughput Pool name. </param>
        /// <param name="throughputPoolAccountName"> Cosmos DB global database account in a Throughput Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="throughputPoolName"/> or <paramref name="throughputPoolAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="throughputPoolName"/> or <paramref name="throughputPoolAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string throughputPoolName, string throughputPoolAccountName, CancellationToken cancellationToken = default)
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
            if (throughputPoolName == null)
            {
                throw new ArgumentNullException(nameof(throughputPoolName));
            }
            if (throughputPoolName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(throughputPoolName));
            }
            if (throughputPoolAccountName == null)
            {
                throw new ArgumentNullException(nameof(throughputPoolAccountName));
            }
            if (throughputPoolAccountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(throughputPoolAccountName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, throughputPoolName, throughputPoolAccountName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
