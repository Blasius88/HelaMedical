using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelaMedical.Class;
using System.Data.Entity;
using System.Windows;
using HelaMedical.Excep;
using System.Data.SqlClient;
using System.Data;

namespace HelaMedical.DbContexte
{
    public class Entity
    {
        /// <summary>
        /// записываем алкоголика в бд
        /// </summary>
        public static void Patient_Сreation_Alco(string fio, string sex, string data, string regionCenterBLR, string raenCenterBLR, string life, string age, string familyStatus,
           string costOfKids, string familyComposition, string education, string profession, string theSkillLevelOfTheProfession, string addressOfRegistration,
           string addressAtTheTimeOfDeath, string dataOfRegistration, string reRegistrationData, string typeOfRegistration, string heredity, string disabilityGroup,
           string disabilityStatus, string reasonForDisability, string socialStatus, string admOtv, string ugOtv, string dlitMLS, string statja107, string statUKRB,
           string rodPrav, string nomLTP, string LTPkol, string hosp, string EK, string dateOfDeregistration, string dateOfDead, string placeOfDead,
           string deathCertificate, string causeOfDeat, string deathCategory, string openingPlace, string historyOfParasucicides, string featuresOfObservation,
           string DrugDiagnosisAlc, string experienceAbuse, string AlcoholicDrinks, string IComorbidity, string ageOfDead, string ageOfRegistration, string dataInfo)
        {
            try
            {
                ApplicationContext db = new ApplicationContext();

                //считываем из бд в массив данных
                foreach (var item in db.Alcos)
                {
                    Alco.AlcoholismPersona.Add(item);
                }

                //иницилизируем переменную Id 
                int IntId = 0;

                //считаем сколько записей в бд
                for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                {
                    IntId++;
                }

                Alco newAlcoPerson = new Alco
                {
                    Id = IntId,
                    FIO = fio,
                    Sex = sex,
                    Date = data,
                    RegionCenterBLR = regionCenterBLR,
                    RaenCenterBLR = raenCenterBLR,
                    Life = life,
                    Age = age,
                    FamilyStatus = familyStatus,
                    CostOfKids = costOfKids,
                    FamilyComposition = familyComposition,
                    Education = education,
                    Profession = profession,
                    TheSkillLevelOfTheProfession = theSkillLevelOfTheProfession,
                    AddressOfRegistration = addressOfRegistration,
                    AddressAtTheTimeOfDeath = addressAtTheTimeOfDeath,
                    DataOfRegistration = dataOfRegistration,
                    ReRegistrationData = reRegistrationData,
                    TypeOfRegistration = typeOfRegistration,
                    Heredity = heredity,
                    DisabilityGroup = disabilityGroup,
                    DisabilityStatus = disabilityStatus,
                    ReasonForDisability = reasonForDisability,
                    WorksStatus = socialStatus,
                    AdmOtv = admOtv,
                    UgOtv = ugOtv,
                    DlitsMLS = dlitMLS,
                    Stat107 = statja107,
                    StatUKRB = statUKRB,
                    RodPrav = rodPrav,
                    NomLTP = nomLTP,
                    LTPKol = LTPkol,
                    Hospitel = hosp,
                    EK = EK,
                    DateOfDeregistration = dateOfDeregistration,
                    DateOfDead = dateOfDead,
                    PlaceOfDead = placeOfDead,
                    DeathCertificate = deathCertificate,
                    CauseOfDead = causeOfDeat,
                    DeathCategory = deathCategory,
                    OpeningPlace = openingPlace,
                    HistoryOfParasucicides = historyOfParasucicides,
                    FeaturesOfObservation = featuresOfObservation,
                    ExperienceAbuse = experienceAbuse,
                    AlcoholicDrinks = AlcoholicDrinks,
                    IK = IComorbidity,
                    DrugDiagnosisAlc = DrugDiagnosisAlc,
                    AgeOfRegistration = ageOfRegistration,
                    AgeOfDead = ageOfDead,
                    DataInfo = dataInfo,
                    Registrotor = Other.Regis,
                };

                db.Alcos.Add(newAlcoPerson);

                db.SaveChanges();

                db.Dispose();

                Alco.AlcoholismPersona.Clear();

                MessageBox.Show("Данные записаны");

            }
            catch (Exception excep)
            {
                MessageBox.Show("Произошла ошибка при добавленни данных в массив");
                ExcepLog.Excep(excep);
                return;
            }
        }

