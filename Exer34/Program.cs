using System;

namespace Exer34
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 45;
            int ingresso = 120;
            double lucro = 0;

            while (valor >= 0.5){
                lucro = valor * ingresso;
                if (valor <= 5)
                {
                    Console.WriteLine("Lucro Máximo: R${0} =  Preço do Ingressos: R${1} // Quantidade de Ingressos: {2}", lucro, valor, ingresso);
                }
                
                ingresso += 16;
                valor -= 0.5;
            }
        }
    }
}
