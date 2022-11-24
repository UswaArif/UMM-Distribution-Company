using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            MailMessage newMessage = new MailMessage("mutaibamohsin845@gmail.com", Totxt.Text);
            newMessage.Subject = Subjecttxt.Text;
            newMessage.Body = Bodytxt.Text;
            newMessage.IsBodyHtml = true;
            SmtpClient customer = new SmtpClient();
            customer.Host = "smtp.gmail.com";
            customer.Port = 465;
            customer.UseDefaultCredentials = false;
            NetworkCredential credential2 = new NetworkCredential("mutaibamohsin32@gmail.com", "mutaibakween69");
            customer.Credentials = credential2;
            customer.EnableSsl = true;
            customer.Send(newMessage);
        }
    }
}
//mutaibamohsin845@gmail.com
