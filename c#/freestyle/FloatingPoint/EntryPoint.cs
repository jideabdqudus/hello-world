﻿using System;

class EntryPoint
{
    static void Main()
    {
        //float can hold up to 32bit 7 digit precision

        float someFloatingPointNumber = 1.5f;

        Console.WriteLine(float.MinValue);
        Console.WriteLine(float.MaxValue);

        //double 64bits, 15 to 16 digit precision

        double someDoublePointNumber = 2.5d;

        Console.WriteLine(double.MinValue);
        Console.WriteLine(double.MaxValue);

        //decimal 128bits, 28 to 29 digits of precision

        decimal decimalNumber = 2.0m;

        Console.WriteLine(decimal.MinValue);
        Console.WriteLine(long.MinValue);
        Console.WriteLine(decimal.MaxValue);
        Console.WriteLine(long.MaxValue);
    }
}