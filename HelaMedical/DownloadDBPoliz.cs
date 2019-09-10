using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HelaMedical.Class.Polizavis;
using HelaMedical.Class;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows;
using HelaMedical.Excep;

namespace HelaMedical
{
    class DownloadDBPoliz
    {
        private static Excel.Application excelApp;
        private static Workbook workBook;
        private static Worksheet workSheet;
        private static Range range;

        private static ApplicationContext db;

        public static void ReadExcel_Poliz()
        {
            try
            {
                string ExcelFilePath = @"d:\HelaMedical\HelaMedical\File\NarcoDataBase.xlsx";
                excelApp = new Excel.Application();
                workBook = excelApp.Workbooks.Open(ExcelFilePath);
                workSheet = (Worksheet)workBook.Worksheets.get_Item(1);
                range = workSheet.UsedRange;
                for (int cCnt = 2; cCnt <= range.Rows.Count; cCnt++)
                {
                    Polizavis polizavis = new Polizavis
                    {
                        FIO = Convert.ToString(workSheet.Cells[cCnt, 2].Value),
                        Sex = Convert.ToString(workSheet.Cells[cCnt, 3].Value),
                        Date = Convert.ToString(workSheet.Cells[cCnt, 4].Value),
                        RegionCenterBLR = Convert.ToString(workSheet.Cells[cCnt, 5].Value),
                        RaenCentrBLR = Convert.ToString(workSheet.Cells[cCnt, 6].Value),
                        Life = Convert.ToString(workSheet.Cells[cCnt, 7].Value),
                        Age = Convert.ToString(workSheet.Cells[cCnt, 8].Value),
                        FamilyStatus = Convert.ToString(workSheet.Cells[cCnt, 9].Value),
                        CostOfKids = Convert.ToString(workSheet.Cells[cCnt, 10].Value),
                        FamilyComposition = Convert.ToString(workSheet.Cells[cCnt, 11].Value),
                        Education = Convert.ToString(workSheet.Cells[cCnt, 12].Value),
                        Profession = Convert.ToString(workSheet.Cells[cCnt, 13].Value),
                        TheSkillLevelOfTheProfession = Convert.ToString(workSheet.Cells[cCnt, 14].Value),
                        AddressOfRegistration = Convert.ToString(workSheet.Cells[cCnt, 15].Value),
                        AddressAtTheTimeOfDeath = Convert.ToString(workSheet.Cells[cCnt, 16].Value),
                        DataOfRegistration = Convert.ToString(workSheet.Cells[cCnt, 17].Value),
                        ReRegistrationData = Convert.ToString(workSheet.Cells[cCnt, 18].Value),
                        TypeOfRegistration = Convert.ToString(workSheet.Cells[cCnt, 19].Value),
                        Heredity = Convert.ToString(workSheet.Cells[cCnt, 20].Value),
                        DisabilityGroup = Convert.ToString(workSheet.Cells[cCnt, 21].Value),
                        DisabilityStatus = Convert.ToString(workSheet.Cells[cCnt, 22].Value),
                        ReasonForDisability = Convert.ToString(workSheet.Cells[cCnt, 23].Value),
                        WorksStatus = Convert.ToString(workSheet.Cells[cCnt, 24].Value),
                        AdmOtv = Convert.ToString(workSheet.Cells[cCnt, 25].Value),
                        UgOtv = Convert.ToString(workSheet.Cells[cCnt, 26].Value),
                        DlitsMLS = Convert.ToString(workSheet.Cells[cCnt, 27].Value),
                        Stat107 = Convert.ToString(workSheet.Cells[cCnt, 28].Value),
                        StatUKRB = Convert.ToString(workSheet.Cells[cCnt, 29].Value),
                        RodPrav = Convert.ToString(workSheet.Cells[cCnt, 30].Value),
                        NomLTP = Convert.ToString(workSheet.Cells[cCnt, 31].Value),
                        LTPKol = Convert.ToString(workSheet.Cells[cCnt, 32].Value),
                        Hospitel = Convert.ToString(workSheet.Cells[cCnt, 33].Value),
                        EK = Convert.ToString(workSheet.Cells[cCnt, 34].Value),
                        DateOfDeregistration = Convert.ToString(workSheet.Cells[cCnt, 35].Value),
                        DateOfDead = Convert.ToString(workSheet.Cells[cCnt, 36].Value),
                        PlaceOfDead = Convert.ToString(workSheet.Cells[cCnt, 37].Value),
                        DeathCertificate = Convert.ToString(workSheet.Cells[cCnt, 38].Value),
                        CauseOfDead = Convert.ToString(workSheet.Cells[cCnt, 39].Value),
                        DeathCategory = Convert.ToString(workSheet.Cells[cCnt, 40].Value),
                        OpeningPlace = Convert.ToString(workSheet.Cells[cCnt, 41].Value),
                        HistoryOfParasucicides = Convert.ToString(workSheet.Cells[cCnt, 42].Value),
                        FeaturesOfObservation = Convert.ToString(workSheet.Cells[cCnt, 43].Value),
                        ExperienceAbuse = Convert.ToString(workSheet.Cells[cCnt, 44].Value),
                        AlcoholicDrinks = Convert.ToString(workSheet.Cells[cCnt, 45].Value),
                        IK = Convert.ToString(workSheet.Cells[cCnt, 46].Value),
                        DrugDiagnosisAlc = Convert.ToString(workSheet.Cells[cCnt, 47].Value),
                        IntranozologicalComorbidity = Convert.ToString(workSheet.Cells[cCnt, 48].Value),
                        TypeOfDrug = Convert.ToString(workSheet.Cells[cCnt, 49].Value),
                        DrugUse = Convert.ToString(workSheet.Cells[cCnt, 50].Value),
                        YearOfFirstUse = Convert.ToString(workSheet.Cells[cCnt, 51].Value),
                        ExperienceAbuseDrug = Convert.ToString(workSheet.Cells[cCnt, 52].Value),
                        Remissions = Convert.ToString(workSheet.Cells[cCnt, 53].Value),
                        RemissionNumber = Convert.ToString(workSheet.Cells[cCnt, 54].Value),
                        RemissionTimer = Convert.ToString(workSheet.Cells[cCnt, 55].Value),
                        DrugDiagnosisX = Convert.ToString(workSheet.Cells[cCnt, 56].Value),
                        AgeOfRegistration = Convert.ToString(workSheet.Cells[cCnt, 57].Value),
                        AgeOfDead = Convert.ToString(workSheet.Cells[cCnt, 58].Value),
                        DataInfo = Convert.ToString(workSheet.Cells[cCnt, 59].Value),
                        Registrotor = Convert.ToString(workSheet.Cells[cCnt, 60].Value)
                    };
                    Alco_Narco_Person.Add(polizavis);
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
            finally
            {
                workBook.Close();
                excelApp.Quit();
            }
        }

        public static bool Download_Poliz()
        {
            db = new ApplicationContext();
            bool check = false;
            int a = 0;
            for (int i = 0; i < Alco_Narco_Person.Count; i++)
            {
                Polizavis newPolizavis = new Polizavis
                {
                    Id = Convert.ToInt32(Alco_Narco_Person[i].Id),
                    FIO = Alco_Narco_Person[i].FIO,
                    Sex = Alco_Narco_Person[i].Sex,
                    Date = Alco_Narco_Person[i].Date,
                    RegionCenterBLR = Alco_Narco_Person[i].RegionCenterBLR,
                    RaenCentrBLR = Alco_Narco_Person[i].RaenCentrBLR,
                    Life = Alco_Narco_Person[i].Life,
                    Age = Alco_Narco_Person[i].Age,
                    FamilyStatus = Alco_Narco_Person[i].FamilyStatus,
                    CostOfKids = Alco_Narco_Person[i].CostOfKids,
                    FamilyComposition = Alco_Narco_Person[i].FamilyComposition,
                    Education = Alco_Narco_Person[i].Education,
                    Profession = Alco_Narco_Person[i].Profession,
                    TheSkillLevelOfTheProfession = Alco_Narco_Person[i].TheSkillLevelOfTheProfession,
                    AddressOfRegistration = Alco_Narco_Person[i].AddressOfRegistration,
                    AddressAtTheTimeOfDeath = Alco_Narco_Person[i].AddressAtTheTimeOfDeath,
                    DataOfRegistration = Alco_Narco_Person[i].DataOfRegistration,
                    ReRegistrationData = Alco_Narco_Person[i].ReRegistrationData,
                    TypeOfRegistration = Alco_Narco_Person[i].TypeOfRegistration,
                    Heredity = Alco_Narco_Person[i].Heredity,
                    DisabilityGroup = Alco_Narco_Person[i].DisabilityGroup,
                    DisabilityStatus = Alco_Narco_Person[i].DisabilityStatus,
                    ReasonForDisability = Alco_Narco_Person[i].ReasonForDisability,
                    WorksStatus = Alco_Narco_Person[i].WorksStatus,
                    AdmOtv = Alco_Narco_Person[i].AdmOtv,
                    UgOtv = Alco_Narco_Person[i].UgOtv,
                    DlitsMLS = Alco_Narco_Person[i].DlitsMLS,
                    Stat107 = Alco_Narco_Person[i].Stat107,
                    StatUKRB = Alco_Narco_Person[i].StatUKRB,
                    RodPrav = Alco_Narco_Person[i].RodPrav,
                    NomLTP = Alco_Narco_Person[i].NomLTP,
                    LTPKol = Alco_Narco_Person[i].LTPKol,
                    Hospitel = Alco_Narco_Person[i].Hospitel,
                    EK = Alco_Narco_Person[i].EK,
                    DateOfDeregistration = Alco_Narco_Person[i].DateOfDeregistration,
                    DateOfDead = Alco_Narco_Person[i].DateOfDead,
                    PlaceOfDead = Alco_Narco_Person[i].PlaceOfDead,
                    DeathCertificate = Alco_Narco_Person[i].DeathCertificate,
                    CauseOfDead = Alco_Narco_Person[i].CauseOfDead,
                    DeathCategory = Alco_Narco_Person[i].DeathCategory,
                    OpeningPlace = Alco_Narco_Person[i].OpeningPlace,
                    HistoryOfParasucicides = Alco_Narco_Person[i].HistoryOfParasucicides,
                    FeaturesOfObservation = Alco_Narco_Person[i].FeaturesOfObservation,
                    ExperienceAbuse = Alco_Narco_Person[i].ExperienceAbuse,
                    AlcoholicDrinks = Alco_Narco_Person[i].AlcoholicDrinks,
                    DrugDiagnosisAlc = Alco_Narco_Person[i].DrugDiagnosisAlc,
                    IntranozologicalComorbidity = Alco_Narco_Person[i].IntranozologicalComorbidity,
                    TypeOfDrug = Alco_Narco_Person[i].TypeOfDrug,
                    DrugUse = Alco_Narco_Person[i].DrugUse,
                    YearOfFirstUse = Alco_Narco_Person[i].YearOfFirstUse,
                    ExperienceAbuseDrug = Alco_Narco_Person[i].ExperienceAbuseDrug,
                    Remissions = Alco_Narco_Person[i].Remissions,
                    RemissionNumber = Alco_Narco_Person[i].RemissionNumber,
                    RemissionTimer = Alco_Narco_Person[i].RemissionTimer,
                    DrugDiagnosisX = Alco_Narco_Person[i].DrugDiagnosisX,
                    AgeOfDead = Alco_Narco_Person[i].AgeOfDead,
                    AgeOfRegistration = Alco_Narco_Person[i].AgeOfRegistration,
                    DataInfo = Alco_Narco_Person[i].DataInfo,
                    Registrotor = Other.Regis,
                };

                db.Polizaviss.Add(newPolizavis);
                db.SaveChanges();
                a++;
            }
            db.Dispose();
            if (a > 0)
                check = true;
            else
                check = false;
            Polizavis.Alco_Narco_Person.Clear();

            return check;
        }
    }
}