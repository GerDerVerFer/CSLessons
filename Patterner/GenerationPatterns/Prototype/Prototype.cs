
using System;

public class Prototype
{
    public static void Run()
    {
        Task task1 = new Task();
        task1.description = "Test";

        ITask task2 = task1.Clone();
        Console.WriteLine($"{task1.GetHashCode()} == {task2.GetHashCode()}, " +
            $"{task2.Equals(task1)}");
    }
}

