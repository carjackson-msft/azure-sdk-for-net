// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult : IUtf8JsonSerializable, IJsonModel<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && !(DelegatedSubnetsUsage is ChangeTrackingList<PostgreSqlFlexibleServerDelegatedSubnetUsage> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("delegatedSubnetsUsage"u8);
                writer.WriteStartArray();
                foreach (var item in DelegatedSubnetsUsage)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Location.HasValue)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (options.Format != "W" && SubscriptionId != null)
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
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

        PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult IJsonModel<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult(document.RootElement, options);
        }

        internal static PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult DeserializePostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<PostgreSqlFlexibleServerDelegatedSubnetUsage> delegatedSubnetsUsage = default;
            Optional<AzureLocation> location = default;
            Optional<string> subscriptionId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("delegatedSubnetsUsage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlFlexibleServerDelegatedSubnetUsage> array = new List<PostgreSqlFlexibleServerDelegatedSubnetUsage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlFlexibleServerDelegatedSubnetUsage.DeserializePostgreSqlFlexibleServerDelegatedSubnetUsage(item, options));
                    }
                    delegatedSubnetsUsage = array;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult(delegatedSubnetsUsage ?? new ChangeTrackingList<PostgreSqlFlexibleServerDelegatedSubnetUsage>(), Optional.ToNullable(location), subscriptionId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult)} does not support '{options.Format}' format.");
            }
        }

        PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult IPersistableModel<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
