// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppCorsPolicy : IUtf8JsonSerializable, IJsonModel<ContainerAppCorsPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppCorsPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppCorsPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCorsPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppCorsPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("allowedOrigins"u8);
            writer.WriteStartArray();
            foreach (var item in AllowedOrigins)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (!(AllowedMethods is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("allowedMethods"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedMethods)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(AllowedHeaders is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("allowedHeaders"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedHeaders)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ExposeHeaders is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("exposeHeaders"u8);
                writer.WriteStartArray();
                foreach (var item in ExposeHeaders)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (MaxAge.HasValue)
            {
                writer.WritePropertyName("maxAge"u8);
                writer.WriteNumberValue(MaxAge.Value);
            }
            if (AllowCredentials.HasValue)
            {
                writer.WritePropertyName("allowCredentials"u8);
                writer.WriteBooleanValue(AllowCredentials.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ContainerAppCorsPolicy IJsonModel<ContainerAppCorsPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCorsPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppCorsPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppCorsPolicy(document.RootElement, options);
        }

        internal static ContainerAppCorsPolicy DeserializeContainerAppCorsPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> allowedOrigins = default;
            IList<string> allowedMethods = default;
            IList<string> allowedHeaders = default;
            IList<string> exposeHeaders = default;
            Optional<int> maxAge = default;
            Optional<bool> allowCredentials = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedOrigins"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedOrigins = array;
                    continue;
                }
                if (property.NameEquals("allowedMethods"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedMethods = array;
                    continue;
                }
                if (property.NameEquals("allowedHeaders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedHeaders = array;
                    continue;
                }
                if (property.NameEquals("exposeHeaders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    exposeHeaders = array;
                    continue;
                }
                if (property.NameEquals("maxAge"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxAge = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowCredentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowCredentials = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppCorsPolicy(
                allowedOrigins,
                allowedMethods ?? new ChangeTrackingList<string>(),
                allowedHeaders ?? new ChangeTrackingList<string>(),
                exposeHeaders ?? new ChangeTrackingList<string>(),
                Optional.ToNullable(maxAge),
                Optional.ToNullable(allowCredentials),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppCorsPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCorsPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppCorsPolicy)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppCorsPolicy IPersistableModel<ContainerAppCorsPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCorsPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppCorsPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppCorsPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppCorsPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
