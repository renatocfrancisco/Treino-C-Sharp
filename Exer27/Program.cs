using System;

namespace Exer27
{
    class Program
    {
        static void Main(string[] args)
        {
//            27.Um restaurante esta fazendo uma promoção semanal de descontos para clientes de acordo com as iniciar
                //do nome da pessoa.Criar um algoritmo que leia o primeiro nome do cliente, o valor de sua conta e se o nome
                //iniciar com as letras A, D, M ou S, dar um desconto de 30 %.Para o cliente cujo nome não se inicia por
                //nenhuma dessas letras, exibir a mensagem “Que pena. Nesta semana o desconto não é para seu nome; mas
                //continue nos prestigiando que sua vez chegara”.

            Console.WriteLine("Inserir nome e valor da conta: ");
            string nome = Console.ReadLine();
            double valor = double.Parse(Console.ReadLine());
            
            nome = nome.ToLower().Substring(0,1);

            ///char[] letras = { 'a', 'b' };

            switch (nome)
            {
                case "a":
                case "d":
                case "m":
                case "s":
                    Console.WriteLine(valor - valor * 0.30);
                    break;
                default:
                    Console.WriteLine("Que pena. Nesta semana o desconto não é para seu nome; mas continue nos prestigiando que sua vez chegara");
                    break;
            }

            //if (nome == "a" || nome == "d" || nome == "m" || nome == "s")
            //{
            //    Console.WriteLine(valor - (valor * 0.30));
            //}
            //else
            //{
            //    Console.WriteLine("Que pena. Nesta semana o desconto não é para seu nome; mas continue nos prestigiando que sua vez chegara");
            //}
        }
    }
}
