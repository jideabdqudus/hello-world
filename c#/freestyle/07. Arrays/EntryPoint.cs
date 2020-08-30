class EntryPoint
{
    static void Main()
    {
        string iAmArray = "array";

        System.Console.WriteLine(iAmArray);
        System.Console.WriteLine(iAmArray[4]);

        string[] iAmStringArray = { "dgdf", "dgdf", "dgfdgd", "vxcvcx", "dasdsa", "gdfgdf", "yryuhn" };

        System.Console.WriteLine(iAmStringArray[3]);

        System.Console.WriteLine(iAmStringArray.Length);
        System.Console.WriteLine(iAmArray.Length);

        int[] integerArray = { 1, 2, 3, 4, 432547 };

        integerArray[3] = 123;
        

    }
}