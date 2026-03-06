using System;

class Piano : Instrument
{
    public Piano(string name) : base("피아노")
    {
    }

    public override void Play()
    {
        Console.WriteLine($"🎹 {Name} 건반을 누릅니다 - 딩동댕~");
    }
    public override void Tune()
    {
        Console.WriteLine($"{Name} 현을 조율합니다");
    }
}