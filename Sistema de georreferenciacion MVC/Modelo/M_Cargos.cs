using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_Cargos
    {
        private M_Concexion conexion = new M_Concexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarCargos_M()
        {
            ////Procedimientos almacenados
            comando = new SqlCommand();//Refrescar comando
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CRUD_Cargos_SP";
            comando.Parameters.AddWithValue("@modo", "V");
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void InsertarCargo_M(string nombre_c, int nivel_acceso, string descripcion, string usuario_c)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "CRUD_Cargos_SP";
            comando.Parameters.AddWithValue("@modo", "I");
            comando.Parameters.AddWithValue("@nombre_c", nombre_c);
            comando.Parameters.AddWithValue("@nivel_acceso", nivel_acceso);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@usuario_c", usuario_c);
            comando.ExecuteNonQuery();

        }
        public void ModificarCargo_M(int id_cargo, string nombre_c, int nivel_acceso, string descripcion, string usuario_c)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "CRUD_Cargos_SP";
            comando.Parameters.AddWithValue("@modo", "U");
            comando.Parameters.AddWithValue("@id_cargo", id_cargo);
            comando.Parameters.AddWithValue("@nombre_c", nombre_c);
            comando.Parameters.AddWithValue("@nivel_acceso", nivel_acceso);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@usuario_c", usuario_c);
            comando.ExecuteNonQuery();

        }
        public void EliminarCargo_M(int id_cargo, string usuario_c)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "CRUD_Cargos_SP";
            comando.Parameters.AddWithValue("@modo", "D");
            comando.Parameters.AddWithValue("@id_cargo", id_cargo);
            comando.Parameters.AddWithValue("@usuario_c", usuario_c);
            comando.ExecuteNonQuery();

        }
    }
}
