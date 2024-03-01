// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Solutions can group tables and functions that are associated with a certain Azure Log Analytics offering. </summary>
    internal partial class MetadataSolution
    {
        /// <summary> Initializes a new instance of <see cref="MetadataSolution"/>. </summary>
        /// <param name="id"> The ID of the Log Analytics solution. </param>
        /// <param name="name"> The name of the Log Analytics solution. </param>
        /// <param name="related"> The related metadata items for the Log Analytics solution. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="name"/> or <paramref name="related"/> is null. </exception>
        internal MetadataSolution(string id, string name, MetadataSolutionRelated related)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (related == null)
            {
                throw new ArgumentNullException(nameof(related));
            }

            Id = id;
            Name = name;
            Related = related;
        }

        /// <summary> Initializes a new instance of <see cref="MetadataSolution"/>. </summary>
        /// <param name="id"> The ID of the Log Analytics solution. </param>
        /// <param name="name"> The name of the Log Analytics solution. </param>
        /// <param name="displayName"> The display name of the Log Analytics solution. </param>
        /// <param name="description"> The description of the Log Analytics solution. </param>
        /// <param name="tags"> The tags that are associated with the Log Analytics solution. </param>
        /// <param name="properties"> The properties of the Log Analytics solution. </param>
        /// <param name="related"> The related metadata items for the Log Analytics solution. </param>
        internal MetadataSolution(string id, string name, string displayName, string description, object tags, object properties, MetadataSolutionRelated related)
        {
            Id = id;
            Name = name;
            DisplayName = displayName;
            Description = description;
            Tags = tags;
            Properties = properties;
            Related = related;
        }

        /// <summary> The ID of the Log Analytics solution. </summary>
        public string Id { get; }
        /// <summary> The name of the Log Analytics solution. </summary>
        public string Name { get; }
        /// <summary> The display name of the Log Analytics solution. </summary>
        public string DisplayName { get; }
        /// <summary> The description of the Log Analytics solution. </summary>
        public string Description { get; }
        /// <summary> The tags that are associated with the Log Analytics solution. </summary>
        public object Tags { get; }
        /// <summary> The properties of the Log Analytics solution. </summary>
        public object Properties { get; }
        /// <summary> The related metadata items for the Log Analytics solution. </summary>
        public MetadataSolutionRelated Related { get; }
    }
}
