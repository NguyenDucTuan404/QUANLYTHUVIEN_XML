using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using System.IO;
using System.Net.Mail;

namespace QUANLYTHUVIEN
{
    public partial class XACNHAN : Form
    {
        public XACNHAN()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {			
		}

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string to, from, pass, mail;
            to = (txtReceiver.Text).ToString();
            from = (txtSender.Text).ToString();
            mail = (txtMail.Text).ToString();
            pass = (txtPassword.Text).ToString();
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = mail;
            message.Subject = "XIN MÃ CODE CHỈNH SỬA TÀI KHOẢN ĐĂNG NHẬP PHẦN MỀM QLTV NTU";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Email đã gửi xong", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMail1_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://maps.app.goo.gl/vTMfwqY1Pm86m2pM9");
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            string to, from, pass, mail;
            to = (txtReceiver.Text).ToString();
            from = (txtSender.Text).ToString();
            mail = (txtMail.Text).ToString();
            pass = (txtPassword.Text).ToString();
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = mail;
            message.Subject = "XIN MÃ CODE CHỈNH SỬA TÀI KHOẢN ĐĂNG NHẬP PHẦN MỀM QLTV NTU";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Email đã gửi xong", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void XACNHAN_Load(object sender, EventArgs e)
        {

        }
    }
}
