﻿namespace Nilgon.Condition.Helpers;

public static partial class UInt64ConditionHelpers
{
    /// <summary>
    ///    Checks if the <paramref name="value" /> is zero.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    ///    <see langword="true" /> if the <paramref name="value"/> is zero; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsZero(this ulong value)
    {
        bool conditionResult = value == 0;

        return conditionResult;
    }

    /// <summary>
    ///    Checks if the <paramref name="value" /> is not zero.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    ///    <see langword="true" /> if the <paramref name="value"/> is not zero; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsNotZero(this ulong value)
    {
        bool conditionResult = value != 0;

        return conditionResult;
    }
}
