// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class GoogleCloudStorageLocation : IUtf8JsonSerializable, IJsonModel<GoogleCloudStorageLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GoogleCloudStorageLocation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GoogleCloudStorageLocation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GoogleCloudStorageLocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GoogleCloudStorageLocation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (BucketName != null)
            {
                writer.WritePropertyName("bucketName"u8);
                JsonSerializer.Serialize(writer, BucketName);
            }
            if (Version != null)
            {
                writer.WritePropertyName("version"u8);
                JsonSerializer.Serialize(writer, Version);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(DatasetLocationType);
            if (FolderPath != null)
            {
                writer.WritePropertyName("folderPath"u8);
                JsonSerializer.Serialize(writer, FolderPath);
            }
            if (FileName != null)
            {
                writer.WritePropertyName("fileName"u8);
                JsonSerializer.Serialize(writer, FileName);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        GoogleCloudStorageLocation IJsonModel<GoogleCloudStorageLocation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GoogleCloudStorageLocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GoogleCloudStorageLocation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGoogleCloudStorageLocation(document.RootElement, options);
        }

        internal static GoogleCloudStorageLocation DeserializeGoogleCloudStorageLocation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryElement<string>> bucketName = default;
            Optional<DataFactoryElement<string>> version = default;
            string type = default;
            Optional<DataFactoryElement<string>> folderPath = default;
            Optional<DataFactoryElement<string>> fileName = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bucketName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bucketName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("folderPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    folderPath = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("fileName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new GoogleCloudStorageLocation(
                type,
                folderPath.Value,
                fileName.Value,
                additionalProperties,
                bucketName.Value,
                version.Value);
        }

        BinaryData IPersistableModel<GoogleCloudStorageLocation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GoogleCloudStorageLocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GoogleCloudStorageLocation)} does not support '{options.Format}' format.");
            }
        }

        GoogleCloudStorageLocation IPersistableModel<GoogleCloudStorageLocation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GoogleCloudStorageLocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGoogleCloudStorageLocation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GoogleCloudStorageLocation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GoogleCloudStorageLocation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
