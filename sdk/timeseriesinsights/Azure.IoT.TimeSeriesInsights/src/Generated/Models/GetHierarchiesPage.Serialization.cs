// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    internal partial class GetHierarchiesPage
    {
        internal static GetHierarchiesPage DeserializeGetHierarchiesPage(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<TimeSeriesHierarchy> hierarchies = default;
            Optional<string> continuationToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hierarchies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TimeSeriesHierarchy> array = new List<TimeSeriesHierarchy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimeSeriesHierarchy.DeserializeTimeSeriesHierarchy(item));
                    }
                    hierarchies = array;
                    continue;
                }
                if (property.NameEquals("continuationToken"u8))
                {
                    continuationToken = property.Value.GetString();
                    continue;
                }
            }
            return new GetHierarchiesPage(continuationToken.Value, hierarchies ?? new ChangeTrackingList<TimeSeriesHierarchy>());
        }
    }
}
