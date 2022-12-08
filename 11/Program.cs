// Entrar com um número e imprimir uma das mensagens: maior do que 20, igual a 20 ou menor do que 20.

Console.WriteLine("Inserir um número: ");
int x = int.Parse(Console.ReadLine());

if (x > 20)
{
    Console.WriteLine("Maior que 20");
}
else if (x < 20)
{
    Console.WriteLine("Menor que 20");
}
else
{
    Console.WriteLine("Igual a 20");
}