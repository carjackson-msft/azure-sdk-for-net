// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class ScriptSecureStringExecutionParameterDetails : IUtf8JsonSerializable, IJsonModel<ScriptSecureStringExecutionParameterDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScriptSecureStringExecutionParameterDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ScriptSecureStringExecutionParameterDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptSecureStringExecutionParameterDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScriptSecureStringExecutionParameterDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (SecureValue != null)
            {
                writer.WritePropertyName("secureValue"u8);
                writer.WriteStringValue(SecureValue);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ParameterType.ToString());
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

        ScriptSecureStringExecutionParameterDetails IJsonModel<ScriptSecureStringExecutionParameterDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptSecureStringExecutionParameterDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScriptSecureStringExecutionParameterDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScriptSecureStringExecutionParameterDetails(document.RootElement, options);
        }

        internal static ScriptSecureStringExecutionParameterDetails DeserializeScriptSecureStringExecutionParameterDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> secureValue = default;
            string name = default;
            ScriptExecutionParameterType type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secureValue"u8))
                {
                    secureValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ScriptExecutionParameterType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ScriptSecureStringExecutionParameterDetails(name, type, serializedAdditionalRawData, secureValue.Value);
        }

        BinaryData IPersistableModel<ScriptSecureStringExecutionParameterDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptSecureStringExecutionParameterDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScriptSecureStringExecutionParameterDetails)} does not support '{options.Format}' format.");
            }
        }

        ScriptSecureStringExecutionParameterDetails IPersistableModel<ScriptSecureStringExecutionParameterDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptSecureStringExecutionParameterDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScriptSecureStringExecutionParameterDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScriptSecureStringExecutionParameterDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScriptSecureStringExecutionParameterDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
