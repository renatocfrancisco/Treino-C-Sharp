using System;

namespace Exer23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];
            for (int i = 0; i < n.Length; i++)
            {
                string inp = "";
                while (!int.TryParse(inp, out n[i]))
                {
                    Console.Write("Enter number {0}: ", i + 1);
                    inp = Console.ReadLine();
                }
            }
            Array.Sort(n);
            Console.WriteLine("Largest  : {0}\nSmallest : {1}", n[n.Length - 1], n[0]);

            /*
            int[] arrayDeInteiros = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int inteiro in arrayDeInteiros)
            {
                Console.WriteLine(inteiro);
            }
            Console.Read();
            */
            

        }
    }
}
