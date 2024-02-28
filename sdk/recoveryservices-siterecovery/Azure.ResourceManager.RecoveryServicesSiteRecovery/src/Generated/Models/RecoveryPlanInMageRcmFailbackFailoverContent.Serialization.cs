// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class RecoveryPlanInMageRcmFailbackFailoverContent : IUtf8JsonSerializable, IJsonModel<RecoveryPlanInMageRcmFailbackFailoverContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryPlanInMageRcmFailbackFailoverContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecoveryPlanInMageRcmFailbackFailoverContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanInMageRcmFailbackFailoverContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPlanInMageRcmFailbackFailoverContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("recoveryPointType"u8);
            writer.WriteStringValue(RecoveryPointType.ToString());
            if (UseMultiVmSyncPoint != null)
            {
                writer.WritePropertyName("useMultiVmSyncPoint"u8);
                writer.WriteStringValue(UseMultiVmSyncPoint);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        RecoveryPlanInMageRcmFailbackFailoverContent IJsonModel<RecoveryPlanInMageRcmFailbackFailoverContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanInMageRcmFailbackFailoverContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPlanInMageRcmFailbackFailoverContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPlanInMageRcmFailbackFailoverContent(document.RootElement, options);
        }

        internal static RecoveryPlanInMageRcmFailbackFailoverContent DeserializeRecoveryPlanInMageRcmFailbackFailoverContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InMageRcmFailbackRecoveryPointType recoveryPointType = default;
            Optional<string> useMultiVmSyncPoint = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointType"u8))
                {
                    recoveryPointType = new InMageRcmFailbackRecoveryPointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useMultiVmSyncPoint"u8))
                {
                    useMultiVmSyncPoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RecoveryPlanInMageRcmFailbackFailoverContent(instanceType, serializedAdditionalRawData, recoveryPointType, useMultiVmSyncPoint.Value);
        }

        BinaryData IPersistableModel<RecoveryPlanInMageRcmFailbackFailoverContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanInMageRcmFailbackFailoverContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecoveryPlanInMageRcmFailbackFailoverContent)} does not support '{options.Format}' format.");
            }
        }

        RecoveryPlanInMageRcmFailbackFailoverContent IPersistableModel<RecoveryPlanInMageRcmFailbackFailoverContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanInMageRcmFailbackFailoverContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecoveryPlanInMageRcmFailbackFailoverContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryPlanInMageRcmFailbackFailoverContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryPlanInMageRcmFailbackFailoverContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
