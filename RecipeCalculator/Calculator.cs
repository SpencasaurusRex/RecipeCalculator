using System;
using System.Collections.Generic;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting Recipe Calculator");
        new Calculator();
    }
    private ItemRepository items;
    private RecipeRepository recipes;

    public Calculator()
    {
        FactorioCsvLoader loader = new FactorioCsvLoader();
        items = new ItemRepository();
        recipes = new RecipeRepository();
        loader.Load(items, recipes);
        foreach (Recipe r in recipes.GetAll())
        {
            Console.WriteLine(r);
        }
    }
}