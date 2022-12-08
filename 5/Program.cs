//            5.Uma pessoa resolveu fazer uma aplicação em uma poupança programada.Para calcular seu rendimento, ela
//                  devera fornecer o valor constante da aplicação mensal, a taxa e o número de meses. Sabendo - se que a
//                  formula usada para este calculo é:
//          Valor acumulado = P * ( (1 + i)n - 1)/ i

// i = taxa
// p = aplicação mensal
// n = número de meses(obs. (1 + i) elevado a n)

Console.WriteLine("Inserir taxa (%), aplicação mensal e Nº de Meses");
double i = double.Parse(Console.ReadLine()); i /= 100;
double p = double.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

double valorAcumulado = p * ((Math.Pow(1 + i, n) - 1) / i);
Console.WriteLine("Valor Acumulado: {0}", valorAcumulado.ToString("F"));
///Está certo?