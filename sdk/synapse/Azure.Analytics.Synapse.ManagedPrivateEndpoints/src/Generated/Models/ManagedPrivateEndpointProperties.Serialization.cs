// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.ManagedPrivateEndpoints.Models
{
    public partial class ManagedPrivateEndpointProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (PrivateLinkResourceId != null)
            {
                writer.WritePropertyName("privateLinkResourceId"u8);
                writer.WriteStringValue(PrivateLinkResourceId);
            }
            if (GroupId != null)
            {
                writer.WritePropertyName("groupId"u8);
                writer.WriteStringValue(GroupId);
            }
            if (ConnectionState != null)
            {
                writer.WritePropertyName("connectionState"u8);
                writer.WriteObjectValue(ConnectionState);
            }
            if (!(Fqdns is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("fqdns"u8);
                writer.WriteStartArray();
                foreach (var item in Fqdns)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (IsCompliant.HasValue)
            {
                writer.WritePropertyName("isCompliant"u8);
                writer.WriteBooleanValue(IsCompliant.Value);
            }
            writer.WriteEndObject();
        }

        internal static ManagedPrivateEndpointProperties DeserializeManagedPrivateEndpointProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> privateLinkResourceId = default;
            Optional<string> groupId = default;
            Optional<string> provisioningState = default;
            Optional<ManagedPrivateEndpointConnectionState> connectionState = default;
            Optional<bool> isReserved = default;
            IList<string> fqdns = default;
            Optional<bool> isCompliant = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateLinkResourceId"u8))
                {
                    privateLinkResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupId"u8))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionState = ManagedPrivateEndpointConnectionState.DeserializeManagedPrivateEndpointConnectionState(property.Value);
                    continue;
                }
                if (property.NameEquals("isReserved"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isReserved = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("fqdns"u8))
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
                    fqdns = array;
                    continue;
                }
                if (property.NameEquals("isCompliant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isCompliant = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ManagedPrivateEndpointProperties(
                name.Value,
                privateLinkResourceId.Value,
                groupId.Value,
                provisioningState.Value,
                connectionState.Value,
                Optional.ToNullable(isReserved),
                fqdns ?? new ChangeTrackingList<string>(),
                Optional.ToNullable(isCompliant));
        }
    }
}
