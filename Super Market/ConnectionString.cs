using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Configuration;
namespace Super_Market
{
    class clsBienDungChung
    {
        public static string roleAdmin = "QuanLy";
        public static string roleNhanVien = "NhanVien";
        public static string Quyen = ""; // quyền là nhân viên hay quản lý khi đăng nhập

        public static int FirstTimeOpen = 0; // mở form main lần đầu
    }
    public class ConnectionString
    {
        public static String chuoiKetNoi()
        {
            string result = ConfigurationManager.ConnectionStrings["SiteSqlServer"].ConnectionString;
            return result;
        }
       
    }
}
