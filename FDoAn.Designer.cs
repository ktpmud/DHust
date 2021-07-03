
namespace WinFormsApp4
{
    partial class FDoAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDoAn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button26 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.dgvDeCuong = new System.Windows.Forms.DataGridView();
            this.TenTaiLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UploadTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeCuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.dgvDeCuong);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 620);
            this.panel1.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.AccessibleName = "dgvDeCuong";
            this.panel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel12.Controls.Add(this.button26);
            this.panel12.Controls.Add(this.button1);
            this.panel12.Controls.Add(this.pictureBox1);
            this.panel12.Controls.Add(this.button21);
            this.panel12.Controls.Add(this.button22);
            this.panel12.Controls.Add(this.button23);
            this.panel12.Controls.Add(this.button24);
            this.panel12.Location = new System.Drawing.Point(851, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(201, 617);
            this.panel12.TabIndex = 24;
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(179)))));
            this.button26.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button26.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button26.Location = new System.Drawing.Point(0, 0);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(201, 61);
            this.button26.TabIndex = 5;
            this.button26.Text = "Danh Sách Đọc";
            this.button26.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(-1, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sắp Xếp";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WinFormsApp4.Properties.Resources._163630346_256856292825653_2906519646402782198_n2;
            this.pictureBox1.Image = global::WinFormsApp4.Properties.Resources._163630346_256856292825653_2906519646402782198_n2;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 350);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.button21.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button21.Location = new System.Drawing.Point(0, 242);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(201, 48);
            this.button21.TabIndex = 7;
            this.button21.Text = "Thêm Vào Danh Sách Đọc";
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(179)))));
            this.button22.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button22.Location = new System.Drawing.Point(0, 67);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(201, 61);
            this.button22.TabIndex = 6;
            this.button22.Text = "Đọc";
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.button23.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button23.Location = new System.Drawing.Point(0, 188);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(201, 48);
            this.button23.TabIndex = 5;
            this.button23.Text = "Chọn Tất Cả";
            this.button23.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(223)))), ((int)(((byte)(199)))));
            this.button24.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button24.Location = new System.Drawing.Point(0, 134);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(201, 48);
            this.button24.TabIndex = 4;
            this.button24.Text = "Chọn ";
            this.button24.UseVisualStyleBackColor = false;
            // 
            // dgvDeCuong
            // 
            this.dgvDeCuong.AccessibleName = "";
            this.dgvDeCuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDeCuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeCuong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvDeCuong.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvDeCuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeCuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTaiLieu,
            this.Link,
            this.UploadTime,
            this.Format});
            this.dgvDeCuong.Location = new System.Drawing.Point(3, 3);
            this.dgvDeCuong.Name = "dgvDeCuong";
            this.dgvDeCuong.ReadOnly = true;
            this.dgvDeCuong.RowHeadersWidth = 62;
            this.dgvDeCuong.RowTemplate.Height = 33;
            this.dgvDeCuong.Size = new System.Drawing.Size(844, 617);
            this.dgvDeCuong.TabIndex = 23;
            // 
            // TenTaiLieu
            // 
            this.TenTaiLieu.DataPropertyName = "Tên Tài Liệu";
            this.TenTaiLieu.HeaderText = "Tên Tài Liệu";
            this.TenTaiLieu.MinimumWidth = 8;
            this.TenTaiLieu.Name = "TenTaiLieu";
            this.TenTaiLieu.ReadOnly = true;
            // 
            // Link
            // 
            this.Link.DataPropertyName = "Link";
            this.Link.HeaderText = "Link";
            this.Link.MinimumWidth = 8;
            this.Link.Name = "Link";
            this.Link.ReadOnly = true;
            // 
            // UploadTime
            // 
            this.UploadTime.DataPropertyName = "Thời Gian Tải Lên";
            this.UploadTime.HeaderText = "Thời Gian Tải Lên";
            this.UploadTime.MinimumWidth = 8;
            this.UploadTime.Name = "UploadTime";
            this.UploadTime.ReadOnly = true;
            // 
            // Format
            // 
            this.Format.DataPropertyName = "Định Dạng";
            this.Format.HeaderText = "Định Dạng";
            this.Format.MinimumWidth = 8;
            this.Format.Name = "Format";
            this.Format.ReadOnly = true;
            // 
            // FDoAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "FDoAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDoAn";
            this.panel1.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeCuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.DataGridView dgvDeCuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Link;
        private System.Windows.Forms.DataGridViewTextBoxColumn UploadTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Format;
    }
}