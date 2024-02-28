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
    public partial class SiteRecoveryProtectionContainerProperties : IUtf8JsonSerializable, IJsonModel<SiteRecoveryProtectionContainerProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryProtectionContainerProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryProtectionContainerProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryProtectionContainerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryProtectionContainerProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (FabricFriendlyName != null)
            {
                writer.WritePropertyName("fabricFriendlyName"u8);
                writer.WriteStringValue(FabricFriendlyName);
            }
            if (FriendlyName != null)
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (FabricType != null)
            {
                writer.WritePropertyName("fabricType"u8);
                writer.WriteStringValue(FabricType);
            }
            if (ProtectedItemCount.HasValue)
            {
                writer.WritePropertyName("protectedItemCount"u8);
                writer.WriteNumberValue(ProtectedItemCount.Value);
            }
            if (PairingStatus != null)
            {
                writer.WritePropertyName("pairingStatus"u8);
                writer.WriteStringValue(PairingStatus);
            }
            if (Role != null)
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role);
            }
            if (FabricSpecificDetails != null)
            {
                writer.WritePropertyName("fabricSpecificDetails"u8);
                writer.WriteObjectValue(FabricSpecificDetails);
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

        SiteRecoveryProtectionContainerProperties IJsonModel<SiteRecoveryProtectionContainerProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryProtectionContainerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryProtectionContainerProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryProtectionContainerProperties(document.RootElement, options);
        }

        internal static SiteRecoveryProtectionContainerProperties DeserializeSiteRecoveryProtectionContainerProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> fabricFriendlyName = default;
            Optional<string> friendlyName = default;
            Optional<string> fabricType = default;
            Optional<int> protectedItemCount = default;
            Optional<string> pairingStatus = default;
            Optional<string> role = default;
            Optional<ProtectionContainerFabricSpecificDetails> fabricSpecificDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fabricFriendlyName"u8))
                {
                    fabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricType"u8))
                {
                    fabricType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedItemCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pairingStatus"u8))
                {
                    pairingStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("role"u8))
                {
                    role = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricSpecificDetails = ProtectionContainerFabricSpecificDetails.DeserializeProtectionContainerFabricSpecificDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryProtectionContainerProperties(
                fabricFriendlyName.Value,
                friendlyName.Value,
                fabricType.Value,
                Optional.ToNullable(protectedItemCount),
                pairingStatus.Value,
                role.Value,
                fabricSpecificDetails.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryProtectionContainerProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryProtectionContainerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryProtectionContainerProperties)} does not support '{options.Format}' format.");
            }
        }

        SiteRecoveryProtectionContainerProperties IPersistableModel<SiteRecoveryProtectionContainerProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryProtectionContainerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryProtectionContainerProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryProtectionContainerProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryProtectionContainerProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
