
using System;

class EntryPoint
{
    static void Main()
    {
        string firstString = "C# Course";
        string secondString = "for Beginners";
        string freeSpace = " ";
        //Console.WriteLine(firstString);
        //Console.WriteLine(secondString);

        //concatenation

        Console.WriteLine("I am taking my first " + firstString + freeSpace + secondString + " and I am really happy with what I am learning.");
        Console.WriteLine("I am taking my first {0}{1}{2} and I am really happy with what I am learning.", firstString, freeSpace, secondString);

        string number = "5.34";

        double numb = Convert.ToDouble(number);

        Console.WriteLine(numb);
        Console.WriteLine(numb.GetType());
    }
}