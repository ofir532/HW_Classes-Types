using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Classes_Types_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from main");
            Console.WriteLine(StaticClass.Type);
            StaticClass.Type = "test 123";
            Console.WriteLine(StaticClass.Type);
        }
    }
}
