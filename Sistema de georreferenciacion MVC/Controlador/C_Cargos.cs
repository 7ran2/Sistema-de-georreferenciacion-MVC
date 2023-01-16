using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    internal class C_Cargos
    {
        private M_Cargos objeto_M = new M_Cargos();
        public DataTable MostrarCargos_C()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_M.MostrarCargos_M();
            return tabla;
        }
        public void InsertarCargos_C(string nombre_c, string nivel_acceso, string descripcion, string usuario_c)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.InsertarCargo_M( nombre_c, Convert.ToInt32(nivel_acceso),  descripcion,  usuario_c);
        }
        public void ModificarCargos_C(string id_cargo,string nombre_c, string nivel_acceso, string descripcion, string usuario_c)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.ModificarCargo_M(Convert.ToInt32(id_cargo),nombre_c, Convert.ToInt32(nivel_acceso), descripcion, usuario_c);
        }
        public void EliminarCargos_C(string id_cargo, string usuario_c)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.EliminarCargo_M(Convert.ToInt32(id_cargo), usuario_c);
        }
    }
}
