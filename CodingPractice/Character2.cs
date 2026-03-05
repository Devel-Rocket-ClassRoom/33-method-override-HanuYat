using System;

class Character2
{
    public string Name;
    public int AttackPower;

    public Character2(string name, int attackPower)
    {
        Name = name;
        AttackPower = attackPower;
    }

    public virtual void Attack()
    {
        Console.WriteLine($"{Name}이(가) 공격합니다! 데미지: {AttackPower}");
    }

    public override string ToString()
    {
        return $"[{Name}] 공격력: {AttackPower}";
    }
}