using System;
class Calculator
{
    private ItemRepository _itemRepo;

    static void Main(string[] args)
    {
        Console.WriteLine("Starting Recipe Calculator");
        new Calculator();
    }

    public Calculator()
    {
        _itemRepo = new ItemRepository();
    }
}