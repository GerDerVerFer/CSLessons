using System;

class AbstractFactory
{
    public static void Run()
    {
        Hero p1 = HeroFactory.createRanger();
        Hero p2 = HeroFactory.createWinger();
        Hero p3 = HeroFactory.createTank();

        p1.Move();
        p2.Move();
        p3.Move();

        Console.WriteLine();

        p1.Hit();
        p2.Hit();
        p3.Hit();
    }
}