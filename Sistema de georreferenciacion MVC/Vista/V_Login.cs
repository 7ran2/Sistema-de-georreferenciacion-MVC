using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class V_Login : Form
    {
        public string usuario = "";
        Controlador.C_Login objeto_C = new C_Login();
        int Conteo=0;
        public V_Login()
        {
            InitializeComponent();
        }
        private void Login_V()
        {
            DataTable dt = new DataTable();
            dt = objeto_C.Login_C(txtUsuario.Text,txtClave.Text);
            //dataGridView1.DataSource = dt;
            Conteo = Convert.ToInt32(dt.Rows[0]["Column1"].ToString());
            if (Conteo > 0)
            {
                usuario = txtUsuario.Text;
                MessageBox.Show(" Bienvenido "+usuario );
                Principal pr = new Principal();
                pr.usuario_pr = usuario;
                pr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Revise su usuario o contraseña");
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Login_V();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
