// faça um programa que mostre a tabuada dos números de 1 a 10.

int t = 1;
Console.WriteLine("Tabuada do 1 ao 10");
while (t <= 10)
{
    Console.WriteLine("===============");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine("{0} x {1} = {2}", t, i, t * i);
    }
    Console.WriteLine("===============");
    t++;
}