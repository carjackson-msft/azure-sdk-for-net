// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class RoutingRuleData : IUtf8JsonSerializable, IJsonModel<RoutingRuleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoutingRuleData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RoutingRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingRuleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoutingRuleData)} does not support '{format}' format.");
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
            if (options.Format != "W" && ResourceType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (!(FrontendEndpoints is ChangeTrackingList<WritableSubResource> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("frontendEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in FrontendEndpoints)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (!(AcceptedProtocols is ChangeTrackingList<FrontDoorProtocol> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("acceptedProtocols"u8);
                writer.WriteStartArray();
                foreach (var item in AcceptedProtocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (!(PatternsToMatch is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("patternsToMatch"u8);
                writer.WriteStartArray();
                foreach (var item in PatternsToMatch)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (EnabledState.HasValue)
            {
                writer.WritePropertyName("enabledState"u8);
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            if (RouteConfiguration != null)
            {
                writer.WritePropertyName("routeConfiguration"u8);
                writer.WriteObjectValue(RouteConfiguration);
            }
            if (RulesEngine != null)
            {
                writer.WritePropertyName("rulesEngine"u8);
                JsonSerializer.Serialize(writer, RulesEngine);
            }
            if (WebApplicationFirewallPolicyLink != null)
            {
                writer.WritePropertyName("webApplicationFirewallPolicyLink"u8);
                JsonSerializer.Serialize(writer, WebApplicationFirewallPolicyLink);
            }
            if (options.Format != "W" && ResourceState.HasValue)
            {
                writer.WritePropertyName("resourceState"u8);
                writer.WriteStringValue(ResourceState.Value.ToString());
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

        RoutingRuleData IJsonModel<RoutingRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingRuleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoutingRuleData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoutingRuleData(document.RootElement, options);
        }

        internal static RoutingRuleData DeserializeRoutingRuleData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            IList<WritableSubResource> frontendEndpoints = default;
            IList<FrontDoorProtocol> acceptedProtocols = default;
            IList<string> patternsToMatch = default;
            Optional<RoutingRuleEnabledState> enabledState = default;
            Optional<RouteConfiguration> routeConfiguration = default;
            Optional<WritableSubResource> rulesEngine = default;
            Optional<WritableSubResource> webApplicationFirewallPolicyLink = default;
            Optional<FrontDoorResourceState> resourceState = default;
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
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("frontendEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            frontendEndpoints = array;
                            continue;
                        }
                        if (property0.NameEquals("acceptedProtocols"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FrontDoorProtocol> array = new List<FrontDoorProtocol>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new FrontDoorProtocol(item.GetString()));
                            }
                            acceptedProtocols = array;
                            continue;
                        }
                        if (property0.NameEquals("patternsToMatch"u8))
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
                            patternsToMatch = array;
                            continue;
                        }
                        if (property0.NameEquals("enabledState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabledState = new RoutingRuleEnabledState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("routeConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routeConfiguration = RouteConfiguration.DeserializeRouteConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("rulesEngine"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rulesEngine = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("webApplicationFirewallPolicyLink"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            webApplicationFirewallPolicyLink = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new FrontDoorResourceState(property0.Value.GetString());
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
            return new RoutingRuleData(
                id.Value,
                name.Value,
                Optional.ToNullable(type),
                serializedAdditionalRawData,
                frontendEndpoints ?? new ChangeTrackingList<WritableSubResource>(),
                acceptedProtocols ?? new ChangeTrackingList<FrontDoorProtocol>(),
                patternsToMatch ?? new ChangeTrackingList<string>(),
                Optional.ToNullable(enabledState),
                routeConfiguration.Value,
                rulesEngine,
                webApplicationFirewallPolicyLink,
                Optional.ToNullable(resourceState));
        }

        BinaryData IPersistableModel<RoutingRuleData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingRuleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RoutingRuleData)} does not support '{options.Format}' format.");
            }
        }

        RoutingRuleData IPersistableModel<RoutingRuleData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingRuleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRoutingRuleData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoutingRuleData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoutingRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
