// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class HiveCatalogOption : IUtf8JsonSerializable, IJsonModel<HiveCatalogOption>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HiveCatalogOption>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HiveCatalogOption>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HiveCatalogOption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HiveCatalogOption)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("catalogName"u8);
            writer.WriteStringValue(CatalogName);
            writer.WritePropertyName("metastoreDbConnectionPasswordSecret"u8);
            writer.WriteStringValue(MetastoreDBConnectionPasswordSecret);
            writer.WritePropertyName("metastoreDbConnectionURL"u8);
            writer.WriteStringValue(MetastoreDBConnectionUriString);
            writer.WritePropertyName("metastoreDbConnectionUserName"u8);
            writer.WriteStringValue(MetastoreDBConnectionUserName);
            writer.WritePropertyName("metastoreWarehouseDir"u8);
            writer.WriteStringValue(MetastoreWarehouseDir);
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

        HiveCatalogOption IJsonModel<HiveCatalogOption>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HiveCatalogOption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HiveCatalogOption)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHiveCatalogOption(document.RootElement, options);
        }

        internal static HiveCatalogOption DeserializeHiveCatalogOption(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string catalogName = default;
            string metastoreDBConnectionPasswordSecret = default;
            string metastoreDBConnectionURL = default;
            string metastoreDBConnectionUserName = default;
            string metastoreWarehouseDir = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("catalogName"u8))
                {
                    catalogName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metastoreDbConnectionPasswordSecret"u8))
                {
                    metastoreDBConnectionPasswordSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metastoreDbConnectionURL"u8))
                {
                    metastoreDBConnectionURL = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metastoreDbConnectionUserName"u8))
                {
                    metastoreDBConnectionUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metastoreWarehouseDir"u8))
                {
                    metastoreWarehouseDir = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HiveCatalogOption(
                catalogName,
                metastoreDBConnectionPasswordSecret,
                metastoreDBConnectionURL,
                metastoreDBConnectionUserName,
                metastoreWarehouseDir,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HiveCatalogOption>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HiveCatalogOption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HiveCatalogOption)} does not support '{options.Format}' format.");
            }
        }

        HiveCatalogOption IPersistableModel<HiveCatalogOption>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HiveCatalogOption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHiveCatalogOption(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HiveCatalogOption)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HiveCatalogOption>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
