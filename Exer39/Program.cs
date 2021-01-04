﻿using System;

namespace Exer39
{
    class Program
    {
        static void Main(string[] args)
        {
           //Faça um programa que receba a idade, altura e peso de 25 pessoas e calcule e mostre:
           //- quantidade de pessoas com idade superior a 50 anos
           //- média das alturas das pessoas com idade entre 10 e 20 anos
           //- percentagem de pessoas com peso inferior a 40 quilos entre todas as pessoas analisadas

            Pessoa[] pessoa = new Pessoa[2];
            int i = 0;
            int count = 0;
            double count2 = 0;

            while (i < pessoa.Length)
            {
                pessoa[i] = new Pessoa();
                Console.WriteLine("Insira a idade, altura e peso: ");
                pessoa[i].Cadastrar(int.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                if (pessoa[i].idade > 50) { count++; }
                if (pessoa[i].peso < 40) { count2++; }
                i++;
            }

            double media = 0;
            int count3 = 0;

            for (int j = 0; j < pessoa.Length; j++)
            {
                if(pessoa[j].idade < 20 && pessoa[j].idade > 10)
                {
                    media += pessoa[j].altura;
                    count3++;
                }
            }

            Console.WriteLine("Pessoas com + de 50 anos: {0}", count);

            Console.WriteLine("Média de altura de pessoas com idade entre 10 e 20 anos: {0}", media / count3);

            Console.WriteLine("Pessoas com menos de 40kg (%): {0}%", 100 * count2 / pessoa.Length);

            
        }
    }
}
