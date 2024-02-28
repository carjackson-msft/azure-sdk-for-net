// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxHeavyJobDetails : IUtf8JsonSerializable, IJsonModel<DataBoxHeavyJobDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxHeavyJobDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxHeavyJobDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxHeavyJobDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxHeavyJobDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && !(CopyProgress is ChangeTrackingList<DataBoxCopyProgress> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("copyProgress"u8);
                writer.WriteStartArray();
                foreach (var item in CopyProgress)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (DevicePassword != null)
            {
                writer.WritePropertyName("devicePassword"u8);
                writer.WriteStringValue(DevicePassword);
            }
            if (options.Format != "W" && !(JobStages is ChangeTrackingList<DataBoxJobStage> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("jobStages"u8);
                writer.WriteStartArray();
                foreach (var item in JobStages)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("contactDetails"u8);
            writer.WriteObjectValue(ContactDetails);
            if (ShippingAddress != null)
            {
                writer.WritePropertyName("shippingAddress"u8);
                writer.WriteObjectValue(ShippingAddress);
            }
            if (options.Format != "W" && DeliveryPackage != null)
            {
                writer.WritePropertyName("deliveryPackage"u8);
                writer.WriteObjectValue(DeliveryPackage);
            }
            if (options.Format != "W" && ReturnPackage != null)
            {
                writer.WritePropertyName("returnPackage"u8);
                writer.WriteObjectValue(ReturnPackage);
            }
            if (!(DataImportDetails is ChangeTrackingList<DataImportDetails> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("dataImportDetails"u8);
                writer.WriteStartArray();
                foreach (var item in DataImportDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(DataExportDetails is ChangeTrackingList<DataExportDetails> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("dataExportDetails"u8);
                writer.WriteStartArray();
                foreach (var item in DataExportDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("jobDetailsType"u8);
            writer.WriteStringValue(JobDetailsType.ToSerialString());
            if (Preferences != null)
            {
                writer.WritePropertyName("preferences"u8);
                writer.WriteObjectValue(Preferences);
            }
            if (ReverseShippingDetails != null)
            {
                writer.WritePropertyName("reverseShippingDetails"u8);
                writer.WriteObjectValue(ReverseShippingDetails);
            }
            if (options.Format != "W" && !(CopyLogDetails is ChangeTrackingList<CopyLogDetails> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("copyLogDetails"u8);
                writer.WriteStartArray();
                foreach (var item in CopyLogDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ReverseShipmentLabelSasKey != null)
            {
                writer.WritePropertyName("reverseShipmentLabelSasKey"u8);
                writer.WriteStringValue(ReverseShipmentLabelSasKey);
            }
            if (options.Format != "W" && ChainOfCustodySasKey != null)
            {
                writer.WritePropertyName("chainOfCustodySasKey"u8);
                writer.WriteStringValue(ChainOfCustodySasKey);
            }
            if (options.Format != "W" && DeviceErasureDetails != null)
            {
                writer.WritePropertyName("deviceErasureDetails"u8);
                writer.WriteObjectValue(DeviceErasureDetails);
            }
            if (KeyEncryptionKey != null)
            {
                writer.WritePropertyName("keyEncryptionKey"u8);
                writer.WriteObjectValue(KeyEncryptionKey);
            }
            if (ExpectedDataSizeInTerabytes.HasValue)
            {
                writer.WritePropertyName("expectedDataSizeInTeraBytes"u8);
                writer.WriteNumberValue(ExpectedDataSizeInTerabytes.Value);
            }
            if (options.Format != "W" && !(Actions is ChangeTrackingList<CustomerResolutionCode> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("actions"u8);
                writer.WriteStartArray();
                foreach (var item in Actions)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && LastMitigationActionOnJob != null)
            {
                writer.WritePropertyName("lastMitigationActionOnJob"u8);
                writer.WriteObjectValue(LastMitigationActionOnJob);
            }
            if (options.Format != "W" && DataCenterAddress != null)
            {
                writer.WritePropertyName("datacenterAddress"u8);
                writer.WriteObjectValue(DataCenterAddress);
            }
            if (options.Format != "W" && DataCenterCode.HasValue)
            {
                writer.WritePropertyName("dataCenterCode"u8);
                writer.WriteStringValue(DataCenterCode.Value.ToString());
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

        DataBoxHeavyJobDetails IJsonModel<DataBoxHeavyJobDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxHeavyJobDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxHeavyJobDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxHeavyJobDetails(document.RootElement, options);
        }

        internal static DataBoxHeavyJobDetails DeserializeDataBoxHeavyJobDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DataBoxCopyProgress> copyProgress = default;
            Optional<string> devicePassword = default;
            IReadOnlyList<DataBoxJobStage> jobStages = default;
            DataBoxContactDetails contactDetails = default;
            Optional<DataBoxShippingAddress> shippingAddress = default;
            Optional<PackageShippingDetails> deliveryPackage = default;
            Optional<PackageShippingDetails> returnPackage = default;
            IList<DataImportDetails> dataImportDetails = default;
            IList<DataExportDetails> dataExportDetails = default;
            DataBoxOrderType jobDetailsType = default;
            Optional<DataBoxOrderPreferences> preferences = default;
            Optional<ReverseShippingDetails> reverseShippingDetails = default;
            IReadOnlyList<CopyLogDetails> copyLogDetails = default;
            Optional<string> reverseShipmentLabelSasKey = default;
            Optional<string> chainOfCustodySasKey = default;
            Optional<DeviceErasureDetails> deviceErasureDetails = default;
            Optional<DataBoxKeyEncryptionKey> keyEncryptionKey = default;
            Optional<int> expectedDataSizeInTerabytes = default;
            IReadOnlyList<CustomerResolutionCode> actions = default;
            Optional<LastMitigationActionOnJob> lastMitigationActionOnJob = default;
            Optional<DataCenterAddressResult> dataCenterAddress = default;
            Optional<DataCenterCode> dataCenterCode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("copyProgress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxCopyProgress> array = new List<DataBoxCopyProgress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxCopyProgress.DeserializeDataBoxCopyProgress(item, options));
                    }
                    copyProgress = array;
                    continue;
                }
                if (property.NameEquals("devicePassword"u8))
                {
                    devicePassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobStages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxJobStage> array = new List<DataBoxJobStage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxJobStage.DeserializeDataBoxJobStage(item, options));
                    }
                    jobStages = array;
                    continue;
                }
                if (property.NameEquals("contactDetails"u8))
                {
                    contactDetails = DataBoxContactDetails.DeserializeDataBoxContactDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("shippingAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shippingAddress = DataBoxShippingAddress.DeserializeDataBoxShippingAddress(property.Value, options);
                    continue;
                }
                if (property.NameEquals("deliveryPackage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deliveryPackage = PackageShippingDetails.DeserializePackageShippingDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("returnPackage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    returnPackage = PackageShippingDetails.DeserializePackageShippingDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataImportDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataImportDetails> array = new List<DataImportDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.DataImportDetails.DeserializeDataImportDetails(item, options));
                    }
                    dataImportDetails = array;
                    continue;
                }
                if (property.NameEquals("dataExportDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataExportDetails> array = new List<DataExportDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.DataExportDetails.DeserializeDataExportDetails(item, options));
                    }
                    dataExportDetails = array;
                    continue;
                }
                if (property.NameEquals("jobDetailsType"u8))
                {
                    jobDetailsType = property.Value.GetString().ToDataBoxOrderType();
                    continue;
                }
                if (property.NameEquals("preferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preferences = DataBoxOrderPreferences.DeserializeDataBoxOrderPreferences(property.Value, options);
                    continue;
                }
                if (property.NameEquals("reverseShippingDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reverseShippingDetails = ReverseShippingDetails.DeserializeReverseShippingDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("copyLogDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CopyLogDetails> array = new List<CopyLogDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.CopyLogDetails.DeserializeCopyLogDetails(item, options));
                    }
                    copyLogDetails = array;
                    continue;
                }
                if (property.NameEquals("reverseShipmentLabelSasKey"u8))
                {
                    reverseShipmentLabelSasKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("chainOfCustodySasKey"u8))
                {
                    chainOfCustodySasKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceErasureDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deviceErasureDetails = DeviceErasureDetails.DeserializeDeviceErasureDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("keyEncryptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyEncryptionKey = DataBoxKeyEncryptionKey.DeserializeDataBoxKeyEncryptionKey(property.Value, options);
                    continue;
                }
                if (property.NameEquals("expectedDataSizeInTeraBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expectedDataSizeInTerabytes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("actions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CustomerResolutionCode> array = new List<CustomerResolutionCode>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToCustomerResolutionCode());
                    }
                    actions = array;
                    continue;
                }
                if (property.NameEquals("lastMitigationActionOnJob"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastMitigationActionOnJob = LastMitigationActionOnJob.DeserializeLastMitigationActionOnJob(property.Value, options);
                    continue;
                }
                if (property.NameEquals("datacenterAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCenterAddress = DataCenterAddressResult.DeserializeDataCenterAddressResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataCenterCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCenterCode = new DataCenterCode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxHeavyJobDetails(
                jobStages ?? new ChangeTrackingList<DataBoxJobStage>(),
                contactDetails,
                shippingAddress.Value,
                deliveryPackage.Value,
                returnPackage.Value,
                dataImportDetails ?? new ChangeTrackingList<DataImportDetails>(),
                dataExportDetails ?? new ChangeTrackingList<DataExportDetails>(),
                jobDetailsType,
                preferences.Value,
                reverseShippingDetails.Value,
                copyLogDetails ?? new ChangeTrackingList<CopyLogDetails>(),
                reverseShipmentLabelSasKey.Value,
                chainOfCustodySasKey.Value,
                deviceErasureDetails.Value,
                keyEncryptionKey.Value,
                Optional.ToNullable(expectedDataSizeInTerabytes),
                actions ?? new ChangeTrackingList<CustomerResolutionCode>(),
                lastMitigationActionOnJob.Value,
                dataCenterAddress.Value,
                Optional.ToNullable(dataCenterCode),
                serializedAdditionalRawData,
                copyProgress ?? new ChangeTrackingList<DataBoxCopyProgress>(),
                devicePassword.Value);
        }

        BinaryData IPersistableModel<DataBoxHeavyJobDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxHeavyJobDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxHeavyJobDetails)} does not support '{options.Format}' format.");
            }
        }

        DataBoxHeavyJobDetails IPersistableModel<DataBoxHeavyJobDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxHeavyJobDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxHeavyJobDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxHeavyJobDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxHeavyJobDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
