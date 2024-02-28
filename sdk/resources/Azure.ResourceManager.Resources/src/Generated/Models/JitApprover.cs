// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> JIT approver definition. </summary>
    public partial class JitApprover
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="JitApprover"/>. </summary>
        /// <param name="id"> The approver service principal Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public JitApprover(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
        }

        /// <summary> Initializes a new instance of <see cref="JitApprover"/>. </summary>
        /// <param name="id"> The approver service principal Id. </param>
        /// <param name="approverType"> The approver type. </param>
        /// <param name="displayName"> The approver display name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal JitApprover(string id, JitApproverType? approverType, string displayName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            ApproverType = approverType;
            DisplayName = displayName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="JitApprover"/> for deserialization. </summary>
        internal JitApprover()
        {
        }

        /// <summary> The approver service principal Id. </summary>
        public string Id { get; set; }
        /// <summary> The approver type. </summary>
        public JitApproverType? ApproverType { get; set; }
        /// <summary> The approver display name. </summary>
        public string DisplayName { get; set; }
    }
}
