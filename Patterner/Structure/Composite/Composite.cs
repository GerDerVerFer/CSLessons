using System;

public class Composite
{ 
    public static void compst()
    {
        Folder f1 = new Folder();
        Folder f2 = new Folder();
        Folder f3 = new Folder();

        for (int i = 1; i < 10; i++)
        {
            f3.files.Add(new File() { Size = i * 5 , Name = $"i"});
        }
        f2.files.Add(new File() { Name = "1", Size = 1 });
        f2.files.Add (new File() { Name = "2", Size = 2 });

        for (int i = 1;i < 10;i++)
        {
            f1.files.Add(new File() { Size = i * 3, Name = $"i" });
        }

        f1.folders.Add(f2);
        f1.folders.Add(f3);

        Console.WriteLine($"f3: {f3.getSize()} \nf2:{f2.getSize()}\nf1:{f1.getSize()}");
    }
    public static void Run()
    {
        compst();
    }
}