using System;

namespace Exer13
{
    class Program
    {
        static void Main(string[] args)
        {
            string sigla = Console.ReadLine();
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
