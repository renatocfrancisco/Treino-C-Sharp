using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public double ValorGasto { get; private set; }

        public double Bonus { get; private set; }
        private int ControlNumber { get; set; }

        public Cliente Cadastrar(string _nome, double _valor)
        {
            this.Nome = _nome;
            this.ValorGasto = _valor;
            this.Bonus = GerarBonus(ValorGasto);
            this.ControlNumber = 5;
            return this;
        }

        public double GerarBonus(double valorGasto)
        {
            if (valorGasto < 1000)
            {
                double v = valorGasto *= 0.10;
                return v;
            }
            else
            {
                double v = valorGasto *= 0.15;
                return v;
            }
        }
    }
}
