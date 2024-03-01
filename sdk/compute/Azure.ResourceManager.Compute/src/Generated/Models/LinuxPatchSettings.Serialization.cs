// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class LinuxPatchSettings : IUtf8JsonSerializable, IJsonModel<LinuxPatchSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LinuxPatchSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LinuxPatchSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinuxPatchSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinuxPatchSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (PatchMode.HasValue)
            {
                writer.WritePropertyName("patchMode"u8);
                writer.WriteStringValue(PatchMode.Value.ToString());
            }
            if (AssessmentMode.HasValue)
            {
                writer.WritePropertyName("assessmentMode"u8);
                writer.WriteStringValue(AssessmentMode.Value.ToString());
            }
            if (AutomaticByPlatformSettings != null)
            {
                writer.WritePropertyName("automaticByPlatformSettings"u8);
                writer.WriteObjectValue(AutomaticByPlatformSettings);
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

        LinuxPatchSettings IJsonModel<LinuxPatchSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinuxPatchSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinuxPatchSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLinuxPatchSettings(document.RootElement, options);
        }

        internal static LinuxPatchSettings DeserializeLinuxPatchSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LinuxVmGuestPatchMode> patchMode = default;
            Optional<LinuxPatchAssessmentMode> assessmentMode = default;
            Optional<LinuxVmGuestPatchAutomaticByPlatformSettings> automaticByPlatformSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("patchMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    patchMode = new LinuxVmGuestPatchMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("assessmentMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assessmentMode = new LinuxPatchAssessmentMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("automaticByPlatformSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    automaticByPlatformSettings = LinuxVmGuestPatchAutomaticByPlatformSettings.DeserializeLinuxVmGuestPatchAutomaticByPlatformSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LinuxPatchSettings(Optional.ToNullable(patchMode), Optional.ToNullable(assessmentMode), automaticByPlatformSettings.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LinuxPatchSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinuxPatchSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LinuxPatchSettings)} does not support '{options.Format}' format.");
            }
        }

        LinuxPatchSettings IPersistableModel<LinuxPatchSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinuxPatchSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLinuxPatchSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LinuxPatchSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LinuxPatchSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
