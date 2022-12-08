int[] numeros = new int[5];
for (int i = 0; i < numeros.Length; i++)
{
    string inp = "";
    while (!int.TryParse(inp, out numeros[i]))
    {
        Console.Write("Enter number {0}: ", i + 1);
        inp = Console.ReadLine();
    }
}

Array.Sort(numeros);
Console.WriteLine("Maior Valor : {0}\nMenor Valor : {1}", numeros[numeros.Length - 1], numeros[0]);

/*
int[] arrayDeInteiros = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
foreach (int inteiro in arrayDeInteiros)
{
    Console.WriteLine(inteiro);
}
Console.Read();
*/