// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class JobStatusMessage : IUtf8JsonSerializable, IJsonModel<JobStatusMessage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JobStatusMessage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<JobStatusMessage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobStatusMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JobStatusMessage)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Code != null)
            {
                if (Code != null)
                {
                    writer.WritePropertyName("code"u8);
                    writer.WriteStringValue(Code);
                }
                else
                {
                    writer.WriteNull("code");
                }
            }
            if (options.Format != "W" && CreatedOn.HasValue)
            {
                if (CreatedOn != null)
                {
                    writer.WritePropertyName("createdDateTime"u8);
                    writer.WriteStringValue(CreatedOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("createdDateTime");
                }
            }
            if (options.Format != "W" && Level.HasValue)
            {
                writer.WritePropertyName("level"u8);
                writer.WriteStringValue(Level.Value.ToString());
            }
            if (options.Format != "W" && Message != null)
            {
                if (Message != null)
                {
                    writer.WritePropertyName("message"u8);
                    writer.WriteStringValue(Message);
                }
                else
                {
                    writer.WriteNull("message");
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

        JobStatusMessage IJsonModel<JobStatusMessage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobStatusMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JobStatusMessage)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJobStatusMessage(document.RootElement, options);
        }

        internal static JobStatusMessage DeserializeJobStatusMessage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> code = default;
            Optional<DateTimeOffset?> createdDateTime = default;
            Optional<JobStatusMessageLevel> level = default;
            Optional<string> message = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        code = null;
                        continue;
                    }
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        createdDateTime = null;
                        continue;
                    }
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("level"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    level = new JobStatusMessageLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        message = null;
                        continue;
                    }
                    message = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new JobStatusMessage(code.Value, Optional.ToNullable(createdDateTime), Optional.ToNullable(level), message.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<JobStatusMessage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobStatusMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(JobStatusMessage)} does not support '{options.Format}' format.");
            }
        }

        JobStatusMessage IPersistableModel<JobStatusMessage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobStatusMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeJobStatusMessage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(JobStatusMessage)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<JobStatusMessage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
