using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelaMedical.Class
{
    public class Polizavis : INotifyPropertyChanged
    {
        //Персональные данные 
        public int Id { get; set; } // Id  
        public string FIO { get; set; } // фамилия 
        public string Sex { get; set; } // пол
        public string Date { get; set; } // дата рождения 
        public string RegionCenterBLR { get; set; } // облостной центр
        public string RaenCentrBLR { get; set; }//раенный центр
        public string Life { get; set; } // Место проживания 
        public string Age { get; set; } // Адрес проживания
        public string FamilyStatus { get; set; } // Семейный статус 
        public string CostOfKids { get; set; } // Количество детей 
        public string FamilyComposition { get; set; } // Состав семьи 
        public string Education { get; set; } // Уровень образование 
        public string Profession { get; set; } // Профессия /должность
        public string TheSkillLevelOfTheProfession { get; set; } // Уровень квалификации профессии


        //Постановка на учет
        public string AddressOfRegistration { get; set; } //Адрес постановки на учет
        public string AddressAtTheTimeOfDeath { get; set; } // Адрес на момент смерти
        public string DataOfRegistration { get; set; } // Дата постановки на учет 
        public string ReRegistrationData { get; set; } // Дата повторной постановки на учет 
        public string TypeOfRegistration { get; set; } // Вид постановки на учет 
        public string Heredity { get; set; } // Наследственность 


        //Инвалидность 
        public string DisabilityGroup { get; set; } // Группа инвалидности
        public string DisabilityStatus { get; set; } // Статус инвалидности
        public string ReasonForDisability { get; set; } // Основание для инвалидности 


        // Социально - экономический статус
        public string WorksStatus { get; set; } // Социально - Экономический статус 
        public string AdmOtv { get; set; } // Привлечение к адм. ответствености (кол)
        public string UgOtv { get; set; } // Привлечение к угл. ответственности 
        public string DlitsMLS { get; set; } // Длительность пребывание в МЛС 
        public string Stat107 { get; set; } // Статья 107 
        public string StatUKRB { get; set; } // Номер статей УК РБ
        public string RodPrav { get; set; } // Лишение родительских прав 
        public string NomLTP { get; set; } // Номер ЛТП 
        public string LTPKol { get; set; } //ЛТП количество 
        public string Hospitel { get; set; } // Больницы 


        //Экстранозологическая коморбидность
        public string EK { get; set; } //Экстранозологическая коморбидность


        //Дата снятия с учета 
        public string DateOfDeregistration { get; set; } // Дата снятия с учета 


        //Данные о смерти 
        public string DateOfDead { get; set; } // дата смерти 
        public string PlaceOfDead { get; set; } // Место смерти 
        public string DeathCertificate { get; set; } // № Свидетельсва о смерти
        public string CauseOfDead { get; set; } // Причина смерти 
        public string DeathCategory { get; set; } // Категория и род смерти 
        public string OpeningPlace { get; set; } // Место вскрытия трупа 
        public string HistoryOfParasucicides { get; set; } // Парасуициды в анамнезе
        public string FeaturesOfObservation { get; set; } // особенности наблюдения 


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

        public string AgeOfDead { get; set; }
        public string AgeOfRegistration { get; set; }

        public string Registrotor { get; set; }

        public static List<Polizavis> Alco_Narco_Person = new List<Polizavis>();



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
