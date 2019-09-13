using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelaMedical.Class
{
    public class Alco : Papient, INotifyPropertyChanged
    {
        //Экстранозологическая коморбидность
        public string EK { get; set; } //Экстранозологическая коморбидность


        //Дата снятия с учета 
        public string DateOfDeregistration { get; set; } // Дата снятия с учета 

        //Алкоголизм 
        // Стаж злоупотребления 
        public string ExperienceAbuse { get; set; } //Стаж злоупотребления 


        //Алкогольные напитки 
        public string AlcoholicDrinks { get; set; } // Алкогольные напитки 


        //Интранозологическая  коморбидность 
        public string IK { get; set; } // Интранозологическая  коморбидность

        // Наркодиагноз алко
        public string DrugDiagnosisAlc { get; set; } // Наркодиагноз алко

        public static List<Alco> AlcoholismPersona = new List<Alco>();



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
