using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(new { hello = "world" }));
        }
    }
}
