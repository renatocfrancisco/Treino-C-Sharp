using System;
using System.Collections.Generic;
using System.Text;

namespace Cap11oop2
{
    public class Veiculo
    {
        public string TipoModelo { get; private set; }
        public Veiculo(string tipoModelo)
        {
            this.TipoModelo = tipoModelo;
        }
        public virtual void Mover()
        { }

        public virtual void Parar() { }

    }
}
