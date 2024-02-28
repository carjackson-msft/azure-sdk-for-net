// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class BudgetCurrentSpend : IUtf8JsonSerializable, IJsonModel<BudgetCurrentSpend>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BudgetCurrentSpend>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BudgetCurrentSpend>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BudgetCurrentSpend>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BudgetCurrentSpend)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Amount.HasValue)
            {
                writer.WritePropertyName("amount"u8);
                writer.WriteNumberValue(Amount.Value);
            }
            if (options.Format != "W" && Unit != null)
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit);
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

        BudgetCurrentSpend IJsonModel<BudgetCurrentSpend>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BudgetCurrentSpend>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BudgetCurrentSpend)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBudgetCurrentSpend(document.RootElement, options);
        }

        internal static BudgetCurrentSpend DeserializeBudgetCurrentSpend(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<decimal> amount = default;
            Optional<string> unit = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("amount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    amount = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BudgetCurrentSpend(Optional.ToNullable(amount), unit.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BudgetCurrentSpend>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BudgetCurrentSpend>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BudgetCurrentSpend)} does not support '{options.Format}' format.");
            }
        }

        BudgetCurrentSpend IPersistableModel<BudgetCurrentSpend>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BudgetCurrentSpend>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBudgetCurrentSpend(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BudgetCurrentSpend)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BudgetCurrentSpend>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
