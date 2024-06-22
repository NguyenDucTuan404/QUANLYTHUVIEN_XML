using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using XML_Login;

namespace QUANLYTHUVIEN
{
    public partial class DANGNHAP : Form
    {
        public DANGNHAP()
        {
            InitializeComponent();
        }
        public string FromXML_user = "";
        public string FromXML_pwd = "";
        public string FromXML_name = "";

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pws = password.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pws))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên Đăng Nhập và Mật Khẩu");
                return;
            }

            XDocument doc = XDocument.Load(Application.StartupPath.ToString() + @"\QLTV_PK.xml");
            var selected_users = from x in doc.Descendants("NHANVIEN").Where(x => (string)x.Element("TaiKhoanNV") == user)
                                 select new
                                 {
                                     XMLuser = x.Element("TaiKhoanNV").Value,
                                     XMLpwd = x.Element("MatKhauNV").Value,
                                     XMLname = x.Element("TenNV").Value
                                 };
            var selected_user = selected_users.FirstOrDefault();
            if (selected_user == null)
            {
                MessageBox.Show("Tài khoản hoặc Mật khẩu Không Đúng");
                return;
            }

            FromXML_user = selected_user.XMLuser;
            FromXML_pwd = selected_user.XMLpwd;
            FromXML_name = selected_user.XMLname;



            //MessageBox.Show("Đăng nhập thành công");
            //LOADING f = new LOADING();
            Form1 f = new Form1();


            PassUserInformation.Username_user = FromXML_user;
            PassUserInformation.Name_user = FromXML_name;
            PassUserInformation.Pwd_user = FromXML_pwd;

            f.Show();
            this.Hide();

        }
        private void ClearBoxes()
        {
            username.Clear();
            password.Clear();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            var a1 = new ProcessStartInfo("msedge.exe");
            a1.Arguments = "https://ictu.edu.vn/";
            Process.Start(a1);
        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
            var a3 = new ProcessStartInfo("msedge.exe");
            a3.Arguments = "https://www.facebook.com/tuancutedapxetrenph0";
            Process.Start(a3);
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
