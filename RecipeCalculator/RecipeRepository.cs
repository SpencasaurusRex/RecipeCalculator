using System;
using System.Collections.Generic;

namespace RecipeCalculator
{
    class RecipeRepository
    {
        private List<Recipe> recipes;
        public static RecipeRepository Repository
        {
            set;
            get;
        }

        public RecipeRepository()
        {
            recipes = new List<Recipe>();
        }

        public void Add(Recipe r)
        {
            recipes.Add(r);
        }

        public List<Recipe> GetRecipesFor(Item item)
        {
            List<Recipe> validRecipes = new List<Recipe>();
            foreach (Recipe r in recipes)
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

        public Recipe[] GetAll()
        {
            return recipes.ToArray();
        }
    }
}