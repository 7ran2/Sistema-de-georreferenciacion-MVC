using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_Mantenimientos
    {

        private M_Concexion conexion = new M_Concexion();

        SqlDataReader leer;
        //DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable ListarTrayectorias_M()
        {
            DataTable TablaTrayectorias= new DataTable();
            ////Procedimientos almacenados
            comando = new SqlCommand();//Refrescar comando
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CRUD_Mantenimientos_SP";
            comando.Parameters.AddWithValue("@modo", "T");
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            TablaTrayectorias.Clear();
            TablaTrayectorias.Load(leer);
            conexion.CerrarConexion();
            return TablaTrayectorias;
        }
        public DataTable ListarSeguimientos_M()
        {
            DataTable tabla = new DataTable();
            ////Procedimientos almacenados
            comando = new SqlCommand();//Refrescar comando
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CRUD_Mantenimientos_SP";
            comando.Parameters.AddWithValue("@modo", "S");
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable MostrarMantenimientos_M()
        {
            DataTable tabla = new DataTable();
            ////Procedimientos almacenados
            comando = new SqlCommand();//Refrescar comando
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CRUD_Mantenimientos_SP";
            comando.Parameters.AddWithValue("@modo", "V");
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void InsertarMantenimiento_M(int id_seguimiento, int id_geo, string asignacion_trabajo, string descripcion_m, string fecha_hora_inicio, string fecha_hora_final, string estado_m, string usuario_m)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "CRUD_Mantenimientos_SP";
            comando.Parameters.AddWithValue("@modo", "I");
            comando.Parameters.AddWithValue("@id_seguimiento", id_seguimiento);
            comando.Parameters.AddWithValue("@id_geo", id_geo);
            comando.Parameters.AddWithValue("@asignacion_trabajo", asignacion_trabajo);
            comando.Parameters.AddWithValue("@descripcion_m", descripcion_m);
            comando.Parameters.AddWithValue("@fecha_hora_inicio", fecha_hora_inicio);
            comando.Parameters.AddWithValue("@fecha_hora_final", fecha_hora_final);
            comando.Parameters.AddWithValue("@estado_m", estado_m);
            comando.Parameters.AddWithValue("@usuario_m", usuario_m);
            comando.ExecuteNonQuery();

        }
        public void ModificarMantenimiento_M(int id_seguimiento, int id_geo, string asignacion_trabajo, string descripcion_m, string fecha_hora_inicio, string fecha_hora_final, string estado_m, string usuario_m)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "CRUD_Mantenimientos_SP";
            comando.Parameters.AddWithValue("@modo", "U");
            comando.Parameters.AddWithValue("@id_seguimiento", id_seguimiento);
            comando.Parameters.AddWithValue("@id_geo", id_geo);
            comando.Parameters.AddWithValue("@asignacion_trabajo", asignacion_trabajo);
            comando.Parameters.AddWithValue("@descripcion_m", descripcion_m);
            comando.Parameters.AddWithValue("@fecha_hora_inicio", fecha_hora_inicio);
            comando.Parameters.AddWithValue("@fecha_hora_final", fecha_hora_final);
            comando.Parameters.AddWithValue("@estado_m", estado_m);
            comando.Parameters.AddWithValue("@usuario_m", usuario_m);
            comando.ExecuteNonQuery();

        }
        public void EliminarMantenimiento_M(int id_mantenimiento, string usuario_m)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "CRUD_Mantenimientos_SP";
            comando.Parameters.AddWithValue("@modo", "D");
            comando.Parameters.AddWithValue("@id_mantenimiento", id_mantenimiento);
            comando.Parameters.AddWithValue("@usuario_m", usuario_m);
            comando.ExecuteNonQuery();

        }

    }
}
