// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Describes the connection monitor test group. </summary>
    public partial class ConnectionMonitorTestGroup
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

        /// <summary> Initializes a new instance of <see cref="ConnectionMonitorTestGroup"/>. </summary>
        /// <param name="name"> The name of the connection monitor test group. </param>
        /// <param name="testConfigurations"> List of test configuration names. </param>
        /// <param name="sources"> List of source endpoint names. </param>
        /// <param name="destinations"> List of destination endpoint names. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="testConfigurations"/>, <paramref name="sources"/> or <paramref name="destinations"/> is null. </exception>
        public ConnectionMonitorTestGroup(string name, IEnumerable<string> testConfigurations, IEnumerable<string> sources, IEnumerable<string> destinations)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (testConfigurations == null)
            {
                throw new ArgumentNullException(nameof(testConfigurations));
            }
            if (sources == null)
            {
                throw new ArgumentNullException(nameof(sources));
            }
            if (destinations == null)
            {
                throw new ArgumentNullException(nameof(destinations));
            }

            Name = name;
            TestConfigurations = testConfigurations.ToList();
            Sources = sources.ToList();
            Destinations = destinations.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionMonitorTestGroup"/>. </summary>
        /// <param name="name"> The name of the connection monitor test group. </param>
        /// <param name="disable"> Value indicating whether test group is disabled. </param>
        /// <param name="testConfigurations"> List of test configuration names. </param>
        /// <param name="sources"> List of source endpoint names. </param>
        /// <param name="destinations"> List of destination endpoint names. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectionMonitorTestGroup(string name, bool? disable, IList<string> testConfigurations, IList<string> sources, IList<string> destinations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Disable = disable;
            TestConfigurations = testConfigurations;
            Sources = sources;
            Destinations = destinations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionMonitorTestGroup"/> for deserialization. </summary>
        internal ConnectionMonitorTestGroup()
        {
        }

        /// <summary> The name of the connection monitor test group. </summary>
        public string Name { get; set; }
        /// <summary> Value indicating whether test group is disabled. </summary>
        public bool? Disable { get; set; }
        /// <summary> List of test configuration names. </summary>
        public IList<string> TestConfigurations { get; }
        /// <summary> List of source endpoint names. </summary>
        public IList<string> Sources { get; }
        /// <summary> List of destination endpoint names. </summary>
        public IList<string> Destinations { get; }
    }
}
