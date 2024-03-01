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

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class DataNetworkConfiguration : IUtf8JsonSerializable, IJsonModel<DataNetworkConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataNetworkConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataNetworkConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataNetworkConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataNetworkConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("dataNetwork"u8);
            JsonSerializer.Serialize(writer, DataNetwork);
            writer.WritePropertyName("sessionAmbr"u8);
            writer.WriteObjectValue(SessionAmbr);
            if (FiveQi.HasValue)
            {
                writer.WritePropertyName("5qi"u8);
                writer.WriteNumberValue(FiveQi.Value);
            }
            if (AllocationAndRetentionPriorityLevel.HasValue)
            {
                writer.WritePropertyName("allocationAndRetentionPriorityLevel"u8);
                writer.WriteNumberValue(AllocationAndRetentionPriorityLevel.Value);
            }
            if (PreemptionCapability.HasValue)
            {
                writer.WritePropertyName("preemptionCapability"u8);
                writer.WriteStringValue(PreemptionCapability.Value.ToString());
            }
            if (PreemptionVulnerability.HasValue)
            {
                writer.WritePropertyName("preemptionVulnerability"u8);
                writer.WriteStringValue(PreemptionVulnerability.Value.ToString());
            }
            if (DefaultSessionType.HasValue)
            {
                writer.WritePropertyName("defaultSessionType"u8);
                writer.WriteStringValue(DefaultSessionType.Value.ToString());
            }
            if (!(AdditionalAllowedSessionTypes is ChangeTrackingList<MobileNetworkPduSessionType> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("additionalAllowedSessionTypes"u8);
                writer.WriteStartArray();
                foreach (var item in AdditionalAllowedSessionTypes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("allowedServices"u8);
            writer.WriteStartArray();
            foreach (var item in AllowedServices)
            {
                JsonSerializer.Serialize(writer, item);
            }
            writer.WriteEndArray();
            if (MaximumNumberOfBufferedPackets.HasValue)
            {
                writer.WritePropertyName("maximumNumberOfBufferedPackets"u8);
                writer.WriteNumberValue(MaximumNumberOfBufferedPackets.Value);
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

        DataNetworkConfiguration IJsonModel<DataNetworkConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataNetworkConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataNetworkConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataNetworkConfiguration(document.RootElement, options);
        }

        internal static DataNetworkConfiguration DeserializeDataNetworkConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WritableSubResource dataNetwork = default;
            Ambr sessionAmbr = default;
            Optional<int> _5qi = default;
            Optional<int> allocationAndRetentionPriorityLevel = default;
            Optional<MobileNetworkPreemptionCapability> preemptionCapability = default;
            Optional<MobileNetworkPreemptionVulnerability> preemptionVulnerability = default;
            Optional<MobileNetworkPduSessionType> defaultSessionType = default;
            IList<MobileNetworkPduSessionType> additionalAllowedSessionTypes = default;
            IList<WritableSubResource> allowedServices = default;
            Optional<int> maximumNumberOfBufferedPackets = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataNetwork"u8))
                {
                    dataNetwork = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sessionAmbr"u8))
                {
                    sessionAmbr = Ambr.DeserializeAmbr(property.Value, options);
                    continue;
                }
                if (property.NameEquals("5qi"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    _5qi = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allocationAndRetentionPriorityLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocationAndRetentionPriorityLevel = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("preemptionCapability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preemptionCapability = new MobileNetworkPreemptionCapability(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("preemptionVulnerability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preemptionVulnerability = new MobileNetworkPreemptionVulnerability(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("defaultSessionType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultSessionType = new MobileNetworkPduSessionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("additionalAllowedSessionTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MobileNetworkPduSessionType> array = new List<MobileNetworkPduSessionType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new MobileNetworkPduSessionType(item.GetString()));
                    }
                    additionalAllowedSessionTypes = array;
                    continue;
                }
                if (property.NameEquals("allowedServices"u8))
                {
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    allowedServices = array;
                    continue;
                }
                if (property.NameEquals("maximumNumberOfBufferedPackets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximumNumberOfBufferedPackets = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataNetworkConfiguration(
                dataNetwork,
                sessionAmbr,
                Optional.ToNullable(_5qi),
                Optional.ToNullable(allocationAndRetentionPriorityLevel),
                Optional.ToNullable(preemptionCapability),
                Optional.ToNullable(preemptionVulnerability),
                Optional.ToNullable(defaultSessionType),
                additionalAllowedSessionTypes ?? new ChangeTrackingList<MobileNetworkPduSessionType>(),
                allowedServices,
                Optional.ToNullable(maximumNumberOfBufferedPackets),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataNetworkConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataNetworkConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataNetworkConfiguration)} does not support '{options.Format}' format.");
            }
        }

        DataNetworkConfiguration IPersistableModel<DataNetworkConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataNetworkConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataNetworkConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataNetworkConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataNetworkConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
