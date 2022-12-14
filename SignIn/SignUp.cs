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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            if(Passwordtxt.Text== ReEnterPasswordtxt.Text)
            {
                UserBL newUser = new UserBL(UserNametxt.Text, Passwordtxt.Text, Roletxt.Text);
                UserDL.addIntoList(newUser);
                //UserDL.storeUserIntoFile("pr");
                MessageBox.Show("Account Created");
            }
            else
            {
                MessageBox.Show("File Doesnt Match");
            }
        }
    }
}
