// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class FadeOptions : IUtf8JsonSerializable, IJsonModel<FadeOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FadeOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FadeOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FadeOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FadeOptions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("duration"u8);
            writer.WriteStringValue(Duration, "P");
            writer.WritePropertyName("fadeColor"u8);
            writer.WriteStringValue(FadeColor);
            if (Start != null)
            {
                writer.WritePropertyName("start"u8);
                writer.WriteStringValue(Start);
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

        FadeOptions IJsonModel<FadeOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FadeOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FadeOptions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFadeOptions(document.RootElement, options);
        }

        internal static FadeOptions DeserializeFadeOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSpan duration = default;
            string fadeColor = default;
            Optional<string> start = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("duration"u8))
                {
                    duration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("fadeColor"u8))
                {
                    fadeColor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("start"u8))
                {
                    start = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FadeOptions(duration, fadeColor, start.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FadeOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FadeOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FadeOptions)} does not support '{options.Format}' format.");
            }
        }

        FadeOptions IPersistableModel<FadeOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FadeOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFadeOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FadeOptions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FadeOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
