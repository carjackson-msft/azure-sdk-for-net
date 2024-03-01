// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class EventHubOutputDataSource : IUtf8JsonSerializable, IJsonModel<EventHubOutputDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventHubOutputDataSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EventHubOutputDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubOutputDataSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(OutputDataSourceType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (ServiceBusNamespace != null)
            {
                writer.WritePropertyName("serviceBusNamespace"u8);
                writer.WriteStringValue(ServiceBusNamespace);
            }
            if (SharedAccessPolicyName != null)
            {
                writer.WritePropertyName("sharedAccessPolicyName"u8);
                writer.WriteStringValue(SharedAccessPolicyName);
            }
            if (SharedAccessPolicyKey != null)
            {
                writer.WritePropertyName("sharedAccessPolicyKey"u8);
                writer.WriteStringValue(SharedAccessPolicyKey);
            }
            if (AuthenticationMode.HasValue)
            {
                writer.WritePropertyName("authenticationMode"u8);
                writer.WriteStringValue(AuthenticationMode.Value.ToString());
            }
            if (EventHubName != null)
            {
                writer.WritePropertyName("eventHubName"u8);
                writer.WriteStringValue(EventHubName);
            }
            if (PartitionCount.HasValue)
            {
                writer.WritePropertyName("partitionCount"u8);
                writer.WriteNumberValue(PartitionCount.Value);
            }
            if (PartitionKey != null)
            {
                writer.WritePropertyName("partitionKey"u8);
                writer.WriteStringValue(PartitionKey);
            }
            if (!(PropertyColumns is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("propertyColumns"u8);
                writer.WriteStartArray();
                foreach (var item in PropertyColumns)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        EventHubOutputDataSource IJsonModel<EventHubOutputDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubOutputDataSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventHubOutputDataSource(document.RootElement, options);
        }

        internal static EventHubOutputDataSource DeserializeEventHubOutputDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<string> serviceBusNamespace = default;
            Optional<string> sharedAccessPolicyName = default;
            Optional<string> sharedAccessPolicyKey = default;
            Optional<StreamAnalyticsAuthenticationMode> authenticationMode = default;
            Optional<string> eventHubName = default;
            Optional<int> partitionCount = default;
            Optional<string> partitionKey = default;
            IList<string> propertyColumns = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("serviceBusNamespace"u8))
                        {
                            serviceBusNamespace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sharedAccessPolicyName"u8))
                        {
                            sharedAccessPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sharedAccessPolicyKey"u8))
                        {
                            sharedAccessPolicyKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authenticationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationMode = new StreamAnalyticsAuthenticationMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("eventHubName"u8))
                        {
                            eventHubName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partitionCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partitionCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("partitionKey"u8))
                        {
                            partitionKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("propertyColumns"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            propertyColumns = array;
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
            return new EventHubOutputDataSource(
                type,
                serializedAdditionalRawData,
                serviceBusNamespace.Value,
                sharedAccessPolicyName.Value,
                sharedAccessPolicyKey.Value,
                Optional.ToNullable(authenticationMode),
                eventHubName.Value,
                Optional.ToNullable(partitionCount),
                partitionKey.Value,
                propertyColumns ?? new ChangeTrackingList<string>());
        }

        BinaryData IPersistableModel<EventHubOutputDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EventHubOutputDataSource)} does not support '{options.Format}' format.");
            }
        }

        EventHubOutputDataSource IPersistableModel<EventHubOutputDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventHubOutputDataSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventHubOutputDataSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventHubOutputDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
