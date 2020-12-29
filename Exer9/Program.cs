using System;

namespace Exer9
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioBruto = double.Parse(Console.ReadLine());
            double valorPrest = double.Parse(Console.ReadLine());

            if (valorPrest <= salarioBruto * (30 / 100))
            {
                Console.WriteLine("Empréstimo pode ser concedido.");
            }
            else
            {
                Console.WriteLine("Empréstimo não pode ser concedido.");
            }
        }
    }
}
