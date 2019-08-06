using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HelaMedical.Class;

namespace HelaMedical.Excep
{
    class ExcepLog
    {
        public static void Excep(Exception exception)
        {
            string register = Other.Regis;
            string path = @"\HelaMedical\HelaMedical\Excep\ExepLog.txt";
            int count = File.ReadAllLines(path).Length;
            StreamWriter NewFile = new StreamWriter(path, true);
            NewFile.WriteLine(
                $"{count}| " +
                $"{exception}| " +
                $"{DateTime.Now}| " +
                $"{register}");
            NewFile.Close();
        }
    }
}
