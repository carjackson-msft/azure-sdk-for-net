// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary>
    /// A record of a call to a function tool, issued by the model in evaluation of a defined tool, that represents the inputs
    /// and output consumed and emitted by the specified function.
    /// </summary>
    public partial class RunStepFunctionToolCall : RunStepToolCall
    {
        /// <summary> Initializes a new instance of <see cref="RunStepFunctionToolCall"/>. </summary>
        /// <param name="id"> The ID of the tool call. This ID must be referenced when you submit tool outputs. </param>
        /// <param name="internalDetails"> The detailed information about the function called by the model. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="internalDetails"/> is null. </exception>
        internal RunStepFunctionToolCall(string id, InternalRunStepFunctionToolCallDetails internalDetails) : base(id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (internalDetails == null)
            {
                throw new ArgumentNullException(nameof(internalDetails));
            }

            Type = "function";
            InternalDetails = internalDetails;
        }

        /// <summary> Initializes a new instance of <see cref="RunStepFunctionToolCall"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="id"> The ID of the tool call. This ID must be referenced when you submit tool outputs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="internalDetails"> The detailed information about the function called by the model. </param>
        internal RunStepFunctionToolCall(string type, string id, IDictionary<string, BinaryData> serializedAdditionalRawData, InternalRunStepFunctionToolCallDetails internalDetails) : base(type, id, serializedAdditionalRawData)
        {
            InternalDetails = internalDetails;
        }

        /// <summary> Initializes a new instance of <see cref="RunStepFunctionToolCall"/> for deserialization. </summary>
        internal RunStepFunctionToolCall()
        {
        }
    }
}
