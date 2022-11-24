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
            chart.Series["Series"].Points.AddXY("Nor", 8.7);
            chart.Series["Series"].Points.AddXY("Noir", 8.9);
            chart.Series["Series"].Points.AddXY("or", 9.7);
        }
    }
}
