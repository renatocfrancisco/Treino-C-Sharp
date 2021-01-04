using System;

namespace Exer34
{
    class Program
    {
        static void Main(string[] args)
        {
//            Uma companhia de teatro deseja dar uma série de espetáculos. A direção calcula que a R45,00 o ingresso
                //serão vendidos 120 ingressos, e que as despesas serão de R$200,00.Diminuindo - se R$0,50 o preço dos
                // ingressos espera - se que as vendas aumentem em 26 ingressos.
            //Faça um programa que escreva uma tabela de valores de lucros esperados em função do preço do ingresso,
            //fazendo - se variar esse preço de R$ 5,00 a R$ 1,00 de R$0,50 em R$0,50.Escreva ainda o lucro máximo
            //esperado, o preço do ingresso e a quantidade de ingressos vendidos para a obtenção desse lucro.


            double valorIngresso = 45;
            int ingresso = 120;
            double despesas = 200;
            double lucro = 0;
            const double cadaIngresso = 1.67;

            while (valorIngresso >= 1.0){

                despesas = ingresso * cadaIngresso;
                lucro = (ingresso * valorIngresso) - despesas;
                
                if (valorIngresso <= 5)
                {
                    Console.WriteLine("Lucro Esperado: R${0} =  Preço do Ingressos: R${1} // Quantidade de Ingressos: {2}", lucro, valorIngresso, ingresso);
                }
                
                ingresso += 26;
                valorIngresso -= 0.5;
            }
        }
    }
}
