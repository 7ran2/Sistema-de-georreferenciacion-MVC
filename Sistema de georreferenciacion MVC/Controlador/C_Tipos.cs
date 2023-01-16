using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class C_Tipos
    {
        private M_Tipos objeto_M = new M_Tipos();
        public DataTable MostrarTipos_C()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_M.MostrarTipos_M();
            return tabla;
        }
        public void InsertarTipos_C(int tipo_gt, string nombre_gt, string estado_g, string usuario_g)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.InsertarTipo_M( tipo_gt,  nombre_gt,  estado_g,  usuario_g);
        }
        public void ModificarTipos_C(int tipo_gt, string nombre_gt, string estado_g, string usuario_g)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.ModificarTipo_M(tipo_gt, nombre_gt, estado_g, usuario_g);
        }
        public void EliminarTipos_C(string tipo_gt, string usuario_g)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.EliminarTipo_M(Convert.ToInt32(tipo_gt), usuario_g);
        }
    }
}
