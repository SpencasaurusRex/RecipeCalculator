using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RecipeCalculator
{
    class BreakdownController
    {
        private TreeView view;
        private ItemRepository items;
        private RecipeRepository recipes;

        public BreakdownController(TreeView view)
        {
            this.view = view;
            Loader.Load(out items, out recipes);
            Item i;
            if (items.Get("electronic-circuit", out i))
            {
                try
                {
                    view.Nodes.Add(recipes.Breakdown(i * 1));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went terrible wrong");
                }
            }
            else
            {
                Console.WriteLine("Could not find electronic circuit");
            }
        }
    }
}
