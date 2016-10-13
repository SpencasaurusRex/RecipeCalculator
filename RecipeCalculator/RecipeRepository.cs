using System;
using System.Collections.Generic;

class RecipeRepository
{
    private List<Recipe> _recipes;

    public RecipeRepository()
    {
        _recipes = new List<Recipe>();
    }

    public void Add(Recipe r)
    {
        _recipes.Add(r);
    }
}