﻿//Uma loja utiliza um código V para transações à vista e P para transações à prazo. 
//Faça um programa que receba o código e o valor de 15 transações.Calcule e mostre:
//- valor total das compras à vista
//- valor total das compras à prazo
//- valor total das compras efetuadas
//- valor da primeira prestação das compras à prazo, sabendo - se que essa serão pagas em três vezes.

List<double> aVista = new List<double>();
List<double> aPrazo = new List<double>();
int dec = 0;
double prestacao = 0;
double totalVista = 0;
double totalPrazo = 0;

var x = new Random();

for (int i = 0; i < 15; i++)
{
    Console.WriteLine("1 para Compras à Vista // 2 para Compras à Prazo");
    dec = int.Parse(Console.ReadLine());

    if (dec == 1)
    {
        Console.WriteLine("Valor?");
        double valor = x.Next(1000);
        //aVista.Add(double.Parse(Console.ReadLine()));
        aVista.Add(valor);

    }
    else if (dec == 2)
    {
        Console.WriteLine("Valor?");
        //aPrazo.Add(double.Parse(Console.ReadLine()));
        double valor = x.Next(1000);
        aPrazo.Add(valor);

    }

}

foreach (double item in aVista)
{
    totalVista += item;
}

foreach (double item in aPrazo)
{
    totalPrazo += item;
}

prestacao = totalPrazo / 3;

Console.WriteLine("Compras à Vista: {0}", totalVista);
Console.WriteLine("Compras à Prazo: {0}", totalPrazo);
Console.WriteLine("Compras feitas: {0}", (totalPrazo + totalVista));
Console.WriteLine("Valor da primeira prestação das compras à prazo: {0}", prestacao.ToString("F"));