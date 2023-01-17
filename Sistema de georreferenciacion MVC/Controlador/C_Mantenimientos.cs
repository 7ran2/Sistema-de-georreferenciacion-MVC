using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class C_Mantenimientos
    {
        private M_Mantenimientos objeto_M = new M_Mantenimientos();
        public DataTable ListarTrayectorias_C()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_M.ListarTrayectorias_M();
            return tabla;
        }
        public DataTable ListarSeguimientos_C()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_M.ListarSeguimientos_M();
            return tabla;
        }
        public DataTable MostrarMantenimientos_C()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_M.MostrarMantenimientos_M();
            return tabla;
        }
        public void InsertarMantenimientos_C(string id_seguimiento, string id_geo, string asignacion_trabajo, string descripcion_m, string fecha_hora_inicio, string fecha_hora_final, string estado_m, string usuario_m)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.InsertarMantenimiento_M(Convert.ToInt32(id_seguimiento), Convert.ToInt32(id_geo), asignacion_trabajo, descripcion_m, fecha_hora_inicio, fecha_hora_final, estado_m, usuario_m);
        }
        public void ModificarMantenimientos_C(int id_seguimiento, int id_geo, string asignacion_trabajo, string descripcion_m, string fecha_hora_inicio, string fecha_hora_final, string estado_m, string usuario_m)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.ModificarMantenimiento_M(id_seguimiento, id_geo, asignacion_trabajo, descripcion_m, fecha_hora_inicio, fecha_hora_final, estado_m, usuario_m);
        }
        public void EliminarMantenimientos_C(string id, string usuario)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.EliminarMantenimiento_M(Convert.ToInt32(id), usuario);
        }
    }
}
