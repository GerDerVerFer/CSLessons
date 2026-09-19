using System;

public class Logger
{
    public static Logger Instance = new Logger();
    private Logger() { }
    public static Logger getInstance()
    {
        return Instance;
    }
    public void Log(string info)
    {
        Console.WriteLine(info);
    }
}