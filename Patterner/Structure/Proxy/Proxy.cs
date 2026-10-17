using System;
using System.Collections.Generic;

class Proxy
{
    static void proxy()
    {
        DBDServiceProxy dbds = new DBDServiceProxy();
        for (int i = 0; i < 10; i++) 
        {
           Console.WriteLine( dbds.getNews($"city"));
        }
    }
    public static void Run()
    {
        proxy();
    }
}