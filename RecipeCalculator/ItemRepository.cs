using System;
using System.Collections.Generic;

class ItemRepository
{
    private List<Item> items;

    public ItemRepository()
    {
        items = new List<Item>();
    }

    public void AddItem(Item i)
    {
        items.Add(i);
    }
}