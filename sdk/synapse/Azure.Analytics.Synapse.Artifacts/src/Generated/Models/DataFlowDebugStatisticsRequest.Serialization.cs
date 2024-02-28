// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(DataFlowDebugStatisticsRequestConverter))]
    public partial class DataFlowDebugStatisticsRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (SessionId != null)
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId);
            }
            if (DataFlowName != null)
            {
                writer.WritePropertyName("dataFlowName"u8);
                writer.WriteStringValue(DataFlowName);
            }
            if (StreamName != null)
            {
                writer.WritePropertyName("streamName"u8);
                writer.WriteStringValue(StreamName);
            }
            if (!(Columns is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("columns"u8);
                writer.WriteStartArray();
                foreach (var item in Columns)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static DataFlowDebugStatisticsRequest DeserializeDataFlowDebugStatisticsRequest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> sessionId = default;
            Optional<string> dataFlowName = default;
            Optional<string> streamName = default;
            IList<string> columns = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"u8))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFlowName"u8))
                {
                    dataFlowName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streamName"u8))
                {
                    streamName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("columns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    columns = array;
                    continue;
                }
            }
            return new DataFlowDebugStatisticsRequest(sessionId.Value, dataFlowName.Value, streamName.Value, columns ?? new ChangeTrackingList<string>());
        }

        internal partial class DataFlowDebugStatisticsRequestConverter : JsonConverter<DataFlowDebugStatisticsRequest>
        {
            public override void Write(Utf8JsonWriter writer, DataFlowDebugStatisticsRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DataFlowDebugStatisticsRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDataFlowDebugStatisticsRequest(document.RootElement);
            }
        }
    }
}
