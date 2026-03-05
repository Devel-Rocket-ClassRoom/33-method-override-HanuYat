using System;

class Warrior : Character2
{
    public Warrior(string name) : base(name, 50)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 칼로 베어냅니다! 데미지: {AttackPower}");
    }
}