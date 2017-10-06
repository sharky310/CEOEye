using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEOEye.Negocio
{
    class Cliente
    {

        public Cliente(string dni, string nombre, string apellidos, string telefono, string direccion, string mail, string contacto)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.direccion = direccion;
            this.mail = mail;
            this.contacto = contacto;
        }

        private string dni { get => dni; set => dni = value; }
        private string nombre { get => nombre; set => nombre = value; }
        private string apellidos { get => apellidos; set => apellidos = value; }
        private string telefono { get => telefono; set => telefono = value; }
        private string direccion { get => direccion; set => direccion = value; }
        private string mail { get => mail; set => mail = value; }
        private string contacto { get => contacto; set => contacto = value; }
    }
}
