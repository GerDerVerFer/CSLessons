using System;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Xml;
using System.Xml.Linq;
class XMLAdapter
{
    public static void XMLToJSON(string info)
    {
        var xlog = XDocument.Parse(info).Root;
        var JLogger = new JLogger();
        var json = new JsonObject();

        foreach (var p in xlog.Elements())
        {
            json.Add(p.Name.LocalName, p.Value);
        }
        JLogger.log(json.ToString());   
    }
}