using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class C_Trayectorias
    {
        private M_Trayectorias objeto_M = new M_Trayectorias();
        public DataTable MostrarTrayectorias_C()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_M.MostrarTrayectorias_M();
            return tabla;
        }
        public void InsertarTrayectorias_C(string inicio_t, string final_t, string nombre_t, string num_orden_t, string estado_t, string usuario_t)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.InsertarTrayectoria_M(inicio_t, final_t, nombre_t,Convert.ToInt32(num_orden_t), estado_t, usuario_t);
        }
        public void ModificarTrayectorias_C(string inicio_t, string final_t, string nombre_t, int num_orden_t, string estado_t, string usuario_t)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.ModificarTrayectoria_M(inicio_t, final_t, nombre_t, num_orden_t, estado_t, usuario_t);
        }
        public void EliminarTrayectorias_C(string id_trayectoria, string usuario_t)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.EliminarTrayectoria_M(Convert.ToInt32(id_trayectoria), usuario_t);
        }
    }
}
