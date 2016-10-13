using System;

class Recipe
{
    public static RecipeRepository Repository
    {
        set;
        get;
    }

    public ItemStack[] Products
    {
        get;
    }

    public ItemStack[] Ingredients
    {
        get;
    }

    public Recipe(Item product, params ItemStack[] ingredients) : this(product * 1, ingredients)
    {
    }

    public Recipe(ItemStack product, params ItemStack[] ingredients) : this(new ItemStack[] { product }, ingredients)
    {
    }

    public Recipe(ItemStack[] products, params ItemStack[] ingredients)
    {
        Products = products;
        Ingredients = ingredients;
        if (Repository != null)
        {
            Repository.Add(this);
        }
    }

    public override string ToString()
    {
        string buffer = "Products:\r\n";
        foreach (ItemStack product in Products)
        {
            buffer += "\t" + product.ToString() + "\r\n";
        }
        buffer += "Ingredients:\r\n";
        foreach (ItemStack ingredient in Ingredients)
        {
            buffer += "\t" + ingredient.ToString() + "\r\n";
        }
        return buffer;
    }
}