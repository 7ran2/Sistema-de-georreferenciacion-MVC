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

        public void InsertarAlerta_C(string id_Trayectoria, string usuario_alerta)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.InsertarAlerta_M(Convert.ToInt32(id_Trayectoria),usuario_alerta);
        }
    }
}
