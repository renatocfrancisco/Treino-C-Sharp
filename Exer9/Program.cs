using System;

namespace Exer9
{
    class Program
    {
        static void Main(string[] args)
        {
//            9.A prefeitura do Rio de Janeiro abriu uma linha de crédito para os funcionários estatutários.O valor Máximo
//                  da prestação não poderá ultrapassar 30 % do salário bruto. Fazer um programa que permita entrar com o
//                  salário bruto e o valor da prestação e informa se o empréstimo pode ou não ser concedido.


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
