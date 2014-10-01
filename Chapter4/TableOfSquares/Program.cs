using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableOfSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("──┬───");
                Console.WriteLine("{0,2}│{1,3}", i, i * i);
            }
        }
    }
}
