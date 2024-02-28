// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class SamplingOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (SkipSamplesWithoutAnnotation != null)
            {
                writer.WritePropertyName("skipSamplesWithoutAnnotation"u8);
                writer.WriteStringValue(SkipSamplesWithoutAnnotation);
            }
            if (MaximumSamplesPerSecond != null)
            {
                writer.WritePropertyName("maximumSamplesPerSecond"u8);
                writer.WriteStringValue(MaximumSamplesPerSecond);
            }
            writer.WriteEndObject();
        }

        internal static SamplingOptions DeserializeSamplingOptions(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> skipSamplesWithoutAnnotation = default;
            Optional<string> maximumSamplesPerSecond = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("skipSamplesWithoutAnnotation"u8))
                {
                    skipSamplesWithoutAnnotation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maximumSamplesPerSecond"u8))
                {
                    maximumSamplesPerSecond = property.Value.GetString();
                    continue;
                }
            }
            return new SamplingOptions(skipSamplesWithoutAnnotation.Value, maximumSamplesPerSecond.Value);
        }
    }
}
