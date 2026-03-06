using System;

class Clothing : Product
{
    public string Size { get; set; }

    public override void GetDescription()
    {
        Console.WriteLine($" → 의류입니다. 세탁 방법을 확인하세요");
    }

    public override string ToString()
    {
        return $"{base.ToString()} (사이즈: {Size})";
    }
}