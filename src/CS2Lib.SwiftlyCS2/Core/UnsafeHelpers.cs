/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Ian Lucas. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System.Runtime.CompilerServices;

namespace CS2Lib.SwiftlyCS2.Core;

/// <summary>
/// Provides low-level unsafe memory operations for type reinterpretation.
/// </summary>
public static class UnsafeHelpers
{
    /// <summary>
    /// Reinterprets a value of one unmanaged type as another unmanaged type with the same size.
    /// </summary>
    /// <typeparam name="TFrom">The source type to convert from.</typeparam>
    /// <typeparam name="TTo">The target type to convert to.</typeparam>
    /// <param name="value">The value to reinterpret.</param>
    /// <returns>The value reinterpreted as the target type.</returns>
    /// <exception cref="ArgumentException">Thrown when the sizes of TFrom and TTo do not match.</exception>
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
