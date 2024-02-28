// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Bgp Communities sent over ExpressRoute with each route corresponding to a prefix in this VNET. </summary>
    public partial class VirtualNetworkBgpCommunities
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

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkBgpCommunities"/>. </summary>
        /// <param name="virtualNetworkCommunity"> The BGP community associated with the virtual network. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkCommunity"/> is null. </exception>
        public VirtualNetworkBgpCommunities(string virtualNetworkCommunity)
        {
            if (virtualNetworkCommunity == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkCommunity));
            }

            VirtualNetworkCommunity = virtualNetworkCommunity;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkBgpCommunities"/>. </summary>
        /// <param name="virtualNetworkCommunity"> The BGP community associated with the virtual network. </param>
        /// <param name="regionalCommunity"> The BGP community associated with the region of the virtual network. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualNetworkBgpCommunities(string virtualNetworkCommunity, string regionalCommunity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VirtualNetworkCommunity = virtualNetworkCommunity;
            RegionalCommunity = regionalCommunity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkBgpCommunities"/> for deserialization. </summary>
        internal VirtualNetworkBgpCommunities()
        {
        }

        /// <summary> The BGP community associated with the virtual network. </summary>
        public string VirtualNetworkCommunity { get; set; }
        /// <summary> The BGP community associated with the region of the virtual network. </summary>
        public string RegionalCommunity { get; }
    }
}
