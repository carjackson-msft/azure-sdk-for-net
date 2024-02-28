// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class CustomInferencingServer : IUtf8JsonSerializable, IJsonModel<CustomInferencingServer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomInferencingServer>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CustomInferencingServer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomInferencingServer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomInferencingServer)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (InferenceConfiguration != null)
            {
                if (InferenceConfiguration != null)
                {
                    writer.WritePropertyName("inferenceConfiguration"u8);
                    writer.WriteObjectValue(InferenceConfiguration);
                }
                else
                {
                    writer.WriteNull("inferenceConfiguration");
                }
            }
            writer.WritePropertyName("serverType"u8);
            writer.WriteStringValue(ServerType.ToString());
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

        CustomInferencingServer IJsonModel<CustomInferencingServer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomInferencingServer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomInferencingServer)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomInferencingServer(document.RootElement, options);
        }

        internal static CustomInferencingServer DeserializeCustomInferencingServer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<OnlineInferenceConfiguration> inferenceConfiguration = default;
            InferencingServerType serverType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inferenceConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        inferenceConfiguration = null;
                        continue;
                    }
                    inferenceConfiguration = OnlineInferenceConfiguration.DeserializeOnlineInferenceConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("serverType"u8))
                {
                    serverType = new InferencingServerType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CustomInferencingServer(serverType, serializedAdditionalRawData, inferenceConfiguration.Value);
        }

        BinaryData IPersistableModel<CustomInferencingServer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomInferencingServer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CustomInferencingServer)} does not support '{options.Format}' format.");
            }
        }

        CustomInferencingServer IPersistableModel<CustomInferencingServer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomInferencingServer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCustomInferencingServer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomInferencingServer)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomInferencingServer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
