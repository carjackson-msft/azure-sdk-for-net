// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Qumulo.Models
{
    public partial class MarketplaceDetails : IUtf8JsonSerializable, IJsonModel<MarketplaceDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MarketplaceDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MarketplaceDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MarketplaceDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (MarketplaceSubscriptionId != null)
            {
                writer.WritePropertyName("marketplaceSubscriptionId"u8);
                writer.WriteStringValue(MarketplaceSubscriptionId);
            }
            writer.WritePropertyName("planId"u8);
            writer.WriteStringValue(PlanId);
            writer.WritePropertyName("offerId"u8);
            writer.WriteStringValue(OfferId);
            writer.WritePropertyName("publisherId"u8);
            writer.WriteStringValue(PublisherId);
            if (options.Format != "W" && MarketplaceSubscriptionStatus.HasValue)
            {
                writer.WritePropertyName("marketplaceSubscriptionStatus"u8);
                writer.WriteStringValue(MarketplaceSubscriptionStatus.Value.ToSerialString());
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

        MarketplaceDetails IJsonModel<MarketplaceDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MarketplaceDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMarketplaceDetails(document.RootElement, options);
        }

        internal static MarketplaceDetails DeserializeMarketplaceDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> marketplaceSubscriptionId = default;
            string planId = default;
            string offerId = default;
            string publisherId = default;
            Optional<MarketplaceSubscriptionStatus> marketplaceSubscriptionStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("marketplaceSubscriptionId"u8))
                {
                    marketplaceSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("planId"u8))
                {
                    planId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offerId"u8))
                {
                    offerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisherId"u8))
                {
                    publisherId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("marketplaceSubscriptionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    marketplaceSubscriptionStatus = property.Value.GetString().ToMarketplaceSubscriptionStatus();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MarketplaceDetails(
                marketplaceSubscriptionId.Value,
                planId,
                offerId,
                publisherId,
                Optional.ToNullable(marketplaceSubscriptionStatus),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MarketplaceDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MarketplaceDetails)} does not support '{options.Format}' format.");
            }
        }

        MarketplaceDetails IPersistableModel<MarketplaceDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMarketplaceDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MarketplaceDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MarketplaceDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
