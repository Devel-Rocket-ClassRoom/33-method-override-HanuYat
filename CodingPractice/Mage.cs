using System;

class Mage : Character2
{
    public Mage(string name) : base(name, 30)
    {
    }
    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 파이어볼을 시전합니다! 데미지: {AttackPower * 2}");
    }
}