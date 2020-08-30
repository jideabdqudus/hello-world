using System;

class EntryPoint
{
    static void Main()
    {
        // int type holds 32bit numbers

        int someInteger = 5;

        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);

        uint someUInteger = 1; // unsigned int

        Console.WriteLine(uint.MinValue);
        Console.WriteLine(uint.MaxValue);

        // byte type holds 8bit numbers

        byte someByte = 255; // from 0 to 255

        sbyte negativeByte = -1; // signed byte -128 to 127

        Console.WriteLine(byte.MinValue);
        Console.WriteLine(byte.MaxValue);
        Console.WriteLine(sbyte.MinValue);
        Console.WriteLine(sbyte.MaxValue);

        // long type holds 64bit numbers

        long someVeryLongNumber = 34556758675455;

        Console.WriteLine(long.MinValue);
        Console.WriteLine(long.MaxValue);

        ulong noNegativeLongNumbers = 0;

        Console.WriteLine(ulong.MinValue);
        Console.WriteLine(ulong.MaxValue);


    }
}