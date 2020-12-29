using System;
using System.Collections.Generic;
using System.Text;

namespace Cap11oop2
{
    public class Automovel : Veiculo
    {
        public Automovel(string tipoModelo) : base(tipoModelo)
        { }
        public override void Mover()
        {
            Console.WriteLine("Acelerando o automovel");
        }
        public override void Parar()
        {
            Console.WriteLine("Parando o automovel.");
        }

        public void Parar(string comoParar)
        {
            Console.WriteLine("Parando o Automovel: " + comoParar);
        }

    }
}
