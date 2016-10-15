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

    public bool Get(String name, out Item get)
    {
        Item selectedItem;
        if (items.TryGetValue(name, out selectedItem))
        {
            get = selectedItem;
            return true;
        }
        get = null;
        return false;
    }
}