using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp4;
using WinFormsApp4.DAO;

namespace đăng_kí_tài_khoản
{
    public partial class FRegister : Form
    {
        public FRegister()
        {
            InitializeComponent();
        }

        public bool CheckControl()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Chưa nhập Username!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Chưa nhập Email!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Chưa nhập Password!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Vui lòng nhập lại Password!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return false;
            }
            return true;
        }
        public bool TestEmail(string Email, string pw)
        {
            return AccountDAO.Instance.Login(Email, pw);
        }
        private void buttonSigninInPageSignin_Click(object sender, EventArgs e)
        {
            if (CheckControl())
            {
                string Em = textBox2.Text;
                string pw = textBox3.Text;
                string pwRP = textBox4.Text;
                if (!TestEmail(Em, pw))
                {
                    if (pw == pwRP)
                    {

                        string sqlDangKi = @"INSERT INTO dbo.ThongTinNguoiDung
                                        (
                                            [Tên Người Dùng],
                                            Email,
                                            Password
                                        )
                                        VALUES
                                        (   N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text + "')";
                        DataProvider.Instance.ExecuteNonQuery(sqlDangKi);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập lại đúng Password!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Email đã được sử dụng! Vui lòng nhập Email khác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
