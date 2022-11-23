using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;

namespace GoogleMap
{
    public partial class Mapfrm : Form
    {
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
            gMapDisplayArea.Position = new GMap.NET.PointLatLng(lattitude, longtitude);
            gMapDisplayArea.MinZoom = 1;
            gMapDisplayArea.MaxZoom = 100;
            gMapDisplayArea.Zoom = 10;

        }
    }
}
