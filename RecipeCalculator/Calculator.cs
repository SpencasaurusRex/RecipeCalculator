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
        FactorioHardLoader loader = new FactorioHardLoader();
        items = new ItemRepository();
        recipes = new RecipeRepository();

        loader.Load(items, recipes);

        Item gear = items.Get("Iron Gear Wheel");
        List<Recipe> r = recipes.GetRecipesFor(gear);
        Console.WriteLine(r[0].ToString());
    }
}