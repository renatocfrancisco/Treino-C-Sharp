using System;

namespace Exer28
{
    class Program
    {
        static void Main(string[] args)
        {

            string placa = Console.ReadLine();
            char last = placa[placa.Length - 1];
            Console.WriteLine("Renovação no {0}º mês.", last);
            
            /*
            
            int numero;
            bool satisfeito = false;
            while (satisfeito == false)
            {
                Console.WriteLine("Até qual número devo escrever de 1 em 1?");
                numero = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numero; i++)
                {
                    Console.WriteLine(i + 1);
                }
                Console.WriteLine("Satisfeito? S - para Sim / N - para Não");
                if (Console.ReadLine().Equals("S"))
                {
                    satisfeito = true;
                }
            }
            Console.Read();

            ////-----------

            int numero;
            Console.WriteLine("Até qual número devo escrever de 1 em 1?");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine(i + 1);
            }
            
            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            ////----------------------
            
            int n = 1;
            do
            {
                Console.WriteLine("Valor de n é: " + n);
                n++;
            }
            while (n != 10);
            Console.Read();

            ///----------------------

            /*
            int n = 1;
            while(n <= 10)
            {
                Console.WriteLine(String.Format("Valor corrente de n é: {0}", n));
                n++;
            }
            Console.Read();
            */
        }
    }
}
