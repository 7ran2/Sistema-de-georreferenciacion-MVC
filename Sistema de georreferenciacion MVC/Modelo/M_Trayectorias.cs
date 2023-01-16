using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_Trayectorias
    {
        private M_Concexion conexion = new M_Concexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarTrayectorias_M()
        {
            ////Procedimientos almacenados
            comando = new SqlCommand();//Refrescar comando
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CRUD_TRAYECTORIAS_SP";
            comando.Parameters.AddWithValue("@modo", "V");
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void InsertarTrayectoria_M(string inicio_t, string final_t, string nombre_t, int num_orden_t, string estado_t, string usuario_t)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "CRUD_TRAYECTORIAS_SP";
            comando.Parameters.AddWithValue("@modo", "I");
            comando.Parameters.AddWithValue("@inicio_t", inicio_t);
            comando.Parameters.AddWithValue("@final_t", final_t);
            comando.Parameters.AddWithValue("@nombre_t", nombre_t);
            comando.Parameters.AddWithValue("@num_orden_t", num_orden_t);
            comando.Parameters.AddWithValue("@estado_t", estado_t);
            comando.Parameters.AddWithValue("@usuario_t", usuario_t);
            comando.ExecuteNonQuery();

        }
        public void ModificarTrayectoria_M(string inicio_t, string final_t, string nombre_t, int num_orden_t, string estado_t, string usuario_t)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "CRUD_TRAYECTORIAS_SP";
            comando.Parameters.AddWithValue("@modo", "U");
            comando.Parameters.AddWithValue("@inicio_t", inicio_t);
            comando.Parameters.AddWithValue("@final_t", final_t);
            comando.Parameters.AddWithValue("@nombre_t", nombre_t);
            comando.Parameters.AddWithValue("@num_orden_t", num_orden_t);
            comando.Parameters.AddWithValue("@estado_t", estado_t);
            comando.Parameters.AddWithValue("@usuario_t", usuario_t);
            comando.ExecuteNonQuery();

        }
        public void EliminarTrayectoria_M(int id_trayectoria, string usuario_t)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "CRUD_TRAYECTORIAS_SP";
            comando.Parameters.AddWithValue("@modo", "D");
            comando.Parameters.AddWithValue("@id_trayectoria", id_trayectoria);
            comando.Parameters.AddWithValue("@usuario_t", usuario_t);
            comando.ExecuteNonQuery();

        }
    }
}
