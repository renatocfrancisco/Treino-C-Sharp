using System;

namespace Cap11oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.Cadastrar( "Gustavo Rosauro", "Rua Lauro Muller 370", 27, new DateTime(1992, 02, 23) );

            //Ja sendo cadastrada as informações no objeto, podemos acessa-las
            
            Console.WriteLine(pessoa.DiaNascimento);
            Console.WriteLine(pessoa.Nome);
            Console.WriteLine(pessoa.Idade);
            Console.WriteLine(pessoa.Endereco);

            pessoa.show();
            pessoa.Beber();
            
            Console.Read();


        }
    }
}
