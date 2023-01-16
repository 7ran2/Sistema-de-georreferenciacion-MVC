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
        public void CerrarVentanas()
        {
            V_Georreferenciacion Georreferenciacion = new V_Georreferenciacion();
            Georreferenciacion.Close();
            V_Socios Asociados = new V_Socios();
            Asociados.Close();
            V_Seguimientos Seguimientos = new V_Seguimientos();
            Seguimientos.Close();
            V_Mantenimientos Mantenimientos = new V_Mantenimientos();
            Mantenimientos.Close();
            V_Cargos Cargos = new V_Cargos();
            Cargos.Close();
            V_Usuarios Usuarios = new V_Usuarios();
            Usuarios.Close();
            V_Trayectorias Trayectorias = new V_Trayectorias();
            Trayectorias.Close();
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_Socios Asociados= new V_Socios();
            Asociados.TopLevel=false;
            panel1.Controls.Add(Asociados);
            Asociados.Show();
            Asociados.usuario=usuario_pr;
        }

        private void registroDeCoordenadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_Georreferenciacion Georreferenciacion = new V_Georreferenciacion();
            Georreferenciacion.TopLevel = false;
            panel1.Controls.Add(Georreferenciacion);
            Georreferenciacion.Show();
            Georreferenciacion.usuario = usuario_pr;
        }

        private void registroDeAsociadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_Seguimientos Seguimientos = new V_Seguimientos();
            Seguimientos.TopLevel = false;
            panel1.Controls.Add(Seguimientos);
            Seguimientos.Show();
            Seguimientos.usuario = usuario_pr;
        }

        private void registroDeMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_Mantenimientos Mantenimientos = new V_Mantenimientos();
            Mantenimientos.TopLevel = false;
            panel1.Controls.Add(Mantenimientos);
            Mantenimientos.Show();
            Mantenimientos.usuario = usuario_pr;
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_Cargos Cargos = new V_Cargos();
            Cargos.TopLevel = false;
            panel1.Controls.Add(Cargos);
            Cargos.Show();
            Cargos.usuario = usuario_pr;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_Usuarios Usuarios = new V_Usuarios();
            Usuarios.TopLevel = false;
            panel1.Controls.Add(Usuarios);
            Usuarios.Show();
            Usuarios.usuario = usuario_pr;
        }

        private void vistaDeCoordenadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_Trayectorias Trayectorias = new V_Trayectorias();
            Trayectorias.TopLevel = false;
            panel1.Controls.Add(Trayectorias);
            Trayectorias.Show();
            Trayectorias.usuario = usuario_pr;
        }
    }
}
