using Controlador;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;

namespace Vista
{
    public partial class V_Seguimientos : Form
    {
        public string usuario="f";
        Controlador.C_Seguimientos objeto_C = new C_Seguimientos();
        Controlador.C_Georreferenciaciones objetoGeo_C = new C_Georreferenciaciones();
        Controlador.C_Alertas objetoAlerta_C = new C_Alertas();

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;
        int filaseleccionada = 0;
        double LatInicial = -16.572782;
        double LngInicial = -68.173222;
        public V_Seguimientos()
        {
            InitializeComponent();
        }
        private void listarTrayectorias()
        {
            DataTable dtTrayectoriasLista = new DataTable();
            //Asignar Datos a comboBox
            dtTrayectoriasLista = objetoGeo_C.ListarTrayectorias_C();
            cbxTrayectorias.DataSource = dtTrayectoriasLista;
            cbxTrayectorias.DisplayMember = "nombre_t";
            cbxTrayectorias.ValueMember = "id_trayectoria";
        }
        private void V_Seguimientos_Load(object sender, EventArgs e)
        {
            MostrarAlertas();
            listarTrayectorias();

            //MostrarSeguimientos_V();
            //TrayectoriasRegistradas();
            //listarTrayectorias();
            //listarTipos();
            //MostraGeorrefenciaciones();
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleSatelliteMap;
            //gMapControl1.MapProvider = GMapProviders.GoogleMap;
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
        private void MostrarSeguimientos_V()
        {
            DataTable dt = new DataTable();
            dt = objeto_C.MostrarSeguimientos_C();
            //dt=objetoGeo_C.MostrarGeorreferenciaciones_C();
            dataGridView1.DataSource = dt;
        }
        private void MostrarAlertas()
        {
            DataTable dt = new DataTable();
            dt=objetoAlerta_C.MostrarUsuarios_C();
            dataGridView1.DataSource = dt;
        }

        private void cbxTrayectorias_DropDownClosed(object sender, EventArgs e)
        {

        }
    }
    
}

