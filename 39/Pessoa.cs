using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39
{
    internal class Pessoa
    {
        public int idade { get; private set; }
        public double altura { get; private set; }
        public double peso { get; private set; }

        public Pessoa Cadastrar(int _idade, double _altura, double _peso)
        {
            this.idade = _idade;
            this.peso = _peso;
            this.altura = _altura;
            return this;
        }
    }
}
