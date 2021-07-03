using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class webB : Form
    {
        WebBrowser wb;
        public static string link;
        public webB()
        {
            InitializeComponent();
            wb = new WebBrowser();
            wb.Dock = DockStyle.Fill;
            pnlWeb1.Controls.Add(wb);
            wb.Navigate(link);
        }       

    }
}
