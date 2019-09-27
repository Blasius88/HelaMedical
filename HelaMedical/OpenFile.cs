using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelaMedical
{
    public class OpenFile
    {
        public static string Open_File()
        {
            string fileName = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text documents (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.FilterIndex = 2;
            Nullable<bool> result = dialog.ShowDialog();
            if (result == true)
            {
                fileName = dialog.FileName;
            }
            return fileName;
        }

        public static string Save_File_Excel()
        {
            string fileName = "";
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel file (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            dialog.FilterIndex = 2;
            Nullable<bool> result = dialog.ShowDialog();
            if (result == true)
            {
                fileName = dialog.FileName;
            }
            return fileName;
        }
    }
}