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
    public partial class V_Mantenimientos : Form
    {
        public string usuario = "f";
        Controlador.C_Mantenimientos objeto_C = new Controlador.C_Mantenimientos();
        DataTable dtTrayectoriasLista=new DataTable();
        DataTable dtSeguimientosLista = new DataTable();
        public V_Mantenimientos()
        {
            InitializeComponent();
        }

        private void V_Mantenimientos_Load(object sender, EventArgs e)
        {
            listarTrayectorias();
            listarSeguimientos();
        }
        private void listarTrayectorias()
        {
            //Asignar Datos a comboBox
            dtTrayectoriasLista = objeto_C.ListarTrayectorias_C();
            cbxTrayectoriaGeorreferenciacion.DataSource = dtTrayectoriasLista;
            cbxTrayectoriaGeorreferenciacion.DisplayMember = "nombre_t";
            cbxTrayectoriaGeorreferenciacion.ValueMember = "id_trayectoria";
        }
        private void listarSeguimientos()
        {
            //Asignar Datos a comboBox
            dtSeguimientosLista = objeto_C.ListarSeguimientos_C();
            cbxSeguimiento.DataSource = dtSeguimientosLista;
            cbxSeguimiento.DisplayMember = "fecha_hora";
            cbxSeguimiento.ValueMember = "id_seguimiento";
        }
    }
}
