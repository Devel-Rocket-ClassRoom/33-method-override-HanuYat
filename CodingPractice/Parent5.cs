using System;

class Parent5
{
    public virtual void Work()
    {
        Console.WriteLine("프로그래머");
    }
}

class Child5 : Parent5
{
    public sealed override void Work()
    {
        base.Work();
    }
}

class GrandChild5 : Child5
{
    public void Play()
    {
        Console.WriteLine("프로게이머");
    }
}