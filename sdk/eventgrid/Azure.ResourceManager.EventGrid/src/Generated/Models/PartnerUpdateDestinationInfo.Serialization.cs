// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    [PersistableModelProxy(typeof(UnknownPartnerUpdateDestinationInfo))]
    public partial class PartnerUpdateDestinationInfo : IUtf8JsonSerializable, IJsonModel<PartnerUpdateDestinationInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PartnerUpdateDestinationInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PartnerUpdateDestinationInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerUpdateDestinationInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartnerUpdateDestinationInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
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

        PartnerUpdateDestinationInfo IJsonModel<PartnerUpdateDestinationInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerUpdateDestinationInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartnerUpdateDestinationInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePartnerUpdateDestinationInfo(document.RootElement, options);
        }

        internal static PartnerUpdateDestinationInfo DeserializePartnerUpdateDestinationInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("endpointType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "WebHook": return WebhookUpdatePartnerDestinationInfo.DeserializeWebhookUpdatePartnerDestinationInfo(element, options);
                }
            }
            return UnknownPartnerUpdateDestinationInfo.DeserializeUnknownPartnerUpdateDestinationInfo(element, options);
        }

        BinaryData IPersistableModel<PartnerUpdateDestinationInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerUpdateDestinationInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PartnerUpdateDestinationInfo)} does not support '{options.Format}' format.");
            }
        }

        PartnerUpdateDestinationInfo IPersistableModel<PartnerUpdateDestinationInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerUpdateDestinationInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePartnerUpdateDestinationInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PartnerUpdateDestinationInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PartnerUpdateDestinationInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
