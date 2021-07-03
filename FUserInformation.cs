using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp4
{
    public partial class FUserInformation : Form
    {
        string connectionString = @"Data Source=DESKTOP-32H73DG\SQLEXPRESS;Initial Catalog=BanChinhSua4;Integrated Security=True";
        public FUserInformation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Email.Text == "" || Password.Text == "" || Fullname.Text == "" || Class.Text == "" || Vien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Fullname", Fullname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", Email.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@MSSV", MSSV.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Day", Day.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Month", Month.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Year", Year.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Class", Class.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Major", Major.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", Password.Text.Trim());

                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Update successfull");
                    Clear();

                }
            }
            this.Close();
        }
        void Clear()
        {
            Fullname.Text = Email.Text = MSSV.Text = Day.Text = Month.Text = Year.Text = Class.Text = Major.Text = Password.Text = "";

        }

    }
}
