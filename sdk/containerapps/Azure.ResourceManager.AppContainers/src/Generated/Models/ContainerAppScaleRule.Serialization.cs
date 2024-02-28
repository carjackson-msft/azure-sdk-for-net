// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppScaleRule : IUtf8JsonSerializable, IJsonModel<ContainerAppScaleRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppScaleRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppScaleRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppScaleRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppScaleRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (AzureQueue != null)
            {
                writer.WritePropertyName("azureQueue"u8);
                writer.WriteObjectValue(AzureQueue);
            }
            if (Custom != null)
            {
                writer.WritePropertyName("custom"u8);
                writer.WriteObjectValue(Custom);
            }
            if (Http != null)
            {
                writer.WritePropertyName("http"u8);
                writer.WriteObjectValue(Http);
            }
            if (Tcp != null)
            {
                writer.WritePropertyName("tcp"u8);
                writer.WriteObjectValue(Tcp);
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

        ContainerAppScaleRule IJsonModel<ContainerAppScaleRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppScaleRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppScaleRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppScaleRule(document.RootElement, options);
        }

        internal static ContainerAppScaleRule DeserializeContainerAppScaleRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<ContainerAppQueueScaleRule> azureQueue = default;
            Optional<ContainerAppCustomScaleRule> custom = default;
            Optional<ContainerAppHttpScaleRule> http = default;
            Optional<ContainerAppTcpScaleRule> tcp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureQueue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureQueue = ContainerAppQueueScaleRule.DeserializeContainerAppQueueScaleRule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("custom"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    custom = ContainerAppCustomScaleRule.DeserializeContainerAppCustomScaleRule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("http"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    http = ContainerAppHttpScaleRule.DeserializeContainerAppHttpScaleRule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tcp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tcp = ContainerAppTcpScaleRule.DeserializeContainerAppTcpScaleRule(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppScaleRule(
                name.Value,
                azureQueue.Value,
                custom.Value,
                http.Value,
                tcp.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppScaleRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppScaleRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppScaleRule)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppScaleRule IPersistableModel<ContainerAppScaleRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppScaleRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppScaleRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppScaleRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppScaleRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
