using System;

namespace Cap11oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria array de veiculos, pondendo ser Automovel, Barco ou qualquer que herde de Veiculo
            
            Veiculo[] veiculo = new Veiculo[2];
            veiculo[0] = new Automovel("BMW");
            veiculo[1] = new Barco("Phantom");

            MovimentarVeiculo(veiculo[0]);
            MovimentarVeiculo(veiculo[1]);

            Console.WriteLine("Digite Enter para os veículos pararem. ");
            Console.ReadLine();

            PararVeiculo(veiculo[0]);
            PararVeiculo(veiculo[1]);
            
            Console.Read();

            public static void MovimentarVeiculo(Veiculo veiculo)
            {
                Console.WriteLine(veiculo.TipoModelo);
                veiculo.Mover();
            }

            public static void PararVeiculo(Veiculo veiculo)
            {
                Console.WriteLine(veiculo.TipoModelo);
                veiculo.Parar();
            }
        }
    }
}
