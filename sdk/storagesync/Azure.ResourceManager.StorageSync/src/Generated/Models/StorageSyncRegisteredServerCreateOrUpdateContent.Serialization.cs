// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class StorageSyncRegisteredServerCreateOrUpdateContent : IUtf8JsonSerializable, IJsonModel<StorageSyncRegisteredServerCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageSyncRegisteredServerCreateOrUpdateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageSyncRegisteredServerCreateOrUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncRegisteredServerCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageSyncRegisteredServerCreateOrUpdateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (ServerCertificate != null)
            {
                writer.WritePropertyName("serverCertificate"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ServerCertificate);
#else
                using (JsonDocument document = JsonDocument.Parse(ServerCertificate))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (AgentVersion != null)
            {
                writer.WritePropertyName("agentVersion"u8);
                writer.WriteStringValue(AgentVersion);
            }
            if (ServerOSVersion != null)
            {
                writer.WritePropertyName("serverOSVersion"u8);
                writer.WriteStringValue(ServerOSVersion);
            }
            if (LastHeartbeat != null)
            {
                writer.WritePropertyName("lastHeartBeat"u8);
                writer.WriteStringValue(LastHeartbeat);
            }
            if (ServerRole != null)
            {
                writer.WritePropertyName("serverRole"u8);
                writer.WriteStringValue(ServerRole);
            }
            if (ClusterId.HasValue)
            {
                writer.WritePropertyName("clusterId"u8);
                writer.WriteStringValue(ClusterId.Value);
            }
            if (ClusterName != null)
            {
                writer.WritePropertyName("clusterName"u8);
                writer.WriteStringValue(ClusterName);
            }
            if (ServerId.HasValue)
            {
                writer.WritePropertyName("serverId"u8);
                writer.WriteStringValue(ServerId.Value);
            }
            if (FriendlyName != null)
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
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

        StorageSyncRegisteredServerCreateOrUpdateContent IJsonModel<StorageSyncRegisteredServerCreateOrUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncRegisteredServerCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageSyncRegisteredServerCreateOrUpdateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageSyncRegisteredServerCreateOrUpdateContent(document.RootElement, options);
        }

        internal static StorageSyncRegisteredServerCreateOrUpdateContent DeserializeStorageSyncRegisteredServerCreateOrUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<BinaryData> serverCertificate = default;
            Optional<string> agentVersion = default;
            Optional<string> serverOSVersion = default;
            Optional<string> lastHeartbeat = default;
            Optional<string> serverRole = default;
            Optional<Guid> clusterId = default;
            Optional<string> clusterName = default;
            Optional<Guid> serverId = default;
            Optional<string> friendlyName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("serverCertificate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serverCertificate = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("agentVersion"u8))
                        {
                            agentVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverOSVersion"u8))
                        {
                            serverOSVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastHeartBeat"u8))
                        {
                            lastHeartbeat = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverRole"u8))
                        {
                            serverRole = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("clusterName"u8))
                        {
                            clusterName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serverId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
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
            return new StorageSyncRegisteredServerCreateOrUpdateContent(
                id,
                name,
                type,
                systemData.Value,
                serverCertificate.Value,
                agentVersion.Value,
                serverOSVersion.Value,
                lastHeartbeat.Value,
                serverRole.Value,
                Optional.ToNullable(clusterId),
                clusterName.Value,
                Optional.ToNullable(serverId),
                friendlyName.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageSyncRegisteredServerCreateOrUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncRegisteredServerCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageSyncRegisteredServerCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        StorageSyncRegisteredServerCreateOrUpdateContent IPersistableModel<StorageSyncRegisteredServerCreateOrUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncRegisteredServerCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageSyncRegisteredServerCreateOrUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageSyncRegisteredServerCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageSyncRegisteredServerCreateOrUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
