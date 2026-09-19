using System;

class PC1 : IComputer
{
    public void turnOff()
    {
        Console.WriteLine("PC1 turned off");
    }

    public void turnOn()
    {
        Console.WriteLine("PC1 turned on");

    }
}