
namespace WinFormsApp4
{
    partial class webB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(webB));
            this.pnlWeb1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlWeb1
            // 
            this.pnlWeb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlWeb1.Location = new System.Drawing.Point(13, 13);
            this.pnlWeb1.Margin = new System.Windows.Forms.Padding(4);
            this.pnlWeb1.Name = "pnlWeb1";
            this.pnlWeb1.Size = new System.Drawing.Size(1052, 618);
            this.pnlWeb1.TabIndex = 3;
            // 
            // webB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.Controls.Add(this.pnlWeb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "webB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Link";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlWeb1;
    }
}