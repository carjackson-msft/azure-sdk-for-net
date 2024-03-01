// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabArmTemplateInfo : IUtf8JsonSerializable, IJsonModel<DevTestLabArmTemplateInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabArmTemplateInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevTestLabArmTemplateInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabArmTemplateInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabArmTemplateInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Template != null)
            {
                writer.WritePropertyName("template"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Template);
#else
                using (JsonDocument document = JsonDocument.Parse(Template))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Parameters != null)
            {
                writer.WritePropertyName("parameters"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Parameters);
#else
                using (JsonDocument document = JsonDocument.Parse(Parameters))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        DevTestLabArmTemplateInfo IJsonModel<DevTestLabArmTemplateInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabArmTemplateInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabArmTemplateInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabArmTemplateInfo(document.RootElement, options);
        }

        internal static DevTestLabArmTemplateInfo DeserializeDevTestLabArmTemplateInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BinaryData> template = default;
            Optional<BinaryData> parameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("template"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    template = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parameters = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevTestLabArmTemplateInfo(template.Value, parameters.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabArmTemplateInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabArmTemplateInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabArmTemplateInfo)} does not support '{options.Format}' format.");
            }
        }

        DevTestLabArmTemplateInfo IPersistableModel<DevTestLabArmTemplateInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabArmTemplateInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevTestLabArmTemplateInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabArmTemplateInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabArmTemplateInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
