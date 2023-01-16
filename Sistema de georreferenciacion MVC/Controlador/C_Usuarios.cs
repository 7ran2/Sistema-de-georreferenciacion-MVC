using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class C_Usuarios
    {
        private M_Usuarios objeto_M = new M_Usuarios();
        public DataTable MostrarUsuarios_C()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_M.MostrarUsuarios_M();
            return tabla;
        }
        public void InsertarUsuarios_C(string id_socio, string usuario, string clave, string id_cargo, string estado_u, string usuario_u)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.InsertarUsuario_M( Convert.ToInt32(id_socio),  usuario,  clave, Convert.ToInt32(id_cargo),  estado_u,  usuario_u);
        }
        public void ModificarUsuarios_C(string id_usuario, string id_socio, string usuario, string clave, string id_cargo, string estado_u, string usuario_u)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.ModificarUsuario_M( Convert.ToInt32(id_usuario), Convert.ToInt32(id_socio), usuario, clave, Convert.ToInt32(id_cargo), estado_u, usuario_u);
        }
        public void EliminarUsuarios_C(string id, string usuario_u)
        {
            //Aqui se validan los datos, si es necesario hacer conversion, hay que hacerlo.
            objeto_M.EliminarUsuario_M(Convert.ToInt32(usuario_u), usuario_u);
        }
    }
}
