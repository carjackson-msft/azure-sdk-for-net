// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary>
    /// Factory's git repo information.
    /// Please note <see cref="FactoryRepoConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="FactoryGitHubConfiguration"/> and <see cref="FactoryVstsConfiguration"/>.
    /// </summary>
    public abstract partial class FactoryRepoConfiguration
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FactoryRepoConfiguration"/>. </summary>
        /// <param name="accountName"> Account name. </param>
        /// <param name="repositoryName"> Repository name. </param>
        /// <param name="collaborationBranch"> Collaboration branch. </param>
        /// <param name="rootFolder"> Root folder. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/>, <paramref name="repositoryName"/>, <paramref name="collaborationBranch"/> or <paramref name="rootFolder"/> is null. </exception>
        protected FactoryRepoConfiguration(string accountName, string repositoryName, string collaborationBranch, string rootFolder)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (repositoryName == null)
            {
                throw new ArgumentNullException(nameof(repositoryName));
            }
            if (collaborationBranch == null)
            {
                throw new ArgumentNullException(nameof(collaborationBranch));
            }
            if (rootFolder == null)
            {
                throw new ArgumentNullException(nameof(rootFolder));
            }

            AccountName = accountName;
            RepositoryName = repositoryName;
            CollaborationBranch = collaborationBranch;
            RootFolder = rootFolder;
        }

        /// <summary> Initializes a new instance of <see cref="FactoryRepoConfiguration"/>. </summary>
        /// <param name="factoryRepoConfigurationType"> Type of repo configuration. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="repositoryName"> Repository name. </param>
        /// <param name="collaborationBranch"> Collaboration branch. </param>
        /// <param name="rootFolder"> Root folder. </param>
        /// <param name="lastCommitId"> Last commit id. </param>
        /// <param name="disablePublish"> Disable manual publish operation in ADF studio to favor automated publish. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FactoryRepoConfiguration(string factoryRepoConfigurationType, string accountName, string repositoryName, string collaborationBranch, string rootFolder, string lastCommitId, bool? disablePublish, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FactoryRepoConfigurationType = factoryRepoConfigurationType;
            AccountName = accountName;
            RepositoryName = repositoryName;
            CollaborationBranch = collaborationBranch;
            RootFolder = rootFolder;
            LastCommitId = lastCommitId;
            DisablePublish = disablePublish;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FactoryRepoConfiguration"/> for deserialization. </summary>
        internal FactoryRepoConfiguration()
        {
        }

        /// <summary> Type of repo configuration. </summary>
        internal string FactoryRepoConfigurationType { get; set; }
        /// <summary> Account name. </summary>
        public string AccountName { get; set; }
        /// <summary> Repository name. </summary>
        public string RepositoryName { get; set; }
        /// <summary> Collaboration branch. </summary>
        public string CollaborationBranch { get; set; }
        /// <summary> Root folder. </summary>
        public string RootFolder { get; set; }
        /// <summary> Last commit id. </summary>
        public string LastCommitId { get; set; }
        /// <summary> Disable manual publish operation in ADF studio to favor automated publish. </summary>
        public bool? DisablePublish { get; set; }
    }
}
