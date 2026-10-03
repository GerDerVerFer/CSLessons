using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

public class Teacher
{
    public string Name { get; }
    public uint ID { get; }
    Decanate decanate = new Decanate();

    public Teacher(string name, uint id)
    {
        Name = name;
        ID = id;
    }
    public void getMessageFromStudent()
    {
        List<string> msg = decanate.receiveMessage(this);
        foreach (string s in msg) Console.WriteLine(s);
    }
    public void sendMessageToStudent(Student target, string msg)
    {
        decanate.sendMessage(target, msg);
    }
}