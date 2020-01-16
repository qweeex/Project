using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "hello";
            string b = a;
            a = "world";
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
