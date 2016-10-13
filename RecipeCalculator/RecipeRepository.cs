using System;
using System.Collections.Generic;

class RecipeRepository
{
    private List<Recipe> _recipes;
    public static RecipeRepository Repository
    {
        set;
        get;
    }

    public RecipeRepository()
    {
        _recipes = new List<Recipe>();
    }

    public void Add(Recipe r)
    {
        _recipes.Add(r);
    }

    public List<Recipe> GetRecipesFor(Item item)
    {
        List<Recipe> validRecipes = new List<Recipe>();
        foreach (Recipe r in _recipes)
        {
            foreach (ItemStack items in r.Products)
            {
                if (items.Item == item)
                {
                    validRecipes.Add(r);
                }
            }
        }
        return validRecipes;
    }
}