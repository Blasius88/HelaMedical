using System;
using System.Windows;
using System.IO;
using System.Windows.Media;
using static HelaMedical.Incitalization;
using HelaMedical.Excep;
using System.Data.Entity;

namespace HelaMedical
{
    /// <summary>
    /// Логика взаимодействия для NewPersonalWindow.xaml
    /// </summary>
    public partial class NewPersonalWindow : Window
    {
        ApplicationContext db;

        public NewPersonalWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// закрытие окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewPersonalClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Добавление нового персонала
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewPersonalAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Download_Database();

                int a = 0;
                string fio = NewPersonalFIO.Text;
                //проверяем пустое ли поле
                if (fio == "")
                {
                    NewPersonalFIO.BorderBrush = Brushes.Red;
                    MessageBox.Show("Не ввели ФИО");
                    return;
                }
                else a++;
                string position = NewPersonalPosition.Text;
                if (position == "")
                {
                    NewPersonalPosition.BorderBrush = Brushes.Red;
                    MessageBox.Show("Не ввели должность");
                    return;
                }
                else a++;
                string pass = NewPersonalPassword.Text;
                if (pass == "")
                {
                    NewPersonalPassword.BorderBrush = Brushes.Red;
                    MessageBox.Show("Не ввели пароль");
                    return;
                }
                else a++;

                string pass1 = NewPersonalPassword1.Text;
                if (pass == "")
                {
                    NewPersonalPassword1.BorderBrush = Brushes.Red;
                    MessageBox.Show("Не ввели повторно пароль");
                    return;
                }
                else a++;

                //Проверяем на наличие данного имени в базе 
                for (int i = 0; i < Inci.Count; i++)
                {
                    if (fio == Inci[i].Name)
                    {
                        NewPersonalFIO.BorderBrush = Brushes.Red;
                        MessageBox.Show("Данное ФИО есть в базе");
                        return;
                    }
                }
                if (NewPersonalPassword.Text != NewPersonalPassword1.Text)
                {

                    NewPersonalPassword.BorderBrush = Brushes.Red;
                    NewPersonalPassword1.BorderBrush = Brushes.Red;
                    MessageBox.Show("Пароли не совпадают");
                    return;
                }

                if (a <= 3) return;
                else
                {
                    CreatPerson(fio, position, pass);
                    Close();
                }

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        public static void CreatPerson(string fio, string position, string pass)
        {
            try
            {
                ApplicationContext db = new ApplicationContext();
                db.Incitalizations.Load();
                foreach (var item in db.Incitalizations)
                {
                    Inci.Add(item);
                }

                int intId = 0;
                for (int i = 0; i < Inci.Count; i++)
                {
                    intId ++;
                }

                Incitalization person = new Incitalization
                {
                    Id = intId,
                    Name = fio,
                    Pass = pass,
                    Pasition = position
                };
                db.Incitalizations.Add(person);
                db.SaveChanges();
                MessageBox.Show("Регистрация прошла успешна");
                db.Dispose();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// загрузка данных из базы
        /// </summary>
        public void Download_Database()
        {
            db = new ApplicationContext();
            db.Incitalizations.Load();
            foreach (var item in db.Incitalizations)
            {
                Inci.Add(item);
            }
        }
    }
}
