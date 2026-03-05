using System;

class Archer : Character2
{
    public Archer(string name) : base(name, 40)
    {
    }
    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 화살을 쏩니다! 데미지: {AttackPower}");
    }
}