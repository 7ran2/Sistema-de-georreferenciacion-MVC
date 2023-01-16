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
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;

namespace Vista
{
    public partial class V_Trayectorias : Form
    {
        public string usuario = "f";
        string idSocio = "";
        Controlador.C_Trayectorias Objeto_C=new C_Trayectorias();
        public V_Trayectorias()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtInicio.Text == "" || txtFinal.Text == "" || txtNombreTrayectoria.Text == "" || txtNumOrden.Text == "")
            {
                MessageBox.Show("Complete las Casillas");
            }
            else
            {
                try
                {
                    Objeto_C.InsertarTrayectorias_C(txtInicio.Text, txtFinal.Text, txtNombreTrayectoria.Text, txtNumOrden.Text, "1", usuario);
                    MessageBox.Show(txtNombreTrayectoria.Text+" Regiostrado correctamente");
                    Limpiartxt();
                    listarTrayectorias();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
        public void listarTrayectorias()
        {
            dataGridView1.DataSource= Objeto_C.MostrarTrayectorias_C();
        }
        public void Mapa()
        {
            GMarkerGoogle marker;
            GMapOverlay markerOverlay;
            double LatInicial = -16.572782;
            double LngInicial = -68.173222;

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
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = string.Format("Ubicacion: \n Latitud: {0} \n Longitud: {1}", LatInicial, LngInicial);

            //ahora agregamos el mapa y el marcador al map control
            gMapControl1.Overlays.Add(markerOverlay);
        }
        public void VerificarCasillaLlena()
        {
            
            
        }
        public void Limpiartxt()
        {
            txtInicio.Text = "";
            txtFinal.Text = "";
            txtNombreTrayectoria.Text = "";
            txtNumOrden.Text = "";
        }

        private void V_Trayectorias_Load(object sender, EventArgs e)
        {
            listarTrayectorias();
            Mapa();
        }
    }
}
