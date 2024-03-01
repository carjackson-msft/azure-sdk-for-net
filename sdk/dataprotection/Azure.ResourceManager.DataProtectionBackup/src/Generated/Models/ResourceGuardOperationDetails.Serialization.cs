// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class ResourceGuardOperationDetails : IUtf8JsonSerializable, IJsonModel<ResourceGuardOperationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceGuardOperationDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceGuardOperationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceGuardOperationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceGuardOperationDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && VaultCriticalOperation != null)
            {
                writer.WritePropertyName("vaultCriticalOperation"u8);
                writer.WriteStringValue(VaultCriticalOperation);
            }
            if (options.Format != "W" && RequestResourceType.HasValue)
            {
                writer.WritePropertyName("requestResourceType"u8);
                writer.WriteStringValue(RequestResourceType.Value);
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

        ResourceGuardOperationDetails IJsonModel<ResourceGuardOperationDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceGuardOperationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceGuardOperationDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceGuardOperationDetails(document.RootElement, options);
        }

        internal static ResourceGuardOperationDetails DeserializeResourceGuardOperationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> vaultCriticalOperation = default;
            Optional<ResourceType> requestResourceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vaultCriticalOperation"u8))
                {
                    vaultCriticalOperation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestResourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestResourceType = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceGuardOperationDetails(vaultCriticalOperation.Value, Optional.ToNullable(requestResourceType), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceGuardOperationDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceGuardOperationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceGuardOperationDetails)} does not support '{options.Format}' format.");
            }
        }

        ResourceGuardOperationDetails IPersistableModel<ResourceGuardOperationDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceGuardOperationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceGuardOperationDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceGuardOperationDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceGuardOperationDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
