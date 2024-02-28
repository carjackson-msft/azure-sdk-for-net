// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppInsightsWebAppStackSettings : IUtf8JsonSerializable, IJsonModel<AppInsightsWebAppStackSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppInsightsWebAppStackSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppInsightsWebAppStackSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppInsightsWebAppStackSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppInsightsWebAppStackSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && IsSupported.HasValue)
            {
                writer.WritePropertyName("isSupported"u8);
                writer.WriteBooleanValue(IsSupported.Value);
            }
            if (options.Format != "W" && IsDefaultOff.HasValue)
            {
                writer.WritePropertyName("isDefaultOff"u8);
                writer.WriteBooleanValue(IsDefaultOff.Value);
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

        AppInsightsWebAppStackSettings IJsonModel<AppInsightsWebAppStackSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppInsightsWebAppStackSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppInsightsWebAppStackSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppInsightsWebAppStackSettings(document.RootElement, options);
        }

        internal static AppInsightsWebAppStackSettings DeserializeAppInsightsWebAppStackSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> isSupported = default;
            Optional<bool> isDefaultOff = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDefaultOff"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDefaultOff = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppInsightsWebAppStackSettings(Optional.ToNullable(isSupported), Optional.ToNullable(isDefaultOff), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppInsightsWebAppStackSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppInsightsWebAppStackSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppInsightsWebAppStackSettings)} does not support '{options.Format}' format.");
            }
        }

        AppInsightsWebAppStackSettings IPersistableModel<AppInsightsWebAppStackSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppInsightsWebAppStackSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppInsightsWebAppStackSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppInsightsWebAppStackSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppInsightsWebAppStackSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
