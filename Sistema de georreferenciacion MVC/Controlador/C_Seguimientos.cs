using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    internal class C_Seguimientos
    {

        private M_Seguimientos objeto_M = new M_Seguimientos();
        public DataTable MostrarSeguimientos_C()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_M.MostrarSeguimientos_M();
            return tabla;
        }
        public void InsertarSeguimientos_C(string id_socio, string metros_cubicos, string litros, string fecha_hora, string estado_s, string usuario_s)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.InsertarSeguimiento_M(id_socio, metros_cubicos, litros, fecha_hora, estado_s, usuario_s);
        }
        public void ModificarSeguimientos_C(string id_socio, string metros_cubicos, string litros, string fecha_hora, string estado_s, string usuario_s)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.ModificarSeguimiento_M(id_socio, metros_cubicos, litros, fecha_hora, estado_s, usuario_s);
        }
        public void EliminarSeguimientos_C(string id_seguimiento, string usuario_s)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.EliminarSeguimiento_M(Convert.ToInt32(id_seguimiento), usuario_s);
        }
    }
}
