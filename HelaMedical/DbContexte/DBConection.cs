using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using HelaMedical.Excep;

namespace HelaMedical.DbContexte
{
    public class DBConection
    {
        public static SqlConnection sqlConnection;
        public static void Select(string ConnectionString) // функция подключения к базе данных и обработка запросов
        {
            try
            { 
                sqlConnection = new SqlConnection(ConnectionString);// подключаемся к базе данны
                sqlConnection.Open(); // открываем соединение 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ExcepLog.Excep(ex);
            }
        }

        public static void Closed()
        {
            try
            {
                sqlConnection.Close(); // Закрываем соединение
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }
    }
}
