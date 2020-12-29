using System;
using System.Collections.Generic;
using System.Text;

namespace Cap11oop2
{
    public class Barco : Veiculo
    {
        public Barco(string tipoModelo) : base(tipoModelo)
        { }
        public override void Mover()
        {
            Console.WriteLine("Acelerando barco");
        }
        public override void Parar()
        {
            Console.WriteLine("Atracando barco no porto.");
        }

    }
}
