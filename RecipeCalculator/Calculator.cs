using System;
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
        loader.LoadItems(items);
        loader.LoadRecipes(items, recipes);
    }
}