//25. Entrar com nome, nota da PR1 e nota da PR2 de um aluno, imprimir nome, nota da PR1, nota da PR2,
//média e uma das mensagens: APROVADO, REPROVADO ou EXAME(a média é 7 para aprovação, menor que 3
//para reprovação e as demais em exame).


Console.WriteLine("Inserir duas notas: ");
double pr1 = double.Parse(Console.ReadLine());
double pr2 = double.Parse(Console.ReadLine());

double media = (pr1 + pr2) / 2;
if (media >= 7)
{
    Console.WriteLine("Aprovado");
}
else if (media < 3)
{
    Console.WriteLine("Reprovado");
}
else
{
    Console.WriteLine("Em Exame");
}