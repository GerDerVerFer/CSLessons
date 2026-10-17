using System.Collections.Generic;
using System.Threading;

class DBDServiceProxy
{
    public Dictionary<string, string> ns = new Dictionary<string, string>();
    public string getNews(string city)
    {
        if (ns.ContainsKey(city))
             return ns[city];
        
        Thread.Sleep(5000);
        string res = DBDService.getNews(city);
        ns.Add(city, res);
        return res;
    }
}