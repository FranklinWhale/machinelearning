// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable enable

using System;
using Microsoft.Data.Analysis;

namespace Microsoft.ML.Data
{
    public static class DataViewTypeExtensions
    {
        public static DataFrameColumn CreateDataFrameColumn(this DataViewType type, string columnName)
        {
            if (type == BooleanDataViewType.Instance)
            {
                return new BooleanDataFrameColumn(columnName);
            }
            if (type == DateTimeDataViewType.Instance)
            {
                return new DateTimeDataFrameColumn(columnName);
            }
            if (type == NumberDataViewType.Byte)
            {
                return new ByteDataFrameColumn(columnName);
            }
            if (type == NumberDataViewType.Double)
            {
                return new DoubleDataFrameColumn(columnName);
            }
            if (type == NumberDataViewType.Single)
            {
                return new SingleDataFrameColumn(columnName);
            }
            if (type == NumberDataViewType.Int32)
            {
                return new Int32DataFrameColumn(columnName);
            }
            if (type == NumberDataViewType.Int64)
            {
                return new Int64DataFrameColumn(columnName);
            }
            if (type == NumberDataViewType.SByte)
            {
                return new SByteDataFrameColumn(columnName);
            }
            if (type == NumberDataViewType.Int16)
            {
                return new Int16DataFrameColumn(columnName);
            }
            if (type == NumberDataViewType.UInt32)
            {
                return new UInt32DataFrameColumn(columnName);
            }
            if (type == NumberDataViewType.UInt64)
            {
                return new UInt64DataFrameColumn(columnName);
            }
            if (type == NumberDataViewType.UInt16)
            {
                return new UInt16DataFrameColumn(columnName);
            }
            if (type == TextDataViewType.Instance)
            {
                return new StringDataFrameColumn(columnName);
            }
            throw new NotSupportedException(String.Format(Microsoft.Data.Strings.NotSupportedColumnType, type.RawType.Name));
        }
    }
}