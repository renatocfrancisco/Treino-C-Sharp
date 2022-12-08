//Faça um programa que receba a idade de dez pessoas e que calcule e mostre a quantidade de pessoas com
//idade maior ou igual a 18 anos.

Console.WriteLine("Digite 10 Idades: ");
int count = 0;
for (int i = 0; i < 10; i++)
{
    int idade = int.Parse(Console.ReadLine());
    if (idade >= 18) { count++; }
}
Console.WriteLine("{0} Pessoas com ou mais de 18 anos.", count);