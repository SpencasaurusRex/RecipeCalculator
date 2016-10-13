using System;

class FactorioHardLoader : Loader
{
    public void Load(ItemRepository items, RecipeRepository recipes)
    {
        Item.Repository = items;

        Item iron = new Item("Iron Plate");
        Item copper = new Item("Copper Plate");
        Item gear = new Item("Iron Gear Wheel");
        Item cc = new Item("Copper Cable");
        Item ec = new Item("Electronic Circuit");
        Item t = new Item("Time");

        Recipe.Repository = recipes;

        new Recipe(gear, 2 * iron, .5f * t);
        new Recipe(ec, 1 * iron, 3 * cc, .5f * t);

        Item.Repository = null;
        Recipe.Repository = null;
    }
}