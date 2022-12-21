using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class C_Georreferenciaciones
    {
        private M_Georreferenciaciones objeto_M = new M_Georreferenciaciones();
        public DataTable ListarTrayectorias_C()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_M.ListarTrayectorias_M();
            return tabla;
        }
        public DataTable ListarTipos_C()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_M.ListarTipos_M();
            return tabla;
        }
        public int CantidadTrayectorias_C(string Nombre, int Orden)
        {
            int cantidadTrayectorias;
            cantidadTrayectorias = objeto_M.CantidadTrayectorias_M(Nombre,Orden);
            return cantidadTrayectorias;
        }
        public DataTable MostrarGeorreferenciaciones_C()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_M.MostrarGeorreferenciaciones_M();
            return tabla;
        }
        public void InsertarGeorreferenciaciones_C(string id_trayectoria, string latitud_g, string longitud_g, int profundidad_g, string tipo_g, string descripcion_g, string estado_g, string usuario_g)
        {
            objeto_M.InsertarGeorreferenciaciones_M(id_trayectoria, latitud_g, longitud_g, profundidad_g, tipo_g, descripcion_g, estado_g, usuario_g);
        }
    }
}
