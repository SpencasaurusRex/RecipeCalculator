using System;
using System.Collections.Generic;

class ItemRepository
{
    private Dictionary<String, Item> items;

    public ItemRepository()
    {
        items = new Dictionary<String, Item>();
    }

    public void Add(Item i)
    {
        items.Add(i.Name, i);
    }

    public Item Get(String name)
    {
        Item selectedItem;
        if (items.TryGetValue(name, out selectedItem))
        {
            return selectedItem;
        }
        throw new ArgumentException("The item \"{0}\" is not in the item list");
    }
}