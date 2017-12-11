using System;
using Netcoredate;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DateTime d = DateTime.Today;
            var result = d.isBetween(DateTime.Today.AddDays(-2),DateTime.Today.AddDays(2));
            System.Console.WriteLine(result +"");
            System.Console.WriteLine(d.inWords());

        }
    }
}
