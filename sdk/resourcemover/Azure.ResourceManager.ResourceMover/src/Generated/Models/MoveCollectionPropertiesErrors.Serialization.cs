// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    internal partial class MoveCollectionPropertiesErrors : IUtf8JsonSerializable, IJsonModel<MoveCollectionPropertiesErrors>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MoveCollectionPropertiesErrors>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MoveCollectionPropertiesErrors>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoveCollectionPropertiesErrors>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoveCollectionPropertiesErrors)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Properties != null)
            {
                writer.WritePropertyName("properties"u8);
                JsonSerializer.Serialize(writer, Properties);
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

        MoveCollectionPropertiesErrors IJsonModel<MoveCollectionPropertiesErrors>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoveCollectionPropertiesErrors>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoveCollectionPropertiesErrors)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMoveCollectionPropertiesErrors(document.RootElement, options);
        }

        internal static MoveCollectionPropertiesErrors DeserializeMoveCollectionPropertiesErrors(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResponseError> properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MoveCollectionPropertiesErrors(properties.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MoveCollectionPropertiesErrors>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoveCollectionPropertiesErrors>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MoveCollectionPropertiesErrors)} does not support '{options.Format}' format.");
            }
        }

        MoveCollectionPropertiesErrors IPersistableModel<MoveCollectionPropertiesErrors>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoveCollectionPropertiesErrors>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMoveCollectionPropertiesErrors(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MoveCollectionPropertiesErrors)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MoveCollectionPropertiesErrors>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
