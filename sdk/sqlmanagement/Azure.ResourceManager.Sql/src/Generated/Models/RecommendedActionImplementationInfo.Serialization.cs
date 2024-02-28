// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class RecommendedActionImplementationInfo : IUtf8JsonSerializable, IJsonModel<RecommendedActionImplementationInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecommendedActionImplementationInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecommendedActionImplementationInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecommendedActionImplementationInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecommendedActionImplementationInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Method.HasValue)
            {
                writer.WritePropertyName("method"u8);
                writer.WriteStringValue(Method.Value.ToSerialString());
            }
            if (options.Format != "W" && Script != null)
            {
                writer.WritePropertyName("script"u8);
                writer.WriteStringValue(Script);
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

        RecommendedActionImplementationInfo IJsonModel<RecommendedActionImplementationInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecommendedActionImplementationInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecommendedActionImplementationInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecommendedActionImplementationInfo(document.RootElement, options);
        }

        internal static RecommendedActionImplementationInfo DeserializeRecommendedActionImplementationInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ImplementationMethod> method = default;
            Optional<string> script = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("method"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    method = property.Value.GetString().ToImplementationMethod();
                    continue;
                }
                if (property.NameEquals("script"u8))
                {
                    script = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RecommendedActionImplementationInfo(Optional.ToNullable(method), script.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RecommendedActionImplementationInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecommendedActionImplementationInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecommendedActionImplementationInfo)} does not support '{options.Format}' format.");
            }
        }

        RecommendedActionImplementationInfo IPersistableModel<RecommendedActionImplementationInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecommendedActionImplementationInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecommendedActionImplementationInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecommendedActionImplementationInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecommendedActionImplementationInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
