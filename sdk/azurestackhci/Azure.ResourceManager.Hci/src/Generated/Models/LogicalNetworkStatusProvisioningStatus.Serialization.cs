// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class LogicalNetworkStatusProvisioningStatus : IUtf8JsonSerializable, IJsonModel<LogicalNetworkStatusProvisioningStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicalNetworkStatusProvisioningStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogicalNetworkStatusProvisioningStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicalNetworkStatusProvisioningStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicalNetworkStatusProvisioningStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (OperationId != null)
            {
                writer.WritePropertyName("operationId"u8);
                writer.WriteStringValue(OperationId);
            }
            if (Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
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

        LogicalNetworkStatusProvisioningStatus IJsonModel<LogicalNetworkStatusProvisioningStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicalNetworkStatusProvisioningStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicalNetworkStatusProvisioningStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicalNetworkStatusProvisioningStatus(document.RootElement, options);
        }

        internal static LogicalNetworkStatusProvisioningStatus DeserializeLogicalNetworkStatusProvisioningStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> operationId = default;
            Optional<HciClusterStatus> status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new HciClusterStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogicalNetworkStatusProvisioningStatus(operationId.Value, Optional.ToNullable(status), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LogicalNetworkStatusProvisioningStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicalNetworkStatusProvisioningStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogicalNetworkStatusProvisioningStatus)} does not support '{options.Format}' format.");
            }
        }

        LogicalNetworkStatusProvisioningStatus IPersistableModel<LogicalNetworkStatusProvisioningStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicalNetworkStatusProvisioningStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogicalNetworkStatusProvisioningStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogicalNetworkStatusProvisioningStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogicalNetworkStatusProvisioningStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
