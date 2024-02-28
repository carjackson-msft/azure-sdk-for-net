// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class ServiceAlertEssentials : IUtf8JsonSerializable, IJsonModel<ServiceAlertEssentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceAlertEssentials>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceAlertEssentials>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertEssentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceAlertEssentials)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Severity.HasValue)
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (options.Format != "W" && SignalType.HasValue)
            {
                writer.WritePropertyName("signalType"u8);
                writer.WriteStringValue(SignalType.Value.ToString());
            }
            if (options.Format != "W" && AlertState.HasValue)
            {
                writer.WritePropertyName("alertState"u8);
                writer.WriteStringValue(AlertState.Value.ToString());
            }
            if (options.Format != "W" && MonitorCondition.HasValue)
            {
                writer.WritePropertyName("monitorCondition"u8);
                writer.WriteStringValue(MonitorCondition.Value.ToString());
            }
            if (TargetResource != null)
            {
                writer.WritePropertyName("targetResource"u8);
                writer.WriteStringValue(TargetResource);
            }
            if (TargetResourceName != null)
            {
                writer.WritePropertyName("targetResourceName"u8);
                writer.WriteStringValue(TargetResourceName);
            }
            if (TargetResourceGroup != null)
            {
                writer.WritePropertyName("targetResourceGroup"u8);
                writer.WriteStringValue(TargetResourceGroup);
            }
            if (TargetResourceType != null)
            {
                writer.WritePropertyName("targetResourceType"u8);
                writer.WriteStringValue(TargetResourceType);
            }
            if (options.Format != "W" && MonitorService.HasValue)
            {
                writer.WritePropertyName("monitorService"u8);
                writer.WriteStringValue(MonitorService.Value.ToString());
            }
            if (options.Format != "W" && AlertRule != null)
            {
                writer.WritePropertyName("alertRule"u8);
                writer.WriteStringValue(AlertRule);
            }
            if (options.Format != "W" && SourceCreatedId != null)
            {
                writer.WritePropertyName("sourceCreatedId"u8);
                writer.WriteStringValue(SourceCreatedId);
            }
            if (options.Format != "W" && SmartGroupId.HasValue)
            {
                writer.WritePropertyName("smartGroupId"u8);
                writer.WriteStringValue(SmartGroupId.Value);
            }
            if (options.Format != "W" && SmartGroupingReason != null)
            {
                writer.WritePropertyName("smartGroupingReason"u8);
                writer.WriteStringValue(SmartGroupingReason);
            }
            if (options.Format != "W" && StartOn.HasValue)
            {
                writer.WritePropertyName("startDateTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && LastModifiedOn.HasValue)
            {
                writer.WritePropertyName("lastModifiedDateTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (options.Format != "W" && MonitorConditionResolvedOn.HasValue)
            {
                writer.WritePropertyName("monitorConditionResolvedDateTime"u8);
                writer.WriteStringValue(MonitorConditionResolvedOn.Value, "O");
            }
            if (options.Format != "W" && LastModifiedBy != null)
            {
                writer.WritePropertyName("lastModifiedUserName"u8);
                writer.WriteStringValue(LastModifiedBy);
            }
            if (ActionStatus != null)
            {
                writer.WritePropertyName("actionStatus"u8);
                writer.WriteObjectValue(ActionStatus);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        ServiceAlertEssentials IJsonModel<ServiceAlertEssentials>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertEssentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceAlertEssentials)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceAlertEssentials(document.RootElement, options);
        }

        internal static ServiceAlertEssentials DeserializeServiceAlertEssentials(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ServiceAlertSeverity> severity = default;
            Optional<ServiceAlertSignalType> signalType = default;
            Optional<ServiceAlertState> alertState = default;
            Optional<MonitorCondition> monitorCondition = default;
            Optional<string> targetResource = default;
            Optional<string> targetResourceName = default;
            Optional<string> targetResourceGroup = default;
            Optional<string> targetResourceType = default;
            Optional<MonitorServiceSourceForAlert> monitorService = default;
            Optional<string> alertRule = default;
            Optional<string> sourceCreatedId = default;
            Optional<Guid> smartGroupId = default;
            Optional<string> smartGroupingReason = default;
            Optional<DateTimeOffset> startDateTime = default;
            Optional<DateTimeOffset> lastModifiedDateTime = default;
            Optional<DateTimeOffset> monitorConditionResolvedDateTime = default;
            Optional<string> lastModifiedUserName = default;
            Optional<ServiceAlertActionStatus> actionStatus = default;
            Optional<string> description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    severity = new ServiceAlertSeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("signalType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    signalType = new ServiceAlertSignalType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("alertState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    alertState = new ServiceAlertState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("monitorCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitorCondition = new MonitorCondition(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetResource"u8))
                {
                    targetResource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceName"u8))
                {
                    targetResourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceGroup"u8))
                {
                    targetResourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceType"u8))
                {
                    targetResourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("monitorService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitorService = new MonitorServiceSourceForAlert(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("alertRule"u8))
                {
                    alertRule = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceCreatedId"u8))
                {
                    sourceCreatedId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("smartGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    smartGroupId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("smartGroupingReason"u8))
                {
                    smartGroupingReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("monitorConditionResolvedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitorConditionResolvedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedUserName"u8))
                {
                    lastModifiedUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionStatus = ServiceAlertActionStatus.DeserializeServiceAlertActionStatus(property.Value, options);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceAlertEssentials(
                Optional.ToNullable(severity),
                Optional.ToNullable(signalType),
                Optional.ToNullable(alertState),
                Optional.ToNullable(monitorCondition),
                targetResource.Value,
                targetResourceName.Value,
                targetResourceGroup.Value,
                targetResourceType.Value,
                Optional.ToNullable(monitorService),
                alertRule.Value,
                sourceCreatedId.Value,
                Optional.ToNullable(smartGroupId),
                smartGroupingReason.Value,
                Optional.ToNullable(startDateTime),
                Optional.ToNullable(lastModifiedDateTime),
                Optional.ToNullable(monitorConditionResolvedDateTime),
                lastModifiedUserName.Value,
                actionStatus.Value,
                description.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceAlertEssentials>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertEssentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceAlertEssentials)} does not support '{options.Format}' format.");
            }
        }

        ServiceAlertEssentials IPersistableModel<ServiceAlertEssentials>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertEssentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceAlertEssentials(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceAlertEssentials)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceAlertEssentials>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
