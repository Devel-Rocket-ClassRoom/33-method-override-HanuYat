using System;

class Product
{
    public string Name;
    public int Price;

    public virtual void GetDescription()
    {
        Console.WriteLine($" → {Name}입니다.");
    }

    public override string ToString()
    {
        return $"{Name} - ￦{Price:N0}";
    }
}