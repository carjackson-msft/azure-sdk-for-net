// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareCbtSecurityProfileProperties : IUtf8JsonSerializable, IJsonModel<VMwareCbtSecurityProfileProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareCbtSecurityProfileProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VMwareCbtSecurityProfileProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtSecurityProfileProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareCbtSecurityProfileProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (TargetVmSecurityType.HasValue)
            {
                writer.WritePropertyName("targetVmSecurityType"u8);
                writer.WriteStringValue(TargetVmSecurityType.Value.ToString());
            }
            if (IsTargetVmSecureBootEnabled != null)
            {
                writer.WritePropertyName("isTargetVmSecureBootEnabled"u8);
                writer.WriteStringValue(IsTargetVmSecureBootEnabled);
            }
            if (IsTargetVmTpmEnabled != null)
            {
                writer.WritePropertyName("isTargetVmTpmEnabled"u8);
                writer.WriteStringValue(IsTargetVmTpmEnabled);
            }
            if (IsTargetVmIntegrityMonitoringEnabled != null)
            {
                writer.WritePropertyName("isTargetVmIntegrityMonitoringEnabled"u8);
                writer.WriteStringValue(IsTargetVmIntegrityMonitoringEnabled);
            }
            if (IsTargetVmConfidentialEncryptionEnabled != null)
            {
                writer.WritePropertyName("isTargetVmConfidentialEncryptionEnabled"u8);
                writer.WriteStringValue(IsTargetVmConfidentialEncryptionEnabled);
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

        VMwareCbtSecurityProfileProperties IJsonModel<VMwareCbtSecurityProfileProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtSecurityProfileProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareCbtSecurityProfileProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareCbtSecurityProfileProperties(document.RootElement, options);
        }

        internal static VMwareCbtSecurityProfileProperties DeserializeVMwareCbtSecurityProfileProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SiteRecoveryVmSecurityType> targetVmSecurityType = default;
            Optional<string> isTargetVmSecureBootEnabled = default;
            Optional<string> isTargetVmTpmEnabled = default;
            Optional<string> isTargetVmIntegrityMonitoringEnabled = default;
            Optional<string> isTargetVmConfidentialEncryptionEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetVmSecurityType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetVmSecurityType = new SiteRecoveryVmSecurityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isTargetVmSecureBootEnabled"u8))
                {
                    isTargetVmSecureBootEnabled = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isTargetVmTpmEnabled"u8))
                {
                    isTargetVmTpmEnabled = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isTargetVmIntegrityMonitoringEnabled"u8))
                {
                    isTargetVmIntegrityMonitoringEnabled = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isTargetVmConfidentialEncryptionEnabled"u8))
                {
                    isTargetVmConfidentialEncryptionEnabled = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VMwareCbtSecurityProfileProperties(
                Optional.ToNullable(targetVmSecurityType),
                isTargetVmSecureBootEnabled.Value,
                isTargetVmTpmEnabled.Value,
                isTargetVmIntegrityMonitoringEnabled.Value,
                isTargetVmConfidentialEncryptionEnabled.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VMwareCbtSecurityProfileProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtSecurityProfileProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VMwareCbtSecurityProfileProperties)} does not support '{options.Format}' format.");
            }
        }

        VMwareCbtSecurityProfileProperties IPersistableModel<VMwareCbtSecurityProfileProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtSecurityProfileProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVMwareCbtSecurityProfileProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareCbtSecurityProfileProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareCbtSecurityProfileProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
