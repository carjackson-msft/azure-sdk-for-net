// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.Analysis;

namespace Azure.ResourceManager.Analysis.Models
{
    /// <summary> An array of Analysis Services resources. </summary>
    internal partial class AnalysisServers
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

        /// <summary> Initializes a new instance of <see cref="AnalysisServers"/>. </summary>
        /// <param name="analysisResources"> An array of Analysis Services resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisResources"/> is null. </exception>
        internal AnalysisServers(IEnumerable<AnalysisServerData> analysisResources)
        {
            if (analysisResources == null)
            {
                throw new ArgumentNullException(nameof(analysisResources));
            }

            AnalysisResources = analysisResources.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AnalysisServers"/>. </summary>
        /// <param name="analysisResources"> An array of Analysis Services resources. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalysisServers(IReadOnlyList<AnalysisServerData> analysisResources, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AnalysisResources = analysisResources;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AnalysisServers"/> for deserialization. </summary>
        internal AnalysisServers()
        {
        }

        /// <summary> An array of Analysis Services resources. </summary>
        public IReadOnlyList<AnalysisServerData> AnalysisResources { get; }
    }
}
