// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SignalR.Models
{
    public partial class SignalRNetworkAcl : IUtf8JsonSerializable, IJsonModel<SignalRNetworkAcl>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SignalRNetworkAcl>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SignalRNetworkAcl>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRNetworkAcl>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SignalRNetworkAcl)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Allow is ChangeTrackingList<SignalRRequestType> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("allow"u8);
                writer.WriteStartArray();
                foreach (var item in Allow)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (!(Deny is ChangeTrackingList<SignalRRequestType> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("deny"u8);
                writer.WriteStartArray();
                foreach (var item in Deny)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
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

        SignalRNetworkAcl IJsonModel<SignalRNetworkAcl>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRNetworkAcl>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SignalRNetworkAcl)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSignalRNetworkAcl(document.RootElement, options);
        }

        internal static SignalRNetworkAcl DeserializeSignalRNetworkAcl(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<SignalRRequestType> allow = default;
            IList<SignalRRequestType> deny = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SignalRRequestType> array = new List<SignalRRequestType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SignalRRequestType(item.GetString()));
                    }
                    allow = array;
                    continue;
                }
                if (property.NameEquals("deny"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SignalRRequestType> array = new List<SignalRRequestType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SignalRRequestType(item.GetString()));
                    }
                    deny = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SignalRNetworkAcl(allow ?? new ChangeTrackingList<SignalRRequestType>(), deny ?? new ChangeTrackingList<SignalRRequestType>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SignalRNetworkAcl>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRNetworkAcl>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SignalRNetworkAcl)} does not support '{options.Format}' format.");
            }
        }

        SignalRNetworkAcl IPersistableModel<SignalRNetworkAcl>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRNetworkAcl>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSignalRNetworkAcl(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SignalRNetworkAcl)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SignalRNetworkAcl>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
