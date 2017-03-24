using System;
using System.Net.Http;
namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var x = new HttpClient();
            var y = x.GetStringAsync("http://localhost:60519/api/values").Result;
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}