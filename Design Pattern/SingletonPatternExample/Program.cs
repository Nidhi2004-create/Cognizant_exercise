using System;

class Program
{
    static void Main()
    {
        Logger l1 = Logger.GetInstance();
        l1.Log("Hello First");

        Logger l2 = Logger.GetInstance();
        l2.Log("Hello Second");

        Console.WriteLine(l1 == l2);
    }
}