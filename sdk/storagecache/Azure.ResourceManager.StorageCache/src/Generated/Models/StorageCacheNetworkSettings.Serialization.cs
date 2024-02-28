// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class StorageCacheNetworkSettings : IUtf8JsonSerializable, IJsonModel<StorageCacheNetworkSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageCacheNetworkSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageCacheNetworkSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageCacheNetworkSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Mtu.HasValue)
            {
                writer.WritePropertyName("mtu"u8);
                writer.WriteNumberValue(Mtu.Value);
            }
            if (options.Format != "W" && !(UtilityAddresses is ChangeTrackingList<IPAddress> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("utilityAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in UtilityAddresses)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (!(DnsServers is ChangeTrackingList<IPAddress> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("dnsServers"u8);
                writer.WriteStartArray();
                foreach (var item in DnsServers)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (DnsSearchDomain != null)
            {
                writer.WritePropertyName("dnsSearchDomain"u8);
                writer.WriteStringValue(DnsSearchDomain);
            }
            if (NtpServer != null)
            {
                writer.WritePropertyName("ntpServer"u8);
                writer.WriteStringValue(NtpServer);
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

        StorageCacheNetworkSettings IJsonModel<StorageCacheNetworkSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageCacheNetworkSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageCacheNetworkSettings(document.RootElement, options);
        }

        internal static StorageCacheNetworkSettings DeserializeStorageCacheNetworkSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> mtu = default;
            IReadOnlyList<IPAddress> utilityAddresses = default;
            IList<IPAddress> dnsServers = default;
            Optional<string> dnsSearchDomain = default;
            Optional<string> ntpServer = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mtu"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mtu = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("utilityAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPAddress> array = new List<IPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(IPAddress.Parse(item.GetString()));
                        }
                    }
                    utilityAddresses = array;
                    continue;
                }
                if (property.NameEquals("dnsServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPAddress> array = new List<IPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(IPAddress.Parse(item.GetString()));
                        }
                    }
                    dnsServers = array;
                    continue;
                }
                if (property.NameEquals("dnsSearchDomain"u8))
                {
                    dnsSearchDomain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ntpServer"u8))
                {
                    ntpServer = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageCacheNetworkSettings(
                Optional.ToNullable(mtu),
                utilityAddresses ?? new ChangeTrackingList<IPAddress>(),
                dnsServers ?? new ChangeTrackingList<IPAddress>(),
                dnsSearchDomain.Value,
                ntpServer.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageCacheNetworkSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageCacheNetworkSettings)} does not support '{options.Format}' format.");
            }
        }

        StorageCacheNetworkSettings IPersistableModel<StorageCacheNetworkSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageCacheNetworkSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageCacheNetworkSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageCacheNetworkSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
