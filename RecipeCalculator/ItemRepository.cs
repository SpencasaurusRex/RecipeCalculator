using System;

class ItemRepository
{
    private Item item1;

    public ItemRepository(Item item)
    {
        Console.WriteLine(item.Name);
    }
}