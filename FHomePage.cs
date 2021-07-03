using đăng_kí_tài_khoản;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class FHomePage : Form
    {

              
        public FHomePage()
        {
            InitializeComponent();


        }

        private void UserInformation_Click(object sender, EventArgs e)
        {
            FUserInformation f = new FUserInformation();
            f.Show();
        }

        private void NewAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn tạo tài khoản mới?","Thông báo",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                FRegister f = new FRegister();
                f.Show();
            }
        }

        private void DeleteAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa tài khoản?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void DaiCuong_Click(object sender, EventArgs e)
        {
            FDocument f = new FDocument();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void CoSoNganh_Click(object sender, EventArgs e)
        {
            FDocument f = new FDocument();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void ChuyenNganh_Click(object sender, EventArgs e)
        {
            FDocument f = new FDocument();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void DoAnVaKhoaLuan_Click(object sender, EventArgs e)
        {
            FDoAn f = new FDoAn();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void AccessAsAdmin_Click(object sender, EventArgs e)
        {
            FAdminPage f = new FAdminPage();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }        

        public void loadgrid()
        {
            ketnoi kn = new ketnoi();
            dataGridView1.DataSource = kn.laybang("SELECT * FROM dbo.ThongTinHocPhan ORDER BY [Tên Học Phần] ");
        }
        public void loadgridFirstT()
        {
            ketnoi kn = new ketnoi();
            dataGridView1.DataSource = kn.laybang("SELECT * FROM dbo.ThongTinHocPhan WHERE Viện = N'All' ");
        }

        public void loadgridbykeyword() // tìm kiếm
        {
            ketnoi kn = new ketnoi();
            dataGridView1.DataSource = kn.laybang("SELECT * FROM dbo.ThongTinHocPhan where ([Viện] = N'" + cbVien.Text +"') and ([Tên Học Phần] like N'%" + txbMon.Text + "%')");
        }                            
        private void BntSearch_Click(object sender, EventArgs e)
        {
            loadgridbykeyword();
        }

        private void FHomePage_Load(object sender, EventArgs e)//?????
        {
            loadgridFirstT();
            testAdmin();
        }

        private void testAdmin()
        {
            if (FLogin.EmailU == "Admin")
            {
                AccessAsAdmin.Enabled = true;
            }
            else
            {
                AccessAsAdmin.Enabled = false;
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            FDocument.mon = dataGridView1.Rows[i].Cells[0].Value.ToString();
            FDocument t = new FDocument();
            t.ShowDialog();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            loadgrid();
            cbVien.Text = null;
            txbMon.Text = null;
        }
    }
}
