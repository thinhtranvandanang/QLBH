using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Super_Market
{
    class clsBienDungChung
    {
        public static string roleAdmin = "QuanLy";
        public static string roleNhanVien = "NhanVien";
        public static string Quyen = ""; // quyền là nhân viên hay quản lý khi đăng nhập

        public static int FirstTimeOpen = 0; // mở form main lần đầu
    }
    public static class ConnectionString
    {
        static String result;
        public static String chuoiKetNoi()
        {
            String curentDirectory = Directory.GetCurrentDirectory();
            String path = Directory.GetCurrentDirectory() + @"\config.txt";
            if (!File.Exists(path))
            {
              Microsoft.Data.ConnectionUI.DataConnectionDialog _dialog = new  Microsoft.Data.ConnectionUI.DataConnectionDialog();
              Microsoft.Data.ConnectionUI.DataSource.AddStandardDataSources(_dialog);
              Microsoft.Data.ConnectionUI.DataConnectionDialog.Show(_dialog);
                        if (_dialog.DialogResult.ToString().Equals("OK"))
                        {
                            using (FileStream fs = new FileStream(path, FileMode.Create))
                            {
                                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
                                {
                                    String connec = _dialog.ConnectionString;
                                    writer.WriteLine(connec);
                                    writer.Close();
                                }
                            }
                        }
                        try
                        {
                            FileStream stream = new FileStream(path, FileMode.Open);

                            StreamReader reader = new StreamReader(stream);
                            result = reader.ReadLine();
                            reader.Close();
                        }
                        catch (FileNotFoundException ex) { }
            }
            else
            {
                FileStream stream = new FileStream(path, FileMode.Open);
                StreamReader reader = new StreamReader(stream);
                result = reader.ReadLine();
                reader.Close();
            }
            return result;
        }
       
    }
}
