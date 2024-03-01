// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ProviderResourceType : IUtf8JsonSerializable, IJsonModel<ProviderResourceType>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProviderResourceType>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProviderResourceType>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProviderResourceType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProviderResourceType)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (RoutingType.HasValue)
            {
                writer.WritePropertyName("routingType"u8);
                writer.WriteStringValue(RoutingType.Value.ToString());
            }
            if (ResourceValidation.HasValue)
            {
                writer.WritePropertyName("resourceValidation"u8);
                writer.WriteStringValue(ResourceValidation.Value.ToString());
            }
            if (!(AllowedUnauthorizedActions is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("allowedUnauthorizedActions"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedUnauthorizedActions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(AuthorizationActionMappings is ChangeTrackingList<AuthorizationActionMapping> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("authorizationActionMappings"u8);
                writer.WriteStartArray();
                foreach (var item in AuthorizationActionMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(LinkedAccessChecks is ChangeTrackingList<LinkedAccessCheck> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("linkedAccessChecks"u8);
                writer.WriteStartArray();
                foreach (var item in LinkedAccessChecks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (DefaultApiVersion != null)
            {
                writer.WritePropertyName("defaultApiVersion"u8);
                writer.WriteStringValue(DefaultApiVersion);
            }
            if (!(LoggingRules is ChangeTrackingList<LoggingRule> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("loggingRules"u8);
                writer.WriteStartArray();
                foreach (var item in LoggingRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ThrottlingRules is ChangeTrackingList<ThrottlingRule> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("throttlingRules"u8);
                writer.WriteStartArray();
                foreach (var item in ThrottlingRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Endpoints is ChangeTrackingList<ResourceProviderEndpoint> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("endpoints"u8);
                writer.WriteStartArray();
                foreach (var item in Endpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (MarketplaceType.HasValue)
            {
                writer.WritePropertyName("marketplaceType"u8);
                writer.WriteStringValue(MarketplaceType.Value.ToSerialString());
            }
            if (IdentityManagement != null)
            {
                writer.WritePropertyName("identityManagement"u8);
                writer.WriteObjectValue(IdentityManagement);
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
            if (!(RequiredFeatures is ChangeTrackingList<string> collection5 && collection5.IsUndefined))
            {
                writer.WritePropertyName("requiredFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredFeatures)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (FeaturesRule != null)
            {
                writer.WritePropertyName("featuresRule"u8);
                writer.WriteObjectValue(FeaturesRule);
            }
            if (!(SubscriptionStateRules is ChangeTrackingList<ProviderSubscriptionStateRule> collection6 && collection6.IsUndefined))
            {
                writer.WritePropertyName("subscriptionStateRules"u8);
                writer.WriteStartArray();
                foreach (var item in SubscriptionStateRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ServiceTreeInfos is ChangeTrackingList<ServiceTreeInfo> collection7 && collection7.IsUndefined))
            {
                writer.WritePropertyName("serviceTreeInfos"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceTreeInfos)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (RequestHeaderOptions != null)
            {
                writer.WritePropertyName("requestHeaderOptions"u8);
                writer.WriteObjectValue(RequestHeaderOptions);
            }
            if (SkuLink != null)
            {
                writer.WritePropertyName("skuLink"u8);
                writer.WriteStringValue(SkuLink);
            }
            if (!(DisallowedActionVerbs is ChangeTrackingList<string> collection8 && collection8.IsUndefined))
            {
                writer.WritePropertyName("disallowedActionVerbs"u8);
                writer.WriteStartArray();
                foreach (var item in DisallowedActionVerbs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (TemplateDeploymentPolicy != null)
            {
                writer.WritePropertyName("templateDeploymentPolicy"u8);
                writer.WriteObjectValue(TemplateDeploymentPolicy);
            }
            if (!(ExtendedLocations is ChangeTrackingList<ProviderHubExtendedLocationOptions> collection9 && collection9.IsUndefined))
            {
                writer.WritePropertyName("extendedLocations"u8);
                writer.WriteStartArray();
                foreach (var item in ExtendedLocations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(LinkedOperationRules is ChangeTrackingList<LinkedOperationRule> collection10 && collection10.IsUndefined))
            {
                writer.WritePropertyName("linkedOperationRules"u8);
                writer.WriteStartArray();
                foreach (var item in LinkedOperationRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ResourceDeletionPolicy.HasValue)
            {
                writer.WritePropertyName("resourceDeletionPolicy"u8);
                writer.WriteStringValue(ResourceDeletionPolicy.Value.ToString());
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

        ProviderResourceType IJsonModel<ProviderResourceType>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProviderResourceType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProviderResourceType)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProviderResourceType(document.RootElement, options);
        }

        internal static ProviderResourceType DeserializeProviderResourceType(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<ResourceRoutingType> routingType = default;
            Optional<ResourceValidation> resourceValidation = default;
            IReadOnlyList<string> allowedUnauthorizedActions = default;
            IReadOnlyList<AuthorizationActionMapping> authorizationActionMappings = default;
            IReadOnlyList<LinkedAccessCheck> linkedAccessChecks = default;
            Optional<string> defaultApiVersion = default;
            IReadOnlyList<LoggingRule> loggingRules = default;
            IReadOnlyList<ThrottlingRule> throttlingRules = default;
            IReadOnlyList<ResourceProviderEndpoint> endpoints = default;
            Optional<MarketplaceType> marketplaceType = default;
            Optional<IdentityManagement> identityManagement = default;
            Optional<BinaryData> metadata = default;
            IReadOnlyList<string> requiredFeatures = default;
            Optional<FeaturesRule> featuresRule = default;
            IReadOnlyList<ProviderSubscriptionStateRule> subscriptionStateRules = default;
            IReadOnlyList<ServiceTreeInfo> serviceTreeInfos = default;
            Optional<RequestHeaderOptions> requestHeaderOptions = default;
            Optional<string> skuLink = default;
            IReadOnlyList<string> disallowedActionVerbs = default;
            Optional<TemplateDeploymentPolicy> templateDeploymentPolicy = default;
            IReadOnlyList<ProviderHubExtendedLocationOptions> extendedLocations = default;
            IReadOnlyList<LinkedOperationRule> linkedOperationRules = default;
            Optional<ManifestResourceDeletionPolicy> resourceDeletionPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("routingType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routingType = new ResourceRoutingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceValidation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceValidation = new ResourceValidation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowedUnauthorizedActions"u8))
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
                    allowedUnauthorizedActions = array;
                    continue;
                }
                if (property.NameEquals("authorizationActionMappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AuthorizationActionMapping> array = new List<AuthorizationActionMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AuthorizationActionMapping.DeserializeAuthorizationActionMapping(item, options));
                    }
                    authorizationActionMappings = array;
                    continue;
                }
                if (property.NameEquals("linkedAccessChecks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LinkedAccessCheck> array = new List<LinkedAccessCheck>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkedAccessCheck.DeserializeLinkedAccessCheck(item, options));
                    }
                    linkedAccessChecks = array;
                    continue;
                }
                if (property.NameEquals("defaultApiVersion"u8))
                {
                    defaultApiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loggingRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LoggingRule> array = new List<LoggingRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoggingRule.DeserializeLoggingRule(item, options));
                    }
                    loggingRules = array;
                    continue;
                }
                if (property.NameEquals("throttlingRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ThrottlingRule> array = new List<ThrottlingRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ThrottlingRule.DeserializeThrottlingRule(item, options));
                    }
                    throttlingRules = array;
                    continue;
                }
                if (property.NameEquals("endpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceProviderEndpoint> array = new List<ResourceProviderEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceProviderEndpoint.DeserializeResourceProviderEndpoint(item, options));
                    }
                    endpoints = array;
                    continue;
                }
                if (property.NameEquals("marketplaceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    marketplaceType = property.Value.GetString().ToMarketplaceType();
                    continue;
                }
                if (property.NameEquals("identityManagement"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityManagement = IdentityManagement.DeserializeIdentityManagement(property.Value, options);
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
                if (property.NameEquals("requiredFeatures"u8))
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
                    requiredFeatures = array;
                    continue;
                }
                if (property.NameEquals("featuresRule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    featuresRule = FeaturesRule.DeserializeFeaturesRule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("subscriptionStateRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProviderSubscriptionStateRule> array = new List<ProviderSubscriptionStateRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderSubscriptionStateRule.DeserializeProviderSubscriptionStateRule(item, options));
                    }
                    subscriptionStateRules = array;
                    continue;
                }
                if (property.NameEquals("serviceTreeInfos"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceTreeInfo> array = new List<ServiceTreeInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceTreeInfo.DeserializeServiceTreeInfo(item, options));
                    }
                    serviceTreeInfos = array;
                    continue;
                }
                if (property.NameEquals("requestHeaderOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestHeaderOptions = RequestHeaderOptions.DeserializeRequestHeaderOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("skuLink"u8))
                {
                    skuLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disallowedActionVerbs"u8))
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
                    disallowedActionVerbs = array;
                    continue;
                }
                if (property.NameEquals("templateDeploymentPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    templateDeploymentPolicy = TemplateDeploymentPolicy.DeserializeTemplateDeploymentPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("extendedLocations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProviderHubExtendedLocationOptions> array = new List<ProviderHubExtendedLocationOptions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderHubExtendedLocationOptions.DeserializeProviderHubExtendedLocationOptions(item, options));
                    }
                    extendedLocations = array;
                    continue;
                }
                if (property.NameEquals("linkedOperationRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LinkedOperationRule> array = new List<LinkedOperationRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkedOperationRule.DeserializeLinkedOperationRule(item, options));
                    }
                    linkedOperationRules = array;
                    continue;
                }
                if (property.NameEquals("resourceDeletionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceDeletionPolicy = new ManifestResourceDeletionPolicy(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProviderResourceType(
                name.Value,
                Optional.ToNullable(routingType),
                Optional.ToNullable(resourceValidation),
                allowedUnauthorizedActions ?? new ChangeTrackingList<string>(),
                authorizationActionMappings ?? new ChangeTrackingList<AuthorizationActionMapping>(),
                linkedAccessChecks ?? new ChangeTrackingList<LinkedAccessCheck>(),
                defaultApiVersion.Value,
                loggingRules ?? new ChangeTrackingList<LoggingRule>(),
                throttlingRules ?? new ChangeTrackingList<ThrottlingRule>(),
                endpoints ?? new ChangeTrackingList<ResourceProviderEndpoint>(),
                Optional.ToNullable(marketplaceType),
                identityManagement.Value,
                metadata.Value,
                requiredFeatures ?? new ChangeTrackingList<string>(),
                featuresRule.Value,
                subscriptionStateRules ?? new ChangeTrackingList<ProviderSubscriptionStateRule>(),
                serviceTreeInfos ?? new ChangeTrackingList<ServiceTreeInfo>(),
                requestHeaderOptions.Value,
                skuLink.Value,
                disallowedActionVerbs ?? new ChangeTrackingList<string>(),
                templateDeploymentPolicy.Value,
                extendedLocations ?? new ChangeTrackingList<ProviderHubExtendedLocationOptions>(),
                linkedOperationRules ?? new ChangeTrackingList<LinkedOperationRule>(),
                Optional.ToNullable(resourceDeletionPolicy),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProviderResourceType>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProviderResourceType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProviderResourceType)} does not support '{options.Format}' format.");
            }
        }

        ProviderResourceType IPersistableModel<ProviderResourceType>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProviderResourceType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProviderResourceType(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProviderResourceType)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProviderResourceType>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
