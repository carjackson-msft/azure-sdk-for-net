// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> AutoScale settings for the pool. </summary>
    public partial class BatchAccountAutoScaleSettings
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

        /// <summary> Initializes a new instance of <see cref="BatchAccountAutoScaleSettings"/>. </summary>
        /// <param name="formula"> A formula for the desired number of compute nodes in the pool. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="formula"/> is null. </exception>
        public BatchAccountAutoScaleSettings(string formula)
        {
            if (formula == null)
            {
                throw new ArgumentNullException(nameof(formula));
            }

            Formula = formula;
        }

        /// <summary> Initializes a new instance of <see cref="BatchAccountAutoScaleSettings"/>. </summary>
        /// <param name="formula"> A formula for the desired number of compute nodes in the pool. </param>
        /// <param name="evaluationInterval"> If omitted, the default value is 15 minutes (PT15M). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchAccountAutoScaleSettings(string formula, TimeSpan? evaluationInterval, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Formula = formula;
            EvaluationInterval = evaluationInterval;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchAccountAutoScaleSettings"/> for deserialization. </summary>
        internal BatchAccountAutoScaleSettings()
        {
        }

        /// <summary> A formula for the desired number of compute nodes in the pool. </summary>
        public string Formula { get; set; }
        /// <summary> If omitted, the default value is 15 minutes (PT15M). </summary>
        public TimeSpan? EvaluationInterval { get; set; }
    }
}
