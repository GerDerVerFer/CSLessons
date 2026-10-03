using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; }
    public string Group { get; }
    Decanate decanate = new Decanate();
    public Student (string name, string group)
    {
        Name = name;
        Group = group;
    }
    public void getMessageFromTeacher()
    {
        List<string> msg = decanate.receiveMessage(this);
        foreach (string s in msg) Console.WriteLine(s);
    }
    public void sendMessageToTeacher(Teacher target, string msg)
    {
        decanate.sendMessage(target, msg);
    }
}