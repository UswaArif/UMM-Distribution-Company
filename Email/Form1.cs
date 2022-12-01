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
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;

namespace Email
{
    public partial class Form1 : Form
    {
        string[] Scopes = { GmailService.Scope.GmailSend };
        string ApplicationName = "GmailApp";
        public Form1()
        {
            InitializeComponent();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        string Base64UrlEncode(string input)
        {
            var data = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(data).Replace("+", "-").Replace("/", "_").Replace("=", "");
        }
        private void sendbtn_Click(object sender, EventArgs e)
        {
            UserCredential credential;
            //read your credentials file
            using (FileStream stream = new FileStream(Application.StartupPath + @"/credentials.json", FileMode.Open, FileAccess.Read))
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                path = Path.Combine(path, ".credentials/gmail-dotnet-quickstart.json");
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, Scopes, "user", CancellationToken.None, new FileDataStore(path, true)).Result;
            }
            string message = $"To: {Totxt.Text}\r\nSubject: {Subjecttxt.Text}\r\nContent-Type: text/html;charset=utf-8\r\n\r\n<h1>{Bodytxt.Text}</h1>";
            //call your gmail service
            var service = new GmailService(new BaseClientService.Initializer() { HttpClientInitializer = credential, ApplicationName = ApplicationName });
            var msg = new Google.Apis.Gmail.v1.Data.Message();
            msg.Raw = Base64UrlEncode(message.ToString());
            service.Users.Messages.Send(msg, "me").Execute();
            MessageBox.Show("Your email has been successfully sent !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("uswaarif32@gmail.com");
                msg.To.Add(Totxt.Text);
                msg.Subject = Subjecttxt.Text;
                msg.Body = Bodytxt.Text;
              

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                smt.EnableSsl = true;
                smt.UseDefaultCredentials = false;
                //System.Net.NetworkCredential ntcd = new NetworkCredential();
                var ntcd = new NetworkCredential();
                ntcd.UserName = "uswaarif32@gmail.com";
                ntcd.Password = "uh06nw3h";
                smt.Credentials = ntcd;
                
                smt.Port = 587;
                smt.DeliveryMethod = SmtpDeliveryMethod.Network;
                smt.Send(msg);

                MessageBox.Show("Your Mail is sended");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }*/
            /*MailMessage newMessage = new MailMessage("mutaibamohsin845@gmail.com", Totxt.Text);
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
            customer.Send(newMessage);*/
        }
    }
}
//mutaibamohsin845@gmail.com
