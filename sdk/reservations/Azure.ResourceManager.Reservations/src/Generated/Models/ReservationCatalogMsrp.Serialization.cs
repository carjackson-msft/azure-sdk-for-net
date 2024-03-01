// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ReservationCatalogMsrp : IUtf8JsonSerializable, IJsonModel<ReservationCatalogMsrp>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReservationCatalogMsrp>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReservationCatalogMsrp>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationCatalogMsrp>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationCatalogMsrp)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (P1Y != null)
            {
                writer.WritePropertyName("p1Y"u8);
                writer.WriteObjectValue(P1Y);
            }
            if (P3Y != null)
            {
                writer.WritePropertyName("p3Y"u8);
                writer.WriteObjectValue(P3Y);
            }
            if (P5Y != null)
            {
                writer.WritePropertyName("p5Y"u8);
                writer.WriteObjectValue(P5Y);
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

        ReservationCatalogMsrp IJsonModel<ReservationCatalogMsrp>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationCatalogMsrp>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationCatalogMsrp)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReservationCatalogMsrp(document.RootElement, options);
        }

        internal static ReservationCatalogMsrp DeserializeReservationCatalogMsrp(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PurchasePrice> p1Y = default;
            Optional<PurchasePrice> p3Y = default;
            Optional<PurchasePrice> p5Y = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("p1Y"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    p1Y = PurchasePrice.DeserializePurchasePrice(property.Value, options);
                    continue;
                }
                if (property.NameEquals("p3Y"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    p3Y = PurchasePrice.DeserializePurchasePrice(property.Value, options);
                    continue;
                }
                if (property.NameEquals("p5Y"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    p5Y = PurchasePrice.DeserializePurchasePrice(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReservationCatalogMsrp(p1Y.Value, p3Y.Value, p5Y.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReservationCatalogMsrp>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationCatalogMsrp>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReservationCatalogMsrp)} does not support '{options.Format}' format.");
            }
        }

        ReservationCatalogMsrp IPersistableModel<ReservationCatalogMsrp>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationCatalogMsrp>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReservationCatalogMsrp(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReservationCatalogMsrp)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReservationCatalogMsrp>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
