using System;

class Shoot : IHit
{
    public void Hit()
    {
        Console.WriteLine("Pew!");
    }
}