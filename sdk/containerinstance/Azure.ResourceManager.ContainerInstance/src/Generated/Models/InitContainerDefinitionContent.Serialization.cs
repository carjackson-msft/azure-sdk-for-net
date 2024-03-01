// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class InitContainerDefinitionContent : IUtf8JsonSerializable, IJsonModel<InitContainerDefinitionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InitContainerDefinitionContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InitContainerDefinitionContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InitContainerDefinitionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InitContainerDefinitionContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Image != null)
            {
                writer.WritePropertyName("image"u8);
                writer.WriteStringValue(Image);
            }
            if (!(Command is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("command"u8);
                writer.WriteStartArray();
                foreach (var item in Command)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(EnvironmentVariables is ChangeTrackingList<ContainerEnvironmentVariable> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("environmentVariables"u8);
                writer.WriteStartArray();
                foreach (var item in EnvironmentVariables)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && InstanceView != null)
            {
                writer.WritePropertyName("instanceView"u8);
                writer.WriteObjectValue(InstanceView);
            }
            if (!(VolumeMounts is ChangeTrackingList<ContainerVolumeMount> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("volumeMounts"u8);
                writer.WriteStartArray();
                foreach (var item in VolumeMounts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (SecurityContext != null)
            {
                writer.WritePropertyName("securityContext"u8);
                writer.WriteObjectValue(SecurityContext);
            }
            writer.WriteEndObject();
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

        InitContainerDefinitionContent IJsonModel<InitContainerDefinitionContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InitContainerDefinitionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InitContainerDefinitionContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInitContainerDefinitionContent(document.RootElement, options);
        }

        internal static InitContainerDefinitionContent DeserializeInitContainerDefinitionContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<string> image = default;
            IList<string> command = default;
            IList<ContainerEnvironmentVariable> environmentVariables = default;
            Optional<InitContainerPropertiesDefinitionInstanceView> instanceView = default;
            IList<ContainerVolumeMount> volumeMounts = default;
            Optional<ContainerSecurityContextDefinition> securityContext = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("image"u8))
                        {
                            image = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("command"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            command = array;
                            continue;
                        }
                        if (property0.NameEquals("environmentVariables"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerEnvironmentVariable> array = new List<ContainerEnvironmentVariable>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerEnvironmentVariable.DeserializeContainerEnvironmentVariable(item, options));
                            }
                            environmentVariables = array;
                            continue;
                        }
                        if (property0.NameEquals("instanceView"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            instanceView = InitContainerPropertiesDefinitionInstanceView.DeserializeInitContainerPropertiesDefinitionInstanceView(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("volumeMounts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerVolumeMount> array = new List<ContainerVolumeMount>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerVolumeMount.DeserializeContainerVolumeMount(item, options));
                            }
                            volumeMounts = array;
                            continue;
                        }
                        if (property0.NameEquals("securityContext"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securityContext = ContainerSecurityContextDefinition.DeserializeContainerSecurityContextDefinition(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InitContainerDefinitionContent(
                name,
                image.Value,
                command ?? new ChangeTrackingList<string>(),
                environmentVariables ?? new ChangeTrackingList<ContainerEnvironmentVariable>(),
                instanceView.Value,
                volumeMounts ?? new ChangeTrackingList<ContainerVolumeMount>(),
                securityContext.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InitContainerDefinitionContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InitContainerDefinitionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InitContainerDefinitionContent)} does not support '{options.Format}' format.");
            }
        }

        InitContainerDefinitionContent IPersistableModel<InitContainerDefinitionContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InitContainerDefinitionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInitContainerDefinitionContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InitContainerDefinitionContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InitContainerDefinitionContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
