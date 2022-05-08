﻿using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.SByteConditionHelpers.NegativeHelpers;

public sealed class IsNegative_Condition_Helper_Tests
{
    [Fact]
    public void IsNegative_ReturnsTrue_WhenNumberIsNegative()
    {
        sbyte numberToTest = -1;

        bool result = numberToTest.IsNegative();

        Assert.True(result);
    }

    [Fact]
    public void IsNegative_ReturnsFalse_WhenNumberIsPositive()
    {
        sbyte numberToTest = 1;

        bool result = numberToTest.IsNegative();

        Assert.False(result);
    }
}
