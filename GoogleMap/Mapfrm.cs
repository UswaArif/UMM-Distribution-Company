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

namespace GoogleMap
{
    public partial class Mapfrm : Form
    {
        GMapMarker gMapDisplayAreaMarkerForWareHouse;
        GMapMarker gMapDisplayAreaMarkerForCustomer;
        PointLatLng pointforCustomer;
        PointLatLng pointforWareHouse;
        public Mapfrm()
        {
            InitializeComponent();
        }

        private void btnLoadMap_Click(object sender, EventArgs e)
        {
            gMapDisplayArea.DragButton = MouseButtons.Left;
            gMapDisplayArea.MapProvider = GMapProviders.GoogleMap;
            double lattitude = Convert.ToDouble(Lattxt.Text);
            double longtitude= Convert.ToDouble(Longtxt.Text);
            double lattitude2 = Convert.ToDouble(lat2txt.Text);
            double longtitude2 = Convert.ToDouble(long2txt.Text);
            gMapDisplayArea.Position = new GMap.NET.PointLatLng(lattitude, longtitude);
            gMapDisplayArea.Position = new GMap.NET.PointLatLng(lattitude2, longtitude2);
            gMapDisplayArea.MinZoom = 1; // zoom min manually 
            gMapDisplayArea.MaxZoom = 100;
            gMapDisplayArea.Zoom = 10;//by default
            pointforWareHouse = new PointLatLng(lattitude, longtitude);
            pointforCustomer = new PointLatLng(lattitude2, longtitude2);
            gMapDisplayAreaMarkerForWareHouse = new GMarkerGoogle(pointforWareHouse, GMarkerGoogleType.blue_pushpin);// marker adding
            gMapDisplayAreaMarkerForCustomer = new GMarkerGoogle(pointforCustomer, GMarkerGoogleType.blue_pushpin);
            //overlay to add marker, overlay having all the number of markers then add the overlay to the forms
            GMapOverlay markerCollection = new GMapOverlay("markers");
            markerCollection.Markers.Add(gMapDisplayAreaMarkerForWareHouse);
            markerCollection.Markers.Add(gMapDisplayAreaMarkerForCustomer);
            gMapDisplayArea.Overlays.Add(markerCollection);
        }

        private void Mapfrm_Load(object sender, EventArgs e)
        {

        }

        private void GetRoute_Click(object sender, EventArgs e)
        {
            var route = GoogleMapProvider.Instance.GetRoute(pointforWareHouse,pointforCustomer,false,false,35);
            var newRoute = new GMapRoute(route.Points, "New Route")
            {
                Stroke = new Pen(Color.Black, 25)
            };
            var routeCollection = new GMapOverlay("routes");
            routeCollection.Routes.Add(newRoute);
            gMapDisplayArea.Overlays.Add(routeCollection);
        }
    }
}
//31.57783
//74.28800
//31.58921
//74.31060
