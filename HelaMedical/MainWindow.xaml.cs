using System;
using System.Data.Entity;
using System.Windows;
using HelaMedical.Class;
using HelaMedical.Excep;
using HelaMedical.DbContexte;
using System.IO;
using System.Data.SqlClient;

namespace HelaMedical
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // BackgroundWorker backgroundWorker;

        ApplicationContext db;

        public MainWindow()
        {
            try
            {
                FileLoad();
                db = new ApplicationContext();
                db.Incitalizations.Load(); //загружаем из бд именна 
                InitializeComponent();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }
        /// <summary>
        /// Регистрация нового сотрудника 
        /// </summary>
        public void Button_Registration(object sender, RoutedEventArgs e)
        {
            NewPersonalWindow newPersonal = new NewPersonalWindow();
            newPersonal.Show();
        }

        public static void FileLoad()
        {
            try
            {
                string path = @"\HelaMedical\HelaMedical\File\INC.INI";
                string s = File.ReadAllText(path);
                DBConection.Select(s);
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// Вход в систему
        /// </summary>
        private void Button_Entry(object sender, RoutedEventArgs e)
        {
            try
            {
                bool c = false; // Для проверики наличия имени в массиве 
                string a = tb.Text;
                string b = Convert.ToString(pass.Password);
                // проверяем соответствие имени и пароля в системе 
                foreach (var sIncitalization in db.Incitalizations)
                {
                    if (a == sIncitalization.Name && b == sIncitalization.Pass)
                    {
                        c = true;
                        Incitalization reg = new Incitalization
                        {

                            Name = a
                        };
                        Incitalization.Registr.Add(reg);
                        Other.Regis = a; // запоминаем имя регистратора данных
                        break;
                    }
                    // имя не найдено 
                    else
                    {
                        c = false;
                    }
                }
                
                // если в массиве нет имени 
                if (c == false)
                {
                    MessageBox.Show("Неправельно введен логин или пароль");
                    tb.Clear(); // очищает поле логин
                    pass.Clear(); // очищает поле пароль
                }

                else
                {
                    Interface iInterface = new Interface();
                    iInterface.Show();
                    Close();
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
                return;
            }
        }
    }
}