// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class TestFailoverWorkflowModelCustomProperties : IUtf8JsonSerializable, IJsonModel<TestFailoverWorkflowModelCustomProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TestFailoverWorkflowModelCustomProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TestFailoverWorkflowModelCustomProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestFailoverWorkflowModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TestFailoverWorkflowModelCustomProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && !(ProtectedItemDetails is ChangeTrackingList<FailoverProtectedItemProperties> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("protectedItemDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedItemDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            if (options.Format != "W" && !(AffectedObjectDetails is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("affectedObjectDetails"u8);
                writer.WriteStartObject();
                foreach (var item in AffectedObjectDetails)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        TestFailoverWorkflowModelCustomProperties IJsonModel<TestFailoverWorkflowModelCustomProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestFailoverWorkflowModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TestFailoverWorkflowModelCustomProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTestFailoverWorkflowModelCustomProperties(document.RootElement, options);
        }

        internal static TestFailoverWorkflowModelCustomProperties DeserializeTestFailoverWorkflowModelCustomProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<FailoverProtectedItemProperties> protectedItemDetails = default;
            string instanceType = default;
            IReadOnlyDictionary<string, string> affectedObjectDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectedItemDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FailoverProtectedItemProperties> array = new List<FailoverProtectedItemProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FailoverProtectedItemProperties.DeserializeFailoverProtectedItemProperties(item, options));
                    }
                    protectedItemDetails = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("affectedObjectDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    affectedObjectDetails = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TestFailoverWorkflowModelCustomProperties(instanceType, affectedObjectDetails ?? new ChangeTrackingDictionary<string, string>(), serializedAdditionalRawData, protectedItemDetails ?? new ChangeTrackingList<FailoverProtectedItemProperties>());
        }

        BinaryData IPersistableModel<TestFailoverWorkflowModelCustomProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestFailoverWorkflowModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TestFailoverWorkflowModelCustomProperties)} does not support '{options.Format}' format.");
            }
        }

        TestFailoverWorkflowModelCustomProperties IPersistableModel<TestFailoverWorkflowModelCustomProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestFailoverWorkflowModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTestFailoverWorkflowModelCustomProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TestFailoverWorkflowModelCustomProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TestFailoverWorkflowModelCustomProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
