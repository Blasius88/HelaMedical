using System;
using static HelaMedical.Class.Alco;
using HelaMedical.Class;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows;
using HelaMedical.Excep;

namespace HelaMedical
{
    public class DownloadDBAlco
    {
        private static Excel.Application excelApp;
        private static Workbook workBook;
        private static Worksheet workSheet;
        private static Range range;

        private static ApplicationContext db;

        public static void ReadExcel_Alco()
        {
            try
            {
                string ExcelFilePath = @"d:\HelaMedical\HelaMedical\File\AlcoDataBase.xlsx";
                excelApp = new Excel.Application();
                workBook = excelApp.Workbooks.Open(ExcelFilePath);
                workSheet = (Worksheet)workBook.Worksheets.get_Item(1);
                range = workSheet.UsedRange;
                for (int cCnt = 2; cCnt <= range.Rows.Count; cCnt++)
                {
                    Alco alcos = new Alco
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
                        ExperienceAbuse = Convert.ToString(workSheet.Cells[cCnt, 44].Value),
                        AlcoholicDrinks = Convert.ToString(workSheet.Cells[cCnt, 45].Value),
                        IK = Convert.ToString(workSheet.Cells[cCnt, 46].Value),
                        DrugDiagnosisAlc = Convert.ToString(workSheet.Cells[cCnt, 47].Value),
                        AgeOfRegistration = Convert.ToString(workSheet.Cells[cCnt, 48].Value),
                        AgeOfDead = Convert.ToString(workSheet.Cells[cCnt, 49].Value),
                        DataInfo = Convert.ToString(workSheet.Cells[cCnt, 50].Value),
                        Registrotor = Convert.ToString(workSheet.Cells[cCnt, 51].Value)
                    };
                    AlcoholismPersona.Add(alcos);
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


        public static bool Download_Alco()
        {
            db = new ApplicationContext();
            bool check;
            int a = 0;
            for (int i = 0; i < AlcoholismPersona.Count; i++)
            {
                Alco newAlcoPerson = new Alco
                {
                    Id = Convert.ToInt32(AlcoholismPersona[i].Id),
                    FIO = AlcoholismPersona[i].FIO,
                    Sex = AlcoholismPersona[i].Sex,
                    Date = AlcoholismPersona[i].Date,
                    RegionCenterBLR = AlcoholismPersona[i].RegionCenterBLR,
                    RaenCenterBLR = AlcoholismPersona[i].RaenCenterBLR,
                    Life = AlcoholismPersona[i].Life,
                    Age = AlcoholismPersona[i].Age,
                    FamilyStatus = AlcoholismPersona[i].FamilyStatus,
                    CostOfKids = AlcoholismPersona[i].CostOfKids,
                    FamilyComposition = AlcoholismPersona[i].FamilyComposition,
                    Education = AlcoholismPersona[i].Education,
                    Profession = AlcoholismPersona[i].Profession,
                    TheSkillLevelOfTheProfession = AlcoholismPersona[i].TheSkillLevelOfTheProfession,
                    AddressOfRegistration = AlcoholismPersona[i].AddressOfRegistration,
                    AddressAtTheTimeOfDeath = AlcoholismPersona[i].AddressAtTheTimeOfDeath,
                    DataOfRegistration = AlcoholismPersona[i].DataOfRegistration,
                    ReRegistrationData = AlcoholismPersona[i].ReRegistrationData,
                    TypeOfRegistration = AlcoholismPersona[i].TypeOfRegistration,
                    Heredity = AlcoholismPersona[i].Heredity,
                    DisabilityGroup = AlcoholismPersona[i].DisabilityGroup,
                    DisabilityStatus = AlcoholismPersona[i].DisabilityStatus,
                    ReasonForDisability = AlcoholismPersona[i].ReasonForDisability,
                    WorksStatus = AlcoholismPersona[i].WorksStatus,
                    AdmOtv = AlcoholismPersona[i].AdmOtv,
                    UgOtv = AlcoholismPersona[i].UgOtv,
                    DlitsMLS = AlcoholismPersona[i].DlitsMLS,
                    Stat107 = AlcoholismPersona[i].Stat107,
                    StatUKRB = AlcoholismPersona[i].StatUKRB,
                    RodPrav = AlcoholismPersona[i].RodPrav,
                    NomLTP = AlcoholismPersona[i].NomLTP,
                    LTPKol = AlcoholismPersona[i].LTPKol,
                    Hospitel = AlcoholismPersona[i].Hospitel,
                    EK = AlcoholismPersona[i].EK,
                    DateOfDeregistration = AlcoholismPersona[i].DateOfDeregistration,
                    DateOfDead = AlcoholismPersona[i].DateOfDead,
                    PlaceOfDead = AlcoholismPersona[i].PlaceOfDead,
                    DeathCertificate = AlcoholismPersona[i].DeathCertificate,
                    CauseOfDead = AlcoholismPersona[i].CauseOfDead,
                    DeathCategory = AlcoholismPersona[i].DeathCategory,
                    OpeningPlace = AlcoholismPersona[i].OpeningPlace,
                    HistoryOfParasucicides = AlcoholismPersona[i].HistoryOfParasucicides,
                    FeaturesOfObservation = AlcoholismPersona[i].FeaturesOfObservation,
                    ExperienceAbuse = AlcoholismPersona[i].ExperienceAbuse,
                    AlcoholicDrinks = AlcoholismPersona[i].AlcoholicDrinks,
                    IK = AlcoholismPersona[i].IK,
                    DrugDiagnosisAlc = AlcoholismPersona[i].DrugDiagnosisAlc,
                    AgeOfRegistration = AlcoholismPersona[i].AgeOfRegistration,
                    AgeOfDead = AlcoholismPersona[i].AgeOfDead,
                    DataInfo = AlcoholismPersona[i].DataInfo,
                    Registrotor = Other.Regis,
                };
                db.Alcos.Add(newAlcoPerson);
                db.SaveChanges();
                
                a++;
            }
            db.Dispose();
            if (a > 0)
                check = true;
            else
                check = false;
            AlcoholismPersona.Clear();

            return check;
        }
    }
}
