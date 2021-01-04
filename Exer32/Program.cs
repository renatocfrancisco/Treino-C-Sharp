using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;

namespace Exer32
{
    class Program
    {
        static void Main(string[] args)
        {
            ///  Faça um programa que leia cinco grupos de quatro valores (A, B, C, D) e mostre-os na ordem lida. Em
            //seguida, mostre - os em ordem crescente e decrescente.
            // int[,] numeros5-4 = new int[5,4];
            // OrderBy(a => a.Nome).ToList().

            ////---------Com Array--------------------

            /*

            int[] numeros20 = new int[3];


            for (int i = 0; i < numeros20.Length; i++)
            {
                int x = int.Parse(Console.ReadLine());
                numeros20[i] = x;
            }

            foreach (int i in numeros20) Console.Write(i + " ");
            Console.Write("\n");

            Array.Sort(numeros20);
            foreach (int i in numeros20) Console.Write(i + " ");
            Console.Write("\n");

            Array.Reverse(numeros20);
            foreach (int i in numeros20) Console.Write(i + " ");
            Console.Write("\n");

            */

            ///-----------Com Lista---

            Metodo2();

            //List<int> grupo1 = new List<int>();
            //List<int> grupo2 = new List<int>();
            //List<int> grupo3 = new List<int>();
            //List<int> grupo4 = new List<int>();
            //List<int> grupo5 = new List<int>();

            //List<List<int>> teste = new List<List<int>>();

            //alimentarGrupoComValores(grupo1);
            //alimentarGrupoComValores(grupo2);
            //alimentarGrupoComValores(grupo3);
            //alimentarGrupoComValores(grupo4);
            //alimentarGrupoComValores(grupo5);

            //Console.WriteLine("Ordem Lida: ");
            //foreach (int i in grupo1) Console.Write(i + " ");
            //foreach (int i in grupo2) Console.Write(i + " ");
            //foreach (int i in grupo3) Console.Write(i + " ");
            //foreach (int i in grupo4) Console.Write(i + " ");
            //foreach (int i in grupo5) Console.Write(i + " ");
            //Console.WriteLine("\n");

            //grupo1.Sort();
            //grupo2.Sort();
            //grupo3.Sort();
            //grupo4.Sort();
            //grupo5.Sort();

            //Console.WriteLine("Ordem Crescente: \n");
            //foreach (int i in grupo1) Console.Write(i + " ");
            //foreach (int i in grupo2) Console.Write(i + " ");
            //foreach (int i in grupo3) Console.Write(i + " ");
            //foreach (int i in grupo4) Console.Write(i + " ");
            //foreach (int i in grupo5) Console.Write(i + " ");
            //Console.WriteLine("\n");

            //grupo1.Reverse();
            //grupo2.Reverse();
            //grupo3.Reverse();
            //grupo4.Reverse();
            //grupo5.Reverse();

            //Console.WriteLine("Ordem Decrescente: \n");
            //foreach (int i in grupo1) Console.Write(i + " ");
            //foreach (int i in grupo2) Console.Write(i + " ");
            //foreach (int i in grupo3) Console.Write(i + " ");
            //foreach (int i in grupo4) Console.Write(i + " ");
            //foreach (int i in grupo5) Console.Write(i + " ");
            //Console.WriteLine("\n");
        }

        private static void AlimentarGrupoComValores(List<int> grupoAlimentar)
        {
            const int limiteLeitura = 2;

            var randomico = new Random();

            for (int i = 0; i < limiteLeitura; i++)
            {
                int x = int.Parse(Console.ReadLine());
                // TESTE DO DESENVOL int x = randomico.Next(100);
                grupoAlimentar.Add(x);
            }
        }

        private static void Metodo2()
        {
            List<List<int>> teste = new List<List<int>>();

            AlimentarGrupoComValores(teste);

            Console.WriteLine("Ordem Lida: ");
            foreach (var item in teste)
            {
                foreach (int i in item) Console.Write(i + " ");
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");

            foreach (var item in teste)
            {
                item.Sort();
            }

            Console.WriteLine("Ordem Crescente: \n");
            foreach (var item in teste)
            {
                foreach (int i in item) Console.Write(i + " ");
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");

            foreach (var item in teste)
            {
                item.Reverse();
            }

            Console.WriteLine("Ordem Decrescente: \n");
            foreach (var item in teste)
            {
                foreach (int i in item) Console.Write(i + " ");
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }

        private static void AlimentarGrupoComValores(List<List<int>> grupoAlimentar)
        {
            const int quantidadeGrupos = 100;
            const int limiteLeitura = 10;

            var randomico = new Random();
            for (int j = 0; j < quantidadeGrupos; j++)
            {
                grupoAlimentar.Add(new List<int>());
                for (int i = 0; i < limiteLeitura; i++)
                {
                    //int x = int.Parse(Console.ReadLine());
                    int x = randomico.Next(100);
                    grupoAlimentar[j].Add(x);
                }
            }
            
        }
    }
}
