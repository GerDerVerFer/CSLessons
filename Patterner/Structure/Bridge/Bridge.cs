using System;

class Bridge
{

    public static void bridge()
    {
        Student s1 = new Student("Vasilyy", "KB-31");
        Student s11 = new Student("Mikhail", "KB-31");

        Student s2 = new Student("Evgeniy", "IB-31");
        Student s22 = new Student("Anton", "IB-31");

        Teacher t1 = new Teacher("Artemiy E.", 1);
        Teacher t2 = new Teacher("Artemiy G.", 1);


        t1.sendMessageToStudent(s22, "Пара будет в корпусе биофака");
        s1.sendMessageToTeacher(t1, "Когда проверите лабы?");

        t2.sendMessageToStudent(s22, "Пары не будет");

        s2.sendMessageToTeacher(t1, "Вы чо издеваетесь?");

        Console.WriteLine("t1");
        t1.getMessageFromStudent();

        Console.WriteLine("\nt2");
        t2.getMessageFromStudent();

        Console.WriteLine("\nKB-31");
        s11.getMessageFromTeacher();

        Console.WriteLine("\nIB-31");
        s22.getMessageFromTeacher();

    }
    public static void Run()
    {
        bridge();
    }
}