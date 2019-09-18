using System;
using System.Windows;
using System.Windows.Media;
using HelaMedical.Class;
using HelaMedical.Excep;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HelaMedical
{
     /// <summary>
    /// Логика взаимодействия для MainDataWindow.xaml
    /// </summary>
    public partial class MainDataWindow : Window
    {
        private bool worksStatus = false;
        private bool worksStatus2 = false;
        private bool worksStatus3 = false;
        private bool worksStatus4 = false;
        private bool worksStatus5 = false;
        private bool worksStatus6 = false;

        private bool stat107 = false;
        private bool rodprav = false;

        private bool GKND = false;
        private bool BSMP = false;
        private bool RKPB = false;
        private bool hospitOther = false;

        private bool chmt = false;
        private bool chmtMulti = false;
        private bool boneAracture = false;
        private bool boneAractureMulti = false;
        private bool wound = false;
        private bool tuberculosis = false;
        private bool hepatitisB = false;
        private bool hepatitisC = false;
        private bool jazvaZeludka = false;
        private bool jazvaDPK = false;
        private bool hiv = false;
        private bool notSpecifiedEksta = false;

        private bool historyOfParasucicide = false;

        private bool f101I = false;
        private bool f101II = false;
        private bool f101III = false;
        private bool f1020I = false;
        private bool f1020II = false;
        private bool f1020III = false;
        private bool f1021I = false;
        private bool f1021II = false;
        private bool f1021III = false;
        private bool f1022I = false;
        private bool f1022II = false;
        private bool f1022III = false;
        private bool f1023I = false;
        private bool f1023II = false;
        private bool f1023III = false;
        private bool f1024I = false;
        private bool f1024II = false;
        private bool f1024III = false;
        private bool f1025I = false;
        private bool f1025II = false;
        private bool f1025III = false;
        private bool f1026I = false;
        private bool f1026II = false;
        private bool f1026III = false;
        private bool f1031I = false;
        private bool f1031II = false;
        private bool f1031III = false;
        private bool f1040I = false;
        private bool f1040II = false;
        private bool f1040III = false;
        private bool f1041I = false;
        private bool f1041II = false;
        private bool f1041III = false;
        private bool f1045I = false;
        private bool f1045II = false;
        private bool f1045III = false;
        private bool f105I = false;
        private bool f105II = false;
        private bool f105III = false;
        private bool f1050I = false;
        private bool f1050II = false;
        private bool f1050III = false;
        private bool f1051I = false;
        private bool f1051II = false;
        private bool f1051III = false;
        private bool f1052I = false;
        private bool f1052II = false;
        private bool f1052III = false;
        private bool f1053I = false;
        private bool f1053II = false;
        private bool f1053III = false;
        private bool f1054I = false;
        private bool f1054II = false;
        private bool f1054III = false;
        private bool f1055I = false;
        private bool f1055II = false;
        private bool f1055III = false;
        private bool f1056I = false;
        private bool f1056II = false;
        private bool f1056III = false;
        private bool f106I = false;
        private bool f106II = false;
        private bool f106III = false;
        private bool f1071I = false;
        private bool f1071II = false;
        private bool f1071III = false;
        private bool f1073I = false;
        private bool f1073II = false;
        private bool f1073III = false;
        private bool f109I = false;
        private bool f109II = false;
        private bool f109III = false;
        private bool f1003I = false;
        private bool f1003II = false;
        private bool f1003III = false;
        private bool f1006I = false;
        private bool f1006II = false;
        private bool f1006III = false;

        private bool vodka = false;
        private bool wine = false;
        private bool beer = false;
        private bool surrogates = false;
        private bool moonshine = false;
        private bool notSpecified = false;
        private bool alcoholContainingDrugs = false;
        private bool otherAlco = false;

        private bool fattyHepatosis = false;
        private bool alcHepatosis = false;
        private bool alcCirrhosis = false;
        private bool alcPancreatitis = false;
        private bool alcCardiomyopathy = false;
        private bool alcPolyneuropathy = false;
        private bool alcEncephalopathy = false;
        private bool alcEpilepsy = false;
        private bool chronicalBronchitis = false;
        private bool alcNotSpecified = false;
        private bool orintirDead = false;

        public MainDataWindow()
        {
            InitializeComponent();
            Bool.AlcoBool = false;
            Registrator.Text = Other.Regis;
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            scroll.LineUp();
        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            scroll.LineDown();
        }

        private void Left_Click(object sender, RoutedEventArgs e)
        {
            scroll.LineLeft();
        }

        private void Right_Click(object sender, RoutedEventArgs e)
        {
            scroll.LineRight();
        }

        /// <summary>
        /// закрытия окна 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitAlc_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        
        /// <summary>
        /// Добавление карточки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddAlc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool check = true;
                //Персональные данные 
                string fio = FIO.Text;
                string sex = Sex.Text;
                if (sex == "")
                {
                    Sex.BorderThickness = new Thickness(3);
                    Sex.BorderBrush = Brushes.Red;
                    check = false;
                }
                
                string data = Date.Text;
                if (data == "")
                {
                    Date.BorderThickness = new Thickness(3);
                    Date.BorderBrush = Brushes.Red;
                    check = false;
                }
                string regionCenterBLR = Other.Obl;
                string raenCenterBLR = Other.Reg;
                string life = Life.Text;
                if (life == "")
                {
                    Life.BorderThickness = new Thickness(3);
                    Life.BorderBrush = Brushes.Red;
                    check = false;
                }
                string age = Age.Text;
                if (age == "")
                {
                    Age.BorderThickness = new Thickness(3);
                    Age.BorderBrush = Brushes.Red;
                    check = false;
                }
                string familyStatus = FamilyStatus.Text;
                if (familyStatus == "")
                {
                    FamilyStatus.BorderThickness = new Thickness(3);
                    FamilyStatus.BorderBrush = Brushes.Red;
                    check = false;
                }
                string costOfKids = CostOfKids.Text;
                if (costOfKids =="")
                {
                    CostOfKids.BorderThickness = new Thickness(3);
                    CostOfKids.BorderBrush = Brushes.Red;
                    check = false;
                }
                string familyComposition = FamilyComposition.Text;
                if (familyComposition == "")
                {
                    FamilyComposition.BorderThickness = new Thickness(3);
                    FamilyComposition.BorderBrush = Brushes.Red;
                    check = false;
                }
                string education = Education.Text;
                if (education =="")
                {
                    Education.BorderThickness = new Thickness(3);
                    Education.BorderBrush = Brushes.Red;
                    check = false;
                }
                string profession = Profession.Text;
                if (profession == "")
                {
                    Profession.BorderThickness = new Thickness(3);
                    Profession.BorderBrush = Brushes.Red;
                    check = false;
                }
                string theSkillLevelOfTheProfession = TheSkillLevelOfTheProfession.Text;
                if (theSkillLevelOfTheProfession == "")
                {
                    TheSkillLevelOfTheProfession.BorderThickness = new Thickness(3);
                    TheSkillLevelOfTheProfession.BorderBrush = Brushes.Red;
                    check = false;
                }

                //Постановка на учет 
                string addressOfRegistration = AddressOfRegistration.Text;
                string addressAtTheTimeOfDeath = AddressAtTheTimeOfDeath.Text;
                string dataOfRegistration = DataOfRegistration.Text;
                string reRegistrationData = ReRegistrationData.Text;
                string typeOfRegistration = TypeOfRegistration.Text;
                string heredity = Heredity.Text;

                //Инвалидность
                string disabilityGroup = DisabilityGroup.Text;
                string disabilityStatus = DisabilityStatus.Text;
                string reasonForDisability = ReasonForDisability.Text;

                //Социально-экономический статус 
                string SocialStatus = "";
                if (worksStatus == true) SocialStatus += "Работает. ";
                if (worksStatus2 == true) SocialStatus += "Работает эпизодически. ";
                if (worksStatus3 == true) SocialStatus += "Не работает. ";
                if (worksStatus4 == true) SocialStatus += "Работающий пенсионер. ";
                if (worksStatus5 == true) SocialStatus += "Неработающий пенсионер. ";
                if (worksStatus6 == true) SocialStatus += "Не уточнено. ";

                //Адм и уголовная ответственность
                string admOtv = AdmOtv.Text;
                string ugOtv = UgOtv.Text;
                string dlitMLS = DlitMLS.Text;

                string statja107 = "";
                if (stat107 == true) statja107 += "Да";
                else statja107 += "Нет";

                string statUKRB = StatUKRB.Text;
                
                string rodPrav = "";
                if (rodprav == true) rodPrav += "Да";
                else rodPrav += "Нет";

                string nomLTP = NomLTP.Text;
                string LTPkol = LTPKol.Text;

                //Больничные данные.
                //больницы 
                string hosp = "";
                string quantityGKND = QuantityGNKD.Text;
                if (GKND == true)
                {
                    if (quantityGKND != "") hosp += "ГКНД " + quantityGKND + " раз. ";
                    else
                    {
                        QuantityGNKD.BorderThickness = new Thickness(3);
                        QuantityGNKD.BorderBrush = Brushes.Red;
                        check = false;
                    }
                }
                string quantityRKPB = QuantityRKPB.Text;
                if (RKPB == true)
                {
                    if (quantityRKPB != "") hosp += "РКПБ/РНПЦ " + quantityRKPB + " раз. ";
                    else
                    {
                        QuantityRKPB.BorderThickness = new Thickness(3);
                        QuantityRKPB.BorderBrush = Brushes.Red;
                        check = false;
                    }
                }
                string quantityBSMP = QuantityBSMP.Text;
                if (BSMP == true)
                {
                    if (quantityBSMP != "") hosp += "БСМП " + quantityBSMP + " раз. ";
                    else
                    {
                        QuantityBSMP.BorderThickness = new Thickness(3);
                        QuantityBSMP.BorderBrush = Brushes.Red;
                        check = false;
                    }
                }
                if (hospitOther == true)
                {
                    string hospitelOther = Other.HospitelOther;
                    hosp += hospitelOther;
                }


                //Экстранозологическая коморбидность
                string EK = "";
                if (chmt == true) EK += "ЧМТ. ";
                if (chmtMulti == true) EK += "ЧМТ множ. ";
                if (boneAracture == true) EK += "Перелом костей. ";
                if (boneAractureMulti == true) EK += "Перелом костей множ. ";
                if (wound == true) EK += "Ранение. ";
                if (tuberculosis == true) EK += "Туберкулезю ";
                if (hepatitisB == true) EK += "Гепатит Б. ";
                if (hepatitisC == true) EK += "Гепатит С. ";
                if (jazvaZeludka == true) EK += "Язва желудка";
                if (jazvaDPK == true) EK += "Язва ДПК";
                if (hiv == true) EK += "ВИЧ. ";
                if (notSpecifiedEksta == true) EK += "Не уточнено";

                string dateOfDeregistration = DateOfDeregistration.Text;


                //Данные о смерти
                string dateOfDead = DateOfDead.Text;
                if (orintirDead == true)
                {
                    dateOfDead += "(Ориентировачная)";
                }
                string placeOfDead = PlaceOfDead.Text;
                string deathCertificate = DeathCertificate.Text;
                string causeOfDeat = CauseOfDeat.Text;
                string deathCategory = DeathCategory.Text;
                string openingPlace = OpeningPlace.Text;

                string historyOfParasucicides = "";
                if (historyOfParasucicide == true) historyOfParasucicides += "Парасуициды в анамнезе";

                string featuresOfObservation = FeaturesOfObservation.Text;


                //Наркодиагноз
                string f101 = "";
                if (f101I == true) f101 += "f101I";
                else if (f101II == true) f101 += "f101II";
                else if (f101III == true) f101 += "f101III";

                string f1020 = "";
                if (f1020I == true) f1020 += "f1020I";
                else if (f1020II == true) f1020 += "f1020II";
                else if (f1020III == true) f1020 += "f1020III";

                string f1021 = "";
                if (f1021I == true) f1021 += "f1021I";
                else if (f1021II == true) f1021 += "f1021II";
                else if (f1021III == true) f1021 += "f1021III";

                string f1022 = "";
                if (f1022I == true) f1022 += "f1022I";
                else if (f1022II == true) f1022 += "f1022II";
                else if (f1022III == true) f1022 += "f1022III";

                string f1023 = "";
                if (f1023I == true) f1023 += "f1023I";
                else if (f1023II == true) f1023 += "f1023II";
                else if (f1023III == true) f1023 += "f1023III";

                string f1024 = "";
                if (f1024I == true) f1024 += "f1024I";
                else if (f1024II == true) f1024 += "f1024II";
                else if (f1024III == true) f1024 += "f1024III";

                string f1025 = "";
                if (f1025I == true) f1025 += "f1025I";
                else if (f1025II == true) f1025 += "f1025II";
                else if (f1025III == true) f1025 += "f1025III";

                string f1026 = "";
                if (f1026I == true) f1026 += "f1026I";
                else if (f1026II == true) f1026 += "f1026II";
                else if (f1026III == true) f1026 += "f1026III";

                string f1031 = "";
                if (f1031I == true) f1031 += "f1031I";
                else if (f1031II == true) f1031 += "f1031II";
                else if (f1031III == true) f1031 += "f1031III";

                string f1040 = "";
                if (f1040I == true) f1040 += "f1040I";
                else if (f1040II == true) f1040 += "f1040II";
                else if (f1040III == true) f1040 += "f1040III";

                string f1041 = "";
                if (f1041I == true) f1041 += "f1041I";
                else if (f1041II == true) f1041 += "f1041II";
                else if (f1041III == true) f1041 += "f1041III";

                string f1045 = "";
                if (f1045I == true) f1045 += "f1045I";
                else if (f1045II == true) f1045 += "f1045II";
                else if (f1045III == true) f1045 += "f1045III";

                string f105 = "";
                if (f105I == true) f105 += "f105I";
                else if (f105II == true) f105 += "f105II";
                else if (f105III == true) f105 += "f105III";

                string f1050 = "";
                if (f1050I == true) f1050 += "f1050I";
                else if (f1050II == true) f1050 += "f1050II";
                else if (f1050III == true) f1050 += "f1050III";

                string f1051 = "";
                if (f1051I == true) f1051 += "f1051I";
                else if (f1051II == true) f1051 += "f1051II";
                else if (f1051III == true) f1051 += "f1051III";

                string f1052 = "";
                if (f1052I == true) f1052 += "f1052I";
                else if (f1052II == true) f1052 += "f1052II";
                else if (f1052III == true) f1052 += "f1052III";

                string f1053 = "";
                if (f1053I == true) f1053 += "f1053I";
                else if (f1053II == true) f1053 += "f1053II";
                else if (f1053III == true) f1053 += "f1053III";

                string f1054 = "";
                if (f1054I == true) f1054 += "f1054I";
                else if (f1054II == true) f1054 += "f1054II";
                else if (f1054III == true) f1054 += "f1054III";

                string f1055 = "";
                if (f1055I == true) f1055 += "f1055I";
                else if (f1055II == true) f1055 += "f1055II";
                else if (f1055III == true) f1055 += "f1055III";

                string f1056 = "";
                if (f1056I == true) f1056 += "f1056I";
                else if (f1056II == true) f1056 += "f1056II";
                else if (f1056III == true) f1056 += "f1056III";

                string f106 = "";
                if (f106I == true) f106 += "f106I";
                else if (f106II == true) f106 += "f106II";
                else if (f106III == true) f106 += "f106III";

                string f1071 = "";
                if (f1071I == true) f1071 += "f1071I";
                else if (f1071II == true) f1071 += "f1071II";
                else if (f1071III == true) f1071 += "f1071III";

                string f1073 = "";
                if (f1073I == true) f1073 += "f1073I";
                else if (f1073II == true) f1073 += "f1073II";
                else if (f1073III == true) f1073 += "f1073III";

                string f109 = "";
                if (f109I == true) f109 += "f109I";
                else if (f109II == true) f109 += "f109II";
                else if (f109III == true) f109 += "f109III";

                string f1003 = "";
                if (f1003I == true) f1003 += "f1003I";
                else if (f1003II == true) f1003 += "f1003II";
                else if (f1003III == true) f1003 += "f1003III";

                string f1006 = "";
                if (f1006I == true) f1006 += "f1006I";
                else if (f1006II == true) f1006 += "f1006II";
                else if (f1006III == true) f1006 += "f1006III";

                string DrugDiagnosisAlc = "";
                if (f101 != "") DrugDiagnosisAlc += f101 + ", ";
                if (f1020 != "") DrugDiagnosisAlc += f1020 + ", ";
                if (f1021 != "") DrugDiagnosisAlc += f1021 + ", ";
                if (f1022 != "") DrugDiagnosisAlc += f1022 + ", ";
                if (f1023 != "") DrugDiagnosisAlc += f1023 + ", ";
                if (f1024 != "") DrugDiagnosisAlc += f1024 + ", ";
                if (f1025 != "") DrugDiagnosisAlc += f1025 + ", ";
                if (f1026 != "") DrugDiagnosisAlc += f1026 + ", ";
                if (f1031 != "") DrugDiagnosisAlc += f1031 + ", ";
                if (f1040 != "") DrugDiagnosisAlc += f1040 + ", ";
                if (f1041 != "") DrugDiagnosisAlc += f1041 + ", ";
                if (f1045 != "") DrugDiagnosisAlc += f1045 + ", ";
                if (f105 != "") DrugDiagnosisAlc += f105 + ", ";
                if (f1051 != "") DrugDiagnosisAlc += f1051 + ", ";
                if (f1052 != "") DrugDiagnosisAlc += f1052 + ", ";
                if (f1053 != "") DrugDiagnosisAlc += f1053 + ", ";
                if (f1054 != "") DrugDiagnosisAlc += f1054 + ", ";
                if (f1055 != "") DrugDiagnosisAlc += f1055 + ", ";
                if (f1056 != "") DrugDiagnosisAlc += f1056 + ", ";
                if (f106 != "") DrugDiagnosisAlc += f106 + ", ";
                if (f1071 != "") DrugDiagnosisAlc += f1071 + ", ";
                if (f1073 != "") DrugDiagnosisAlc += f1073 + ", ";
                if (f109 != "") DrugDiagnosisAlc += f109 + ", ";
                if (f1003 != "") DrugDiagnosisAlc += f1003 + ", ";
                if (f1006 != "") DrugDiagnosisAlc += f1006 + ", ";

                //Стаж злоупотребления 
                string experienceAbuse = ExperienceAbuse.Text;


                //Алкогольные напитки 
                string AlcoholicDrinks = "";
                if (vodka == true) AlcoholicDrinks += "Водка. ";
                if (wine == true) AlcoholicDrinks += "Вино. ";
                if (beer == true) AlcoholicDrinks += "Пиво. ";
                if (surrogates == true) AlcoholicDrinks += "Суррогаты. ";
                if (moonshine == true) AlcoholicDrinks += "Самогон. ";
                if (alcoholContainingDrugs == true) AlcoholicDrinks += "Cпиртосодержащие лекарственные препараты. ";
                if (notSpecified == true) AlcoholicDrinks += "Не уточнено";
                if (otherAlco == true) AlcoholicDrinks += "Разное. ";


                //Интранозологическая коморбидность
                string IntranozologicalComorbidity = "";
                if (fattyHepatosis == true) IntranozologicalComorbidity += "Жировой гепатоз. ";
                if (alcHepatosis == true) IntranozologicalComorbidity += "Алк. гепатит. ";
                if (alcCirrhosis == true) IntranozologicalComorbidity += "Алк. цирроз. ";
                if (alcPancreatitis == true) IntranozologicalComorbidity += "Алк. панкреатит. ";
                if (alcCardiomyopathy == true) IntranozologicalComorbidity += "Алк. кардиомиопатия. ";
                if (alcPolyneuropathy == true) IntranozologicalComorbidity += "Алк. полинейропатия. ";
                if (alcEncephalopathy == true) IntranozologicalComorbidity += "Алк. энцефалопатия. ";
                if (alcEpilepsy == true) IntranozologicalComorbidity += "Алк. эпилепсия. ";
                if (chronicalBronchitis == true) IntranozologicalComorbidity += "Хронический бронхит (условно). ";
                if (alcNotSpecified == true) IntranozologicalComorbidity += "Не уточнено. ";

                int aa = 0;
                if (dataOfRegistration != "")
                {
                    try
                    {
                        string[] mas = data.Split('.', ',', '/');
                        string[] mas1 = dataOfRegistration.Split('.', ',', '/');
                        int a = Convert.ToInt32(mas[2]);
                        int b = Convert.ToInt32(mas1[2]);
                        aa = b - a;
                    }
                    catch (Exception)
                    {
                        Date.BorderThickness = new Thickness(3);
                        DataOfRegistration.BorderThickness = new Thickness(3);
                        Date.BorderBrush = Brushes.Red;
                        DataOfRegistration.BorderBrush = Brushes.Red;
                        check = false;
                    }
                }
                else if (reRegistrationData != "")
                {
                    try
                    {
                        string[] mas = data.Split('.', ',', '/');
                        string[] mas1 = reRegistrationData.Split('.', ',', '/');
                        int a = Convert.ToInt32(mas[2]);
                        int b = Convert.ToInt32(mas1[2]);
                        aa = b - a;
                    }
                    catch (Exception)
                    {
                        Date.BorderThickness = new Thickness(3);
                        ReRegistrationData.BorderThickness = new Thickness(3);
                        Date.BorderBrush = Brushes.Red;
                        ReRegistrationData.BorderBrush = Brushes.Red;
                        check = false;
                    }
                }

                AgeOfRegistration.Text = Convert.ToString(aa);
                string ageOfRegistration = AgeOfRegistration.Text;

                int ab = 0;
                if (dateOfDead != "")
                {
                    try
                    {
                        string[] mas = data.Split('.', ',', '/');
                        string[] mas1 = dateOfDead.Split('.', ',', '/' , '(');
                        int a = Convert.ToInt32(mas[2]);
                        int b = Convert.ToInt32(mas1[2]);
                        ab = b - a;
                    }
                    catch (Exception)
                    {
                        Date.BorderThickness = new Thickness(3);
                        DateOfDead.BorderThickness = new Thickness(3);
                        Date.BorderBrush = Brushes.Red;
                        DateOfDead.BorderBrush = Brushes.Red;
                        check = false;
                    }
                }

                string dataInfo = DataInfo.Text;
              
                AgeOfDead.Text = Convert.ToString(ab);
                string ageOfDead = AgeOfDead.Text;

                if (check == true)
                {
                    // Отправляем инфу на дальнейшую обработку 

                    DbContexte.Entity.Patient_Сreation_Alco(fio, sex, data, regionCenterBLR, raenCenterBLR, life, age, familyStatus, costOfKids,
                        familyComposition, education, profession, theSkillLevelOfTheProfession, addressOfRegistration,
                        addressAtTheTimeOfDeath, dataOfRegistration, reRegistrationData, typeOfRegistration, heredity,
                        disabilityGroup, disabilityStatus, reasonForDisability, SocialStatus, admOtv, ugOtv,
                        dlitMLS, statja107, statUKRB, rodPrav, nomLTP, LTPkol, hosp, EK, dateOfDeregistration,
                        dateOfDead, placeOfDead, deathCertificate, causeOfDeat, deathCategory, openingPlace, historyOfParasucicides,
                        featuresOfObservation, DrugDiagnosisAlc, experienceAbuse, AlcoholicDrinks, IntranozologicalComorbidity, ageOfDead,
                        ageOfRegistration, dataInfo);
                    Close();
                }
                else
                {
                    MessageBox.Show("Не все данные введены");
                    return;
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// Другие больницы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OtherHosp_Click(object sender, RoutedEventArgs e)
        {
            OtherHosp otherHosp = new OtherHosp
            {
                Owner = this
            };
            otherHosp.Show();
        }

        //-------------------------------------------------------------------------------------------
        // checkbox 
        //-------------------------------------------------------------------------------------------
        
        //Интранозологическая коморбидность
        private void FattyHepatosis_Checked(object sender, RoutedEventArgs e)
        {
            fattyHepatosis = true;
        }
        private void FattyHepatosis_UnChecked(object sender, RoutedEventArgs e)
        {
            fattyHepatosis = false;
        }

        private void AlcHepatitis_Checked(object sender, RoutedEventArgs e)
        {
            alcHepatosis = true;
        }
        private void AlcHepatitis_UnChecked(object sender, RoutedEventArgs e)
        {
            alcHepatosis = false;
        }

        private void AlcCirrhosis_Checked(object sender, RoutedEventArgs e)
        {
            alcCirrhosis = true;
        }
        private void AlcCirrhosis_UnChecked(object sender, RoutedEventArgs e)
        {
            alcCirrhosis = false;
        }

        private void AlcPancreatitis_Checked(object sender, RoutedEventArgs e)
        {
            alcPancreatitis = true;
        }
        private void AlcPancreatitis_UnChecked(object sender, RoutedEventArgs e)
        {
            alcPancreatitis = false;
        }

        private void AlcCardiomyopathy_Checked(object sender, RoutedEventArgs e)
        {
            alcCardiomyopathy = true;
        }
        private void AlcCardiomyopathy_UnChecked(object sender, RoutedEventArgs e)
        {
            alcCardiomyopathy = false;
        }

        private void AlcPolyneuropathy_Checked(object sender, RoutedEventArgs e)
        {
            alcPolyneuropathy = true;
        }
        private void AlcPolyneuropathy_UnChecked(object sender, RoutedEventArgs e)
        {
            alcPolyneuropathy = false;
        }

        private void AlcEncephalopathy_Checked(object sender, RoutedEventArgs e)
        {
            alcEncephalopathy = true;
        }
        private void AlcEncephalopathy_UnChecked(object sender, RoutedEventArgs e)
        {
            alcEncephalopathy = false;
        }

        private void AlcEpilepsy_Checked(object sender, RoutedEventArgs e)
        {
            alcEpilepsy = true;
        }
        private void AlcEpilepsy_UnChecked(object sender, RoutedEventArgs e)
        {
            alcEpilepsy = false;
        }

        private void ChronicalBronchitis_Checked(object sender, RoutedEventArgs e)
        {
            chronicalBronchitis = true;
        }
        private void ChronicalBronchitis_UnChecked(object sender, RoutedEventArgs e)
        {
            chronicalBronchitis = false;
        }

        private void AlcNotSpecified_Checked(object sender, RoutedEventArgs e)
        {
            alcNotSpecified = true;
        }
        private void AlcNotSpecified_UnChecked(object sender, RoutedEventArgs e)
        {
            alcNotSpecified = false;
        }


        // Алкогольные напитки
        private void Vodka_Checked(object sender, RoutedEventArgs e)
        {
            vodka = true;
        }
        private void Vodka_UnChecked(object sender, RoutedEventArgs e)
        {
            vodka = false;
        }

        private void Wine_Checked(object sender, RoutedEventArgs e)
        {
            wine = true;
        }
        private void Wine_UnChecked(object sender, RoutedEventArgs e)
        {
            wine = false;
        }

        private void Beer_Checked(object sender, RoutedEventArgs e)
        {
            beer = true;
        }
        private void Beer_UnChecked(object sender, RoutedEventArgs e)
        {
            beer = false;
        }

        private void Surrogates_Checked(object sender, RoutedEventArgs e)
        {
            surrogates = true;
        }
        private void Surrogates_UnChecked(object sender, RoutedEventArgs e)
        {
            surrogates = false;
        }

        private void Moonshine_Checked(object sender, RoutedEventArgs e)
        {
            moonshine = true;
        }
        private void Moonshine_UnChecked(object sender, RoutedEventArgs e)
        {
            moonshine = false;
        }

        private void NotSpecified_Checked(object sender, RoutedEventArgs e)
        {
            notSpecified = true;
        }
        private void NotSpecified_UnChecked(object sender, RoutedEventArgs e)
        {
            notSpecified = false;
        }

        private void AlcoholContainingDrugs_Checked(object sender, RoutedEventArgs e)
        {
            alcoholContainingDrugs = true;
        }
        private void AlcoholContainingDrugs_UnChecked(object sender, RoutedEventArgs e)
        {
            alcoholContainingDrugs = false;
        }

        /// <summary>
        /// Наркодиагноз
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void F101I_Checked(object sender, RoutedEventArgs e)
        {
            f101I = true;
        }
        private void F101I_UnChecked(object sender, RoutedEventArgs e)
        {
            f101I = false;
        }

        private void F101II_Checked(object sender, RoutedEventArgs e)
        {
            f101II = true;
        }
        private void F101II_UnChecked(object sender, RoutedEventArgs e)
        {
            f101II = false;
        }

        private void F101III_Checked(object sender, RoutedEventArgs e)
        {
            f101III = true;
        }
        private void F101III_UnChecked(object sender, RoutedEventArgs e)
        {
            f101III = false;
        }

        private void F1020I_Checked(object sender, RoutedEventArgs e)
        {
            f1020I = true;
        }
        private void F1020I_UnChecked(object sender, RoutedEventArgs e)
        {
            f1020I = false;
        }

        private void F1020II_Checked(object sender, RoutedEventArgs e)
        {
            f1020II = true;
        }
        private void F1020II_UnChecked(object sender, RoutedEventArgs e)
        {
            f1020II = false;
        }

        private void F1020III_Checked(object sender, RoutedEventArgs e)
        {
            f1020III = true;
        }
        private void F1020III_UnChecked(object sender, RoutedEventArgs e)
        {
            f1020III = false;
        }

        private void F1021I_Checked(object sender, RoutedEventArgs e)
        {
            f1021I = true;
        }
        private void F1021I_UnChecked(object sender, RoutedEventArgs e)
        {
            f1021I = false;
        }

        private void F1021II_Checked(object sender, RoutedEventArgs e)
        {
            f1021II = true;
        }
        private void F1021II_UnChecked(object sender, RoutedEventArgs e)
        {
            f1021II = false;
        }

        private void F1021III_Checked(object sender, RoutedEventArgs e)
        {
            f1021III = true;
        }
        private void F1021III_UnChecked(object sender, RoutedEventArgs e)
        {
            f1021III = false;
        }

        private void F1022I_Checked(object sender, RoutedEventArgs e)
        {
            f1022I = true;
        }
        private void F1022I_UnChecked(object sender, RoutedEventArgs e)
        {
            f1022I = false;
        }

        private void F1022II_Checked(object sender, RoutedEventArgs e)
        {
            f1022II = true;
        }
        private void F1022II_UnChecked(object sender, RoutedEventArgs e)
        {
            f1022II = false;
        }

        private void F1022III_Checked(object sender, RoutedEventArgs e)
        {
            f1022III = true;
        }
        private void F1022III_UnChecked(object sender, RoutedEventArgs e)
        {
            f1022III = false;
        }

        private void F1023I_Checked(object sender, RoutedEventArgs e)
        {
            f1023I = true;
        }
        private void F1023I_UnChecked(object sender, RoutedEventArgs e)
        {
            f1023I = false;
        }

        private void F1023II_Checked(object sender, RoutedEventArgs e)
        {
            f1023II = true;
        }
        private void F1023II_UnChecked(object sender, RoutedEventArgs e)
        {
            f1023II = false;
        }

        private void F1023III_Checked(object sender, RoutedEventArgs e)
        {
            f1023III = true;
        }
        private void F1023III_UnChecked(object sender, RoutedEventArgs e)
        {
            f1023III = false;
        }

        private void F1024I_Checked(object sender, RoutedEventArgs e)
        {
            f1024I = true;
        }
        private void F1024I_UnChecked(object sender, RoutedEventArgs e)
        {
            f1024I = false; 
        }

        private void F1024II_Checked(object sender, RoutedEventArgs e)
        {
            f1024II = true;
        }
        private void F1024II_UnChecked(object sender, RoutedEventArgs e)
        {
            f1024II = false;
        }

        private void F1024III_Checked(object sender, RoutedEventArgs e)
        {
            f1024III = true;
        }
        private void F1024III_UnChecked(object sender, RoutedEventArgs e)
        {
            f1024III = false;
        }

        private void F1025I_Checked(object sender, RoutedEventArgs e)
        {
            f1025I = true;
        }
        private void F1025I_UnChecked(object sender, RoutedEventArgs e)
        {
            f1025I = false;
        }

        private void F1025II_Checked(object sender, RoutedEventArgs e)
        {
            f1025II = true;
        }
        private void F1025II_UnChecked(object sender, RoutedEventArgs e)
        {
            f1025II = false;
        }

        private void F1025III_Checked(object sender, RoutedEventArgs e)
        {
            f1025III = true;
        }
        private void F1025III_UnChecked(object sender, RoutedEventArgs e)
        {
            f1025III = false;
        }

        private void F1026I_Checked(object sender, RoutedEventArgs e)
        {
            f1026I = true;
        }
        private void F1026I_UnChecked(object sender, RoutedEventArgs e)
        {
            f1026I = false;
        }

        private void F1026II_Checked(object sender, RoutedEventArgs e)
        {
            f1026II = true;
        }
        private void F1026II_UnChecked(object sender, RoutedEventArgs e)
        {
            f1026II = false;
        }

        private void F1026III_Checked(object sender, RoutedEventArgs e)
        {
            f1026III = true;
        }
        private void F1026III_UnChecked(object sender, RoutedEventArgs e)
        {
            f1026III = false;
        }

        private void F1031I_Checked(object sender, RoutedEventArgs e)
        {
            f1031I = true;
        }
        private void F1031I_UnChecked(object sender, RoutedEventArgs e)
        {
            f1031I = false;
        }

        private void F1031II_Checked(object sender, RoutedEventArgs e)
        {
            f1031II = true;
        }
        private void F1031II_UnChecked(object sender, RoutedEventArgs e)
        {
            f1031II = false;
        }

        private void F1031III_Checked(object sender, RoutedEventArgs e)
        {
            f1031III = true;
        }
        private void F1031III_UnChecked(object sender, RoutedEventArgs e)
        {
            f1031III = false;
        }

        private void F1040I_Checked(object sender, RoutedEventArgs e)
        {
            f1040I = true;
        }
        private void F1040I_UnChecked(object sender, RoutedEventArgs e)
        {
            f1040I = false;
        }

        private void F1040II_Checked(object sender, RoutedEventArgs e)
        {
            f1040II = true;
        }
        private void F1040II_UnChecked(object sender, RoutedEventArgs e)
        {
            f1040II = false;
        }

        private void F1040III_Checked(object sender, RoutedEventArgs e)
        {
            f1040III = true;
        }
        private void F1040III_UnChecked(object sender, RoutedEventArgs e)
        {
            f1040III = false;
        }

        private void F1041I_Checked(object sender, RoutedEventArgs e)
        {
            f1041I = true;
        }
        private void F1041I_UnChecked(object sender, RoutedEventArgs e)
        {
            f1041I = false;
        }

        private void F1041II_Checked(object sender, RoutedEventArgs e)
        {
            f1041II = true;
        }
        private void F1041II_UnChecked(object sender, RoutedEventArgs e)
        {
            f1041II = false;
        }

        private void F1041III_Checked(object sender, RoutedEventArgs e)
        {
            f1041III = true;
        }
        private void F1041III_UnChecked(object sender, RoutedEventArgs e)
        {
            f1041III = false;
        }

        private void F1045I_Checked(object sender, RoutedEventArgs e)
        {
            f1045I = true;
        }
        private void F1045I_UnChecked(object sender, RoutedEventArgs e)
        {
            f1045I = false;
        }

        private void F1045II_Checked(object sender, RoutedEventArgs e)
        {
            f1045II = true;
        }
        private void F1045II_UnChecked(object sender, RoutedEventArgs e)
        {
            f1045II = false;
        }

        private void F1045III_Checked(object sender, RoutedEventArgs e)
        {
            f1045III = true;
        }
        private void F1045III_UnChecked(object sender, RoutedEventArgs e)
        {
            f1045III = false;
        }

        private void F105I_Checked(object sender, RoutedEventArgs e)
        {
            f105I = true;
        }
        private void F105I_UnChecked(object sender, RoutedEventArgs e)
        {
            f105I = false;
        }

        private void F105II_Checked(object sender, RoutedEventArgs e)
        {
            f105II = true;
        }
        private void F105II_UnChecked(object sender, RoutedEventArgs e)
        {
            f105II = false;
        }

        private void F105III_Checked(object sender, RoutedEventArgs e)
        {
            f105III = true;
        }
        private void F105III_UnChecked(object sender, RoutedEventArgs e)
        {
            f105III = false;
        }

        private void F1050I_Checked(object sender, RoutedEventArgs e)
        {
            f1050I = true;
        }
        private void F1050I_UnChecked(object sender, RoutedEventArgs e)
        {
            f1050I = false;
        }

        private void F1050II_Checked(object sender, RoutedEventArgs e)
        {
            f1050II = true;
        }
        private void F1050II_UnChecked(object sender, RoutedEventArgs e)
        {
            f1050II = false;
        }

        private void F1050III_Checked(object sender, RoutedEventArgs e)
        {
            f1050III = true;
        }
        private void F1050III_UnChecked(object sender, RoutedEventArgs e)
        {
            f1050III = false;
        }

        private void F1051I_Checked(object sender, RoutedEventArgs e)
        {
            f1051I = true;
        }
        private void F1051I_UnChecked(object sender, RoutedEventArgs e)
        {
            f1051I = false;
        }

        private void F1051II_Checked(object sender, RoutedEventArgs e)
        {
            f1051II = true;
        }
        private void F1051II_UnChecked(object sender, RoutedEventArgs e)
        {
            f1051II = false;
        }

        private void F1051III_Checked(object sender, RoutedEventArgs e)
        {
            f1051III = true;
        }
        private void F1051III_UnChecked(object sender, RoutedEventArgs e)
        {
            f1051III = false;
        }

        private void F1052I_Checked(object sender, RoutedEventArgs e)
        {
            f1052I = true;
        }
        private void F1052I_UnChecked(object sender, RoutedEventArgs e)
        {
            f1052I = false;
        }

        private void F1052II_Checked(object sender, RoutedEventArgs e)
        {
            f1052II = true;
        }
        private void F1052II_UnChecked(object sender, RoutedEventArgs e)
        {
            f1052II = false;
        }

        private void F1052III_Checked(object sender, RoutedEventArgs e)
        {
            f1052III = true;
        }
        private void F1052III_UnChecked(object sender, RoutedEventArgs e)
        {
            f1052III = false;
        }

        private void F1053I_Checked(object sender, RoutedEventArgs e)
        {
            f1053I = true;
        }
        private void F1053I_UnChecked(object sender, RoutedEventArgs e)
        {
            f1053I = false;
        }

        private void F1053II_Checked(object sender, RoutedEventArgs e)
        {
            f1053II = true;
        }
        private void F1053II_UnChecked(object sender, RoutedEventArgs e)
        {
            f1053II = false;
        }

        private void F1053III_Checked(object sender, RoutedEventArgs e)
        {
            f1053III = true;
        }
        private void F1053III_UnChecked(object sender, RoutedEventArgs e)
        {
            f1053III = false;
        }

        private void F1054I_Checked(object sender, RoutedEventArgs e)
        {
            f1054I = true;
        }
        private void F1054I_UnChecked(object sender, RoutedEventArgs e)
        {
            f1054I = false;
        }

        private void F1054II_Checked(object sender, RoutedEventArgs e)
        {
            f1054II = true;
        }
        private void F1054II_UnChecked(object sender, RoutedEventArgs e)
        {
            f1054II = false;
        }

        private void F1054III_Checked(object sender, RoutedEventArgs e)
        {
            f1054III = true;
        }
        private void F1054III_UnChecked(object sender, RoutedEventArgs e)
        {
            f1054III = false;
        }

        private void F1055I_Checked(object sender, RoutedEventArgs e)
        {
            f1055I = true;
        }
        private void F1055I_UnChecked(object sender, RoutedEventArgs e)
        {
            f1055I = false;
        }

        private void F1055II_Checked(object sender, RoutedEventArgs e)
        {
            f1055II = true;
        }
        private void F1055II_UnChecked(object sender, RoutedEventArgs e)
        {
            f1055II = false;
        }

        private void F1055III_Checked(object sender, RoutedEventArgs e)
        {
            f1055III = true;
        }
        private void F1055III_UnChecked(object sender, RoutedEventArgs e)
        {
            f1055III = false;
        }

        private void F1056I_Checked(object sender, RoutedEventArgs e)
        {
            f1056I = true;
        }
        private void F1056I_UnChecked(object sender, RoutedEventArgs e)
        {
            f1056I = false;
        }

        private void F1056II_Checked(object sender, RoutedEventArgs e)
        {
            f1056II = true;
        }
        private void F1056II_UnChecked(object sender, RoutedEventArgs e)
        {
            f1056II = false;
        }

        private void F1056III_Checked(object sender, RoutedEventArgs e)
        {
            f1056III = true;
        }
        private void F1056III_UnChecked(object sender, RoutedEventArgs e)
        {
            f1056III = false;
        }

        private void F106I_Checked(object sender, RoutedEventArgs e)
        {
            f106I = true;
        }
        private void F106I_UnChecked(object sender, RoutedEventArgs e)
        {
            f106I = false;
        }

        private void F106II_Checked(object sender, RoutedEventArgs e)
        {
            f106II = true;
        }
        private void F106II_UnChecked(object sender, RoutedEventArgs e)
        {
            f106II = false;
        }

        private void F106III_Checked(object sender, RoutedEventArgs e)
        {
            f106III = true;
        }
        private void F106III_UnChecked(object sender, RoutedEventArgs e)
        {
            f106III = false;
        }

        private void F1071I_Checked(object sender, RoutedEventArgs e)
        {
            f1071I = true;
        }
        private void F1071I_UnChecked(object sender, RoutedEventArgs e)
        {
            f1071I = false;
        }

        private void F1071II_Checked(object sender, RoutedEventArgs e)
        {
            f1071II = true;
        }
        private void F1071II_UnChecked(object sender, RoutedEventArgs e)
        {
            f1071II = false;
        }

        private void F1071III_Checked(object sender, RoutedEventArgs e)
        {
            f1071III = true;
        }
        private void F1071III_UnChecked(object sender, RoutedEventArgs e)
        {
            f1071III = false;
        }

        private void F1073I_Checked(object sender, RoutedEventArgs e)
        {
            f1073I = true;
        }
        private void F1073I_UnChecked(object sender, RoutedEventArgs e)
        {
            f1073I = false;
        }

        private void F1073II_Checked(object sender, RoutedEventArgs e)
        {
            f1073II = true;
        }
        private void F1073II_UnChecked(object sender, RoutedEventArgs e)
        {
            f1073II = false;
        }

        private void F1073III_Checked(object sender, RoutedEventArgs e)
        {
            f1073III = true;
        }
        private void F1073III_UnChecked(object sender, RoutedEventArgs e)
        {
            f1073III = false;
        }

        private void F109I_Checked(object sender, RoutedEventArgs e)
        {
            f109I = true;
        }
        private void F109I_UnChecked(object sender, RoutedEventArgs e)
        {
            f109I = false;
        }

        private void F109II_Checked(object sender, RoutedEventArgs e)
        {
            f109II = true;
        }
        private void F109II_UnChecked(object sender, RoutedEventArgs e)
        {
            f109II = false;
        }

        private void F109III_Checked(object sender, RoutedEventArgs e)
        {
            f109III = true;
        }
        private void F109III_UnChecked(object sender, RoutedEventArgs e)
        {
            f109III = false;
        }

        private void F1003I_Checked(object sender, RoutedEventArgs e)
        {
            f1003I = true;
        }
        private void F1003I_UnChecked(object sender, RoutedEventArgs e)
        {
            f1003I = false;
        }

        private void F1003II_Checked(object sender, RoutedEventArgs e)
        {
            f1003II = true;
        }
        private void F1003II_UnChecked(object sender, RoutedEventArgs e)
        {
            f1003II = false;
        }

        private void F1003III_Checked(object sender, RoutedEventArgs e)
        {
            f1003III = true;
        }
        private void F1003III_UnChecked(object sender, RoutedEventArgs e)
        {
            f1003III = false;
        }

        private void F1006I_Checked(object sender, RoutedEventArgs e)
        {
            f1006I = true;
        }
        private void F1006I_UnChecked(object sender, RoutedEventArgs e)
        {
            f1006I = false;
        }

        private void F1006II_Checked(object sender, RoutedEventArgs e)
        {
            f1006II = true;
        }
        private void F1006II_UnChecked(object sender, RoutedEventArgs e)
        {
            f1006II = false;
        }

        private void F1006III_Checked(object sender, RoutedEventArgs e)
        {
            f1006III = true;
        }
        private void F1006III_UnChecked(object sender, RoutedEventArgs e)
        {
            f1006III = false;
        }


        /// <summary>
        ///  Парасуициды в анамнезе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HistoryOfParasucicides_Checked(object sender, RoutedEventArgs e)
        {
            historyOfParasucicide = true;
        }
        private void HistoryOfParasucicides_UnChecked(object sender, RoutedEventArgs e)
        {
            historyOfParasucicide = false;
        }


        /// <summary>
        /// ЧМТ 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CHMT_Checked(object sender, RoutedEventArgs e)
        {
            chmt = true;
        }
        private void CHMT_UnChecked(object sender, RoutedEventArgs e)
        {
            chmt = false;
        }

        /// <summary>
        /// ЧМТ множ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CHMTMultiple_Checked(object sender, RoutedEventArgs e)
        {
            chmtMulti = true;
        }
        private void CHMTMultiple_UnChecked(object sender, RoutedEventArgs e)
        {
            chmtMulti = false;
        }

        /// <summary>
        /// Перелом костей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoneАracture_Checked(object sender, RoutedEventArgs e)
        {
            boneAracture = true;
        }
        private void BoneАracture_UnChecked(object sender, RoutedEventArgs e)
        {
            boneAracture = false;
        }

        /// <summary>
        /// Перелом костей множ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoneАractureMultiple_Checked(object sender, RoutedEventArgs e)
        {
            boneAractureMulti = true;
        }
        private void BoneАractureMultiple_UnChecked(object sender, RoutedEventArgs e)
        {
            boneAractureMulti = false;
        }

        /// <summary>
        /// Ранение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Wound_Checked(object sender, RoutedEventArgs e)
        {
            wound = true;
        }
        private void Wound_UnChecked(object sender, RoutedEventArgs e)
        {
            wound = false;
        }

        /// <summary>
        /// Туберкулез
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tuberculosis_Checked(object sender, RoutedEventArgs e)
        {
            tuberculosis = true;
        }
        private void Tuberculosis_UnChecked(object sender, RoutedEventArgs e)
        {
            tuberculosis = false;
        }

        /// <summary>
        /// Гепатит Б
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HepatitisB_Checked(object sender, RoutedEventArgs e)
        {
            hepatitisB = true;
        }
        private void HepatitisB_UnChecked(object sender, RoutedEventArgs e)
        {
            hepatitisB = false;
        }
        
        /// <summary>
        /// Гепатит С
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HepatitisC_Checked(object sender, RoutedEventArgs e)
        {
            hepatitisC = true;
        }
        private void HepatitisC_UnChecked(object sender, RoutedEventArgs e)
        {
            hepatitisC = false;
        }

        /// <summary>
        /// вич
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HIV_Checked(object sender, RoutedEventArgs e)
        {
            hiv = true;
        }
        private void HIV_UnChecked(object sender, RoutedEventArgs e)
        {
            hiv = false;
        }


        /// <summary>
        /// Не уточнено
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotSpecifiedEksta_Checked(object sender, RoutedEventArgs e)
        {
            notSpecifiedEksta = true;
        }
        private void NotSpecifiedEksta_UnChecked(object sender, RoutedEventArgs e)
        {
            notSpecifiedEksta = false;
        }

        /// <summary>
        ///  проверка CheckBox Больница ГКНД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HostGKND_Checked(object sender, RoutedEventArgs e)
        {
            GKND = true;
        }
        private void HostGKND_UnChecked(object sender, RoutedEventArgs e)
        {
            GKND = false;
        }

        /// <summary>
        /// проверка CheckBox Больница РКПБ 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HospRKPB_Checked(object sender, RoutedEventArgs e)
        {
            RKPB = true;
        }
        private void HospRKPB_UnChecked(object sender, RoutedEventArgs e)
        {
            RKPB = false;
        }

        /// <summary>
        /// проверка CheckBox Больница БСМП
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HospBSMP_Checked(object sender, RoutedEventArgs e)
        {
            BSMP = true;
        }
        private void HospBSMP_UnChecked(object sender, RoutedEventArgs e)
        {
            BSMP = false;
        }

        /// <summary>
        /// проверка CheckBox Больница Другая
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HospOther_Checked(object sender, RoutedEventArgs e)
        {
            hospitOther = true;
        }
        private void HospOther_UnChecked(object sender, RoutedEventArgs e)
        {
            hospitOther = false;
        }


        /// <summary>
        /// проверяет вкл или выкл CheckBox "Родительские права" в адм и угл ответственности
        /// </summary>
        private void RodPrav_Checked(object sender, RoutedEventArgs e)
        {
            rodprav = true;
        }
        private void RodPrav_UnChecked (object sender, RoutedEventArgs e)
        {
            rodprav = false;
        }

        /// <summary>
        /// проверяет вкл или выкл CheckBox "Статья 107" в адм и угл ответственности
        /// </summary>
        private void Sta107_Checked(object sender, RoutedEventArgs e)
        {
            stat107 = true;
        }
        private void Sta107_UnChecked(object sender, RoutedEventArgs e)
        {
            stat107 = false;
        }


        /// <summary>
        /// проверяет вкл или выкл CheckBox "Работает" coциально - экономический статус 
        /// </summary>
        private void WorksStatus_Checked(object sender, RoutedEventArgs e)
        {
            worksStatus = true;
        }
        private void WorksStatus_UnChecked(object sender, RoutedEventArgs e)
        {
            worksStatus = false;
        }

        /// <summary>
        /// проверяет вкл или выкл CheckBox "Работает эпизодически" coциально - экономический статус 
        /// </summary>
        private void WorksStatus_Checked2(object sender, RoutedEventArgs e)
        {
            worksStatus2 = true;
        }
        private void WorksStatus_UnChecked2(object sender, RoutedEventArgs e)
        {
            worksStatus2 = false;
        }

        /// <summary>
        /// проверяет вкл или выкл CheckBox "Не работает." coциально - экономический статус 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorksStatus_Checked3(object sender, RoutedEventArgs e)
        {
            worksStatus3 = true;
        }
        private void WorksStatus_UnChecked3(object sender, RoutedEventArgs e)
        {
            worksStatus3 = false;
        }

        /// <summary>
        /// проверяет вкл или выкл CheckBox "Работающая пенс" coциально - экономический статус 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorksStatus_Checked4(object sender, RoutedEventArgs e)
        {
            worksStatus4 = true;
        }
        private void WorksStatus_UnChecked4(object sender, RoutedEventArgs e)
        {
            worksStatus4 = false;
        }

        /// <summary>
        /// проверяет вкл или выкл CheckBox "не работающийц пенс" coциально - экономический статус 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorksStatus_Checked5(object sender, RoutedEventArgs e)
        {
            worksStatus5 = true;
        }
        private void WorksStatus_UnChecked5(object sender, RoutedEventArgs e)
        {
            worksStatus5 = false;
        }

        /// <summary>
        /// проверяет вкл или выкл CheckBox "не уточнено" coциально - экономический статус 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorksStatus_Checked6(object sender, RoutedEventArgs e)
        {
            worksStatus6 = true;
        }
        private void WorksStatus_UnChecked6(object sender, RoutedEventArgs e)
        {
            worksStatus6 = false;
        }

        private void OrintirDead_Checked(object sender, RoutedEventArgs e)
        {
            orintirDead = true;
        }
        private void OrintirDead_UnChecked(object sender, RoutedEventArgs e)
        {
            orintirDead = false;
        }

        private void JazvaZeludka_Checked(object sender, RoutedEventArgs e)
        {
            jazvaZeludka = true;
        }
        private void JazvaZeludka_UnChecked(object sender, RoutedEventArgs e)
        {
            jazvaZeludka = false;
        }

        private void JazvaDPK_Checked(object sender, RoutedEventArgs e)
        {
            jazvaDPK = true;
        }
        private void JazvaDPK_UnChecked(object sender, RoutedEventArgs e)
        {
            jazvaDPK = false;
        }

        private void OtherAlco_Checked(object sender, RoutedEventArgs e)
        {
            otherAlco = true;
        }
        private void OtherAlco_UnChecked(object sender, RoutedEventArgs e)
        {
            otherAlco = false;
        }
    }
}
