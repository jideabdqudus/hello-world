class EntryPoint
{
    static void Main()
    {
        int someCrazyNumber = 4536334;
        System.Console.WriteLine(someCrazyNumber);
        System.Console.WriteLine(someCrazyNumber.GetType());

        string theNumberWasStringed = someCrazyNumber.ToString();
        System.Console.WriteLine(theNumberWasStringed);
        System.Console.WriteLine(theNumberWasStringed.GetType());
        System.Console.WriteLine(theNumberWasStringed[3]);

        bool theTrue = true;

        System.Console.WriteLine(theTrue.ToString()[2]);
    }
}