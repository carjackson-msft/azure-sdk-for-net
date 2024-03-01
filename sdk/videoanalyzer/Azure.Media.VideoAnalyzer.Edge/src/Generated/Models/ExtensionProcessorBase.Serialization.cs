// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class ExtensionProcessorBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("endpoint"u8);
            writer.WriteObjectValue(Endpoint);
            writer.WritePropertyName("image"u8);
            writer.WriteObjectValue(Image);
            if (SamplingOptions != null)
            {
                writer.WritePropertyName("samplingOptions"u8);
                writer.WriteObjectValue(SamplingOptions);
            }
            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue(Type);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("inputs"u8);
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static ExtensionProcessorBase DeserializeExtensionProcessorBase(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.VideoAnalyzer.GrpcExtension": return GrpcExtension.DeserializeGrpcExtension(element);
                    case "#Microsoft.VideoAnalyzer.HttpExtension": return HttpExtension.DeserializeHttpExtension(element);
                }
            }
            EndpointBase endpoint = default;
            ImageProperties image = default;
            Optional<SamplingOptions> samplingOptions = default;
            string type = "#Microsoft.VideoAnalyzer.ExtensionProcessorBase";
            string name = default;
            IList<NodeInput> inputs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpoint"u8))
                {
                    endpoint = EndpointBase.DeserializeEndpointBase(property.Value);
                    continue;
                }
                if (property.NameEquals("image"u8))
                {
                    image = ImageProperties.DeserializeImageProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("samplingOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    samplingOptions = SamplingOptions.DeserializeSamplingOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("@type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    List<NodeInput> array = new List<NodeInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NodeInput.DeserializeNodeInput(item));
                    }
                    inputs = array;
                    continue;
                }
            }
            return new ExtensionProcessorBase(
                type,
                name,
                inputs,
                endpoint,
                image,
                samplingOptions.Value);
        }
    }
}