        /// <summary>
        /// Записывает наркоманов в бд
        /// </summary>
        public static void Patient_Сreation_Narco(string fio, string sex, string data, string regionCenterBLR, string raenCenterBLR, string life, string age, string familyStatus,
             string costOfKids, string familyComposition, string education, string profession, string theSkillLevelOfTheProfession, string addressOfRegistration,
             string addressAtTheTimeOfDeath, string dataOfRegistration, string reRegistrationData, string typeOfRegistration, string heredity, string disabilityGroup,
             string disabilityStatus, string reasonForDisability, string socialStatus, string admOtv, string ugOtv, string dlitMLS, string statja107, string statUKRB,
             string rodPrav, string nomLTP, string LTPkol, string hosp, string EK, string dateOfDeregistration, string dateOfDead, string placeOfDead, string deathCertificate,
             string causeOfDeat, string deathCategory, string openingPlace, string historyOfParasucicides, string featuresOfObservation, string intranozologicalComorbidity,
             string typeOfDrug, string drugUse, string yearOfFirstUse, string experienceAbuseDrug, string remissions, string remissionNumber, string remissionTimer,
             string drugDiagnosisX, string ageOfDead, string ageOfRegistration, string dataInfo)
        {
            try
            {
                ApplicationContext db = new ApplicationContext();

                //считываем из бд в массив данных
                foreach (var item in db.Narcomans)
                {
                    Narcoman.Drug_Addiction.Add(item);
                }

                //иницилизируем переменную 
                int IntId = 0;

                //считаем сколько записей в бд
                for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                {
                    IntId++;
                }

                Narcoman newNarcoPerson = new Narcoman
                {
                    Id = IntId,
                    FIO = fio,
                    Sex = sex,
                    Date = data,
                    RegionCenterBLR = regionCenterBLR,
                    RaenCenterBLR = raenCenterBLR,
                    Life = life,
                    Age = age,
                    FamilyStatus = familyStatus,
                    CostOfKids = costOfKids,
                    FamilyComposition = familyComposition,
                    Education = education,
                    Profession = profession,
                    TheSkillLevelOfTheProfession = theSkillLevelOfTheProfession,
                    AddressOfRegistration = addressOfRegistration,
                    AddressAtTheTimeOfDeath = addressAtTheTimeOfDeath,
                    DataOfRegistration = dataOfRegistration,
                    ReRegistrationData = reRegistrationData,
                    TypeOfRegistration = typeOfRegistration,
                    Heredity = heredity,
                    DisabilityGroup = disabilityGroup,
                    DisabilityStatus = disabilityStatus,
                    ReasonForDisability = reasonForDisability,
                    WorksStatus = socialStatus,
                    AdmOtv = Convert.ToString(admOtv),
                    UgOtv = Convert.ToString(ugOtv),
                    DlitsMLS = Convert.ToString(dlitMLS),
                    Stat107 = statja107,
                    StatUKRB = statUKRB,
                    RodPrav = rodPrav,
                    NomLTP = nomLTP,
                    LTPKol = LTPkol,
                    Hospitel = hosp,
                    EK = EK,
                    DateOfDeregistration = dateOfDeregistration,
                    DateOfDead = dateOfDead,
                    PlaceOfDead = placeOfDead,
                    DeathCertificate = deathCertificate,
                    CauseOfDead = causeOfDeat,
                    DeathCategory = deathCategory,
                    OpeningPlace = openingPlace,
                    HistoryOfParasucicides = historyOfParasucicides,
                    FeaturesOfObservation = featuresOfObservation,
                    IntranozologicalComorbidity = intranozologicalComorbidity,
                    TypeOfDrug = typeOfDrug,
                    DrugUse = drugUse,
                    YearOfFirstUse = yearOfFirstUse,
                    ExperienceAbuseDrug = experienceAbuseDrug,
                    Remissions = remissions,
                    RemissionNumber = remissionNumber,
                    RemissionTimer = remissionTimer,
                    DrugDiagnosisX = drugDiagnosisX,
                    AgeOfDead = ageOfDead,
                    AgeOfRegistration = ageOfRegistration,
                    DataInfo = dataInfo,
                    Registrotor = Other.Regis,
                };
                db.Narcomans.Add(newNarcoPerson);

                db.SaveChanges();

                db.Dispose();

                Narcoman.Drug_Addiction.Clear();

                MessageBox.Show("Данные записаны");

            }
            catch (Exception excep)
            {
                MessageBox.Show("Произошла ошибка при добавленни данных в массив");
                ExcepLog.Excep(excep);
                return;
            }
        }

