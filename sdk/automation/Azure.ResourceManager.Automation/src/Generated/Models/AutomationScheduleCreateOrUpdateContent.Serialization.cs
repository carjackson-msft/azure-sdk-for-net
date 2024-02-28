// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class AutomationScheduleCreateOrUpdateContent : IUtf8JsonSerializable, IJsonModel<AutomationScheduleCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutomationScheduleCreateOrUpdateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutomationScheduleCreateOrUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationScheduleCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationScheduleCreateOrUpdateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartOn, "O");
            if (ExpireOn.HasValue)
            {
                if (ExpireOn != null)
                {
                    writer.WritePropertyName("expiryTime"u8);
                    writer.WriteStringValue(ExpireOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("expiryTime");
                }
            }
            if (Interval != null)
            {
                writer.WritePropertyName("interval"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Interval);
#else
                using (JsonDocument document = JsonDocument.Parse(Interval))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WritePropertyName("frequency"u8);
            writer.WriteStringValue(Frequency.ToString());
            if (TimeZone != null)
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
            }
            if (AdvancedSchedule != null)
            {
                writer.WritePropertyName("advancedSchedule"u8);
                writer.WriteObjectValue(AdvancedSchedule);
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

        AutomationScheduleCreateOrUpdateContent IJsonModel<AutomationScheduleCreateOrUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationScheduleCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationScheduleCreateOrUpdateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationScheduleCreateOrUpdateContent(document.RootElement, options);
        }

        internal static AutomationScheduleCreateOrUpdateContent DeserializeAutomationScheduleCreateOrUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<string> description = default;
            DateTimeOffset startTime = default;
            Optional<DateTimeOffset?> expiryTime = default;
            Optional<BinaryData> interval = default;
            AutomationScheduleFrequency frequency = default;
            Optional<string> timeZone = default;
            Optional<AutomationAdvancedSchedule> advancedSchedule = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("expiryTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                expiryTime = null;
                                continue;
                            }
                            expiryTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("interval"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            interval = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("frequency"u8))
                        {
                            frequency = new AutomationScheduleFrequency(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("timeZone"u8))
                        {
                            timeZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("advancedSchedule"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            advancedSchedule = AutomationAdvancedSchedule.DeserializeAutomationAdvancedSchedule(property0.Value, options);
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
            return new AutomationScheduleCreateOrUpdateContent(
                name,
                description.Value,
                startTime,
                Optional.ToNullable(expiryTime),
                interval.Value,
                frequency,
                timeZone.Value,
                advancedSchedule.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutomationScheduleCreateOrUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationScheduleCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutomationScheduleCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        AutomationScheduleCreateOrUpdateContent IPersistableModel<AutomationScheduleCreateOrUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationScheduleCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutomationScheduleCreateOrUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutomationScheduleCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutomationScheduleCreateOrUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
