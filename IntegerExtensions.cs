﻿public static class IntegerExtensions
{
    public static bool IsOdd(this int number)
    {
        return number % 2 != 0;
    }

    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }
}
