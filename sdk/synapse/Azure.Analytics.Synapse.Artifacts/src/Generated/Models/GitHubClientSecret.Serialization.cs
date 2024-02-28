// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(GitHubClientSecretConverter))]
    public partial class GitHubClientSecret : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ByoaSecretAkvUrl != null)
            {
                writer.WritePropertyName("byoaSecretAkvUrl"u8);
                writer.WriteStringValue(ByoaSecretAkvUrl);
            }
            if (ByoaSecretName != null)
            {
                writer.WritePropertyName("byoaSecretName"u8);
                writer.WriteStringValue(ByoaSecretName);
            }
            writer.WriteEndObject();
        }

        internal static GitHubClientSecret DeserializeGitHubClientSecret(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> byoaSecretAkvUrl = default;
            Optional<string> byoaSecretName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("byoaSecretAkvUrl"u8))
                {
                    byoaSecretAkvUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("byoaSecretName"u8))
                {
                    byoaSecretName = property.Value.GetString();
                    continue;
                }
            }
            return new GitHubClientSecret(byoaSecretAkvUrl.Value, byoaSecretName.Value);
        }

        internal partial class GitHubClientSecretConverter : JsonConverter<GitHubClientSecret>
        {
            public override void Write(Utf8JsonWriter writer, GitHubClientSecret model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override GitHubClientSecret Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeGitHubClientSecret(document.RootElement);
            }
        }
    }
}
