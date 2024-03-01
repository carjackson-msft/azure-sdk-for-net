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
    public partial class SiteRecoveryDiskDetails : IUtf8JsonSerializable, IJsonModel<SiteRecoveryDiskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryDiskDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryDiskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryDiskDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (MaxSizeMB.HasValue)
            {
                writer.WritePropertyName("maxSizeMB"u8);
                writer.WriteNumberValue(MaxSizeMB.Value);
            }
            if (VhdType != null)
            {
                writer.WritePropertyName("vhdType"u8);
                writer.WriteStringValue(VhdType);
            }
            if (VhdId != null)
            {
                writer.WritePropertyName("vhdId"u8);
                writer.WriteStringValue(VhdId);
            }
            if (VhdName != null)
            {
                writer.WritePropertyName("vhdName"u8);
                writer.WriteStringValue(VhdName);
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

        SiteRecoveryDiskDetails IJsonModel<SiteRecoveryDiskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryDiskDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryDiskDetails(document.RootElement, options);
        }

        internal static SiteRecoveryDiskDetails DeserializeSiteRecoveryDiskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> maxSizeMB = default;
            Optional<string> vhdType = default;
            Optional<string> vhdId = default;
            Optional<string> vhdName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxSizeMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxSizeMB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("vhdType"u8))
                {
                    vhdType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vhdId"u8))
                {
                    vhdId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vhdName"u8))
                {
                    vhdName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryDiskDetails(Optional.ToNullable(maxSizeMB), vhdType.Value, vhdId.Value, vhdName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryDiskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryDiskDetails)} does not support '{options.Format}' format.");
            }
        }

        SiteRecoveryDiskDetails IPersistableModel<SiteRecoveryDiskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryDiskDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryDiskDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryDiskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
