using System;
using System.Collections.Generic;

namespace RecipeCalculator
{
    class Recipe
    {
        public static RecipeRepository Repository
        {
            set;
            get;
        }

        private List<ItemStack> products;
        private List<ItemStack> ingredients;

        public ItemStack[] Products
        {
            get { return products.ToArray(); }
        }

        public ItemStack[] Ingredients
        {
            get { return ingredients.ToArray(); }
        }

        public Recipe(Item product, params ItemStack[] ingredients) : this(product * 1, ingredients)
        {
        }

        public Recipe(ItemStack product, params ItemStack[] ingredients) : this(new ItemStack[] { product }, ingredients)
        {
        }

        public Recipe(ItemStack[] products, params ItemStack[] ingredients)
        {
            this.products = new List<ItemStack>();
            this.ingredients = new List<ItemStack>();

            foreach (ItemStack i in products)
            {
                AddProduct(i);
            }
            foreach (ItemStack i in ingredients)
            {
                AddIngredients(i);
            }
            if (Repository != null)
            {
                Repository.Add(this);
            }
        }

        public void AddIngredients(ItemStack ingredients)
        {
            foreach (ItemStack i in this.ingredients)
            {
                if (i.Item == ingredients.Item)
                {
                    Console.Error.WriteLine("WARNING: The following recipe was given duplicate ingredient: " + ingredients.Item.Name + "\n" + this);
                    i.Number += ingredients.Number;
                    return;
                }
            }
            this.ingredients.Add(ingredients);
        }

        public override string ToString()
        {
            string buffer = "Products:\r\n";
            foreach (ItemStack product in products)
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

        private void AddProduct(ItemStack product)
        {
            foreach (ItemStack i in this.products)
            {
                if (i.Item == product.Item)
                {
                    i.Number += product.Number;
                    return;
                }
            }
            this.products.Add(product);
        }
    }
}