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
    }
}