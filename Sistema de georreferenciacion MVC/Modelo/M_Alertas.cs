using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_Alertas
    {
        private M_Concexion conexion = new M_Concexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarAlertas_M()
        {
            ////Procedimientos almacenados
            comando = new SqlCommand();//Refrescar comando
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ALERTAS_SP";
            comando.Parameters.AddWithValue("@modo", "V");
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void InsertarAlerta_M(int id_Trayectoria, string usuario_alerta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "ALERTAS_SP"; 
            comando.Parameters.AddWithValue("@modo", "I");
            comando.Parameters.AddWithValue("@id_Trayectoria", id_Trayectoria);
            comando.Parameters.AddWithValue("@usuario_alerta", usuario_alerta);
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

        }
    }
}
