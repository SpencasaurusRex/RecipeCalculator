using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeCalculator
{
    class DesignerController
    {
        private ItemRepository items;
        private RecipeRepository recipes;

        public DesignerController(ItemRepository items, RecipeRepository recipes)
        {
            this.items = items;
            this.recipes = recipes;
        }
    }
}
