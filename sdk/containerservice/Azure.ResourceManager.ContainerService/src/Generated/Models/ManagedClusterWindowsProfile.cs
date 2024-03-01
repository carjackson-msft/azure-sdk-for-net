// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Profile for Windows VMs in the managed cluster. </summary>
    public partial class ManagedClusterWindowsProfile
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

        /// <summary> Initializes a new instance of <see cref="ManagedClusterWindowsProfile"/>. </summary>
        /// <param name="adminUsername"> Specifies the name of the administrator account. &lt;br&gt;&lt;br&gt; **Restriction:** Cannot end in "." &lt;br&gt;&lt;br&gt; **Disallowed values:** "administrator", "admin", "user", "user1", "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console", "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4", "user5". &lt;br&gt;&lt;br&gt; **Minimum-length:** 1 character &lt;br&gt;&lt;br&gt; **Max-length:** 20 characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="adminUsername"/> is null. </exception>
        public ManagedClusterWindowsProfile(string adminUsername)
        {
            if (adminUsername == null)
            {
                throw new ArgumentNullException(nameof(adminUsername));
            }

            AdminUsername = adminUsername;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterWindowsProfile"/>. </summary>
        /// <param name="adminUsername"> Specifies the name of the administrator account. &lt;br&gt;&lt;br&gt; **Restriction:** Cannot end in "." &lt;br&gt;&lt;br&gt; **Disallowed values:** "administrator", "admin", "user", "user1", "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console", "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4", "user5". &lt;br&gt;&lt;br&gt; **Minimum-length:** 1 character &lt;br&gt;&lt;br&gt; **Max-length:** 20 characters. </param>
        /// <param name="adminPassword"> Specifies the password of the administrator account. &lt;br&gt;&lt;br&gt; **Minimum-length:** 8 characters &lt;br&gt;&lt;br&gt; **Max-length:** 123 characters &lt;br&gt;&lt;br&gt; **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled &lt;br&gt; Has lower characters &lt;br&gt;Has upper characters &lt;br&gt; Has a digit &lt;br&gt; Has a special character (Regex match [\W_]) &lt;br&gt;&lt;br&gt; **Disallowed values:** "abc@123", "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1", "Password22", "iloveyou!". </param>
        /// <param name="licenseType"> The license type to use for Windows VMs. See [Azure Hybrid User Benefits](https://azure.microsoft.com/pricing/hybrid-benefit/faq/) for more details. </param>
        /// <param name="isCsiProxyEnabled"> For more details on CSI proxy, see the [CSI proxy GitHub repo](https://github.com/kubernetes-csi/csi-proxy). </param>
        /// <param name="gmsaProfile"> The Windows gMSA Profile in the Managed Cluster. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterWindowsProfile(string adminUsername, string adminPassword, WindowsVmLicenseType? licenseType, bool? isCsiProxyEnabled, WindowsGmsaProfile gmsaProfile, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AdminUsername = adminUsername;
            AdminPassword = adminPassword;
            LicenseType = licenseType;
            IsCsiProxyEnabled = isCsiProxyEnabled;
            GmsaProfile = gmsaProfile;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterWindowsProfile"/> for deserialization. </summary>
        internal ManagedClusterWindowsProfile()
        {
        }

        /// <summary> Specifies the name of the administrator account. &lt;br&gt;&lt;br&gt; **Restriction:** Cannot end in "." &lt;br&gt;&lt;br&gt; **Disallowed values:** "administrator", "admin", "user", "user1", "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console", "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4", "user5". &lt;br&gt;&lt;br&gt; **Minimum-length:** 1 character &lt;br&gt;&lt;br&gt; **Max-length:** 20 characters. </summary>
        public string AdminUsername { get; set; }
        /// <summary> Specifies the password of the administrator account. &lt;br&gt;&lt;br&gt; **Minimum-length:** 8 characters &lt;br&gt;&lt;br&gt; **Max-length:** 123 characters &lt;br&gt;&lt;br&gt; **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled &lt;br&gt; Has lower characters &lt;br&gt;Has upper characters &lt;br&gt; Has a digit &lt;br&gt; Has a special character (Regex match [\W_]) &lt;br&gt;&lt;br&gt; **Disallowed values:** "abc@123", "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1", "Password22", "iloveyou!". </summary>
        public string AdminPassword { get; set; }
        /// <summary> The license type to use for Windows VMs. See [Azure Hybrid User Benefits](https://azure.microsoft.com/pricing/hybrid-benefit/faq/) for more details. </summary>
        public WindowsVmLicenseType? LicenseType { get; set; }
        /// <summary> For more details on CSI proxy, see the [CSI proxy GitHub repo](https://github.com/kubernetes-csi/csi-proxy). </summary>
        public bool? IsCsiProxyEnabled { get; set; }
        /// <summary> The Windows gMSA Profile in the Managed Cluster. </summary>
        public WindowsGmsaProfile GmsaProfile { get; set; }
    }
}
