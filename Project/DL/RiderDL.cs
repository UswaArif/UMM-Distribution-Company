using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.BL;
using System.IO;

namespace Project.DL
{
    class RiderDL
    {
        private static LinkedList<Rider> newrider = new LinkedList<Rider>();
        public static LinkedList<Rider> Newrider { get => newrider; set => newrider = value; }

        public static void StoreRiderIntoList(Rider r1)
        {
            Newrider.AddLast(r1);
        }

        public static Rider isRiderExists(string name)
        {
            foreach (Rider r1 in Newrider)
            {
                if (r1.Name == name)
                {
                    return r1;
                }
            }
            return null;
        }

        public static Rider searchRider(int ID)
        {
            foreach (Rider r1 in Newrider)
            {
                if (r1.Id1 == ID)
                {
                    return r1;
                }
            }
            return null;
        }

        public static void editRiderFromList(Rider previous,Rider updated)
        {
            foreach (Rider r1 in Newrider)
            {
                if (r1.Name == previous.Name && r1.PhoneNumber == previous.PhoneNumber && r1.Id1 == previous.Id1 && r1.Salary == previous.Salary && r1.VehicleAssign == previous.VehicleAssign)
                {
                    r1.Name = updated.Name;
                    r1.PhoneNumber = updated.PhoneNumber;
                    r1.Id1 = updated.Id1;
                    r1.Salary = updated.Salary;
                    r1.VehicleAssign = updated.VehicleAssign;
                }
            }
        }

        public static void checkIsDeleted(Rider delete)
        {
            if (delete != null)
            {
                foreach (Rider r1 in Newrider)
                {
                    if (r1.Name == delete.Name && r1.PhoneNumber == delete.PhoneNumber && r1.Id1 == delete.Id1 && r1.Salary == delete.Salary && r1.VehicleAssign == delete.VehicleAssign)
                    {
                        Newrider.Remove(r1);
                    }
                }
            }
        }

        public static bool readRiderfromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string phoneNumber = splittedRecord[1];
                    int Id = int.Parse(splittedRecord[2]);
                    float salary = float.Parse(splittedRecord[3]);
                    int vehicleAssign = int.Parse(splittedRecord[4]);

                    Rider r = new Rider(name,phoneNumber,Id,salary,vehicleAssign);
                    StoreRiderIntoList(r);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void storeRiderIntoFile(string path, Rider r)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(r.Name + "," + r.PhoneNumber + "," + r.Id1 + "," + r.Salary + "," + r.VehicleAssign);
            f.Flush();
            f.Close();
        }

        public static void storeAllRiderIntoFile(string path)
        {
            StreamWriter f = new StreamWriter(path);
            foreach (Rider storedrider in Newrider)
            {
                f.WriteLine(storedrider.Name + "," + storedrider.PhoneNumber + "," + storedrider.Id1 + "," + storedrider.Salary + "," + storedrider.VehicleAssign);

            }
            f.Flush();

            f.Close();
        }
    }
}
