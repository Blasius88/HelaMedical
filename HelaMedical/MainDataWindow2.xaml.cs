using System;
using System.Windows;
using HelaMedical.Class;
using System.Windows.Media;
using HelaMedical.Excep;
using HelaMedical.DbContexte;

namespace HelaMedical
{
    /// <summary>
    /// Логика взаимодействия для MainDataWindow2.xaml
    /// </summary>
    public partial class MainDataWindow2 : Window
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
         private bool hiv = false;
         private bool jazvaZeludka = false;
         private bool jazvaDPK = false;
         private bool notSpecifiedEksta = false;

         private bool historyOfParasucicide = false;

         private bool opiodF1x1 = false;
         private bool opiodF1x20 = false;
         private bool opiodF1x21 = false;
         private bool opiodF1x22 = false;
         private bool opiodF1x23 = false;
         private bool opiodF1x24 = false;
         private bool opiodF1x25 = false;
         private bool opiodF1x26 = false;
         private bool opiodF1x31 = false;
         private bool opiodF1x40 = false;
         private bool opiodF1x41 = false;
         private bool opiodF1x5 = false;
         private bool opiodF1x51 = false;
         private bool opiodF1x52 = false;
         private bool opiodF1x53 = false;
         private bool opiodF1x54 = false;
         private bool opiodF1x55 = false;
         private bool opiodF1x56 = false;
         private bool opiodF1x71 = false;
         private bool opiodF1x73 = false;
         private bool opiodF1x9 = false;
         private bool opiodF1x03 = false;
         private bool opiodF1x04 = false;
         private bool opiodF1x06 = false;

         private bool kanabF1x1 = false;
         private bool kanabF1x20 = false;
         private bool kanabF1x21 = false;
         private bool kanabF1x22 = false;
         private bool kanabF1x23 = false;
         private bool kanabF1x24 = false;
         private bool kanabF1x25 = false;
         private bool kanabF1x26 = false;
         private bool kanabF1x31 = false;
         private bool kanabF1x40 = false;
         private bool kanabF1x41 = false;
         private bool kanabF1x5 = false;
         private bool kanabF1x51 = false;
         private bool kanabF1x52 = false;
         private bool kanabF1x53 = false;
         private bool kanabF1x54 = false;
         private bool kanabF1x55 = false;
         private bool kanabF1x56 = false;
         private bool kanabF1x71 = false;
         private bool kanabF1x73 = false;
         private bool kanabF1x9 = false;
         private bool kanabF1x03 = false;
         private bool kanabF1x04 = false;
         private bool kanabF1x06 = false;

         private bool sedatF1x1 = false;
         private bool sedatF1x20 = false;
         private bool sedatF1x21 = false;
         private bool sedatF1x22 = false;
         private bool sedatF1x23 = false;
         private bool sedatF1x24 = false;
         private bool sedatF1x25 = false;
         private bool sedatF1x26 = false;
         private bool sedatF1x31 = false;
         private bool sedatF1x40 = false;
         private bool sedatF1x41 = false;
         private bool sedatF1x5 = false;
         private bool sedatF1x51 = false;
         private bool sedatF1x52 = false;
         private bool sedatF1x53 = false;
         private bool sedatF1x54 = false;
         private bool sedatF1x55 = false;
         private bool sedatF1x56 = false;
         private bool sedatF1x71 = false;
         private bool sedatF1x73 = false;
         private bool sedatF1x9 = false;
         private bool sedatF1x03 = false;
         private bool sedatF1x04 = false;
         private bool sedatF1x06 = false;

         private bool kokF1x1 = false;
         private bool kokF1x20 = false;
         private bool kokF1x21 = false;
         private bool kokF1x22 = false;
         private bool kokF1x23 = false;
         private bool kokF1x24 = false;
         private bool kokF1x25 = false;
         private bool kokF1x26 = false;
         private bool kokF1x31 = false;
         private bool kokF1x40 = false;
         private bool kokF1x41 = false;
         private bool kokF1x5 = false;
         private bool kokF1x51 = false;
         private bool kokF1x52 = false;
         private bool kokF1x53 = false;
         private bool kokF1x54 = false;
         private bool kokF1x55 = false;
         private bool kokF1x56 = false;
         private bool kokF1x71 = false ;
         private bool kokF1x73 = false;
         private bool kokF1x9 = false;
         private bool kokF1x03 = false;
         private bool kokF1x04 = false;
         private bool kokF1x06= false;

         private bool stimF1x1 = false;
         private bool stimF1x20 = false;
         private bool stimF1x21 = false;
         private bool stimF1x22 = false;
         private bool stimF1x23 = false;
         private bool stimF1x24 = false;
         private bool stimF1x25 = false;
         private bool stimF1x26 = false;
         private bool stimF1x31 = false;
         private bool stimF1x40 = false;
         private bool stimF1x41 = false;
         private bool stimF1x5 = false;
         private bool stimF1x51 = false;
         private bool stimF1x52 = false;
         private bool stimF1x53 = false;
         private bool stimF1x54 = false;
         private bool stimF1x55 = false;
         private bool stimF1x56 = false;
         private bool stimF1x71 = false;
         private bool stimF1x73 = false;
         private bool stimF1x9 = false;
         private bool stimF1x03 = false;
         private bool stimF1x04 = false;
         private bool stimF1x06 = false;

         private bool glukF1x1 = false;
         private bool glukF1x20 = false;
         private bool glukF1x21 = false;
         private bool glukF1x22 = false;
         private bool glukF1x23 = false;
         private bool glukF1x24 = false;
         private bool glukF1x25 = false;
         private bool glukF1x26 = false; 
         private bool glukF1x31 = false;
         private bool glukF1x40 = false;
         private bool glukF1x41 = false;
         private bool glukF1x5 = false;
         private bool glukF1x51 = false;
         private bool glukF1x52 = false;
         private bool glukF1x53 = false;
         private bool glukF1x54 = false;
         private bool glukF1x55 = false;
         private bool glukF1x56 = false;
         private bool glukF1x71 = false;
         private bool glukF1x73 = false;
         private bool glukF1x9 = false;
         private bool glukF1x03 = false;
         private bool glukF1x04 = false;
         private bool glukF1x06 = false;

