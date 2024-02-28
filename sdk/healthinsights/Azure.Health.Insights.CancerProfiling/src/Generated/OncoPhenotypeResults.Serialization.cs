// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Health.Insights.CancerProfiling
{
    public partial class OncoPhenotypeResults : IUtf8JsonSerializable, IJsonModel<OncoPhenotypeResults>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OncoPhenotypeResults>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OncoPhenotypeResults>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OncoPhenotypeResults>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OncoPhenotypeResults)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("patients"u8);
            writer.WriteStartArray();
            foreach (var item in Patients)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("modelVersion"u8);
            writer.WriteStringValue(ModelVersion);
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

        OncoPhenotypeResults IJsonModel<OncoPhenotypeResults>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OncoPhenotypeResults>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OncoPhenotypeResults)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOncoPhenotypeResults(document.RootElement, options);
        }

        internal static OncoPhenotypeResults DeserializeOncoPhenotypeResults(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<OncoPhenotypePatientResult> patients = default;
            string modelVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("patients"u8))
                {
                    List<OncoPhenotypePatientResult> array = new List<OncoPhenotypePatientResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OncoPhenotypePatientResult.DeserializeOncoPhenotypePatientResult(item, options));
                    }
                    patients = array;
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OncoPhenotypeResults(patients, modelVersion, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OncoPhenotypeResults>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OncoPhenotypeResults>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OncoPhenotypeResults)} does not support '{options.Format}' format.");
            }
        }

        OncoPhenotypeResults IPersistableModel<OncoPhenotypeResults>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OncoPhenotypeResults>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOncoPhenotypeResults(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OncoPhenotypeResults)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OncoPhenotypeResults>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static OncoPhenotypeResults FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeOncoPhenotypeResults(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
