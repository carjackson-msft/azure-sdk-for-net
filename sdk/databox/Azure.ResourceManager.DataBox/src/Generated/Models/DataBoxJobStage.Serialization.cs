// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxJobStage : IUtf8JsonSerializable, IJsonModel<DataBoxJobStage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxJobStage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxJobStage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxJobStage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxJobStage)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && StageName.HasValue)
            {
                writer.WritePropertyName("stageName"u8);
                writer.WriteStringValue(StageName.Value.ToString());
            }
            if (options.Format != "W" && DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && StageStatus.HasValue)
            {
                writer.WritePropertyName("stageStatus"u8);
                writer.WriteStringValue(StageStatus.Value.ToSerialString());
            }
            if (options.Format != "W" && StageTime.HasValue)
            {
                writer.WritePropertyName("stageTime"u8);
                writer.WriteStringValue(StageTime.Value, "O");
            }
            if (options.Format != "W" && JobStageDetails != null)
            {
                writer.WritePropertyName("jobStageDetails"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(JobStageDetails);
#else
                using (JsonDocument document = JsonDocument.Parse(JobStageDetails))
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

        DataBoxJobStage IJsonModel<DataBoxJobStage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxJobStage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxJobStage)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxJobStage(document.RootElement, options);
        }

        internal static DataBoxJobStage DeserializeDataBoxJobStage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataBoxStageName> stageName = default;
            Optional<string> displayName = default;
            Optional<DataBoxStageStatus> stageStatus = default;
            Optional<DateTimeOffset> stageTime = default;
            Optional<BinaryData> jobStageDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stageName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stageName = new DataBoxStageName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stageStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stageStatus = property.Value.GetString().ToDataBoxStageStatus();
                    continue;
                }
                if (property.NameEquals("stageTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stageTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("jobStageDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobStageDetails = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxJobStage(
                Optional.ToNullable(stageName),
                displayName.Value,
                Optional.ToNullable(stageStatus),
                Optional.ToNullable(stageTime),
                jobStageDetails.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxJobStage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxJobStage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxJobStage)} does not support '{options.Format}' format.");
            }
        }

        DataBoxJobStage IPersistableModel<DataBoxJobStage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxJobStage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxJobStage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxJobStage)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxJobStage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
