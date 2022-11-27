// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable enable

using System;
using System.Collections.Generic;
using Microsoft.Data.Analysis;
using Microsoft.ML.Data;

namespace Microsoft.ML
{
    public static class DataViewSchemaExtensions
    {
        public static IEnumerable<DataFrameColumn> ToDataFrameColumns(this DataViewSchema schema, bool includesHidden = false, ISet<string>? selectColumns = null)
        {
			List<DataFrameColumn> dataFrameColumns = new(schema.Count);
			foreach (var column in schema)
            {
				if (!includesHidden && column.IsHidden || selectColumns != null && !selectColumns.Contains(column.Name))
                {
					continue;
				}
				dataFrameColumns.Add(column.Type.CreateDataFrameColumn(column.Name));
			}
			return dataFrameColumns;
		}
    }
}