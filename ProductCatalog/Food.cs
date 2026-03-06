using System;

class Food : Product
{
    public DateTime ExpirationDate { get; set; }

    public override void GetDescription()
    {
        Console.WriteLine($" → 식품입니다. 냉장 보관하세요.");
    }

    public override string ToString()
    {
        return $"{base.ToString()} (유통기한: {ExpirationDate:yyyy-MM-dd})";
    }
}