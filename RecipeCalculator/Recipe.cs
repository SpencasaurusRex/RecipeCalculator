using System;

class Recipe
{
    public Item[] Products
    {
        get;
    }

    public Item[] Ingredients
    {
        get;
    }

    public Recipe(Item product, params Item[] ingredients) : this(new Item[] { product }, ingredients)
    {
    }

    public Recipe(Item[] products, params Item[] ingredients)
    {
        Products = products;
        Ingredients = ingredients;
    }
}