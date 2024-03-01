// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    public partial class SelfHelpDiagnosticInsight : IUtf8JsonSerializable, IJsonModel<SelfHelpDiagnosticInsight>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SelfHelpDiagnosticInsight>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SelfHelpDiagnosticInsight>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpDiagnosticInsight>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SelfHelpDiagnosticInsight)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Title != null)
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (Results != null)
            {
                writer.WritePropertyName("results"u8);
                writer.WriteStringValue(Results);
            }
            if (InsightImportanceLevel.HasValue)
            {
                writer.WritePropertyName("importanceLevel"u8);
                writer.WriteStringValue(InsightImportanceLevel.Value.ToString());
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

        SelfHelpDiagnosticInsight IJsonModel<SelfHelpDiagnosticInsight>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpDiagnosticInsight>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SelfHelpDiagnosticInsight)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSelfHelpDiagnosticInsight(document.RootElement, options);
        }

        internal static SelfHelpDiagnosticInsight DeserializeSelfHelpDiagnosticInsight(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> title = default;
            Optional<string> results = default;
            Optional<SelfHelpImportanceLevel> importanceLevel = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("results"u8))
                {
                    results = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("importanceLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    importanceLevel = new SelfHelpImportanceLevel(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SelfHelpDiagnosticInsight(id.Value, title.Value, results.Value, Optional.ToNullable(importanceLevel), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SelfHelpDiagnosticInsight>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpDiagnosticInsight>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SelfHelpDiagnosticInsight)} does not support '{options.Format}' format.");
            }
        }

        SelfHelpDiagnosticInsight IPersistableModel<SelfHelpDiagnosticInsight>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpDiagnosticInsight>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSelfHelpDiagnosticInsight(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SelfHelpDiagnosticInsight)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SelfHelpDiagnosticInsight>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
