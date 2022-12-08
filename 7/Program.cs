//            7.Construir um algoritmo que leia dois valores numéricos inteiros e efetue a adição; caso o resultado seja
//maior que 10, apresentá - lo.

Console.WriteLine("Primero Número:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Segundo Número:");
int y = int.Parse(Console.ReadLine());
int resultado = x + y;

if (resultado > 10)
{
    Console.WriteLine(resultado);
}