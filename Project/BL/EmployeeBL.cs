using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BL
{
    class EmployeeBL
    {
        private string EmpName;
        private string EmpCnic;
        private string EmpPhone;
        private string EmpId;
        private int EmpSalary;
        private bool isSalaryPaid;

        public string EmpName1 { get => EmpName; set => EmpName = value; }
        public string EmpCnic1 { get => EmpCnic; set => EmpCnic = value; }
        public string EmpPhone1 { get => EmpPhone; set => EmpPhone = value; }
        public string EmpId1 { get => EmpId; set => EmpId = value; }
        public int EmpSalary1 { get => EmpSalary; set => EmpSalary = value; }
        public bool IsSalaryPaid { get => isSalaryPaid; set => isSalaryPaid = value; }

        public EmployeeBL(string name, string CNIC, string phoneNumber, string Id, int salary)
        {
            this.EmpName = name;
            this.EmpCnic1 = CNIC;
            this.EmpPhone1 = phoneNumber;
            this.EmpId1 = Id;
            this.EmpSalary1 = salary;
        }
    }
}
