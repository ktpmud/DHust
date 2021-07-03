
namespace WinFormsApp4
{
    partial class FHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHomePage));
            this.menuStrip_QuanLyTaiLieu = new System.Windows.Forms.MenuStrip();
            this.AccountManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.UserInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.NewAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.AccessAsAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.Utilities = new System.Windows.Forms.ToolStripMenuItem();
            this.ThoiKhoaBieu = new System.Windows.Forms.ToolStripMenuItem();
            this.LichSuXemTaiLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.PhanTichDanhGia = new System.Windows.Forms.ToolStripMenuItem();
            this.NhacNhoThongBao = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bntSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TenHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbVien = new System.Windows.Forms.ComboBox();
            this.txbMon = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip_QuanLyTaiLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_QuanLyTaiLieu
            // 
            this.menuStrip_QuanLyTaiLieu.BackColor = System.Drawing.Color.LightSalmon;
            this.menuStrip_QuanLyTaiLieu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip_QuanLyTaiLieu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountManagement,
            this.Utilities});
            this.menuStrip_QuanLyTaiLieu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_QuanLyTaiLieu.MdiWindowListItem = this.AccountManagement;
            this.menuStrip_QuanLyTaiLieu.Name = "menuStrip_QuanLyTaiLieu";
            this.menuStrip_QuanLyTaiLieu.Size = new System.Drawing.Size(1082, 33);
            this.menuStrip_QuanLyTaiLieu.TabIndex = 0;
            this.menuStrip_QuanLyTaiLieu.Text = "Quản Lí Tài Liệu";
            // 
            // AccountManagement
            // 
            this.AccountManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserInformation,
            this.NewAccount,
            this.DeleteAccount,
            this.AccessAsAdmin,
            this.LogOut});
            this.AccountManagement.Name = "AccountManagement";
            this.AccountManagement.Size = new System.Drawing.Size(103, 29);
            this.AccountManagement.Text = "Tài Khoản";
            // 
            // UserInformation
            // 
            this.UserInformation.Name = "UserInformation";
            this.UserInformation.Size = new System.Drawing.Size(320, 34);
            this.UserInformation.Text = "Thông Tin";
            this.UserInformation.Click += new System.EventHandler(this.UserInformation_Click);
            // 
            // NewAccount
            // 
            this.NewAccount.Name = "NewAccount";
            this.NewAccount.Size = new System.Drawing.Size(320, 34);
            this.NewAccount.Text = "Tài Khoản Mới";
            this.NewAccount.Click += new System.EventHandler(this.NewAccount_Click);
            // 
            // DeleteAccount
            // 
            this.DeleteAccount.Name = "DeleteAccount";
            this.DeleteAccount.Size = new System.Drawing.Size(320, 34);
            this.DeleteAccount.Text = "Xóa Tài Khoản";
            this.DeleteAccount.Click += new System.EventHandler(this.DeleteAccount_Click);
            // 
            // AccessAsAdmin
            // 
            this.AccessAsAdmin.Enabled = false;
            this.AccessAsAdmin.Name = "AccessAsAdmin";
            this.AccessAsAdmin.Size = new System.Drawing.Size(320, 34);
            this.AccessAsAdmin.Text = "Truy cập với quyền Admin";
            this.AccessAsAdmin.Click += new System.EventHandler(this.AccessAsAdmin_Click);
            // 
            // LogOut
            // 
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(320, 34);
            this.LogOut.Text = "Đăng Xuất";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Utilities
            // 
            this.Utilities.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThoiKhoaBieu,
            this.LichSuXemTaiLieu,
            this.PhanTichDanhGia,
            this.NhacNhoThongBao});
            this.Utilities.Name = "Utilities";
            this.Utilities.Size = new System.Drawing.Size(88, 29);
            this.Utilities.Text = "Tiện Ích";
            // 
            // ThoiKhoaBieu
            // 
            this.ThoiKhoaBieu.Name = "ThoiKhoaBieu";
            this.ThoiKhoaBieu.Size = new System.Drawing.Size(363, 34);
            this.ThoiKhoaBieu.Text = "Thời Khóa Biểu";
            // 
            // LichSuXemTaiLieu
            // 
            this.LichSuXemTaiLieu.Name = "LichSuXemTaiLieu";
            this.LichSuXemTaiLieu.Size = new System.Drawing.Size(363, 34);
            this.LichSuXemTaiLieu.Text = "Lịch Sử Xem Tài liệu";
            // 
            // PhanTichDanhGia
            // 
            this.PhanTichDanhGia.Name = "PhanTichDanhGia";
            this.PhanTichDanhGia.Size = new System.Drawing.Size(363, 34);
            this.PhanTichDanhGia.Text = "Đánh Giá Tiến Trình Đọc Tài Liệu";
            // 
            // NhacNhoThongBao
            // 
            this.NhacNhoThongBao.Name = "NhacNhoThongBao";
            this.NhacNhoThongBao.Size = new System.Drawing.Size(363, 34);
            this.NhacNhoThongBao.Text = "Nhắc Nhở, Thông Báo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CustomFormat = "hh:mm dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(869, 35);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 31);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // bntSearch
            // 
            this.bntSearch.BackColor = System.Drawing.Color.PeachPuff;
            this.bntSearch.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.bntSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.bntSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSearch.Location = new System.Drawing.Point(733, 57);
            this.bntSearch.Margin = new System.Windows.Forms.Padding(4);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(80, 36);
            this.bntSearch.TabIndex = 3;
            this.bntSearch.Text = "Tìm";
            this.bntSearch.UseVisualStyleBackColor = false;
            this.bntSearch.Click += new System.EventHandler(this.BntSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHP,
            this.MaHP,
            this.Vien});
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 456);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // TenHP
            // 
            this.TenHP.DataPropertyName = "Tên Học Phần";
            this.TenHP.HeaderText = "Tên Học Phần";
            this.TenHP.MinimumWidth = 8;
            this.TenHP.Name = "TenHP";
            this.TenHP.ReadOnly = true;
            // 
            // MaHP
            // 
            this.MaHP.DataPropertyName = "Mã HP";
            this.MaHP.HeaderText = "Mã HP";
            this.MaHP.MinimumWidth = 8;
            this.MaHP.Name = "MaHP";
            this.MaHP.ReadOnly = true;
            // 
            // Vien
            // 
            this.Vien.DataPropertyName = "Viện";
            this.Vien.HeaderText = "Viện";
            this.Vien.MinimumWidth = 8;
            this.Vien.Name = "Vien";
            this.Vien.ReadOnly = true;
            // 
            // cbVien
            // 
            this.cbVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbVien.DropDownHeight = 200;
            this.cbVien.DropDownWidth = 100;
            this.cbVien.IntegralHeight = false;
            this.cbVien.Items.AddRange(new object[] {
            "Viện Cơ khí",
            "Viện Cơ khí động lực",
            "Viện Công nghệ sinh học và công nghệ thực phẩm",
            "Viện Công nghệ thông tin và truyền thông",
            "Viện Đào tạo Quốc tế",
            "Viện Đào tạo quốc tế về khoa học vật liệu",
            "Viện Dệt may-Da giầy và Thời trang",
            "Viện Điện",
            "Viện Điện tử - Viễn thông",
            "Viện Khoa học và công nghệ môi trường",
            "Viện Khoa học và công nghệ nhiệt lạnh",
            "Viện Khoa học và kỹ thuật vật liệu",
            "Viện Kinh tế và quản lý",
            "Viện Kỹ thuật hoá học",
            "Viện Nghiên cứu quốc tế MICA",
            "Viện Ngoại ngữ",
            "Viện Sư phạm Kỹ thuật",
            "Viện Tiên tiến khoa học và công nghệ",
            "Viện Toán ứng dụng và Tin học",
            "Viện Vật lý kỹ thuật"});
            this.cbVien.Location = new System.Drawing.Point(221, 59);
            this.cbVien.Margin = new System.Windows.Forms.Padding(4);
            this.cbVien.Name = "cbVien";
            this.cbVien.Size = new System.Drawing.Size(369, 33);
            this.cbVien.TabIndex = 5;
            // 
            // txbMon
            // 
            this.txbMon.Location = new System.Drawing.Point(597, 60);
            this.txbMon.Name = "txbMon";
            this.txbMon.PlaceholderText = "Gợi ý";
            this.txbMon.Size = new System.Drawing.Size(129, 31);
            this.txbMon.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.PeachPuff;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(821, 57);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 36);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 464);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbVien);
            this.panel2.Controls.Add(this.txbMon);
            this.panel2.Controls.Add(this.bntSearch);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Location = new System.Drawing.Point(13, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 99);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(597, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên Học Phần";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(221, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Theo Viện";
            // 
            // FHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImage = global::WinFormsApp4.Properties.Resources.books_2596809_1920;
            this.ClientSize = new System.Drawing.Size(1082, 652);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip_QuanLyTaiLieu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_QuanLyTaiLieu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1100, 697);
            this.Name = "FHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lí Tài Liệu _ DHust";
            this.Load += new System.EventHandler(this.FHomePage_Load);
            this.menuStrip_QuanLyTaiLieu.ResumeLayout(false);
            this.menuStrip_QuanLyTaiLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip ThongTin;
        private System.Windows.Forms.MenuStrip menuStrip_QuanLyTaiLieu;
        private System.Windows.Forms.ToolStripMenuItem Account;
        private System.Windows.Forms.ToolStripMenuItem Utilities;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ThoiKhoaBieu;
        private System.Windows.Forms.ToolStripMenuItem LichSuXemTaiLieu;
        private System.Windows.Forms.ToolStripMenuItem PhanTichDanhGia;
        private System.Windows.Forms.ToolStripMenuItem NhacNhoThongBao;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem AccountManagement;
        private System.Windows.Forms.ToolStripMenuItem UserInformation;
        private System.Windows.Forms.ToolStripMenuItem NewAccount;
        private System.Windows.Forms.ToolStripMenuItem DeleteAccount;
        private System.Windows.Forms.ToolStripMenuItem LogOut;
        private System.Windows.Forms.ToolStripMenuItem AccessAsAdmin;
        private System.Windows.Forms.Button bntSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbVien;
        private System.Windows.Forms.TextBox txbMon;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}