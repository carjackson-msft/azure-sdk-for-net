// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The parameters to provide for the Alexa channel. </summary>
    public partial class AlexaChannelProperties
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

        /// <summary> Initializes a new instance of <see cref="AlexaChannelProperties"/>. </summary>
        /// <param name="alexaSkillId"> The Alexa skill Id. </param>
        /// <param name="isEnabled"> Whether this channel is enabled for the bot. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alexaSkillId"/> is null. </exception>
        public AlexaChannelProperties(string alexaSkillId, bool isEnabled)
        {
            if (alexaSkillId == null)
            {
                throw new ArgumentNullException(nameof(alexaSkillId));
            }

            AlexaSkillId = alexaSkillId;
            IsEnabled = isEnabled;
        }

        /// <summary> Initializes a new instance of <see cref="AlexaChannelProperties"/>. </summary>
        /// <param name="alexaSkillId"> The Alexa skill Id. </param>
        /// <param name="uriFragment"> Url fragment used in part of the Uri configured in Alexa. </param>
        /// <param name="serviceEndpointUri"> Full Uri used to configured the skill in Alexa. </param>
        /// <param name="isEnabled"> Whether this channel is enabled for the bot. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AlexaChannelProperties(string alexaSkillId, string uriFragment, Uri serviceEndpointUri, bool isEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AlexaSkillId = alexaSkillId;
            UriFragment = uriFragment;
            ServiceEndpointUri = serviceEndpointUri;
            IsEnabled = isEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AlexaChannelProperties"/> for deserialization. </summary>
        internal AlexaChannelProperties()
        {
        }

        /// <summary> The Alexa skill Id. </summary>
        public string AlexaSkillId { get; set; }
        /// <summary> Url fragment used in part of the Uri configured in Alexa. </summary>
        public string UriFragment { get; }
        /// <summary> Full Uri used to configured the skill in Alexa. </summary>
        public Uri ServiceEndpointUri { get; }
        /// <summary> Whether this channel is enabled for the bot. </summary>
        public bool IsEnabled { get; set; }
    }
}
