using SignIn.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn.DL
{
    class CustomerDL
    {
        private static LinkedList<CustomerBL> cusList = new LinkedList<CustomerBL>();
        public static LinkedList<CustomerBL> CusList { get => cusList; set => cusList = value; }
        public static void addintoList(CustomerBL c){cusList.AddLast(c);}
        public static void storeIntoFile(string CustomerPath)
        {
            StreamWriter file = new StreamWriter(CustomerPath);
            foreach (CustomerBL c in CusList)
            {
                file.WriteLine(c.CusName1 + "," + c.CusEmail1 +","+ c.CusLedger1 +","+ c.IsFrequenter1 +","+ c.CusTotalOrder1 +","+ c.CusAddress1.Latitude1 +","+c.CusAddress1.Longitude1 +","+ c.CusCinic1);
            }
            file.Flush();
            file.Close();
        }
        public static bool readfromFile(string CustomerPath)
        {
            StreamReader file = new StreamReader(CustomerPath);
            string record;
            if (File.Exists(CustomerPath))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string cusName = splittedRecord[0];
                    string cusEmail = splittedRecord[1];
                    int cusLedger = int.Parse(splittedRecord[2]);
                    bool isFrequenter = bool.Parse(splittedRecord[3]);
                    int cusTotalOrder = int.Parse(splittedRecord[4]);
                    float Lattitude = float.Parse(splittedRecord[5]);
                    float Longitutide = float.Parse(splittedRecord[6]);
                    string cusCinic = splittedRecord[7];
                    area newArea = new area(Lattitude, Longitutide);
                    CustomerBL newCus = new CustomerBL(cusName, cusEmail, cusLedger, isFrequenter, cusTotalOrder, cusCinic, newArea);
                    addintoList(newCus);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool deleteCustomer(CustomerBL c)
        {
            for(int index=0; index<=cusList.Count; index++)
            {
                if(cusList.ElementAt(index).CusName1==c.CusName1 && cusList.ElementAt(index).CusEmail1==c.CusEmail1 && cusList.ElementAt(index).CusLedger1==c.CusLedger1 && cusList.ElementAt(index).IsFrequenter1== c.IsFrequenter1 && cusList.ElementAt(index).CusTotalOrder1== c.CusTotalOrder1 && cusList.ElementAt(index).CusAddress1 == c.CusAddress1 && cusList.ElementAt(index).CusCinic1==c.CusCinic1)
                {
                    cusList.Remove(cusList.ElementAt(index));
                    return true;
                }
            }
            return false; 
        }
        public static bool editCustomer(CustomerBL previous, CustomerBL updated)
        {
            foreach (CustomerBL c in cusList)
            {
                if (previous.CusName1 == c.CusName1 && previous.CusEmail1 == c.CusEmail1 && previous.CusLedger1 == c.CusLedger1 && previous.IsFrequenter1 == c.IsFrequenter1 && previous.CusTotalOrder1 == c.CusTotalOrder1 && previous.CusAddress1 == c.CusAddress1 && previous.CusCinic1 == c.CusCinic1)
                {
                    previous.CusName1 = updated.CusName1;
                    previous.CusEmail1 = updated.CusEmail1;
                    previous.CusLedger1 = updated.CusLedger1;
                    previous.IsFrequenter1 = updated.IsFrequenter1;
                    previous.CusTotalOrder1 = updated.CusTotalOrder1;
                    previous.CusCinic1 = updated.CusCinic1;
                    previous.CusAddress1 = updated.CusAddress1;
                    return true;
                }
            }
            return false;
        }
    }
}
