using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp4.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {

            get
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string Email, string password) //trả về hàng/bản ghi có đúng Email và Password
        {
            if ( Email == "Admin")
            {
                string queryAd = "SELECT * FROM dbo.Admin WHERE [Tên Hiển Thị] = N'Admin' AND Password = N'" + password + "'";

                DataTable resultAd = DataProvider.Instance.ExecuteQuery(queryAd);
                int Index = resultAd.Rows.Count;
                return Index > 0;

            }


            string query = "SELECT * FROM dbo.ThongTinNguoiDung WHERE Email = N'" + Email + "' AND Password = N'" + password + "'";
            
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            int i = result.Rows.Count;
            return i > 0;
        }

        public bool TestMaHP(string MaHP) //trả về hàng/bản ghi có đúng Email và Password
        {
            string query = "SELECT * FROM dbo.ThongTinHocPhan WHERE [Mã HP] = N'"+MaHP+"'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            int i = result.Rows.Count;
            return i > 0;
        }



    }
}
