using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controlador
{
    public class C_Login
    {
        private M_Login objeto_M = new M_Login();
        public DataTable Login_C(string usuario,string clave)
        {
            DataTable tabla = new DataTable();
            tabla = objeto_M.Login_M(usuario,clave);
            return tabla;
        }
    }
}
