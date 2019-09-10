using System;
using System.Windows;
using HelaMedical.Class;
using System.Windows.Media;
using HelaMedical.Excep;
using HelaMedical.DbContexte;

namespace HelaMedical
{
    /// <summary>
    /// Логика взаимодействия для MainDataWindow3.xaml
    /// </summary>
    public partial class MainDataWindow3 : Window
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
        private bool boneAracture = false ;
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
        private bool kokF1x71 = false;
        private bool kokF1x73 = false;
        private bool kokF1x9 = false;
        private bool kokF1x03 = false;
        private bool kokF1x04 = false;
        private bool kokF1x06 = false;

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

        public MainDataWindow3()
        {
            InitializeComponent();
            Bool.PolizBool = false;
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

        private void ExitCombo_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Обработка клавиши добавить 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddCombo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool check = true;
                //Персональные данные 
                string fio = FIO.Text;
                string sex = Sex.Text;
                if (sex =="")
                {
                    Sex.BorderThickness = new Thickness(3);
                    Sex.BorderBrush = Brushes.Red;
                    check = false;
                }
                string data = Date.Text;
                if (data =="")
                {
                    Date.BorderThickness = new Thickness(3);
                    Date.BorderBrush = Brushes.Red;
                    check = false;
                }

                //областной центр берет из страницы OblReg
                string regionCenterBLR = Other.Obl;

                string raenCentrBLR = Other.Reg;

                string life = Life.Text;
                if (life =="")
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
                if (vodka == true) AlcoholicDrinks += "Водка или другие крепкие алкогольные напитки. ";
                if (wine == true) AlcoholicDrinks += "Вино. ";
                if (beer == true) AlcoholicDrinks += "Пиво. ";
                if (surrogates == true) AlcoholicDrinks += "Суррогаты. ";
                if (moonshine == true) AlcoholicDrinks += "Самогон. ";
                if (alcoholContainingDrugs == true) AlcoholicDrinks += "Спиртосодержащие. ";
                if (notSpecified == true) AlcoholicDrinks += "Не уточнено";


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
                if (thrombophlebitis == true) IntranozologicalComorbidity += "Тромбофлебит. ";
                if (endocarditis == true) IntranozologicalComorbidity += "Эндокардит. ";
                if (myocarditis == true) IntranozologicalComorbidity += "Миокардит. ";
                if (meningitis == true) IntranozologicalComorbidity += "Менингит. ";
                if (sepsis == true) IntranozologicalComorbidity += "Сепсис. ";


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
                string remissionTimer = RemissionTimer.Text;


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
                        DataOfRegistration.BorderBrush = Brushes.Red;
                        Date.BorderBrush = Brushes.Red;
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
                        ReRegistrationData.BorderBrush = Brushes.Red;
                        Date.BorderBrush = Brushes.Red;
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
                        string[] mas1 = dateOfDead.Split('.', ',', '/');
                        int a = Convert.ToInt32(mas[2]);
                        int b = Convert.ToInt32(mas1[2]);
                        ab = b - a;
                    }
                    catch (Exception)
                    {
                        Date.BorderThickness = new Thickness(3);
                        DateOfDead.BorderThickness = new Thickness(3);
                        DateOfDead.BorderBrush = Brushes.Red;
                        Date.BorderBrush = Brushes.Red;
                        check = false;
                    }
                }

                string dataInfo = DataInfo.Text;
                AgeOfDead.Text = Convert.ToString(ab);
                string ageOfDead = AgeOfDead.Text;

                if (check == true)
                {
                    Entity.Patient_Сreation_Alco_Narco(fio, sex, data, regionCenterBLR, raenCentrBLR, life, age, familyStatus,
                    costOfKids, familyComposition, education, profession, theSkillLevelOfTheProfession, addressOfRegistration,
                    addressAtTheTimeOfDeath, dataOfRegistration, reRegistrationData, typeOfRegistration, heredity, disabilityGroup,
                    disabilityStatus, reasonForDisability, SocialStatus, admOtv, ugOtv, dlitMLS, statja107, statUKRB,
                    rodPrav, nomLTP, LTPkol, hosp, EK, dateOfDeregistration, dateOfDead, placeOfDead,
                    deathCertificate, causeOfDeat, deathCategory, openingPlace, historyOfParasucicides, featuresOfObservation,
                    DrugDiagnosisAlc, experienceAbuse, AlcoholicDrinks, IntranozologicalComorbidity, typeOfDrug,
                    drugUse, yearOfFirstUse, experienceAbuseDrug, remissions, remissionNumber, remissionTimer, DrugAddictionX,
                    ageOfDead, ageOfRegistration, dataInfo);
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

        private void OtherHosp_Click(object sender, RoutedEventArgs e)
        {
            OtherHosp otherHosp = new OtherHosp
            {
                Owner = this
            };
            otherHosp.Show();
        }

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


        //--------------------------------------------


        private void Thrombophlebitis_Checked(object sender, RoutedEventArgs e)
        {
            thrombophlebitis = true;
        }
        private void Thrombophlebitis_UnChecked(object sender, RoutedEventArgs e)
        {
            thrombophlebitis = false;
        }

        private void Endocarditis_Checked(object sender, RoutedEventArgs e)
        {
            endocarditis = true;
        }
        private void Endocarditis_UnChecked(object sender, RoutedEventArgs e)
        {
            endocarditis = false;
        }

        private void Myocarditis_Checked(object sender, RoutedEventArgs e)
        {
            myocarditis = true;
        }
        private void Myocarditis_UnChecked(object sender, RoutedEventArgs e)
        {
            myocarditis = false;
        }

        private void Meningitis_Checked(object sender, RoutedEventArgs e)
        {
            meningitis = true;
        }
        private void Meningitis_UnChecked(object sender, RoutedEventArgs e)
        {
            meningitis = false;
        }

        private void Sepsis_Checked(object sender, RoutedEventArgs e)
        {
            sepsis = true;
        }
        private void Sepsis_UnChecked(object sender, RoutedEventArgs e)
        {
            sepsis = false;
        }

        //----------------------------------------------------------------------------
        private void OpiodF1x1_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x1 = true;
        }
        private void OpiodF1x1_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x1 = false;
        }

        private void OpiodF1x20_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x20 = true;
        }
        private void OpiodF1x20_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x20 = false;
        }

        private void OpiodF1x21_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x21 = true;
        }
        private void OpiodF1x21_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x21 = false;
        }

        private void OpiodF1x22_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x22 = true;
        }
        private void OpiodF1x22_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x22 = false;
        }

        private void OpiodF1x23_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x23 = true;
        }
        private void OpiodF1x23_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x23 = false;
        }

        private void OpiodF1x24_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x24 = true;
        }
        private void OpiodF1x24_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x24 = false;
        }

        private void OpiodF1x25_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x25 = true;
        }
        private void OpiodF1x25_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x25 = false;
        }

        private void OpiodF1x26_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x26 = true;
        }
        private void OpiodF1x26_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x26 = false;
        }

        private void OpiodF1x31_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x31 = true;
        }
        private void OpiodF1x31_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x31 = false;
        }

        private void OpiodF1x40_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x40 = true;
        }
        private void OpiodF1x40_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x40 = false;
        }

        private void OpiodF1x41_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x41 = true;
        }
        private void OpiodF1x41_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x41 = false;
        }

        private void OpiodF1x5_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x5 = true;
        }
        private void OpiodF1x5_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x5 = false;
        }

        private void OpiodF1x51_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x51 = true;
        }
        private void OpiodF1x51_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x51 = false;
        }

        private void OpiodF1x52_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x52 = true;
        }
        private void OpiodF1x52_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x52 = false;
        }

        private void OpiodF1x53_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x53 = true;
        }
        private void OpiodF1x53_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x53 = false;
        }

        private void OpiodF1x54_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x54 = true;
        }
        private void OpiodF1x54_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x54 = false;
        }

        private void OpiodF1x55_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x55 = true;
        }
        private void OpiodF1x55_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x55 = false;
        }

        private void OpiodF1x56_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x56 = true;
        }
        private void OpiodF1x56_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x56 = false;
        }

        private void OpiodF1x71_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x71 = true;
        }
        private void OpiodF1x71_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x71 = false;
        }

        private void OpiodF1x73_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x73 = true;
        }
        private void OpiodF1x73_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x73 = false;
        }

        private void OpiodF1x9_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x9 = true;
        }
        private void OpiodF1x9_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x9 = false;
        }

        private void OpiodF1x03_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x03 = true;
        }
        private void OpiodF1x03_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x03 = false;
        }

        private void OpiodF1x04_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x04 = true;
        }
        private void OpiodF1x04_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x04 = false;
        }

        private void OpiodF1x06_Checked(object sender, RoutedEventArgs e)
        {
            opiodF1x06 = true;
        }
        private void OpiodF1x06_UnChecked(object sender, RoutedEventArgs e)
        {
            opiodF1x06 = false;
        }

        //----------------------------------------------------------------------
        private void KanabF1x1_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x1 = true;
        }
        private void KanabF1x1_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x1 = false;
        }

        private void KanabF1x20_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x20 = true;
        }
        private void KanabF1x20_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x20 = false;
        }

        private void KanabF1x21_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x21 = true;
        }
        private void KanabF1x21_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x21 = false;
        }

        private void KanabF1x22_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x22 = true;
        }
        private void KanabF1x22_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x22 = false;
        }

        private void KanabF1x23_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x23 = true;
        }
        private void KanabF1x23_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x23 = false;
        }

        private void KanabF1x24_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x24 = true;
        }
        private void KanabF1x24_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x24 = false;
        }

        private void KanabF1x25_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x25 = true;
        }
        private void KanabF1x25_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x25 = false;
        }

        private void KanabF1x26_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x26 = true;
        }
        private void KanabF1x26_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x26 = false;
        }

        private void KanabF1x31_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x31 = true;
        }
        private void KanabF1x31_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x31 = false;
        }

        private void KanabF1x40_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x40 = true;
        }
        private void KanabF1x40_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x40 = false;
        }

        private void KanabF1x41_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x41 = true;
        }
        private void KanabF1x41_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x41 = false;
        }

        private void KanabF1x5_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x5 = true;
        }
        private void KanabF1x5_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x5 = false;
        }

        private void KanabF1x51_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x51 = true;
        }
        private void KanabF1x51_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x51 = false;
        }

        private void KanabF1x52_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x52 = true;
        }
        private void KanabF1x52_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x52 = false;
        }

        private void KanabF1x53_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x53 = true;
        }
        private void KanabF1x53_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x53 = false;
        }

        private void KanabF1x54_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x54 = true;
        }
        private void KanabF1x54_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x54 = false;
        }

        private void KanabF1x55_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x55 = true;
        }
        private void KanabF1x55_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x55 = false;
        }

        private void KanabF1x56_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x56 = true;
        }
        private void KanabF1x56_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x56 = false;
        }

        private void KanabF1x71_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x71 = true;
        }
        private void KanabF1x71_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x71 = false;
        }

        private void KanabF1x73_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x73 = true;
        }
        private void KanabF1x73_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x73 = false;
        }

        private void KanabF1x9_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x9 = true;
        }
        private void KanabF1x9_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x9 = false;
        }

        private void KanabF1x03_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x03 = true;
        }
        private void KanabF1x03_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x03 = false;
        }

        private void KanabF1x04_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x04 = true;
        }
        private void KanabF1x04_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x04 = false;
        }

        private void KanabF1x06_Checked(object sender, RoutedEventArgs e)
        {
            kanabF1x06 = true;
        }
        private void KanabF1x06_UnChecked(object sender, RoutedEventArgs e)
        {
            kanabF1x06 = false;
        }

        //-----------------------------------------------------------------------
        private void SedatF1x1_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x1 = true;
        }
        private void SedatF1x1_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x1 = false;
        }

        private void SedatF1x20_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x20 = true;
        }
        private void SedatF1x20_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x20 = false;
        }

        private void SedatF1x21_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x21 = true;
        }
        private void SedatF1x21_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x21 = false;
        }

        private void SedatF1x22_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x22 = true;
        }
        private void SedatF1x22_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x22 = false;
        }

        private void SedatF1x23_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x23 = true;
        }
        private void SedatF1x23_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x23 = false;
        }

        private void SedatF1x24_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x24 = true;
        }
        private void SedatF1x24_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x24 = false;
        }

        private void SedatF1x25_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x25 = true;
        }
        private void SedatF1x25_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x25 = false;
        }

        private void SedatF1x26_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x26 = true;
        }
        private void SedatF1x26_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x26 = false;
        }

        private void SedatF1x31_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x31 = true;
        }
        private void SedatF1x31_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x31 = false;
        }

        private void SedatF1x40_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x40 = true;
        }
        private void SedatF1x40_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x40 = false;
        }

        private void SedatF1x41_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x41 = true;
        }
        private void SedatF1x41_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x41 = false;
        }

        private void SedatF1x5_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x5 = true;
        }
        private void SedatF1x5_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x5 = false;
        }

        private void SedatF1x51_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x51 = true;
        }
        private void SedatF1x51_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x51 = false;
        }

        private void SedatF1x52_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x52 = true;
        }
        private void SedatF1x52_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x52 = false;
        }

        private void SedatF1x53_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x53 = true;
        }
        private void SedatF1x53_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x53 = false;
        }

        private void SedatF1x54_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x54 = true;
        }
        private void SedatF1x54_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x54 = false;
        }

        private void SedatF1x55_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x55 = true;
        }
        private void SedatF1x55_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x55 = false;
        }

        private void SedatF1x56_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x56 = true;
        }
        private void SedatF1x56_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x56 = false;
        }

        private void SedatF1x71_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x71 = true;
        }
        private void SedatF1x71_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x71 = false;
        }

        private void SedatF1x73_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x73 = true;
        }
        private void SedatF1x73_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x73 = false;
        }

        private void SedatF1x9_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x9 = true;
        }
        private void SedatF1x9_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x9 = false;
        }

        private void SedatF1x03_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x03 = true;
        }
        private void SedatF1x03_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x03 = false;
        }

        private void SedatF1x04_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x04 = true;
        }
        private void SedatF1x04_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x04 = false;
        }

        private void SedatF1x06_Checked(object sender, RoutedEventArgs e)
        {
            sedatF1x06 = true;
        }
        private void SedatF1x06_UnChecked(object sender, RoutedEventArgs e)
        {
            sedatF1x06 = false;
        }

        //-------------------------------------------------------------------
        private void KokF1x1_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x1 = true;
        }
        private void KokF1x1_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x1 = false;
        }

        private void KokF1x20_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x20 = true;
        }
        private void KokF1x20_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x20 = false;
        }

        private void KokF1x21_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x21 = true;
        }
        private void KokF1x21_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x21 = false;
        }

        private void KokF1x22_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x22 = true;
        }
        private void KokF1x22_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x22 = false;
        }

        private void KokF1x23_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x23 = true;
        }
        private void KokF1x23_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x23 = false;
        }

        private void KokF1x24_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x24 = true;
        }
        private void KokF1x24_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x24 = false;
        }

        private void KokF1x25_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x25 = true;
        }
        private void KokF1x25_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x25 = false;
        }

        private void KokF1x26_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x26 = true;
        }
        private void KokF1x26_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x26 = false;
        }

        private void KokF1x31_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x31 = true;
        }
        private void KokF1x31_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x31 = false;
        }

        private void KokF1x40_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x40 = true;
        }
        private void KokF1x40_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x40 = false;
        }

        private void KokF1x41_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x41 = true;
        }
        private void KokF1x41_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x41 = false;
        }

        private void KokF1x5_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x5 = true;
        }
        private void KokF1x5_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x5 = false;
        }

        private void KokF1x51_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x51 = true;
        }
        private void KokF1x51_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x51 = false;
        }

        private void KokF1x52_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x52 = true;
        }
        private void KokF1x52_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x52 = false;
        }

        private void KokF1x53_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x53 = true;
        }
        private void KokF1x53_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x53 = false;
        }

        private void KokF1x54_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x54 = true;
        }
        private void KokF1x54_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x54 = false;
        }

        private void KokF1x55_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x55 = true;
        }
        private void KokF1x55_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x55 = false;
        }

        private void KokF1x56_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x56 = true;
        }
        private void KokF1x56_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x56 = false;
        }

        private void KokF1x71_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x71 = true;
        }
        private void KokF1x71_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x71 = false;
        }

        private void KokF1x73_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x73 = true;
        }
        private void KokF1x73_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x73 = false;
        }

        private void KokF1x9_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x9 = true;
        }
        private void KokF1x9_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x9 = false;
        }

        private void KokF1x03_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x03 = true;
        }
        private void KokF1x03_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x03 = false;
        }

        private void KokF1x04_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x04 = true;
        }
        private void KokF1x04_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x04 = false;
        }

        private void KokF1x06_Checked(object sender, RoutedEventArgs e)
        {
            kokF1x06 = true;
        }
        private void KokF1x06_UnChecked(object sender, RoutedEventArgs e)
        {
            kokF1x06 = false;
        }

        // ------------------------------------------------------------------
        private void StimF1x1_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x1 = true;
        }
        private void StimF1x1_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x1 = false;
        }

        private void StimF1x20_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x20 = true;
        }
        private void StimF1x20_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x20 = false;
        }

        private void StimF1x21_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x21 = true;
        }
        private void StimF1x21_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x21 = false;
        }

        private void StimF1x22_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x22 = true;
        }
        private void StimF1x22_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x22 = false;
        }

        private void StimF1x23_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x23 = true;
        }
        private void StimF1x23_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x23 = false;
        }

        private void StimF1x24_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x24 = true;
        }
        private void StimF1x24_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x24 = false;
        }

        private void StimF1x25_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x25 = true;
        }
        private void StimF1x25_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x25 = false;
        }

        private void StimF1x26_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x26 = true;
        }
        private void StimF1x26_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x26 = false;
        }

        private void StimF1x31_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x31 = true;
        }
        private void StimF1x31_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x31 = false;
        }

        private void StimF1x40_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x40 = true;
        }
        private void StimF1x40_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x40 = false;
        }

        private void StimF1x41_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x41 = true;
        }
        private void StimF1x41_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x41 = false;
        }

        private void StimF1x5_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x5 = true;
        }
        private void StimF1x5_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x5 = false;
        }

        private void StimF1x51_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x51 = true;
        }
        private void StimF1x51_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x51 = false;
        }

        private void StimF1x52_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x52 = true;
        }
        private void StimF1x52_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x52 = false;
        }

        private void StimF1x53_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x53 = true;
        }
        private void StimF1x53_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x53 = false;
        }

        private void StimF1x54_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x54 = true;
        }
        private void StimF1x54_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x54 = false;
        }

        private void StimF1x55_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x55 = true;
        }
        private void StimF1x55_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x55 = false;
        }

        private void StimF1x56_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x56 = true;
        }
        private void StimF1x56_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x56 = false;
        }

        private void StimF1x71_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x71 = true;
        }
        private void StimF1x71_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x71 = false;
        }

        private void StimF1x73_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x73 = true;
        }
        private void StimF1x73_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x73 = false;
        }

        private void StimF1x9_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x9 = true;
        }
        private void StimF1x9_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x9 = false;
        }

        private void StimF1x03_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x03 = true;
        }
        private void StimF1x03_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x03 = false;
        }

        private void StimF1x04_Checked(object sender, RoutedEventArgs e)
        {
            stimF1x04 = true;
        }
        private void StimF1x04_UnChecked(object sender, RoutedEventArgs e)
        {
            stimF1x04 = false;
        }

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
