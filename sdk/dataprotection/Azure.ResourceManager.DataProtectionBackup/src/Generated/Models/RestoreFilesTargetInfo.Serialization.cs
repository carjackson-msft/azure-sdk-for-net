// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class RestoreFilesTargetInfo : IUtf8JsonSerializable, IJsonModel<RestoreFilesTargetInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RestoreFilesTargetInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RestoreFilesTargetInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreFilesTargetInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestoreFilesTargetInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("targetDetails"u8);
            writer.WriteObjectValue(TargetDetails);
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WritePropertyName("recoveryOption"u8);
            writer.WriteStringValue(RecoverySetting.ToString());
            if (RestoreLocation.HasValue)
            {
                writer.WritePropertyName("restoreLocation"u8);
                writer.WriteStringValue(RestoreLocation.Value);
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

        RestoreFilesTargetInfo IJsonModel<RestoreFilesTargetInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreFilesTargetInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestoreFilesTargetInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRestoreFilesTargetInfo(document.RootElement, options);
        }

        internal static RestoreFilesTargetInfo DeserializeRestoreFilesTargetInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RestoreFilesTargetDetails targetDetails = default;
            string objectType = default;
            RecoverySetting recoveryOption = default;
            Optional<AzureLocation> restoreLocation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetDetails"u8))
                {
                    targetDetails = RestoreFilesTargetDetails.DeserializeRestoreFilesTargetDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryOption"u8))
                {
                    recoveryOption = new RecoverySetting(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("restoreLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RestoreFilesTargetInfo(objectType, recoveryOption, Optional.ToNullable(restoreLocation), serializedAdditionalRawData, targetDetails);
        }

        BinaryData IPersistableModel<RestoreFilesTargetInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreFilesTargetInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RestoreFilesTargetInfo)} does not support '{options.Format}' format.");
            }
        }

        RestoreFilesTargetInfo IPersistableModel<RestoreFilesTargetInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreFilesTargetInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRestoreFilesTargetInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RestoreFilesTargetInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RestoreFilesTargetInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
