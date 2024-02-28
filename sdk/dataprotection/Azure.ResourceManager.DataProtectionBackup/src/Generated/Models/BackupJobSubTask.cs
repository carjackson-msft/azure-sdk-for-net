// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Details of Job's Sub Task. </summary>
    public partial class BackupJobSubTask
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

        /// <summary> Initializes a new instance of <see cref="BackupJobSubTask"/>. </summary>
        /// <param name="taskId"> Task Id of the Sub Task. </param>
        /// <param name="taskName"> Name of the Sub Task. </param>
        /// <param name="taskStatus"> Status of the Sub Task. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> or <paramref name="taskStatus"/> is null. </exception>
        internal BackupJobSubTask(int taskId, string taskName, string taskStatus)
        {
            if (taskName == null)
            {
                throw new ArgumentNullException(nameof(taskName));
            }
            if (taskStatus == null)
            {
                throw new ArgumentNullException(nameof(taskStatus));
            }

            AdditionalDetails = new ChangeTrackingDictionary<string, string>();
            TaskId = taskId;
            TaskName = taskName;
            TaskStatus = taskStatus;
        }

        /// <summary> Initializes a new instance of <see cref="BackupJobSubTask"/>. </summary>
        /// <param name="additionalDetails"> Additional details of Sub Tasks. </param>
        /// <param name="taskId"> Task Id of the Sub Task. </param>
        /// <param name="taskName"> Name of the Sub Task. </param>
        /// <param name="taskProgress"> Progress of the Sub Task. </param>
        /// <param name="taskStatus"> Status of the Sub Task. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupJobSubTask(IReadOnlyDictionary<string, string> additionalDetails, int taskId, string taskName, string taskProgress, string taskStatus, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AdditionalDetails = additionalDetails;
            TaskId = taskId;
            TaskName = taskName;
            TaskProgress = taskProgress;
            TaskStatus = taskStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BackupJobSubTask"/> for deserialization. </summary>
        internal BackupJobSubTask()
        {
        }

        /// <summary> Additional details of Sub Tasks. </summary>
        public IReadOnlyDictionary<string, string> AdditionalDetails { get; }
        /// <summary> Task Id of the Sub Task. </summary>
        public int TaskId { get; }
        /// <summary> Name of the Sub Task. </summary>
        public string TaskName { get; }
        /// <summary> Progress of the Sub Task. </summary>
        public string TaskProgress { get; }
        /// <summary> Status of the Sub Task. </summary>
        public string TaskStatus { get; }
    }
}
