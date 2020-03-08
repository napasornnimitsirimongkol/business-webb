using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, z;
            Console.Write("Mutiply: ");
            x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++ )
            {
                z = x * i;
                Console.WriteLine(x+" * "+i+" = "+z);
            }
        }
    }
}
