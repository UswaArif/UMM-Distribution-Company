using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.BL;
using System.IO;

namespace Project.DL
{
    class EmployeeDL
    {
        private static LinkedList<Employee> employeeList = new LinkedList<Employee>();

        public static LinkedList<Employee> EmployeeList { get => employeeList; set => employeeList = value; }

        public static void StoreEmployeeIntoList(Employee e1)
        {
            employeeList.AddLast(e1);
        }

        public static Employee isEmployeeExists(string name)
        {
            foreach (Employee e1 in employeeList)
            {
                if (e1.Name == name)
                {
                    return e1;
                }
            }
            return null;
        }

        public static Employee searchEmployee(int ID)
        {
            foreach (Employee e1 in employeeList)
            {
                if (e1.Id1 == ID)
                {
                    return e1;
                }
            }
            return null;
        }

        public static void editEmployeeFromList(Employee previous, Employee updated)
        {
            foreach (Employee e1 in employeeList)
            {
                if (e1.Name == previous.Name && e1.CNIC1 == previous.CNIC1 && e1.PhoneNumber == previous.PhoneNumber && e1.Id1 == previous.Id1 && e1.Salary == previous.Salary)
                {
                    e1.Name = updated.Name;
                    e1.CNIC1 = updated.CNIC1;
                    e1.PhoneNumber = updated.PhoneNumber;
                    e1.Id1 = updated.Id1;
                    e1.Salary = updated.Salary;
                }
            }
        }

        public static void DeleteEmployee(Employee delete)
        {
            if (delete != null)
            {
                foreach (Employee e1 in employeeList)
                {
                    if (e1.Name == delete.Name && e1.CNIC1 == delete.CNIC1 && e1.PhoneNumber == delete.PhoneNumber && e1.Id1 == delete.Id1 && e1.Salary == delete.Salary)
                    {
                        employeeList.Remove(e1);
                    }
                }
            }
        }

        public static bool readEmployeefromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string CNIC = splittedRecord[1];
                    string phoneNumber = splittedRecord[2];
                    int Id = int.Parse(splittedRecord[3]);
                    float salary = float.Parse(splittedRecord[4]);

                    Employee e = new Employee(name, CNIC, phoneNumber, Id, salary);
                    StoreEmployeeIntoList(e);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void storeEmployeeIntoFile(string path, Employee e)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(e.Name + "," + e.CNIC1 + "," + e.PhoneNumber + "," + e.Id1 + "," + e.Salary);
            f.Flush();
            f.Close();
        }

        public static void storeAllEmployeeIntoFile(string path)
        {
            StreamWriter f = new StreamWriter(path);
            foreach (Employee storedemployee in employeeList)
            {
                f.WriteLine(storedemployee.Name + "," + storedemployee.CNIC1 + "," + storedemployee.PhoneNumber + "," + storedemployee.Id1 + "," + storedemployee.Salary);
            }
            f.Flush();

            f.Close();
        }
    }
}
