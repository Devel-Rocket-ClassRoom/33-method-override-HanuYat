using System;

class Parent4
{
    public virtual void Work()
    {
        Console.WriteLine("프로그래머");
    }
}

class Child4 : Parent4
{
    public override void Work()
    {
        base.Work();
    }
}

class GrandChild4 : Child4
{
    public override void Work()
    {
        Console.WriteLine("프로게이머");
    }
}