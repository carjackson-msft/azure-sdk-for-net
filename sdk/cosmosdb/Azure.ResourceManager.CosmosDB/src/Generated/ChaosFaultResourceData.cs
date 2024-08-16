// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing the ChaosFaultResource data model.
    /// A request object to enable/disable the chaos fault
    /// </summary>
    public partial class ChaosFaultResourceData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ChaosFaultResourceData"/>. </summary>
        public ChaosFaultResourceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ChaosFaultResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="action"> Indicates whether what action to take for the Chaos Fault. </param>
        /// <param name="region"> Region of the account where the Chaos Fault is to be enabled/disabled. </param>
        /// <param name="databaseName"> Database name. </param>
        /// <param name="containerName"> Container name. </param>
        /// <param name="provisioningState"> A provisioning state of the Chaos Fault. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChaosFaultResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SupportedAction? action, string region, string databaseName, string containerName, string provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Action = action;
            Region = region;
            DatabaseName = databaseName;
            ContainerName = containerName;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates whether what action to take for the Chaos Fault. </summary>
        [WirePath("properties.action")]
        public SupportedAction? Action { get; set; }
        /// <summary> Region of the account where the Chaos Fault is to be enabled/disabled. </summary>
        [WirePath("properties.region")]
        public string Region { get; set; }
        /// <summary> Database name. </summary>
        [WirePath("properties.databaseName")]
        public string DatabaseName { get; set; }
        /// <summary> Container name. </summary>
        [WirePath("properties.containerName")]
        public string ContainerName { get; set; }
        /// <summary> A provisioning state of the Chaos Fault. </summary>
        [WirePath("properties.provisioningState")]
        public string ProvisioningState { get; }
    }
}
