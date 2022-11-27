using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;

namespace Modelo
{
    public class M_Login
    {
        private M_Concexion conexion = new M_Concexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Login_M(string usuario, string clave)
        {
            comando = new SqlCommand();//Refrescar comando
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "LOGIN_SP";
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@clave", clave);
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
