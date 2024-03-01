// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    [PersistableModelProxy(typeof(UnknownResourceDetails))]
    public partial class SecurityCenterResourceDetails : IUtf8JsonSerializable, IJsonModel<SecurityCenterResourceDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityCenterResourceDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityCenterResourceDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterResourceDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityCenterResourceDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("source"u8);
            writer.WriteStringValue(Source.ToString());
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

        SecurityCenterResourceDetails IJsonModel<SecurityCenterResourceDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterResourceDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityCenterResourceDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityCenterResourceDetails(document.RootElement, options);
        }

        internal static SecurityCenterResourceDetails DeserializeSecurityCenterResourceDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("source", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Azure": return AzureResourceDetails.DeserializeAzureResourceDetails(element, options);
                    case "OnPremise": return OnPremiseResourceDetails.DeserializeOnPremiseResourceDetails(element, options);
                    case "OnPremiseSql": return OnPremiseSqlResourceDetails.DeserializeOnPremiseSqlResourceDetails(element, options);
                }
            }
            return UnknownResourceDetails.DeserializeUnknownResourceDetails(element, options);
        }

        BinaryData IPersistableModel<SecurityCenterResourceDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterResourceDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityCenterResourceDetails)} does not support '{options.Format}' format.");
            }
        }

        SecurityCenterResourceDetails IPersistableModel<SecurityCenterResourceDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterResourceDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityCenterResourceDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityCenterResourceDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityCenterResourceDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
