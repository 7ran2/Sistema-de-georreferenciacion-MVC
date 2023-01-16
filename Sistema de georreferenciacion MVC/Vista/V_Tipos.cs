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
    public partial class V_Tipos : Form
    {
        public V_Tipos()
        {
            InitializeComponent();
        }


        DataTable dt = new DataTable();
        private void V_Tipos_Load(object sender, EventArgs e)
        {
            ListaTipos();
            
        }
        private void ListaTipos()
        {
            DataRow row = dt.NewRow();
            dt.Columns.Add(new DataColumn("Tipo", typeof(int)));
            dt.Columns.Add(new DataColumn("Nombre", typeof(string)));
            dt.Rows.Add(1, "Nodo Inicial");
            dt.Rows.Add(2, "Arco");
            dt.Rows.Add(3, "Nodo Final");
            //dataGridView1.DataSource = dt;
            cbbxIdTipo.DataSource = dt;
            cbbxIdTipo.DisplayMember = "Nombre";
            cbbxIdTipo.ValueMember = "Tipo";

            txtNombreTipo.Text = cbbxIdTipo.SelectedValue.ToString();
        }
    }
    
}
