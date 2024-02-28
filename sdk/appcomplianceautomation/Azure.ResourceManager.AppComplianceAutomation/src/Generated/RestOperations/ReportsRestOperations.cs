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
using Azure.ResourceManager.AppComplianceAutomation.Models;

namespace Azure.ResourceManager.AppComplianceAutomation
{
    internal partial class ReportsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ReportsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ReportsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-11-16-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string skipToken, int? top, string select, string offerGuid, string reportCreatorTenantId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.AppComplianceAutomation/reports", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            if (select != null)
            {
                uri.AppendQuery("$select", select, true);
            }
            if (offerGuid != null)
            {
                uri.AppendQuery("offerGuid", offerGuid, true);
            }
            if (reportCreatorTenantId != null)
            {
                uri.AppendQuery("reportCreatorTenantId", reportCreatorTenantId, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the AppComplianceAutomation report list for the tenant. </summary>
        /// <param name="skipToken"> Skip over when retrieving results. </param>
        /// <param name="top"> Number of elements to return when retrieving results. </param>
        /// <param name="select"> OData Select statement. Limits the properties on each entry to just those requested, e.g. ?$select=reportName,id. </param>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="reportCreatorTenantId"> The tenant id of the report creator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ReportResourceList>> ListAsync(string skipToken = null, int? top = null, string select = null, string offerGuid = null, string reportCreatorTenantId = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(skipToken, top, select, offerGuid, reportCreatorTenantId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReportResourceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReportResourceList.DeserializeReportResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the AppComplianceAutomation report list for the tenant. </summary>
        /// <param name="skipToken"> Skip over when retrieving results. </param>
        /// <param name="top"> Number of elements to return when retrieving results. </param>
        /// <param name="select"> OData Select statement. Limits the properties on each entry to just those requested, e.g. ?$select=reportName,id. </param>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="reportCreatorTenantId"> The tenant id of the report creator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ReportResourceList> List(string skipToken = null, int? top = null, string select = null, string offerGuid = null, string reportCreatorTenantId = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(skipToken, top, select, offerGuid, reportCreatorTenantId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReportResourceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReportResourceList.DeserializeReportResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string skipToken, int? top, string select, string offerGuid, string reportCreatorTenantId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the AppComplianceAutomation report list for the tenant. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="skipToken"> Skip over when retrieving results. </param>
        /// <param name="top"> Number of elements to return when retrieving results. </param>
        /// <param name="select"> OData Select statement. Limits the properties on each entry to just those requested, e.g. ?$select=reportName,id. </param>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="reportCreatorTenantId"> The tenant id of the report creator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<ReportResourceList>> ListNextPageAsync(string nextLink, string skipToken = null, int? top = null, string select = null, string offerGuid = null, string reportCreatorTenantId = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink, skipToken, top, select, offerGuid, reportCreatorTenantId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReportResourceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReportResourceList.DeserializeReportResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the AppComplianceAutomation report list for the tenant. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="skipToken"> Skip over when retrieving results. </param>
        /// <param name="top"> Number of elements to return when retrieving results. </param>
        /// <param name="select"> OData Select statement. Limits the properties on each entry to just those requested, e.g. ?$select=reportName,id. </param>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="reportCreatorTenantId"> The tenant id of the report creator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<ReportResourceList> ListNextPage(string nextLink, string skipToken = null, int? top = null, string select = null, string offerGuid = null, string reportCreatorTenantId = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink, skipToken, top, select, offerGuid, reportCreatorTenantId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReportResourceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReportResourceList.DeserializeReportResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
