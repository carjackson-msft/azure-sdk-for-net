// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S : IUtf8JsonSerializable, IJsonModel<DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (IsEnabled.HasValue)
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (WorkloadIdentityProviderId != null)
            {
                writer.WritePropertyName("workloadIdentityProviderId"u8);
                writer.WriteStringValue(WorkloadIdentityProviderId);
            }
            if (ServiceAccountEmailAddress != null)
            {
                writer.WritePropertyName("serviceAccountEmailAddress"u8);
                writer.WriteStringValue(ServiceAccountEmailAddress);
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

        DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S IJsonModel<DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S(document.RootElement, options);
        }

        internal static DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S DeserializeDefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<string> workloadIdentityProviderId = default;
            Optional<string> serviceAccountEmailAddress = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("workloadIdentityProviderId"u8))
                {
                    workloadIdentityProviderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceAccountEmailAddress"u8))
                {
                    serviceAccountEmailAddress = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S(Optional.ToNullable(enabled), workloadIdentityProviderId.Value, serviceAccountEmailAddress.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S)} does not support '{options.Format}' format.");
            }
        }

        DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S IPersistableModel<DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
