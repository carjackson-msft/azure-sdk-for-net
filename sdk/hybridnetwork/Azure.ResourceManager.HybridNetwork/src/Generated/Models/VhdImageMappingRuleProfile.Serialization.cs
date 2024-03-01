// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    internal partial class VhdImageMappingRuleProfile : IUtf8JsonSerializable, IJsonModel<VhdImageMappingRuleProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VhdImageMappingRuleProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VhdImageMappingRuleProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VhdImageMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VhdImageMappingRuleProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (UserConfiguration != null)
            {
                writer.WritePropertyName("userConfiguration"u8);
                writer.WriteStringValue(UserConfiguration);
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

        VhdImageMappingRuleProfile IJsonModel<VhdImageMappingRuleProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VhdImageMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VhdImageMappingRuleProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVhdImageMappingRuleProfile(document.RootElement, options);
        }

        internal static VhdImageMappingRuleProfile DeserializeVhdImageMappingRuleProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> userConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userConfiguration"u8))
                {
                    userConfiguration = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VhdImageMappingRuleProfile(userConfiguration.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VhdImageMappingRuleProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VhdImageMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VhdImageMappingRuleProfile)} does not support '{options.Format}' format.");
            }
        }

        VhdImageMappingRuleProfile IPersistableModel<VhdImageMappingRuleProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VhdImageMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVhdImageMappingRuleProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VhdImageMappingRuleProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VhdImageMappingRuleProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
