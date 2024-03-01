// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceBus.Models
{
    public partial class ServiceBusClientAffineProperties : IUtf8JsonSerializable, IJsonModel<ServiceBusClientAffineProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceBusClientAffineProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceBusClientAffineProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusClientAffineProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceBusClientAffineProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ClientId != null)
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (IsDurable.HasValue)
            {
                writer.WritePropertyName("isDurable"u8);
                writer.WriteBooleanValue(IsDurable.Value);
            }
            if (IsShared.HasValue)
            {
                writer.WritePropertyName("isShared"u8);
                writer.WriteBooleanValue(IsShared.Value);
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

        ServiceBusClientAffineProperties IJsonModel<ServiceBusClientAffineProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusClientAffineProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceBusClientAffineProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceBusClientAffineProperties(document.RootElement, options);
        }

        internal static ServiceBusClientAffineProperties DeserializeServiceBusClientAffineProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> clientId = default;
            Optional<bool> isDurable = default;
            Optional<bool> isShared = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isDurable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDurable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isShared"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isShared = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceBusClientAffineProperties(clientId.Value, Optional.ToNullable(isDurable), Optional.ToNullable(isShared), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceBusClientAffineProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusClientAffineProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceBusClientAffineProperties)} does not support '{options.Format}' format.");
            }
        }

        ServiceBusClientAffineProperties IPersistableModel<ServiceBusClientAffineProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusClientAffineProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceBusClientAffineProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceBusClientAffineProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceBusClientAffineProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
