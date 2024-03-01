// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class ThreatIntelligenceKillChainPhase : IUtf8JsonSerializable, IJsonModel<ThreatIntelligenceKillChainPhase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ThreatIntelligenceKillChainPhase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ThreatIntelligenceKillChainPhase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceKillChainPhase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThreatIntelligenceKillChainPhase)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (KillChainName != null)
            {
                writer.WritePropertyName("killChainName"u8);
                writer.WriteStringValue(KillChainName);
            }
            if (PhaseName != null)
            {
                writer.WritePropertyName("phaseName"u8);
                writer.WriteStringValue(PhaseName);
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

        ThreatIntelligenceKillChainPhase IJsonModel<ThreatIntelligenceKillChainPhase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceKillChainPhase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThreatIntelligenceKillChainPhase)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeThreatIntelligenceKillChainPhase(document.RootElement, options);
        }

        internal static ThreatIntelligenceKillChainPhase DeserializeThreatIntelligenceKillChainPhase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> killChainName = default;
            Optional<string> phaseName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("killChainName"u8))
                {
                    killChainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phaseName"u8))
                {
                    phaseName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ThreatIntelligenceKillChainPhase(killChainName.Value, phaseName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ThreatIntelligenceKillChainPhase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceKillChainPhase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ThreatIntelligenceKillChainPhase)} does not support '{options.Format}' format.");
            }
        }

        ThreatIntelligenceKillChainPhase IPersistableModel<ThreatIntelligenceKillChainPhase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceKillChainPhase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeThreatIntelligenceKillChainPhase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ThreatIntelligenceKillChainPhase)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ThreatIntelligenceKillChainPhase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
