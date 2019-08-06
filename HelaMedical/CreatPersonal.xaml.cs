using System;
using System.IO;
using System.Text;
using System.Windows;
using static HelaMedical.Incitalization;
using HelaMedical.Excep;
using System.Data.Entity;
using System.Collections.Generic;

namespace HelaMedical
{
    /// <summary>
    /// Логика взаимодействия для CreatPersonal.xaml
    /// </summary>
    public partial class CreatPersonal : Window
    {
        public CreatPersonal()
        {
            InitializeComponent();
        }

        int poz_nam = 0;


        /// <summary>
        /// Клавиша поиска персонажа по ФИО
        /// </summary>
        private void ButtonFind_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Inci.Clear();
                ApplicationContext db = new ApplicationContext();

                foreach (var item in db.Incitalizations)
                {
                    Inci.Add(item);
                }

                int poz = -1;
                string fiofind = FindPerson.Text;
                if (fiofind == "")
                {
                    MessageBox.Show("Не ввели ФИО");
                }
                else
                {
                    for (int i = 0; i < Inci.Count; i++)
                    {
                        if (fiofind == Inci[i].Name) // ищет по ФИО 
                        {
                            FioCreatPeson.Text = Inci[i].Name;
                            PositionCreatPerson.Text = Inci[i].Pasition;
                            PassCreatPerson.Text = Inci[i].Pass;
                            poz_nam = i;
                            poz = 2;
                            break;
                        }
                    }
                }

                if (poz < 1)
                {
                    MessageBox.Show("Работника нет в базе!");
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
                return;
            }
        }
        /// <summary>
        /// Редактировать персонал
        /// </summary>
        private void ButtonCreatePerson_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ApplicationContext db = new ApplicationContext();
                for (int i = 0; i < Inci.Count; i ++)
                {
                    if (Inci[i].Id == poz_nam)
                    {
                        Inci[i].Id = poz_nam;
                        Inci[i].Name = FioCreatPeson.Text;
                        Inci[i].Pasition = PositionCreatPerson.Text;
                        Inci[i].Pass = PassCreatPerson.Text;
                    }
                }
              //  db.Incitalizations.Remove();
                //db.SaveChanges();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
                return;
            }
        }

        /// <summary>
        /// Клавиша назад, закрывает окно
        /// </summary>
        private void BackCreatePersone_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Удаление из Фаила информацию о персонаже 
        /// </summary>
        private void ButtonDelPerson_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string path = @"\HelaMedical\HelaMedical\File\INC.txt";
                StreamReader SDR = new StreamReader(path, Encoding.GetEncoding(1251));
                string Array = SDR.ReadToEnd();
                SDR.Close();
                string[] Lines = System.Text.RegularExpressions.Regex.Split(Array, "\n");
                StreamWriter SWP =
                    new StreamWriter(path, false, Encoding.GetEncoding(1251));
                for (int i = 0; i < Lines.Length; i++)
                {
                    if (i == poz_nam)
                        continue;
                    SWP.WriteLine(Lines[i]);
                }

                SWP.Close();
                Inci.Clear();
                ReadInci();

                // перазаписывает информацию о персонажах в фаил
                StreamWriter NewFile2 = new StreamWriter(path);
                foreach (Incitalization creatperson in Inci)
                {
                    NewFile2.WriteLine(
                        $"{creatperson.Name}|" +
                        $"{creatperson.Pass}|" +
                        $"{creatperson.Pasition}|");
                }

                NewFile2.Close();
                Close();
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