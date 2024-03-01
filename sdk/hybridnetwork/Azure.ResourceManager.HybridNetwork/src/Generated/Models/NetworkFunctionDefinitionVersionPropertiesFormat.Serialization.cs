// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    [PersistableModelProxy(typeof(UnknownNetworkFunctionDefinitionVersionPropertiesFormat))]
    public partial class NetworkFunctionDefinitionVersionPropertiesFormat : IUtf8JsonSerializable, IJsonModel<NetworkFunctionDefinitionVersionPropertiesFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkFunctionDefinitionVersionPropertiesFormat>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkFunctionDefinitionVersionPropertiesFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFunctionDefinitionVersionPropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkFunctionDefinitionVersionPropertiesFormat)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && VersionState.HasValue)
            {
                writer.WritePropertyName("versionState"u8);
                writer.WriteStringValue(VersionState.Value.ToString());
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (DeployParameters != null)
            {
                writer.WritePropertyName("deployParameters"u8);
                writer.WriteStringValue(DeployParameters);
            }
            writer.WritePropertyName("networkFunctionType"u8);
            writer.WriteStringValue(NetworkFunctionType.ToString());
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

        NetworkFunctionDefinitionVersionPropertiesFormat IJsonModel<NetworkFunctionDefinitionVersionPropertiesFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFunctionDefinitionVersionPropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkFunctionDefinitionVersionPropertiesFormat)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkFunctionDefinitionVersionPropertiesFormat(document.RootElement, options);
        }

        internal static NetworkFunctionDefinitionVersionPropertiesFormat DeserializeNetworkFunctionDefinitionVersionPropertiesFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("networkFunctionType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ContainerizedNetworkFunction": return ContainerizedNetworkFunctionDefinitionVersion.DeserializeContainerizedNetworkFunctionDefinitionVersion(element, options);
                    case "VirtualNetworkFunction": return VirtualNetworkFunctionDefinitionVersion.DeserializeVirtualNetworkFunctionDefinitionVersion(element, options);
                }
            }
            return UnknownNetworkFunctionDefinitionVersionPropertiesFormat.DeserializeUnknownNetworkFunctionDefinitionVersionPropertiesFormat(element, options);
        }

        BinaryData IPersistableModel<NetworkFunctionDefinitionVersionPropertiesFormat>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFunctionDefinitionVersionPropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkFunctionDefinitionVersionPropertiesFormat)} does not support '{options.Format}' format.");
            }
        }

        NetworkFunctionDefinitionVersionPropertiesFormat IPersistableModel<NetworkFunctionDefinitionVersionPropertiesFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFunctionDefinitionVersionPropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkFunctionDefinitionVersionPropertiesFormat(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkFunctionDefinitionVersionPropertiesFormat)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkFunctionDefinitionVersionPropertiesFormat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
