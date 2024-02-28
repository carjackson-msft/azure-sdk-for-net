// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DevOpsConfigurationProperties : IUtf8JsonSerializable, IJsonModel<DevOpsConfigurationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevOpsConfigurationProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevOpsConfigurationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevOpsConfigurationProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ProvisioningStatusMessage != null)
            {
                writer.WritePropertyName("provisioningStatusMessage"u8);
                writer.WriteStringValue(ProvisioningStatusMessage);
            }
            if (options.Format != "W" && ProvisioningStatusUpdateTimeUtc.HasValue)
            {
                writer.WritePropertyName("provisioningStatusUpdateTimeUtc"u8);
                writer.WriteStringValue(ProvisioningStatusUpdateTimeUtc.Value, "O");
            }
            if (ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Authorization != null)
            {
                writer.WritePropertyName("authorization"u8);
                writer.WriteObjectValue(Authorization);
            }
            if (AutoDiscovery.HasValue)
            {
                writer.WritePropertyName("autoDiscovery"u8);
                writer.WriteStringValue(AutoDiscovery.Value.ToString());
            }
            if (!(TopLevelInventoryList is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("topLevelInventoryList"u8);
                writer.WriteStartArray();
                foreach (var item in TopLevelInventoryList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        DevOpsConfigurationProperties IJsonModel<DevOpsConfigurationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevOpsConfigurationProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevOpsConfigurationProperties(document.RootElement, options);
        }

        internal static DevOpsConfigurationProperties DeserializeDevOpsConfigurationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> provisioningStatusMessage = default;
            Optional<DateTimeOffset> provisioningStatusUpdateTimeUtc = default;
            Optional<DevOpsProvisioningState> provisioningState = default;
            Optional<DevOpsAuthorization> authorization = default;
            Optional<DevOpsAutoDiscovery> autoDiscovery = default;
            IList<string> topLevelInventoryList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningStatusMessage"u8))
                {
                    provisioningStatusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningStatusUpdateTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningStatusUpdateTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DevOpsProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("authorization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authorization = DevOpsAuthorization.DeserializeDevOpsAuthorization(property.Value, options);
                    continue;
                }
                if (property.NameEquals("autoDiscovery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoDiscovery = new DevOpsAutoDiscovery(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("topLevelInventoryList"u8))
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
                    topLevelInventoryList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevOpsConfigurationProperties(
                provisioningStatusMessage.Value,
                Optional.ToNullable(provisioningStatusUpdateTimeUtc),
                Optional.ToNullable(provisioningState),
                authorization.Value,
                Optional.ToNullable(autoDiscovery),
                topLevelInventoryList ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevOpsConfigurationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevOpsConfigurationProperties)} does not support '{options.Format}' format.");
            }
        }

        DevOpsConfigurationProperties IPersistableModel<DevOpsConfigurationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevOpsConfigurationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevOpsConfigurationProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevOpsConfigurationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
