using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;
using HelaMedical.Class;
using HelaMedical.Excep;

namespace HelaMedical
{
    /// <summary>
    /// Логика взаимодействия для Generate_A_Report.xaml
    /// </summary>
    public partial class Generate_A_Report : Window
    {
        ApplicationContext db;

        public static string _typeOfAddiction = "";
        public static string _regionCenterBLR = "";
        public static string _sex = "";
        public static string _familyStatus = "";
        public static string _costOfKids = "";
        public static string _familyComposition = "";
        public static string _education = "";
        public static string _periodS = "";
        public static string _periodPo = "";

        public static List<Alco> alco = new List<Alco>();

        public static List<Narcoman> narco = new List<Narcoman>();

        public static List<Polizavis> poliz = new List<Polizavis>();

        public Generate_A_Report()
        {
            InitializeComponent();
            this.Closing += Generate_A_Report_Closing;
        }

        /// <summary>
        /// Закрытие окна
        /// </summary>
        private void Generate_A_Report_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (db != null) db.Dispose();
                
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// Преводим из бд в список алкоголиков
        /// </summary>
        public void Generate_List_Alco()
        {
            try
            {
                Alco.AlcoholismPersona.Clear();
                alco.Clear();
                db = new ApplicationContext();
                db.Alcos.Load();
                foreach (var AlcoPer in db.Alcos)
                {
                    Alco.AlcoholismPersona.Add(AlcoPer);
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// Преводим из бд в список наркоманов
        /// </summary>
        public void Generate_List_Narco()
        {
            try
            {
                narco.Clear();
                Narcoman.Drug_Addiction.Clear();
                db = new ApplicationContext();
                db.Narcomans.Load();
                foreach (var Narco in db.Narcomans)
                {
                    Narcoman.Drug_Addiction.Add(Narco);
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// Преводим из бд в список полизависимых
        /// </summary>
        public void Generate_List_Poliz()
        {
            try
            {
                poliz.Clear();
                Polizavis.Alco_Narco_Person.Clear();
                db = new ApplicationContext();
                db.Polizaviss.Load();
                foreach (var Polis in db.Polizaviss)
                {
                    Polizavis.Alco_Narco_Person.Add(Polis);
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// Создать отчет в DataGrid
        /// </summary>
        public void Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int count = 0;
                string typeOfAddiction = TypeOfAddiction.Text;
                string regionCenterBLR = RegionCenterBLR.Text;
                string sex = Sex.Text;
                string familyStatus = FamilyStatus.Text;
                string costOfKids = CostOfKids.Text;
                string familyComposition = FamilyComposition.Text;
                string education = Education.Text;
                string periodS = PeriodS.Text;
                string periodPo = PeriodPo.Text;
                if (typeOfAddiction == "")
                {
                    MessageBox.Show("Все поля пустые");
                    return;
                }

                if (typeOfAddiction != "") count++;

                if (regionCenterBLR != "") count++;

                if (sex != "") count++;

                if (familyStatus != "") count++;

                if (costOfKids != "") count++;

                if (familyComposition != "") count++;

                if (education != "") count++;

                if (periodS != "") count++;

                if (periodPo != "") count++;

                if (count == 1) One_Params(typeOfAddiction);

                else if (count == 2) Two_Params(typeOfAddiction, regionCenterBLR, sex, familyStatus, costOfKids, familyComposition, education, periodS, periodPo);

                else if (count == 3) Three_Params(typeOfAddiction, regionCenterBLR, sex, familyStatus, costOfKids, familyComposition, education, periodS, periodPo);

                else if (count == 4) Four_Params(typeOfAddiction, regionCenterBLR, sex, familyStatus, costOfKids, familyComposition, education, periodS, periodPo);

                else if (count == 5) Five_Params(typeOfAddiction, regionCenterBLR, sex, familyStatus, costOfKids, familyComposition, education, periodS, periodPo);

                else if (count == 6) Six_Params(typeOfAddiction, regionCenterBLR, sex, familyStatus, costOfKids, familyComposition, education, periodS, periodPo);

                else if (count == 7) Seven_Params(typeOfAddiction, regionCenterBLR, sex, familyStatus, costOfKids, familyComposition, education, periodS, periodPo);

                else if (count == 8) Eight_Params(typeOfAddiction, regionCenterBLR, sex, familyStatus, costOfKids, familyComposition, education, periodS, periodPo);

                else if (count == 9) Nine_Params(typeOfAddiction, regionCenterBLR, sex, familyStatus, costOfKids, familyComposition, education, periodS, periodPo);
            }

            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// Передает 1 параметр
        /// </summary>
        public void One_Params(string typeOfAddiction)
        {
            _typeOfAddiction = typeOfAddiction;
            DataGridFormat(_typeOfAddiction);
        }

        /// <summary>
        /// Передает 2 параметра 
        /// </summary>
        public void Two_Params(string typeOfAddiction, string regionCenterBLR, string sex, string familyStatus, string costOfKids, string familyComposition, string education, string periodS, string periodPo)
        {
            if (typeOfAddiction != "" && regionCenterBLR != "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR);

            }
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                DataGridFormat(_typeOfAddiction, _sex);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                DataGridFormat(_typeOfAddiction, _familyStatus);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _costOfKids = costOfKids;
                DataGridFormat(_typeOfAddiction, _costOfKids);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition != "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyComposition = familyComposition;
                DataGridFormat(_typeOfAddiction, _familyComposition);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _education = education;
                DataGridFormat(_typeOfAddiction, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _periodPo);
            }
        }

        /// <summary>
        /// Передает 3 параметра 
        /// </summary>
        public void Three_Params(string typeOfAddiction, string regionCenterBLR, string sex, string familyStatus, string costOfKids, string familyComposition, string education, string periodS, string periodPo)
        {
            //-------------------------------
            //тип зависимости
            //--------------------------------------------------------------------------------------------------------
            if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus == ""
                   && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex == "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _familyStatus = familyStatus;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _familyStatus);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _costOfKids = costOfKids;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _costOfKids);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition != "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _familyComposition = familyComposition;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _familyComposition);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _education = education;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _periodPo);
            }
            //------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                DataGridFormat(_typeOfAddiction, _sex, _familyStatus);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus == ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _costOfKids = costOfKids;
                DataGridFormat(_typeOfAddiction, _sex, _costOfKids);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus == ""
            && costOfKids == "" && familyComposition != "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyComposition = familyComposition;
                DataGridFormat(_typeOfAddiction, _sex, _familyComposition);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _education = education;
                DataGridFormat(_typeOfAddiction, _sex, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _sex, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _sex, _periodPo);
            }
            //---------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                DataGridFormat(_typeOfAddiction, _familyStatus, _costOfKids);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids == "" && familyComposition != "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _familyComposition = familyComposition;
                DataGridFormat(_typeOfAddiction, _familyStatus, _familyComposition);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _education = education;
                DataGridFormat(_typeOfAddiction, _familyStatus, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _familyStatus, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _familyStatus, _periodPo);
            }
            //----------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition != "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                DataGridFormat(_typeOfAddiction, _costOfKids, _familyComposition);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition == "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _costOfKids = costOfKids;
                _education = education;
                DataGridFormat(_typeOfAddiction, _costOfKids, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _costOfKids = costOfKids;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _costOfKids, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _costOfKids = costOfKids;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _costOfKids, _periodPo);
            }
            //---------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition != "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyComposition = familyComposition;
                _education = education;
                DataGridFormat(_typeOfAddiction, _familyComposition, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition != "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyComposition = familyComposition;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _familyComposition, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition != "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyComposition = familyComposition;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _familyComposition, _periodPo);
            }
            //---------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education != "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _education = education;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _education, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _education = education;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _education, _periodPo);
            }
            //---------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS != "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _periodS = periodS;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _periodS, _periodPo);
            }
        }

        /// <summary>
        /// Передает 4 параметра 
        /// </summary>
        public void Four_Params(string typeOfAddiction, string regionCenterBLR, string sex, string familyStatus, string costOfKids, string familyComposition, string education, string periodS, string periodPo)
        {
            if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus == ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _costOfKids = costOfKids;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _costOfKids);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus == ""
            && costOfKids == "" && familyComposition != "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyComposition = familyComposition;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyComposition);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _education = education;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _periodPo);
            }
            //---------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _costOfKids);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition != "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _familyComposition = familyComposition;
                DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _familyComposition);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _education = education;
                DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _periodPo);
            }
            //-----------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                DataGridFormat(_typeOfAddiction, _familyStatus, _costOfKids, _familyComposition);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _education = education;
                DataGridFormat(_typeOfAddiction, _familyStatus, _costOfKids, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _familyStatus, _costOfKids, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _familyStatus, _costOfKids, _periodPo);
            }
            //--------------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                DataGridFormat(_typeOfAddiction, _costOfKids, _familyComposition, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition != "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _costOfKids, _familyComposition, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition != "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _costOfKids, _familyComposition, _periodPo);
            }
            //------------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition != "" && education != "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyComposition = familyComposition;
                _education = education;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _familyComposition, _education, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition != "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyComposition = familyComposition;
                _education = education;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _familyComposition, _education, _periodPo);
            }
            //------------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education != "" && periodS != "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _education = education;
                _periodS = periodS;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _education, _periodS, _periodPo);
            }
        }

        /// <summary>
        /// Передает 5 параметров
        /// </summary>
        public void Five_Params(string typeOfAddiction, string regionCenterBLR, string sex, string familyStatus, string costOfKids, string familyComposition, string education, string periodS, string periodPo)
        {
            if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition != "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _familyComposition = familyComposition;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _familyComposition);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _education = education;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _periodPo);
            }
            //---------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _costOfKids, _familyComposition);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _education = education;
                DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _costOfKids, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _costOfKids, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _costOfKids, _periodPo);
            }
            //------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                DataGridFormat(_typeOfAddiction, _familyStatus, _costOfKids, _familyComposition, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _familyStatus, _costOfKids, _familyComposition, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _familyStatus, _costOfKids, _familyComposition, _periodPo);
            }
            //------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _costOfKids, _familyComposition, _education, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _costOfKids, _familyComposition, _education, _periodPo);
            }
            //------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition != "" && education != "" && periodS != "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyComposition = familyComposition;
                _education = education;
                _periodS = periodS;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _familyComposition, _education, _periodS, _periodPo);
            }
        }

        /// <summary>
        /// Передает 6 параметров
        /// </summary>
        public void Six_Params(string typeOfAddiction, string regionCenterBLR, string sex, string familyStatus, string costOfKids, string familyComposition, string education, string periodS, string periodPo)
        {
            if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
           && costOfKids != "" && familyComposition != "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _familyComposition);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _education = education;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _periodPo);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _costOfKids, _familyComposition, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _costOfKids, _familyComposition, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _costOfKids, _familyComposition, _periodPo);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _familyStatus, _costOfKids, _familyComposition, _education, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _familyStatus, _costOfKids, _familyComposition, _education, _periodPo);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS != "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodS = periodS;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _costOfKids, _familyComposition, _education, _periodS, _periodPo);
            }
        }

        /// <summary>
        /// Передает 7 параметров
        /// </summary>
        public void Seven_Params(string typeOfAddiction, string regionCenterBLR, string sex, string familyStatus, string costOfKids, string familyComposition, string education, string periodS, string periodPo)
        {
            if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _familyComposition, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _familyComposition, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _familyComposition, _periodPo);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education != "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _education = education;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _education, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _education = education;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _education, _periodPo);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition != "" && education != "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _familyComposition = familyComposition;
                _education = education;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _familyComposition, _education, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition != "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _familyComposition = familyComposition;
                _education = education;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _familyComposition, _education, _periodPo);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus == ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _costOfKids, _familyComposition, _education, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus == ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _costOfKids, _familyComposition, _education, _periodPo);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _familyStatus, _costOfKids, _familyComposition, _education, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _familyStatus, _costOfKids, _familyComposition, _education, _periodPo);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _costOfKids, _familyComposition, _education, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _costOfKids, _familyComposition, _education, _periodPo);
            }
        }

        /// <summary>
        /// передает 8 параметров пока не дописан 
        /// </summary>
        public void Eight_Params(string typeOfAddiction, string regionCenterBLR, string sex, string familyStatus, string costOfKids, string familyComposition, string education, string periodS, string periodPo)
        {
            if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
               && costOfKids != "" && familyComposition != "" && education != "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodS = periodS;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _familyComposition, _education, _periodS);
            }
            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _familyComposition, _education, _periodPo);
            }
            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _familyComposition, _education, _periodPo);
            }
            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _familyComposition, _education, _periodPo);
            }
        }

        /// <summary>
        /// передает 9 параметров пока не дописан 
        /// </summary>
        public void Nine_Params(string typeOfAddiction, string regionCenterBLR, string sex, string familyStatus, string costOfKids, string familyComposition, string education, string periodS, string periodPo)
        {
            if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
           && costOfKids != "" && familyComposition != "" && education != "" && periodS != "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodS = periodS;
                _periodPo = periodPo;
                DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _familyComposition, _education, _periodS, _periodPo);
            }
        }

        
        /// <summary>
        /// Принемает 1 параметр
        /// </summary>
        public void DataGridFormat(string a)
        {
            if (a == "Алкогольная")
            {
                Generate_List_Alco();
                for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                {
                    alco.Add(Alco.AlcoholismPersona[i]);
                }
                DataGrid.ItemsSource = alco;
            }

            else if (a == "Наркотическая")
            {
                Generate_List_Narco();
                for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                {
                    narco.Add(Narcoman.Drug_Addiction[i]);
                }
                DataGrid.ItemsSource = narco;
            }

            else if (a == "Полизависимость")
            {
                Generate_List_Poliz();
                for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                {
                    poliz.Add(Polizavis.Alco_Narco_Person[i]);
                }
                DataGrid.ItemsSource = poliz;
            }
        }

        /// <summary>
        /// Принемает 2 параметра 
        /// </summary>
        public void DataGridFormat(string a, string b)
        {
            try
            {
                if (a == "Алкогольная")
                {
                    Generate_List_Alco();
                    if (_regionCenterBLR == b)
                    {
                        for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                        {
                            if (Alco.AlcoholismPersona[i].RegionCenterBLR == b)
                            {
                                alco.Add(Alco.AlcoholismPersona[i]);
                            }
                        }
                    }

                    else if (_sex == b)
                    {
                        for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                        {
                            if (Alco.AlcoholismPersona[i].Sex == b)
                            {
                                alco.Add(Alco.AlcoholismPersona[i]);
                            }
                        }
                    }

                    else if (_familyStatus == b)
                    {
                        for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                        {
                            if (Alco.AlcoholismPersona[i].FamilyStatus == b)
                            {
                                alco.Add(Alco.AlcoholismPersona[i]);
                            }
                        }
                    }

                    else if (_costOfKids == b)
                    {

                        for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                        {
                            if (Alco.AlcoholismPersona[i].CostOfKids == b)
                            {
                                alco.Add(Alco.AlcoholismPersona[i]);
                            }
                        }
                    }

                    else if (_familyComposition == b)
                    {

                        for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                        {
                            if (Alco.AlcoholismPersona[i].FamilyComposition == b)
                            {
                                alco.Add(Alco.AlcoholismPersona[i]);
                            }
                        }
                    }

                    else if (_education == b)
                    {
                        for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                        {
                            if (Alco.AlcoholismPersona[i].Education == b)
                            {
                                alco.Add(Alco.AlcoholismPersona[i]);
                            }
                        }
                    }

                    else if (_periodS == b)
                    {
                        for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                        {
                            string[] mas = Alco.AlcoholismPersona[i].DateOfDeregistration.Split('.', ',', '/');
                            string data = mas[2];
                            if (data == b)
                            {
                                alco.Add(Alco.AlcoholismPersona[i]);
                            }
                        }
                    }

                    else if (_periodPo == b)
                    {
                        for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                        {
                            string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split(',', '.', '/');
                            string data = mas[2];
                            if (data == b)
                            {
                                alco.Add(Alco.AlcoholismPersona[i]);
                            }
                        }
                    }

                    DataGrid.ItemsSource = alco;

                }

                else if (a == "Наркотическая")
                {
                    Generate_List_Narco();
                    if (_regionCenterBLR == b)
                    {
                        for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                        {
                            if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b)
                            {
                                narco.Add(Narcoman.Drug_Addiction[i]);
                            }
                        }
                    }

                    else if (_sex == b)
                    {
                        for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                        {
                            if (Narcoman.Drug_Addiction[i].Sex == b)
                            {
                                narco.Add(Narcoman.Drug_Addiction[i]);
                            }
                        }
                    }

                    else if (_familyStatus == b)
                    {
                        for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                        {
                            if (Narcoman.Drug_Addiction[i].FamilyStatus == b)
                            {
                                narco.Add(Narcoman.Drug_Addiction[i]);
                            }
                        }
                    }

                    else if (_costOfKids == b)
                    {
                        for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                        {
                            if (Narcoman.Drug_Addiction[i].CostOfKids == b)
                            {
                                narco.Add(Narcoman.Drug_Addiction[i]);
                            }
                        }
                    }

                    else if (_familyComposition == b)
                    {
                        for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                        {
                            if (Narcoman.Drug_Addiction[i].FamilyComposition == b)
                            {
                                narco.Add(Narcoman.Drug_Addiction[i]);
                            }
                        }
                    }

                    else if (_education == b)
                    {
                        for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                        {
                            if (Narcoman.Drug_Addiction[i].Education == b)
                            {
                                narco.Add(Narcoman.Drug_Addiction[i]);
                            }
                        }
                    }

                    else if (_periodS == b)
                    {
                        for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                        {
                            string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split(',', '.', '/');
                            string data = mas[2];
                            if (data == b)
                            {
                                narco.Add(Narcoman.Drug_Addiction[i]);
                            }
                        }
                    }

                    else if (_periodPo == b)
                    {
                        for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                        {
                            string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split(',', '.', '/');
                            string data = mas[2];
                            if (data == b)
                            {
                                narco.Add(Narcoman.Drug_Addiction[i]);
                            }
                        }
                    }

                    DataGrid.ItemsSource = narco;
                }

                else if (a == "Полизависимость")
                {
                    Generate_List_Poliz();
                    if (_regionCenterBLR == b)
                    {
                        for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                        {
                            if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b)
                            {
                                poliz.Add(Polizavis.Alco_Narco_Person[i]);
                            }
                        }
                    }

                    else if (_sex == b)
                    {
                        for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                        {
                            if (Polizavis.Alco_Narco_Person[i].Sex == b)
                            {
                                poliz.Add(Polizavis.Alco_Narco_Person[i]);
                            }
                        }
                    }

                    else if (_familyStatus == b)
                    {
                        for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                        {
                            if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b)
                            {
                                poliz.Add(Polizavis.Alco_Narco_Person[i]);
                            }
                        }
                    }

                    else if (_costOfKids == b)
                    {
                        for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                        {
                            if (Polizavis.Alco_Narco_Person[i].CostOfKids == b)
                            {
                                poliz.Add(Polizavis.Alco_Narco_Person[i]);
                            }
                        }
                    }

                    else if (_familyComposition == b)
                    {
                        for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                        {
                            if (Polizavis.Alco_Narco_Person[i].FamilyComposition == b)
                            {
                                poliz.Add(Polizavis.Alco_Narco_Person[i]);
                            }
                        }
                    }

                    else if (_education == b)
                    {
                        for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                        {
                            if (Polizavis.Alco_Narco_Person[i].Education == b)
                            {
                                poliz.Add(Polizavis.Alco_Narco_Person[i]);
                            }
                        }
                    }

                    else if (_periodS == b)
                    {
                        for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                        {
                            string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split(',', '.', '/');
                            string data = mas[2];
                            if (data == b)
                            {
                                poliz.Add(Polizavis.Alco_Narco_Person[i]);
                            }
                        }
                    }

                    else if (_periodPo == b)
                    {
                        for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                        {
                            string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split(',', '.', '/');
                            string data = mas[2];
                            if (data == b)
                            {
                                poliz.Add(Polizavis.Alco_Narco_Person[i]);
                            }
                        }
                    }

                    DataGrid.ItemsSource = poliz;

                }

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// обрабатывает 3 параметра 
        /// </summary>
        public void DataGridFormat(string a, string b, string c)
        {
            if (a == "Алкогольная")
            {
                Generate_List_Alco();
                if (_regionCenterBLR == b && _sex == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b && Alco.AlcoholismPersona[i].Sex == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b && Alco.AlcoholismPersona[i].FamilyStatus == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b && Alco.AlcoholismPersona[i].CostOfKids == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b && Alco.AlcoholismPersona[i].FamilyComposition == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b && Alco.AlcoholismPersona[i].Education == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c)
                {

                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].FamilyStatus == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c)
                {

                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].CostOfKids == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c)
                {

                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].FamilyComposition == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].Education == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && Alco.AlcoholismPersona[i].CostOfKids == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && Alco.AlcoholismPersona[i].FamilyComposition == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && Alco.AlcoholismPersona[i].Education == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c)
                {

                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].CostOfKids == b && Alco.AlcoholismPersona[i].FamilyComposition == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].CostOfKids == b && Alco.AlcoholismPersona[i].Education == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _education == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].FamilyComposition == b && Alco.AlcoholismPersona[i].Education == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_education == b)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].FamilyComposition == b)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }
                // По датам 
                else if (_regionCenterBLR == b && _periodS == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _periodPo == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _periodS == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _periodPo == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodS == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodPo == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodS == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].CostOfKids == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodPo == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].CostOfKids == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodS == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyComposition == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodPo == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyComposition == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_education == b && _periodS == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_education == b && _periodPo == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_periodS == b && _periodPo == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (data == b && data1 == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = alco;
            }

            else if (a == "Наркотическая")
            {
                Generate_List_Narco();
                if (_regionCenterBLR == b && _sex == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b && Narcoman.Drug_Addiction[i].Sex == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b && Narcoman.Drug_Addiction[i].FamilyStatus == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b && Narcoman.Drug_Addiction[i].CostOfKids == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b && Narcoman.Drug_Addiction[i].FamilyComposition == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b && Narcoman.Drug_Addiction[i].Education == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].FamilyStatus == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].CostOfKids == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].FamilyComposition == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].Education == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && Narcoman.Drug_Addiction[i].CostOfKids == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && Narcoman.Drug_Addiction[i].FamilyComposition == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && Narcoman.Drug_Addiction[i].Education == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b && Narcoman.Drug_Addiction[i].FamilyComposition == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b && Narcoman.Drug_Addiction[i].Education == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _education == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].FamilyComposition == b && Narcoman.Drug_Addiction[i].Education == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_education == b)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].FamilyComposition == b)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }
                //Используется дата 
                else if (_regionCenterBLR == b && _periodS == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _periodPo == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _periodS == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _periodPo == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodS == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodPo == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodS == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodPo == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodS == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyComposition == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodPo == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyComposition == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_education == b && _periodS == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_education == b && _periodPo == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_periodS == b && _periodPo == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (data == b && data1 == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = narco;
            }

            else if (a == "Полизависимость")
            {
                Generate_List_Poliz();
                if (_regionCenterBLR == b && _sex == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b && Polizavis.Alco_Narco_Person[i].Sex == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b && Polizavis.Alco_Narco_Person[i].FamilyStatus == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b && Polizavis.Alco_Narco_Person[i].CostOfKids == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b && Polizavis.Alco_Narco_Person[i].Education == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].FamilyStatus == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].CostOfKids == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].Education == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && Polizavis.Alco_Narco_Person[i].CostOfKids == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && Polizavis.Alco_Narco_Person[i].Education == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c)
                {

                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b && Polizavis.Alco_Narco_Person[i].Education == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _education == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].FamilyComposition == b && Polizavis.Alco_Narco_Person[i].Education == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }
                //по дате 
                else if (_regionCenterBLR == b && _periodS == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _periodPo == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _periodS == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _periodPo == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodS == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodPo == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodS == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodPo == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodS == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyComposition == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodPo == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyComposition == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_education == b && _periodS == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_education == b && _periodPo == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_periodS == b && _periodPo == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (data == b && data1 == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = poliz;
            }
        }

        /// <summary>
        /// Принемает 4 параметра  
        /// </summary>
        public void DataGridFormat(string a, string b, string c, string d)
        {
            if (a == "Алкогольная")
            {
                Generate_List_Alco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _education == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].Education == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _familyComposition == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _education == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].Education == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].Education == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].FamilyComposition == c
                            && Alco.AlcoholismPersona[i].Education == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _education == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].Education == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].Education == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyComposition == c
                            && Alco.AlcoholismPersona[i].Education == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].Education == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b
                            && Alco.AlcoholismPersona[i].FamilyComposition == c
                            && Alco.AlcoholismPersona[i].Education == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].CostOfKids == b
                            && Alco.AlcoholismPersona[i].FamilyComposition == c
                            && Alco.AlcoholismPersona[i].Education == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                // Дата----------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b && Alco.AlcoholismPersona[i].Sex == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b && Alco.AlcoholismPersona[i].FamilyStatus == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b && Alco.AlcoholismPersona[i].CostOfKids == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b && Alco.AlcoholismPersona[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b && Alco.AlcoholismPersona[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b && Alco.AlcoholismPersona[i].Education == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b && Alco.AlcoholismPersona[i].Education == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                //-----------------------------------------------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].FamilyStatus == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].FamilyStatus == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].CostOfKids == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].CostOfKids == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].Education == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].Education == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && Alco.AlcoholismPersona[i].CostOfKids == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && Alco.AlcoholismPersona[i].CostOfKids == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && Alco.AlcoholismPersona[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && Alco.AlcoholismPersona[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && Alco.AlcoholismPersona[i].Education == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && Alco.AlcoholismPersona[i].Education == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                //----------------------------------------------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].CostOfKids == b && Alco.AlcoholismPersona[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].CostOfKids == b && Alco.AlcoholismPersona[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].CostOfKids == b && Alco.AlcoholismPersona[i].Education == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].CostOfKids == b && Alco.AlcoholismPersona[i].Education == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }
                //-----------------------------------------------------------------------------------------------------------------------------------------------
                else if (_familyComposition == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyComposition == b && Alco.AlcoholismPersona[i].Education == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyComposition == b && Alco.AlcoholismPersona[i].Education == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }
                //----------------------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b && data == c && data1 == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].Sex == b && data == c && data1 == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && data == c && data1 == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].CostOfKids == b && data == c && data1 == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].FamilyComposition == b && data == c && data1 == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_education == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].Education == b && data == c && data1 == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = alco;
            }

            else if (a == "Наркотическая")
            {
                Generate_List_Narco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _education == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].Education == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _familyComposition == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _education == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].Education == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].Education == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].FamilyComposition == c
                            && Narcoman.Drug_Addiction[i].Education == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _education == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].Education == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].Education == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyComposition == c
                            && Narcoman.Drug_Addiction[i].Education == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].Education == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b
                            && Narcoman.Drug_Addiction[i].FamilyComposition == c
                            && Narcoman.Drug_Addiction[i].Education == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b
                            && Narcoman.Drug_Addiction[i].FamilyComposition == c
                            && Narcoman.Drug_Addiction[i].Education == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                // Дата----------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && Narcoman.Drug_Addiction[i].Sex == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && Narcoman.Drug_Addiction[i].Sex == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && Narcoman.Drug_Addiction[i].FamilyStatus == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && Narcoman.Drug_Addiction[i].FamilyStatus == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && Narcoman.Drug_Addiction[i].CostOfKids == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && Narcoman.Drug_Addiction[i].CostOfKids == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && Narcoman.Drug_Addiction[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && Narcoman.Drug_Addiction[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && Narcoman.Drug_Addiction[i].Education == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && Narcoman.Drug_Addiction[i].Education == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                //-----------------------------------------------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].FamilyStatus == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].FamilyStatus == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].CostOfKids == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].CostOfKids == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].Education == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].Education == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && Narcoman.Drug_Addiction[i].CostOfKids == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && Narcoman.Drug_Addiction[i].CostOfKids == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && Narcoman.Drug_Addiction[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && Narcoman.Drug_Addiction[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && Narcoman.Drug_Addiction[i].Education == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && Narcoman.Drug_Addiction[i].Education == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                //----------------------------------------------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b && Narcoman.Drug_Addiction[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b && Narcoman.Drug_Addiction[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b && Narcoman.Drug_Addiction[i].Education == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b && Narcoman.Drug_Addiction[i].Education == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }
                //-----------------------------------------------------------------------------------------------------------------------------------------------
                else if (_familyComposition == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyComposition == b && Narcoman.Drug_Addiction[i].Education == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyComposition == b && Narcoman.Drug_Addiction[i].Education == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }
                //----------------------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b && data == c && data1 == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b && data == c && data1 == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && data == c && data1 == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b && data == c && data1 == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].FamilyComposition == b && data == c && data1 == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_education == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && data == c && data1 == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = narco;
            }

            else if (a == "Полизависимость")
            {
                Generate_List_Poliz();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _education == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].Education == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _familyComposition == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _education == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].Education == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].Education == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == c
                            && Polizavis.Alco_Narco_Person[i].Education == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _education == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].Education == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].Education == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == c
                            && Polizavis.Alco_Narco_Person[i].Education == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].Education == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == c
                            && Polizavis.Alco_Narco_Person[i].Education == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == c
                            && Polizavis.Alco_Narco_Person[i].Education == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                // Дата----------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && Polizavis.Alco_Narco_Person[i].Sex == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && Polizavis.Alco_Narco_Person[i].Sex == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && Polizavis.Alco_Narco_Person[i].FamilyStatus == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && Polizavis.Alco_Narco_Person[i].FamilyStatus == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && Polizavis.Alco_Narco_Person[i].CostOfKids == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && Polizavis.Alco_Narco_Person[i].CostOfKids == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && Polizavis.Alco_Narco_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && Polizavis.Alco_Narco_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                //-----------------------------------------------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].FamilyStatus == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].FamilyStatus == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].CostOfKids == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].CostOfKids == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && Polizavis.Alco_Narco_Person[i].CostOfKids == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && Polizavis.Alco_Narco_Person[i].CostOfKids == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && Polizavis.Alco_Narco_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && Polizavis.Alco_Narco_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                //----------------------------------------------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b && Polizavis.Alco_Narco_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b && Polizavis.Alco_Narco_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }
                //-----------------------------------------------------------------------------------------------------------------------------------------------
                else if (_familyComposition == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyComposition == b && Polizavis.Alco_Narco_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyComposition == b && Polizavis.Alco_Narco_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }
                //----------------------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b && data == c && data1 == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && data == c && data1 == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && data == c && data1 == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b && data == c && data1 == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyComposition == b && data == c && data1 == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_education == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && data == c && data1 == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }
                DataGrid.ItemsSource = poliz;
            }
        }

        /// <summary>
        /// Принемает 5 параметров 
        /// </summary>
        public void DataGridFormat(string a, string b, string c, string d, string e)
        {
            if (a == "Алкогольная")
            {
                Generate_List_Alco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].CostOfKids == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].Education == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].Education == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && Alco.AlcoholismPersona[i].Education == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].Education == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && Alco.AlcoholismPersona[i].Education == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && Alco.AlcoholismPersona[i].Education == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].Education == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && Alco.AlcoholismPersona[i].Education == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && Alco.AlcoholismPersona[i].Education == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && Alco.AlcoholismPersona[i].Education == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                //дата -------------------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && data == d
                            && data1 == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }

                }
                //-----------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && data == d
                            && data1 == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }

                }
                //------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }

                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }

                }

                else if (_familyStatus == b && _costOfKids == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }

                }

                else if (_familyStatus == b && _costOfKids == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }

                }

                else if (_familyStatus == b && _costOfKids == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && data == d
                            && data1 == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }

                }
                //-----------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].CostOfKids == b
                            && Alco.AlcoholismPersona[i].FamilyComposition == c
                            && Alco.AlcoholismPersona[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }

                }

                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].CostOfKids == b
                            && Alco.AlcoholismPersona[i].FamilyComposition == c
                            && Alco.AlcoholismPersona[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].CostOfKids == b
                            && Alco.AlcoholismPersona[i].FamilyComposition == c
                            && data == d
                            && data1 == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }
                //-----------------------------------------------------------------------------------------------------------------------------------
                else if (_familyComposition == b && _education == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].FamilyComposition == b
                            && Alco.AlcoholismPersona[i].Education == c
                            && data == d
                            && data1 == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }
                DataGrid.ItemsSource = alco;

            }

            else if (a == "Наркотическая")
            {
                Generate_List_Narco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].CostOfKids == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].Education == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].Education == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && Narcoman.Drug_Addiction[i].Education == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].Education == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _familyStatus == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && Narcoman.Drug_Addiction[i].Education == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && Narcoman.Drug_Addiction[i].Education == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].Education == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && Narcoman.Drug_Addiction[i].Education == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_sex == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && Narcoman.Drug_Addiction[i].Education == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && Narcoman.Drug_Addiction[i].Education == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                //дата -------------------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && data == d
                            && data1 == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }
                //-----------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && data == d
                            && data1 == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }
                //------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_familyStatus == b && _costOfKids == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_familyStatus == b && _costOfKids == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_familyStatus == b && _costOfKids == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && data == d
                            && data1 == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }
                //-----------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b
                            && Narcoman.Drug_Addiction[i].FamilyComposition == c
                            && Narcoman.Drug_Addiction[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b
                            && Narcoman.Drug_Addiction[i].FamilyComposition == c
                            && Narcoman.Drug_Addiction[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }

                else if (_costOfKids == b && _familyComposition == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b
                            && Narcoman.Drug_Addiction[i].FamilyComposition == c
                            && data == d
                            && data1 == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }
                //-----------------------------------------------------------------------------------------------------------------------------------
                else if (_familyComposition == b && _education == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].FamilyComposition == b
                            && Narcoman.Drug_Addiction[i].Education == c
                            && data == d
                            && data1 == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }

                }
                DataGrid.ItemsSource = narco;
            }

            else if (a == "Полизависимость")
            {
                Generate_List_Poliz();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                    DataGrid.ItemsSource = poliz;
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].Education == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].Education == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && Polizavis.Alco_Narco_Person[i].Education == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].Education == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _familyStatus == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && Polizavis.Alco_Narco_Person[i].Education == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && Polizavis.Alco_Narco_Person[i].Education == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].Education == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && Polizavis.Alco_Narco_Person[i].Education == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_sex == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && Polizavis.Alco_Narco_Person[i].Education == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && Polizavis.Alco_Narco_Person[i].Education == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                //дата -------------------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && data == d
                            && data1 == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }
                //-----------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && data == d
                            && data1 == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }
                //------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_familyStatus == b && _costOfKids == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_familyStatus == b && _costOfKids == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_familyStatus == b && _costOfKids == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && data == d
                            && data1 == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }
                //-----------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == c
                            && Polizavis.Alco_Narco_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == c
                            && Polizavis.Alco_Narco_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }

                }

                else if (_costOfKids == b && _familyComposition == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == c
                            && data == d
                            && data1 == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }
                //-----------------------------------------------------------------------------------------------------------------------------------
                else if (_familyComposition == b && _education == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyComposition == b
                            && Polizavis.Alco_Narco_Person[i].Education == c
                            && data == d
                            && data1 == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }
                DataGrid.ItemsSource = poliz;
            }


        }

        /// <summary>
        /// Принемает 6 параметров
        /// </summary>
        public void DataGridFormat(string a, string b, string c, string d, string e, string f)
        {
            if (a == "Алкогольная")
            {
                Generate_List_Alco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].CostOfKids == e
                            && Alco.AlcoholismPersona[i].FamilyComposition == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _education == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].CostOfKids == e
                            && Alco.AlcoholismPersona[i].Education == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e
                            && Alco.AlcoholismPersona[i].Education == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }

                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e
                            && Alco.AlcoholismPersona[i].Education == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e
                            && Alco.AlcoholismPersona[i].Education == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e
                            && Alco.AlcoholismPersona[i].Education == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }
                //дата ------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _periodS == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].CostOfKids == e
                            && data == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].CostOfKids == e
                            && data == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _periodS == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e
                            && data == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e
                            && data == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].Education == e
                            && data == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].Education == e
                            && data == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {

                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && data == e
                            && data1 == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _periodS == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e
                            && data == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e
                            && data == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].Education == e
                            && data == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].Education == e
                            && data == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && data == e
                            && data1 == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && Alco.AlcoholismPersona[i].Education == e
                            && data == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].CostOfKids == b
                            && Alco.AlcoholismPersona[i].FamilyComposition == c
                            && Alco.AlcoholismPersona[i].Education == d
                            && data == e
                            && data1 == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = alco;
            }

            else if (a == "Наркотическая")
            {
                Generate_List_Narco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].CostOfKids == e
                            && Narcoman.Drug_Addiction[i].FamilyComposition == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _education == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].CostOfKids == e
                            && Narcoman.Drug_Addiction[i].Education == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e
                            && Narcoman.Drug_Addiction[i].Education == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e
                            && Narcoman.Drug_Addiction[i].Education == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e
                            && Narcoman.Drug_Addiction[i].Education == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e
                            && Narcoman.Drug_Addiction[i].Education == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }
                //дата ---------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _periodS == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].CostOfKids == e
                            && data == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _periodPo == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].CostOfKids == e
                            && data == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _periodS == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e
                            && data == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _periodPo == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e
                            && data == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].Education == e
                            && data == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e && _periodPo == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].Education == e
                            && data == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {

                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && data == e
                            && data1 == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _periodS == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e
                            && data == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _periodPo == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e
                            && data == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].Education == e
                            && data == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e && _periodPo == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].Education == e
                            && data == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && data == e
                            && data1 == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && Narcoman.Drug_Addiction[i].Education == e
                            && data == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }
                //------------------------------------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b
                            && Narcoman.Drug_Addiction[i].FamilyComposition == c
                            && Narcoman.Drug_Addiction[i].Education == d
                            && data == e
                            && data1 == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = narco;
            }

            else if (a == "Полизависимость")
            {
                Generate_List_Poliz();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == e
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _education == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == e
                            && Polizavis.Alco_Narco_Person[i].Education == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e
                            && Polizavis.Alco_Narco_Person[i].Education == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e
                            && Polizavis.Alco_Narco_Person[i].Education == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e
                            && Polizavis.Alco_Narco_Person[i].Education == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e
                            && Polizavis.Alco_Narco_Person[i].Education == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }
                //Дата-------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _periodS == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == e
                            && data == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _periodPo == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == e
                            && data == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _periodS == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e
                            && data == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _periodPo == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e
                            && data == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].Education == e
                            && data == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e && _periodPo == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].Education == e
                            && data == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {

                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && data == e
                            && data1 == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _periodS == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e
                            && data == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _periodPo == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e
                            && data == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].Education == e
                            && data == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e && _periodPo == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].Education == e
                            && data == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && data == e
                            && data1 == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && Polizavis.Alco_Narco_Person[i].Education == e
                            && data == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }
                //------------------------------------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == c
                            && Polizavis.Alco_Narco_Person[i].Education == d
                            && data == e
                            && data1 == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = poliz;

            }
        }

        /// <summary>
        /// принемает 7 параметров 
        /// </summary>
        public void DataGridFormat(string a, string b, string c, string d, string e, string f, string g)
        {
            if (a == "Алкогольная")
            {
                Generate_List_Alco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].CostOfKids == e
                            && Alco.AlcoholismPersona[i].FamilyComposition == f
                            && Alco.AlcoholismPersona[i].Education == g)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _periodS == g)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].CostOfKids == e
                            && Alco.AlcoholismPersona[i].FamilyComposition == f
                            && data == g)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _periodPo == g)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].CostOfKids == e
                            && Alco.AlcoholismPersona[i].FamilyComposition == f
                            && data == g)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = alco;
            }

            else if (a == "Наркотическая")
            {
                Generate_List_Narco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].CostOfKids == e
                            && Narcoman.Drug_Addiction[i].FamilyComposition == f
                            && Narcoman.Drug_Addiction[i].Education == g)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _periodS == g)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].CostOfKids == e
                            && Narcoman.Drug_Addiction[i].FamilyComposition == f
                            && data == g)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _periodPo == g)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].CostOfKids == e
                            && Narcoman.Drug_Addiction[i].FamilyComposition == f
                            && data == g)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = narco;
            }

            else if (a == "Полизависимость")
            {
                Generate_List_Poliz();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == e
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == f
                            && Polizavis.Alco_Narco_Person[i].Education == g)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _periodS == g)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == e
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == f
                            && data == g)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _periodPo == g)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == e
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == f
                            && data == g)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = poliz;
            }
        }

        /// <summary>
        /// Принемает 8 параметров 
        /// </summary>
        public void DataGridFormat(string a, string b, string c, string d, string e, string f, string g, string h)
        {
            if (a == "Алкогольная")
            {
                Generate_List_Alco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g && _periodS == h)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].CostOfKids == e
                            && Alco.AlcoholismPersona[i].FamilyComposition == f
                            && Alco.AlcoholismPersona[i].Education == g
                            && data == h)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g && _periodPo == h)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].CostOfKids == e
                            && Alco.AlcoholismPersona[i].FamilyComposition == f
                            && Alco.AlcoholismPersona[i].Education == g
                            && data == h)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = alco;
            }

            else if (a == "Наркотическая")
            {
                Generate_List_Narco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g && _periodS == h)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].CostOfKids == e
                            && Narcoman.Drug_Addiction[i].FamilyComposition == f
                            && Narcoman.Drug_Addiction[i].Education == g
                            && data == h)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g && _periodPo == h)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].CostOfKids == e
                            && Narcoman.Drug_Addiction[i].FamilyComposition == f
                            && Narcoman.Drug_Addiction[i].Education == g
                            && data == h)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = narco;
            }

            else if (a == "Полизависимость")
            {
                Generate_List_Poliz();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g && _periodS == h)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == e
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == f
                            && Polizavis.Alco_Narco_Person[i].Education == g
                            && data == h)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g && _periodPo == h)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == e
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == f
                            && Polizavis.Alco_Narco_Person[i].Education == g
                            && data == h)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = poliz;
            }
        }

        /// <summary>
        /// Принемает 9 параметров 
        /// </summary>
        public void DataGridFormat(string a, string b, string c, string d, string e, string f, string g, string h, string k)
        {
            if (a == "Алкогольная")
            {
                Generate_List_Alco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g && _periodS == h && _periodPo == k)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].CostOfKids == e
                            && Alco.AlcoholismPersona[i].FamilyComposition == f
                            && Alco.AlcoholismPersona[i].Education == g
                            && data == h
                            && data1 == k)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = alco;
            }

            else if (a == "Наркотическая")
            {
                Generate_List_Narco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g && _periodS == h && _periodPo == k)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].CostOfKids == e
                            && Narcoman.Drug_Addiction[i].FamilyComposition == f
                            && Narcoman.Drug_Addiction[i].Education == g
                            && data == h
                            && data1 == k)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = narco;
            }

            else if (a == "Полизависимость")
            {
                Generate_List_Poliz();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g && _periodS == h && _periodPo == k)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == e
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == f
                            && Polizavis.Alco_Narco_Person[i].Education == g
                            && data == h
                            && data1 == k)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = poliz;
            }
        }
        /// <summary>
        /// клавиша назад
        /// </summary>
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (db != null) db.Dispose();
                Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// клавиша сформировать отчет 
        /// </summary>
        private void Excel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool close = false;
                //сформировать отчет по алкогольной зависимости
                if (_typeOfAddiction == "Алкогольная")
                {
                    ExcelDataServis.Save_Report_Excel_Alco(alco);
                    close = true;
                }
                //сформировать отчет по наркозависимости
                else if (_typeOfAddiction == "Наркотическая")
                {
                    ExcelDataServis.Save_Report_Excel_Narco(narco);
                    close = true;
                }
                //сформировать отчет по полизависимости
                else if (_typeOfAddiction == "Полизависимость")
                {
                    ExcelDataServis.Save_Report_Excel_Poliz(poliz);
                    close = true;
                }
                if (!close)
                {
                    MessageBox.Show("Создайте отчет перед тем как выгрузить в Excel фаил");
                }
                else
                {
                    if (db != null) db.Dispose();
                    Close();
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

    }
}