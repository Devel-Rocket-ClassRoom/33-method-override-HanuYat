using System;

class Drum : Instrument
{
    public Drum(string name) : base("드럼")
    {
    }
    
    public override void Play()
    {
        Console.WriteLine($"🥁 {Name} 드럼을 두드립니다 - 둥둥둥~");
    }
    
    public override void Tune()
    {
        base.Tune();
    }
}