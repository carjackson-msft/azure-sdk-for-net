// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    internal partial class StreamingJobInputWatermarkProperties : IUtf8JsonSerializable, IJsonModel<StreamingJobInputWatermarkProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamingJobInputWatermarkProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StreamingJobInputWatermarkProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobInputWatermarkProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingJobInputWatermarkProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (WatermarkMode.HasValue)
            {
                writer.WritePropertyName("watermarkMode"u8);
                writer.WriteStringValue(WatermarkMode.Value.ToString());
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

        StreamingJobInputWatermarkProperties IJsonModel<StreamingJobInputWatermarkProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobInputWatermarkProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingJobInputWatermarkProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingJobInputWatermarkProperties(document.RootElement, options);
        }

        internal static StreamingJobInputWatermarkProperties DeserializeStreamingJobInputWatermarkProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StreamingJobInputWatermarkMode> watermarkMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("watermarkMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    watermarkMode = new StreamingJobInputWatermarkMode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StreamingJobInputWatermarkProperties(Optional.ToNullable(watermarkMode), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StreamingJobInputWatermarkProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobInputWatermarkProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamingJobInputWatermarkProperties)} does not support '{options.Format}' format.");
            }
        }

        StreamingJobInputWatermarkProperties IPersistableModel<StreamingJobInputWatermarkProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobInputWatermarkProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamingJobInputWatermarkProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamingJobInputWatermarkProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingJobInputWatermarkProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
