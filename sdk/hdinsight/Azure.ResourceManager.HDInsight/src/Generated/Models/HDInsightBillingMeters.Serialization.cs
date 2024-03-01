// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightBillingMeters : IUtf8JsonSerializable, IJsonModel<HDInsightBillingMeters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightBillingMeters>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HDInsightBillingMeters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightBillingMeters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightBillingMeters)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (MeterParameter != null)
            {
                writer.WritePropertyName("meterParameter"u8);
                writer.WriteStringValue(MeterParameter);
            }
            if (Meter != null)
            {
                writer.WritePropertyName("meter"u8);
                writer.WriteStringValue(Meter);
            }
            if (Unit != null)
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit);
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

        HDInsightBillingMeters IJsonModel<HDInsightBillingMeters>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightBillingMeters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightBillingMeters)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightBillingMeters(document.RootElement, options);
        }

        internal static HDInsightBillingMeters DeserializeHDInsightBillingMeters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> meterParameter = default;
            Optional<string> meter = default;
            Optional<string> unit = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("meterParameter"u8))
                {
                    meterParameter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("meter"u8))
                {
                    meter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HDInsightBillingMeters(meterParameter.Value, meter.Value, unit.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightBillingMeters>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightBillingMeters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightBillingMeters)} does not support '{options.Format}' format.");
            }
        }

        HDInsightBillingMeters IPersistableModel<HDInsightBillingMeters>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightBillingMeters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightBillingMeters(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightBillingMeters)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightBillingMeters>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
