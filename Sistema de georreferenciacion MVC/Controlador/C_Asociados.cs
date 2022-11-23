using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Modelo;
using System.Diagnostics.Tracing;

namespace Controlador
{
    public class C_Asociados
    {
        private M_Asociados objeto_M = new M_Asociados();
        public DataTable MostrarAsociados_C()
        {
            DataTable tabla = new DataTable();
            tabla=objeto_M.MostrarAsociados_M();
            return tabla;
        }
        public void InsertarAsociados_C(string carnet, string nombres, string apellidos, string fecha_nacimiento, string estado,string usuario)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.InsertarAsociado_M(Convert.ToInt32(carnet), nombres, apellidos, Convert.ToDateTime(fecha_nacimiento), estado,usuario);
        }
    }
}
