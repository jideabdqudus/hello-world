using System;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        string theBox = "I am inside the box";

        // A variable has three things, it has: Data Type, Name and Value
        // aLotOfWordsInIt
        // tomAndJerry

        int number = 3;

        char lonelySymbol = 'd';

        bool isAlive = false;

        float pi = 3.14f;

        object piSecond = 3.14f;

        Console.WriteLine(theBox);

        number = number + 1;
        Thread.Sleep(5000);
        Console.WriteLine("The number integer variable has the number: " + number);
    }
}