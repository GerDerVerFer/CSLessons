using System.Collections.Generic;

public class Decanate
{
    private Dictionary<string, List<string>> messagesForStudent = new Dictionary<string, List<string>>();
    private Dictionary<uint, List<string>> messagesForTeacher = new Dictionary<uint, List<string>>();

    public void sendMessage(Student student,string message)
    {
        if (!messagesForStudent.ContainsKey(student.Group))
            messagesForStudent.Add(student.Group, new List<string>());

        messagesForStudent[student.Group].Add(message);
    }
    public void sendMessage(Teacher teacher, string message)
    {
        if (!messagesForTeacher.ContainsKey(teacher.ID))
            messagesForTeacher.Add(teacher.ID, new List<string>());

        messagesForTeacher[teacher.ID].Add(message);
    }

    public List<string> receiveMessage(Student student)
    {
        List<string> temp = messagesForStudent[student.Group];

        if (temp.Count == 0)
            return new List<string>{"No new messages"};

        messagesForStudent[student.Group].Clear();

        return temp;
    }
    public List<string> receiveMessage(Teacher teacher)
    {
        List<string> temp = messagesForTeacher[teacher.ID];

        if (temp.Count == 0)
            return new List<string> { "No new messages" };

        messagesForTeacher[teacher.ID].Clear();

        return temp;
    }
}