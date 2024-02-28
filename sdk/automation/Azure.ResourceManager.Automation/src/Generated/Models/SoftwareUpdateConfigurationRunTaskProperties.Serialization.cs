// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class SoftwareUpdateConfigurationRunTaskProperties : IUtf8JsonSerializable, IJsonModel<SoftwareUpdateConfigurationRunTaskProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SoftwareUpdateConfigurationRunTaskProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SoftwareUpdateConfigurationRunTaskProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationRunTaskProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationRunTaskProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Status != null)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Source != null)
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (JobId.HasValue)
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId.Value);
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

        SoftwareUpdateConfigurationRunTaskProperties IJsonModel<SoftwareUpdateConfigurationRunTaskProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationRunTaskProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationRunTaskProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSoftwareUpdateConfigurationRunTaskProperties(document.RootElement, options);
        }

        internal static SoftwareUpdateConfigurationRunTaskProperties DeserializeSoftwareUpdateConfigurationRunTaskProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> status = default;
            Optional<string> source = default;
            Optional<Guid> jobId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SoftwareUpdateConfigurationRunTaskProperties(status.Value, source.Value, Optional.ToNullable(jobId), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SoftwareUpdateConfigurationRunTaskProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationRunTaskProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationRunTaskProperties)} does not support '{options.Format}' format.");
            }
        }

        SoftwareUpdateConfigurationRunTaskProperties IPersistableModel<SoftwareUpdateConfigurationRunTaskProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationRunTaskProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSoftwareUpdateConfigurationRunTaskProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationRunTaskProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SoftwareUpdateConfigurationRunTaskProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
