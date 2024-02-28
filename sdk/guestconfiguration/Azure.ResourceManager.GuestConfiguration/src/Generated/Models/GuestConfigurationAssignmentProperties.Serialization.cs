// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    public partial class GuestConfigurationAssignmentProperties : IUtf8JsonSerializable, IJsonModel<GuestConfigurationAssignmentProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GuestConfigurationAssignmentProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GuestConfigurationAssignmentProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationAssignmentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GuestConfigurationAssignmentProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && TargetResourceId != null)
            {
                if (TargetResourceId != null)
                {
                    writer.WritePropertyName("targetResourceId"u8);
                    writer.WriteStringValue(TargetResourceId);
                }
                else
                {
                    writer.WriteNull("targetResourceId");
                }
            }
            if (GuestConfiguration != null)
            {
                writer.WritePropertyName("guestConfiguration"u8);
                writer.WriteObjectValue(GuestConfiguration);
            }
            if (options.Format != "W" && ComplianceStatus.HasValue)
            {
                writer.WritePropertyName("complianceStatus"u8);
                writer.WriteStringValue(ComplianceStatus.Value.ToString());
            }
            if (options.Format != "W" && LastComplianceStatusCheckedOn.HasValue)
            {
                if (LastComplianceStatusCheckedOn != null)
                {
                    writer.WritePropertyName("lastComplianceStatusChecked"u8);
                    writer.WriteStringValue(LastComplianceStatusCheckedOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("lastComplianceStatusChecked");
                }
            }
            if (options.Format != "W" && LatestReportId != null)
            {
                if (LatestReportId != null)
                {
                    writer.WritePropertyName("latestReportId"u8);
                    writer.WriteStringValue(LatestReportId);
                }
                else
                {
                    writer.WriteNull("latestReportId");
                }
            }
            if (options.Format != "W" && ParameterHash != null)
            {
                if (ParameterHash != null)
                {
                    writer.WritePropertyName("parameterHash"u8);
                    writer.WriteStringValue(ParameterHash);
                }
                else
                {
                    writer.WriteNull("parameterHash");
                }
            }
            if (LatestAssignmentReport != null)
            {
                writer.WritePropertyName("latestAssignmentReport"u8);
                writer.WriteObjectValue(LatestAssignmentReport);
            }
            if (Context != null)
            {
                writer.WritePropertyName("context"u8);
                writer.WriteStringValue(Context);
            }
            if (options.Format != "W" && AssignmentHash != null)
            {
                if (AssignmentHash != null)
                {
                    writer.WritePropertyName("assignmentHash"u8);
                    writer.WriteStringValue(AssignmentHash);
                }
                else
                {
                    writer.WriteNull("assignmentHash");
                }
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                if (ProvisioningState != null)
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
                else
                {
                    writer.WriteNull("provisioningState");
                }
            }
            if (options.Format != "W" && ResourceType != null)
            {
                if (ResourceType != null)
                {
                    writer.WritePropertyName("resourceType"u8);
                    writer.WriteStringValue(ResourceType);
                }
                else
                {
                    writer.WriteNull("resourceType");
                }
            }
            if (!(VmssVmList is ChangeTrackingList<GuestConfigurationVmssVmInfo> collection && collection.IsUndefined))
            {
                if (VmssVmList != null)
                {
                    writer.WritePropertyName("vmssVMList"u8);
                    writer.WriteStartArray();
                    foreach (var item in VmssVmList)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("vmssVMList");
                }
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

        GuestConfigurationAssignmentProperties IJsonModel<GuestConfigurationAssignmentProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationAssignmentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GuestConfigurationAssignmentProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGuestConfigurationAssignmentProperties(document.RootElement, options);
        }

        internal static GuestConfigurationAssignmentProperties DeserializeGuestConfigurationAssignmentProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> targetResourceId = default;
            Optional<GuestConfigurationNavigation> guestConfiguration = default;
            Optional<AssignedGuestConfigurationMachineComplianceStatus> complianceStatus = default;
            Optional<DateTimeOffset?> lastComplianceStatusChecked = default;
            Optional<ResourceIdentifier> latestReportId = default;
            Optional<string> parameterHash = default;
            Optional<GuestConfigurationAssignmentReportInfo> latestAssignmentReport = default;
            Optional<string> context = default;
            Optional<string> assignmentHash = default;
            Optional<GuestConfigurationProvisioningState?> provisioningState = default;
            Optional<string> resourceType = default;
            IList<GuestConfigurationVmssVmInfo> vmssVmList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetResourceId = null;
                        continue;
                    }
                    targetResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("guestConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    guestConfiguration = GuestConfigurationNavigation.DeserializeGuestConfigurationNavigation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("complianceStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    complianceStatus = new AssignedGuestConfigurationMachineComplianceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastComplianceStatusChecked"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        lastComplianceStatusChecked = null;
                        continue;
                    }
                    lastComplianceStatusChecked = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("latestReportId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        latestReportId = null;
                        continue;
                    }
                    latestReportId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("parameterHash"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        parameterHash = null;
                        continue;
                    }
                    parameterHash = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("latestAssignmentReport"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    latestAssignmentReport = GuestConfigurationAssignmentReportInfo.DeserializeGuestConfigurationAssignmentReportInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("context"u8))
                {
                    context = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assignmentHash"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        assignmentHash = null;
                        continue;
                    }
                    assignmentHash = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        provisioningState = null;
                        continue;
                    }
                    provisioningState = new GuestConfigurationProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceType = null;
                        continue;
                    }
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmssVMList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        vmssVmList = null;
                        continue;
                    }
                    List<GuestConfigurationVmssVmInfo> array = new List<GuestConfigurationVmssVmInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GuestConfigurationVmssVmInfo.DeserializeGuestConfigurationVmssVmInfo(item, options));
                    }
                    vmssVmList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GuestConfigurationAssignmentProperties(
                targetResourceId.Value,
                guestConfiguration.Value,
                Optional.ToNullable(complianceStatus),
                Optional.ToNullable(lastComplianceStatusChecked),
                latestReportId.Value,
                parameterHash.Value,
                latestAssignmentReport.Value,
                context.Value,
                assignmentHash.Value,
                Optional.ToNullable(provisioningState),
                resourceType.Value,
                vmssVmList ?? new ChangeTrackingList<GuestConfigurationVmssVmInfo>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GuestConfigurationAssignmentProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationAssignmentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GuestConfigurationAssignmentProperties)} does not support '{options.Format}' format.");
            }
        }

        GuestConfigurationAssignmentProperties IPersistableModel<GuestConfigurationAssignmentProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationAssignmentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGuestConfigurationAssignmentProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GuestConfigurationAssignmentProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GuestConfigurationAssignmentProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
