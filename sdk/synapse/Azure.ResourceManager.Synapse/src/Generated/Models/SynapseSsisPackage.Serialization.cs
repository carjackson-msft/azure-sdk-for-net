// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseSsisPackage : IUtf8JsonSerializable, IJsonModel<SynapseSsisPackage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseSsisPackage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseSsisPackage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSsisPackage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSsisPackage)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (FolderId.HasValue)
            {
                writer.WritePropertyName("folderId"u8);
                writer.WriteNumberValue(FolderId.Value);
            }
            if (ProjectVersion.HasValue)
            {
                writer.WritePropertyName("projectVersion"u8);
                writer.WriteNumberValue(ProjectVersion.Value);
            }
            if (ProjectId.HasValue)
            {
                writer.WritePropertyName("projectId"u8);
                writer.WriteNumberValue(ProjectId.Value);
            }
            if (!(Parameters is ChangeTrackingList<SynapseSsisParameter> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartArray();
                foreach (var item in Parameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(MetadataType.ToString());
            if (Id.HasValue)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteNumberValue(Id.Value);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        SynapseSsisPackage IJsonModel<SynapseSsisPackage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSsisPackage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSsisPackage)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseSsisPackage(document.RootElement, options);
        }

        internal static SynapseSsisPackage DeserializeSynapseSsisPackage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> folderId = default;
            Optional<long> projectVersion = default;
            Optional<long> projectId = default;
            IReadOnlyList<SynapseSsisParameter> parameters = default;
            SynapseSsisObjectMetadataType type = default;
            Optional<long> id = default;
            Optional<string> name = default;
            Optional<string> description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("folderId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    folderId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("projectVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    projectVersion = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("projectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    projectId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseSsisParameter> array = new List<SynapseSsisParameter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseSsisParameter.DeserializeSynapseSsisParameter(item, options));
                    }
                    parameters = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new SynapseSsisObjectMetadataType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseSsisPackage(
                type,
                Optional.ToNullable(id),
                name.Value,
                description.Value,
                serializedAdditionalRawData,
                Optional.ToNullable(folderId),
                Optional.ToNullable(projectVersion),
                Optional.ToNullable(projectId),
                parameters ?? new ChangeTrackingList<SynapseSsisParameter>());
        }

        BinaryData IPersistableModel<SynapseSsisPackage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSsisPackage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseSsisPackage)} does not support '{options.Format}' format.");
            }
        }

        SynapseSsisPackage IPersistableModel<SynapseSsisPackage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSsisPackage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseSsisPackage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseSsisPackage)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseSsisPackage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
