using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CEOEye.Datos
{
    public class MySqlConexion
    {
        static MySqlConnection conexion = new MySqlConnection();
        static String serv = "Server = localhost;";
        static String db = "Database = alpendre;";
        static String usuario = "UID = root;";
        static String pwd = "Password = zebrahead;";

        string CadenaConexion = serv + db + usuario + pwd;

        static MySqlCommand comando = new MySqlCommand();
        static MySqlDataAdapter adaptador = new MySqlDataAdapter();

        public void Conectar()
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Desconectar()
        {
            conexion.Close();
        }

        public void insertarDatos(String sql)
        {
            comando.CommandText = sql;
            comando.Connection = conexion;
            comando.ExecuteNonQuery();
            MessageBox.Show("Datos introducido correctamente");
        }
    }
}
