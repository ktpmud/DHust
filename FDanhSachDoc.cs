using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp4.DAO;

namespace WinFormsApp4
{
    public partial class FDanhSachDoc : Form
    {
        public static int ID =0;
        public FDanhSachDoc()
        {
            InitializeComponent();
        }

        private void FDanhSachDoc_Load(object sender, EventArgs e)
        {
            string LayIDDSD = " SELECT ID FROM dbo.DanhSachDocCuaNguoiDung WHERE Email = N'" + FLogin.EmailU + "' ";
            dataGridViewDSD.DataSource = DataProvider.Instance.ExecuteQuery(LayIDDSD);
            textBoxMaDSD.DataBindings.Add("Text", dataGridViewDSD.DataSource, "ID");

            string SqlLayIDUser = "SELECT ID FROM dbo.ThongTinNguoiDung WHERE Email= N'"+FLogin.EmailU+"'";
            dataGridViewDSD.DataSource = DataProvider.Instance.ExecuteQuery(SqlLayIDUser);
            textBoxIDuser.DataBindings.Add("Text", dataGridViewDSD.DataSource, "ID");
            ID = int.Parse(textBoxIDuser.Text);
            HienThiDSTaiLen();
        }

        public bool CheckControl()
        {
            if (string.IsNullOrWhiteSpace(textBoxHP.Text))
            {
                MessageBox.Show("Chưa nhập Tên Học Phần!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxHP.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxTL.Text))
            {
                MessageBox.Show("Chưa nhập Tên Tài Liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTL.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxLink.Text))
            {
                MessageBox.Show("Chưa nhập Link!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxLink.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxmaHp.Text))
            {
                MessageBox.Show("Chưa nhập Mã HP!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxmaHp.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(comboBoxVien.Text))
            {
                MessageBox.Show("Chưa chọn Viện!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxVien.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(comboBoxDD.Text))
            {
                MessageBox.Show("Chưa chọn định dạng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxDD.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(comboBoxPL.Text))
            {
                MessageBox.Show("Chưa chọn Phân Loại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxPL.Focus();
                return false;
            }
            return true;
        }

       

        public void HienThiDSTaiLen()
        {
            string QueryX = "SELECT [INNER].[Tên Tài Liệu],[INNER].[Mã HP],[INNER].Link,[INNER].[Phân Loại Theo Lượng Kiến Thức], [Trạng Thái],[Số Lần Đọc],[Lịch Sử Đọc] FROM dbo.ThongTinTaiLieu [INNER] JOIN dbo.TaiLieuNguoiDungDaDoc ON TaiLieuNguoiDungDaDoc.IDTaiLieu = [INNER].ID AND IDDSD = N'" + textBoxMaDSD.Text + "'";
            dataGridViewDSD.DataSource = DataProvider.Instance.ExecuteQuery(QueryX);

            string Query = " SELECT ID,[Tên Tài Liệu],[Mã HP],Link,[Thời Gian Tải Lên],[Định Dạng],[Phân Loại Theo Lượng Kiến Thức] FROM dbo.ThongTinTaiLieu WHERE EmailofUserUpload = N'" + FLogin.EmailU+"' ";
            dgvUpload.DataSource = DataProvider.Instance.ExecuteQuery(Query);

        }

        bool TestMaHP(string MaHPhan)
        {
            return AccountDAO.Instance.TestMaHP(MaHPhan);
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thêm Tài Liệu?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CheckControl())
                {
                    string MaHPhan = textBoxmaHp.Text;
                    if (!TestMaHP(MaHPhan)) {
                        string sqlAddHP = " INSERT INTO dbo.ThongTinHocPhan (    [Mã HP],    [Tên Học Phần],    Viện) VALUES ('" + textBoxmaHp.Text + "',   N'" + textBoxHP.Text + "',    N'" + comboBoxVien.Text + "') ";
                        DataProvider.Instance.ExecuteQuery(sqlAddHP);
                    }

                    string sqlTL = @"INSERT INTO dbo.ThongTinTaiLieu
                                                                    (
                                                                        [Mã HP],
                                                                        [Tên Tài Liệu],
                                                                        Link,
                                                                        [Thời Gian Tải Lên],
                                                                        [Định Dạng],
                                                                        [Phân Loại Theo Lượng Kiến Thức],
                                                                        IDuserUpload,
                                                                        EmailofUserUpload
                                                                    )
                                                                    VALUES
                                                                    (   N'"+textBoxmaHp.Text+"',N'"+textBoxTL.Text+"',N'"+textBoxLink.Text+"',GETDATE(),N'"+comboBoxDD.Text+"',N'"+comboBoxPL.Text+ "',(SELECT ID FROM dbo.ThongTinNguoiDung WHERE Email = N'"+FLogin.EmailU+"'),       N'"+FLogin.EmailU+"')";
                    DataProvider.Instance.ExecuteQuery(sqlTL);
                    string sqlUpdate = "UPDATE dbo.TaiLieuNguoiDungDaDoc SET [Trạng Thái]=DEFAULT,[Số Lần Đọc]=DEFAULT,[Lịch Sử Đọc]=DEFAULT,IDTaiLieu="+ID+",IDDSD="+int.Parse(textBoxMaDSD.Text)+" ";
                    HienThiDSTaiLen();
                }
            }
        }


        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxHP.Text = textBoxLink.Text = textBoxmaHp.Text = textBoxTL.Text = comboBoxVien.Text = comboBoxPL.Text = comboBoxDD.Text = "";
            HienThiDSTaiLen();
        }

        void Binding()
        {
            textBoxTL.DataBindings.Clear();
            textBoxTL.DataBindings.Add("Text", dgvUpload.DataSource, "Tên Tài Liệu");

            textBoxLink.DataBindings.Clear();
            textBoxLink.DataBindings.Add("Text", dgvUpload.DataSource, "Link");

            textBoxmaHp.DataBindings.Clear();
            textBoxmaHp.DataBindings.Add("Text", dgvUpload.DataSource, "Mã HP");

            int i;
            i = dgvUpload.CurrentRow.Index;
            comboBoxDD.Text = dgvUpload.Rows[i].Cells[5].Value.ToString();
            comboBoxPL.Text = dgvUpload.Rows[i].Cells[6].Value.ToString();
        }

        private void ButtonXoa_Click(object sender, EventArgs e) // chức năng xóa tài liệu chỉ dành cho Người Dùng, chỉ xóa đc thông tin tài liệu
        {
            if (MessageBox.Show("Bạn muốn xóa Tài Liệu?", "Cảnh Báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                string sqlXoa = "DELETE FROM dbo.ThongTinTaiLieu WHERE [Tên Tài Liệu] = N'"+textBoxTL.Text+ "' AND [Mã HP] = N'"+textBoxmaHp.Text+"' AND Link =N'"+textBoxLink.Text+"'  AND EmailofUserUpload = N'"+FLogin.EmailU+"' ";
                DataProvider.Instance.ExecuteNonQuery(sqlXoa);
                HienThiDSTaiLen();
            }
        }

        private void buttonSưa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn sửa Tài Liệu?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (textBoxTL.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn Tài liệu muốn sửa thông tin!", "Thông Báo", MessageBoxButtons.OK);
                }
                else {
                    //cập nhật TTTL
                    //int i;
                    //i = dgvUpload.CurrentRow.Index;
                    //int a = (int)dgvUpload.Rows[i].Cells[0].Value;

                    string sqlSua = @"UPDATE dbo.ThongTinTaiLieu SET [Tên Tài Liệu]=N'" + textBoxTL.Text + "',Link=N'" + textBoxLink.Text + "',[Định Dạng]=N'" + comboBoxDD.Text + "',[Phân Loại Theo Lượng Kiến Thức]=N'" + comboBoxPL.Text + "',[Thời Gian Tải Lên]= GETDATE() WHERE  [Tên Tài Liệu]=N'" + textBoxTL.Text + "' ";
                    DataProvider.Instance.ExecuteNonQuery(sqlSua);
                    HienThiDSTaiLen();
                }
            }
        }

        private void dgvUpload_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Binding();
        }
    }
    }
