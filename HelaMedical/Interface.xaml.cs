using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using HelaMedical.Class;
using HelaMedical.Excep;

namespace HelaMedical
{
    /// <summary>
    /// Логика взаимодействия для Interface.xaml
    /// </summary>
    public partial class Interface : Window
    {
        private ApplicationContext db;
        public List<Alco> alcoFindPerson = new List<Alco>();
        public List<Narcoman> narcoFindPerson = new List<Narcoman>();
        public List<Polizavis> polizFindPerson = new List<Polizavis>();

        public Interface()
        {
            db = new ApplicationContext();
            InitializeComponent();
            this.Closing += Generate_A_Report_Closing;
        }

        private void Open_OblReg()
        {
            MessageBox.Show("Не выбрали область и регион");
            OblReg oblReg = new OblReg();
            oblReg.Show();
            return;
        }
        private void Generate_A_Report_Closing(object sender, CancelEventArgs e)
        {
            try
            {
                if (db != null) db.Dispose();
                DbContexte.DBConection.Closed();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// открыть окно с алкоголиками 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Order(object sender, RoutedEventArgs e)
        {
            if (Other.Obl == null || Other.Reg == null)
            {
                Open_OblReg();
            }
            else
            {
                MainDataWindow mainDataWindow = new MainDataWindow();
                mainDataWindow.Show();
            }
        }

        /// <summary>
        /// открыть окно с наркоманами 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Edit_Order(object sender, RoutedEventArgs e)
        {
            if (Other.Obl == null || Other.Reg == null)
            {
                Open_OblReg();
            }
            else
            {
                MainDataWindow2 mainDataWindow2 = new MainDataWindow2();
                mainDataWindow2.Show();
            }
        }

        /// <summary>
        /// открыть окно с полизависимыми 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Del_Order(object sender, RoutedEventArgs e)
        {
            if (Other.Obl == null || Other.Reg == null)
            {
                Open_OblReg();
            }
            else
            {
                MainDataWindow3 mainDataWindow3 = new MainDataWindow3();
                mainDataWindow3.Show();
            }
        }

        /// <summary>
        /// Создать отчет по определенным критериям 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Generate_A_Report(object sender, RoutedEventArgs e)
        {
            Generate_A_Report generate_A_Report = new Generate_A_Report();
            generate_A_Report.Show();
        }

        /// <summary>
        /// Выбрать Область и регион
        /// </summary>
        private void MenuItem_OblReg_Click(object sender, RoutedEventArgs e)
        {
            OblReg oblReg = new OblReg();
            oblReg.Show();
        }

        /// <summary>
        /// Поиск карты пациента 
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool check_alco = false;
            bool check_narco = false;
            bool check_poliz = false;
            string findperson = FindPerson.Text;

            //Очищаем память перед записью новой информации 
            alcoFindPerson.Clear();
            narcoFindPerson.Clear();
            polizFindPerson.Clear();

            //Ищим инфу в колекциях
            for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
            {
                if (findperson == Alco.AlcoholismPersona[i].FIO)
                {
                    check_alco = true;
                    alcoFindPerson.Add(Alco.AlcoholismPersona[i]);
                }
            }

            for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
            {
                if (findperson == Narcoman.Drug_Addiction[i].FIO)
                {
                    check_narco = true;
                    narcoFindPerson.Add(Narcoman.Drug_Addiction[i]);
                }
            }

            for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
            {
                if (findperson == Polizavis.Alco_Narco_Person[i].FIO)
                {
                    check_poliz = true;
                    polizFindPerson.Add(Polizavis.Alco_Narco_Person[i]);
                }
            }

            if (check_alco == true)
            {
                //Выводим инфу на экран 
                ListOrder.ItemsSource = alcoFindPerson;
            }
            else if (check_narco == true)
            {
                ListOrder.ItemsSource = narcoFindPerson;

            }
            else if (check_poliz == true)
            {
                ListOrder.ItemsSource = polizFindPerson;
            }
            else if (check_alco == false && check_narco == false && check_poliz == false)
            {
                MessageBox.Show("ФИО не найдено");
            }
        }

        private void MenuItem_Download_Alco(object sender, RoutedEventArgs e)
        {
            try
            {
                bool check = false;
                DownloadDBAlco.ReadExcel_Alco();
                check = DownloadDBAlco.Download_Alco();
                if (check)
                {
                    MessageBox.Show("Запись в бд прошла успешно");
                }
                else
                {
                    MessageBox.Show("Ошибка записи в бд");
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
            finally
            {
                db.Dispose();
            }
        }

        private void MenuItem_Download_Narco(object sender, RoutedEventArgs e)
        {
            try { 
            bool check = false;
            DownloadDBNarco.ReadExcel_Narco();
            check = DownloadDBNarco.Download_Narco();
            if (check)
            {
                MessageBox.Show("Запись в бд прошла успешно");
            }
            else
            {
                MessageBox.Show("Ошибка записи в бд");
            }
        }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
            finally
            {
                db.Dispose();
            }
        }

        private void MenuItem_Download_Polizavis(object sender, RoutedEventArgs e)
        {
            try
            {
                bool check = false;
                DownloadDBPoliz.ReadExcel_Poliz();
                check = DownloadDBPoliz.Download_Poliz();
                if (check)
                {
                    MessageBox.Show("Запись в бд прошла успешно");
                }
                else
                {
                    MessageBox.Show("Ошибка записи в бд");
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
            finally
            {
                db.Dispose();
            }
        }

    }
}
