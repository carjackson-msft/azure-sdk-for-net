// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace BasicTypeSpec.Models
{
    /// <summary> this is not a friendly model but with a friendly name. </summary>
    public partial class Friend
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal Friend(string name)
        {
            Name = name;
        }

        internal Friend(string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> name of the NotFriend. </summary>
        public string Name { get; set; }
    }
}
