using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachCuTru_383XVNT
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\huynh\OneDrive\Desktop\[CSharp]QuanLy_WDF\QuanLyDanhSachCuTru\DanhSachCuTru_383XVNT\DanhSachCuTru_383XVNT\Database1.mdf;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
