using System;
using System.Collections.Generic;

namespace RecipeCalculator
{
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
            return items.TryGetValue(name, out get);
        }
    }
}