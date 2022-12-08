///. Entrar com nome, sexo e idade de uma pessoa. Se a pessoa for do sexo feminino e tiver menos que 25
// anos, imprimir nome e a mensagem: ACEITA. Caso contrário, imprimir nome e a mensagem: NÃO ACEITA


Console.WriteLine("Inserir nome, sexo (m || f) e idade: ");
string nome = Console.ReadLine();
string sexo = Console.ReadLine();
int idade = int.Parse(Console.ReadLine());

if (sexo == "f" && idade < 25)
{
    Console.WriteLine(nome + " ACEITA");
}
else
{
    Console.WriteLine(nome + " NÃO ACEITA");
}