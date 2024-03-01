// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class FirewallVwanConfiguration : IUtf8JsonSerializable, IJsonModel<FirewallVwanConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallVwanConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FirewallVwanConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallVwanConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallVwanConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (NetworkVirtualApplianceId != null)
            {
                writer.WritePropertyName("networkVirtualApplianceId"u8);
                writer.WriteStringValue(NetworkVirtualApplianceId);
            }
            writer.WritePropertyName("vHub"u8);
            writer.WriteObjectValue(Vhub);
            if (TrustSubnet != null)
            {
                writer.WritePropertyName("trustSubnet"u8);
                writer.WriteObjectValue(TrustSubnet);
            }
            if (UnTrustSubnet != null)
            {
                writer.WritePropertyName("unTrustSubnet"u8);
                writer.WriteObjectValue(UnTrustSubnet);
            }
            if (IPOfTrustSubnetForUdr != null)
            {
                writer.WritePropertyName("ipOfTrustSubnetForUdr"u8);
                writer.WriteObjectValue(IPOfTrustSubnetForUdr);
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

        FirewallVwanConfiguration IJsonModel<FirewallVwanConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallVwanConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallVwanConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallVwanConfiguration(document.RootElement, options);
        }

        internal static FirewallVwanConfiguration DeserializeFirewallVwanConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> networkVirtualApplianceId = default;
            IPAddressSpaceInfo vHub = default;
            Optional<IPAddressSpaceInfo> trustSubnet = default;
            Optional<IPAddressSpaceInfo> unTrustSubnet = default;
            Optional<IPAddressInfo> ipOfTrustSubnetForUdr = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkVirtualApplianceId"u8))
                {
                    networkVirtualApplianceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vHub"u8))
                {
                    vHub = IPAddressSpaceInfo.DeserializeIPAddressSpaceInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("trustSubnet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trustSubnet = IPAddressSpaceInfo.DeserializeIPAddressSpaceInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("unTrustSubnet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unTrustSubnet = IPAddressSpaceInfo.DeserializeIPAddressSpaceInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("ipOfTrustSubnetForUdr"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipOfTrustSubnetForUdr = IPAddressInfo.DeserializeIPAddressInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FirewallVwanConfiguration(
                networkVirtualApplianceId.Value,
                vHub,
                trustSubnet.Value,
                unTrustSubnet.Value,
                ipOfTrustSubnetForUdr.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirewallVwanConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallVwanConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FirewallVwanConfiguration)} does not support '{options.Format}' format.");
            }
        }

        FirewallVwanConfiguration IPersistableModel<FirewallVwanConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallVwanConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFirewallVwanConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FirewallVwanConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirewallVwanConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
