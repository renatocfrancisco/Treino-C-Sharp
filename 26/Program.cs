// 26. Um comerciante comprou um produto e quer vende - lo com um lucro de 45 % se o valor da compra for
// menor que R$ 20, 00; caso contrario, o lucro será de 30 %.Entrar com o valor do produto e imprimir o valor da
// venda.

Console.WriteLine("Inserir valor: ");
double valor = double.Parse(Console.ReadLine());
if (valor < 20)
{
    Console.WriteLine("Valor da Venda: {0}", valor + (valor * 0.45));
}
else
{
    Console.WriteLine("Valor da Venda: {0}", valor + (valor * 0.30));
}