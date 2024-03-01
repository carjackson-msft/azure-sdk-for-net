// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Contains the tables, columns &amp; rows resulting from a query. </summary>
    public partial class LogsBatchQueryResult : LogsQueryResult
    {
        /// <summary> Initializes a new instance of <see cref="LogsBatchQueryResult"/>. </summary>
        /// <param name="allTables"> The results of the query in tabular format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="allTables"/> is null. </exception>
        internal LogsBatchQueryResult(IEnumerable<LogsTable> allTables) : base(allTables)
        {
            if (allTables == null)
            {
                throw new ArgumentNullException(nameof(allTables));
            }
        }

        /// <summary> Initializes a new instance of <see cref="LogsBatchQueryResult"/>. </summary>
        /// <param name="allTables"> The results of the query in tabular format. </param>
        /// <param name="statistics"> Any object. </param>
        /// <param name="visualization"> Any object. </param>
        /// <param name="error"> Any object. </param>
        internal LogsBatchQueryResult(IReadOnlyList<LogsTable> allTables, JsonElement statistics, JsonElement visualization, JsonElement error) : base(allTables, statistics, visualization, error)
        {
        }
    }
}
