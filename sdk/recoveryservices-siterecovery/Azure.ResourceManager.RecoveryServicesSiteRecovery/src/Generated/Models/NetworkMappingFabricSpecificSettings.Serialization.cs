// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [PersistableModelProxy(typeof(UnknownNetworkMappingFabricSpecificSettings))]
    public partial class NetworkMappingFabricSpecificSettings : IUtf8JsonSerializable, IJsonModel<NetworkMappingFabricSpecificSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkMappingFabricSpecificSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkMappingFabricSpecificSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkMappingFabricSpecificSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkMappingFabricSpecificSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        NetworkMappingFabricSpecificSettings IJsonModel<NetworkMappingFabricSpecificSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkMappingFabricSpecificSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkMappingFabricSpecificSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkMappingFabricSpecificSettings(document.RootElement, options);
        }

        internal static NetworkMappingFabricSpecificSettings DeserializeNetworkMappingFabricSpecificSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureToAzure": return A2ANetworkMappingSettings.DeserializeA2ANetworkMappingSettings(element, options);
                    case "VmmToAzure": return VmmToAzureNetworkMappingSettings.DeserializeVmmToAzureNetworkMappingSettings(element, options);
                    case "VmmToVmm": return VmmToVmmNetworkMappingSettings.DeserializeVmmToVmmNetworkMappingSettings(element, options);
                }
            }
            return UnknownNetworkMappingFabricSpecificSettings.DeserializeUnknownNetworkMappingFabricSpecificSettings(element, options);
        }

        BinaryData IPersistableModel<NetworkMappingFabricSpecificSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkMappingFabricSpecificSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkMappingFabricSpecificSettings)} does not support '{options.Format}' format.");
            }
        }

        NetworkMappingFabricSpecificSettings IPersistableModel<NetworkMappingFabricSpecificSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkMappingFabricSpecificSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkMappingFabricSpecificSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkMappingFabricSpecificSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkMappingFabricSpecificSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
