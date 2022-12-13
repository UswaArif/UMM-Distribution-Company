using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn.BL
{
    class CustomerBL
    {
        private string CusName;
        private string CusEmail;
        private int CusLedger;
        private bool isFrequenter;
        private int CusTotalOrder;
        private area CusAddress;
        private string CusCinic;

        public CustomerBL(string cusName1, string cusEmail1, int cusLedger1, bool isFrequenter, int cusTotalOrder1, string cusCinic1, area cusAddress1)
        {
            this.CusName1 = cusName1;
            this.CusEmail1 = cusEmail1;
            this.CusLedger1 = cusLedger1;
            this.IsFrequenter1 = isFrequenter;
            this.CusTotalOrder1 = cusTotalOrder1;
            this.CusCinic1 = cusCinic1;
            this.CusAddress1 = cusAddress1;
        }
        public string CusName1 { get => CusName; set => CusName = value; }
        public string CusEmail1 { get => CusEmail; set => CusEmail = value; }
        public int CusLedger1 { get => CusLedger; set => CusLedger = value; }
        public bool IsFrequenter1 { get => isFrequenter; set => isFrequenter = value; }
        public int CusTotalOrder1 { get => CusTotalOrder; set => CusTotalOrder = value; }
        public string CusCinic1 { get => CusCinic; set => CusCinic = value; }
        public area CusAddress1 { get => CusAddress; set => CusAddress = value; }
        public bool IsFrequenter()
        {
            if (this.IsFrequenter1 == true)
            {
                return true;
            }
            return false;
        }
    }
}
