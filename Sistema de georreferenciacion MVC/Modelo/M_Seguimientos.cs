using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Modelo
{
    public class M_Seguimientos
    {
        private M_Concexion conexion = new M_Concexion();

        //SqlDataReader leer;
        //DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable MostrarSeguimientos_M()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            
            ////Procedimientos almacenados
            comando = new SqlCommand();//Refrescar comando
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CRUD_SEGUIMIENTOS_SP";
            comando.Parameters.AddWithValue("@modo", "V");
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable ListarTrayectorias()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            
            ////Procedimientos almacenados
            comando = new SqlCommand();//Refrescar comando
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CRUD_SEGUIMIENTOS_SP";
            comando.Parameters.AddWithValue("@modo", "T");
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void InsertarSeguimiento_M(string id_socio, string metros_cubicos, string litros, string fecha_hora, string estado_s, string usuario_s)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "CRUD_SEGUIMIENTOS_SP";
            comando.Parameters.AddWithValue("@modo", "I");
            comando.Parameters.AddWithValue("@id_socio", id_socio);
            comando.Parameters.AddWithValue("@metros_cubicos", metros_cubicos);
            comando.Parameters.AddWithValue("@litros", litros);
            comando.Parameters.AddWithValue("@fecha_hora", fecha_hora);
            comando.Parameters.AddWithValue("@estado_s", estado_s);
            comando.Parameters.AddWithValue("@usuario_s", usuario_s);
            comando.ExecuteNonQuery();

        }
        public void ModificarSeguimiento_M(string id_socio, string metros_cubicos, string litros, string fecha_hora, string estado_s, string usuario_s)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "CRUD_SEGUIMIENTOS_SP";
            comando.Parameters.AddWithValue("@modo", "U");
            comando.Parameters.AddWithValue("@id_socio", id_socio);
            comando.Parameters.AddWithValue("@metros_cubicos", metros_cubicos);
            comando.Parameters.AddWithValue("@litros", litros);
            comando.Parameters.AddWithValue("@fecha_hora", fecha_hora);
            comando.Parameters.AddWithValue("@estado_s", estado_s);
            comando.Parameters.AddWithValue("@usuario_s", usuario_s);
            comando.ExecuteNonQuery();

        }
        public void EliminarSeguimiento_M(int id_seguimiento, string usuario_s)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "CRUD_SEGUIMIENTOS_SP";
            comando.Parameters.AddWithValue("@modo", "D");
            comando.Parameters.AddWithValue("@id_seguimiento", id_seguimiento);
            comando.Parameters.AddWithValue("@usuario_s", usuario_s);
            comando.ExecuteNonQuery();

        }
    }
}
