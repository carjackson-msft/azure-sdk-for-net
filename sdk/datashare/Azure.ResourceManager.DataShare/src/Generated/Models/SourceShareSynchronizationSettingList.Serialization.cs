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
    internal partial class SourceShareSynchronizationSettingList : IUtf8JsonSerializable, IJsonModel<SourceShareSynchronizationSettingList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SourceShareSynchronizationSettingList>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SourceShareSynchronizationSettingList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceShareSynchronizationSettingList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SourceShareSynchronizationSettingList)} does not support '{format}' format.");
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

        SourceShareSynchronizationSettingList IJsonModel<SourceShareSynchronizationSettingList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceShareSynchronizationSettingList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SourceShareSynchronizationSettingList)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSourceShareSynchronizationSettingList(document.RootElement, options);
        }

        internal static SourceShareSynchronizationSettingList DeserializeSourceShareSynchronizationSettingList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            IReadOnlyList<SourceShareSynchronizationSetting> value = default;
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
                    List<SourceShareSynchronizationSetting> array = new List<SourceShareSynchronizationSetting>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SourceShareSynchronizationSetting.DeserializeSourceShareSynchronizationSetting(item, options));
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
            return new SourceShareSynchronizationSettingList(nextLink.Value, value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SourceShareSynchronizationSettingList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceShareSynchronizationSettingList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SourceShareSynchronizationSettingList)} does not support '{options.Format}' format.");
            }
        }

        SourceShareSynchronizationSettingList IPersistableModel<SourceShareSynchronizationSettingList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceShareSynchronizationSettingList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSourceShareSynchronizationSettingList(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SourceShareSynchronizationSettingList)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SourceShareSynchronizationSettingList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
