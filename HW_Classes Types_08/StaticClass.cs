using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Classes_Types_08
{
    internal static class StaticClass
    {
        public static string? Type { get; set; }

        static StaticClass()
        {
            Type = "I'm Static Class";
        }

        public static void StaticFoo1()
        {
            Console.WriteLine("First static foo");
        }
        public static void StaticFoo2()
        {
            Console.WriteLine("Second static foo");
        }
    }
}
