// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> Parameters for a Redis Enterprise import operation. </summary>
    public partial class ImportRedisEnterpriseDatabaseContent
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

        /// <summary> Initializes a new instance of <see cref="ImportRedisEnterpriseDatabaseContent"/>. </summary>
        /// <param name="sasUris"> SAS URIs for the target blobs to import from. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sasUris"/> is null. </exception>
        public ImportRedisEnterpriseDatabaseContent(IEnumerable<Uri> sasUris)
        {
            if (sasUris == null)
            {
                throw new ArgumentNullException(nameof(sasUris));
            }

            SasUris = sasUris.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ImportRedisEnterpriseDatabaseContent"/>. </summary>
        /// <param name="sasUris"> SAS URIs for the target blobs to import from. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ImportRedisEnterpriseDatabaseContent(IList<Uri> sasUris, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SasUris = sasUris;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ImportRedisEnterpriseDatabaseContent"/> for deserialization. </summary>
        internal ImportRedisEnterpriseDatabaseContent()
        {
        }

        /// <summary> SAS URIs for the target blobs to import from. </summary>
        public IList<Uri> SasUris { get; }
    }
}
