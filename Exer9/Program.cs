using System;

namespace Exer9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserir o Salário Bruto e o valor da Prestação: ");
            double salarioBruto = double.Parse(Console.ReadLine());
            double valorPrest = double.Parse(Console.ReadLine());

            if (valorPrest <= salarioBruto * 0.3)
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
