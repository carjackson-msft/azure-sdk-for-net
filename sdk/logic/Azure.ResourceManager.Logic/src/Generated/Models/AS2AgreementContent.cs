// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The integration account AS2 agreement content. </summary>
    public partial class AS2AgreementContent
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

        /// <summary> Initializes a new instance of <see cref="AS2AgreementContent"/>. </summary>
        /// <param name="receiveAgreement"> The AS2 one-way receive agreement. </param>
        /// <param name="sendAgreement"> The AS2 one-way send agreement. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="receiveAgreement"/> or <paramref name="sendAgreement"/> is null. </exception>
        public AS2AgreementContent(AS2OneWayAgreement receiveAgreement, AS2OneWayAgreement sendAgreement)
        {
            if (receiveAgreement == null)
            {
                throw new ArgumentNullException(nameof(receiveAgreement));
            }
            if (sendAgreement == null)
            {
                throw new ArgumentNullException(nameof(sendAgreement));
            }

            ReceiveAgreement = receiveAgreement;
            SendAgreement = sendAgreement;
        }

        /// <summary> Initializes a new instance of <see cref="AS2AgreementContent"/>. </summary>
        /// <param name="receiveAgreement"> The AS2 one-way receive agreement. </param>
        /// <param name="sendAgreement"> The AS2 one-way send agreement. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AS2AgreementContent(AS2OneWayAgreement receiveAgreement, AS2OneWayAgreement sendAgreement, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ReceiveAgreement = receiveAgreement;
            SendAgreement = sendAgreement;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AS2AgreementContent"/> for deserialization. </summary>
        internal AS2AgreementContent()
        {
        }

        /// <summary> The AS2 one-way receive agreement. </summary>
        public AS2OneWayAgreement ReceiveAgreement { get; set; }
        /// <summary> The AS2 one-way send agreement. </summary>
        public AS2OneWayAgreement SendAgreement { get; set; }
    }
}