         private bool rastvorF1x1 = false;
         private bool rastvorF1x20 = false;
         private bool rastvorF1x21 = false;
         private bool rastvorF1x22 = false;
         private bool rastvorF1x23 = false;
         private bool rastvorF1x24 = false;
         private bool rastvorF1x25 = false;
         private bool rastvorF1x26 = false;
         private bool rastvorF1x31 = false;
         private bool rastvorF1x40 = false;
         private bool rastvorF1x41 = false;
         private bool rastvorF1x5 = false;
         private bool rastvorF1x51 = false;
         private bool rastvorF1x52 = false;
         private bool rastvorF1x53 = false;
         private bool rastvorF1x54 = false;
         private bool rastvorF1x55 = false;
         private bool rastvorF1x56 = false;
         private bool rastvorF1x71 = false;
         private bool rastvorF1x73 = false;
         private bool rastvorF1x9 = false;
         private bool rastvorF1x03 = false;
         private bool rastvorF1x04 = false;
         private bool rastvorF1x06 = false;

         private bool comboF1x1 = false;
         private bool comboF1x20 = false;
         private bool comboF1x21 = false;
         private bool comboF1x22 = false;
         private bool comboF1x23 = false;
         private bool comboF1x24 = false;
         private bool comboF1x25 = false;
         private bool comboF1x26 = false;
         private bool comboF1x31 = false;
         private bool comboF1x40 = false;
         private bool comboF1x41 = false;
         private bool comboF1x5 = false;
         private bool comboF1x51 = false;
         private bool comboF1x52 = false;
         private bool comboF1x53 = false;
         private bool comboF1x54 = false;
         private bool comboF1x55 = false;
         private bool comboF1x56 = false;
         private bool comboF1x71 = false;
         private bool comboF1x73 = false;
         private bool comboF1x9 = false;
         private bool comboF1x03 = false;
         private bool comboF1x04 = false;
         private bool comboF1x06 = false;

         private bool thrombophlebitis = false;
         private bool endocarditis = false;
         private bool myocarditis = false;
         private bool meningitis = false;
         private bool sepsis = false;
         private bool orintirDead = false;



