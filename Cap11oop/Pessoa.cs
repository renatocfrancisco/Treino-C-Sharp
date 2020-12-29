using System;
using System.Collections.Generic;
using System.Text;

namespace Cap11oop
{
    public class Pessoa
    {
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public int Idade { get; private set; }
        public DateTime DiaNascimento { get; private set; }


        public Pessoa Cadastrar(string _nome, string _endereco, int _idade, DateTime _diaNascimento)
        {
            this.DiaNascimento = _diaNascimento;
            this.Endereco = _endereco;
            this.Nome = _nome;
            this.Idade = _idade;
            return this;
        }

        public void show() { Console.WriteLine("{0}: {1} {2} {3}", Nome, Endereco, Idade, DiaNascimento); }
        public void Beber() { Console.WriteLine("Não estou com sede."); }

        public void Comer() { Console.WriteLine("Não estou com fome."); }

        public void Andar() {; }
    }
}
