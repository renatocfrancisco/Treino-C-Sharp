//  Faça um programa que leia cinco grupos de quatro valores (A, B, C, D) e mostre-os na ordem lida. Em
// seguida, mostre - os em ordem crescente e decrescente.

// int[,] numeros5-4 = new int[5,4];void
// OrderBy(a => a.Nome).ToList().

Iniciar();

void Iniciar()
{
    List<List<int>> lista = new List<List<int>>();

    AlimentarGrupoComValores(lista);

    Console.WriteLine("Ordem Lida: ");
    foreach (var item in lista)
    {
        foreach (int i in item) Console.Write(i + " ");
        Console.WriteLine("\n");
    }
    Console.WriteLine("\n");

    foreach (var item in lista)
    {
        item.Sort();
    }

    Console.WriteLine("Ordem Crescente: \n");
    foreach (var item in lista)
    {
        foreach (int i in item) Console.Write(i + " ");
        Console.WriteLine("\n");
    }
    Console.WriteLine("\n");

    foreach (var item in lista)
    {
        item.Reverse();
    }

    Console.WriteLine("Ordem Decrescente: \n");
    foreach (var item in lista)
    {
        foreach (int i in item) Console.Write(i + " ");
        Console.WriteLine("\n");
    }
    Console.WriteLine("\n");
}

void AlimentarGrupoComValores(List<List<int>> grupoAlimentar)
{
    const int quantidadeGrupos = 2;
    const int limiteLeitura = 10;

    var randomico = new Random();
    for (int j = 0; j < quantidadeGrupos; j++)
    {
        grupoAlimentar.Add(new List<int>());
        for (int i = 0; i < limiteLeitura; i++)
        {
            //int x = int.Parse(Console.ReadLine());
            int x = randomico.Next(100);
            grupoAlimentar[j].Add(x);
        }
    }

}