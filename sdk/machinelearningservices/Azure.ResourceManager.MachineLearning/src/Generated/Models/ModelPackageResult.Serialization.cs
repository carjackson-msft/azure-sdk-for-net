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
    public partial class ModelPackageResult : IUtf8JsonSerializable, IJsonModel<ModelPackageResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ModelPackageResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ModelPackageResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelPackageResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ModelPackageResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && BaseEnvironmentSource != null)
            {
                if (BaseEnvironmentSource != null)
                {
                    writer.WritePropertyName("baseEnvironmentSource"u8);
                    writer.WriteObjectValue(BaseEnvironmentSource);
                }
                else
                {
                    writer.WriteNull("baseEnvironmentSource");
                }
            }
            if (options.Format != "W" && BuildId != null)
            {
                if (BuildId != null)
                {
                    writer.WritePropertyName("buildId"u8);
                    writer.WriteStringValue(BuildId);
                }
                else
                {
                    writer.WriteNull("buildId");
                }
            }
            if (options.Format != "W" && BuildState.HasValue)
            {
                writer.WritePropertyName("buildState"u8);
                writer.WriteStringValue(BuildState.Value.ToString());
            }
            if (options.Format != "W" && !(EnvironmentVariables is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                if (EnvironmentVariables != null)
                {
                    writer.WritePropertyName("environmentVariables"u8);
                    writer.WriteStartObject();
                    foreach (var item in EnvironmentVariables)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("environmentVariables");
                }
            }
            if (options.Format != "W" && InferencingServer != null)
            {
                if (InferencingServer != null)
                {
                    writer.WritePropertyName("inferencingServer"u8);
                    writer.WriteObjectValue(InferencingServer);
                }
                else
                {
                    writer.WriteNull("inferencingServer");
                }
            }
            if (options.Format != "W" && !(Inputs is ChangeTrackingList<ModelPackageInput> collection0 && collection0.IsUndefined))
            {
                if (Inputs != null)
                {
                    writer.WritePropertyName("inputs"u8);
                    writer.WriteStartArray();
                    foreach (var item in Inputs)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("inputs");
                }
            }
            if (options.Format != "W" && LogUri != null)
            {
                if (LogUri != null)
                {
                    writer.WritePropertyName("logUrl"u8);
                    writer.WriteStringValue(LogUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("logUrl");
                }
            }
            if (options.Format != "W" && ModelConfiguration != null)
            {
                if (ModelConfiguration != null)
                {
                    writer.WritePropertyName("modelConfiguration"u8);
                    writer.WriteObjectValue(ModelConfiguration);
                }
                else
                {
                    writer.WriteNull("modelConfiguration");
                }
            }
            if (options.Format != "W" && !(Tags is ChangeTrackingDictionary<string, string> collection1 && collection1.IsUndefined))
            {
                if (Tags != null)
                {
                    writer.WritePropertyName("tags"u8);
                    writer.WriteStartObject();
                    foreach (var item in Tags)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("tags");
                }
            }
            if (options.Format != "W" && TargetEnvironmentId != null)
            {
                if (TargetEnvironmentId != null)
                {
                    writer.WritePropertyName("targetEnvironmentId"u8);
                    writer.WriteStringValue(TargetEnvironmentId);
                }
                else
                {
                    writer.WriteNull("targetEnvironmentId");
                }
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

        ModelPackageResult IJsonModel<ModelPackageResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelPackageResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ModelPackageResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeModelPackageResult(document.RootElement, options);
        }

        internal static ModelPackageResult DeserializeModelPackageResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BaseEnvironmentSource> baseEnvironmentSource = default;
            Optional<string> buildId = default;
            Optional<PackageBuildState> buildState = default;
            IReadOnlyDictionary<string, string> environmentVariables = default;
            Optional<InferencingServer> inferencingServer = default;
            IReadOnlyList<ModelPackageInput> inputs = default;
            Optional<Uri> logUrl = default;
            Optional<ModelConfiguration> modelConfiguration = default;
            IReadOnlyDictionary<string, string> tags = default;
            Optional<string> targetEnvironmentId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("baseEnvironmentSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        baseEnvironmentSource = null;
                        continue;
                    }
                    baseEnvironmentSource = BaseEnvironmentSource.DeserializeBaseEnvironmentSource(property.Value, options);
                    continue;
                }
                if (property.NameEquals("buildId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        buildId = null;
                        continue;
                    }
                    buildId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("buildState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    buildState = new PackageBuildState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("environmentVariables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        environmentVariables = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    environmentVariables = dictionary;
                    continue;
                }
                if (property.NameEquals("inferencingServer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        inferencingServer = null;
                        continue;
                    }
                    inferencingServer = InferencingServer.DeserializeInferencingServer(property.Value, options);
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        inputs = null;
                        continue;
                    }
                    List<ModelPackageInput> array = new List<ModelPackageInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ModelPackageInput.DeserializeModelPackageInput(item, options));
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("logUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        logUrl = null;
                        continue;
                    }
                    logUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("modelConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelConfiguration = null;
                        continue;
                    }
                    modelConfiguration = ModelConfiguration.DeserializeModelConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("targetEnvironmentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetEnvironmentId = null;
                        continue;
                    }
                    targetEnvironmentId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ModelPackageResult(
                baseEnvironmentSource.Value,
                buildId.Value,
                Optional.ToNullable(buildState),
                environmentVariables ?? new ChangeTrackingDictionary<string, string>(),
                inferencingServer.Value,
                inputs ?? new ChangeTrackingList<ModelPackageInput>(),
                logUrl.Value,
                modelConfiguration.Value,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                targetEnvironmentId.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ModelPackageResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelPackageResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ModelPackageResult)} does not support '{options.Format}' format.");
            }
        }

        ModelPackageResult IPersistableModel<ModelPackageResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelPackageResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeModelPackageResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ModelPackageResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ModelPackageResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
