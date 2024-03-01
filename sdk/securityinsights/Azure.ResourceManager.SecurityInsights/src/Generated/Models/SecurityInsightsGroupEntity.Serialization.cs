// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsGroupEntity : IUtf8JsonSerializable, IJsonModel<SecurityInsightsGroupEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsGroupEntity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsGroupEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsGroupEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsGroupEntity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && !(AdditionalData is ChangeTrackingDictionary<string, BinaryData> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("additionalData"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalData)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
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
            if (options.Format != "W" && FriendlyName != null)
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (options.Format != "W" && DistinguishedName != null)
            {
                writer.WritePropertyName("distinguishedName"u8);
                writer.WriteStringValue(DistinguishedName);
            }
            if (options.Format != "W" && ObjectGuid.HasValue)
            {
                writer.WritePropertyName("objectGuid"u8);
                writer.WriteStringValue(ObjectGuid.Value);
            }
            if (options.Format != "W" && Sid != null)
            {
                writer.WritePropertyName("sid"u8);
                writer.WriteStringValue(Sid);
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

        SecurityInsightsGroupEntity IJsonModel<SecurityInsightsGroupEntity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsGroupEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsGroupEntity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsGroupEntity(document.RootElement, options);
        }

        internal static SecurityInsightsGroupEntity DeserializeSecurityInsightsGroupEntity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SecurityInsightsEntityKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            IReadOnlyDictionary<string, BinaryData> additionalData = default;
            Optional<string> friendlyName = default;
            Optional<string> distinguishedName = default;
            Optional<Guid> objectGuid = default;
            Optional<string> sid = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new SecurityInsightsEntityKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("additionalData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            additionalData = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("distinguishedName"u8))
                        {
                            distinguishedName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("objectGuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            objectGuid = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("sid"u8))
                        {
                            sid = property0.Value.GetString();
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
            return new SecurityInsightsGroupEntity(
                id,
                name,
                type,
                systemData.Value,
                kind,
                serializedAdditionalRawData,
                additionalData ?? new ChangeTrackingDictionary<string, BinaryData>(),
                friendlyName.Value,
                distinguishedName.Value,
                Optional.ToNullable(objectGuid),
                sid.Value);
        }

        BinaryData IPersistableModel<SecurityInsightsGroupEntity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsGroupEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsGroupEntity)} does not support '{options.Format}' format.");
            }
        }

        SecurityInsightsGroupEntity IPersistableModel<SecurityInsightsGroupEntity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsGroupEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsGroupEntity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsGroupEntity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsGroupEntity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
