using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_Tipos
    {
        private M_Concexion conexion = new M_Concexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarTipos_M()
        {
            ////Procedimientos almacenados
            comando = new SqlCommand();//Refrescar comando
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CRUD_Tipos_SP";
            comando.Parameters.AddWithValue("@modo", "V");
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void InsertarTipo_M(int tipo_gt, string nombre_gt, string estado_g, string usuario_g)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "CRUD_Tipos_SP";
            comando.Parameters.AddWithValue("@modo", "I");
            comando.Parameters.AddWithValue("@tipo_gt", tipo_gt);
            comando.Parameters.AddWithValue("@nombre_gt", nombre_gt);
            comando.Parameters.AddWithValue("@estado_g", estado_g);
            comando.Parameters.AddWithValue("@usuario_g", usuario_g);
            comando.ExecuteNonQuery();

        }
        public void ModificarTipo_M(int tipo_gt, string nombre_gt, string estado_g, string usuario_g)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "CRUD_Tipos_SP";
            comando.Parameters.AddWithValue("@modo", "U");
            comando.Parameters.AddWithValue("@tipo_gt", tipo_gt);
            comando.Parameters.AddWithValue("@nombre_gt", nombre_gt);
            comando.Parameters.AddWithValue("@estado_g", estado_g);
            comando.Parameters.AddWithValue("@usuario_g", usuario_g);
            comando.ExecuteNonQuery();

        }
        public void EliminarTipo_M(int tipo_gt, string usuario_g)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "CRUD_Tipos_SP";
            comando.Parameters.AddWithValue("@modo", "D");
            comando.Parameters.AddWithValue("@tipo_gt", tipo_gt);
            comando.Parameters.AddWithValue("@usuario_g", usuario_g);
            comando.ExecuteNonQuery();

        }
    }
}
