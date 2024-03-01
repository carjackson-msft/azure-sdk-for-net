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
    public partial class AzureFileStorageLinkedService : IUtf8JsonSerializable, IJsonModel<AzureFileStorageLinkedService>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureFileStorageLinkedService>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureFileStorageLinkedService>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureFileStorageLinkedService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureFileStorageLinkedService)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(LinkedServiceType);
            if (ConnectVia != null)
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (!(Parameters is ChangeTrackingDictionary<string, EntityParameterSpecification> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(Annotations is ChangeTrackingList<BinaryData> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Host != null)
            {
                writer.WritePropertyName("host"u8);
                JsonSerializer.Serialize(writer, Host);
            }
            if (UserId != null)
            {
                writer.WritePropertyName("userId"u8);
                JsonSerializer.Serialize(writer, UserId);
            }
            if (Password != null)
            {
                writer.WritePropertyName("password"u8);
                JsonSerializer.Serialize(writer, Password);
            }
            if (ConnectionString != null)
            {
                writer.WritePropertyName("connectionString"u8);
                JsonSerializer.Serialize(writer, ConnectionString);
            }
            if (AccountKey != null)
            {
                writer.WritePropertyName("accountKey"u8);
                JsonSerializer.Serialize(writer, AccountKey);
            }
            if (SasUri != null)
            {
                writer.WritePropertyName("sasUri"u8);
                JsonSerializer.Serialize(writer, SasUri);
            }
            if (SasToken != null)
            {
                writer.WritePropertyName("sasToken"u8);
                JsonSerializer.Serialize(writer, SasToken);
            }
            if (FileShare != null)
            {
                writer.WritePropertyName("fileShare"u8);
                JsonSerializer.Serialize(writer, FileShare);
            }
            if (Snapshot != null)
            {
                writer.WritePropertyName("snapshot"u8);
                JsonSerializer.Serialize(writer, Snapshot);
            }
            if (EncryptedCredential != null)
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteStringValue(EncryptedCredential);
            }
            writer.WriteEndObject();
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

        AzureFileStorageLinkedService IJsonModel<AzureFileStorageLinkedService>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureFileStorageLinkedService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureFileStorageLinkedService)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureFileStorageLinkedService(document.RootElement, options);
        }

        internal static AzureFileStorageLinkedService DeserializeAzureFileStorageLinkedService(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            IDictionary<string, EntityParameterSpecification> parameters = default;
            IList<BinaryData> annotations = default;
            Optional<DataFactoryElement<string>> host = default;
            Optional<DataFactoryElement<string>> userId = default;
            Optional<DataFactorySecretBaseDefinition> password = default;
            Optional<DataFactoryElement<string>> connectionString = default;
            Optional<DataFactoryKeyVaultSecretReference> accountKey = default;
            Optional<DataFactoryElement<string>> sasUri = default;
            Optional<DataFactoryKeyVaultSecretReference> sasToken = default;
            Optional<DataFactoryElement<string>> fileShare = default;
            Optional<DataFactoryElement<string>> snapshot = default;
            Optional<string> encryptedCredential = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, EntityParameterSpecification> dictionary = new Dictionary<string, EntityParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EntityParameterSpecification.DeserializeEntityParameterSpecification(property0.Value, options));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("host"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            host = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("userId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            userId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("password"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            password = JsonSerializer.Deserialize<DataFactorySecretBaseDefinition>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("connectionString"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionString = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("accountKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accountKey = JsonSerializer.Deserialize<DataFactoryKeyVaultSecretReference>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("sasUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sasUri = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("sasToken"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sasToken = JsonSerializer.Deserialize<DataFactoryKeyVaultSecretReference>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("fileShare"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            fileShare = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("snapshot"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            snapshot = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            encryptedCredential = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureFileStorageLinkedService(
                type,
                connectVia.Value,
                description.Value,
                parameters ?? new ChangeTrackingDictionary<string, EntityParameterSpecification>(),
                annotations ?? new ChangeTrackingList<BinaryData>(),
                additionalProperties,
                host.Value,
                userId.Value,
                password,
                connectionString.Value,
                accountKey,
                sasUri.Value,
                sasToken,
                fileShare.Value,
                snapshot.Value,
                encryptedCredential.Value);
        }

        BinaryData IPersistableModel<AzureFileStorageLinkedService>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureFileStorageLinkedService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureFileStorageLinkedService)} does not support '{options.Format}' format.");
            }
        }

        AzureFileStorageLinkedService IPersistableModel<AzureFileStorageLinkedService>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureFileStorageLinkedService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureFileStorageLinkedService(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureFileStorageLinkedService)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureFileStorageLinkedService>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
