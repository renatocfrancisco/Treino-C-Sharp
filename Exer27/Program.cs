using System;

namespace Exer27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserir nome e valor da conta: ");
            string nome = Console.ReadLine();
            double valor = double.Parse(Console.ReadLine());
            
            nome = nome.ToLower().Substring(0,1);

            ///char[] letras = { 'a', 'b' };

            if (nome == "a" || nome == "d" || nome == "m" || nome == "s")
            {
                Console.WriteLine(valor + (valor * 0.30));
            }
            else
            {
                Console.WriteLine("Que pena. Nesta semana o desconto não é para seu nome; mas continue nos prestigiando que sua vez chegara");
            }
        }
    }
}
