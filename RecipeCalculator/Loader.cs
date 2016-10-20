using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeCalculator
{
    static class Loader
    {
        public static void Load(out ItemRepository items, out RecipeRepository recipes)
        {
            items = new ItemRepository();
            recipes = new RecipeRepository();
            FactorioCsvLoader.Load(items, recipes);
            LocalizationLoader.Load(items);
        }
    }
}
