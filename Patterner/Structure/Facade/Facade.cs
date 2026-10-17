using System;

class Facade
{
    public static void facade()
    {
        string file = Reader.readFile("./File.txt");
        Console.WriteLine(file);
    }
    public static void Run()
    {
        facade();
    }
}