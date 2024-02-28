// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchNetworkConfiguration : IUtf8JsonSerializable, IJsonModel<BatchNetworkConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchNetworkConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchNetworkConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchNetworkConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchNetworkConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (SubnetId != null)
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (DynamicVNetAssignmentScope.HasValue)
            {
                writer.WritePropertyName("dynamicVnetAssignmentScope"u8);
                writer.WriteStringValue(DynamicVNetAssignmentScope.Value.ToSerialString());
            }
            if (EndpointConfiguration != null)
            {
                writer.WritePropertyName("endpointConfiguration"u8);
                writer.WriteObjectValue(EndpointConfiguration);
            }
            if (PublicIPAddressConfiguration != null)
            {
                writer.WritePropertyName("publicIPAddressConfiguration"u8);
                writer.WriteObjectValue(PublicIPAddressConfiguration);
            }
            if (EnableAcceleratedNetworking.HasValue)
            {
                writer.WritePropertyName("enableAcceleratedNetworking"u8);
                writer.WriteBooleanValue(EnableAcceleratedNetworking.Value);
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

        BatchNetworkConfiguration IJsonModel<BatchNetworkConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchNetworkConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchNetworkConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchNetworkConfiguration(document.RootElement, options);
        }

        internal static BatchNetworkConfiguration DeserializeBatchNetworkConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> subnetId = default;
            Optional<DynamicVNetAssignmentScope> dynamicVnetAssignmentScope = default;
            Optional<PoolEndpointConfiguration> endpointConfiguration = default;
            Optional<BatchPublicIPAddressConfiguration> publicIPAddressConfiguration = default;
            Optional<bool> enableAcceleratedNetworking = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dynamicVnetAssignmentScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dynamicVnetAssignmentScope = property.Value.GetString().ToDynamicVNetAssignmentScope();
                    continue;
                }
                if (property.NameEquals("endpointConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endpointConfiguration = PoolEndpointConfiguration.DeserializePoolEndpointConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("publicIPAddressConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicIPAddressConfiguration = BatchPublicIPAddressConfiguration.DeserializeBatchPublicIPAddressConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("enableAcceleratedNetworking"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableAcceleratedNetworking = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchNetworkConfiguration(
                subnetId.Value,
                Optional.ToNullable(dynamicVnetAssignmentScope),
                endpointConfiguration.Value,
                publicIPAddressConfiguration.Value,
                Optional.ToNullable(enableAcceleratedNetworking),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchNetworkConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchNetworkConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchNetworkConfiguration)} does not support '{options.Format}' format.");
            }
        }

        BatchNetworkConfiguration IPersistableModel<BatchNetworkConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchNetworkConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchNetworkConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchNetworkConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchNetworkConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
