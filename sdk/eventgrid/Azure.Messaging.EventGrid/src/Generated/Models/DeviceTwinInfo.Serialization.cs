// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class DeviceTwinInfo
    {
        internal static DeviceTwinInfo DeserializeDeviceTwinInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> authenticationType = default;
            Optional<float> cloudToDeviceMessageCount = default;
            Optional<string> connectionState = default;
            Optional<string> deviceId = default;
            Optional<string> etag = default;
            Optional<string> lastActivityTime = default;
            Optional<DeviceTwinInfoProperties> properties = default;
            Optional<string> status = default;
            Optional<string> statusUpdateTime = default;
            Optional<float> version = default;
            Optional<DeviceTwinInfoX509Thumbprint> x509Thumbprint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authenticationType"u8))
                {
                    authenticationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cloudToDeviceMessageCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloudToDeviceMessageCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("connectionState"u8))
                {
                    connectionState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceId"u8))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastActivityTime"u8))
                {
                    lastActivityTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = DeviceTwinInfoProperties.DeserializeDeviceTwinInfoProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusUpdateTime"u8))
                {
                    statusUpdateTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("x509Thumbprint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    x509Thumbprint = DeviceTwinInfoX509Thumbprint.DeserializeDeviceTwinInfoX509Thumbprint(property.Value);
                    continue;
                }
            }
            return new DeviceTwinInfo(
                authenticationType.Value,
                Optional.ToNullable(cloudToDeviceMessageCount),
                connectionState.Value,
                deviceId.Value,
                etag.Value,
                lastActivityTime.Value,
                properties.Value,
                status.Value,
                statusUpdateTime.Value,
                Optional.ToNullable(version),
                x509Thumbprint.Value);
        }
    }
}
