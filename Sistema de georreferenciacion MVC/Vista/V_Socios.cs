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
    public partial class V_Socios : Form
    {
        public string usuario="f";
        Controlador.C_Socios objeto_C = new C_Socios();
        string idSocio = "";
        DataTable dt = new DataTable();
        public V_Socios()
        {
            InitializeComponent();
        }

        private void V_Socios_Load(object sender, EventArgs e)
        {
            MostrarSocios_V();
        }
        private void MostrarSocios_V()
        {
            dt = objeto_C.MostrarSocios_C();
            dataGridView1.DataSource=dt;
        }
        private void LimpiarCamposSocios_V()
        {
            txtCarnet.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            dtpFechaNacimiento.MaxDate=DateTime.Now;
            chbxEstado.Checked=false;
            idSocio = "";
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string tipo="";
            if (rdbtnOriginario.Checked==true)
            {
                tipo = "1";
            }
            if (rdbtnComprador.Checked==true)
            {
                tipo = "0";
            }

            string estado;
            if (chbxEstado.Checked == true)
            {
                estado = "1";
            }
            else
            {
                estado = "0";
            }
            objeto_C.InsertarSocios_C(txtCarnet.Text,cbbxExtension.Text, txtNombres.Text, txtApellidos.Text,tipo, dtpFechaNacimiento.Value.ToShortDateString(),estado,usuario);
            MessageBox.Show("Socio Registrado Correctamente");
            MostrarSocios_V();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MostrarSocios_V();
            LimpiarCamposSocios_V();
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
            idSocio = dt.Rows[filaseleccionada][0].ToString();
            txtCarnet.Text= dt.Rows[filaseleccionada][1].ToString();
            cbbxExtension.Text= dt.Rows[filaseleccionada][2].ToString();
            txtNombres.Text= dt.Rows[filaseleccionada][3].ToString();
            txtApellidos.Text= dt.Rows[filaseleccionada][4].ToString();
            if(Convert.ToBoolean(dt.Rows[filaseleccionada][5]) == true)
            {
                rdbtnOriginario.Checked = true;
            }
            else
            {
                rdbtnComprador.Checked = true;
            }
            dtpFechaNacimiento.Value = Convert.ToDateTime(dt.Rows[filaseleccionada][6].ToString());
            //idSocio = dataGridView1.Rows[filaseleccionada].Cells[0].Value.ToString();
            if (Convert.ToBoolean(dt.Rows[filaseleccionada][7]) == true)
            {
                chbxEstado.Checked = true;
            }
            else
            {
                chbxEstado.Checked = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string tipo = "";
            if (rdbtnOriginario.Checked == true)
            {
                tipo = "1";
            }
            if (rdbtnComprador.Checked == true)
            {
                tipo = "0";
            }
            string estado;
            if (chbxEstado.Checked == true)
            {
                estado = "1";
            }
            else
            {
                estado = "0";
            }
            objeto_C.ModificarSocios_C(idSocio, txtCarnet.Text,cbbxExtension.Text, txtNombres.Text, txtApellidos.Text,tipo, dtpFechaNacimiento.Value.ToShortDateString(), estado, usuario);
            MessageBox.Show("Socio Modificado Correctamente");
            LimpiarCamposSocios_V();
            MostrarSocios_V();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea Eliminar a " + txtNombres.Text+" "+txtApellidos.Text+"?", "Eiminar",
            MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                objeto_C.EliminarSocios_C(idSocio, usuario);
                MessageBox.Show("Socio Eliminado Correctamente");
                LimpiarCamposSocios_V();
                MostrarSocios_V();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Cancelado");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
