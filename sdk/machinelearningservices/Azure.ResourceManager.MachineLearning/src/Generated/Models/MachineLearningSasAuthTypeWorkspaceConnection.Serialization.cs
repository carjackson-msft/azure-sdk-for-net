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
    public partial class MachineLearningSasAuthTypeWorkspaceConnection : IUtf8JsonSerializable, IJsonModel<MachineLearningSasAuthTypeWorkspaceConnection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningSasAuthTypeWorkspaceConnection>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningSasAuthTypeWorkspaceConnection>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSasAuthTypeWorkspaceConnection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningSasAuthTypeWorkspaceConnection)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Credentials != null)
            {
                writer.WritePropertyName("credentials"u8);
                writer.WriteObjectValue(Credentials);
            }
            writer.WritePropertyName("authType"u8);
            writer.WriteStringValue(AuthType.ToString());
            if (Category.HasValue)
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (ExpiryOn.HasValue)
            {
                writer.WritePropertyName("expiryTime"u8);
                writer.WriteStringValue(ExpiryOn.Value, "O");
            }
            if (Metadata != null)
            {
                writer.WritePropertyName("metadata"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                using (JsonDocument document = JsonDocument.Parse(Metadata))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Target != null)
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
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

        MachineLearningSasAuthTypeWorkspaceConnection IJsonModel<MachineLearningSasAuthTypeWorkspaceConnection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSasAuthTypeWorkspaceConnection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningSasAuthTypeWorkspaceConnection)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningSasAuthTypeWorkspaceConnection(document.RootElement, options);
        }

        internal static MachineLearningSasAuthTypeWorkspaceConnection DeserializeMachineLearningSasAuthTypeWorkspaceConnection(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<WorkspaceConnectionSharedAccessSignature> credentials = default;
            MachineLearningConnectionAuthType authType = default;
            Optional<MachineLearningConnectionCategory> category = default;
            Optional<DateTimeOffset> expiryTime = default;
            Optional<BinaryData> metadata = default;
            Optional<string> target = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("credentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credentials = WorkspaceConnectionSharedAccessSignature.DeserializeWorkspaceConnectionSharedAccessSignature(property.Value, options);
                    continue;
                }
                if (property.NameEquals("authType"u8))
                {
                    authType = new MachineLearningConnectionAuthType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    category = new MachineLearningConnectionCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expiryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningSasAuthTypeWorkspaceConnection(
                authType,
                Optional.ToNullable(category),
                Optional.ToNullable(expiryTime),
                metadata.Value,
                target.Value,
                serializedAdditionalRawData,
                credentials.Value);
        }

        BinaryData IPersistableModel<MachineLearningSasAuthTypeWorkspaceConnection>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSasAuthTypeWorkspaceConnection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningSasAuthTypeWorkspaceConnection)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningSasAuthTypeWorkspaceConnection IPersistableModel<MachineLearningSasAuthTypeWorkspaceConnection>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSasAuthTypeWorkspaceConnection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningSasAuthTypeWorkspaceConnection(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningSasAuthTypeWorkspaceConnection)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningSasAuthTypeWorkspaceConnection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
