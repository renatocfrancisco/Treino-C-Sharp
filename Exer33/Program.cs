using System;

namespace Exer33
{
    class Program
    {
        private const string Format = "{0} - Valor Gasto:{1} / Bonus:{2}";

        static void Main(string[] args)
        {
//            . Uma loja tem 15 clientes cadastrados e deseja enviar uma correspondência a cada um deles anunciando
                //um bônus especial.Faça um programa que leia o nome do cliente e o valor das suas compras no ano passado.
                //Calcule e mostre um bônus de 10 % se o valor das compras for menor que R$1.000, 00 e de 15 % caso seja maior
                // do que R$ 1.000,00.

            Console.WriteLine("Inserir Nome e Valor das Compras: ");

            const int quant = 3;
            Cliente[] clientes = new Cliente[quant];
            var random = new Random();

            // int x = randomico.Next(100);

            for (int i = 0; i < quant; i++)
            {
                double valor = random.Next(100,2000);
                clientes[i] = new Cliente();
                clientes[i] = clientes[i].Cadastrar(Console.ReadLine(), valor);
            }

            foreach (Cliente item in clientes)
            {
                Console.WriteLine(Format, item.Nome, item.ValorGasto, item.Bonus);
            };
                        

            ///Console.WriteLine("{0} - {1}", nome, valor);
        }
    }
}
