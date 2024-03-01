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

namespace Azure.ResourceManager.Network.Models
{
    public partial class EffectiveNetworkSecurityGroupAssociation : IUtf8JsonSerializable, IJsonModel<EffectiveNetworkSecurityGroupAssociation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EffectiveNetworkSecurityGroupAssociation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EffectiveNetworkSecurityGroupAssociation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EffectiveNetworkSecurityGroupAssociation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EffectiveNetworkSecurityGroupAssociation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (NetworkManager != null)
            {
                writer.WritePropertyName("networkManager"u8);
                JsonSerializer.Serialize(writer, NetworkManager);
            }
            if (Subnet != null)
            {
                writer.WritePropertyName("subnet"u8);
                JsonSerializer.Serialize(writer, Subnet);
            }
            if (NetworkInterface != null)
            {
                writer.WritePropertyName("networkInterface"u8);
                JsonSerializer.Serialize(writer, NetworkInterface);
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

        EffectiveNetworkSecurityGroupAssociation IJsonModel<EffectiveNetworkSecurityGroupAssociation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EffectiveNetworkSecurityGroupAssociation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EffectiveNetworkSecurityGroupAssociation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEffectiveNetworkSecurityGroupAssociation(document.RootElement, options);
        }

        internal static EffectiveNetworkSecurityGroupAssociation DeserializeEffectiveNetworkSecurityGroupAssociation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<WritableSubResource> networkManager = default;
            Optional<WritableSubResource> subnet = default;
            Optional<WritableSubResource> networkInterface = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkManager"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkManager = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("subnet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnet = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("networkInterface"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkInterface = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EffectiveNetworkSecurityGroupAssociation(networkManager, subnet, networkInterface, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EffectiveNetworkSecurityGroupAssociation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EffectiveNetworkSecurityGroupAssociation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EffectiveNetworkSecurityGroupAssociation)} does not support '{options.Format}' format.");
            }
        }

        EffectiveNetworkSecurityGroupAssociation IPersistableModel<EffectiveNetworkSecurityGroupAssociation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EffectiveNetworkSecurityGroupAssociation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEffectiveNetworkSecurityGroupAssociation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EffectiveNetworkSecurityGroupAssociation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EffectiveNetworkSecurityGroupAssociation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
