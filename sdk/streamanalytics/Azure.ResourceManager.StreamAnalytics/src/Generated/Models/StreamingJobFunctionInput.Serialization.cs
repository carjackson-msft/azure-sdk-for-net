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
    public partial class StreamingJobFunctionInput : IUtf8JsonSerializable, IJsonModel<StreamingJobFunctionInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamingJobFunctionInput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StreamingJobFunctionInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobFunctionInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingJobFunctionInput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DataType != null)
            {
                writer.WritePropertyName("dataType"u8);
                writer.WriteStringValue(DataType);
            }
            if (IsConfigurationParameter.HasValue)
            {
                if (IsConfigurationParameter != null)
                {
                    writer.WritePropertyName("isConfigurationParameter"u8);
                    writer.WriteBooleanValue(IsConfigurationParameter.Value);
                }
                else
                {
                    writer.WriteNull("isConfigurationParameter");
                }
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

        StreamingJobFunctionInput IJsonModel<StreamingJobFunctionInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobFunctionInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingJobFunctionInput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingJobFunctionInput(document.RootElement, options);
        }

        internal static StreamingJobFunctionInput DeserializeStreamingJobFunctionInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> dataType = default;
            Optional<bool?> isConfigurationParameter = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataType"u8))
                {
                    dataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isConfigurationParameter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        isConfigurationParameter = null;
                        continue;
                    }
                    isConfigurationParameter = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StreamingJobFunctionInput(dataType.Value, Optional.ToNullable(isConfigurationParameter), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StreamingJobFunctionInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobFunctionInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamingJobFunctionInput)} does not support '{options.Format}' format.");
            }
        }

        StreamingJobFunctionInput IPersistableModel<StreamingJobFunctionInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobFunctionInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamingJobFunctionInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamingJobFunctionInput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingJobFunctionInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
