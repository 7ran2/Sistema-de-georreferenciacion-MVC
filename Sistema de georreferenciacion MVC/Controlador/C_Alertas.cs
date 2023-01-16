using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class C_Alertas
    {
        private M_Alertas objeto_M = new M_Alertas();
        public DataTable MostrarUsuarios_C()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_M.MostrarAlertas_M();
            return tabla;
        }
    }
}
