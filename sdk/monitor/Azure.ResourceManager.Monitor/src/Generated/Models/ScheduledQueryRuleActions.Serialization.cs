// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class ScheduledQueryRuleActions : IUtf8JsonSerializable, IJsonModel<ScheduledQueryRuleActions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScheduledQueryRuleActions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ScheduledQueryRuleActions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledQueryRuleActions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduledQueryRuleActions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(ActionGroups is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("actionGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ActionGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(CustomProperties is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("customProperties"u8);
                writer.WriteStartObject();
                foreach (var item in CustomProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        ScheduledQueryRuleActions IJsonModel<ScheduledQueryRuleActions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledQueryRuleActions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduledQueryRuleActions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScheduledQueryRuleActions(document.RootElement, options);
        }

        internal static ScheduledQueryRuleActions DeserializeScheduledQueryRuleActions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> actionGroups = default;
            IDictionary<string, string> customProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionGroups"u8))
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
                    actionGroups = array;
                    continue;
                }
                if (property.NameEquals("customProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    customProperties = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ScheduledQueryRuleActions(actionGroups ?? new ChangeTrackingList<string>(), customProperties ?? new ChangeTrackingDictionary<string, string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScheduledQueryRuleActions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledQueryRuleActions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScheduledQueryRuleActions)} does not support '{options.Format}' format.");
            }
        }

        ScheduledQueryRuleActions IPersistableModel<ScheduledQueryRuleActions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledQueryRuleActions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScheduledQueryRuleActions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScheduledQueryRuleActions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScheduledQueryRuleActions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
