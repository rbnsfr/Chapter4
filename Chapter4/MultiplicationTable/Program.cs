using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("─────┬─────┬─────┬─────┬─────┬─────┬─────┬──────");
            Console.WriteLine("    X│{0,5}│{1,5}│{2,5}│{3,5}│{4,5}│{5,5}│{6,5}│{7,5}│{8,5}│{9,5}│{10,5}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine("─────┴─────┴─────┴─────┴─────┴─────┴─────┴──────");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0,5}│{1,5}│{2,5}│{3,5}│{4,5}│{5,5}", i, i * 0, i * 1, i * 2, i * 3, i * 4, i * 5);
                Console.WriteLine("────────────────────────────────────────────────");
            }
        }
    }
}
