// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformConfigurationServiceSettings : IUtf8JsonSerializable, IJsonModel<AppPlatformConfigurationServiceSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformConfigurationServiceSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppPlatformConfigurationServiceSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformConfigurationServiceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformConfigurationServiceSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (GitProperty != null)
            {
                writer.WritePropertyName("gitProperty"u8);
                writer.WriteObjectValue(GitProperty);
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

        AppPlatformConfigurationServiceSettings IJsonModel<AppPlatformConfigurationServiceSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformConfigurationServiceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformConfigurationServiceSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformConfigurationServiceSettings(document.RootElement, options);
        }

        internal static AppPlatformConfigurationServiceSettings DeserializeAppPlatformConfigurationServiceSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ConfigurationServiceGitProperty> gitProperty = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("gitProperty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gitProperty = ConfigurationServiceGitProperty.DeserializeConfigurationServiceGitProperty(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformConfigurationServiceSettings(gitProperty.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformConfigurationServiceSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformConfigurationServiceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformConfigurationServiceSettings)} does not support '{options.Format}' format.");
            }
        }

        AppPlatformConfigurationServiceSettings IPersistableModel<AppPlatformConfigurationServiceSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformConfigurationServiceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformConfigurationServiceSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformConfigurationServiceSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformConfigurationServiceSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
