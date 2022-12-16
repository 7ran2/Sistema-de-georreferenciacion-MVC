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
    public class C_Socios
    {
        private M_Socios objeto_M = new M_Socios();
        public DataTable MostrarSocios_C()
        {
            DataTable tabla = new DataTable();
            tabla=objeto_M.MostrarSocios_M();
            return tabla;
        }
        public void InsertarSocios_C(string carnet,string extension, string nombres, string apellidos, string tipo, string fecha_nacimiento, string estado,string usuario)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.InsertarSocio_M(Convert.ToInt32(carnet),extension, nombres, apellidos,tipo, Convert.ToDateTime(fecha_nacimiento), estado,usuario);
        }
        public void ModificarSocios_C(string id, string carnet, string extension, string nombres, string apellidos,string tipo, string fecha_nacimiento, string estado, string usuario)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.ModificarSocio_M(Convert.ToInt32(id),Convert.ToInt32(carnet),extension, nombres, apellidos,tipo, Convert.ToDateTime(fecha_nacimiento), estado, usuario);
        }
        public void EliminarSocios_C(string id, string usuario)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.EliminarSocio_M(Convert.ToInt32(id),usuario);
        }
    }
}
