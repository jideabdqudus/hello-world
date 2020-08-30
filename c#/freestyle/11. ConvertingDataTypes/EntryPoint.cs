using System;

class EntryPoint
{
    // Type Casting, Converting, Parsing

    static void Main()
    {
        int number = 5;
        string word = null;
        char x = '5';
        float floating = 3.14F;

        int someInt = (int)floating;

        string convertedChar = x.ToString();

        number = Convert.ToInt32(word);

        Console.WriteLine(number);
    }
}
