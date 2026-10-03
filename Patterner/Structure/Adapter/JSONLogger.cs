using System;
using System.IO;
using System.Text.Json;
class JLogger
{
    public static void log(string info)
    {
        var json = JsonDocument.Parse(info);
        foreach (var item in json.RootElement.EnumerateObject())
        {
           Console.WriteLine(item);
        }
    }
    public static void Run()
    {
        using (StreamReader sr = new StreamReader("H:\\Test.xml"))
        {
            //string json = sr.ReadToEnd();
            //log(json);

            string xml = sr.ReadToEnd();
            XMLAdapter.XMLToJSON(xml);
        }
    }
}