// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnLinkBgpSettings : IUtf8JsonSerializable, IJsonModel<VpnLinkBgpSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VpnLinkBgpSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VpnLinkBgpSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnLinkBgpSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnLinkBgpSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Asn.HasValue)
            {
                writer.WritePropertyName("asn"u8);
                writer.WriteNumberValue(Asn.Value);
            }
            if (BgpPeeringAddress != null)
            {
                writer.WritePropertyName("bgpPeeringAddress"u8);
                writer.WriteStringValue(BgpPeeringAddress);
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

        VpnLinkBgpSettings IJsonModel<VpnLinkBgpSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnLinkBgpSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnLinkBgpSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnLinkBgpSettings(document.RootElement, options);
        }

        internal static VpnLinkBgpSettings DeserializeVpnLinkBgpSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> asn = default;
            Optional<string> bgpPeeringAddress = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("asn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    asn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("bgpPeeringAddress"u8))
                {
                    bgpPeeringAddress = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VpnLinkBgpSettings(Optional.ToNullable(asn), bgpPeeringAddress.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VpnLinkBgpSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnLinkBgpSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VpnLinkBgpSettings)} does not support '{options.Format}' format.");
            }
        }

        VpnLinkBgpSettings IPersistableModel<VpnLinkBgpSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnLinkBgpSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVpnLinkBgpSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VpnLinkBgpSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VpnLinkBgpSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
