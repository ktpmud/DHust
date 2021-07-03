using đăng_kí_tài_khoản;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp4.DAO;

namespace WinFormsApp4
{
    public partial class FLogin : Form
    {
        public static string EmailU;
        public static string passwordU;

        public FLogin()
        {
            InitializeComponent();
        }

        private void button_Signin_Click(object sender, EventArgs e)
        {
            FRegister f = new FRegister();
            this.Hide();
            f.ShowDialog();
            this.Show();           
        }

        bool Login(string Email, string password)
        {
            return AccountDAO.Instance.Login(Email, password);
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string Email = textBox_Email.Text;
            string password = textBox_password.Text;

            if (Login(Email, password))
            {
                EmailU = Email;
                passwordU = password;
                FHomePage f = new FHomePage();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài Khoản hoặc Mật Khẩu sai! Vui lòng nhập lại!", "Notifycation");
            }
        }
    }
}
