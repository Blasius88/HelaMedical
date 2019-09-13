using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelaMedical.Class
{
    public class Narcoman : Papient, INotifyPropertyChanged
    {
        //Экстранозологическая коморбидность
        public string EK { get; set; } //Экстранозологическая коморбидность


        //Дата снятия с учета 
        public string DateOfDeregistration { get; set; } // Дата снятия с учета 

        //наркотики
        public string IntranozologicalComorbidity { get; set; }

        public string TypeOfDrug { get; set; } // Вид наркотика 
        public string DrugUse { get; set; } // Способ употребления 
        public string YearOfFirstUse { get; set; } // Год первого употребления 
        public string ExperienceAbuseDrug { get; set; } //стаж злоупотребления 
        public string Remissions { get; set; } // Ремиссии
        public string RemissionNumber { get; set; } // количество ремиссий 
        public string RemissionTimer { get; set; } // Продолжительность ремиссии
        public string DrugDiagnosisX { get; set; } // наркодиагноз х 


        public static List<Narcoman> Drug_Addiction = new List<Narcoman>();



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
