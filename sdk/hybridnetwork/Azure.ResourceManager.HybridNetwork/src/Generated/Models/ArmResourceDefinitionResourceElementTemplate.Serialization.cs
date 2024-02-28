// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class ArmResourceDefinitionResourceElementTemplate : IUtf8JsonSerializable, IJsonModel<ArmResourceDefinitionResourceElementTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArmResourceDefinitionResourceElementTemplate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ArmResourceDefinitionResourceElementTemplate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmResourceDefinitionResourceElementTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmResourceDefinitionResourceElementTemplate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (TemplateType.HasValue)
            {
                writer.WritePropertyName("templateType"u8);
                writer.WriteStringValue(TemplateType.Value.ToString());
            }
            if (ParameterValues != null)
            {
                writer.WritePropertyName("parameterValues"u8);
                writer.WriteStringValue(ParameterValues);
            }
            if (ArtifactProfile != null)
            {
                writer.WritePropertyName("artifactProfile"u8);
                writer.WriteObjectValue(ArtifactProfile);
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

        ArmResourceDefinitionResourceElementTemplate IJsonModel<ArmResourceDefinitionResourceElementTemplate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmResourceDefinitionResourceElementTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmResourceDefinitionResourceElementTemplate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArmResourceDefinitionResourceElementTemplate(document.RootElement, options);
        }

        internal static ArmResourceDefinitionResourceElementTemplate DeserializeArmResourceDefinitionResourceElementTemplate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TemplateType> templateType = default;
            Optional<string> parameterValues = default;
            Optional<NSDArtifactProfile> artifactProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("templateType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    templateType = new TemplateType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("parameterValues"u8))
                {
                    parameterValues = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    artifactProfile = NSDArtifactProfile.DeserializeNSDArtifactProfile(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ArmResourceDefinitionResourceElementTemplate(Optional.ToNullable(templateType), parameterValues.Value, artifactProfile.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ArmResourceDefinitionResourceElementTemplate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmResourceDefinitionResourceElementTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ArmResourceDefinitionResourceElementTemplate)} does not support '{options.Format}' format.");
            }
        }

        ArmResourceDefinitionResourceElementTemplate IPersistableModel<ArmResourceDefinitionResourceElementTemplate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmResourceDefinitionResourceElementTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeArmResourceDefinitionResourceElementTemplate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArmResourceDefinitionResourceElementTemplate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArmResourceDefinitionResourceElementTemplate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
