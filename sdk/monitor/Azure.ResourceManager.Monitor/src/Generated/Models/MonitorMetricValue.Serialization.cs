// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorMetricValue : IUtf8JsonSerializable, IJsonModel<MonitorMetricValue>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorMetricValue>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitorMetricValue>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorMetricValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorMetricValue)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("timeStamp"u8);
            writer.WriteStringValue(TimeStamp, "O");
            if (Average.HasValue)
            {
                writer.WritePropertyName("average"u8);
                writer.WriteNumberValue(Average.Value);
            }
            if (Minimum.HasValue)
            {
                writer.WritePropertyName("minimum"u8);
                writer.WriteNumberValue(Minimum.Value);
            }
            if (Maximum.HasValue)
            {
                writer.WritePropertyName("maximum"u8);
                writer.WriteNumberValue(Maximum.Value);
            }
            if (Total.HasValue)
            {
                writer.WritePropertyName("total"u8);
                writer.WriteNumberValue(Total.Value);
            }
            if (Count.HasValue)
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
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

        MonitorMetricValue IJsonModel<MonitorMetricValue>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorMetricValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorMetricValue)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorMetricValue(document.RootElement, options);
        }

        internal static MonitorMetricValue DeserializeMonitorMetricValue(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset timeStamp = default;
            Optional<double> average = default;
            Optional<double> minimum = default;
            Optional<double> maximum = default;
            Optional<double> total = default;
            Optional<double> count = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeStamp"u8))
                {
                    timeStamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("average"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    average = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("minimum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimum = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("maximum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximum = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("total"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    total = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MonitorMetricValue(
                timeStamp,
                Optional.ToNullable(average),
                Optional.ToNullable(minimum),
                Optional.ToNullable(maximum),
                Optional.ToNullable(total),
                Optional.ToNullable(count),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitorMetricValue>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorMetricValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitorMetricValue)} does not support '{options.Format}' format.");
            }
        }

        MonitorMetricValue IPersistableModel<MonitorMetricValue>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorMetricValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitorMetricValue(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitorMetricValue)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorMetricValue>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
