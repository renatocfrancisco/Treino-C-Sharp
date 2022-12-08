//  2.Em época de pouco dinheiro, os comerciantes estão procurando aumentar suas vendas oferecendo
//desconto.Faça um algoritmo que possa entrar com o valor de um produto e imprima o novo valor tendo em
//vista que o desconto foi de 9%.


Console.WriteLine("Valor do Produto: ");
double valorProd = double.Parse(Console.ReadLine());
Console.WriteLine("Valor com desconto de 9%: " + (valorProd * 0.91));