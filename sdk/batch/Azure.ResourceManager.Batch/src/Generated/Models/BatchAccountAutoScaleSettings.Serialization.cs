// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchAccountAutoScaleSettings : IUtf8JsonSerializable, IJsonModel<BatchAccountAutoScaleSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchAccountAutoScaleSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchAccountAutoScaleSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountAutoScaleSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchAccountAutoScaleSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("formula"u8);
            writer.WriteStringValue(Formula);
            if (EvaluationInterval.HasValue)
            {
                writer.WritePropertyName("evaluationInterval"u8);
                writer.WriteStringValue(EvaluationInterval.Value, "P");
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

        BatchAccountAutoScaleSettings IJsonModel<BatchAccountAutoScaleSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountAutoScaleSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchAccountAutoScaleSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchAccountAutoScaleSettings(document.RootElement, options);
        }

        internal static BatchAccountAutoScaleSettings DeserializeBatchAccountAutoScaleSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string formula = default;
            Optional<TimeSpan> evaluationInterval = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("formula"u8))
                {
                    formula = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("evaluationInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    evaluationInterval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchAccountAutoScaleSettings(formula, Optional.ToNullable(evaluationInterval), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchAccountAutoScaleSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountAutoScaleSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchAccountAutoScaleSettings)} does not support '{options.Format}' format.");
            }
        }

        BatchAccountAutoScaleSettings IPersistableModel<BatchAccountAutoScaleSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountAutoScaleSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchAccountAutoScaleSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchAccountAutoScaleSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchAccountAutoScaleSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
