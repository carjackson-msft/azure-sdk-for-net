// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class BareMetalMachineCordonContent : IUtf8JsonSerializable, IJsonModel<BareMetalMachineCordonContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BareMetalMachineCordonContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BareMetalMachineCordonContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BareMetalMachineCordonContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BareMetalMachineCordonContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Evacuate.HasValue)
            {
                writer.WritePropertyName("evacuate"u8);
                writer.WriteStringValue(Evacuate.Value.ToString());
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

        BareMetalMachineCordonContent IJsonModel<BareMetalMachineCordonContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BareMetalMachineCordonContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BareMetalMachineCordonContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBareMetalMachineCordonContent(document.RootElement, options);
        }

        internal static BareMetalMachineCordonContent DeserializeBareMetalMachineCordonContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BareMetalMachineEvacuate> evacuate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("evacuate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    evacuate = new BareMetalMachineEvacuate(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BareMetalMachineCordonContent(Optional.ToNullable(evacuate), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BareMetalMachineCordonContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BareMetalMachineCordonContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BareMetalMachineCordonContent)} does not support '{options.Format}' format.");
            }
        }

        BareMetalMachineCordonContent IPersistableModel<BareMetalMachineCordonContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BareMetalMachineCordonContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBareMetalMachineCordonContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BareMetalMachineCordonContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BareMetalMachineCordonContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
