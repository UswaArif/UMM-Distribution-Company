using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plotbtn_Click(object sender, EventArgs e)
        {
            //chart.AxisX.Title = "Day of Week";
            chart.Series["sales"].Points.AddXY("TapalXL", 8.7);
            chart.Series["sales"].Points.AddXY("TapalS", 8.9);
            chart.Series["sales"].Points.AddXY("TapalM", 9.7);
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }
    }
}
