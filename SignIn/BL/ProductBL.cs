using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn.BL
{
    public class ProductBL
    {
        private string ProductName;
        private int ProductStock;
        private int ProductThreshold;
        private int ProductPrice;
        private int ProductTotalSelled;
        private string ProductExpire;
        private string ProductSize;

        public ProductBL(string productName, int productStock, int productThreshold, int productPrice, int productTotalSelled, string productExpire, string productSize)
        {
            this.ProductName = productName;
            this.ProductStock = productStock;
            this.ProductThreshold = productThreshold;
            this.ProductPrice = productPrice;
            this.ProductTotalSelled = productTotalSelled;
            this.ProductExpire = productExpire;
            this.ProductSize = productSize;
        }

        public string ProductName1 { get => ProductName; set => ProductName = value; }
        public int ProductStock1 { get => ProductStock; set => ProductStock = value; }
        public int ProductThreshold1 { get => ProductThreshold; set => ProductThreshold = value; }
        public int ProductPrice1 { get => ProductPrice; set => ProductPrice = value; }
        public int ProductTotalSelled1 { get => ProductTotalSelled; set => ProductTotalSelled = value; }
        public string ProductExpire1 { get => ProductExpire; set => ProductExpire = value; }
        public string ProductSize1 { get => ProductSize; set => ProductSize = value; }
        public void IncreaseSellings(int selligs)
        {
            this.ProductTotalSelled1 = this.ProductTotalSelled1 + selligs;
        }
        public void DecreaseSelling(int selligs)
        {
            this.ProductTotalSelled1 = this.ProductTotalSelled1 + selligs;
        }
    }
}
