// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Elastic.Models
{
    public partial class MonitorProperties : IUtf8JsonSerializable, IJsonModel<MonitorProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitorProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (MonitoringStatus.HasValue)
            {
                writer.WritePropertyName("monitoringStatus"u8);
                writer.WriteStringValue(MonitoringStatus.Value.ToString());
            }
            if (ElasticProperties != null)
            {
                writer.WritePropertyName("elasticProperties"u8);
                writer.WriteObjectValue(ElasticProperties);
            }
            if (UserInfo != null)
            {
                writer.WritePropertyName("userInfo"u8);
                writer.WriteObjectValue(UserInfo);
            }
            if (options.Format != "W" && LiftrResourceCategory.HasValue)
            {
                writer.WritePropertyName("liftrResourceCategory"u8);
                writer.WriteStringValue(LiftrResourceCategory.Value.ToString());
            }
            if (options.Format != "W" && LiftrResourcePreference.HasValue)
            {
                writer.WritePropertyName("liftrResourcePreference"u8);
                writer.WriteNumberValue(LiftrResourcePreference.Value);
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

        MonitorProperties IJsonModel<MonitorProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorProperties(document.RootElement, options);
        }

        internal static MonitorProperties DeserializeMonitorProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProvisioningState> provisioningState = default;
            Optional<MonitoringStatus> monitoringStatus = default;
            Optional<ElasticProperties> elasticProperties = default;
            Optional<UserInfo> userInfo = default;
            Optional<LiftrResourceCategory> liftrResourceCategory = default;
            Optional<int> liftrResourcePreference = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("monitoringStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitoringStatus = new MonitoringStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("elasticProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    elasticProperties = ElasticProperties.DeserializeElasticProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("userInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userInfo = UserInfo.DeserializeUserInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("liftrResourceCategory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    liftrResourceCategory = new LiftrResourceCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("liftrResourcePreference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    liftrResourcePreference = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MonitorProperties(
                Optional.ToNullable(provisioningState),
                Optional.ToNullable(monitoringStatus),
                elasticProperties.Value,
                userInfo.Value,
                Optional.ToNullable(liftrResourceCategory),
                Optional.ToNullable(liftrResourcePreference),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitorProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitorProperties)} does not support '{options.Format}' format.");
            }
        }

        MonitorProperties IPersistableModel<MonitorProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitorProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitorProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
