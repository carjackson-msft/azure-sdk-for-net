// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ServiceBus.Models
{
    public partial class ServiceBusNetworkRuleSetVirtualNetworkRules : IUtf8JsonSerializable, IJsonModel<ServiceBusNetworkRuleSetVirtualNetworkRules>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceBusNetworkRuleSetVirtualNetworkRules>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceBusNetworkRuleSetVirtualNetworkRules>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusNetworkRuleSetVirtualNetworkRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceBusNetworkRuleSetVirtualNetworkRules)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Subnet != null)
            {
                writer.WritePropertyName("subnet"u8);
                JsonSerializer.Serialize(writer, Subnet);
            }
            if (IgnoreMissingVnetServiceEndpoint.HasValue)
            {
                writer.WritePropertyName("ignoreMissingVnetServiceEndpoint"u8);
                writer.WriteBooleanValue(IgnoreMissingVnetServiceEndpoint.Value);
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

        ServiceBusNetworkRuleSetVirtualNetworkRules IJsonModel<ServiceBusNetworkRuleSetVirtualNetworkRules>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusNetworkRuleSetVirtualNetworkRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceBusNetworkRuleSetVirtualNetworkRules)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceBusNetworkRuleSetVirtualNetworkRules(document.RootElement, options);
        }

        internal static ServiceBusNetworkRuleSetVirtualNetworkRules DeserializeServiceBusNetworkRuleSetVirtualNetworkRules(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<WritableSubResource> subnet = default;
            Optional<bool> ignoreMissingVnetServiceEndpoint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subnet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnet = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("ignoreMissingVnetServiceEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ignoreMissingVnetServiceEndpoint = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceBusNetworkRuleSetVirtualNetworkRules(subnet, Optional.ToNullable(ignoreMissingVnetServiceEndpoint), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceBusNetworkRuleSetVirtualNetworkRules>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusNetworkRuleSetVirtualNetworkRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceBusNetworkRuleSetVirtualNetworkRules)} does not support '{options.Format}' format.");
            }
        }

        ServiceBusNetworkRuleSetVirtualNetworkRules IPersistableModel<ServiceBusNetworkRuleSetVirtualNetworkRules>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusNetworkRuleSetVirtualNetworkRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceBusNetworkRuleSetVirtualNetworkRules(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceBusNetworkRuleSetVirtualNetworkRules)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceBusNetworkRuleSetVirtualNetworkRules>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
