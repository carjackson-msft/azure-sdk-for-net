// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Attestation.Models
{
    /// <summary> Parameters for creating an attestation provider. </summary>
    public partial class AttestationProviderCreateOrUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="AttestationProviderCreateOrUpdateContent"/>. </summary>
        /// <param name="location"> The supported Azure location where the attestation provider should be created. </param>
        /// <param name="properties"> Properties of the attestation provider. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public AttestationProviderCreateOrUpdateContent(AzureLocation location, AttestationServiceCreationSpecificParams properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Location = location;
            Tags = new ChangeTrackingDictionary<string, string>();
            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="AttestationProviderCreateOrUpdateContent"/>. </summary>
        /// <param name="location"> The supported Azure location where the attestation provider should be created. </param>
        /// <param name="tags"> The tags that will be assigned to the attestation provider. </param>
        /// <param name="properties"> Properties of the attestation provider. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AttestationProviderCreateOrUpdateContent(AzureLocation location, IDictionary<string, string> tags, AttestationServiceCreationSpecificParams properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Location = location;
            Tags = tags;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AttestationProviderCreateOrUpdateContent"/> for deserialization. </summary>
        internal AttestationProviderCreateOrUpdateContent()
        {
        }

        /// <summary> The supported Azure location where the attestation provider should be created. </summary>
        public AzureLocation Location { get; }
        /// <summary> The tags that will be assigned to the attestation provider. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Properties of the attestation provider. </summary>
        public AttestationServiceCreationSpecificParams Properties { get; }
    }
}
