// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBAccountReadOnlyKeyList : IUtf8JsonSerializable, IJsonModel<CosmosDBAccountReadOnlyKeyList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBAccountReadOnlyKeyList>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CosmosDBAccountReadOnlyKeyList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBAccountReadOnlyKeyList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBAccountReadOnlyKeyList)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && PrimaryReadonlyMasterKey != null)
            {
                writer.WritePropertyName("primaryReadonlyMasterKey"u8);
                writer.WriteStringValue(PrimaryReadonlyMasterKey);
            }
            if (options.Format != "W" && SecondaryReadonlyMasterKey != null)
            {
                writer.WritePropertyName("secondaryReadonlyMasterKey"u8);
                writer.WriteStringValue(SecondaryReadonlyMasterKey);
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

        CosmosDBAccountReadOnlyKeyList IJsonModel<CosmosDBAccountReadOnlyKeyList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBAccountReadOnlyKeyList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBAccountReadOnlyKeyList)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBAccountReadOnlyKeyList(document.RootElement, options);
        }

        internal static CosmosDBAccountReadOnlyKeyList DeserializeCosmosDBAccountReadOnlyKeyList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> primaryReadonlyMasterKey = default;
            Optional<string> secondaryReadonlyMasterKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryReadonlyMasterKey"u8))
                {
                    primaryReadonlyMasterKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryReadonlyMasterKey"u8))
                {
                    secondaryReadonlyMasterKey = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CosmosDBAccountReadOnlyKeyList(primaryReadonlyMasterKey.Value, secondaryReadonlyMasterKey.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CosmosDBAccountReadOnlyKeyList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBAccountReadOnlyKeyList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBAccountReadOnlyKeyList)} does not support '{options.Format}' format.");
            }
        }

        CosmosDBAccountReadOnlyKeyList IPersistableModel<CosmosDBAccountReadOnlyKeyList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBAccountReadOnlyKeyList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBAccountReadOnlyKeyList(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBAccountReadOnlyKeyList)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBAccountReadOnlyKeyList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
