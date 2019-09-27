using System;
using static HelaMedical.Class.Narcoman;
using HelaMedical.Class;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows;
using HelaMedical.Excep;


namespace HelaMedical
{
    class DownloadDBNarco
    {
        private static Excel.Application excelApp;
        private static Workbook workBook;
        private static Worksheet workSheet;
        private static Range range;

        private static ApplicationContext db;

        public static void ReadExcel_Narco()
        {
            try
            {
                string ExcelFilePath = OpenFile.Open_File();
                excelApp = new Excel.Application();
                workBook = excelApp.Workbooks.Open(ExcelFilePath);
                workSheet = (Worksheet)workBook.Worksheets.get_Item(1);
                range = workSheet.UsedRange;
                for (int cCnt = 2; cCnt <= range.Rows.Count; cCnt++)
                {
                    Narcoman narcoman = new Narcoman
                    {
                        FIO = Convert.ToString(workSheet.Cells[cCnt, 2].Value),
                        Sex = Convert.ToString(workSheet.Cells[cCnt, 3].Value),
                        Date = Convert.ToString(workSheet.Cells[cCnt, 4].Value),
                        RegionCenterBLR = Convert.ToString(workSheet.Cells[cCnt, 5].Value),
                        RaenCenterBLR = Convert.ToString(workSheet.Cells[cCnt, 6].Value),
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
                        IntranozologicalComorbidity = Convert.ToString(workSheet.Cells[cCnt, 44].Value),
                        TypeOfDrug = Convert.ToString(workSheet.Cells[cCnt, 45].Value),
                        DrugUse = Convert.ToString(workSheet.Cells[cCnt, 46].Value),
                        YearOfFirstUse = Convert.ToString(workSheet.Cells[cCnt, 47].Value),
                        ExperienceAbuseDrug = Convert.ToString(workSheet.Cells[cCnt, 48].Value),
                        Remissions = Convert.ToString(workSheet.Cells[cCnt, 49].Value),
                        RemissionNumber = Convert.ToString(workSheet.Cells[cCnt, 50].Value),
                        RemissionTimer = Convert.ToString(workSheet.Cells[cCnt, 51].Value),
                        DrugDiagnosisX = Convert.ToString(workSheet.Cells[cCnt, 52].Value),
                        AgeOfRegistration = Convert.ToString(workSheet.Cells[cCnt, 53].Value),
                        AgeOfDead = Convert.ToString(workSheet.Cells[cCnt, 54].Value),
                        DataInfo = Convert.ToString(workSheet.Cells[cCnt, 55].Value),
                        Registrotor = Convert.ToString(workSheet.Cells[cCnt, 56].Value)
                    };
                    Drug_Addiction.Add(narcoman);
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

        public static bool Download_Narco()
        {
            db = new ApplicationContext();
            bool check = false;
            int a = 0;
            for (int i = 0; i < Drug_Addiction.Count; i++)
            {
                Narcoman newNarcoPerson = new Narcoman
                {
                    Id = Convert.ToInt32(Drug_Addiction[i].Id),
                    FIO = Drug_Addiction[i].FIO,
                    Sex = Drug_Addiction[i].Sex,
                    Date = Drug_Addiction[i].Date,
                    RegionCenterBLR = Drug_Addiction[i].RegionCenterBLR,
                    RaenCenterBLR = Drug_Addiction[i].RaenCenterBLR,
                    Life = Drug_Addiction[i].Life,
                    Age = Drug_Addiction[i].Age,
                    FamilyStatus = Drug_Addiction[i].FamilyStatus,
                    CostOfKids = Drug_Addiction[i].CostOfKids,
                    FamilyComposition = Drug_Addiction[i].FamilyComposition,
                    Education = Drug_Addiction[i].Education,
                    Profession = Drug_Addiction[i].Profession,
                    TheSkillLevelOfTheProfession = Drug_Addiction[i].TheSkillLevelOfTheProfession,
                    AddressOfRegistration = Drug_Addiction[i].AddressOfRegistration,
                    AddressAtTheTimeOfDeath = Drug_Addiction[i].AddressAtTheTimeOfDeath,
                    DataOfRegistration = Drug_Addiction[i].DataOfRegistration,
                    ReRegistrationData = Drug_Addiction[i].ReRegistrationData,
                    TypeOfRegistration = Drug_Addiction[i].TypeOfRegistration,
                    Heredity = Drug_Addiction[i].Heredity,
                    DisabilityGroup = Drug_Addiction[i].DisabilityGroup,
                    DisabilityStatus = Drug_Addiction[i].DisabilityStatus,
                    ReasonForDisability = Drug_Addiction[i].ReasonForDisability,
                    WorksStatus = Drug_Addiction[i].WorksStatus,
                    AdmOtv = Drug_Addiction[i].AdmOtv,
                    UgOtv = Drug_Addiction[i].UgOtv,
                    DlitsMLS = Drug_Addiction[i].DlitsMLS,
                    Stat107 = Drug_Addiction[i].Stat107,
                    StatUKRB = Drug_Addiction[i].StatUKRB,
                    RodPrav = Drug_Addiction[i].RodPrav,
                    NomLTP = Drug_Addiction[i].NomLTP,
                    LTPKol = Drug_Addiction[i].LTPKol,
                    Hospitel = Drug_Addiction[i].Hospitel,
                    EK = Drug_Addiction[i].EK,
                    DateOfDeregistration = Drug_Addiction[i].DateOfDeregistration,
                    DateOfDead = Drug_Addiction[i].DateOfDead,
                    PlaceOfDead = Drug_Addiction[i].PlaceOfDead,
                    DeathCertificate = Drug_Addiction[i].DeathCertificate,
                    CauseOfDead = Drug_Addiction[i].CauseOfDead,
                    DeathCategory = Drug_Addiction[i].DeathCategory,
                    OpeningPlace = Drug_Addiction[i].OpeningPlace,
                    HistoryOfParasucicides = Drug_Addiction[i].HistoryOfParasucicides,
                    FeaturesOfObservation = Drug_Addiction[i].FeaturesOfObservation,
                    IntranozologicalComorbidity = Drug_Addiction[i].IntranozologicalComorbidity,
                    TypeOfDrug = Drug_Addiction[i].TypeOfDrug,
                    DrugUse = Drug_Addiction[i].DrugUse,
                    YearOfFirstUse = Drug_Addiction[i].YearOfFirstUse,
                    ExperienceAbuseDrug = Drug_Addiction[i].ExperienceAbuseDrug,
                    Remissions = Drug_Addiction[i].Remissions,
                    RemissionNumber = Drug_Addiction[i].RemissionNumber,
                    RemissionTimer = Drug_Addiction[i].RemissionTimer,
                    DrugDiagnosisX = Drug_Addiction[i].DrugDiagnosisX,
                    AgeOfDead = Drug_Addiction[i].AgeOfDead,
                    AgeOfRegistration = Drug_Addiction[i].AgeOfRegistration,
                    DataInfo = Drug_Addiction[i].DataInfo,
                    Registrotor = Other.Regis,
                };
                db.Narcomans.Add(newNarcoPerson);
                db.SaveChanges();
                a++;
            }
            db.Dispose();
            if(a > 0)
                check = true;
            else
                check = false;
            Narcoman.Drug_Addiction.Clear();

            return check;
        }
    }
}
