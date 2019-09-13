using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelaMedical.Class
{
    public class Polizavis : Papient, INotifyPropertyChanged
    {
        //Экстранозологическая коморбидность
        public string EK { get; set; } //Экстранозологическая коморбидность

        //Дата снятия с учета 
        public string DateOfDeregistration { get; set; } // Дата снятия с учета 
 
        // Алкоголики 
        //Алкоголизм 
        // Стаж злоупотребления 
        public string ExperienceAbuse { get; set; } //Стаж злоупотребления 

        //Алкогольные напитки 
        public string AlcoholicDrinks { get; set; } // Алкогольные напитки 
        
        //Интранозологическая  коморбидность 
        public string IK { get; set; } // Интранозологическая  коморбидность

        // Наркодиагноз алко
        public string DrugDiagnosisAlc { get; set; } // Наркодиагноз алко

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


        public static List<Polizavis> Alco_Narco_Person = new List<Polizavis>();

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

    }
}
