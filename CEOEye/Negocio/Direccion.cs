using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEOEye.Negocio
{
    class Direccion
    {
        public Direccion(int cp, int numero, string calle, string ciudad)
        {
            this.cp = cp;
            this.numero = numero;
            this.calle = calle;
            this.ciudad = ciudad;
        }

        private int cp { get => cp; set => cp = value; }
        private int numero { get => numero; set => numero = value; }
        private string calle { get => calle; set => calle = value; }
        private string ciudad { get => ciudad; set => ciudad = value; }
    }
}
