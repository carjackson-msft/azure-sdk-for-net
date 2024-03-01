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
    public partial class ExtendedRestorableSqlDatabaseResourceInfo : IUtf8JsonSerializable, IJsonModel<ExtendedRestorableSqlDatabaseResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExtendedRestorableSqlDatabaseResourceInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExtendedRestorableSqlDatabaseResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedRestorableSqlDatabaseResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedRestorableSqlDatabaseResourceInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Rid != null)
            {
                writer.WritePropertyName("_rid"u8);
                writer.WriteStringValue(Rid);
            }
            if (options.Format != "W" && OperationType.HasValue)
            {
                writer.WritePropertyName("operationType"u8);
                writer.WriteStringValue(OperationType.Value.ToString());
            }
            if (options.Format != "W" && CanUndelete != null)
            {
                writer.WritePropertyName("canUndelete"u8);
                writer.WriteStringValue(CanUndelete);
            }
            if (options.Format != "W" && CanUndeleteReason != null)
            {
                writer.WritePropertyName("canUndeleteReason"u8);
                writer.WriteStringValue(CanUndeleteReason);
            }
            if (options.Format != "W" && EventTimestamp != null)
            {
                writer.WritePropertyName("eventTimestamp"u8);
                writer.WriteStringValue(EventTimestamp);
            }
            if (options.Format != "W" && DatabaseName != null)
            {
                writer.WritePropertyName("ownerId"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (options.Format != "W" && DatabaseId != null)
            {
                writer.WritePropertyName("ownerResourceId"u8);
                writer.WriteStringValue(DatabaseId);
            }
            if (Database != null)
            {
                writer.WritePropertyName("database"u8);
                writer.WriteObjectValue(Database);
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

        ExtendedRestorableSqlDatabaseResourceInfo IJsonModel<ExtendedRestorableSqlDatabaseResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedRestorableSqlDatabaseResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedRestorableSqlDatabaseResourceInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExtendedRestorableSqlDatabaseResourceInfo(document.RootElement, options);
        }

        internal static ExtendedRestorableSqlDatabaseResourceInfo DeserializeExtendedRestorableSqlDatabaseResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> rid = default;
            Optional<CosmosDBOperationType> operationType = default;
            Optional<string> canUndelete = default;
            Optional<string> canUndeleteReason = default;
            Optional<string> eventTimestamp = default;
            Optional<string> ownerId = default;
            Optional<string> ownerResourceId = default;
            Optional<RestorableSqlDatabasePropertiesResourceDatabase> database = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"u8))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationType = new CosmosDBOperationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("canUndelete"u8))
                {
                    canUndelete = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("canUndeleteReason"u8))
                {
                    canUndeleteReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventTimestamp"u8))
                {
                    eventTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ownerId"u8))
                {
                    ownerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ownerResourceId"u8))
                {
                    ownerResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("database"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    database = RestorableSqlDatabasePropertiesResourceDatabase.DeserializeRestorableSqlDatabasePropertiesResourceDatabase(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExtendedRestorableSqlDatabaseResourceInfo(
                rid.Value,
                Optional.ToNullable(operationType),
                canUndelete.Value,
                canUndeleteReason.Value,
                eventTimestamp.Value,
                ownerId.Value,
                ownerResourceId.Value,
                database.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExtendedRestorableSqlDatabaseResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedRestorableSqlDatabaseResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExtendedRestorableSqlDatabaseResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        ExtendedRestorableSqlDatabaseResourceInfo IPersistableModel<ExtendedRestorableSqlDatabaseResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedRestorableSqlDatabaseResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExtendedRestorableSqlDatabaseResourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExtendedRestorableSqlDatabaseResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExtendedRestorableSqlDatabaseResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
