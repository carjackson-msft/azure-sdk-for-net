// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlServerMetadata : IUtf8JsonSerializable, IJsonModel<PostgreSqlServerMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlServerMetadata>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PostgreSqlServerMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlServerMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlServerMetadata)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Location.HasValue)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Version != null)
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (StorageMb.HasValue)
            {
                writer.WritePropertyName("storageMb"u8);
                writer.WriteNumberValue(StorageMb.Value);
            }
            if (Sku != null)
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
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

        PostgreSqlServerMetadata IJsonModel<PostgreSqlServerMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlServerMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlServerMetadata)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlServerMetadata(document.RootElement, options);
        }

        internal static PostgreSqlServerMetadata DeserializePostgreSqlServerMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            Optional<string> version = default;
            Optional<int> storageMb = default;
            Optional<ServerSku> sku = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageMb = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = ServerSku.DeserializeServerSku(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PostgreSqlServerMetadata(Optional.ToNullable(location), version.Value, Optional.ToNullable(storageMb), sku.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PostgreSqlServerMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlServerMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlServerMetadata)} does not support '{options.Format}' format.");
            }
        }

        PostgreSqlServerMetadata IPersistableModel<PostgreSqlServerMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlServerMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePostgreSqlServerMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlServerMetadata)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlServerMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
