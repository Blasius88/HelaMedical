using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;

namespace HelaMedical
{
    public class Incitalization : INotifyPropertyChanged
    {
        public int Id { get; set; } // Id  

        /// <summary>
        /// Логин
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Pass { get; set; }

        /// <summary>
        /// прова на изменение функционала  
        /// </summary>
        public string Pasition { get; set; }

        public static List<Incitalization> Inci = new List<Incitalization>();

        public static List<Incitalization> Registr = new List<Incitalization>();


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        /// <summary>
        /// Считывает инфу из фаила в буфер для инициализации 
        /// </summary>
        public static void ReadInci()
        {
            string path = @"\HelaMedical\HelaMedical\File\INC.txt";
            string s = File.ReadAllText(path);
            string[] maStrings = s.Split('\r', '\n');
            foreach (string s1 in maStrings)
            {
                if (s1.Length > 2)
                {
                    Incitalization person = new Incitalization();
                    string[] mas = s1.Split('|');
                    person.Name = mas[0];
                    person.Pass = mas[1];
                    person.Pasition = mas[2];
                    Inci.Add(person);
                }
            }
        }
    }
}