using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelaMedical.Class
{
    public class Papient
    {
        public int Id { get; set; } // Id  
        public string FIO { get; set; } // фамилия 
        public string Sex { get; set; } // пол
        public string Date { get; set; } // дата рождения 
        public string RegionCenterBLR { get; set; } // облостной центр
        public string RaenCenterBLR { get; set; } // раенный центр 
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

        //Данные о смерти 

        public string DateOfDead { get; set; } // дата смерти 
        public string PlaceOfDead { get; set; } // Место смерти 
        public string DeathCertificate { get; set; } // № Свидетельсва о смерти
        public string CauseOfDead { get; set; } // Причина смерти 
        public string DeathCategory { get; set; } // Категория и род смерти 
        public string OpeningPlace { get; set; } // Место вскрытия трупа 
        public string HistoryOfParasucicides { get; set; } // Парасуициды в анамнезе
        public string FeaturesOfObservation { get; set; } // особенности наблюдения 

        public string AgeOfDead { get; set; } // Возраст на момент смерти 
        public string AgeOfRegistration { get; set; } // возраст на момент постановки на учет

        public string DataInfo { get; set; } // Год учета

        public string Registrotor { get; set; } // регистратор 

    }
}
