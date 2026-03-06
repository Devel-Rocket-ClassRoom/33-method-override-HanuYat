using System;

class Instrument
{
    public string Name;
    
    public Instrument(string name)
    {
        Name = name;        
    }

    public virtual void Play()
    {
        Console.WriteLine($"{Name}을(를) 연주합니다");
    }

    public virtual void Tune()
    {
        Console.WriteLine($"{Name}을(를) 조율합니다");
    }
}