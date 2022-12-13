using SignIn.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn.DL
{
    class ProductDL
    {
        private static LinkedList<ProductBL> productList = new LinkedList<ProductBL>();

        public static LinkedList<ProductBL> ProductList { get => productList; set => productList = value; }
        public static void addIntoProductList(ProductBL p)
        {
            productList.AddLast(p);
        }
        public static ProductBL checkProduct(ProductBL p)
        {
            foreach (ProductBL check in ProductList)
            {
                if (p.ProductName1 == check.ProductName1 && p.ProductPrice1 == check.ProductPrice1 && p.ProductSize1 == check.ProductSize1 && p.ProductStock1 == check.ProductStock1 && p.ProductThreshold1 == check.ProductThreshold1 && p.ProductTotalSelled1 ==check.ProductTotalSelled1 && p.ProductExpire1 ==check.ProductExpire1)
                {
                    return check;
                }
            }
            return null;
        }
        public static ProductBL checkProduct(string p)
        {
            foreach (ProductBL check in ProductList)
            {
                if (p == check.ProductSize1)
                {
                        return check;
                }
            }
            return null;
        }
        public static void storeProductIntoFile(string productPath)
        {
            StreamWriter file = new StreamWriter(productPath);
            foreach (ProductBL p in ProductList)
            {
                file.WriteLine(p.ProductName1 + "," + p.ProductStock1 + "," + p.ProductThreshold1 + "," + p.ProductPrice1 + "," + p.ProductTotalSelled1 + "," + p.ProductExpire1 + "," + p.ProductSize1) ;
            }
            file.Flush();
            file.Close();
        }
        public static bool readProductFromFile(string ProductPath)
        {
            StreamReader file = new StreamReader(ProductPath);
            string record;
            if (File.Exists(ProductPath))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string productName = splittedRecord[0];
                    int productStock = int.Parse(splittedRecord[1]);
                    int productThreshold = int.Parse(splittedRecord[2]);
                    int productPrice = int.Parse(splittedRecord[3]);
                    int productTotalSelled = int.Parse(splittedRecord[4]);
                    string productExpired = splittedRecord[5];
                    string productSize = splittedRecord[6];
                    ProductBL newProduct = new ProductBL(productName,productStock,productThreshold, productPrice, productTotalSelled,productExpired, productSize);
                    addIntoProductList(newProduct);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool deleteProduct(ProductBL p)
        {
            for(int index=0; index< ProductList.Count; index++)
            {
                if(ProductList.ElementAt(index).ProductName1==p.ProductName1 && ProductList.ElementAt(index).ProductStock1==p.ProductStock1 && ProductList.ElementAt(index).ProductThreshold1== p.ProductThreshold1 && ProductList.ElementAt(index).ProductPrice1==p.ProductPrice1 && ProductList.ElementAt(index).ProductTotalSelled1==p.ProductTotalSelled1 && ProductList.ElementAt(index).ProductExpire1==p.ProductExpire1 && ProductList.ElementAt(index).ProductSize1==p.ProductSize1)
                {
                    ProductList.Remove(ProductList.ElementAt(index));
                    return true;
                }
            }
            return false;
        }
        public static bool editProduct(ProductBL previous, ProductBL updated)
        {
            foreach(ProductBL p in productList)
            {
                if (p.ProductSize1==previous.ProductSize1)
                {
                    previous.ProductName1 = updated.ProductName1;
                    previous.ProductStock1 = updated.ProductStock1;
                    previous.ProductThreshold1 = updated.ProductThreshold1;
                    previous.ProductPrice1 = updated.ProductPrice1;
                    previous.ProductTotalSelled1 = updated.ProductTotalSelled1;
                    previous.ProductExpire1 = updated.ProductExpire1;
                    previous.ProductSize1 = updated.ProductSize1;
                    return true;
                }
            }
            return false;
        }
    }
}
