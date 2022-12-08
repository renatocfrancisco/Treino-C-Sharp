// 29. Faça um programa que verifique e mostre os números entre 1.000 e 2.000 (inclusive) que, quando
//divididos por 11 produzam resto igual a 5.

int n = 1000;
while (n <= 2000)
{
    if ((n % 11) == 5)
    {
        Console.WriteLine(n);
    }
    n++;
}