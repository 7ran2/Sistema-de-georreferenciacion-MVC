using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_Georreferenciaciones
    {
        private M_Concexion conexion = new M_Concexion();

        SqlDataReader leer;
        //DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable ListarTrayectorias_M()
        {
            DataTable tabla = new DataTable();
            ////Procedimientos almacenados
            comando = new SqlCommand();//Refrescar comando
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CRUD_TRAYECTORIAS_SP";
            comando.Parameters.AddWithValue("@modo", "L");
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable ListarTipos_M()
        {
            DataTable tabla = new DataTable();
            ////Procedimientos almacenados
            comando = new SqlCommand();//Refrescar comando
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CRUD_TRAYECTORIAS_SP";
            comando.Parameters.AddWithValue("@modo", "T");
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public int CantidadTrayectorias_M(string Nombre, int Orden)
        {
            DataTable tabla = new DataTable();
            int cantidadTrayectorias;
            comando = new SqlCommand();//Refrescar comando
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CRUD_TRAYECTORIAS_SP";
            comando.Parameters.AddWithValue("@modo", "C");
            comando.Parameters.AddWithValue("@nombre_t", Nombre);
            comando.Parameters.AddWithValue("@num_orden_t",(Orden));
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            cantidadTrayectorias = tabla.Rows.Count;
            conexion.CerrarConexion();
            return cantidadTrayectorias;
        }
        public DataTable MostrarGeorreferenciaciones_M()
        {
            DataTable tabla = new DataTable();
            ////Procedimientos almacenados
            comando = new SqlCommand();//Refrescar comando
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CRUD_GEORREFERENCIACIONES_SP";
            comando.Parameters.AddWithValue("@modo", "V");
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void InsertarGeorreferenciaciones_M(string id_trayectoria, string latitud_g, string longitud_g, int profundidad_g, string tipo_g, string descripcion_g, string estado_g, string usuario_g)
        {
            comando = new SqlCommand();//Refrescar comando
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "CRUD_GEORREFERENCIACIONES_SP";
            comando.Parameters.AddWithValue("@modo", "I");
            comando.Parameters.AddWithValue("@id_trayectoria", id_trayectoria);
            comando.Parameters.AddWithValue("@latitud_g", latitud_g);
            comando.Parameters.AddWithValue("@longitud_g", longitud_g);
            comando.Parameters.AddWithValue("@profundidad_g", profundidad_g);
            comando.Parameters.AddWithValue("@tipo_g", tipo_g);
            comando.Parameters.AddWithValue("@descripcion_g", descripcion_g);
            comando.Parameters.AddWithValue("@estado_g", estado_g);
            comando.Parameters.AddWithValue("@usuario_g", usuario_g);
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteReader();
            conexion.CerrarConexion();
        }
    }
}
