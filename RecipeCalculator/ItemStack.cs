using System;

class ItemStack
{
    public Item Item
    {
        get;
    }

    public float Number
    {
        get;
    }

    public static ItemStack operator *(ItemStack itemStack, float number)
    {
        return new ItemStack(itemStack.Item, itemStack.Number * number);
    }

    public ItemStack(Item item, float number)
    {
        Item = item;
        Number = number;
    }

    public override string ToString()
    {
        return string.Format("[{0} {1}]", Number, Item);
    }
}