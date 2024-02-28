// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Identity provider input. </summary>
    public partial class IdentityProviderContent
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

        /// <summary> Initializes a new instance of <see cref="IdentityProviderContent"/>. </summary>
        /// <param name="tenantId"> The tenant Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services. </param>
        /// <param name="applicationId"> The application/client Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services. </param>
        /// <param name="objectId"> The object Id of the service principal with which the on-premise management/data plane components would communicate with our Azure services. </param>
        /// <param name="audience"> The intended Audience of the service principal with which the on-premise management/data plane components would communicate with our Azure services. </param>
        /// <param name="aadAuthority"> The base authority for Azure Active Directory authentication. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/>, <paramref name="objectId"/>, <paramref name="audience"/> or <paramref name="aadAuthority"/> is null. </exception>
        public IdentityProviderContent(Guid tenantId, string applicationId, string objectId, string audience, string aadAuthority)
        {
            if (applicationId == null)
            {
                throw new ArgumentNullException(nameof(applicationId));
            }
            if (objectId == null)
            {
                throw new ArgumentNullException(nameof(objectId));
            }
            if (audience == null)
            {
                throw new ArgumentNullException(nameof(audience));
            }
            if (aadAuthority == null)
            {
                throw new ArgumentNullException(nameof(aadAuthority));
            }

            TenantId = tenantId;
            ApplicationId = applicationId;
            ObjectId = objectId;
            Audience = audience;
            AadAuthority = aadAuthority;
        }

        /// <summary> Initializes a new instance of <see cref="IdentityProviderContent"/>. </summary>
        /// <param name="tenantId"> The tenant Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services. </param>
        /// <param name="applicationId"> The application/client Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services. </param>
        /// <param name="objectId"> The object Id of the service principal with which the on-premise management/data plane components would communicate with our Azure services. </param>
        /// <param name="audience"> The intended Audience of the service principal with which the on-premise management/data plane components would communicate with our Azure services. </param>
        /// <param name="aadAuthority"> The base authority for Azure Active Directory authentication. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IdentityProviderContent(Guid tenantId, string applicationId, string objectId, string audience, string aadAuthority, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TenantId = tenantId;
            ApplicationId = applicationId;
            ObjectId = objectId;
            Audience = audience;
            AadAuthority = aadAuthority;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IdentityProviderContent"/> for deserialization. </summary>
        internal IdentityProviderContent()
        {
        }

        /// <summary> The tenant Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services. </summary>
        public Guid TenantId { get; }
        /// <summary> The application/client Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services. </summary>
        public string ApplicationId { get; }
        /// <summary> The object Id of the service principal with which the on-premise management/data plane components would communicate with our Azure services. </summary>
        public string ObjectId { get; }
        /// <summary> The intended Audience of the service principal with which the on-premise management/data plane components would communicate with our Azure services. </summary>
        public string Audience { get; }
        /// <summary> The base authority for Azure Active Directory authentication. </summary>
        public string AadAuthority { get; }
    }
}
