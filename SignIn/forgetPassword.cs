using SignIn.BL;
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
    public partial class forgetPassword : Form
    {
        UserBL newUser;
        public forgetPassword(UserBL u)
        {
            InitializeComponent();
            newUser = u;
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            if(ForgotPasswordtxt.Text==ReEntertxt.Text)
            {
                newUser.UserPassword1 = ForgotPasswordtxt.Text;
            }
            else
            {
                MessageBox.Show("InCorrect Password");
            }
        }
    }
}
