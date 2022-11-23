using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Controlador;

namespace Vista
{
    public partial class V_Asociados : Form
    {
        public string usuario="franz";
        Controlador.C_Asociados objeto_C = new C_Asociados();
        public V_Asociados()
        {
            InitializeComponent();
        }

        private void V_Asociados_Load(object sender, EventArgs e)
        {
            MostrarAsociados_V();
        }
        private void MostrarAsociados_V()
        {
            dataGridView1.DataSource = objeto_C.MostrarAsociados_C();
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string estado;
            if (cbxEstado.Checked == true)
            {
                estado = "1";
            }
            else
            {
                estado = "0";
            }
            objeto_C.InsertarAsociados_C(txtCarnet.Text, txtNombres.Text, txtApellidos.Text, dtpFechaNacimiento.Value.ToShortDateString(),estado,usuario);
            MessageBox.Show("Asociado Registrado Correctamente");
            MostrarAsociados_V();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MostrarAsociados_V();
        }
    }
}
