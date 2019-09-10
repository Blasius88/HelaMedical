using System;
using static HelaMedical.Class.Alco;
using static HelaMedical.Class.Narcoman;
using static HelaMedical.Class.Polizavis;
using HelaMedical.Class;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Windows;
using HelaMedical.Excep;

namespace HelaMedical
{
    public class ExcelDataServis
    {
        /// <summary>
        /// Сохранение информации по выборке из отчета по алкогольной зависимости
        /// </summary>
        public static void Save_Report_Excel_Alco(List<Alco> alco)
        {
            try
            {
                int count = 0;
                for (int i = 0; i < alco.Count; i++)
                    count++;
                if (count > 0)
                {
                    string ExcelFilePath = @"D:\HelaMedical\HelaMedical\File\AlcoReport.xlsx";

                    Excel.Application excelApp = new Excel.Application();
                    Workbook workBook;
                    Worksheet workSheet;
                    workBook = excelApp.Workbooks.Open(ExcelFilePath);
                    workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

                    // Получаем активную таблицу
                    for (int i = 1; i <= alco.Count; i++)
                    {
                        int j = i - 1;
                        workSheet.Cells[i, 1] = alco[j].Id;
                        workSheet.Cells[i, 2] = alco[j].FIO;
                        workSheet.Cells[i, 3] = alco[j].Sex;
                        workSheet.Cells[i, 4] = alco[j].Date;
                        workSheet.Cells[i, 5] = alco[j].RegionCenterBLR;
                        workSheet.Cells[i, 6] = alco[j].Life;
                        workSheet.Cells[i, 7] = alco[j].Age;
                        workSheet.Cells[i, 8] = alco[j].FamilyStatus;
                        workSheet.Cells[i, 9] = alco[j].CostOfKids;
                        workSheet.Cells[i, 10] = alco[j].FamilyComposition;
                        workSheet.Cells[i, 11] = alco[j].Education;
                        workSheet.Cells[i, 12] = alco[j].Profession;
                        workSheet.Cells[i, 13] = alco[j].TheSkillLevelOfTheProfession;
                        workSheet.Cells[i, 14] = alco[j].AddressOfRegistration;
                        workSheet.Cells[i, 15] = alco[j].AddressAtTheTimeOfDeath;
                        workSheet.Cells[i, 16] = alco[j].DataOfRegistration;
                        workSheet.Cells[i, 17] = alco[j].ReRegistrationData;
                        workSheet.Cells[i, 18] = alco[j].TypeOfRegistration;
                        workSheet.Cells[i, 19] = alco[j].Heredity;
                        workSheet.Cells[i, 20] = alco[j].DisabilityGroup;
                        workSheet.Cells[i, 21] = alco[j].DisabilityStatus;
                        workSheet.Cells[i, 22] = alco[j].ReasonForDisability;
                        workSheet.Cells[i, 23] = alco[j].WorksStatus;
                        workSheet.Cells[i, 24] = alco[j].AdmOtv;
                        workSheet.Cells[i, 25] = alco[j].UgOtv;
                        workSheet.Cells[i, 26] = alco[j].DlitsMLS;
                        workSheet.Cells[i, 27] = alco[j].Stat107;
                        workSheet.Cells[i, 28] = alco[j].StatUKRB;
                        workSheet.Cells[i, 29] = alco[j].RodPrav;
                        workSheet.Cells[i, 30] = alco[j].NomLTP;
                        workSheet.Cells[i, 31] = alco[j].LTPKol;
                        workSheet.Cells[i, 32] = alco[j].Hospitel;
                        workSheet.Cells[i, 33] = alco[j].EK;
                        workSheet.Cells[i, 34] = alco[j].DateOfDeregistration;
                        workSheet.Cells[i, 35] = alco[j].DateOfDead;
                        workSheet.Cells[i, 36] = alco[j].PlaceOfDead;
                        workSheet.Cells[i, 37] = alco[j].DeathCertificate;
                        workSheet.Cells[i, 38] = alco[j].CauseOfDead;
                        workSheet.Cells[i, 39] = alco[j].DeathCategory;
                        workSheet.Cells[i, 40] = alco[j].OpeningPlace;
                        workSheet.Cells[i, 41] = alco[j].HistoryOfParasucicides;
                        workSheet.Cells[i, 42] = alco[j].FeaturesOfObservation;
                        workSheet.Cells[i, 43] = alco[j].ExperienceAbuse;
                        workSheet.Cells[i, 44] = alco[j].AlcoholicDrinks;
                        workSheet.Cells[i, 45] = alco[j].IK;
                        workSheet.Cells[i, 46] = alco[j].DrugDiagnosisAlc;
                        workSheet.Cells[i, 47] = alco[j].AgeOfRegistration;
                        workSheet.Cells[i, 48] = alco[j].AgeOfDead;
                        workSheet.Cells[i, 49] = alco[j].Registrotor;
                    }
                    workBook.Save();
                    workBook.Close();
                    excelApp.Quit();
                }
                else
                {
                    MessageBox.Show("Нет информации для создания отчета!!! Сформируйте отчет для записи информации в файл");
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// Сохранение информации по выборке из отчета по наркотической зависимости
        /// </summary>
        public static void Save_Report_Excel_Narco(List<Narcoman> narco)
        {
            int count = 0;
            for (int i = 0; i < narco.Count; i++)
                count++;
            if (count > 0)
            {
                string ExcelFilePath = @"D:\HelaMedical\HelaMedical\File\NarcoReport.xlsx";

                Excel.Application excelApp = new Excel.Application();
                Workbook workBook;
                Worksheet workSheet;
                workBook = excelApp.Workbooks.Open(ExcelFilePath);
                workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

                // Получаем активную таблицу
                for (int i = 1; i <= narco.Count; i++)
                {
                    int j = i - 1;
                    workSheet.Cells[i, 1] = narco[j].Id;
                    workSheet.Cells[i, 2] = narco[j].FIO;
                    workSheet.Cells[i, 3] = narco[j].Sex;
                    workSheet.Cells[i, 4] = narco[j].Date;
                    workSheet.Cells[i, 5] = narco[j].RegionCenterBLR;
                    workSheet.Cells[i, 6] = narco[j].Life;
                    workSheet.Cells[i, 7] = narco[j].Age;
                    workSheet.Cells[i, 8] = narco[j].FamilyStatus;
                    workSheet.Cells[i, 9] = narco[j].CostOfKids;
                    workSheet.Cells[i, 10] = narco[j].FamilyComposition;
                    workSheet.Cells[i, 11] = narco[j].Education;
                    workSheet.Cells[i, 12] = narco[j].Profession;
                    workSheet.Cells[i, 13] = narco[j].TheSkillLevelOfTheProfession;
                    workSheet.Cells[i, 14] = narco[j].AddressOfRegistration;
                    workSheet.Cells[i, 15] = narco[j].AddressAtTheTimeOfDeath;
                    workSheet.Cells[i, 16] = narco[j].DataOfRegistration;
                    workSheet.Cells[i, 17] = narco[j].ReRegistrationData;
                    workSheet.Cells[i, 18] = narco[j].TypeOfRegistration;
                    workSheet.Cells[i, 19] = narco[j].Heredity;
                    workSheet.Cells[i, 20] = narco[j].DisabilityGroup;
                    workSheet.Cells[i, 21] = narco[j].DisabilityStatus;
                    workSheet.Cells[i, 22] = narco[j].ReasonForDisability;
                    workSheet.Cells[i, 23] = narco[j].WorksStatus;
                    workSheet.Cells[i, 24] = narco[j].AdmOtv;
                    workSheet.Cells[i, 25] = narco[j].UgOtv;
                    workSheet.Cells[i, 26] = narco[j].DlitsMLS;
                    workSheet.Cells[i, 27] = narco[j].Stat107;
                    workSheet.Cells[i, 28] = narco[j].StatUKRB;
                    workSheet.Cells[i, 29] = narco[j].RodPrav;
                    workSheet.Cells[i, 30] = narco[j].NomLTP;
                    workSheet.Cells[i, 31] = narco[j].LTPKol;
                    workSheet.Cells[i, 32] = narco[j].Hospitel;
                    workSheet.Cells[i, 33] = narco[j].EK;
                    workSheet.Cells[i, 34] = narco[j].DateOfDeregistration;
                    workSheet.Cells[i, 35] = narco[j].DateOfDead;
                    workSheet.Cells[i, 36] = narco[j].PlaceOfDead;
                    workSheet.Cells[i, 37] = narco[j].DeathCertificate;
                    workSheet.Cells[i, 38] = narco[j].CauseOfDead;
                    workSheet.Cells[i, 39] = narco[j].DeathCategory;
                    workSheet.Cells[i, 40] = narco[j].OpeningPlace;
                    workSheet.Cells[i, 41] = narco[j].HistoryOfParasucicides;
                    workSheet.Cells[i, 42] = narco[j].FeaturesOfObservation;
                    workSheet.Cells[i, 43] = narco[j].IntranozologicalComorbidity;
                    workSheet.Cells[i, 44] = narco[j].TypeOfDrug;
                    workSheet.Cells[i, 45] = narco[j].DrugUse;
                    workSheet.Cells[i, 46] = narco[j].YearOfFirstUse;
                    workSheet.Cells[i, 47] = narco[j].ExperienceAbuseDrug;
                    workSheet.Cells[i, 48] = narco[j].Remissions;
                    workSheet.Cells[i, 49] = narco[j].RemissionNumber;
                    workSheet.Cells[i, 50] = narco[j].RemissionTimer;
                    workSheet.Cells[i, 51] = narco[j].DrugDiagnosisX;
                    workSheet.Cells[i, 52] = narco[j].AgeOfRegistration;
                    workSheet.Cells[i, 53] = narco[j].AgeOfDead;
                    workSheet.Cells[i, 54] = narco[j].Registrotor;
                }
                workBook.Save();
                workBook.Close();
                excelApp.Quit();
            }
            else
            {
                MessageBox.Show("Нет информации для создания отчета!!! Сформируйте отчет для записи информации в файл");
            }
        }

        /// <summary>
        /// Сохранение информации по выборке из отчета по полизависимости
        /// </summary>
        public static void Save_Report_Excel_Poliz(List<Polizavis> poliz)
        {
            int count = 0;
            for (int i = 0; i < poliz.Count; i++)
                count++;
            if (count > 0)
            {
                string ExcelFilePath = @"D:\HelaMedical\HelaMedical\File\PolizavisReport.xlsx";

                Excel.Application excelApp = new Excel.Application();
                Workbook workBook;
                Worksheet workSheet;
                workBook = excelApp.Workbooks.Open(ExcelFilePath);
                workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

                // Получаем активную таблицу
                for (int i = 1; i <= poliz.Count; i++)
                {
                    int j = i - 1;
                    workSheet.Cells[i, 1] = poliz[j].Id;
                    workSheet.Cells[i, 2] = poliz[j].FIO;
                    workSheet.Cells[i, 3] = poliz[j].Sex;
                    workSheet.Cells[i, 4] = poliz[j].Date;
                    workSheet.Cells[i, 5] = poliz[j].RegionCenterBLR;
                    workSheet.Cells[i, 6] = poliz[j].RaenCentrBLR;
                    workSheet.Cells[i, 7] = poliz[j].Life;
                    workSheet.Cells[i, 8] = poliz[j].Age;
                    workSheet.Cells[i, 9] = poliz[j].FamilyStatus;
                    workSheet.Cells[i, 10] = poliz[j].CostOfKids;
                    workSheet.Cells[i, 11] = poliz[j].FamilyComposition;
                    workSheet.Cells[i, 12] = poliz[j].Education;
                    workSheet.Cells[i, 13] = poliz[j].Profession;
                    workSheet.Cells[i, 14] = poliz[j].TheSkillLevelOfTheProfession;
                    workSheet.Cells[i, 15] = poliz[j].AddressOfRegistration;
                    workSheet.Cells[i, 16] = poliz[j].AddressAtTheTimeOfDeath;
                    workSheet.Cells[i, 17] = poliz[j].DataOfRegistration;
                    workSheet.Cells[i, 18] = poliz[j].ReRegistrationData;
                    workSheet.Cells[i, 19] = poliz[j].TypeOfRegistration;
                    workSheet.Cells[i, 20] = poliz[j].Heredity;
                    workSheet.Cells[i, 21] = poliz[j].DisabilityGroup;
                    workSheet.Cells[i, 22] = poliz[j].DisabilityStatus;
                    workSheet.Cells[i, 23] = poliz[j].ReasonForDisability;
                    workSheet.Cells[i, 24] = poliz[j].WorksStatus;
                    workSheet.Cells[i, 25] = poliz[j].AdmOtv;
                    workSheet.Cells[i, 26] = poliz[j].UgOtv;
                    workSheet.Cells[i, 27] = poliz[j].DlitsMLS;
                    workSheet.Cells[i, 28] = poliz[j].Stat107;
                    workSheet.Cells[i, 29] = poliz[j].StatUKRB;
                    workSheet.Cells[i, 30] = poliz[j].RodPrav;
                    workSheet.Cells[i, 31] = poliz[j].NomLTP;
                    workSheet.Cells[i, 32] = poliz[j].LTPKol;
                    workSheet.Cells[i, 33] = poliz[j].Hospitel;
                    workSheet.Cells[i, 34] = poliz[j].EK;
                    workSheet.Cells[i, 35] = poliz[j].DateOfDeregistration;
                    workSheet.Cells[i, 36] = poliz[j].DateOfDead;
                    workSheet.Cells[i, 37] = poliz[j].PlaceOfDead;
                    workSheet.Cells[i, 38] = poliz[j].DeathCertificate;
                    workSheet.Cells[i, 39] = poliz[j].CauseOfDead;
                    workSheet.Cells[i, 40] = poliz[j].DeathCategory;
                    workSheet.Cells[i, 41] = poliz[j].OpeningPlace;
                    workSheet.Cells[i, 42] = poliz[j].HistoryOfParasucicides;
                    workSheet.Cells[i, 43] = poliz[j].FeaturesOfObservation;
                    workSheet.Cells[i, 44] = poliz[j].ExperienceAbuse;
                    workSheet.Cells[i, 45] = poliz[j].AlcoholicDrinks;
                    workSheet.Cells[i, 46] = poliz[j].IK;
                    workSheet.Cells[i, 47] = poliz[j].DrugDiagnosisAlc;
                    workSheet.Cells[i, 48] = poliz[j].IntranozologicalComorbidity;
                    workSheet.Cells[i, 49] = poliz[j].TypeOfDrug;
                    workSheet.Cells[i, 50] = poliz[j].DrugUse;
                    workSheet.Cells[i, 51] = poliz[j].YearOfFirstUse;
                    workSheet.Cells[i, 52] = poliz[j].ExperienceAbuseDrug;
                    workSheet.Cells[i, 53] = poliz[j].Remissions;
                    workSheet.Cells[i, 54] = poliz[j].RemissionNumber;
                    workSheet.Cells[i, 55] = poliz[j].RemissionTimer;
                    workSheet.Cells[i, 56] = poliz[j].DrugDiagnosisX;
                    workSheet.Cells[i, 57] = poliz[j].AgeOfRegistration;
                    workSheet.Cells[i, 58] = poliz[j].AgeOfDead;
                    workSheet.Cells[i, 59] = poliz[j].Registrotor;
                }
                workBook.Save();
                workBook.Close();
                excelApp.Quit();
            }
            else
            {
                MessageBox.Show("Нет информации для создания отчета!!! Сформируйте отчет для записи информации в файл");
            }
        }
    }
}

