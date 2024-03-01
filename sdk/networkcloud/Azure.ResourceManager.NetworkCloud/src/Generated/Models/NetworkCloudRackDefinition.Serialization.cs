// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class NetworkCloudRackDefinition : IUtf8JsonSerializable, IJsonModel<NetworkCloudRackDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkCloudRackDefinition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkCloudRackDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudRackDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudRackDefinition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (AvailabilityZone != null)
            {
                writer.WritePropertyName("availabilityZone"u8);
                writer.WriteStringValue(AvailabilityZone);
            }
            if (!(BareMetalMachineConfigurationData is ChangeTrackingList<BareMetalMachineConfiguration> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("bareMetalMachineConfigurationData"u8);
                writer.WriteStartArray();
                foreach (var item in BareMetalMachineConfigurationData)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("networkRackId"u8);
            writer.WriteStringValue(NetworkRackId);
            if (RackLocation != null)
            {
                writer.WritePropertyName("rackLocation"u8);
                writer.WriteStringValue(RackLocation);
            }
            writer.WritePropertyName("rackSerialNumber"u8);
            writer.WriteStringValue(RackSerialNumber);
            writer.WritePropertyName("rackSkuId"u8);
            writer.WriteStringValue(RackSkuId);
            if (!(StorageApplianceConfigurationData is ChangeTrackingList<StorageApplianceConfiguration> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("storageApplianceConfigurationData"u8);
                writer.WriteStartArray();
                foreach (var item in StorageApplianceConfigurationData)
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

        NetworkCloudRackDefinition IJsonModel<NetworkCloudRackDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudRackDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudRackDefinition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudRackDefinition(document.RootElement, options);
        }

        internal static NetworkCloudRackDefinition DeserializeNetworkCloudRackDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> availabilityZone = default;
            IList<BareMetalMachineConfiguration> bareMetalMachineConfigurationData = default;
            ResourceIdentifier networkRackId = default;
            Optional<string> rackLocation = default;
            string rackSerialNumber = default;
            ResourceIdentifier rackSkuId = default;
            IList<StorageApplianceConfiguration> storageApplianceConfigurationData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("availabilityZone"u8))
                {
                    availabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bareMetalMachineConfigurationData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BareMetalMachineConfiguration> array = new List<BareMetalMachineConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BareMetalMachineConfiguration.DeserializeBareMetalMachineConfiguration(item, options));
                    }
                    bareMetalMachineConfigurationData = array;
                    continue;
                }
                if (property.NameEquals("networkRackId"u8))
                {
                    networkRackId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rackLocation"u8))
                {
                    rackLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rackSerialNumber"u8))
                {
                    rackSerialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rackSkuId"u8))
                {
                    rackSkuId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageApplianceConfigurationData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StorageApplianceConfiguration> array = new List<StorageApplianceConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageApplianceConfiguration.DeserializeStorageApplianceConfiguration(item, options));
                    }
                    storageApplianceConfigurationData = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkCloudRackDefinition(
                availabilityZone.Value,
                bareMetalMachineConfigurationData ?? new ChangeTrackingList<BareMetalMachineConfiguration>(),
                networkRackId,
                rackLocation.Value,
                rackSerialNumber,
                rackSkuId,
                storageApplianceConfigurationData ?? new ChangeTrackingList<StorageApplianceConfiguration>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkCloudRackDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudRackDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudRackDefinition)} does not support '{options.Format}' format.");
            }
        }

        NetworkCloudRackDefinition IPersistableModel<NetworkCloudRackDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudRackDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkCloudRackDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudRackDefinition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkCloudRackDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
