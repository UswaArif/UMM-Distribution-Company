using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.BL;
using System.IO;
using SignIn.BL;

namespace Project.DL
{
    class RiderDL
    {
        private static LinkedList<RiderBL> riderList = new LinkedList<RiderBL>();

        public static LinkedList<RiderBL> RiderList { get => riderList; set => riderList = value; }

        public static void addRiderIntoList(RiderBL r1)
        {
            RiderList.AddLast(r1);
        }

        public static RiderBL isRider(string Id)
        {
            foreach (RiderBL r1 in RiderList)
            {
                if (r1.EmpId1 == Id)
                {
                    return r1;
                }
            }
            return null;
        }

        public static RiderBL searchRider(string ID)
        {
            foreach (RiderBL r1 in RiderList)
            {
                if (r1.EmpId1 == ID)
                {
                    return r1;
                }
            }
            return null;
        }

        public static void editRider(RiderBL previous,RiderBL updated)
        {
            foreach (RiderBL r1 in RiderList)
            {
                if (r1.EmpName1 == previous.EmpName1 && r1.EmpCnic1 == previous.EmpCnic1 && r1.EmpPhone1 == previous.EmpPhone1 && r1.EmpId1 == previous.EmpId1 && r1.EmpSalary1 == previous.EmpSalary1 && r1.VehicleId1 == previous.VehicleId1)
                {
                    r1.EmpName1 = updated.EmpName1;
                    r1.EmpCnic1 = updated.EmpCnic1;
                    r1.EmpPhone1 = updated.EmpPhone1;
                    r1.EmpId1 = updated.EmpId1;
                    r1.EmpSalary1 = updated.EmpSalary1;
                    r1.VehicleId1 = updated.VehicleId1;
                }
            }
        }

        public static void checkIsDeleted(RiderBL delete)
        {
            if (delete != null)
            {
                foreach (RiderBL r1 in RiderList)
                {
                    if (r1.EmpName1 == delete.EmpName1 && r1.EmpCnic1 == delete.EmpCnic1 && r1.EmpPhone1 == delete.EmpPhone1 && r1.EmpId1 == delete.EmpId1 && r1.EmpSalary1 == delete.EmpSalary1 && r1.VehicleId1 == delete.VehicleId1)
                    {
                        RiderList.Remove(r1);
                    }
                }
            }
        }

        public static bool readfromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string Id = splittedRecord[1];
                    string phoneNumber = splittedRecord[2];
                    int salary = int.Parse(splittedRecord[3]);
                    string CNIC = splittedRecord[4];
                    bool isSalaryPaid = bool.Parse(splittedRecord[5]);
                    float latitude = float.Parse(splittedRecord[6]);
                    float longitude = float.Parse(splittedRecord[7]);
                    string vehicleAssign = splittedRecord[8];
                    int totalDelivery = int.Parse(splittedRecord[9]);
                    
                    area a = new area(latitude,longitude);

                    RiderBL r = new RiderBL(name,CNIC,phoneNumber,Id,salary,vehicleAssign,totalDelivery,isSalaryPaid,a);
                    addRiderIntoList(r);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void storeIntoFile(string path, RiderBL r)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(r.EmpName1 + "," + r.EmpId1 + "," + r.EmpPhone1 + "," + r.EmpSalary1 + "," + r.EmpCnic1 + "," + r.IsSalaryPaid + "," + r.RiderArea1.Latitude1 + "," + r.RiderArea1.Longitude1 + "," + r.TotalDelivery1);
            f.Flush();
            f.Close();
        }

        public static void storeAllRiderIntoFile(string path)
        {
            StreamWriter f = new StreamWriter(path);
            foreach (RiderBL storedrider in RiderList)
            { 
                f.WriteLine(storedrider.EmpName1 + "," + storedrider.EmpId1 + "," + storedrider.EmpPhone1 + "," + storedrider.EmpSalary1 + "," + storedrider.EmpCnic1 + "," + storedrider.IsSalaryPaid + "," + storedrider.RiderArea1.Latitude1 + "," + storedrider.RiderArea1.Longitude1 + "," + storedrider.TotalDelivery1);

            }
            f.Flush();

            f.Close();
        }
    }
}
