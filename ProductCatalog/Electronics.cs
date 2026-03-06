using System;

class Electronics : Product
{
    public int Warranty { get; set; }

    public override void GetDescription()
    {
        Console.WriteLine($" → 전자기기입니다. 취급에 주의하세요.");
    }

    public override string ToString()
    {
        return $"{base.ToString()} (보증: {Warranty}개월)";
    }
}