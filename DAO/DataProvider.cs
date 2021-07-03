using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace WinFormsApp4.DAO
{
    public class DataProvider
    {
        private static DataProvider instance; // đóng gói = Ctrl +R +E

        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return DataProvider.instance;
            }
            private set { DataProvider.instance = value; }  
        }

        private DataProvider() { }

        public string connectionStr = @"Data Source=DESKTOP-32H73DG\SQLEXPRESS;Initial Catalog=BanChinhSua4;Integrated Security=True"; // chuỗi xác định đối tượng kết nối



        public DataTable ExecuteQuery(string Query, object[] parameter = null ) // hàm thực hiện câu truy vấn - đóng mở đường dẫn
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionStr)) // kết nối từ Client xuống Sever
            {

                connection.Open();

                SqlCommand command = new SqlCommand(Query, connection); // câu truy vấn sẽ thực thi

                if (parameter != null)
                {
                    string[] listPara = Query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command); // trung gian thực hiện câu truy vấn, lấy dữ liệu

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        } // trả ra dòng kết quả



        public int ExecuteNonQuery(string Query, object[] parameter = null) // trả ra số dòng được thực thi( insert, delete, update..)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionStr)) // kết nối từ Client xuống Sever
            {

                connection.Open();

                SqlCommand command = new SqlCommand(Query, connection); // câu truy vấn sẽ thực thi

                if (parameter != null)
                {
                    string[] listPara = Query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }


        public object ExecuteScalar(string Query, object[] parameter = null) // tra ra kết quả
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionStr)) // kết nối từ Client xuống Sever
            {

                connection.Open();

                SqlCommand command = new SqlCommand(Query, connection); // câu truy vấn sẽ thực thi

                if (parameter != null)
                {
                    string[] listPara = Query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();

                connection.Close();
            }
            return data;
        }
    }
}
