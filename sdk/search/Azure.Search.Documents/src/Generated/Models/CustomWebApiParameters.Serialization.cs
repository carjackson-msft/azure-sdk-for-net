// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class CustomWebApiParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Uri != null)
            {
                writer.WritePropertyName("uri"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (!(HttpHeaders is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("httpHeaders"u8);
                writer.WriteStartObject();
                foreach (var item in HttpHeaders)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (HttpMethod != null)
            {
                writer.WritePropertyName("httpMethod"u8);
                writer.WriteStringValue(HttpMethod);
            }
            if (Timeout.HasValue)
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteStringValue(Timeout.Value, "P");
            }
            if (AuthResourceId != null)
            {
                if (AuthResourceId != null)
                {
                    writer.WritePropertyName("authResourceId"u8);
                    writer.WriteStringValue(AuthResourceId);
                }
                else
                {
                    writer.WriteNull("authResourceId");
                }
            }
            if (AuthIdentity != null)
            {
                if (AuthIdentity != null)
                {
                    writer.WritePropertyName("authIdentity"u8);
                    writer.WriteObjectValue(AuthIdentity);
                }
                else
                {
                    writer.WriteNull("authIdentity");
                }
            }
            writer.WriteEndObject();
        }

        internal static CustomWebApiParameters DeserializeCustomWebApiParameters(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> uri = default;
            IDictionary<string, string> httpHeaders = default;
            Optional<string> httpMethod = default;
            Optional<TimeSpan> timeout = default;
            Optional<string> authResourceId = default;
            Optional<SearchIndexerDataIdentity> authIdentity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("httpHeaders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    httpHeaders = dictionary;
                    continue;
                }
                if (property.NameEquals("httpMethod"u8))
                {
                    httpMethod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("authResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        authResourceId = null;
                        continue;
                    }
                    authResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        authIdentity = null;
                        continue;
                    }
                    authIdentity = SearchIndexerDataIdentity.DeserializeSearchIndexerDataIdentity(property.Value);
                    continue;
                }
            }
            return new CustomWebApiParameters(
                uri.Value,
                httpHeaders ?? new ChangeTrackingDictionary<string, string>(),
                httpMethod.Value,
                Optional.ToNullable(timeout),
                authResourceId.Value,
                authIdentity.Value);
        }
    }
}
