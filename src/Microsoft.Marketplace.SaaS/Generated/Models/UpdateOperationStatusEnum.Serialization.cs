// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.Marketplace.SaaS.Models
{
    internal static partial class UpdateOperationStatusEnumExtensions
    {
        public static string ToSerialString(this UpdateOperationStatusEnum value) => value switch
        {
            UpdateOperationStatusEnum.Success => "Success",
            UpdateOperationStatusEnum.Failure => "Failure",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown UpdateOperationStatusEnum value.")
        };

        public static UpdateOperationStatusEnum ToUpdateOperationStatusEnum(this string value)
        {
            if (string.Equals(value, "Success", StringComparison.InvariantCultureIgnoreCase)) return UpdateOperationStatusEnum.Success;
            if (string.Equals(value, "Failure", StringComparison.InvariantCultureIgnoreCase)) return UpdateOperationStatusEnum.Failure;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown UpdateOperationStatusEnum value.");
        }
    }
}
