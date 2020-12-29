using System;

namespace Exer33
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double valor = double.Parse(Console.ReadLine());

            if(valor < 1000)
            {
                valor = valor + (valor * 0.10);
            }
            else
            {
                valor = valor + (valor * 0.15);
            }

            Console.WriteLine("{0} - {1}", nome, valor);
        }
    }
}
