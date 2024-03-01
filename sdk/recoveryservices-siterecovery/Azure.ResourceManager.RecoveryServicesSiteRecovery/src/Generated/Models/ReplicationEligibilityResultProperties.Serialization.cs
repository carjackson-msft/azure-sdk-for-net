// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ReplicationEligibilityResultProperties : IUtf8JsonSerializable, IJsonModel<ReplicationEligibilityResultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReplicationEligibilityResultProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReplicationEligibilityResultProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationEligibilityResultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReplicationEligibilityResultProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ClientRequestId != null)
            {
                writer.WritePropertyName("clientRequestId"u8);
                writer.WriteStringValue(ClientRequestId);
            }
            if (!(Errors is ChangeTrackingList<ReplicationEligibilityResultErrorInfo> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item);
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

        ReplicationEligibilityResultProperties IJsonModel<ReplicationEligibilityResultProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationEligibilityResultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReplicationEligibilityResultProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReplicationEligibilityResultProperties(document.RootElement, options);
        }

        internal static ReplicationEligibilityResultProperties DeserializeReplicationEligibilityResultProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> clientRequestId = default;
            IReadOnlyList<ReplicationEligibilityResultErrorInfo> errors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientRequestId"u8))
                {
                    clientRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReplicationEligibilityResultErrorInfo> array = new List<ReplicationEligibilityResultErrorInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReplicationEligibilityResultErrorInfo.DeserializeReplicationEligibilityResultErrorInfo(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReplicationEligibilityResultProperties(clientRequestId.Value, errors ?? new ChangeTrackingList<ReplicationEligibilityResultErrorInfo>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReplicationEligibilityResultProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationEligibilityResultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReplicationEligibilityResultProperties)} does not support '{options.Format}' format.");
            }
        }

        ReplicationEligibilityResultProperties IPersistableModel<ReplicationEligibilityResultProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationEligibilityResultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReplicationEligibilityResultProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReplicationEligibilityResultProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReplicationEligibilityResultProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
