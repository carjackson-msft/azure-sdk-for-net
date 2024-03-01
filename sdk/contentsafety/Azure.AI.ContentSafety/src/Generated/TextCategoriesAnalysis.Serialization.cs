// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.ContentSafety
{
    public partial class TextCategoriesAnalysis : IUtf8JsonSerializable, IJsonModel<TextCategoriesAnalysis>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TextCategoriesAnalysis>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TextCategoriesAnalysis>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextCategoriesAnalysis>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextCategoriesAnalysis)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("category"u8);
            writer.WriteStringValue(Category.ToString());
            if (Severity.HasValue)
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteNumberValue(Severity.Value);
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

        TextCategoriesAnalysis IJsonModel<TextCategoriesAnalysis>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextCategoriesAnalysis>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextCategoriesAnalysis)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTextCategoriesAnalysis(document.RootElement, options);
        }

        internal static TextCategoriesAnalysis DeserializeTextCategoriesAnalysis(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TextCategory category = default;
            Optional<int> severity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("category"u8))
                {
                    category = new TextCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    severity = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TextCategoriesAnalysis(category, Optional.ToNullable(severity), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TextCategoriesAnalysis>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextCategoriesAnalysis>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TextCategoriesAnalysis)} does not support '{options.Format}' format.");
            }
        }

        TextCategoriesAnalysis IPersistableModel<TextCategoriesAnalysis>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextCategoriesAnalysis>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTextCategoriesAnalysis(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TextCategoriesAnalysis)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TextCategoriesAnalysis>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TextCategoriesAnalysis FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTextCategoriesAnalysis(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
