using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Vista
{
    public partial class V_Georreferenciacion : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;
        int filaseleccionada = 0;
        double LatInicial = -16.572782;
        double LngInicial = -68.173222;

        public V_Georreferenciacion()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Descripcion", typeof(string)));
            dt.Columns.Add(new DataColumn("Lat", typeof(double)));
            dt.Columns.Add(new DataColumn("Long", typeof(double)));
            dt.Columns.Add(new DataColumn("Direccion", typeof(string)));

            //Insertar un adto en el datagrid
            dt.Rows.Add("Ubicacion 1", LatInicial, LngInicial,"Direccion 1");
            dataGridView1.DataSource = dt;

            //Desactivar visivilidad de columnas
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleSatelliteMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            // Marcador
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);//Agregamos al mapa
            //Agregamos el tooltip de texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicacion: \n Latitud: {0} \n Longitud: {1}", LatInicial, LngInicial);

            //ahora agregamos el mapa y el marcador al map control
            gMapControl1.Overlays.Add(markerOverlay);
        }

        private void SeleccionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {
            filaseleccionada = e.RowIndex;//Fila seleccionada
            //Recuperamos los datos del grid y los agignamos a text box
            txtDescripcion.Text = dataGridView1.Rows[filaseleccionada].Cells[0].Value.ToString();
            txtLatitud.Text = dataGridView1.Rows[filaseleccionada].Cells[1].Value.ToString();
            txtLongitud.Text = dataGridView1.Rows[filaseleccionada].Cells[2].Value.ToString();
            txtDireccion.Text = dataGridView1.Rows[filaseleccionada].Cells[3].Value.ToString();
            //Asignamos los valores del grid al marcador 
            marker.Position = new PointLatLng(Convert.ToDouble(txtLatitud.Text), Convert.ToDouble(txtLongitud.Text));
            //Se posiciona el foco del mapa en esa posicion
            gMapControl1.Position = marker.Position;
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Se obtiene los datos de latitud y longitud del mapa donde el usuario presiono 2 veces
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
            //Se posicionan en el txt de la latitud y longitud
            txtLatitud.Text = lat.ToString();
            txtLongitud.Text = lng.ToString();
            //Creamos el marcador para moverlo al lugar indicado
            marker.Position = new PointLatLng(lat, lng);
            //Tambien se agrega el mensaje al marcador(Tooltip)
            marker.ToolTipText = string.Format("Ubicacion: \n Latitud: {0} \n Longitud: {1}", lat, lng);

            txtDescripcion.Focus();//Foco para escribir directamente en descripcion
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agregar Datos del txt a DataGrid
            dt.Rows.Add(txtDescripcion.Text, txtLatitud.Text, txtLongitud.Text,txtDireccion.Text);
            txtDescripcion.Text = "";
            //Aqui pueden ir los procedimientos con BD
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(filaseleccionada);//Remover la fila de un DataGrid
            //Aqui pueden ir los procedimientos con BD
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            GMapOverlay Ruta = new GMapOverlay("CapaRuta");
            List<PointLatLng> puntos = new List<PointLatLng>();
            // variables para almacenar los datos.
            double lng, lat;
            // Agarramos los datos del grid
            for (int filas = 0; filas < dataGridView1.Rows.Count; filas++)
            {
                lat = Convert.ToDouble(dataGridView1.Rows[filas].Cells[1].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[filas].Cells[2].Value);
                puntos.Add(new PointLatLng(lat, lng));
            }

            GMapRoute PuntosRuta = new GMapRoute(puntos, "Ruta");
            Ruta.Routes.Add(PuntosRuta);
            gMapControl1.Overlays.Add(Ruta);
            // actualizar el mapa
            gMapControl1.Zoom = gMapControl1.Zoom - 1;
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
        }
    }
}
