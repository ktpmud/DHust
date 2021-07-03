
namespace WinFormsApp4
{
    partial class FAdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAdminPage));
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabQLND = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.tabQLTL = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxMHP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTL = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbVien = new System.Windows.Forms.ComboBox();
            this.tabAdmin.SuspendLayout();
            this.tabQLND.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.tabQLTL.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabAdmin.Controls.Add(this.tabQLND);
            this.tabAdmin.Controls.Add(this.tabQLTL);
            this.tabAdmin.Location = new System.Drawing.Point(12, 12);
            this.tabAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.tabAdmin.MinimumSize = new System.Drawing.Size(1054, 620);
            this.tabAdmin.Multiline = true;
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(1054, 620);
            this.tabAdmin.TabIndex = 0;
            // 
            // tabQLND
            // 
            this.tabQLND.BackColor = System.Drawing.Color.FloralWhite;
            this.tabQLND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabQLND.Controls.Add(this.panel3);
            this.tabQLND.Controls.Add(this.panel4);
            this.tabQLND.Controls.Add(this.dgvUser);
            this.tabQLND.Location = new System.Drawing.Point(4, 37);
            this.tabQLND.Margin = new System.Windows.Forms.Padding(2);
            this.tabQLND.Name = "tabQLND";
            this.tabQLND.Padding = new System.Windows.Forms.Padding(2);
            this.tabQLND.Size = new System.Drawing.Size(1046, 579);
            this.tabQLND.TabIndex = 0;
            this.tabQLND.Text = "Quản Lý Người Dùng";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.cbVien);
            this.panel3.Controls.Add(this.textBoxU);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(7, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(880, 69);
            this.panel3.TabIndex = 27;
            // 
            // textBoxU
            // 
            this.textBoxU.Location = new System.Drawing.Point(92, 31);
            this.textBoxU.Name = "textBoxU";
            this.textBoxU.PlaceholderText = "Gợi ý";
            this.textBoxU.Size = new System.Drawing.Size(236, 31);
            this.textBoxU.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(379, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Theo Viện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(92, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Theo Tên";
            // 
            // panel4
            // 
            this.panel4.AccessibleName = "dgvDeCuong";
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.button9);
            this.panel4.Location = new System.Drawing.Point(893, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 566);
            this.panel4.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 85);
            this.button1.TabIndex = 11;
            this.button1.Text = "Tìm ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(179)))));
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(3, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 61);
            this.button4.TabIndex = 5;
            this.button4.Text = "Thêm";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(179)))));
            this.button5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(3, 336);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 48);
            this.button5.TabIndex = 10;
            this.button5.Text = "Sắp Xếp";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WinFormsApp4.Properties.Resources._163630346_256856292825653_2906519646402782198_n2;
            this.pictureBox2.Image = global::WinFormsApp4.Properties.Resources._163630346_256856292825653_2906519646402782198_n2;
            this.pictureBox2.Location = new System.Drawing.Point(3, 444);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(179)))));
            this.button6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(3, 388);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 48);
            this.button6.TabIndex = 7;
            this.button6.Text = "In Thông Tin";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(179)))));
            this.button7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(3, 161);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(141, 61);
            this.button7.TabIndex = 6;
            this.button7.Text = "Sửa";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(179)))));
            this.button8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(3, 282);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(141, 48);
            this.button8.TabIndex = 5;
            this.button8.Text = "Chọn Tất Cả";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(179)))));
            this.button9.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(3, 228);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(141, 48);
            this.button9.TabIndex = 4;
            this.button9.Text = "Xóa";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // dgvUser
            // 
            this.dgvUser.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(4, 79);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 62;
            this.dgvUser.RowTemplate.Height = 33;
            this.dgvUser.Size = new System.Drawing.Size(883, 496);
            this.dgvUser.TabIndex = 25;
            // 
            // tabQLTL
            // 
            this.tabQLTL.BackColor = System.Drawing.Color.FloralWhite;
            this.tabQLTL.Controls.Add(this.panel1);
            this.tabQLTL.Location = new System.Drawing.Point(4, 37);
            this.tabQLTL.Margin = new System.Windows.Forms.Padding(2);
            this.tabQLTL.Name = "tabQLTL";
            this.tabQLTL.Padding = new System.Windows.Forms.Padding(2);
            this.tabQLTL.Size = new System.Drawing.Size(1046, 579);
            this.tabQLTL.TabIndex = 1;
            this.tabQLTL.Text = "Quản Lý Tài Liệu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 575);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.textBoxMHP);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txbTL);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 69);
            this.panel2.TabIndex = 24;
            // 
            // textBoxMHP
            // 
            this.textBoxMHP.Location = new System.Drawing.Point(92, 31);
            this.textBoxMHP.Name = "textBoxMHP";
            this.textBoxMHP.PlaceholderText = "Gợi ý";
            this.textBoxMHP.Size = new System.Drawing.Size(236, 31);
            this.textBoxMHP.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(379, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên Tài Liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(92, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Theo Mã HP";
            // 
            // txbTL
            // 
            this.txbTL.Location = new System.Drawing.Point(379, 31);
            this.txbTL.Name = "txbTL";
            this.txbTL.PlaceholderText = "Gợi ý";
            this.txbTL.Size = new System.Drawing.Size(439, 31);
            this.txbTL.TabIndex = 6;
            // 
            // panel12
            // 
            this.panel12.AccessibleName = "dgvDeCuong";
            this.panel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel12.Controls.Add(this.button3);
            this.panel12.Controls.Add(this.button26);
            this.panel12.Controls.Add(this.button2);
            this.panel12.Controls.Add(this.pictureBox1);
            this.panel12.Controls.Add(this.button21);
            this.panel12.Controls.Add(this.button22);
            this.panel12.Controls.Add(this.button23);
            this.panel12.Controls.Add(this.button24);
            this.panel12.Location = new System.Drawing.Point(889, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(150, 566);
            this.panel12.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aqua;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 85);
            this.button3.TabIndex = 11;
            this.button3.Text = "Tìm ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(179)))));
            this.button26.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button26.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button26.Location = new System.Drawing.Point(3, 94);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(141, 61);
            this.button26.TabIndex = 5;
            this.button26.Text = "Thêm";
            this.button26.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(179)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(3, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 48);
            this.button2.TabIndex = 10;
            this.button2.Text = "Sắp Xếp";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WinFormsApp4.Properties.Resources._163630346_256856292825653_2906519646402782198_n2;
            this.pictureBox1.Image = global::WinFormsApp4.Properties.Resources._163630346_256856292825653_2906519646402782198_n2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 444);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(179)))));
            this.button21.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button21.Location = new System.Drawing.Point(3, 388);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(141, 48);
            this.button21.TabIndex = 7;
            this.button21.Text = "In Thông Tin";
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(179)))));
            this.button22.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button22.Location = new System.Drawing.Point(3, 161);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(141, 61);
            this.button22.TabIndex = 6;
            this.button22.Text = "Sửa";
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(179)))));
            this.button23.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button23.Location = new System.Drawing.Point(3, 282);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(141, 48);
            this.button23.TabIndex = 5;
            this.button23.Text = "Chọn Tất Cả";
            this.button23.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(179)))));
            this.button24.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button24.Location = new System.Drawing.Point(3, 228);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(141, 48);
            this.button24.TabIndex = 4;
            this.button24.Text = "Xóa";
            this.button24.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(883, 496);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.cbVien.Location = new System.Drawing.Point(379, 31);
            this.cbVien.Margin = new System.Windows.Forms.Padding(4);
            this.cbVien.Name = "cbVien";
            this.cbVien.Size = new System.Drawing.Size(436, 33);
            this.cbVien.TabIndex = 11;
            // 
            // FAdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 652);
            this.Controls.Add(this.tabAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1100, 697);
            this.Name = "FAdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Quản Lý Admin";
            this.tabAdmin.ResumeLayout(false);
            this.tabQLND.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.tabQLTL.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabQLND;
        private System.Windows.Forms.TabPage tabQLTL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTL;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxMHP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.TextBox textBoxU;
        private System.Windows.Forms.ComboBox cbVien;
    }
}