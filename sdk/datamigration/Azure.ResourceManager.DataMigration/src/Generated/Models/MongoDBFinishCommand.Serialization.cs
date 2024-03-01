// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MongoDBFinishCommand : IUtf8JsonSerializable, IJsonModel<MongoDBFinishCommand>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MongoDBFinishCommand>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MongoDBFinishCommand>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBFinishCommand>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBFinishCommand)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Input != null)
            {
                writer.WritePropertyName("input"u8);
                writer.WriteObjectValue(Input);
            }
            writer.WritePropertyName("commandType"u8);
            writer.WriteStringValue(CommandType.ToString());
            if (options.Format != "W" && !(Errors is ChangeTrackingList<ODataError> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && State.HasValue)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
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

        MongoDBFinishCommand IJsonModel<MongoDBFinishCommand>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBFinishCommand>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBFinishCommand)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMongoDBFinishCommand(document.RootElement, options);
        }

        internal static MongoDBFinishCommand DeserializeMongoDBFinishCommand(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MongoDBFinishCommandInput> input = default;
            CommandType commandType = default;
            IReadOnlyList<ODataError> errors = default;
            Optional<CommandState> state = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("input"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    input = MongoDBFinishCommandInput.DeserializeMongoDBFinishCommandInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("commandType"u8))
                {
                    commandType = new CommandType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ODataError> array = new List<ODataError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ODataError.DeserializeODataError(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new CommandState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MongoDBFinishCommand(commandType, errors ?? new ChangeTrackingList<ODataError>(), Optional.ToNullable(state), serializedAdditionalRawData, input.Value);
        }

        BinaryData IPersistableModel<MongoDBFinishCommand>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBFinishCommand>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MongoDBFinishCommand)} does not support '{options.Format}' format.");
            }
        }

        MongoDBFinishCommand IPersistableModel<MongoDBFinishCommand>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBFinishCommand>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMongoDBFinishCommand(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MongoDBFinishCommand)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MongoDBFinishCommand>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
