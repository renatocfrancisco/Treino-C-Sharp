using System;

namespace Exer13
{
    class Program
    {
        static void Main(string[] args)
        {
//            Entrar com a sigla do estado de uma pessoa imprimir uma das mensagens:
                //• Carioca
                //• Paulista
                //• Mineiro
                //• Outros estados


            Console.WriteLine("Coloque uma sigla de estado: ");
            string sigla = Console.ReadLine().ToUpper();
            switch (sigla)
            {
                case "SP":
                    Console.WriteLine("Paulista");
                    break;
                case "RJ":
                    Console.WriteLine("Carioca");
                    break;
                case "MG":
                    Console.WriteLine("Mineiro");
                    break;
                default:
                    Console.WriteLine("Outros Estados");
                    break;
            }
        }
    }
}
