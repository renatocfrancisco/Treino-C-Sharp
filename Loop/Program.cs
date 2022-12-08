Console.WriteLine("Digite um numero: ");
int n = int.Parse(Console.ReadLine());

while (n != 0)
{
    Console.WriteLine(n);
    n--;
}

///---------------
Console.WriteLine("Digite outro numero: ");
int num = int.Parse(Console.ReadLine());
while (num % 2 != 0)
{
    Console.WriteLine("Digite outro numero, de novo: ");
    num = int.Parse(Console.ReadLine());
}

int x = num / 2;
for (int i = 0; i < x; i++)
{
    Console.WriteLine("Repetição" + x);
}

/////-------

Console.WriteLine("Quem ganhou a copa do Mundo em 2014?");
var resp = Console.ReadLine();
while (resp != "Alemanha")
{
    Console.WriteLine("eRRASTE!");
    resp = Console.ReadLine();
}
Console.WriteLine("aCERTOU!");