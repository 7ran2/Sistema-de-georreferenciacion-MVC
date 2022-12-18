using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class C_Georreferenciaciones
    {
        private M_Georreferenciaciones objeto_M = new M_Georreferenciaciones();
        public DataTable MostrarTrayectorias_C()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_M.MostrarTrayectorias_M();
            return tabla;
        }

        public int CantidadTrayectorias_C(string Nombre, int Orden)
        {
            int cantidadTrayectorias;
            cantidadTrayectorias = objeto_M.CantidadTrayectorias_M(Nombre,Orden);
            return cantidadTrayectorias;
        }
        public DataTable MostrarGeorreferenciaciones_C()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_M.MostrarGeorreferenciaciones_M();
            return tabla;
        }
    }
}
