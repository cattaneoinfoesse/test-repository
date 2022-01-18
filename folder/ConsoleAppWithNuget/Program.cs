using System;

namespace ConsoleAppWithNuget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(new { hello = "world" }));
        }
    }
}
