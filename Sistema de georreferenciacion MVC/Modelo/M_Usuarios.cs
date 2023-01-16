using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Modelo
{
    public class M_Usuarios
    {
        private M_Concexion conexion = new M_Concexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarUsuarios_M()
        {
            ////Procedimientos almacenados
            comando = new SqlCommand();//Refrescar comando
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CRUD_Usuarios_SP";
            comando.Parameters.AddWithValue("@modo", "V");
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void InsertarUsuario_M(int id_socio, string usuario, string clave, int id_cargo, string estado_u, string usuario_u)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "CRUD_Usuarios_SP";
            comando.Parameters.AddWithValue("@modo", "I");
            comando.Parameters.AddWithValue("@id_socio", id_socio);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@clave", clave);
            comando.Parameters.AddWithValue("@id_cargo", id_cargo);
            comando.Parameters.AddWithValue("@estado_u", estado_u);
            comando.Parameters.AddWithValue("@usuario_u", usuario_u);
            comando.ExecuteNonQuery();

        }
        public void ModificarUsuario_M(int id_usuario, int id_socio, string usuario, string clave, int id_cargo, string estado_u, string usuario_u)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "CRUD_Usuarios_SP";
            comando.Parameters.AddWithValue("@modo", "U");
            comando.Parameters.AddWithValue("@id_usuario", id_usuario);
            comando.Parameters.AddWithValue("@id_socio", id_socio);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@clave", clave);
            comando.Parameters.AddWithValue("@id_cargo", id_cargo);
            comando.Parameters.AddWithValue("@estado_u", estado_u);
            comando.Parameters.AddWithValue("@usuario_u", usuario_u);
            comando.ExecuteNonQuery();

        }
        public void EliminarUsuario_M(int id_usuario, string usuario_u)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "CRUD_Usuarios_SP";
            comando.Parameters.AddWithValue("@modo", "D");
            comando.Parameters.AddWithValue("@id_usuario", id_usuario);
            comando.Parameters.AddWithValue("@usuario_u", usuario_u);
            comando.ExecuteNonQuery();

        }
    }
}
