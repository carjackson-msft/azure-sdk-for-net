// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataShare.Models
{
    internal partial class ShareSubscriptionSynchronizationList : IUtf8JsonSerializable, IJsonModel<ShareSubscriptionSynchronizationList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ShareSubscriptionSynchronizationList>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ShareSubscriptionSynchronizationList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareSubscriptionSynchronizationList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ShareSubscriptionSynchronizationList)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (NextLink != null)
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
            }
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        ShareSubscriptionSynchronizationList IJsonModel<ShareSubscriptionSynchronizationList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareSubscriptionSynchronizationList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ShareSubscriptionSynchronizationList)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeShareSubscriptionSynchronizationList(document.RootElement, options);
        }

        internal static ShareSubscriptionSynchronizationList DeserializeShareSubscriptionSynchronizationList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            IReadOnlyList<ShareSubscriptionSynchronization> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    List<ShareSubscriptionSynchronization> array = new List<ShareSubscriptionSynchronization>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ShareSubscriptionSynchronization.DeserializeShareSubscriptionSynchronization(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ShareSubscriptionSynchronizationList(nextLink.Value, value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ShareSubscriptionSynchronizationList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareSubscriptionSynchronizationList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ShareSubscriptionSynchronizationList)} does not support '{options.Format}' format.");
            }
        }

        ShareSubscriptionSynchronizationList IPersistableModel<ShareSubscriptionSynchronizationList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareSubscriptionSynchronizationList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeShareSubscriptionSynchronizationList(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ShareSubscriptionSynchronizationList)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ShareSubscriptionSynchronizationList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
