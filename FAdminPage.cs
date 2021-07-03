using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using WinFormsApp4.DAO;

namespace WinFormsApp4
{
    public partial class FAdminPage : Form
    {
        DataGridView dgvload;


        public FAdminPage()
        {
            InitializeComponent();

            LoadUserInformation();
        }

        void LoadUserInformation()
        {
            string Query = "SELECT * FROM dbo.ThongTinNguoiDung";

            dgvUser.DataSource = DataProvider.Instance.ExecuteQuery(Query);

            string QueryTL = "SELECT * FROM dbo.ThongTinTaiLieu";

            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery(QueryTL);

        }

        void loadWeb()
        {
            int i;
            i = dgvload.CurrentRow.Index;

            webB.link = dgvload.Rows[i].Cells[3].Value.ToString();
            webB nf = new webB();
            nf.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvload = dataGridView1;
            loadWeb();
        }
        public void loadgridbykeywordInQLND()
        {
                string QueryX = " SELECT * FROM dbo.ThongTinNguoiDung WHERE [Tên Người Dùng] LIKE N'%" + textBoxU.Text + "%' OR Viện =N' " + cbVien.Text + " ' " ;
                dgvUser.DataSource = DataProvider.Instance.ExecuteQuery(QueryX);
        }

        public void loadgridInQLTL() // tìm kiếm
        {
            string Query = " SELECT * FROM dbo.ThongTinTaiLieu WHERE [Mã HP] = N'" + textBoxMHP.Text + "' OR  [Tên Tài Liệu] LIKE N'%" + txbTL.Text + "%' ";
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery(Query);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadgridInQLTL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadgridbykeywordInQLND();
        }
    }
}
