// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.BotService;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class BotProperties : IUtf8JsonSerializable, IJsonModel<BotProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BotProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BotProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BotProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("displayName"u8);
            writer.WriteStringValue(DisplayName);
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (IconUri != null)
            {
                writer.WritePropertyName("iconUrl"u8);
                writer.WriteStringValue(IconUri.AbsoluteUri);
            }
            if (Endpoint != null)
            {
                writer.WritePropertyName("endpoint"u8);
                writer.WriteStringValue(Endpoint.AbsoluteUri);
            }
            else
            {
                writer.WriteNull("endpoint");
            }
            if (options.Format != "W" && EndpointVersion != null)
            {
                writer.WritePropertyName("endpointVersion"u8);
                writer.WriteStringValue(EndpointVersion);
            }
            if (!(AllSettings is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("allSettings"u8);
                writer.WriteStartObject();
                foreach (var item in AllSettings)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(Parameters is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (ManifestUri != null)
            {
                writer.WritePropertyName("manifestUrl"u8);
                writer.WriteStringValue(ManifestUri.AbsoluteUri);
            }
            if (MsaAppType.HasValue)
            {
                writer.WritePropertyName("msaAppType"u8);
                writer.WriteStringValue(MsaAppType.Value.ToString());
            }
            writer.WritePropertyName("msaAppId"u8);
            writer.WriteStringValue(MsaAppId);
            if (MsaAppTenantId != null)
            {
                writer.WritePropertyName("msaAppTenantId"u8);
                writer.WriteStringValue(MsaAppTenantId);
            }
            if (MsaAppMSIResourceId != null)
            {
                writer.WritePropertyName("msaAppMSIResourceId"u8);
                writer.WriteStringValue(MsaAppMSIResourceId);
            }
            if (options.Format != "W" && !(ConfiguredChannels is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("configuredChannels"u8);
                writer.WriteStartArray();
                foreach (var item in ConfiguredChannels)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(EnabledChannels is ChangeTrackingList<string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("enabledChannels"u8);
                writer.WriteStartArray();
                foreach (var item in EnabledChannels)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (DeveloperAppInsightKey != null)
            {
                writer.WritePropertyName("developerAppInsightKey"u8);
                writer.WriteStringValue(DeveloperAppInsightKey);
            }
            if (DeveloperAppInsightsApiKey != null)
            {
                writer.WritePropertyName("developerAppInsightsApiKey"u8);
                writer.WriteStringValue(DeveloperAppInsightsApiKey);
            }
            if (DeveloperAppInsightsApplicationId != null)
            {
                writer.WritePropertyName("developerAppInsightsApplicationId"u8);
                writer.WriteStringValue(DeveloperAppInsightsApplicationId);
            }
            if (!(LuisAppIds is ChangeTrackingList<string> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("luisAppIds"u8);
                writer.WriteStartArray();
                foreach (var item in LuisAppIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (LuisKey != null)
            {
                writer.WritePropertyName("luisKey"u8);
                writer.WriteStringValue(LuisKey);
            }
            if (IsCmekEnabled.HasValue)
            {
                writer.WritePropertyName("isCmekEnabled"u8);
                writer.WriteBooleanValue(IsCmekEnabled.Value);
            }
            if (CmekKeyVaultUri != null)
            {
                writer.WritePropertyName("cmekKeyVaultUrl"u8);
                writer.WriteStringValue(CmekKeyVaultUri.AbsoluteUri);
            }
            if (options.Format != "W" && CmekEncryptionStatus != null)
            {
                writer.WritePropertyName("cmekEncryptionStatus"u8);
                writer.WriteStringValue(CmekEncryptionStatus);
            }
            if (TenantId.HasValue)
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (PublicNetworkAccess.HasValue)
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (IsStreamingSupported.HasValue)
            {
                writer.WritePropertyName("isStreamingSupported"u8);
                writer.WriteBooleanValue(IsStreamingSupported.Value);
            }
            if (options.Format != "W" && IsDeveloperAppInsightsApiKeySet.HasValue)
            {
                writer.WritePropertyName("isDeveloperAppInsightsApiKeySet"u8);
                writer.WriteBooleanValue(IsDeveloperAppInsightsApiKeySet.Value);
            }
            if (options.Format != "W" && MigrationToken != null)
            {
                writer.WritePropertyName("migrationToken"u8);
                writer.WriteStringValue(MigrationToken);
            }
            if (IsLocalAuthDisabled.HasValue)
            {
                writer.WritePropertyName("disableLocalAuth"u8);
                writer.WriteBooleanValue(IsLocalAuthDisabled.Value);
            }
            if (SchemaTransformationVersion != null)
            {
                if (SchemaTransformationVersion != null)
                {
                    writer.WritePropertyName("schemaTransformationVersion"u8);
                    writer.WriteStringValue(SchemaTransformationVersion);
                }
                else
                {
                    writer.WriteNull("schemaTransformationVersion");
                }
            }
            if (StorageResourceId != null)
            {
                writer.WritePropertyName("storageResourceId"u8);
                writer.WriteStringValue(StorageResourceId);
            }
            if (options.Format != "W" && !(PrivateEndpointConnections is ChangeTrackingList<BotServicePrivateEndpointConnectionData> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (OpenWithHint != null)
            {
                writer.WritePropertyName("openWithHint"u8);
                writer.WriteStringValue(OpenWithHint);
            }
            if (AppPasswordHint != null)
            {
                writer.WritePropertyName("appPasswordHint"u8);
                writer.WriteStringValue(AppPasswordHint);
            }
            if (options.Format != "W" && ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (PublishingCredentials != null)
            {
                writer.WritePropertyName("publishingCredentials"u8);
                writer.WriteStringValue(PublishingCredentials);
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

        BotProperties IJsonModel<BotProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BotProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBotProperties(document.RootElement, options);
        }

        internal static BotProperties DeserializeBotProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string displayName = default;
            Optional<string> description = default;
            Optional<Uri> iconUrl = default;
            Uri endpoint = default;
            Optional<string> endpointVersion = default;
            IDictionary<string, string> allSettings = default;
            IDictionary<string, string> parameters = default;
            Optional<Uri> manifestUrl = default;
            Optional<BotMsaAppType> msaAppType = default;
            string msaAppId = default;
            Optional<string> msaAppTenantId = default;
            Optional<ResourceIdentifier> msaAppMSIResourceId = default;
            IReadOnlyList<string> configuredChannels = default;
            IReadOnlyList<string> enabledChannels = default;
            Optional<string> developerAppInsightKey = default;
            Optional<string> developerAppInsightsApiKey = default;
            Optional<string> developerAppInsightsApplicationId = default;
            IList<string> luisAppIds = default;
            Optional<string> luisKey = default;
            Optional<bool> isCmekEnabled = default;
            Optional<Uri> cmekKeyVaultUrl = default;
            Optional<string> cmekEncryptionStatus = default;
            Optional<Guid> tenantId = default;
            Optional<BotServicePublicNetworkAccess> publicNetworkAccess = default;
            Optional<bool> isStreamingSupported = default;
            Optional<bool> isDeveloperAppInsightsApiKeySet = default;
            Optional<string> migrationToken = default;
            Optional<bool> disableLocalAuth = default;
            Optional<string> schemaTransformationVersion = default;
            Optional<ResourceIdentifier> storageResourceId = default;
            IReadOnlyList<BotServicePrivateEndpointConnectionData> privateEndpointConnections = default;
            Optional<string> openWithHint = default;
            Optional<string> appPasswordHint = default;
            Optional<string> provisioningState = default;
            Optional<string> publishingCredentials = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iconUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    iconUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("endpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endpoint = null;
                        continue;
                    }
                    endpoint = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("endpointVersion"u8))
                {
                    endpointVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allSettings"u8))
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
                    allSettings = dictionary;
                    continue;
                }
                if (property.NameEquals("parameters"u8))
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
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("manifestUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    manifestUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("msaAppType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    msaAppType = new BotMsaAppType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("msaAppId"u8))
                {
                    msaAppId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("msaAppTenantId"u8))
                {
                    msaAppTenantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("msaAppMSIResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    msaAppMSIResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("configuredChannels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    configuredChannels = array;
                    continue;
                }
                if (property.NameEquals("enabledChannels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    enabledChannels = array;
                    continue;
                }
                if (property.NameEquals("developerAppInsightKey"u8))
                {
                    developerAppInsightKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("developerAppInsightsApiKey"u8))
                {
                    developerAppInsightsApiKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("developerAppInsightsApplicationId"u8))
                {
                    developerAppInsightsApplicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("luisAppIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    luisAppIds = array;
                    continue;
                }
                if (property.NameEquals("luisKey"u8))
                {
                    luisKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isCmekEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isCmekEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cmekKeyVaultUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cmekKeyVaultUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cmekEncryptionStatus"u8))
                {
                    cmekEncryptionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new BotServicePublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isStreamingSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isStreamingSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDeveloperAppInsightsApiKeySet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDeveloperAppInsightsApiKeySet = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("migrationToken"u8))
                {
                    migrationToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disableLocalAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableLocalAuth = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("schemaTransformationVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        schemaTransformationVersion = null;
                        continue;
                    }
                    schemaTransformationVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BotServicePrivateEndpointConnectionData> array = new List<BotServicePrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BotServicePrivateEndpointConnectionData.DeserializeBotServicePrivateEndpointConnectionData(item, options));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
                if (property.NameEquals("openWithHint"u8))
                {
                    openWithHint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appPasswordHint"u8))
                {
                    appPasswordHint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publishingCredentials"u8))
                {
                    publishingCredentials = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BotProperties(
                displayName,
                description.Value,
                iconUrl.Value,
                endpoint,
                endpointVersion.Value,
                allSettings ?? new ChangeTrackingDictionary<string, string>(),
                parameters ?? new ChangeTrackingDictionary<string, string>(),
                manifestUrl.Value,
                Optional.ToNullable(msaAppType),
                msaAppId,
                msaAppTenantId.Value,
                msaAppMSIResourceId.Value,
                configuredChannels ?? new ChangeTrackingList<string>(),
                enabledChannels ?? new ChangeTrackingList<string>(),
                developerAppInsightKey.Value,
                developerAppInsightsApiKey.Value,
                developerAppInsightsApplicationId.Value,
                luisAppIds ?? new ChangeTrackingList<string>(),
                luisKey.Value,
                Optional.ToNullable(isCmekEnabled),
                cmekKeyVaultUrl.Value,
                cmekEncryptionStatus.Value,
                Optional.ToNullable(tenantId),
                Optional.ToNullable(publicNetworkAccess),
                Optional.ToNullable(isStreamingSupported),
                Optional.ToNullable(isDeveloperAppInsightsApiKeySet),
                migrationToken.Value,
                Optional.ToNullable(disableLocalAuth),
                schemaTransformationVersion.Value,
                storageResourceId.Value,
                privateEndpointConnections ?? new ChangeTrackingList<BotServicePrivateEndpointConnectionData>(),
                openWithHint.Value,
                appPasswordHint.Value,
                provisioningState.Value,
                publishingCredentials.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BotProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BotProperties)} does not support '{options.Format}' format.");
            }
        }

        BotProperties IPersistableModel<BotProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBotProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BotProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BotProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
