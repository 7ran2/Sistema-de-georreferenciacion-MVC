using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Modelo
{
    public class M_Asociados
    {
        private M_Concexion conexion = new M_Concexion();

        SqlDataReader leer;
        DataTable tabla=new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarAsociados_M()
        {
            ////Transact
            //comando.Connection = conexion.AbrirConexion();
            //comando.CommandText = "select * from asociados";
            //leer = comando.ExecuteReader();
            //tabla.Load(leer);
            //conexion.CerrarConexion();
            //return tabla;
            ////Procedimientos almacenados
            comando = new SqlCommand();//Refrescar comando
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarAsociados_SP";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void InsertarAsociado_M(int carnet,string nombres,string apellidos,DateTime fecha_nacimiento,string estado,string usuario)
        {
            comando.Connection=conexion.AbrirConexion();
            comando.CommandText = "InsertarAsociados_SP";
            comando.Parameters.AddWithValue("@carnet_a", carnet);
            comando.Parameters.AddWithValue("@nombres_a", nombres);
            comando.Parameters.AddWithValue("@apellidos_a", apellidos);
            comando.Parameters.AddWithValue("@fecha_nacimiento_a", fecha_nacimiento);
            comando.Parameters.AddWithValue("@estado_a", estado);
            comando.Parameters.AddWithValue("@usuario_a", usuario);
            comando.ExecuteNonQuery();

        }
    }
}
