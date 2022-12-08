//Entrar com dois números e imprimir o menor numero(suponha números diferentes).


Console.WriteLine("Insira dois números: ");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

if (x < y)
{
    Console.WriteLine(x);
}
else
{
    Console.WriteLine(y);
}