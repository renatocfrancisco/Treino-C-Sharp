using System;

namespace _28122020
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. Antes do racionamento de energia ser decretado, quase ninguém falava em quilowatts; mas, agora, todos
incorporaram essa palavra em seu vocabulário.Sabendo - se que 100 quilowatts de energia custa um sétimo do
                salário mínimo, fazer um algoritmo que receba o valor do salário mínimo e a quantidade de quilowatts gasta
                por uma residência e calcule. Imprima:
                • O valor em reais de cada quilowatt
                • O valor em reais a ser pago
                • O novo valor a ser pago por essa residência com um desconto de 10 %
            */


            Console.WriteLine("Salário Mínimo: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de Quilowatts");
            double watts = double.Parse(Console.ReadLine());

            double custoDe100qw = (salario / 7);


            double cd1Watt = custoDe100qw / 100;
            Console.WriteLine("Valor de cada quilowatt: " + cd1Watt.ToString("F"));

            double pagar = cd1Watt * watts;
            Console.WriteLine("Valor a ser pago: " + pagar.ToString("F"));

            Console.WriteLine("Novo valor com um desconto de 10%: " + (pagar - pagar * 0.10).ToString("F"));           

        }
    }
}


/* 
 * Console.WriteLine("Insira a idade:");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 13 && idade < 19)
            {
                Console.WriteLine("Adolescente");
            }
            else if (idade >= 19 && idade <= 60)
            {
                Console.WriteLine("Adulto");
            }
            else if (idade > 60)
            {
                Console.WriteLine("Idoso");
            }
            else
            {
                Console.WriteLine("Criança");
            }

            Console.ReadKey();

            Console.WriteLine("Quem ganhou a copa de 2014?");
            string resp = Console.ReadLine().ToUpper();
            if (resp == "ALEMANHA"){
                Console.WriteLine("Acertou! :(");
            }
            else
            {
                Console.WriteLine("Errou! :)");
            }

            Console.ReadKey();

            Console.WriteLine("Peso (kg) e Altura (metros): ");
            double peso = double.Parse(Console.ReadLine());
            double altura = double.Parse(Console.ReadLine());
            double imc = peso / (altura * altura);

            if (idade >= 18.5 && idade <= 24.9)
            {
                Console.WriteLine("Normal");
            }
            else if (idade >= 25 && idade <=29.9) {
                Console.WriteLine("Sobrepeso");
            }
            else if (idade >= 30 && idade <= 40)
            {
                Console.WriteLine("Obesidade");
            }
            else
            {
                Console.WriteLine("Abaixo do Peso");
            } * 
 * 
 * Console.WriteLine("Peso (kg):");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Altura (metros):");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / altura;
            Console.WriteLine(imc);


            Console.WriteLine(CalcularMedia(8, 7, 5, 8));
            */

/* 
double pi = Math.PI;
Console.WriteLine(pi);


double seno = Math.Sin(2.20);
double coseno = Math.Cos(2.20);
double tangente = Math.Tan(2.20);
Console.WriteLine(String.Format("{0} - {1} - {2}", seno, coseno, tangente));

double potencia = Math.Pow(2, 8);
Console.WriteLine(potencia);

double arrendondar = Math.Round(100.5124, 2);
Console.WriteLine(arrendondar);

string textoAntigo = "um texto escrito em letras minúsculas";
string textoNovo = textoAntigo.Replace("minúsculas", "MAIÚSCULAS").ToUpper();
Console.WriteLine(textoNovo);

Console.WriteLine("=============================");

Console.WriteLine("Nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Idade: ");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine("Telefone: ");
string telefone = Console.ReadLine();
telefone = formatarTel(telefone);
SqrtIdade(idade);
nome = modificarNome(nome);

Console.ReadKey();
}

private static string modificarNome(string nome)
{
nome = nome.Replace(" ", ";");
Console.WriteLine(nome);
return nome;
}

private static void SqrtIdade(int idade)
{
double raizQ = Math.Round(Math.Sqrt(idade), 2);
Console.WriteLine(raizQ);
}

private static string formatarTel(string telefone)
{
telefone = telefone.Insert(5, "-");
Console.WriteLine(telefone);
return telefone;
}
*/