        /// <summary>
        /// Записывает полизависимых в бд 
        /// </summary>
        public static void Patient_Сreation_Alco_Narco(string fio, string sex, string data, string regionCenterBLR, string raenCentrBLR, string life, string age, string familyStatus,
            string costOfKids, string familyComposition, string education, string profession, string theSkillLevelOfTheProfession, string addressOfRegistration,
            string addressAtTheTimeOfDeath, string dataOfRegistration, string reRegistrationData, string typeOfRegistration, string heredity, string disabilityGroup,
            string disabilityStatus, string reasonForDisability, string socialStatus, string admOtv, string ugOtv, string dlitMLS, string statja107, string statUKRB,
            string rodPrav, string nomLTP, string LTPkol, string hosp, string EK, string dateOfDeregistration, string dateOfDead, string placeOfDead,
            string deathCertificate, string causeOfDeat, string deathCategory, string openingPlace, string historyOfParasucicides, string featuresOfObservation,
            string DrugDiagnosisAlc, string experienceAbuse, string AlcoholicDrinks, string intranozologicalComorbidity, string typeOfDrug, string drugUse,
            string yearOfFirstUse, string experienceAbuseDrug, string remissions, string remissionNumber, string remissionTimer, string drugDiagnosisX, string ageOfDead,
            string ageOfRegistration, string dataInfo)
        {
            try
            {
                ApplicationContext db = new ApplicationContext();

                foreach (var item in db.Polizaviss)
                {
                    Polizavis.Alco_Narco_Person.Add(item);
                }

                int IntId = 0;

                for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                {
                    IntId++;
                }

                Polizavis newPolizavis = new Polizavis
                {
                    Id = IntId,
                    FIO = fio,
                    Sex = sex,
                    Date = data,
                    RegionCenterBLR = regionCenterBLR,
                    RaenCenterBLR = raenCentrBLR,
                    Life = life,
                    Age = age,
                    FamilyStatus = familyStatus,
                    CostOfKids = costOfKids,
                    FamilyComposition = familyComposition,
                    Education = education,
                    Profession = profession,
                    TheSkillLevelOfTheProfession = theSkillLevelOfTheProfession,
                    AddressOfRegistration = addressOfRegistration,
                    AddressAtTheTimeOfDeath = addressAtTheTimeOfDeath,
                    DataOfRegistration = dataOfRegistration,
                    ReRegistrationData = reRegistrationData,
                    TypeOfRegistration = typeOfRegistration,
                    Heredity = heredity,
                    DisabilityGroup = disabilityGroup,
                    DisabilityStatus = disabilityStatus,
                    ReasonForDisability = reasonForDisability,
                    WorksStatus = socialStatus,
                    AdmOtv = Convert.ToString(admOtv),
                    UgOtv = Convert.ToString(ugOtv),
                    DlitsMLS = Convert.ToString(dlitMLS),
                    Stat107 = statja107,
                    StatUKRB = statUKRB,
                    RodPrav = rodPrav,
                    NomLTP = nomLTP,
                    LTPKol = LTPkol,
                    Hospitel = hosp,
                    EK = EK,
                    DateOfDeregistration = dateOfDeregistration,
                    DateOfDead = dateOfDead,
                    PlaceOfDead = placeOfDead,
                    DeathCertificate = deathCertificate,
                    CauseOfDead = causeOfDeat,
                    DeathCategory = deathCategory,
                    OpeningPlace = openingPlace,
                    HistoryOfParasucicides = historyOfParasucicides,
                    FeaturesOfObservation = featuresOfObservation,
                    ExperienceAbuse = experienceAbuse,
                    AlcoholicDrinks = AlcoholicDrinks,
                    DrugDiagnosisAlc = DrugDiagnosisAlc,
                    IntranozologicalComorbidity = intranozologicalComorbidity,
                    TypeOfDrug = typeOfDrug,
                    DrugUse = drugUse,
                    YearOfFirstUse = yearOfFirstUse,
                    ExperienceAbuseDrug = experienceAbuseDrug,
                    Remissions = remissions,
                    RemissionNumber = remissionNumber,
                    RemissionTimer = remissionTimer,
                    DrugDiagnosisX = drugDiagnosisX,
                    AgeOfDead = ageOfDead,
                    AgeOfRegistration = ageOfRegistration,
                    DataInfo = dataInfo,
                    Registrotor = Other.Regis,
                };
                db.Polizaviss.Add(newPolizavis);

                db.SaveChanges();

                db.Dispose();

                Polizavis.Alco_Narco_Person.Clear();

                MessageBox.Show("Данные записаны");
            }
            catch (Exception excep)
            {
                MessageBox.Show("Произошла ошибка при добавленни данных в массив");
                ExcepLog.Excep(excep);
            }
        }
    }
}
