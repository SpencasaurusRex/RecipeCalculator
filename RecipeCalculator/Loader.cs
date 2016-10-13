using System;

interface Loader
{
    void LoadItems(ItemRepository items);
    void LoadRecipes(ItemRepository items, RecipeRepository recipes);
}