using SignIn.BL;
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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            ProductBL newProduct = new ProductBL(ProductNametxt.Text, int.Parse(ProductStocktxt.Text), int.Parse(ProductThresholdtxt.Text), int.Parse(ProductPricetxt.Text), int.Parse(ProductTotalSelledtxt.Text), ProductExpirytxt.Text,SizeCombox.Text);
            ProductDL.addIntoProductList(newProduct);
            //ProductDL.storeProductIntoFile;
        }
    }
}

