using System;

// README.md를 읽고 코드를 작성하세요.

Parent parent = new Parent();
Child child = new Child();
parent.Work();
child.Work();
Console.WriteLine();

Animal animal = new Animal();
animal.Eat();
animal = new Cat();
animal.Eat();
Console.WriteLine();

Child2 child2 = new Child2();
child2.Say();
child2.Run();
child2.Walk();
Console.WriteLine();
Parent2 parent2 = child2;
parent2.Say();
parent2.Run();
parent2.Walk();
Console.WriteLine();

Console.WriteLine(Calculator.Add(1, 2));
Console.WriteLine(Calculator.Add(1.5, 2.5));
Console.WriteLine(Calculator.Add(1, 2, 3));
Console.WriteLine();

Animal2 animal2 = new Animal2();
animal2.Speak();
animal2 = new Dog2();
animal2.Speak();
animal2 = new Cat2();
animal2.Speak();
Console.WriteLine();

Child3 child3 = new Child3();
child3.Greet();
Console.WriteLine();

new Parent4().Work();
new Child4().Work();
new GrandChild4().Work();
Console.WriteLine();

new Parent5().Work();
new Child5().Work();
new GrandChild5().Work();
new GrandChild5().Play();
Console.WriteLine();

Person person = new Person();
Console.WriteLine(person);
Console.WriteLine(person.ToString());
Console.WriteLine();

Person2 person2 = new Person2("박용준");
Console.WriteLine(person2);
Console.WriteLine();

Character hero = new Character("용사", 10, 100);
Character wizard = new Character("마법사", 8, 70);
Console.WriteLine(hero);
Console.WriteLine(wizard);
Console.WriteLine();

Character2 warrior = new Warrior("전사");
Character2 mage = new Mage("마법사");
Character2 archer = new Archer("궁수");

Console.WriteLine(warrior);
Console.WriteLine(mage);
Console.WriteLine(archer);
Console.WriteLine();

warrior.Attack();
mage.Attack();
archer.Attack();
Console.WriteLine();

Character2[] characters = new Character2[]
{
    warrior,
    mage,
    archer
};

Console.WriteLine("=== 파티 공격 ===");
foreach (Character2 character in characters)
{
    character.Attack();
}