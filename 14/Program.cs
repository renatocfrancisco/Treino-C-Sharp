//Criar um algoritmo que leia dois números e imprimir uma mensagem dizendo se são iguais ou diferentes.

Console.WriteLine("Insira dois números: ");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

if (x == y)
{
    Console.WriteLine("Valores Iguais");
}
else
{
    Console.WriteLine("Valores Diferentes");
}