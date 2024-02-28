// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class EntitiesTaskParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (StringIndexType.HasValue)
            {
                writer.WritePropertyName("stringIndexType"u8);
                writer.WriteStringValue(StringIndexType.Value.ToString());
            }
            if (ModelVersion != null)
            {
                writer.WritePropertyName("modelVersion"u8);
                writer.WriteStringValue(ModelVersion);
            }
            if (LoggingOptOut.HasValue)
            {
                writer.WritePropertyName("loggingOptOut"u8);
                writer.WriteBooleanValue(LoggingOptOut.Value);
            }
            writer.WriteEndObject();
        }

        internal static EntitiesTaskParameters DeserializeEntitiesTaskParameters(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StringIndexType> stringIndexType = default;
            Optional<string> modelVersion = default;
            Optional<bool> loggingOptOut = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stringIndexType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stringIndexType = new StringIndexType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loggingOptOut"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loggingOptOut = property.Value.GetBoolean();
                    continue;
                }
            }
            return new EntitiesTaskParameters(Optional.ToNullable(loggingOptOut), modelVersion.Value, Optional.ToNullable(stringIndexType));
        }
    }
}
