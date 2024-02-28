// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Describes a transcription track in the output of a live event, generated using speech-to-text transcription. This property is reserved for future use, any value set on this property will be ignored. </summary>
    internal partial class LiveEventOutputTranscriptionTrack
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

        /// <summary> Initializes a new instance of <see cref="LiveEventOutputTranscriptionTrack"/>. </summary>
        /// <param name="trackName"> The output track name. This property is reserved for future use, any value set on this property will be ignored. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trackName"/> is null. </exception>
        public LiveEventOutputTranscriptionTrack(string trackName)
        {
            if (trackName == null)
            {
                throw new ArgumentNullException(nameof(trackName));
            }

            TrackName = trackName;
        }

        /// <summary> Initializes a new instance of <see cref="LiveEventOutputTranscriptionTrack"/>. </summary>
        /// <param name="trackName"> The output track name. This property is reserved for future use, any value set on this property will be ignored. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LiveEventOutputTranscriptionTrack(string trackName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TrackName = trackName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="LiveEventOutputTranscriptionTrack"/> for deserialization. </summary>
        internal LiveEventOutputTranscriptionTrack()
        {
        }

        /// <summary> The output track name. This property is reserved for future use, any value set on this property will be ignored. </summary>
        public string TrackName { get; set; }
    }
}
