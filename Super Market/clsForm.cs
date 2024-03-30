using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Super_Market
{
    public static class clsForm
    {
        public static bool checkExitsNormalForm(string name)
        {  // kiểm tra 1 form bình thường, không phải form con, có mở hay chưa
            bool check = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
                if (frm.Name == name)  check = true;
            return check;
        }

  

    }
}
