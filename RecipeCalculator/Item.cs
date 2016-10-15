using System;

class Item
{
    public static ItemRepository Repository
    {
        set;
        get;
    }

    public String Name
    {
        get;
    }

    public Item(String name)
    {
        Name = name;
        if (Repository != null)
        {
            Repository.Add(this);
        }
    }

    public static ItemStack operator *(Item item, float number)
    {
        return new ItemStack(item, number);
    }

    public static ItemStack operator *(float number, Item item)
    {
        return item * number;
    }

    public static bool operator ==(Item a, Item b)
    {
        return string.Equals(a.Name, b.Name);
    }

    public static bool operator !=(Item a, Item b)
    {
        return !string.Equals(a.Name, b.Name);
    }

    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Item))
        {
            return false;
        }
        Item item = (Item)obj;
        return item == this;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode() * Name.GetHashCode();
    }

    public override string ToString()
    {
        return Name;
    }
}