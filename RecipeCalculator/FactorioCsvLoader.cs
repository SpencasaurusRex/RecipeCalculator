using System;
using System.IO;
using System.Collections.Generic;

class FactorioCsvLoader : Loader
{
    public void Load(ItemRepository items, RecipeRepository recipes)
    {
        Item.Repository = items;
        Recipe.Repository = recipes;
        try
        {
            using (StreamReader sr = new StreamReader("../../../resources/recipes.csv"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] tokens = line.Split(',');
                    if (tokens.Length != 4)
                    {
                        Console.Error.WriteLine("Invalid line in CSV file: \"{0}\"", line);
                        Done();
                        return;
                    }
                    string product = tokens[0];
                    float productAmount = (float)Convert.ToDouble(tokens[1]);
                    string ingredient = tokens[2];
                    float amount = (float)Convert.ToDouble(tokens[3]);
                    LoadRecipe(product, productAmount, ingredient, amount);
                }
            }
        }
        catch (FileNotFoundException e)
        {
            Console.Error.WriteLine("Couldnt find file: " + e.FileName);
        }
        catch (Exception e)
        {
            Console.Error.WriteLine("Error while loading recipes:\n" + e.Message);
        }
        Done();
    }

    private void LoadRecipe(string product, float pcount, string ingredient, float icount)
    {
        Recipe r = GetRecipe(product, pcount);
        Item ingredients = GetItem(ingredient);
        r.AddIngredients(ingredients * icount);
    }

    private Recipe GetRecipe(string name, float pcount)
    {
        Item product = GetItem(name);
        List<Recipe> recipes = Recipe.Repository.GetRecipesFor(product);
        if (recipes.Count == 0)
        {
            return new Recipe(product * pcount);
        }
        else if (recipes.Count == 1)
        {
            return recipes[0];
        }
        else
        {
            Console.Error.WriteLine("Duplicate recipes detected for " + product.Name);
            return null;
        }
    }

    private Item GetItem(string name)
    {
        Item existingItem;
        if (Item.Repository.Get(name, out existingItem))
        {
            return existingItem;
        }
        return new Item(name);
    }

    private void Done()
    {
        Item.Repository = null;
        Recipe.Repository = null;
    }
}
