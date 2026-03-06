using System;

class Airplane : Vehicle
{
    public Airplane(string name, int speed) : base(name, 900)
    {
    }

    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 하늘을 납니다! 속도: {Speed}km/h");
    }
}