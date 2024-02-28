// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetworkSiblingSet : IUtf8JsonSerializable, IJsonModel<NetworkSiblingSet>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkSiblingSet>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkSiblingSet>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSiblingSet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkSiblingSet)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (NetworkSiblingSetId != null)
            {
                writer.WritePropertyName("networkSiblingSetId"u8);
                writer.WriteStringValue(NetworkSiblingSetId);
            }
            if (SubnetId != null)
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (NetworkSiblingSetStateId != null)
            {
                writer.WritePropertyName("networkSiblingSetStateId"u8);
                writer.WriteStringValue(NetworkSiblingSetStateId);
            }
            if (NetworkFeatures.HasValue)
            {
                writer.WritePropertyName("networkFeatures"u8);
                writer.WriteStringValue(NetworkFeatures.Value.ToString());
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (!(NicInfoList is ChangeTrackingList<NicInfo> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("nicInfoList"u8);
                writer.WriteStartArray();
                foreach (var item in NicInfoList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        NetworkSiblingSet IJsonModel<NetworkSiblingSet>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSiblingSet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkSiblingSet)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkSiblingSet(document.RootElement, options);
        }

        internal static NetworkSiblingSet DeserializeNetworkSiblingSet(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> networkSiblingSetId = default;
            Optional<ResourceIdentifier> subnetId = default;
            Optional<string> networkSiblingSetStateId = default;
            Optional<NetAppNetworkFeature> networkFeatures = default;
            Optional<NetworkSiblingSetProvisioningState> provisioningState = default;
            IReadOnlyList<NicInfo> nicInfoList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkSiblingSetId"u8))
                {
                    networkSiblingSetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkSiblingSetStateId"u8))
                {
                    networkSiblingSetStateId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkFeatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkFeatures = new NetAppNetworkFeature(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new NetworkSiblingSetProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nicInfoList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NicInfo> array = new List<NicInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NicInfo.DeserializeNicInfo(item, options));
                    }
                    nicInfoList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkSiblingSet(
                networkSiblingSetId.Value,
                subnetId.Value,
                networkSiblingSetStateId.Value,
                Optional.ToNullable(networkFeatures),
                Optional.ToNullable(provisioningState),
                nicInfoList ?? new ChangeTrackingList<NicInfo>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkSiblingSet>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSiblingSet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkSiblingSet)} does not support '{options.Format}' format.");
            }
        }

        NetworkSiblingSet IPersistableModel<NetworkSiblingSet>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSiblingSet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkSiblingSet(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkSiblingSet)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkSiblingSet>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
