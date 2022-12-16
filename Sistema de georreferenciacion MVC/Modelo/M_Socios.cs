using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace Modelo
{
    public class M_Socios
    {
        private M_Concexion conexion = new M_Concexion();

        SqlDataReader leer;
        DataTable tabla=new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarSocios_M()
        {
            ////Procedimientos almacenados
            comando = new SqlCommand();//Refrescar comando
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CRUD_SOCIOS_SP";
            comando.Parameters.AddWithValue("@modo", "V");
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void InsertarSocio_M(int carnet,string extension,string nombres,string apellidos,string tipo,DateTime fecha_nacimiento,string estado,string usuario)
        {
            comando.Connection=conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "CRUD_SOCIOS_SP";
            comando.Parameters.AddWithValue("@modo", "I");
            comando.Parameters.AddWithValue("@carnet_s", carnet);
            comando.Parameters.AddWithValue("@extension_s", extension);
            comando.Parameters.AddWithValue("@nombres_s", nombres);
            comando.Parameters.AddWithValue("@apellidos_s", apellidos);
            comando.Parameters.AddWithValue("@tipo_s", tipo);
            comando.Parameters.AddWithValue("@fecha_nacimiento_s", fecha_nacimiento);
            comando.Parameters.AddWithValue("@estado_s", estado);
            comando.Parameters.AddWithValue("@usuario_s", usuario);
            comando.ExecuteNonQuery();

        }
        public void ModificarSocio_M(int id, int carnet, string extension, string nombres, string apellidos, string tipo, DateTime fecha_nacimiento, string estado, string usuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "CRUD_SOCIOS_SP";
            comando.Parameters.AddWithValue("@modo", "U");
            comando.Parameters.AddWithValue("@id_socio", id);
            comando.Parameters.AddWithValue("@carnet_s", carnet);
            comando.Parameters.AddWithValue("@extension_s", extension);
            comando.Parameters.AddWithValue("@nombres_s", nombres);
            comando.Parameters.AddWithValue("@apellidos_s", apellidos);
            comando.Parameters.AddWithValue("@tipo_s", tipo);
            comando.Parameters.AddWithValue("@fecha_nacimiento_s", fecha_nacimiento);
            comando.Parameters.AddWithValue("@estado_s", estado);
            comando.Parameters.AddWithValue("@usuario_s", usuario);
            comando.ExecuteNonQuery();

        }
        public void EliminarSocio_M(int id, string usuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "CRUD_SOCIOS_SP";
            comando.Parameters.AddWithValue("@modo", "D");
            comando.Parameters.AddWithValue("@id_socio", id);
            comando.Parameters.AddWithValue("@usuario_s", usuario);
            comando.ExecuteNonQuery();

        }
    }
}
