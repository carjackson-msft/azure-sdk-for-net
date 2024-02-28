// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class ManualReclassifyExceptionAction : IUtf8JsonSerializable, IJsonModel<ManualReclassifyExceptionAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManualReclassifyExceptionAction>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManualReclassifyExceptionAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManualReclassifyExceptionAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManualReclassifyExceptionAction)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (QueueId != null)
            {
                writer.WritePropertyName("queueId"u8);
                writer.WriteStringValue(QueueId);
            }
            if (Priority.HasValue)
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (!(WorkerSelectors is ChangeTrackingList<RouterWorkerSelector> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("workerSelectors"u8);
                writer.WriteStartArray();
                foreach (var item in WorkerSelectors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        ManualReclassifyExceptionAction IJsonModel<ManualReclassifyExceptionAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManualReclassifyExceptionAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManualReclassifyExceptionAction)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManualReclassifyExceptionAction(document.RootElement, options);
        }

        internal static ManualReclassifyExceptionAction DeserializeManualReclassifyExceptionAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> queueId = default;
            Optional<int> priority = default;
            IList<RouterWorkerSelector> workerSelectors = default;
            Optional<string> id = default;
            ExceptionActionKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queueId"u8))
                {
                    queueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("workerSelectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouterWorkerSelector> array = new List<RouterWorkerSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouterWorkerSelector.DeserializeRouterWorkerSelector(item, options));
                    }
                    workerSelectors = array;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new ExceptionActionKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManualReclassifyExceptionAction(
                id.Value,
                kind,
                serializedAdditionalRawData,
                queueId.Value,
                Optional.ToNullable(priority),
                workerSelectors ?? new ChangeTrackingList<RouterWorkerSelector>());
        }

        BinaryData IPersistableModel<ManualReclassifyExceptionAction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManualReclassifyExceptionAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManualReclassifyExceptionAction)} does not support '{options.Format}' format.");
            }
        }

        ManualReclassifyExceptionAction IPersistableModel<ManualReclassifyExceptionAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManualReclassifyExceptionAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManualReclassifyExceptionAction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManualReclassifyExceptionAction)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManualReclassifyExceptionAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new ManualReclassifyExceptionAction FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeManualReclassifyExceptionAction(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