        public MainDataWindow2()
        {
            InitializeComponent();
            Bool.NarcoBool = false;
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

        private void ButtonExitStud_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Добавление данных в массив 
        /// </summary>
        private void ButtonAddStud_Click(object sender, RoutedEventArgs e)
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
                else
                {
                    bool flag = MainDataWindow.Data_Check(data);
                    if (!flag)
                    {
                        Date.BorderThickness = new Thickness(3);
                        Date.BorderBrush = Brushes.Red;
                        check = false;

                    }
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
                if (costOfKids == "")
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
                if (education == "")
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
                if (dateOfDead != "")
                {
                    bool flag1 = MainDataWindow.Data_Check(dateOfDead);
                    if (!flag1)
                    {
                        DateOfDead.BorderThickness = new Thickness(3);
                        DateOfDead.BorderBrush = Brushes.Red;
                        check = false;
                    }
                }
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

                // Наркодиагноз х 
                string DrugAddictionX = "";
                if (opiodF1x1 == true) DrugAddictionX += "F11.1.";
                if (opiodF1x20 == true) DrugAddictionX += "F11.20.  ";
                if (opiodF1x21 == true) DrugAddictionX += "F11.21. ";
                if (opiodF1x22 == true) DrugAddictionX += "F11.22. ";
                if (opiodF1x23 == true) DrugAddictionX += "F11.23. ";
                if (opiodF1x24 == true) DrugAddictionX += "F11.24. ";
                if (opiodF1x25 == true) DrugAddictionX += "F11.25. ";
                if (opiodF1x26 == true) DrugAddictionX += "F11.26. ";
                if (opiodF1x31 == true) DrugAddictionX += "F11.31. ";
                if (opiodF1x40 == true) DrugAddictionX += "F11.40. ";
                if (opiodF1x41 == true) DrugAddictionX += "F11.41. ";
                if (opiodF1x5 == true) DrugAddictionX += "F11.5. ";
                if (opiodF1x51 == true) DrugAddictionX += "F11.51. ";
                if (opiodF1x52 == true) DrugAddictionX += "F11.52. ";
                if (opiodF1x53 == true) DrugAddictionX += "F11.53. ";
                if (opiodF1x54 == true) DrugAddictionX += "F11.54. ";
                if (opiodF1x55 == true) DrugAddictionX += "F11.55. ";
                if (opiodF1x56 == true) DrugAddictionX += "F11.56. ";
                if (opiodF1x71 == true) DrugAddictionX += "F11.71. ";
                if (opiodF1x73 == true) DrugAddictionX += "F11.73. ";
                if (opiodF1x9 == true) DrugAddictionX += "F11.9. ";
                if (opiodF1x03 == true) DrugAddictionX += "F11.03. ";
                if (opiodF1x04 == true) DrugAddictionX += "F11.04. ";
                if (opiodF1x06 == true) DrugAddictionX += "F11.06. ";

                if (kanabF1x1 == true) DrugAddictionX += "F12.1. ";
                if (kanabF1x20 == true) DrugAddictionX += "F12.20. ";
                if (kanabF1x21 == true) DrugAddictionX += "F12.21. ";
                if (kanabF1x22 == true) DrugAddictionX += "F12.22. ";
                if (kanabF1x23 == true) DrugAddictionX += "F12.23. ";
                if (kanabF1x24 == true) DrugAddictionX += "F12.24. ";
                if (kanabF1x25 == true) DrugAddictionX += "F12.25. ";
                if (kanabF1x26 == true) DrugAddictionX += "F12.26. ";
                if (kanabF1x31 == true) DrugAddictionX += "F12.31. ";
                if (kanabF1x40 == true) DrugAddictionX += "F12.40. ";
                if (kanabF1x41 == true) DrugAddictionX += "F12.41. ";
                if (kanabF1x5 == true) DrugAddictionX += "F12.5. ";
                if (kanabF1x51 == true) DrugAddictionX += "F12.51. ";
                if (kanabF1x52 == true) DrugAddictionX += "F12.52. ";
                if (kanabF1x53 == true) DrugAddictionX += "F12.53. ";
                if (kanabF1x54 == true) DrugAddictionX += "F12.54. ";
                if (kanabF1x55 == true) DrugAddictionX += "F12.55. ";
                if (kanabF1x56 == true) DrugAddictionX += "F12.56. ";
                if (kanabF1x71 == true) DrugAddictionX += "F12.71. ";
                if (kanabF1x73 == true) DrugAddictionX += "F12.73. ";
                if (kanabF1x9 == true) DrugAddictionX += "F12.9. ";
                if (kanabF1x03 == true) DrugAddictionX += "F12.03. ";
                if (kanabF1x04 == true) DrugAddictionX += "F12.04. ";
                if (kanabF1x06 == true) DrugAddictionX += "F12.06. ";

                if (sedatF1x1 == true) DrugAddictionX += "F13.1. ";
                if (sedatF1x20 == true) DrugAddictionX += "F13.20. ";
                if (sedatF1x21 == true) DrugAddictionX += "F13.21. ";
                if (sedatF1x22 == true) DrugAddictionX += "F13.22. ";
                if (sedatF1x23 == true) DrugAddictionX += "F13.23. ";
                if (sedatF1x24 == true) DrugAddictionX += "F13.24. ";
                if (sedatF1x25 == true) DrugAddictionX += "F13.25. ";
                if (sedatF1x26 == true) DrugAddictionX += "F13.26. ";
                if (sedatF1x31 == true) DrugAddictionX += "F13.31. ";
                if (sedatF1x40 == true) DrugAddictionX += "F13.40. ";
                if (sedatF1x41 == true) DrugAddictionX += "F13.41. ";
                if (sedatF1x5 == true) DrugAddictionX += "F13.5. ";
                if (sedatF1x51 == true) DrugAddictionX += "F13.51. ";
                if (sedatF1x52 == true) DrugAddictionX += "F13.52. ";
                if (sedatF1x53 == true) DrugAddictionX += "F13.53. ";
                if (sedatF1x54 == true) DrugAddictionX += "F13.54. ";
                if (sedatF1x55 == true) DrugAddictionX += "F13.55. ";
                if (sedatF1x56 == true) DrugAddictionX += "F13.56. ";
                if (sedatF1x71 == true) DrugAddictionX += "F13.71. ";
                if (sedatF1x73 == true) DrugAddictionX += "F13.73. ";
                if (sedatF1x9 == true) DrugAddictionX += "F13.9. ";
                if (sedatF1x03 == true) DrugAddictionX += "F13.03. ";
                if (sedatF1x04 == true) DrugAddictionX += "F13.04. ";
                if (sedatF1x06 == true) DrugAddictionX += "F13.06. ";

                if (kokF1x1 == true) DrugAddictionX += "F14.1. ";
                if (kokF1x20 == true) DrugAddictionX += "F14.20. ";
                if (kokF1x21 == true) DrugAddictionX += "F14.21. ";
                if (kokF1x22 == true) DrugAddictionX += "F14.22. ";
                if (kokF1x23 == true) DrugAddictionX += "F14.23. ";
                if (kokF1x24 == true) DrugAddictionX += "F14.24. ";
                if (kokF1x25 == true) DrugAddictionX += "F14.25. ";
                if (kokF1x26 == true) DrugAddictionX += "F14.26. ";
                if (kokF1x31 == true) DrugAddictionX += "F14.31. ";
                if (kokF1x40 == true) DrugAddictionX += "F14.40. ";
                if (kokF1x41 == true) DrugAddictionX += "F14.41. ";
                if (kokF1x5 == true) DrugAddictionX += "F14.5. ";
                if (kokF1x51 == true) DrugAddictionX += "F14.51. ";
                if (kokF1x52 == true) DrugAddictionX += "F14.52. ";
                if (kokF1x53 == true) DrugAddictionX += "F14.53. ";
                if (kokF1x54 == true) DrugAddictionX += "F14.54. ";
                if (kokF1x55 == true) DrugAddictionX += "F14.55. ";
                if (kokF1x56 == true) DrugAddictionX += "F14.56. ";
                if (kokF1x71 == true) DrugAddictionX += "F14.71. ";
                if (kokF1x73 == true) DrugAddictionX += "F14.73. ";
                if (kokF1x9 == true) DrugAddictionX += "F14.9. ";
                if (kokF1x03 == true) DrugAddictionX += "F14.03. ";
                if (kokF1x04 == true) DrugAddictionX += "F14.04. ";
                if (kokF1x06 == true) DrugAddictionX += "F14.06. ";

                if (stimF1x1 == true) DrugAddictionX += "F15.1. ";
                if (stimF1x20 == true) DrugAddictionX += "F15.20. ";
                if (stimF1x21 == true) DrugAddictionX += "F15.21. ";
                if (stimF1x22 == true) DrugAddictionX += "F15.22. ";
                if (stimF1x23 == true) DrugAddictionX += "F15.23. ";
                if (stimF1x24 == true) DrugAddictionX += "F15.24. ";
                if (stimF1x25 == true) DrugAddictionX += "F15.25. ";
                if (stimF1x26 == true) DrugAddictionX += "F15.26. ";
                if (stimF1x31 == true) DrugAddictionX += "F15.31. ";
                if (stimF1x40 == true) DrugAddictionX += "F15.40. ";
                if (stimF1x41 == true) DrugAddictionX += "F15.41. ";
                if (stimF1x5 == true) DrugAddictionX += "F15.5. ";
                if (stimF1x51 == true) DrugAddictionX += "F15.51. ";
                if (stimF1x52 == true) DrugAddictionX += "F15.52. ";
                if (stimF1x53 == true) DrugAddictionX += "F15.53. ";
                if (stimF1x54 == true) DrugAddictionX += "F15.54. ";
                if (stimF1x55 == true) DrugAddictionX += "F15.55. ";
                if (stimF1x56 == true) DrugAddictionX += "F15.56. ";
                if (stimF1x71 == true) DrugAddictionX += "F15.71. ";
                if (stimF1x73 == true) DrugAddictionX += "F15.73. ";
                if (stimF1x9 == true) DrugAddictionX += "F15.9. ";
                if (stimF1x03 == true) DrugAddictionX += "F15.03. ";
                if (stimF1x04 == true) DrugAddictionX += "F15.04. ";
                if (stimF1x06 == true) DrugAddictionX += "F15.06. ";

                if (glukF1x1 == true) DrugAddictionX += "F16.1. ";
                if (glukF1x20 == true) DrugAddictionX += "F16.20. ";
                if (glukF1x21 == true) DrugAddictionX += "F16.21. ";
                if (glukF1x22 == true) DrugAddictionX += "F16.22. ";
                if (glukF1x23 == true) DrugAddictionX += "F16.23. ";
                if (glukF1x24 == true) DrugAddictionX += "F16.24. ";
                if (glukF1x25 == true) DrugAddictionX += "F16.25. ";
                if (glukF1x26 == true) DrugAddictionX += "F16.26. ";
                if (glukF1x31 == true) DrugAddictionX += "F16.31. ";
                if (glukF1x40 == true) DrugAddictionX += "F16.40. ";
                if (glukF1x41 == true) DrugAddictionX += "F16.41. ";
                if (glukF1x5 == true) DrugAddictionX += "F16.5. ";
                if (glukF1x51 == true) DrugAddictionX += "F16.51. ";
                if (glukF1x52 == true) DrugAddictionX += "F16.52. ";
                if (glukF1x53 == true) DrugAddictionX += "F16.53. ";
                if (glukF1x54 == true) DrugAddictionX += "F16.54. ";
                if (glukF1x55 == true) DrugAddictionX += "F16.55. ";
                if (glukF1x56 == true) DrugAddictionX += "F16.56. ";
                if (glukF1x71 == true) DrugAddictionX += "F16.71. ";
                if (glukF1x73 == true) DrugAddictionX += "F16.73. ";
                if (glukF1x9 == true) DrugAddictionX += "F16.9. ";
                if (glukF1x03 == true) DrugAddictionX += "F16.03. ";
                if (glukF1x04 == true) DrugAddictionX += "F16.04. ";
                if (glukF1x06 == true) DrugAddictionX += "F16.06. ";

                if (rastvorF1x1 == true) DrugAddictionX += "F18.1. ";
                if (rastvorF1x20 == true) DrugAddictionX += "F18.20. ";
                if (rastvorF1x21 == true) DrugAddictionX += "F18.21. ";
                if (rastvorF1x22 == true) DrugAddictionX += "F18.22. ";
                if (rastvorF1x23 == true) DrugAddictionX += "F18.23. ";
                if (rastvorF1x24 == true) DrugAddictionX += "F18.24. ";
                if (rastvorF1x25 == true) DrugAddictionX += "F18.25. ";
                if (rastvorF1x26 == true) DrugAddictionX += "F18.26. ";
                if (rastvorF1x31 == true) DrugAddictionX += "F18.31. ";
                if (rastvorF1x40 == true) DrugAddictionX += "F18.40. ";
                if (rastvorF1x41 == true) DrugAddictionX += "F18.41. ";
                if (rastvorF1x5 == true) DrugAddictionX += "F18.5. ";
                if (rastvorF1x51 == true) DrugAddictionX += "F18.51. ";
                if (rastvorF1x52 == true) DrugAddictionX += "F18.52. ";
                if (rastvorF1x53 == true) DrugAddictionX += "F18.53. ";
                if (rastvorF1x54 == true) DrugAddictionX += "F18.54. ";
                if (rastvorF1x55 == true) DrugAddictionX += "F18.55. ";
                if (rastvorF1x56 == true) DrugAddictionX += "F18.56. ";
                if (rastvorF1x71 == true) DrugAddictionX += "F18.71. ";
                if (rastvorF1x73 == true) DrugAddictionX += "F18.73. ";
                if (rastvorF1x9 == true) DrugAddictionX += "F18.9. ";
                if (rastvorF1x03 == true) DrugAddictionX += "F18.03. ";
                if (rastvorF1x04 == true) DrugAddictionX += "F18.04. ";
                if (rastvorF1x06 == true) DrugAddictionX += "F18.06. ";

                if (comboF1x1 == true) DrugAddictionX += "F19.1. ";
                if (comboF1x20 == true) DrugAddictionX += "F19.20. ";
                if (comboF1x21 == true) DrugAddictionX += "F19.21. ";
                if (comboF1x22 == true) DrugAddictionX += "F19.22. ";
                if (comboF1x23 == true) DrugAddictionX += "F19.23. ";
                if (comboF1x24 == true) DrugAddictionX += "F19.24. ";
                if (comboF1x25 == true) DrugAddictionX += "F19.25. ";
                if (comboF1x26 == true) DrugAddictionX += "F19.26. ";
                if (comboF1x31 == true) DrugAddictionX += "F19.31. ";
                if (comboF1x40 == true) DrugAddictionX += "F19.40. ";
                if (comboF1x41 == true) DrugAddictionX += "F19.41. ";
                if (comboF1x5 == true) DrugAddictionX += "F19.5. ";
                if (comboF1x51 == true) DrugAddictionX += "F19.51. ";
                if (comboF1x52 == true) DrugAddictionX += "F19.52. ";
                if (comboF1x53 == true) DrugAddictionX += "F19.53. ";
                if (comboF1x54 == true) DrugAddictionX += "F19.54. ";
                if (comboF1x55 == true) DrugAddictionX += "F19.55. ";
                if (comboF1x56 == true) DrugAddictionX += "F19.56. ";
                if (comboF1x71 == true) DrugAddictionX += "F19.71. ";
                if (comboF1x73 == true) DrugAddictionX += "F19.73. ";
                if (comboF1x9 == true) DrugAddictionX += "F19.9. ";
                if (comboF1x03 == true) DrugAddictionX += "F19.03. ";
                if (comboF1x04 == true) DrugAddictionX += "F19.04. ";
                if (comboF1x06 == true) DrugAddictionX += "F19.06. ";

                // Другая информация по наркозависимости 

                string typeOfDrug = TypeOfDrug.Text;
                string drugUse = DrugUse.Text;
                string yearOfFirstUse = YearOfFirstUse.Text;
                string experienceAbuseDrug = ExperienceAbuseDrug.Text;
                string remissions = Remissions.Text;
                string remissionNumber = RemissionNumber.Text;
                string remissinTimer = RemissionTimer.Text;

                //Интранозологическая коморбидность
                string IntranozologicalComorbidity = "";
                if (thrombophlebitis == true) IntranozologicalComorbidity += "Тромбофлебит. ";
                if (endocarditis == true) IntranozologicalComorbidity += "Эндокардит. ";
                if (myocarditis == true) IntranozologicalComorbidity += "Миокардит. ";
                if (meningitis == true) IntranozologicalComorbidity += "Менингит. ";
                if (sepsis == true) IntranozologicalComorbidity += "Сепсис. ";


                int aa = 0;
                if (dataOfRegistration != "")
                {
                    bool flag2_ = MainDataWindow.Data_Check(dataOfRegistration);
                    if (flag2_)
                    { 
                   
                        string[] mas = data.Split('.', ',', '/');
                        string[] mas1 = dataOfRegistration.Split('.', ',', '/');
                        int a = Convert.ToInt32(mas[2]);
                        int b = Convert.ToInt32(mas1[2]);
                        aa = b - a;
                    }
                    else 
                    {
                        DataOfRegistration.BorderThickness = new Thickness(3);
                        DataOfRegistration.BorderBrush = Brushes.Red;
                        check = false;
                    }
                }
                else if (reRegistrationData != "")
                {
                    bool flag2_ = MainDataWindow.Data_Check(reRegistrationData);
                    if (flag2_)
                    { 
                        string[] mas = data.Split('.', ',', '/');
                        string[] mas1 = reRegistrationData.Split('.', ',', '/');
                        int a = Convert.ToInt32(mas[2]);
                        int b = Convert.ToInt32(mas1[2]);
                        aa = b - a;
                    }
                    else 
                    {
                        ReRegistrationData.BorderThickness = new Thickness(3);
                        ReRegistrationData.BorderBrush = Brushes.Red;
                        check = false;
                    }
                }

                AgeOfRegistration.Text = Convert.ToString(aa);
                string ageOfRegistration = AgeOfRegistration.Text;

                int ab = 0;
                if (dateOfDead != "")
                {
                    bool flag2_ = MainDataWindow.Data_Check(dateOfDead);
                    if (flag2_)
                    {
                        string[] mas = data.Split('.', ',', '/');
                        string[] mas1 = dateOfDead.Split('.', ',', '/', '(');
                        int a = Convert.ToInt32(mas[2]);
                        int b = Convert.ToInt32(mas1[2]);
                        ab = b - a;
                    }
                    else 
                    {
                        DateOfDead.BorderThickness = new Thickness(3);
                        DateOfDead.BorderBrush = Brushes.Red;
                        check = false;
                    }
                }

                string dataInfo = DataInfo.Text;
                bool flag2 = MainDataWindow.Year_Check(dataInfo);
                if (!flag2)
                {
                    DataInfo.BorderThickness = new Thickness(3);
                    DataInfo.BorderBrush = Brushes.Red;
                    check = false;
                }

                AgeOfDead.Text = Convert.ToString(ab);
                string ageOfDead = AgeOfDead.Text;

                if (check == true)
                {
                    Entity.Patient_Сreation_Narco(fio, sex, data, regionCenterBLR, raenCenterBLR, life, age, familyStatus,
                        costOfKids, familyComposition, education, profession, theSkillLevelOfTheProfession, addressOfRegistration,
                        addressAtTheTimeOfDeath, dataOfRegistration, reRegistrationData, typeOfRegistration, heredity, disabilityGroup,
                        disabilityStatus, reasonForDisability, SocialStatus, admOtv, ugOtv, dlitMLS, statja107, statUKRB,
                        rodPrav, nomLTP, LTPkol, hosp, EK, dateOfDeregistration, dateOfDead, placeOfDead, deathCertificate,
                        causeOfDeat, deathCategory, openingPlace, historyOfParasucicides, featuresOfObservation, IntranozologicalComorbidity,
                        typeOfDrug, drugUse, yearOfFirstUse, experienceAbuseDrug, remissions, remissionNumber, remissinTimer, DrugAddictionX, ageOfDead, ageOfRegistration, dataInfo);
                    Close();
                }
                else
                {
                    MessageBox.Show("Не все данные введены корректно");
                    return;
                }
        }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        private void OtherHospNarco_Click(object sender, RoutedEventArgs e)
        {
            OtherHosp otherHosp = new OtherHosp
            {
                Owner = this
            };
            otherHosp.Show();
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RodPrav_Checked(object sender, RoutedEventArgs e)
        {
            rodprav = true;
        }
        private void RodPrav_UnChecked(object sender, RoutedEventArgs e)
        {
            rodprav = false;
        }

        /// <summary>
        /// проверяет вкл или выкл CheckBox "Статья 107" в адм и угл ответственности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        //наркозависимость 
        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Thrombophlebitis_Checked(object sender, RoutedEventArgs e)
        {
            thrombophlebitis = true;
        }
        private void Thrombophlebitis_UnChecked(object sender, RoutedEventArgs e)
        {
            thrombophlebitis = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Endocarditis_Checked(object sender, RoutedEventArgs e)
        {
            endocarditis = true;
        }
        private void Endocarditis_UnChecked(object sender, RoutedEventArgs e)
        {
            endocarditis = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Myocarditis_Checked(object sender, RoutedEventArgs e)
        {
            myocarditis = true;
        }
        private void Myocarditis_UnChecked(object sender, RoutedEventArgs e)
        {
            myocarditis = false;
        }


        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Meningitis_Checked(object sender, RoutedEventArgs e)
        {
            meningitis = true;
        }
        private void Meningitis_UnChecked(object sender, RoutedEventArgs e)
        {
            meningitis = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sepsis_Checked(object sender, RoutedEventArgs e)
        {
            sepsis = true;
        }
        private void Sepsis_UnChecked(object sender, RoutedEventArgs e)
        {
            sepsis = false;
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

        //----------------------------------------------------------------------------
        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x1_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x1 = true;
        }
        private void OpiodF1x1_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x1 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x20_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x20 = true;
        }
        private void OpiodF1x20_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x20 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x21_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x21 = true;
        }
        private void OpiodF1x21_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x21 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x22_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x22 = true;
        }
        private void OpiodF1x22_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x22 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x23_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x23 = true;
        }
        private void OpiodF1x23_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x23 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x24_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x24 = true;
        }
        private void OpiodF1x24_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x24 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x25_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x25 = true;
        }
        private void OpiodF1x25_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x25 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x26_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x26 = true;
        }
        private void OpiodF1x26_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x26 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x31_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x31 = true;
        }
        private void OpiodF1x31_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x31 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x40_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x40 = true;
        }
        private void OpiodF1x40_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x40 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x41_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x41 = true;
        }
        private void OpiodF1x41_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x41 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x5_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x5 = true;
        }
        private void OpiodF1x5_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x5 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x51_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x51 = true;
        }
        private void OpiodF1x51_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x51 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x52_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x52 = true;
        }
        private void OpiodF1x52_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x52 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x53_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x53 = true;
        }
        private void OpiodF1x53_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x53 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x54_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x54 = true;
        }
        private void OpiodF1x54_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x54 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x55_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x55 = true;
        }
        private void OpiodF1x55_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x55 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x56_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x56 = true;
        }
        private void OpiodF1x56_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x56 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x71_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x71 = true;
        }
        private void OpiodF1x71_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x71 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x73_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x73 = true;
        }
        private void OpiodF1x73_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x73 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x9_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x9 = true;
        }
        private void OpiodF1x9_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x9 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x03_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x03 = true;
        }
        private void OpiodF1x03_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x03 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x04_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x04 = true;
        }
        private void OpiodF1x04_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x04 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpiodF1x06_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x06 = true;
        }
        private void OpiodF1x06_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x06 = false;
        }

        //----------------------------------------------------------------------

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x1_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x1 = true;
        }
        private void KanabF1x1_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x1 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x20_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x20 = true;
        }
        private void KanabF1x20_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x20 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x21_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x21 = true;
        }
        private void KanabF1x21_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x21 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x22_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x22 = true;
        }
        private void KanabF1x22_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x22 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x23_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x23 = true;
        }
        private void KanabF1x23_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x23 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x24_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x24 = true;
        }
        private void KanabF1x24_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x24 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x25_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x25 = true;
        }
        private void KanabF1x25_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x25 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x26_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x26 = true;
        }
        private void KanabF1x26_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x26 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x31_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x31 = true;
        }
        private void KanabF1x31_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x31 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x40_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x40 = true;
        }
        private void KanabF1x40_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x40 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x41_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x41 = true;
        }
        private void KanabF1x41_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x41 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x5_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x5 = true;
        }
        private void KanabF1x5_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x5 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x51_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x51 = true;
        }
        private void KanabF1x51_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x51 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x52_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x52 = true;
        }
        private void KanabF1x52_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x52 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x53_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x53 = true;
        }
        private void KanabF1x53_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x53 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x54_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x54 = true;
        }
        private void KanabF1x54_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x54 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x55_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x55 = true;
        }
        private void KanabF1x55_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x55 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x56_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x56 = true;
        }
        private void KanabF1x56_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x56 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x71_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x71 = true;
        }
        private void KanabF1x71_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x71 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x73_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x73 = true;
        }
        private void KanabF1x73_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x73 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x9_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x9 = true;
        }
        private void KanabF1x9_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x9 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x03_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x03 = true;
        }
        private void KanabF1x03_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x03 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x04_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x04 = true;
        }
        private void KanabF1x04_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x04 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanabF1x06_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x06 = true;
        }
        private void KanabF1x06_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x06 = false;
        }

        //-----------------------------------------------------------------------
        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x1_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x1 = true;
        }
        private void SedatF1x1_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x1 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x20_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x20 = true;
        }
        private void SedatF1x20_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x20 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x21_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x21 = true;
        }
        private void SedatF1x21_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x21 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x22_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x22 = true;
        }
        private void SedatF1x22_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x22 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x23_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x23 = true;
        }
        private void SedatF1x23_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x23 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x24_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x24 = true;
        }
        private void SedatF1x24_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x24 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x25_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x25 = true;
        }
        private void SedatF1x25_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x25 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x26_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x26 = true;
        }
        private void SedatF1x26_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x26 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x31_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x31 = true;
        }
        private void SedatF1x31_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x31 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x40_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x40 = true;
        }
        private void SedatF1x40_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x40 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x41_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x41 = true;
        }
        private void SedatF1x41_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x41 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x5_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x5 = true;
        }
        private void SedatF1x5_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x5 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x51_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x51 = true;
        }
        private void SedatF1x51_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x51 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x52_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x52 = true;
        }
        private void SedatF1x52_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x52 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x53_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x53 = true;
        }
        private void SedatF1x53_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x53 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x54_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x54 = true;
        }
        private void SedatF1x54_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x54 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x55_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x55 = true;
        }
        private void SedatF1x55_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x55 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x56_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x56 = true;
        }
        private void SedatF1x56_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x56 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x71_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x71 = true;
        }
        private void SedatF1x71_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x71 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x73_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x73 = true;
        }
        private void SedatF1x73_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x73 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x9_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x9 = true;
        }
        private void SedatF1x9_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x9 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x03_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x03 = true;
        }
        private void SedatF1x03_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x03 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x04_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x04 = true;
        }
        private void SedatF1x04_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x04 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SedatF1x06_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x06 = true;
        }
        private void SedatF1x06_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x06 = false;
        }

        //-------------------------------------------------------------------
        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x1_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x1 = true;
        }
        private void KokF1x1_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x1 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x20_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x20 = true;
        }
        private void KokF1x20_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x20 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x21_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x21 = true;
        }
        private void KokF1x21_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x21 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x22_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x22 = true;
        }
        private void KokF1x22_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x22 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x23_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x23 = true;
        }
        private void KokF1x23_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x23 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x24_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x24 = true;
        }
        private void KokF1x24_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x24 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x25_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x25 = true;
        }
        private void KokF1x25_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x25 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x26_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x26 = true;
        }
        private void KokF1x26_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x26 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x31_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x31 = true;
        }
        private void KokF1x31_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x31 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x40_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x40 = true;
        }
        private void KokF1x40_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x40 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x41_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x41 = true;
        }
        private void KokF1x41_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x41 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x5_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x5 = true;
        }
        private void KokF1x5_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x5 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x51_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x51 = true;
        }
        private void KokF1x51_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x51 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x52_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x52 = true;
        }
        private void KokF1x52_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x52 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x53_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x53 = true;
        }
        private void KokF1x53_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x53 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x54_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x54 = true;
        }
        private void KokF1x54_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x54 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x55_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x55 = true;
        }
        private void KokF1x55_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x55 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x56_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x56 = true;
        }
        private void KokF1x56_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x56 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x71_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x71 = true;
        }
        private void KokF1x71_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x71 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x73_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x73 = true;
        }
        private void KokF1x73_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x73 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x9_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x9 = true;
        }
        private void KokF1x9_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x9 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x03_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x03 = true;
        }
        private void KokF1x03_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x03 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x04_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x04 = true;
        }
        private void KokF1x04_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x04 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KokF1x06_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x06 = true;
        }
        private void KokF1x06_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x06 = false;
        }

        // ------------------------------------------------------------------
        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x1_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x1 = true;
        }
        private void StimF1x1_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x1 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x20_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x20 = true;
        }
        private void StimF1x20_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x20 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x21_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x21 = true;
        }
        private void StimF1x21_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x21 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x22_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x22 = true;
        }
        private void StimF1x22_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x22 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x23_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x23 = true;
        }
        private void StimF1x23_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x23 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x24_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x24 = true;
        }
        private void StimF1x24_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x24 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x25_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x25 = true;
        }
        private void StimF1x25_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x25 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x26_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x26 = true;
        }
        private void StimF1x26_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x26 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x31_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x31 = true;
        }
        private void StimF1x31_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x31 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x40_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x40 = true;
        }
        private void StimF1x40_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x40 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x41_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x41 = true;
        }
        private void StimF1x41_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x41 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x5_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x5 = true;
        }
        private void StimF1x5_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x5 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x51_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x51 = true;
        }
        private void StimF1x51_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x51 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x52_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x52 = true;
        }
        private void StimF1x52_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x52 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x53_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x53 = true;
        }
        private void StimF1x53_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x53 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x54_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x54 = true;
        }
        private void StimF1x54_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x54 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x55_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x55 = true;
        }
        private void StimF1x55_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x55 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x56_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x56 = true;
        }
        private void StimF1x56_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x56 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x71_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x71 = true;
        }
        private void StimF1x71_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x71 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x73_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x73 = true;
        }
        private void StimF1x73_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x73 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x9_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x9 = true;
        }
        private void StimF1x9_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x9 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x03_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x03 = true;
        }
        private void StimF1x03_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x03 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x04_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x04 = true;
        }
        private void StimF1x04_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x04 = false;
        }

        /// <summary>
        /// проверяем чекбокс  по наркозависимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimF1x06_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x06 = true;
        }
        private void StimF1x06_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x06 = false;
        }
        
        //-----------------------------------------------------------------
        private void GlukF1x1_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x1 = true;
        }
        private void GlukF1x1_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x1 = false;
        }

        private void GlukF1x20_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x20 = true;
        }
        private void GlukF1x20_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x20 = false;
        }

        private void GlukF1x21_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x21 = true;
        }
        private void GlukF1x21_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x21 = false;
        }

        private void GlukF1x22_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x22 = true;
        }
        private void GlukF1x22_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x22 = false;
        }

        private void GlukF1x23_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x23 = true;
        }
        private void GlukF1x23_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x23 = false;
        }

        private void GlukF1x24_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x24 = true;
        }
        private void GlukF1x24_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x24 = false;
        }

        private void GlukF1x25_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x25 = true;
        }
        private void GlukF1x25_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x25 = false;
        }

        private void GlukF1x26_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x26 = true;
        }
        private void GlukF1x26_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x26 = false;
        }

        private void GlukF1x31_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x31 = true;
        }
        private void GlukF1x31_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x31 = false;
        }

        private void GlukF1x40_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x40 = true;
        }
        private void GlukF1x40_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x40 = false;
        }

        private void GlukF1x41_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x41 = true;
        }
        private void GlukF1x41_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x41 = false;
        }

        private void GlukF1x5_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x5 = true;
        }
        private void GlukF1x5_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x5 = false;
        }

        private void GlukF1x51_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x51 = true;
        }
        private void GlukF1x51_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x51 = false;
        }

        private void GlukF1x52_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x52 = true;
        }
        private void GlukF1x52_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x52 = false;
        }

        private void GlukF1x53_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x53 = true;
        }
        private void GlukF1x53_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x53 = false;
        }

        private void GlukF1x54_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x54 = true;
        }
        private void GlukF1x54_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x54 = false;
        }

        private void GlukF1x55_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x55 = true;
        }
        private void GlukF1x55_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x55 = false;
        }

        private void GlukF1x56_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x56 = true;
        }
        private void GlukF1x56_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x56 = false;
        }

        private void GlukF1x71_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x71 = true;
        }
        private void GlukF1x71_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x71 = false;
        }

        private void GlukF1x73_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x73 = true;
        }
        private void GlukF1x73_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x73 = false;
        }

        private void GlukF1x9_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x9 = true;
        }
        private void GlukF1x9_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x9 = false;
        }

        private void GlukF1x03_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x03 = true;
        }
        private void GlukF1x03_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x03 = false;
        }

        private void GlukF1x04_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x04 = true;
        }
        private void GlukF1x04_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x04 = false;
        }

        private void GlukF1x06_Checked(object sender, RoutedEventArgs e)
        {
            glukF1x06 = true;
        }
        private void GlukF1x06_UnChecked(object sender, RoutedEventArgs e)
        {
            glukF1x06 = false;
        }
        
        //-----------------------------------------------------------------
        private void RastvorF1x1_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x1 = true;
        }
        private void RastvorF1x1_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x1 = false;
        }

        private void RastvorF1x20_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x20 = true;
        }
        private void RastvorF1x20_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x20 = false;
        }

        private void RastvorF1x21_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x21 = true;
        }
        private void RastvorF1x21_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x21 = false;
        }

        private void RastvorF1x22_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x22 = true;
        }
        private void RastvorF1x22_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x22 = false;
        }

        private void RastvorF1x23_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x23 = true;
        }
        private void RastvorF1x23_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x23 = false;
        }

        private void RastvorF1x24_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x24 = true;
        }
        private void RastvorF1x24_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x24 = false;
        }

        private void RastvorF1x25_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x25 = true;
        }
        private void RastvorF1x25_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x25 = false;
        }

        private void RastvorF1x26_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x26 = true;
        }
        private void RastvorF1x26_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x26 = false;
        }

        private void RastvorF1x31_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x31 = true;
        }
        private void RastvorF1x31_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x31 = false;
        }

        private void RastvorF1x40_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x40 = true;
        }
        private void RastvorF1x40_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x40 = false;
        }

        private void RastvorF1x41_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x41 = true;
        }
        private void RastvorF1x41_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x41 = false;
        }

        private void RastvorF1x5_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x5 = true;
        }
        private void RastvorF1x5_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x5 = false;
        }

        private void RastvorF1x51_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x51 = true;
        }
        private void RastvorF1x51_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x51 = false;
        }

        private void RastvorF1x52_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x52 = true;
        }
        private void RastvorF1x52_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x52 = false;
        }

        private void RastvorF1x53_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x53 = true;
        }
        private void RastvorF1x53_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x53 = false;
        }

        private void RastvorF1x54_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x54 = true;
        }
        private void RastvorF1x54_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x54 = false;
        }

        private void RastvorF1x55_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x55 = true;
        }
        private void RastvorF1x55_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x55 = false;
        }

        private void RastvorF1x56_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x56 = true;
        }
        private void RastvorF1x56_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x56 = false;
        }

        private void RastvorF1x71_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x71 = true;
        }
        private void RastvorF1x71_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x71 = false;
        }

        private void RastvorF1x73_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x73 = true;
        }
        private void RastvorF1x73_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x73 = false;
        }

        private void RastvorF1x9_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x9 = true;
        }
        private void RastvorF1x9_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x9 = false;
        }

        private void RastvorF1x03_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x03 = true;
        }
        private void RastvorF1x03_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x03 = false;
        }

        private void RastvorF1x04_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x04 = true;
        }
        private void RastvorF1x04_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x04 = false;
        }

        private void RastvorF1x06_Checked(object sender, RoutedEventArgs e)
        {
            rastvorF1x06 = true;
        }
        private void RastvorF1x06_UnChecked(object sender, RoutedEventArgs e)
        {
            rastvorF1x06 = false;
        }

        //----------------------------------------------------------------
        private void ComboF1x1_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x1 = true;
        }
        private void ComboF1x1_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x1 = false;
        }

        private void ComboF1x20_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x20 = true;
        }
        private void ComboF1x20_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x20 = false;
        }

        private void ComboF1x21_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x21 = true;
        }
        private void ComboF1x21_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x21 = false;
        }

        private void ComboF1x22_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x22 = true;
        }
        private void ComboF1x22_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x22 = false;
        }

        private void ComboF1x23_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x23 = true;
        }
        private void ComboF1x23_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x23 = false;
        }

        private void ComboF1x24_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x24 = true;
        }
        private void ComboF1x24_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x24 = false;
        }

        private void ComboF1x25_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x25 = true;
        }
        private void ComboF1x25_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x25 = false;
        }

        private void ComboF1x26_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x26 = true;
        }
        private void ComboF1x26_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x26 = false;
        }

        private void ComboF1x31_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x31 = true;
        }
        private void ComboF1x31_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x31 = false;
        }

        private void ComboF1x40_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x40 = true;
        }
        private void ComboF1x40_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x40 = false;
        }

        private void ComboF1x41_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x41 = true;
        }
        private void ComboF1x41_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x41 = false;
        }

        private void ComboF1x5_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x5 = true;
        }
        private void ComboF1x5_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x5 = false;
        }
        private void ComboF1x51_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x51 = true;
        }
        private void ComboF1x51_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x51 = false;
        }

        private void ComboF1x52_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x52 = true;
        }
        private void ComboF1x52_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x52 = false;
        }

        private void ComboF1x53_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x53 = true;
        }
        private void ComboF1x53_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x53 = false;
        }

        private void ComboF1x54_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x54 = true;
        }
        private void ComboF1x54_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x54 = false;
        }

        private void ComboF1x55_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x55 = true;
        }
        private void ComboF1x55_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x55 = false;
        }

        private void ComboF1x56_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x56 = true;
        }
        private void ComboF1x56_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x56 = false;
        }

        private void ComboF1x71_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x71 = true;
        }
        private void ComboF1x71_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x71 = false;
        }

        private void ComboF1x73_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x73 = true;
        }
        private void ComboF1x73_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x73 = false;
        }

        private void ComboF1x9_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x9 = true;
        }
        private void ComboF1x9_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x9 = false;
        }

        private void ComboF1x03_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x03 = true;
        }
        private void ComboF1x03_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x03 = false;
        }

        private void ComboF1x04_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x04 = true;
        }
        private void ComboF1x04_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x04 = false;
        }

        private void ComboF1x06_Checked(object sender, RoutedEventArgs e)
        {
            comboF1x06 = true;
        }

        private void ComboF1x06_UnChecked(object sender, RoutedEventArgs e)
        {
            comboF1x06 = false;
        }
        private void OrintirDead_Checked(object sender, RoutedEventArgs e)
        {
            orintirDead = true;
        }

        private void OrintirDead_UnChecked(object sender, RoutedEventArgs e)
        {
            orintirDead = false;
        }
    }
}
