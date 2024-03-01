// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    internal partial class AddParticipantsResponseInternal
    {
        internal static AddParticipantsResponseInternal DeserializeAddParticipantsResponseInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<AcsCallParticipantInternal> participants = default;
            Optional<string> operationContext = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("participants"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AcsCallParticipantInternal> array = new List<AcsCallParticipantInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AcsCallParticipantInternal.DeserializeAcsCallParticipantInternal(item));
                    }
                    participants = array;
                    continue;
                }
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
            }
            return new AddParticipantsResponseInternal(participants ?? new ChangeTrackingList<AcsCallParticipantInternal>(), operationContext.Value);
        }
    }
}
