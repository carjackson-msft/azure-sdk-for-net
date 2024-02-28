// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(NotebookParameterConverter))]
    public partial class NotebookParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Value != null)
            {
                if (Value != null)
                {
                    writer.WritePropertyName("value"u8);
                    writer.WriteObjectValue(Value);
                }
                else
                {
                    writer.WriteNull("value");
                }
            }
            if (Type.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static NotebookParameter DeserializeNotebookParameter(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> value = default;
            Optional<NotebookParameterType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        value = null;
                        continue;
                    }
                    value = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new NotebookParameterType(property.Value.GetString());
                    continue;
                }
            }
            return new NotebookParameter(value.Value, Optional.ToNullable(type));
        }

        internal partial class NotebookParameterConverter : JsonConverter<NotebookParameter>
        {
            public override void Write(Utf8JsonWriter writer, NotebookParameter model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override NotebookParameter Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeNotebookParameter(document.RootElement);
            }
        }
    }
}
