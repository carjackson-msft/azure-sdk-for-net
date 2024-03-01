// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownOneLakeArtifact))]
    public partial class OneLakeArtifact : IUtf8JsonSerializable, IJsonModel<OneLakeArtifact>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OneLakeArtifact>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OneLakeArtifact>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OneLakeArtifact>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OneLakeArtifact)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("artifactName"u8);
            writer.WriteStringValue(ArtifactName);
            writer.WritePropertyName("artifactType"u8);
            writer.WriteStringValue(ArtifactType.ToString());
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

        OneLakeArtifact IJsonModel<OneLakeArtifact>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OneLakeArtifact>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OneLakeArtifact)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOneLakeArtifact(document.RootElement, options);
        }

        internal static OneLakeArtifact DeserializeOneLakeArtifact(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("artifactType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "LakeHouse": return LakeHouseArtifact.DeserializeLakeHouseArtifact(element, options);
                }
            }
            return UnknownOneLakeArtifact.DeserializeUnknownOneLakeArtifact(element, options);
        }

        BinaryData IPersistableModel<OneLakeArtifact>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OneLakeArtifact>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OneLakeArtifact)} does not support '{options.Format}' format.");
            }
        }

        OneLakeArtifact IPersistableModel<OneLakeArtifact>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OneLakeArtifact>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOneLakeArtifact(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OneLakeArtifact)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OneLakeArtifact>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
