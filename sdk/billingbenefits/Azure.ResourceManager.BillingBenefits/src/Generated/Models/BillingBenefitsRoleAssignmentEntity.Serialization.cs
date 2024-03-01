// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    public partial class BillingBenefitsRoleAssignmentEntity : IUtf8JsonSerializable, IJsonModel<BillingBenefitsRoleAssignmentEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingBenefitsRoleAssignmentEntity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BillingBenefitsRoleAssignmentEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsRoleAssignmentEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingBenefitsRoleAssignmentEntity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (PrincipalId != null)
            {
                writer.WritePropertyName("principalId"u8);
                writer.WriteStringValue(PrincipalId);
            }
            if (RoleDefinitionId != null)
            {
                writer.WritePropertyName("roleDefinitionId"u8);
                writer.WriteStringValue(RoleDefinitionId);
            }
            if (Scope != null)
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
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

        BillingBenefitsRoleAssignmentEntity IJsonModel<BillingBenefitsRoleAssignmentEntity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsRoleAssignmentEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingBenefitsRoleAssignmentEntity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingBenefitsRoleAssignmentEntity(document.RootElement, options);
        }

        internal static BillingBenefitsRoleAssignmentEntity DeserializeBillingBenefitsRoleAssignmentEntity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<string> principalId = default;
            Optional<ResourceIdentifier> roleDefinitionId = default;
            Optional<ResourceIdentifier> scope = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("principalId"u8))
                        {
                            principalId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("roleDefinitionId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            roleDefinitionId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("scope"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scope = new ResourceIdentifier(property0.Value.GetString());
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
            return new BillingBenefitsRoleAssignmentEntity(
                id.Value,
                name.Value,
                principalId.Value,
                roleDefinitionId.Value,
                scope.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BillingBenefitsRoleAssignmentEntity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsRoleAssignmentEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BillingBenefitsRoleAssignmentEntity)} does not support '{options.Format}' format.");
            }
        }

        BillingBenefitsRoleAssignmentEntity IPersistableModel<BillingBenefitsRoleAssignmentEntity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsRoleAssignmentEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBillingBenefitsRoleAssignmentEntity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingBenefitsRoleAssignmentEntity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingBenefitsRoleAssignmentEntity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
