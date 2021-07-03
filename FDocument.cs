using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class FDocument : Form
    {
        DataGridView dgvload;
        public static string mon;       
        public FDocument()
        {
            InitializeComponent();

        }   
        public void loadgridbykeyword()
        {
            ketnoi kn1 = new ketnoi();
            ketnoi kn2 = new ketnoi();
            ketnoi kn3 = new ketnoi();
            ketnoi kn4 = new ketnoi();
            ketnoi kn5 = new ketnoi();
            ketnoi kn6 = new ketnoi();
            dgvDeCuong.DataSource = kn1.laybang("SELECT ID,[Tên Tài Liệu],Link,[Mã HP],[Thời Gian Tải Lên],[Định Dạng],IDuserUpload,EmailofUserUpload FROM dbo.ThongTinTaiLieu WHERE [Phân Loại Theo Lượng Kiến Thức]= N'Đề Cương, Giáo Trình' AND [Mã HP] = N'"+mon+"'");
            dgvSlide.DataSource = kn2.laybang(" SELECT ID,[Tên Tài Liệu],Link,[Mã HP],[Thời Gian Tải Lên],[Định Dạng],IDuserUpload,EmailofUserUpload FROM dbo.ThongTinTaiLieu WHERE [Phân Loại Theo Lượng Kiến Thức]= N'Slide' AND [Mã HP] = N'" + mon +"' ");
            dgvThamKhao.DataSource = kn3.laybang(" SELECT ID,[Tên Tài Liệu],Link,[Mã HP],[Thời Gian Tải Lên],[Định Dạng],IDuserUpload,EmailofUserUpload FROM dbo.ThongTinTaiLieu WHERE [Phân Loại Theo Lượng Kiến Thức]= N'Tài Liệu Tham Khảo' AND [Mã HP] = N'" + mon+"' ");
            dgvDeThi.DataSource = kn4.laybang(" SELECT ID,[Tên Tài Liệu],Link,[Mã HP],[Thời Gian Tải Lên],[Định Dạng],IDuserUpload,EmailofUserUpload FROM dbo.ThongTinTaiLieu WHERE [Phân Loại Theo Lượng Kiến Thức]= N'Đề Thi' AND [Mã HP] = N'" + mon+"' ");
            dgvBaiTap.DataSource = kn5.laybang(" SELECT ID,[Tên Tài Liệu],Link,[Mã HP],[Thời Gian Tải Lên],[Định Dạng],IDuserUpload,EmailofUserUpload FROM dbo.ThongTinTaiLieu WHERE [Phân Loại Theo Lượng Kiến Thức]= N'Bài Tập' AND [Mã HP] = N'" + mon+"' ");
            dgvThiNghiem.DataSource = kn6.laybang(" SELECT ID,[Tên Tài Liệu],Link,[Mã HP],[Thời Gian Tải Lên],[Định Dạng],IDuserUpload,EmailofUserUpload FROM dbo.ThongTinTaiLieu WHERE [Phân Loại Theo Lượng Kiến Thức]= N'Thí Nghiệm' AND [Mã HP] = N'" + mon+"' ");
        }
        void loadgrid()
        {
            int i;
            i = dgvload.CurrentRow.Index;
            
            webB.link = dgvload.Rows[i].Cells[2].Value.ToString();
            webB nf = new webB();
            nf.ShowDialog();
        }
        private void FDocument_Load(object sender, EventArgs e)
        {
            loadgridbykeyword();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvload = dgvDeCuong;
            loadgrid();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvload = dgvSlide;
            loadgrid();
        }

        private void dgvThamKhao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvload = dgvThamKhao;
            loadgrid();
        }

        private void dgvDeThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvload = dgvDeThi;
            loadgrid();
        }

        private void dgvBaiTap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvload = dgvDeThi;
            loadgrid();
        }

        private void dgvThiNghiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvload = dgvThiNghiem;
            loadgrid();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            FDanhSachDoc f = new FDanhSachDoc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

    }    
}
