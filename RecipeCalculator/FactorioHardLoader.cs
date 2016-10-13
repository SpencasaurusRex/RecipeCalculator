using System;

class FactorioHardLoader : Loader
{
    public void LoadItems(ItemRepository items)
    {
        items.Add(new Item("Iron Plate"));
        items.Add(new Item("Copper Plate"));
        items.Add(new Item("Iron Gear Wheel"));
        items.Add(new Item("Copper Cable"));
        items.Add(new Item("Electronic Circuit"));
    }

    public void LoadRecipes(ItemRepository items, RecipeRepository recipes)
    {

    }
}