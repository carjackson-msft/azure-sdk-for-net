// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    public partial class OciAnnotations : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (CreatedOn.HasValue)
            {
                writer.WritePropertyName("org.opencontainers.image.created"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Authors != null)
            {
                writer.WritePropertyName("org.opencontainers.image.authors"u8);
                writer.WriteStringValue(Authors);
            }
            if (Url != null)
            {
                writer.WritePropertyName("org.opencontainers.image.url"u8);
                writer.WriteStringValue(Url.AbsoluteUri);
            }
            if (Documentation != null)
            {
                writer.WritePropertyName("org.opencontainers.image.documentation"u8);
                writer.WriteStringValue(Documentation.AbsoluteUri);
            }
            if (Source != null)
            {
                writer.WritePropertyName("org.opencontainers.image.source"u8);
                writer.WriteStringValue(Source.AbsoluteUri);
            }
            if (Version != null)
            {
                writer.WritePropertyName("org.opencontainers.image.version"u8);
                writer.WriteStringValue(Version);
            }
            if (Revision != null)
            {
                writer.WritePropertyName("org.opencontainers.image.revision"u8);
                writer.WriteStringValue(Revision);
            }
            if (Vendor != null)
            {
                writer.WritePropertyName("org.opencontainers.image.vendor"u8);
                writer.WriteStringValue(Vendor);
            }
            if (Licenses != null)
            {
                writer.WritePropertyName("org.opencontainers.image.licenses"u8);
                writer.WriteStringValue(Licenses);
            }
            if (Name != null)
            {
                writer.WritePropertyName("org.opencontainers.image.ref.name"u8);
                writer.WriteStringValue(Name);
            }
            if (Title != null)
            {
                writer.WritePropertyName("org.opencontainers.image.title"u8);
                writer.WriteStringValue(Title);
            }
            if (Description != null)
            {
                writer.WritePropertyName("org.opencontainers.image.description"u8);
                writer.WriteStringValue(Description);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static OciAnnotations DeserializeOciAnnotations(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> orgOpencontainersImageCreated = default;
            Optional<string> orgOpencontainersImageAuthors = default;
            Optional<Uri> orgOpencontainersImageUrl = default;
            Optional<Uri> orgOpencontainersImageDocumentation = default;
            Optional<Uri> orgOpencontainersImageSource = default;
            Optional<string> orgOpencontainersImageVersion = default;
            Optional<string> orgOpencontainersImageRevision = default;
            Optional<string> orgOpencontainersImageVendor = default;
            Optional<string> orgOpencontainersImageLicenses = default;
            Optional<string> orgOpencontainersImageRefName = default;
            Optional<string> orgOpencontainersImageTitle = default;
            Optional<string> orgOpencontainersImageDescription = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("org.opencontainers.image.created"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    orgOpencontainersImageCreated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("org.opencontainers.image.authors"u8))
                {
                    orgOpencontainersImageAuthors = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("org.opencontainers.image.url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    orgOpencontainersImageUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("org.opencontainers.image.documentation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    orgOpencontainersImageDocumentation = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("org.opencontainers.image.source"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    orgOpencontainersImageSource = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("org.opencontainers.image.version"u8))
                {
                    orgOpencontainersImageVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("org.opencontainers.image.revision"u8))
                {
                    orgOpencontainersImageRevision = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("org.opencontainers.image.vendor"u8))
                {
                    orgOpencontainersImageVendor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("org.opencontainers.image.licenses"u8))
                {
                    orgOpencontainersImageLicenses = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("org.opencontainers.image.ref.name"u8))
                {
                    orgOpencontainersImageRefName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("org.opencontainers.image.title"u8))
                {
                    orgOpencontainersImageTitle = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("org.opencontainers.image.description"u8))
                {
                    orgOpencontainersImageDescription = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new OciAnnotations(
                Optional.ToNullable(orgOpencontainersImageCreated),
                orgOpencontainersImageAuthors.Value,
                orgOpencontainersImageUrl.Value,
                orgOpencontainersImageDocumentation.Value,
                orgOpencontainersImageSource.Value,
                orgOpencontainersImageVersion.Value,
                orgOpencontainersImageRevision.Value,
                orgOpencontainersImageVendor.Value,
                orgOpencontainersImageLicenses.Value,
                orgOpencontainersImageRefName.Value,
                orgOpencontainersImageTitle.Value,
                orgOpencontainersImageDescription.Value,
                additionalProperties);
        }
    }
}
