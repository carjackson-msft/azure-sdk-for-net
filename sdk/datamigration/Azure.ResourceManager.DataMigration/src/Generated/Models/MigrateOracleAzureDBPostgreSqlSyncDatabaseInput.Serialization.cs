// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateOracleAzureDBPostgreSqlSyncDatabaseInput : IUtf8JsonSerializable, IJsonModel<MigrateOracleAzureDBPostgreSqlSyncDatabaseInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateOracleAzureDBPostgreSqlSyncDatabaseInput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateOracleAzureDBPostgreSqlSyncDatabaseInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncDatabaseInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateOracleAzureDBPostgreSqlSyncDatabaseInput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (CaseManipulation != null)
            {
                writer.WritePropertyName("caseManipulation"u8);
                writer.WriteStringValue(CaseManipulation);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (SchemaName != null)
            {
                writer.WritePropertyName("schemaName"u8);
                writer.WriteStringValue(SchemaName);
            }
            if (!(TableMap is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tableMap"u8);
                writer.WriteStartObject();
                foreach (var item in TableMap)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (TargetDatabaseName != null)
            {
                writer.WritePropertyName("targetDatabaseName"u8);
                writer.WriteStringValue(TargetDatabaseName);
            }
            if (!(MigrationSetting is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("migrationSetting"u8);
                writer.WriteStartObject();
                foreach (var item in MigrationSetting)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(SourceSetting is ChangeTrackingDictionary<string, string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("sourceSetting"u8);
                writer.WriteStartObject();
                foreach (var item in SourceSetting)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(TargetSetting is ChangeTrackingDictionary<string, string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("targetSetting"u8);
                writer.WriteStartObject();
                foreach (var item in TargetSetting)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        MigrateOracleAzureDBPostgreSqlSyncDatabaseInput IJsonModel<MigrateOracleAzureDBPostgreSqlSyncDatabaseInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncDatabaseInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateOracleAzureDBPostgreSqlSyncDatabaseInput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateOracleAzureDBPostgreSqlSyncDatabaseInput(document.RootElement, options);
        }

        internal static MigrateOracleAzureDBPostgreSqlSyncDatabaseInput DeserializeMigrateOracleAzureDBPostgreSqlSyncDatabaseInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> caseManipulation = default;
            Optional<string> name = default;
            Optional<string> schemaName = default;
            IDictionary<string, string> tableMap = default;
            Optional<string> targetDatabaseName = default;
            IDictionary<string, string> migrationSetting = default;
            IDictionary<string, string> sourceSetting = default;
            IDictionary<string, string> targetSetting = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("caseManipulation"u8))
                {
                    caseManipulation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaName"u8))
                {
                    schemaName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tableMap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tableMap = dictionary;
                    continue;
                }
                if (property.NameEquals("targetDatabaseName"u8))
                {
                    targetDatabaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    migrationSetting = dictionary;
                    continue;
                }
                if (property.NameEquals("sourceSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    sourceSetting = dictionary;
                    continue;
                }
                if (property.NameEquals("targetSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    targetSetting = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MigrateOracleAzureDBPostgreSqlSyncDatabaseInput(
                caseManipulation.Value,
                name.Value,
                schemaName.Value,
                tableMap ?? new ChangeTrackingDictionary<string, string>(),
                targetDatabaseName.Value,
                migrationSetting ?? new ChangeTrackingDictionary<string, string>(),
                sourceSetting ?? new ChangeTrackingDictionary<string, string>(),
                targetSetting ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncDatabaseInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncDatabaseInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateOracleAzureDBPostgreSqlSyncDatabaseInput)} does not support '{options.Format}' format.");
            }
        }

        MigrateOracleAzureDBPostgreSqlSyncDatabaseInput IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncDatabaseInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncDatabaseInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateOracleAzureDBPostgreSqlSyncDatabaseInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateOracleAzureDBPostgreSqlSyncDatabaseInput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncDatabaseInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
