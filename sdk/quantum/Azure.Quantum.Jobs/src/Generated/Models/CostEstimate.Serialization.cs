// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Quantum.Jobs.Models
{
    public partial class CostEstimate
    {
        internal static CostEstimate DeserializeCostEstimate(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> currencyCode = default;
            IReadOnlyList<UsageEvent> events = default;
            Optional<float> estimatedTotal = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("currencyCode"u8))
                {
                    currencyCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("events"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UsageEvent> array = new List<UsageEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UsageEvent.DeserializeUsageEvent(item));
                    }
                    events = array;
                    continue;
                }
                if (property.NameEquals("estimatedTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    estimatedTotal = property.Value.GetSingle();
                    continue;
                }
            }
            return new CostEstimate(currencyCode.Value, events ?? new ChangeTrackingList<UsageEvent>(), Optional.ToNullable(estimatedTotal));
        }
    }
}
