using System;

class Server : IComputer
{
    public void turnOff()
    {
        Console.WriteLine("Server turned off");
    }

    public void turnOn()
    {
        Console.WriteLine("Server turned on");

    }
}