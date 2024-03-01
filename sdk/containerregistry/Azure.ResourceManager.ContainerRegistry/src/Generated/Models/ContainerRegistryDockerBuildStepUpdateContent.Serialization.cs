// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryDockerBuildStepUpdateContent : IUtf8JsonSerializable, IJsonModel<ContainerRegistryDockerBuildStepUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryDockerBuildStepUpdateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerRegistryDockerBuildStepUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryDockerBuildStepUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryDockerBuildStepUpdateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(ImageNames is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("imageNames"u8);
                writer.WriteStartArray();
                foreach (var item in ImageNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (IsPushEnabled.HasValue)
            {
                writer.WritePropertyName("isPushEnabled"u8);
                writer.WriteBooleanValue(IsPushEnabled.Value);
            }
            if (NoCache.HasValue)
            {
                writer.WritePropertyName("noCache"u8);
                writer.WriteBooleanValue(NoCache.Value);
            }
            if (DockerFilePath != null)
            {
                writer.WritePropertyName("dockerFilePath"u8);
                writer.WriteStringValue(DockerFilePath);
            }
            if (!(Arguments is ChangeTrackingList<ContainerRegistryRunArgument> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("arguments"u8);
                writer.WriteStartArray();
                foreach (var item in Arguments)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Target != null)
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(StepType.ToString());
            if (ContextPath != null)
            {
                writer.WritePropertyName("contextPath"u8);
                writer.WriteStringValue(ContextPath);
            }
            if (ContextAccessToken != null)
            {
                writer.WritePropertyName("contextAccessToken"u8);
                writer.WriteStringValue(ContextAccessToken);
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

        ContainerRegistryDockerBuildStepUpdateContent IJsonModel<ContainerRegistryDockerBuildStepUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryDockerBuildStepUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryDockerBuildStepUpdateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryDockerBuildStepUpdateContent(document.RootElement, options);
        }

        internal static ContainerRegistryDockerBuildStepUpdateContent DeserializeContainerRegistryDockerBuildStepUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> imageNames = default;
            Optional<bool> isPushEnabled = default;
            Optional<bool> noCache = default;
            Optional<string> dockerFilePath = default;
            IList<ContainerRegistryRunArgument> arguments = default;
            Optional<string> target = default;
            ContainerRegistryTaskStepType type = default;
            Optional<string> contextPath = default;
            Optional<string> contextAccessToken = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    imageNames = array;
                    continue;
                }
                if (property.NameEquals("isPushEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPushEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("noCache"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    noCache = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dockerFilePath"u8))
                {
                    dockerFilePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("arguments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistryRunArgument> array = new List<ContainerRegistryRunArgument>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryRunArgument.DeserializeContainerRegistryRunArgument(item, options));
                    }
                    arguments = array;
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ContainerRegistryTaskStepType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("contextPath"u8))
                {
                    contextPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contextAccessToken"u8))
                {
                    contextAccessToken = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistryDockerBuildStepUpdateContent(
                type,
                contextPath.Value,
                contextAccessToken.Value,
                serializedAdditionalRawData,
                imageNames ?? new ChangeTrackingList<string>(),
                Optional.ToNullable(isPushEnabled),
                Optional.ToNullable(noCache),
                dockerFilePath.Value,
                arguments ?? new ChangeTrackingList<ContainerRegistryRunArgument>(),
                target.Value);
        }

        BinaryData IPersistableModel<ContainerRegistryDockerBuildStepUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryDockerBuildStepUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryDockerBuildStepUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        ContainerRegistryDockerBuildStepUpdateContent IPersistableModel<ContainerRegistryDockerBuildStepUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryDockerBuildStepUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistryDockerBuildStepUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryDockerBuildStepUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryDockerBuildStepUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
