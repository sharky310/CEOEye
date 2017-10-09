using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEOEye.Negocio
{
    class Cliente
    {

        public Cliente(String dni, String nombre, String apellidos, String telefono, String direccion, String mail, String contacto)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.direccion = direccion;
            this.mail = mail;
            this.contacto = contacto;
        }

        public Cliente()
        {

        }

        private String dni;
        private String nombre;
        private String apellidos;
        private String telefono;
        private String direccion;
        private String mail;
        private String contacto;

        public String getDni()
        {
            return this.dni;
        }

        public void setDni(String dni)
        {
            this.dni = dni;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getApellidos()
        {
            return this.apellidos;
        }

        public void setApellidos(String apellidos)
        {
            this.apellidos = apellidos;
        }

        public String getTelefono()
        {
            return this.telefono;
        }

        public void setTelefono(String telefono)
        {
            this.telefono = telefono;
        }

        public String getDireccion()
        {
            return this.direccion;
        }

        public void setDireccion(String direccion)
        {
            this.direccion = direccion;
        }

        public String getMail()
        {
            return this.mail;
        }

        public void setMail(String mail)
        {
            this.mail = mail;
        }

        public String getContacto()
        {
            return this.contacto;
        }
        
        public void setContacto(String contacto)
        {
            this.contacto = contacto;
        }


    }
}
