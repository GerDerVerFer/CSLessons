using System.IO;

class Reader
{
    public static string readFile(string filename)
    {
        using (StreamReader sr = new StreamReader(filename))
        {
            return sr.ReadToEnd();
        }
    }
}