using System;

namespace Exer31
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 1;
            while(t <= 10)
            {
                Console.WriteLine("===============");
                for(int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0} x {1} = {2}", t, i, t * i);
                }
                Console.WriteLine("===============");
                t++;
            }
        }
    }
}
