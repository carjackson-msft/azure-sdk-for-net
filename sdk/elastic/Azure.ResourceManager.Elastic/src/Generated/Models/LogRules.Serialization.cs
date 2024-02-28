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
    public partial class LogRules : IUtf8JsonSerializable, IJsonModel<LogRules>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogRules>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogRules>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogRules)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (SendAadLogs.HasValue)
            {
                writer.WritePropertyName("sendAadLogs"u8);
                writer.WriteBooleanValue(SendAadLogs.Value);
            }
            if (SendSubscriptionLogs.HasValue)
            {
                writer.WritePropertyName("sendSubscriptionLogs"u8);
                writer.WriteBooleanValue(SendSubscriptionLogs.Value);
            }
            if (SendActivityLogs.HasValue)
            {
                writer.WritePropertyName("sendActivityLogs"u8);
                writer.WriteBooleanValue(SendActivityLogs.Value);
            }
            if (!(FilteringTags is ChangeTrackingList<FilteringTag> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("filteringTags"u8);
                writer.WriteStartArray();
                foreach (var item in FilteringTags)
                {
                    writer.WriteObjectValue(item);
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

        LogRules IJsonModel<LogRules>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogRules)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogRules(document.RootElement, options);
        }

        internal static LogRules DeserializeLogRules(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> sendAadLogs = default;
            Optional<bool> sendSubscriptionLogs = default;
            Optional<bool> sendActivityLogs = default;
            IList<FilteringTag> filteringTags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sendAadLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendAadLogs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sendSubscriptionLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendSubscriptionLogs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sendActivityLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendActivityLogs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("filteringTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FilteringTag> array = new List<FilteringTag>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FilteringTag.DeserializeFilteringTag(item, options));
                    }
                    filteringTags = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogRules(Optional.ToNullable(sendAadLogs), Optional.ToNullable(sendSubscriptionLogs), Optional.ToNullable(sendActivityLogs), filteringTags ?? new ChangeTrackingList<FilteringTag>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LogRules>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogRules)} does not support '{options.Format}' format.");
            }
        }

        LogRules IPersistableModel<LogRules>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogRules(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogRules)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogRules>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
