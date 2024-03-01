// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Contact Details. </summary>
    public partial class EdgeOrderAddressContactDetails
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

        /// <summary> Initializes a new instance of <see cref="EdgeOrderAddressContactDetails"/>. </summary>
        /// <param name="contactName"> Contact name of the person. </param>
        /// <param name="phone"> Phone number of the contact person. </param>
        /// <param name="emailList"> List of Email-ids to be notified about job progress. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contactName"/>, <paramref name="phone"/> or <paramref name="emailList"/> is null. </exception>
        public EdgeOrderAddressContactDetails(string contactName, string phone, IEnumerable<string> emailList)
        {
            if (contactName == null)
            {
                throw new ArgumentNullException(nameof(contactName));
            }
            if (phone == null)
            {
                throw new ArgumentNullException(nameof(phone));
            }
            if (emailList == null)
            {
                throw new ArgumentNullException(nameof(emailList));
            }

            ContactName = contactName;
            Phone = phone;
            EmailList = emailList.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="EdgeOrderAddressContactDetails"/>. </summary>
        /// <param name="contactName"> Contact name of the person. </param>
        /// <param name="phone"> Phone number of the contact person. </param>
        /// <param name="phoneExtension"> Phone extension number of the contact person. </param>
        /// <param name="mobile"> Mobile number of the contact person. </param>
        /// <param name="emailList"> List of Email-ids to be notified about job progress. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgeOrderAddressContactDetails(string contactName, string phone, string phoneExtension, string mobile, IList<string> emailList, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ContactName = contactName;
            Phone = phone;
            PhoneExtension = phoneExtension;
            Mobile = mobile;
            EmailList = emailList;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EdgeOrderAddressContactDetails"/> for deserialization. </summary>
        internal EdgeOrderAddressContactDetails()
        {
        }

        /// <summary> Contact name of the person. </summary>
        public string ContactName { get; set; }
        /// <summary> Phone number of the contact person. </summary>
        public string Phone { get; set; }
        /// <summary> Phone extension number of the contact person. </summary>
        public string PhoneExtension { get; set; }
        /// <summary> Mobile number of the contact person. </summary>
        public string Mobile { get; set; }
        /// <summary> List of Email-ids to be notified about job progress. </summary>
        public IList<string> EmailList { get; }
    }
}
