using SignIn.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ProductDL.readProductFromFile("Product.txt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BarChart.DataSource = ProductDL.ProductList;
            PieChart.DataSource = ProductDL.ProductList;
            LineChart.DataSource = ProductDL.ProductList;
            BubbleChart.DataSource = ProductDL.ProductList;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
