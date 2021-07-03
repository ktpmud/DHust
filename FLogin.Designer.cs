
namespace WinFormsApp4
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button_Signin = new System.Windows.Forms.Button();
            this.label_notAMember = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(180, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 159);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(104, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp4.Properties.Resources.logoWhite1;
            this.pictureBox1.Location = new System.Drawing.Point(359, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(220, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 28);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(220, 352);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(654, 28);
            this.panel5.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.SystemColors.Info;
            this.button_login.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.button_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_login.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Info;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Location = new System.Drawing.Point(453, 515);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(191, 55);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "LOGIN";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.button_Signin);
            this.panel6.Controls.Add(this.label_notAMember);
            this.panel6.Location = new System.Drawing.Point(222, 438);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(335, 39);
            this.panel6.TabIndex = 6;
            // 
            // button_Signin
            // 
            this.button_Signin.FlatAppearance.BorderSize = 0;
            this.button_Signin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.button_Signin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Signin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Signin.ForeColor = System.Drawing.Color.SkyBlue;
            this.button_Signin.Location = new System.Drawing.Point(213, 0);
            this.button_Signin.Name = "button_Signin";
            this.button_Signin.Size = new System.Drawing.Size(118, 39);
            this.button_Signin.TabIndex = 4;
            this.button_Signin.Text = "Sign in";
            this.button_Signin.UseVisualStyleBackColor = true;
            this.button_Signin.Click += new System.EventHandler(this.button_Signin_Click);
            // 
            // label_notAMember
            // 
            this.label_notAMember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_notAMember.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_notAMember.Location = new System.Drawing.Point(0, 0);
            this.label_notAMember.Name = "label_notAMember";
            this.label_notAMember.Size = new System.Drawing.Size(219, 39);
            this.label_notAMember.TabIndex = 0;
            this.label_notAMember.Text = "You are not a member?";
            this.label_notAMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Email
            // 
            this.textBox_Email.BackColor = System.Drawing.Color.Silver;
            this.textBox_Email.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Email.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Email.Location = new System.Drawing.Point(220, 295);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(653, 42);
            this.textBox_Email.TabIndex = 1;
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.Silver;
            this.textBox_password.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_password.ForeColor = System.Drawing.Color.White;
            this.textBox_password.Location = new System.Drawing.Point(220, 381);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(653, 42);
            this.textBox_password.TabIndex = 2;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // FLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::WinFormsApp4.Properties.Resources.Thiết_kế_không_tên__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button_Signin;
        private System.Windows.Forms.Label label_notAMember;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_password;
    }
}