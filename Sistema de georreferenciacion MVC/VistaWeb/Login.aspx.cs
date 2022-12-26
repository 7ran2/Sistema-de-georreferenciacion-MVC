using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador;
using System.Drawing;

namespace VistaWeb
{
    public partial class Login : System.Web.UI.Page
    {
        public string usuario = "";
        Controlador.C_Login objeto_C = new C_Login();
        int Conteo = 0;

        private void Login_V()
        {
            DataTable dt = new DataTable();
            dt = objeto_C.Login_C(txtUsuario.Text, txtClave.Text);
            //GridView1.DataSource = dt;
            Conteo = Convert.ToInt32(dt.Rows[0]["Column1"].ToString());
            if (Conteo > 0)
            {
                Label1.Text = txtUsuario.Text;
                Label2.Text = txtClave.Text;

                //usuario = txtUsuario.Text;
                //MessageBox.Show(" Bienvenido " + usuario);
                //Principal pr = new Principal();
                //pr.usuario_pr = usuario;
                //pr.Show();
                //this.Hide();
            }
            else
            {
                Label4.ForeColor=Color.Red;
                Label4.Text = "Error de Usuario o Contraseña!!";
                //MessageBox.Show("Revise su usuario o contraseña");
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click1(object sender, EventArgs e)
        {
            Login_V();
        }
    }
}