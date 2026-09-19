using System;

class Builder
{
    public static void Run()
    {
        Building b1 = new Worker()
            .foundation("concrete")
            .roof("tiles")
            .walls("reinfConcrete")
            .interior("Euro")
            .build();

        Console.WriteLine(b1);
    }
}