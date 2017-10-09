using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEOEye.Negocio
{
    class Direccion
    {
        public Direccion(int cp, int numero, String calle, String ciudad)
        {
            this.cp = cp;
            this.numero = numero;
            this.calle = calle;
            this.ciudad = ciudad;
        }

        private int cp { get => cp; set => cp = value; }
        private int numero { get => numero; set => numero = value; }
        private String calle { get => calle; set => calle = value; }
        private String ciudad { get => ciudad; set => ciudad = value; }
    }
}
