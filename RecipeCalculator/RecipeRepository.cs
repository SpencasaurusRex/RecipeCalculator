using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

        public TreeNode Breakdown(ItemStack i)
        {
            List<Recipe> itemRecipes = GetRecipesFor(i.Item);
            TreeNode node = new TreeNode(i.ToString());
            if (itemRecipes.Count == 1)
            {
                Recipe recipe = itemRecipes[0];
                foreach (ItemStack ingredient in recipe.Ingredients)
                {
                    TreeNode subNode = Breakdown(ingredient * (i.Number / recipe.Products[0].Number));
                    node.Nodes.Add(subNode);
                }
            }
            return node;
        }
    }
}