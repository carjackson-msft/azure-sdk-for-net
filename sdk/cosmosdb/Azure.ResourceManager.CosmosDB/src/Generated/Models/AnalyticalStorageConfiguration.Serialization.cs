// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class AnalyticalStorageConfiguration : IUtf8JsonSerializable, IJsonModel<AnalyticalStorageConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AnalyticalStorageConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AnalyticalStorageConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyticalStorageConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalyticalStorageConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (SchemaType.HasValue)
            {
                writer.WritePropertyName("schemaType"u8);
                writer.WriteStringValue(SchemaType.Value.ToString());
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

        AnalyticalStorageConfiguration IJsonModel<AnalyticalStorageConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyticalStorageConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalyticalStorageConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalyticalStorageConfiguration(document.RootElement, options);
        }

        internal static AnalyticalStorageConfiguration DeserializeAnalyticalStorageConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AnalyticalStorageSchemaType> schemaType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("schemaType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schemaType = new AnalyticalStorageSchemaType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AnalyticalStorageConfiguration(Optional.ToNullable(schemaType), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AnalyticalStorageConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyticalStorageConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AnalyticalStorageConfiguration)} does not support '{options.Format}' format.");
            }
        }

        AnalyticalStorageConfiguration IPersistableModel<AnalyticalStorageConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyticalStorageConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAnalyticalStorageConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AnalyticalStorageConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AnalyticalStorageConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
