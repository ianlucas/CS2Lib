/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Ian Lucas. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System.Runtime.CompilerServices;

namespace CS2Lib.SwiftlyCS2.Core;

public static class UnsafeHelpers
{
    public static TTo ViewAs<TFrom, TTo>(TFrom value)
        where TFrom : unmanaged
        where TTo : unmanaged
    {
        if (Unsafe.SizeOf<TFrom>() != Unsafe.SizeOf<TTo>())
        {
            throw new ArgumentException(
                $"Size mismatch: {typeof(TFrom).Name} is {Unsafe.SizeOf<TFrom>()} bytes, "
                    + $"but {typeof(TTo).Name} is {Unsafe.SizeOf<TTo>()} bytes"
            );
        }

        return Unsafe.As<TFrom, TTo>(ref value);
    }
}
