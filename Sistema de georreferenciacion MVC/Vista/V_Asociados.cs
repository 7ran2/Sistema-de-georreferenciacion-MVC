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
        string idAsociado = "";
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
        private void LimpiarCamposAsociados_V()
        {
            txtCarnet.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            dtpFechaNacimiento.MaxDate=DateTime.Now;
            cbxEstado.Checked=false;
            idAsociado = "";
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
            LimpiarCamposAsociados_V();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            int filaseleccionada = 0;
            filaseleccionada = e.RowIndex;//Fila seleccionada
            //Recuperamos los datos del grid y los agignamos a text box
            idAsociado =dataGridView1.Rows[filaseleccionada].Cells[0].Value.ToString();
            txtCarnet.Text = dataGridView1.Rows[filaseleccionada].Cells[1].Value.ToString();
            txtNombres.Text = dataGridView1.Rows[filaseleccionada].Cells[2].Value.ToString();
            txtApellidos.Text = dataGridView1.Rows[filaseleccionada].Cells[3].Value.ToString();
            dtpFechaNacimiento.Value =Convert.ToDateTime(dataGridView1.Rows[filaseleccionada].Cells[4].Value.ToString());
            if (Convert.ToBoolean(dataGridView1.Rows[filaseleccionada].Cells[5].Value) == true)
            {
                cbxEstado.Checked = true;
            }
            else
            {
                cbxEstado.Checked = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
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
            objeto_C.ModificarAsociados_C(idAsociado,txtCarnet.Text, txtNombres.Text, txtApellidos.Text, dtpFechaNacimiento.Value.ToShortDateString(), estado, usuario);
            MessageBox.Show("Asociado Modificado Correctamente");
            LimpiarCamposAsociados_V();
            MostrarAsociados_V();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea Eliminar?", "Eiminar",
            MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                objeto_C.EliminarAsociados_C(idAsociado, usuario);
                MessageBox.Show("Asociado Eliminado Correctamente");
                LimpiarCamposAsociados_V();
                MostrarAsociados_V();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Cancelado");
            }
        }
    }
}
