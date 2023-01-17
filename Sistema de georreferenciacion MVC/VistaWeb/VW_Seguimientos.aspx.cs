using Controlador;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VistaWeb
{
    public partial class VW_Seguimientos : System.Web.UI.Page
    {

        public string usuario = "f";
        Controlador.C_Seguimientos objeto_C = new C_Seguimientos();
        Controlador.C_Alertas objetoAlerta_C = new C_Alertas();
        string idSocio = "";
        //private void txtMetrosCubicos_TextCharged(object sender, KeyPressEventArgs e)
        //{
        //    if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
        //    {
        //        MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        e.Handled = true;
        //        return;
        //    }
        //}
        private void MostrarSeguimientos_V()
        {
            DataTable dt = new DataTable();
            dt = objeto_C.MostrarSeguimientos_C();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        private void ListarTrayectorias()
        {
            if (ddlTrayectorias.Items.Count <= 0)
            {
                DataTable dt = new DataTable();
                dt = objeto_C.ListarSeguimientos_C();

                ListItem i;
                foreach (DataRow r in dt.Rows)
                {
                    i = new ListItem(r["nombre_t"].ToString(), r["id_trayectoria"].ToString());
                    ddlTrayectorias.Items.Add(i);
                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarSeguimientos_V();
            ListarTrayectorias();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                objeto_C.InsertarSeguimientos_C(ddlTrayectorias.SelectedValue, ddlPosicion.SelectedValue, txtLitros.Text, "1", usuario);

                //MessageBox.Show("Socio Registrado Correctamente");
                MostrarSeguimientos_V();
                Label4.Text = "Registrado Correctamente";
                Label4.ForeColor = System.Drawing.Color.Green;
                txtLitros.Text = "";
            }
            catch(Exception ex)
            {
                Label4.Text = "Revise los datos Ingresados";
                Label4.ForeColor = System.Drawing.Color.Red;
                txtLitros.Text = "";
            }
        }

        protected void btnFinalizarTrayectoria_Click(object sender, EventArgs e)
        {
            objetoAlerta_C.InsertarAlerta_C(ddlTrayectorias.SelectedValue.ToString(), usuario);
        }
    }
}