using CEOEye.Negocio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEOEye.Datos
{
    class ClienteDAO
    {
        MySqlConexion conexion = new MySqlConexion();

        public ClienteDAO()
        {

        }

        public Boolean AgregarCliente(Cliente cliente)
        {
            conexion.Conectar();    
        
            if (conexion != null)
            {
                String dni,nombre, apellidos, telefono, direccion, mail, contacto, fecha;
                dni = cliente.getDni();
                nombre = cliente.getNombre();
                apellidos = cliente.getApellidos();
                telefono = cliente.getTelefono();
                direccion = cliente.getDireccion();
                mail = cliente.getMail();
                contacto = cliente.getContacto();
                DateTime thisDay = DateTime.Today;
                fecha = thisDay.ToString("d");

                try { 

                    String sql = "insert into cliente(dni,nombre,apellidos,telefono" +
                      ",direccion,mail,contacto,fecha) values ('" + dni + "','" + nombre + "','" + apellidos + "','" +
                       telefono + "','" + direccion + "','" + mail + "','" + contacto +"','" + fecha +"');";
                    conexion.insertarDatos(sql);
                    return true;
                }
                catch
                {
                    // Gestionar DNI repetidos
                    MessageBox.Show("Error de ingreso");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Problema de conexión a BBDD");
                return false;
            }

        }

        public static Boolean EliminarCliente(Cliente cliente, MySqlConnection conexion)
        {
            if (conexion != null)
            {
                return true;
            }
            else
                return false;
        }

        public static Boolean ActualizarCliente(Cliente cliente, MySqlConnection conexion)
        {
            if (conexion != null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
