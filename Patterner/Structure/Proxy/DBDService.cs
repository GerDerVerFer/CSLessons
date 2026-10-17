using System.Collections.Generic;
using System.Threading;

class DBDService
{
    public static string getNews(string city)
    {
        Thread.Sleep(5000);
        return $"Новости для {city}";
    }
}