using System;
using System.Collections.Generic;

namespace Exer21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrar com três números e imprimi-los em ordem decrescente (suponha números diferentes).

            Console.WriteLine("Insira três números: ");

            List<int> lista = new List<int>();
            int quant = 3;

            for (int i = 0; i < quant; i++)
            {
                lista.Add(int.Parse(Console.ReadLine()));
            }

            lista.Sort();
            lista.Reverse();

            foreach (var item in lista)
            {
                Console.Write("  " + item.ToString());
            }

            //if (x > y && y > z)
            //{
            //    Console.WriteLine("{0} {1} {2}", x, y, z);
            //}
            //else if (x > z && z > y)
            //{
            //    Console.WriteLine("{0} {1} {2}", x, z, y);
            //}
            //else if (y > z && z > x)
            //{
            //    Console.WriteLine("{0} {1} {2}", y, z, x);
            //}
            //else if (y > x && x > z)
            //{
            //    Console.WriteLine("{0} {1} {2}", y, x, z);
            //}
            //else if (z > y && z > x)
            //{
            //    Console.WriteLine("{0} {1} {2}", z, y, x);
            //}
            //else
            //{
            //    Console.WriteLine("{0} {1} {2}", z, x, y);
            //}
        }
    }
}
