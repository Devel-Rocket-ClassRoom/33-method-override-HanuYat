using System;

class Guitar : Instrument
{
    public Guitar(string name) : base("기타")
    {
    }
    public override void Play()
    {
        Console.WriteLine($"🎸 {Name} 줄을 튕깁니다 - 통통통~");
    }
    
    public override void Tune()
    {
        Console.WriteLine($"{Name} 줄을 조율합니다");
    }
}