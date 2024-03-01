// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Models
{
    public partial class CosmosDBForPostgreSqlClusterPatch : IUtf8JsonSerializable, IJsonModel<CosmosDBForPostgreSqlClusterPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBForPostgreSqlClusterPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CosmosDBForPostgreSqlClusterPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBForPostgreSqlClusterPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBForPostgreSqlClusterPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (AdministratorLoginPassword != null)
            {
                writer.WritePropertyName("administratorLoginPassword"u8);
                writer.WriteStringValue(AdministratorLoginPassword);
            }
            if (PostgresqlVersion != null)
            {
                writer.WritePropertyName("postgresqlVersion"u8);
                writer.WriteStringValue(PostgresqlVersion);
            }
            if (CitusVersion != null)
            {
                writer.WritePropertyName("citusVersion"u8);
                writer.WriteStringValue(CitusVersion);
            }
            if (IsShardsOnCoordinatorEnabled.HasValue)
            {
                writer.WritePropertyName("enableShardsOnCoordinator"u8);
                writer.WriteBooleanValue(IsShardsOnCoordinatorEnabled.Value);
            }
            if (IsHAEnabled.HasValue)
            {
                writer.WritePropertyName("enableHa"u8);
                writer.WriteBooleanValue(IsHAEnabled.Value);
            }
            if (PreferredPrimaryZone != null)
            {
                writer.WritePropertyName("preferredPrimaryZone"u8);
                writer.WriteStringValue(PreferredPrimaryZone);
            }
            if (CoordinatorServerEdition != null)
            {
                writer.WritePropertyName("coordinatorServerEdition"u8);
                writer.WriteStringValue(CoordinatorServerEdition);
            }
            if (CoordinatorStorageQuotaInMb.HasValue)
            {
                writer.WritePropertyName("coordinatorStorageQuotaInMb"u8);
                writer.WriteNumberValue(CoordinatorStorageQuotaInMb.Value);
            }
            if (CoordinatorVCores.HasValue)
            {
                writer.WritePropertyName("coordinatorVCores"u8);
                writer.WriteNumberValue(CoordinatorVCores.Value);
            }
            if (IsCoordinatorPublicIPAccessEnabled.HasValue)
            {
                writer.WritePropertyName("coordinatorEnablePublicIpAccess"u8);
                writer.WriteBooleanValue(IsCoordinatorPublicIPAccessEnabled.Value);
            }
            if (NodeServerEdition != null)
            {
                writer.WritePropertyName("nodeServerEdition"u8);
                writer.WriteStringValue(NodeServerEdition);
            }
            if (NodeCount.HasValue)
            {
                writer.WritePropertyName("nodeCount"u8);
                writer.WriteNumberValue(NodeCount.Value);
            }
            if (NodeStorageQuotaInMb.HasValue)
            {
                writer.WritePropertyName("nodeStorageQuotaInMb"u8);
                writer.WriteNumberValue(NodeStorageQuotaInMb.Value);
            }
            if (NodeVCores.HasValue)
            {
                writer.WritePropertyName("nodeVCores"u8);
                writer.WriteNumberValue(NodeVCores.Value);
            }
            if (options.Format != "W" && IsNodePublicIPAccessEnabled.HasValue)
            {
                writer.WritePropertyName("nodeEnablePublicIpAccess"u8);
                writer.WriteBooleanValue(IsNodePublicIPAccessEnabled.Value);
            }
            if (MaintenanceWindow != null)
            {
                writer.WritePropertyName("maintenanceWindow"u8);
                writer.WriteObjectValue(MaintenanceWindow);
            }
            writer.WriteEndObject();
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

        CosmosDBForPostgreSqlClusterPatch IJsonModel<CosmosDBForPostgreSqlClusterPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBForPostgreSqlClusterPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBForPostgreSqlClusterPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBForPostgreSqlClusterPatch(document.RootElement, options);
        }

        internal static CosmosDBForPostgreSqlClusterPatch DeserializeCosmosDBForPostgreSqlClusterPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            Optional<string> administratorLoginPassword = default;
            Optional<string> postgresqlVersion = default;
            Optional<string> citusVersion = default;
            Optional<bool> enableShardsOnCoordinator = default;
            Optional<bool> enableHa = default;
            Optional<string> preferredPrimaryZone = default;
            Optional<string> coordinatorServerEdition = default;
            Optional<int> coordinatorStorageQuotaInMb = default;
            Optional<int> coordinatorVCores = default;
            Optional<bool> coordinatorEnablePublicIPAccess = default;
            Optional<string> nodeServerEdition = default;
            Optional<int> nodeCount = default;
            Optional<int> nodeStorageQuotaInMb = default;
            Optional<int> nodeVCores = default;
            Optional<bool> nodeEnablePublicIPAccess = default;
            Optional<CosmosDBForPostgreSqlMaintenanceWindow> maintenanceWindow = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("administratorLoginPassword"u8))
                        {
                            administratorLoginPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("postgresqlVersion"u8))
                        {
                            postgresqlVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("citusVersion"u8))
                        {
                            citusVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enableShardsOnCoordinator"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableShardsOnCoordinator = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableHa"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableHa = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("preferredPrimaryZone"u8))
                        {
                            preferredPrimaryZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("coordinatorServerEdition"u8))
                        {
                            coordinatorServerEdition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("coordinatorStorageQuotaInMb"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coordinatorStorageQuotaInMb = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("coordinatorVCores"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coordinatorVCores = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("coordinatorEnablePublicIpAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coordinatorEnablePublicIPAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("nodeServerEdition"u8))
                        {
                            nodeServerEdition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("nodeStorageQuotaInMb"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeStorageQuotaInMb = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("nodeVCores"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeVCores = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("nodeEnablePublicIpAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeEnablePublicIPAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("maintenanceWindow"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maintenanceWindow = CosmosDBForPostgreSqlMaintenanceWindow.DeserializeCosmosDBForPostgreSqlMaintenanceWindow(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CosmosDBForPostgreSqlClusterPatch(
                tags ?? new ChangeTrackingDictionary<string, string>(),
                administratorLoginPassword.Value,
                postgresqlVersion.Value,
                citusVersion.Value,
                Optional.ToNullable(enableShardsOnCoordinator),
                Optional.ToNullable(enableHa),
                preferredPrimaryZone.Value,
                coordinatorServerEdition.Value,
                Optional.ToNullable(coordinatorStorageQuotaInMb),
                Optional.ToNullable(coordinatorVCores),
                Optional.ToNullable(coordinatorEnablePublicIPAccess),
                nodeServerEdition.Value,
                Optional.ToNullable(nodeCount),
                Optional.ToNullable(nodeStorageQuotaInMb),
                Optional.ToNullable(nodeVCores),
                Optional.ToNullable(nodeEnablePublicIPAccess),
                maintenanceWindow.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CosmosDBForPostgreSqlClusterPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBForPostgreSqlClusterPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBForPostgreSqlClusterPatch)} does not support '{options.Format}' format.");
            }
        }

        CosmosDBForPostgreSqlClusterPatch IPersistableModel<CosmosDBForPostgreSqlClusterPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBForPostgreSqlClusterPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBForPostgreSqlClusterPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBForPostgreSqlClusterPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBForPostgreSqlClusterPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
