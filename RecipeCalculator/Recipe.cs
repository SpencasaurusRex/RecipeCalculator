using System;

class Recipe
{
    public Item Subject
    {
        get;
    }

    public Item[] Ingredients
    {
        get;
    }

    public Recipe(Item subject, params Item[] ingredients)
    {
        Subject = subject;
        Ingredients = ingredients;
    }
}