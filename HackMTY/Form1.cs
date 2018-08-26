using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
//using System.Windows.Devices.Geolocation;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;


namespace HackMTY
{
    public partial class Ventana_1 : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        double latitud = 20.528501d;
        double longitud = -97.448527d;
       // GeoCoordinateWatcher watcher;
        public Ventana_1()
        {
            InitializeComponent();
            Dispose(false);
        }

        private void coordenadaActual()
        {           
            try
            {
                
                GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
                watcher.Start();
                watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));
                
                GeoCoordinate coord = watcher.Position.Location;
               
              
                double lat = coord.Latitude;
                double lon = coord.Longitude;

                if (coord.IsUnknown != true)
                {
                    
                    /*Console.WriteLine("Lat: {0}, Long: {1}",
                        coord.Latitude,
                        coord.Longitude);*/
                }
                else
                {
                    //Text = "No se pudo, ya vete a dormir :(";
                }
                
                /////////////////////////////////
                //Marcador 
                markerOverlay = new GMapOverlay("Marcador");
                marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.green);
                markerOverlay.Markers.Add(marker);


                marker.ToolTipMode = MarkerTooltipMode.Always;
                MapaGoogle.Overlays.Add(markerOverlay);
                //marker.ToolTipText = String.Format(Ubi);
                /////////////////////////////////
            }
            catch (Exception e)
            {
                Console.WriteLine("Entro en el catch");
                Console.WriteLine(e.ToString());
            }

        }

        private void ponerMarcador(double latitud_,double longitud_)
        {
            //Marcador 
            marker.Position = new PointLatLng(latitud_, longitud_);
            

        }

        private void inicializar(int zoom)
        {
            
            MapaGoogle.DragButton = MouseButtons.Left;
            MapaGoogle.CanDragMap = true;
            MapaGoogle.MapProvider = GMapProviders.GoogleMap;
            MapaGoogle.Position = new PointLatLng(latitud, longitud);

            MapaGoogle.MinZoom = 5;
            MapaGoogle.MaxZoom = 24;
            MapaGoogle.Zoom = zoom;
           // MapaGoogle.
            MapaGoogle.AutoScroll = true;
            MapaGoogle.Refresh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            
            inicializar(14);    
            coordenadaActual();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MapaGoogle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = MapaGoogle.FromLocalToLatLng(e.X, e.Y).Lat;
            double lon = MapaGoogle.FromLocalToLatLng(e.X, e.Y).Lng;


            ponerMarcador(lat, lon);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MapaGoogle_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Move(object sender, EventArgs e)
        {
            
        }

        private void BarZoom_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
