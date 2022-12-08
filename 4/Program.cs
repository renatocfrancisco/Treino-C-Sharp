// 4.Todo restaurante, embora por lei não possa obrigar o cliente a pagar, cobra 10 % para o garçom. Fazer um
//algoritmo que leia o valor gasto com despesas realizadas em um restaurante e imprima o valor total com
//gorjeta.

Console.WriteLine("Valor gasto com desepesas: ");
double valor = double.Parse(Console.ReadLine());
double resultado = valor + (valor * 0.10);
Console.WriteLine("Valor total com Gorjeta do Garçom: " + resultado);
Console.WriteLine("Valor total sem gorjeta: " + valor);