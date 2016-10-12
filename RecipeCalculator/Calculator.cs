using System;
class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting Recipe Calculator");
        new ItemRepository(new Item("Test Item"));
    }
}