using System;
using System.Collections.Generic;
using System.Text;

namespace Exer40
{
    class Pessoa
    {
        public int idade { get; private set; } 
        public double peso { get; private set; }
        
        public Pessoa Cadastrar(int _idade, double _peso)
        {
            this.idade = _idade;
            this.peso = _peso;
            return this;
        }
    }
}
