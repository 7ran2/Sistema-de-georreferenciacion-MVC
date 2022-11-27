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
    public partial class Principal : Form
    {
        V_Login Login_v = new V_Login();
        public string usuario_pr;
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            MessageBox.Show(usuario_pr);
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_Asociados Asociados= new V_Asociados();
            Asociados.TopLevel=false;
            panel1.Controls.Add(Asociados);
            Asociados.Show();
            Asociados.usuario=usuario_pr;
        }
    }
}
