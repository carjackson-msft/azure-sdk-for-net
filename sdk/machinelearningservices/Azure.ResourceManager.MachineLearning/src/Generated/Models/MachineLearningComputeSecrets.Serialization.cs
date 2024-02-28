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
    [PersistableModelProxy(typeof(UnknownComputeSecrets))]
    public partial class MachineLearningComputeSecrets : IUtf8JsonSerializable, IJsonModel<MachineLearningComputeSecrets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningComputeSecrets>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningComputeSecrets>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningComputeSecrets)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("computeType"u8);
            writer.WriteStringValue(ComputeType.ToString());
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

        MachineLearningComputeSecrets IJsonModel<MachineLearningComputeSecrets>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningComputeSecrets)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningComputeSecrets(document.RootElement, options);
        }

        internal static MachineLearningComputeSecrets DeserializeMachineLearningComputeSecrets(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("computeType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AKS": return MachineLearningAksComputeSecrets.DeserializeMachineLearningAksComputeSecrets(element, options);
                    case "Databricks": return MachineLearningDatabricksComputeSecrets.DeserializeMachineLearningDatabricksComputeSecrets(element, options);
                    case "VirtualMachine": return MachineLearningVirtualMachineSecrets.DeserializeMachineLearningVirtualMachineSecrets(element, options);
                }
            }
            return UnknownComputeSecrets.DeserializeUnknownComputeSecrets(element, options);
        }

        BinaryData IPersistableModel<MachineLearningComputeSecrets>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningComputeSecrets)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningComputeSecrets IPersistableModel<MachineLearningComputeSecrets>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningComputeSecrets(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningComputeSecrets)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningComputeSecrets>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
