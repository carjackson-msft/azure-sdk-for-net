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
    public partial class EmailNotification : IUtf8JsonSerializable, IJsonModel<EmailNotification>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EmailNotification>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EmailNotification>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EmailNotification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EmailNotification)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (SendToSubscriptionAdministrator.HasValue)
            {
                writer.WritePropertyName("sendToSubscriptionAdministrator"u8);
                writer.WriteBooleanValue(SendToSubscriptionAdministrator.Value);
            }
            if (SendToSubscriptionCoAdministrators.HasValue)
            {
                writer.WritePropertyName("sendToSubscriptionCoAdministrators"u8);
                writer.WriteBooleanValue(SendToSubscriptionCoAdministrators.Value);
            }
            if (!(CustomEmails is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("customEmails"u8);
                writer.WriteStartArray();
                foreach (var item in CustomEmails)
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

        EmailNotification IJsonModel<EmailNotification>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EmailNotification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EmailNotification)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEmailNotification(document.RootElement, options);
        }

        internal static EmailNotification DeserializeEmailNotification(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> sendToSubscriptionAdministrator = default;
            Optional<bool> sendToSubscriptionCoAdministrators = default;
            IList<string> customEmails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sendToSubscriptionAdministrator"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendToSubscriptionAdministrator = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sendToSubscriptionCoAdministrators"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendToSubscriptionCoAdministrators = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("customEmails"u8))
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
                    customEmails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EmailNotification(Optional.ToNullable(sendToSubscriptionAdministrator), Optional.ToNullable(sendToSubscriptionCoAdministrators), customEmails ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EmailNotification>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EmailNotification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EmailNotification)} does not support '{options.Format}' format.");
            }
        }

        EmailNotification IPersistableModel<EmailNotification>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EmailNotification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEmailNotification(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EmailNotification)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EmailNotification>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
