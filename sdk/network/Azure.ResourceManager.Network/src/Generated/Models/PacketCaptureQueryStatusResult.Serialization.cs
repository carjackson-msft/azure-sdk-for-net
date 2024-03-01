// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PacketCaptureQueryStatusResult : IUtf8JsonSerializable, IJsonModel<PacketCaptureQueryStatusResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PacketCaptureQueryStatusResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PacketCaptureQueryStatusResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PacketCaptureQueryStatusResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PacketCaptureQueryStatusResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (CaptureStartOn.HasValue)
            {
                writer.WritePropertyName("captureStartTime"u8);
                writer.WriteStringValue(CaptureStartOn.Value, "O");
            }
            if (PacketCaptureStatus.HasValue)
            {
                writer.WritePropertyName("packetCaptureStatus"u8);
                writer.WriteStringValue(PacketCaptureStatus.Value.ToString());
            }
            if (StopReason != null)
            {
                writer.WritePropertyName("stopReason"u8);
                writer.WriteStringValue(StopReason);
            }
            if (!(PacketCaptureError is ChangeTrackingList<PcError> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("packetCaptureError"u8);
                writer.WriteStartArray();
                foreach (var item in PacketCaptureError)
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

        PacketCaptureQueryStatusResult IJsonModel<PacketCaptureQueryStatusResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PacketCaptureQueryStatusResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PacketCaptureQueryStatusResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePacketCaptureQueryStatusResult(document.RootElement, options);
        }

        internal static PacketCaptureQueryStatusResult DeserializePacketCaptureQueryStatusResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> id = default;
            Optional<DateTimeOffset> captureStartTime = default;
            Optional<PcStatus> packetCaptureStatus = default;
            Optional<string> stopReason = default;
            IReadOnlyList<PcError> packetCaptureError = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("captureStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    captureStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("packetCaptureStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    packetCaptureStatus = new PcStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("stopReason"u8))
                {
                    stopReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("packetCaptureError"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PcError> array = new List<PcError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new PcError(item.GetString()));
                    }
                    packetCaptureError = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PacketCaptureQueryStatusResult(
                name.Value,
                id.Value,
                Optional.ToNullable(captureStartTime),
                Optional.ToNullable(packetCaptureStatus),
                stopReason.Value,
                packetCaptureError ?? new ChangeTrackingList<PcError>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PacketCaptureQueryStatusResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PacketCaptureQueryStatusResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PacketCaptureQueryStatusResult)} does not support '{options.Format}' format.");
            }
        }

        PacketCaptureQueryStatusResult IPersistableModel<PacketCaptureQueryStatusResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PacketCaptureQueryStatusResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePacketCaptureQueryStatusResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PacketCaptureQueryStatusResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PacketCaptureQueryStatusResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
