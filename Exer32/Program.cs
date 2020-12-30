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
            /// leia cinco grupos de quatro valores (A, B, C, D)
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

            List<int> grupo1 = new List<int>();
            List<int> grupo2 = new List<int>();
            List<int> grupo3 = new List<int>();
            List<int> grupo4 = new List<int>();
            List<int> grupo5 = new List<int>();


            alimentarGrupoComValores(grupo1);
            alimentarGrupoComValores(grupo2);
            alimentarGrupoComValores(grupo3);
            alimentarGrupoComValores(grupo4);
            alimentarGrupoComValores(grupo5);

            Console.WriteLine("Ordem Lida: ");
            foreach (int i in grupo1) Console.Write(i + " ");
            foreach (int i in grupo2) Console.Write(i + " ");
            foreach (int i in grupo3) Console.Write(i + " ");
            foreach (int i in grupo4) Console.Write(i + " ");
            foreach (int i in grupo5) Console.Write(i + " ");
            Console.WriteLine("\n");

            grupo1.Sort();
            grupo2.Sort();
            grupo3.Sort();
            grupo4.Sort();
            grupo5.Sort();

            Console.WriteLine("Ordem Crescente: \n");
            foreach (int i in grupo1) Console.Write(i + " ");
            foreach (int i in grupo2) Console.Write(i + " ");
            foreach (int i in grupo3) Console.Write(i + " ");
            foreach (int i in grupo4) Console.Write(i + " ");
            foreach (int i in grupo5) Console.Write(i + " ");
            Console.WriteLine("\n");

            grupo1.Reverse();
            grupo2.Reverse();
            grupo3.Reverse();
            grupo4.Reverse();
            grupo5.Reverse();

            Console.WriteLine("Ordem Decrescente: \n");
            foreach (int i in grupo1) Console.Write(i + " ");
            foreach (int i in grupo2) Console.Write(i + " ");
            foreach (int i in grupo3) Console.Write(i + " ");
            foreach (int i in grupo4) Console.Write(i + " ");
            foreach (int i in grupo5) Console.Write(i + " ");
            Console.WriteLine("\n");
        }

        private static void alimentarGrupoComValores(List<int> grupoAlimentar)
        {
            const int limiteLeitura = 4;

            var randomico = new Random();

            for (int i = 0; i < limiteLeitura; i++)
            {
                int x = int.Parse(Console.ReadLine());
                // TESTE DO DESENVOL int x = randomico.Next(100);
                grupoAlimentar.Add(x);
            }
        }
    }
}
