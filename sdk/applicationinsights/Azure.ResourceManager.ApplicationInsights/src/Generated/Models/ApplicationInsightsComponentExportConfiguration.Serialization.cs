// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class ApplicationInsightsComponentExportConfiguration : IUtf8JsonSerializable, IJsonModel<ApplicationInsightsComponentExportConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationInsightsComponentExportConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationInsightsComponentExportConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentExportConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentExportConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ExportId != null)
            {
                writer.WritePropertyName("ExportId"u8);
                writer.WriteStringValue(ExportId);
            }
            if (options.Format != "W" && InstrumentationKey != null)
            {
                writer.WritePropertyName("InstrumentationKey"u8);
                writer.WriteStringValue(InstrumentationKey);
            }
            if (RecordTypes != null)
            {
                writer.WritePropertyName("RecordTypes"u8);
                writer.WriteStringValue(RecordTypes);
            }
            if (options.Format != "W" && ApplicationName != null)
            {
                writer.WritePropertyName("ApplicationName"u8);
                writer.WriteStringValue(ApplicationName);
            }
            if (options.Format != "W" && SubscriptionId != null)
            {
                writer.WritePropertyName("SubscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (options.Format != "W" && ResourceGroup != null)
            {
                writer.WritePropertyName("ResourceGroup"u8);
                writer.WriteStringValue(ResourceGroup);
            }
            if (options.Format != "W" && DestinationStorageSubscriptionId != null)
            {
                writer.WritePropertyName("DestinationStorageSubscriptionId"u8);
                writer.WriteStringValue(DestinationStorageSubscriptionId);
            }
            if (options.Format != "W" && DestinationStorageLocationId != null)
            {
                writer.WritePropertyName("DestinationStorageLocationId"u8);
                writer.WriteStringValue(DestinationStorageLocationId);
            }
            if (options.Format != "W" && DestinationAccountId != null)
            {
                writer.WritePropertyName("DestinationAccountId"u8);
                writer.WriteStringValue(DestinationAccountId);
            }
            if (options.Format != "W" && DestinationType != null)
            {
                writer.WritePropertyName("DestinationType"u8);
                writer.WriteStringValue(DestinationType);
            }
            if (options.Format != "W" && IsUserEnabled != null)
            {
                writer.WritePropertyName("IsUserEnabled"u8);
                writer.WriteStringValue(IsUserEnabled);
            }
            if (options.Format != "W" && LastUserUpdate != null)
            {
                writer.WritePropertyName("LastUserUpdate"u8);
                writer.WriteStringValue(LastUserUpdate);
            }
            if (NotificationQueueEnabled != null)
            {
                writer.WritePropertyName("NotificationQueueEnabled"u8);
                writer.WriteStringValue(NotificationQueueEnabled);
            }
            if (options.Format != "W" && ExportStatus != null)
            {
                writer.WritePropertyName("ExportStatus"u8);
                writer.WriteStringValue(ExportStatus);
            }
            if (options.Format != "W" && LastSuccessTime != null)
            {
                writer.WritePropertyName("LastSuccessTime"u8);
                writer.WriteStringValue(LastSuccessTime);
            }
            if (options.Format != "W" && LastGapTime != null)
            {
                writer.WritePropertyName("LastGapTime"u8);
                writer.WriteStringValue(LastGapTime);
            }
            if (options.Format != "W" && PermanentErrorReason != null)
            {
                writer.WritePropertyName("PermanentErrorReason"u8);
                writer.WriteStringValue(PermanentErrorReason);
            }
            if (options.Format != "W" && StorageName != null)
            {
                writer.WritePropertyName("StorageName"u8);
                writer.WriteStringValue(StorageName);
            }
            if (options.Format != "W" && ContainerName != null)
            {
                writer.WritePropertyName("ContainerName"u8);
                writer.WriteStringValue(ContainerName);
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

        ApplicationInsightsComponentExportConfiguration IJsonModel<ApplicationInsightsComponentExportConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentExportConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentExportConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationInsightsComponentExportConfiguration(document.RootElement, options);
        }

        internal static ApplicationInsightsComponentExportConfiguration DeserializeApplicationInsightsComponentExportConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> exportId = default;
            Optional<string> instrumentationKey = default;
            Optional<string> recordTypes = default;
            Optional<string> applicationName = default;
            Optional<string> subscriptionId = default;
            Optional<string> resourceGroup = default;
            Optional<string> destinationStorageSubscriptionId = default;
            Optional<string> destinationStorageLocationId = default;
            Optional<string> destinationAccountId = default;
            Optional<string> destinationType = default;
            Optional<string> isUserEnabled = default;
            Optional<string> lastUserUpdate = default;
            Optional<string> notificationQueueEnabled = default;
            Optional<string> exportStatus = default;
            Optional<string> lastSuccessTime = default;
            Optional<string> lastGapTime = default;
            Optional<string> permanentErrorReason = default;
            Optional<string> storageName = default;
            Optional<string> containerName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ExportId"u8))
                {
                    exportId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("InstrumentationKey"u8))
                {
                    instrumentationKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("RecordTypes"u8))
                {
                    recordTypes = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ApplicationName"u8))
                {
                    applicationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("SubscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ResourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("DestinationStorageSubscriptionId"u8))
                {
                    destinationStorageSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("DestinationStorageLocationId"u8))
                {
                    destinationStorageLocationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("DestinationAccountId"u8))
                {
                    destinationAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("DestinationType"u8))
                {
                    destinationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("IsUserEnabled"u8))
                {
                    isUserEnabled = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("LastUserUpdate"u8))
                {
                    lastUserUpdate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("NotificationQueueEnabled"u8))
                {
                    notificationQueueEnabled = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ExportStatus"u8))
                {
                    exportStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("LastSuccessTime"u8))
                {
                    lastSuccessTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("LastGapTime"u8))
                {
                    lastGapTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("PermanentErrorReason"u8))
                {
                    permanentErrorReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("StorageName"u8))
                {
                    storageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ContainerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationInsightsComponentExportConfiguration(
                exportId.Value,
                instrumentationKey.Value,
                recordTypes.Value,
                applicationName.Value,
                subscriptionId.Value,
                resourceGroup.Value,
                destinationStorageSubscriptionId.Value,
                destinationStorageLocationId.Value,
                destinationAccountId.Value,
                destinationType.Value,
                isUserEnabled.Value,
                lastUserUpdate.Value,
                notificationQueueEnabled.Value,
                exportStatus.Value,
                lastSuccessTime.Value,
                lastGapTime.Value,
                permanentErrorReason.Value,
                storageName.Value,
                containerName.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationInsightsComponentExportConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentExportConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationInsightsComponentExportConfiguration)} does not support '{options.Format}' format.");
            }
        }

        ApplicationInsightsComponentExportConfiguration IPersistableModel<ApplicationInsightsComponentExportConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentExportConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationInsightsComponentExportConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationInsightsComponentExportConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationInsightsComponentExportConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
