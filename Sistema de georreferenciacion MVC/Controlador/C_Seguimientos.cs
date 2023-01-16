using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class C_Seguimientos
    {

        private M_Seguimientos objeto_M = new M_Seguimientos();
        public DataTable MostrarSeguimientos_C()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_M.MostrarSeguimientos_M();
            return tabla;
        }
        public DataTable ListarSeguimientos_C()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_M.ListarTrayectorias();
            return tabla;
        }
        public void InsertarSeguimientos_C(string id_trayectoria, string inicial_o_final_s, string litros, string estado_s, string usuario_s)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.InsertarSeguimiento_M(Convert.ToInt32(id_trayectoria), Convert.ToInt32(inicial_o_final_s), Convert.ToInt32(litros), estado_s, usuario_s);
        }
        public void ModificarSeguimientos_C(string id_trayectoria, string inicial_o_final_s, string metros_cubicos, string estado_s, string usuario_s)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.ModificarSeguimiento_M(Convert.ToInt32(id_trayectoria), Convert.ToInt32(inicial_o_final_s), Convert.ToInt32(metros_cubicos), estado_s, usuario_s);
        }
        public void EliminarSeguimientos_C(string id_seguimiento, string usuario_s)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.EliminarSeguimiento_M(Convert.ToInt32(id_seguimiento), usuario_s);
        }
    }
}
