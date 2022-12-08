//Entrar com dois números e imprimir o maior numero (suponha números diferentes).

Console.WriteLine("Insira dois números: ");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

if (x > y)
    Console.WriteLine(x);
else
    Console.WriteLine(y);

/*
if (x > y)
{
    Console.WriteLine(x);
}
else
{
    Console.WriteLine(y);
}
*/