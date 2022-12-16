using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    internal class M_Concexion
    {
        private SqlConnection Conexion = new SqlConnection("Server=GWNR71517\\SQLEXPRESS;DataBase=SGSRCAP;Integrated Security=true");
        public SqlConnection AbrirConexion()
        {
            if(Conexion.State==ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if(Conexion.State==ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
