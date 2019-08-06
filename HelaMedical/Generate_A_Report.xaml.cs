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

        public List<Alco> alco = new List<Alco>();
        public List<Alco> Alco_Person = new List<Alco>();

        public List<Narcoman> narco = new List<Narcoman>();
        public List<Narcoman> Narco_Person = new List<Narcoman>();

        public List<Polizavis> poliz = new List<Polizavis>();
        public List<Polizavis> Poliz_Person = new List<Polizavis>();

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
        /// Преводим из бд в список 
        /// </summary>
        public void Generate_List_Alco()
        {
            try
            {
                db = new ApplicationContext();
                db.Alcos.Load();
                foreach (var AlcoPer in db.Alcos)
                {
                    Alco_Person.Add(AlcoPer);
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// Преводим из бд в список 
        /// </summary>
        public void Generate_List_Narco()
        {
            try
            {
                db = new ApplicationContext();
                db.Alcos.Load();
                foreach (var Narco in db.Narcomans)
                {
                    Narco_Person.Add(Narco);
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// Преводим из бд в список 
        /// </summary>
        public void Generate_List_Poliz()
        {
            try
            {
                db = new ApplicationContext();
                db.Polizaviss.Load();
                foreach (var Polis in db.Polizaviss)
                {
                    Poliz_Person.Add(Polis);
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    MessageBox.Show(" Все поля пустые");
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
        /// <param name="typeOfAddiction"></param>
        /// <param name="regionCenterBLR"></param>
        /// <param name="sex"></param>
        /// <param name="familyStatus"></param>
        /// <param name="costOfKids"></param>
        /// <param name="familyComposition"></param>
        /// <param name="education"></param>
        /// <param name="periodS"></param>
        /// <param name="periodPo"></param>
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
        /// <param name="typeOfAddiction"></param>
        /// <param name="regionCenterBLR"></param>
        /// <param name="sex"></param>
        /// <param name="familyStatus"></param>
        /// <param name="costOfKids"></param>
        /// <param name="familyComposition"></param>
        /// <param name="education"></param>
        /// <param name="periodS"></param>
        /// <param name="periodPo"></param>
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
        /// <param name="typeOfAddiction"></param>
        /// <param name="regionCenterBLR"></param>
        /// <param name="sex"></param>
        /// <param name="familyStatus"></param>
        /// <param name="costOfKids"></param>
        /// <param name="familyComposition"></param>
        /// <param name="education"></param>
        /// <param name="periodS"></param>
        /// <param name="periodPo"></param>
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
        /// <param name="typeOfAddiction"></param>
        /// <param name="regionCenterBLR"></param>
        /// <param name="sex"></param>
        /// <param name="familyStatus"></param>
        /// <param name="costOfKids"></param>
        /// <param name="familyComposition"></param>
        /// <param name="education"></param>
        /// <param name="periodS"></param>
        /// <param name="periodPo"></param>
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
        /// <param name="typeOfAddiction"></param>
        /// <param name="regionCenterBLR"></param>
        /// <param name="sex"></param>
        /// <param name="familyStatus"></param>
        /// <param name="costOfKids"></param>
        /// <param name="familyComposition"></param>
        /// <param name="education"></param>
        /// <param name="periodS"></param>
        /// <param name="periodPo"></param>
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
        /// <param name="typeOfAddiction"></param>
        /// <param name="regionCenterBLR"></param>
        /// <param name="sex"></param>
        /// <param name="familyStatus"></param>
        /// <param name="costOfKids"></param>
        /// <param name="familyComposition"></param>
        /// <param name="education"></param>
        /// <param name="periodS"></param>
        /// <param name="periodPo"></param>
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
        /// <param name="typeOfAddiction"></param>
        /// <param name="regionCenterBLR"></param>
        /// <param name="sex"></param>
        /// <param name="familyStatus"></param>
        /// <param name="costOfKids"></param>
        /// <param name="familyComposition"></param>
        /// <param name="education"></param>
        /// <param name="periodS"></param>
        /// <param name="periodPo"></param>
        public void Eight_Params(string typeOfAddiction, string regionCenterBLR, string sex, string familyStatus, string costOfKids, string familyComposition, string education, string periodS, string periodPo)
        { }

        /// <summary>
        /// передает 9 параметров пока не дописан 
        /// </summary>
        /// <param name="typeOfAddiction"></param>
        /// <param name="regionCenterBLR"></param>
        /// <param name="sex"></param>
        /// <param name="familyStatus"></param>
        /// <param name="costOfKids"></param>
        /// <param name="familyComposition"></param>
        /// <param name="education"></param>
        /// <param name="periodS"></param>
        /// <param name="periodPo"></param>
        public void Nine_Params(string typeOfAddiction, string regionCenterBLR, string sex, string familyStatus, string costOfKids, string familyComposition, string education, string periodS, string periodPo)
        { }

        /// <summary>
        /// Принемает 1 параметр
        /// </summary>
        public void DataGridFormat(string a)
        {
            if (a == "Алкогольная")
            {
                db = new ApplicationContext();
                db.Alcos.Load();

                foreach (var alcos in db.Alcos)
                {
                    alco.Add(alcos);
                }
                DataGrid.ItemsSource = alco;
            }

            else if (a == "Наркотическая")
            {
                db.Narcomans.Load();
                foreach (var narcos in db.Narcomans)
                {
                    narco.Add(narcos);
                }
                DataGrid.ItemsSource = narco;
            }

            else if (a == "Полизависимость")
            {
                db.Polizaviss.Load();
                foreach (var polizs in db.Polizaviss)
                {
                    poliz.Add(polizs);
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
                        for (int i = 0; i < Alco_Person.Count; i++)
                        {
                            if (Alco_Person[i].RegionCenterBLR == b)
                            {
                                alco.Add(Alco_Person[i]);
                            }
                        }
                    }

                    else if (_sex == b)
                    {
                        for (int i = 0; i < Alco_Person.Count; i++)
                        {
                            if (Alco_Person[i].Sex == b)
                            {
                                alco.Add(Alco_Person[i]);
                            }
                        }
                    }

                    else if (_familyStatus == b)
                    {
                        for (int i = 0; i < Alco_Person.Count; i++)
                        {
                            if (Alco_Person[i].FamilyStatus == b)
                            {
                                alco.Add(Alco_Person[i]);
                            }
                        }
                    }

                    else if (_costOfKids == b)
                    {

                        for (int i = 0; i < Alco_Person.Count; i++)
                        {
                            if (Alco_Person[i].CostOfKids == b)
                            {
                                alco.Add(Alco_Person[i]);
                            }
                        }
                    }

                    else if (_familyComposition == b)
                    {

                        for (int i = 0; i < Alco_Person.Count; i++)
                        {
                            if (Alco_Person[i].FamilyComposition == b)
                            {
                                alco.Add(Alco_Person[i]);
                            }
                        }
                    }

                    else if (_education == b)
                    {
                        for (int i = 0; i < Alco_Person.Count; i++)
                        {
                            if (Alco_Person[i].Education == b)
                            {
                                alco.Add(Alco_Person[i]);
                            }
                        }
                    }

                    else if (_periodS == b)
                    {
                        for (int i = 0; i < Alco_Person.Count; i++)
                        {
                            string[] mas = Alco_Person[i].DateOfDeregistration.Split('.', ',', '/');
                            string data = mas[2];
                            if (data == b)
                            {
                                alco.Add(Alco_Person[i]);
                            }
                        }
                    }

                    else if (_periodPo == b)
                    {
                        for (int i = 0; i < Alco_Person.Count; i++)
                        {
                            string[] mas = Alco_Person[i].DateOfDead.Split(',', '.', '/');
                            string data = mas[2];
                            if (data == b)
                            {
                                alco.Add(Alco_Person[i]);
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
                        for (int i = 0; i < Narco_Person.Count; i++)
                        {
                            if (Narco_Person[i].RegionCenterBLR == b)
                            {
                                narco.Add(Narco_Person[i]);
                            }
                        }
                    }

                    else if (_sex == b)
                    {
                        for (int i = 0; i < Narco_Person.Count; i++)
                        {
                            if (Narco_Person[i].Sex == b)
                            {
                                narco.Add(Narco_Person[i]);
                            }
                        }
                    }

                    else if (_familyStatus == b)
                    {
                        for (int i = 0; i < Narco_Person.Count; i++)
                        {
                            if (Narco_Person[i].FamilyStatus == b)
                            {
                                narco.Add(Narco_Person[i]);
                            }
                        }
                    }

                    else if (_costOfKids == b)
                    {
                        for (int i = 0; i < Narco_Person.Count; i++)
                        {
                            if (Narco_Person[i].CostOfKids == b)
                            {
                                narco.Add(Narco_Person[i]);
                            }
                        }
                    }

                    else if (_familyComposition == b)
                    {
                        for (int i = 0; i < Narco_Person.Count; i++)
                        {
                            if (Narco_Person[i].FamilyComposition == b)
                            {
                                narco.Add(Narco_Person[i]);
                            }
                        }
                    }

                    else if (_education == b)
                    {
                        for (int i = 0; i < Narco_Person.Count; i++)
                        {
                            if (Narco_Person[i].Education == b)
                            {
                                narco.Add(Narco_Person[i]);
                            }
                        }
                    }

                    else if (_periodS == b)
                    {
                        for (int i = 0; i < Narco_Person.Count; i++)
                        {
                            string[] mas = Narco_Person[i].DataOfRegistration.Split(',', '.', '/');
                            string data = mas[2];
                            if (data == b)
                            {
                                narco.Add(Narco_Person[i]);
                            }
                        }
                    }

                    else if (_periodPo == b)
                    {
                        for (int i = 0; i < Narco_Person.Count; i++)
                        {
                            string[] mas = Narco_Person[i].DateOfDead.Split(',', '.', '/');
                            string data = mas[2];
                            if (data == b)
                            {
                                narco.Add(Narco_Person[i]);
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
                        for (int i = 0; i < Poliz_Person.Count; i++)
                        {
                            if (Poliz_Person[i].RegionCenterBLR == b)
                            {
                                poliz.Add(Poliz_Person[i]);
                            }
                        }
                    }

                    else if (_sex == b)
                    {
                        for (int i = 0; i < Poliz_Person.Count; i++)
                        {
                            if (Poliz_Person[i].Sex == b)
                            {
                                poliz.Add(Poliz_Person[i]);
                            }
                        }
                    }

                    else if (_familyStatus == b)
                    {
                        for (int i = 0; i < Poliz_Person.Count; i++)
                        {
                            if (Poliz_Person[i].FamilyStatus == b)
                            {
                                poliz.Add(Poliz_Person[i]);
                            }
                        }
                    }

                    else if (_costOfKids == b)
                    {
                        for (int i = 0; i < Poliz_Person.Count; i++)
                        {
                            if (Poliz_Person[i].CostOfKids == b)
                            {
                                poliz.Add(Poliz_Person[i]);
                            }
                        }
                    }

                    else if (_familyComposition == b)
                    {
                        for (int i = 0; i < Poliz_Person.Count; i++)
                        {
                            if (Poliz_Person[i].FamilyComposition == b)
                            {
                                poliz.Add(Poliz_Person[i]);
                            }
                        }
                    }

                    else if (_education == b)
                    {
                        for (int i = 0; i < Poliz_Person.Count; i++)
                        {
                            if (Poliz_Person[i].Education == b)
                            {
                                poliz.Add(Poliz_Person[i]);
                            }
                        }
                    }

                    else if (_periodS == b)
                    {
                        for (int i = 0; i < Poliz_Person.Count; i++)
                        {
                            string[] mas = Poliz_Person[i].DataOfRegistration.Split(',', '.', '/');
                            string data = mas[2];
                            if (data == b)
                            {
                                poliz.Add(Poliz_Person[i]);
                            }
                        }
                    }

                    else if (_periodPo == b)
                    {
                        for (int i = 0; i < Poliz_Person.Count; i++)
                        {
                            string[] mas = Poliz_Person[i].DateOfDead.Split(',', '.', '/');
                            string data = mas[2];
                            if (data == b)
                            {
                                poliz.Add(Poliz_Person[i]);
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
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b && Alco_Person[i].Sex == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b && Alco_Person[i].FamilyStatus == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b && Alco_Person[i].CostOfKids == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b && Alco_Person[i].FamilyComposition == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b && Alco_Person[i].Education == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c)
                {

                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].Sex == b && Alco_Person[i].FamilyStatus == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c)
                {

                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].Sex == b && Alco_Person[i].CostOfKids == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c)
                {

                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].Sex == b && Alco_Person[i].FamilyComposition == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].Sex == b && Alco_Person[i].Education == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].FamilyStatus == b && Alco_Person[i].CostOfKids == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].FamilyStatus == b && Alco_Person[i].FamilyComposition == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].FamilyStatus == b && Alco_Person[i].Education == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c)
                {

                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].CostOfKids == b && Alco_Person[i].FamilyComposition == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].CostOfKids == b && Alco_Person[i].Education == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _education == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].FamilyComposition == b && Alco_Person[i].Education == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_education == b)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].FamilyComposition == b)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }
                // По датам 
                else if (_regionCenterBLR == b && _periodS == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b && data == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _periodPo == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b && data == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _periodS == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Sex == b && data == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _periodPo == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Sex == b && data == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodS == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].FamilyStatus == b && data == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodPo == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].FamilyStatus == b && data == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodS == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].CostOfKids == b && data == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodPo == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].CostOfKids == b && data == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodS == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].FamilyComposition == b && data == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodPo == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].FamilyComposition == b && data == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_education == b && _periodS == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Education == b && data == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_education == b && _periodPo == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Education == b && data == c)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_periodS == b && _periodPo == c)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (data == b && data1 == c)
                        {
                            alco.Add(Alco_Person[i]);
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
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b && Narco_Person[i].Sex == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b && Narco_Person[i].FamilyStatus == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b && Narco_Person[i].CostOfKids == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b && Narco_Person[i].FamilyComposition == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b && Narco_Person[i].Education == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].Sex == b && Narco_Person[i].FamilyStatus == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].Sex == b && Narco_Person[i].CostOfKids == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].Sex == b && Narco_Person[i].FamilyComposition == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].Sex == b && Narco_Person[i].Education == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].FamilyStatus == b && Narco_Person[i].CostOfKids == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].FamilyStatus == b && Narco_Person[i].FamilyComposition == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].FamilyStatus == b && Narco_Person[i].Education == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].CostOfKids == b && Narco_Person[i].FamilyComposition == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].CostOfKids == b && Narco_Person[i].Education == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _education == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].FamilyComposition == b && Narco_Person[i].Education == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_education == b)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].FamilyComposition == b)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }
                //Используется дата 
                else if (_regionCenterBLR == b && _periodS == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b && data == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _periodPo == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b && data == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _periodS == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Sex == b && data == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _periodPo == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Sex == b && data == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodS == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].FamilyStatus == b && data == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodPo == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].FamilyStatus == b && data == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodS == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].CostOfKids == b && data == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodPo == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].CostOfKids == b && data == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodS == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].FamilyComposition == b && data == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodPo == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].FamilyComposition == b && data == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_education == b && _periodS == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Education == b && data == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_education == b && _periodPo == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Education == b && data == c)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_periodS == b && _periodPo == c)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (data == b && data1 == c)
                        {
                            narco.Add(Narco_Person[i]);
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
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b && Poliz_Person[i].Sex == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b && Poliz_Person[i].FamilyStatus == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b && Poliz_Person[i].CostOfKids == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b && Poliz_Person[i].FamilyComposition == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b && Poliz_Person[i].Education == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].Sex == b && Poliz_Person[i].FamilyStatus == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].Sex == b && Poliz_Person[i].CostOfKids == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].Sex == b && Poliz_Person[i].FamilyComposition == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].Sex == b && Poliz_Person[i].Education == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].FamilyStatus == b && Poliz_Person[i].CostOfKids == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].FamilyStatus == b && Poliz_Person[i].FamilyComposition == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].FamilyStatus == b && Poliz_Person[i].Education == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c)
                {

                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].CostOfKids == b && Poliz_Person[i].FamilyComposition == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].CostOfKids == b && Poliz_Person[i].Education == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _education == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].FamilyComposition == b && Poliz_Person[i].Education == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }
                //по дате 
                else if (_regionCenterBLR == b && _periodS == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b && data == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _periodPo == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b && data == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _periodS == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Sex == b && data == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _periodPo == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Sex == b && data == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodS == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].FamilyStatus == b && data == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodPo == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].FamilyStatus == b && data == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodS == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].CostOfKids == b && data == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodPo == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].CostOfKids == b && data == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodS == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].FamilyComposition == b && data == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodPo == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].FamilyComposition == b && data == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_education == b && _periodS == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Education == b && data == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_education == b && _periodPo == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Education == b && data == c)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_periodS == b && _periodPo == c)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (data == b && data1 == c)
                        {
                            poliz.Add(Poliz_Person[i]);
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
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyStatus == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].CostOfKids == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyComposition == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _education == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].Education == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].CostOfKids == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _familyComposition == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].FamilyComposition == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _education == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].Education == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].CostOfKids == c
                            && Alco_Person[i].FamilyComposition == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].CostOfKids == c
                            && Alco_Person[i].Education == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].FamilyComposition == c
                            && Alco_Person[i].Education == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].CostOfKids == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].FamilyComposition == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _education == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].Education == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].CostOfKids == c
                            && Alco_Person[i].FamilyComposition == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].CostOfKids == c
                            && Alco_Person[i].Education == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].FamilyComposition == c
                            && Alco_Person[i].Education == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].FamilyStatus == b
                            && Alco_Person[i].CostOfKids == c
                            && Alco_Person[i].FamilyComposition == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].FamilyStatus == b
                            && Alco_Person[i].CostOfKids == c
                            && Alco_Person[i].Education == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].FamilyStatus == b
                            && Alco_Person[i].FamilyComposition == c
                            && Alco_Person[i].Education == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].CostOfKids == b
                            && Alco_Person[i].FamilyComposition == c
                            && Alco_Person[i].Education == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                // Дата----------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _periodS == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Education == b 
                            && Alco_Person[i].Sex == c
                            && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Education == b && Alco_Person[i].Sex == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _periodS == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Education == b && Alco_Person[i].FamilyStatus == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Education == b 
                            && Alco_Person[i].FamilyStatus == c 
                            && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Education == b && Alco_Person[i].CostOfKids == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Education == b 
                            && Alco_Person[i].CostOfKids == c 
                            && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Education == b && Alco_Person[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Education == b && Alco_Person[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Education == b && Alco_Person[i].Education == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Education == b && Alco_Person[i].Education == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                //-----------------------------------------------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _periodS == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Sex == b && Alco_Person[i].FamilyStatus == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Sex == b && Alco_Person[i].FamilyStatus == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Sex == b && Alco_Person[i].CostOfKids == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Sex == b && Alco_Person[i].CostOfKids == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Sex == b && Alco_Person[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Sex == b && Alco_Person[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Sex == b && Alco_Person[i].Education == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Sex == b && Alco_Person[i].Education == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].FamilyStatus == b && Alco_Person[i].CostOfKids == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].FamilyStatus == b && Alco_Person[i].CostOfKids == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].FamilyStatus == b && Alco_Person[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].FamilyStatus == b && Alco_Person[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].FamilyStatus == b && Alco_Person[i].Education == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].FamilyStatus == b && Alco_Person[i].Education == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                //----------------------------------------------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].CostOfKids == b && Alco_Person[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].CostOfKids == b && Alco_Person[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].CostOfKids == b && Alco_Person[i].Education == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].CostOfKids == b && Alco_Person[i].Education == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }
                //-----------------------------------------------------------------------------------------------------------------------------------------------
                else if (_familyComposition == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].FamilyComposition == b && Alco_Person[i].Education == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].FamilyComposition == b && Alco_Person[i].Education == c && data == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }
                //----------------------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.',',','/');
                        string data = mas[2];
                        string[] mas1 = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco_Person[i].RegionCenterBLR == b && data == c && data1 == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco_Person[i].Sex == b && data == c && data1 == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco_Person[i].FamilyStatus == b && data == c && data1 == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco_Person[i].CostOfKids == b && data == c && data1 == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco_Person[i].FamilyComposition == b && data == c && data1 == d)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_education == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco_Person[i].Education == b && data == c && data1 == d)
                        {
                            alco.Add(Alco_Person[i]);
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
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyStatus == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].CostOfKids == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyComposition == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _education == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].Education == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].CostOfKids == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _familyComposition == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].FamilyComposition == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _education == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].Education == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].CostOfKids == c
                            && Narco_Person[i].FamilyComposition == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].CostOfKids == c
                            && Narco_Person[i].Education == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].FamilyComposition == c
                            && Narco_Person[i].Education == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].CostOfKids == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].FamilyComposition == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _education == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].Education == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].CostOfKids == c
                            && Narco_Person[i].FamilyComposition == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].CostOfKids == c
                            && Narco_Person[i].Education == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].FamilyComposition == c
                            && Narco_Person[i].Education == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].FamilyStatus == b
                            && Narco_Person[i].CostOfKids == c
                            && Narco_Person[i].FamilyComposition == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].FamilyStatus == b
                            && Narco_Person[i].CostOfKids == c
                            && Narco_Person[i].Education == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].FamilyStatus == b
                            && Narco_Person[i].FamilyComposition == c
                            && Narco_Person[i].Education == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].CostOfKids == b
                            && Narco_Person[i].FamilyComposition == c
                            && Narco_Person[i].Education == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                // Дата----------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _periodS == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Education == b && Narco_Person[i].Sex == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _periodPo == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Education == b && Narco_Person[i].Sex == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _periodS == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Education == b && Narco_Person[i].FamilyStatus == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _periodPo == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Education == b && Narco_Person[i].FamilyStatus == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Education == b && Narco_Person[i].CostOfKids == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Education == b && Narco_Person[i].CostOfKids == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Education == b && Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Education == b && Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Education == b && Narco_Person[i].Education == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Education == b && Narco_Person[i].Education == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                //-----------------------------------------------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _periodS == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Sex == b && Narco_Person[i].FamilyStatus == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _periodPo == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Sex == b && Narco_Person[i].FamilyStatus == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Sex == b && Narco_Person[i].CostOfKids == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Sex == b && Narco_Person[i].CostOfKids == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Sex == b && Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Sex == b && Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Sex == b && Narco_Person[i].Education == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Sex == b && Narco_Person[i].Education == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].FamilyStatus == b && Narco_Person[i].CostOfKids == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].FamilyStatus == b && Narco_Person[i].CostOfKids == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].FamilyStatus == b && Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].FamilyStatus == b && Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].FamilyStatus == b && Narco_Person[i].Education == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].FamilyStatus == b && Narco_Person[i].Education == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                //----------------------------------------------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].CostOfKids == b && Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].CostOfKids == b && Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].CostOfKids == b && Narco_Person[i].Education == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].CostOfKids == b && Narco_Person[i].Education == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }
                //-----------------------------------------------------------------------------------------------------------------------------------------------
                else if (_familyComposition == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].FamilyComposition == b && Narco_Person[i].Education == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].FamilyComposition == b && Narco_Person[i].Education == c && data == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }
                //----------------------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narco_Person[i].RegionCenterBLR == b && data == c && data1 == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narco_Person[i].Sex == b && data == c && data1 == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narco_Person[i].FamilyStatus == b && data == c && data1 == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narco_Person[i].CostOfKids == b && data == c && data1 == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narco_Person[i].FamilyComposition == b && data == c && data1 == d)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_education == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narco_Person[i].Education == b && data == c && data1 == d)
                        {
                            narco.Add(Narco_Person[i]);
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
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyStatus == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].CostOfKids == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyComposition == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _education == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].Education == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].CostOfKids == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _familyComposition == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].FamilyComposition == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _education == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].Education == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].CostOfKids == c
                            && Poliz_Person[i].FamilyComposition == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].CostOfKids == c
                            && Poliz_Person[i].Education == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].FamilyComposition == c
                            && Poliz_Person[i].Education == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].CostOfKids == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].FamilyComposition == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _education == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].Education == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].CostOfKids == c
                            && Poliz_Person[i].FamilyComposition == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].CostOfKids == c
                            && Poliz_Person[i].Education == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].FamilyComposition == c
                            && Poliz_Person[i].Education == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].FamilyStatus == b
                            && Poliz_Person[i].CostOfKids == c
                            && Poliz_Person[i].FamilyComposition == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].FamilyStatus == b
                            && Poliz_Person[i].CostOfKids == c
                            && Poliz_Person[i].Education == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].FamilyStatus == b
                            && Poliz_Person[i].FamilyComposition == c
                            && Poliz_Person[i].Education == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].CostOfKids == b
                            && Poliz_Person[i].FamilyComposition == c
                            && Poliz_Person[i].Education == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                // Дата----------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _periodS == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Education == b && Poliz_Person[i].Sex == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _periodPo == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Education == b && Poliz_Person[i].Sex == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _periodS == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Education == b && Poliz_Person[i].FamilyStatus == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _periodPo == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Education == b && Poliz_Person[i].FamilyStatus == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Education == b && Poliz_Person[i].CostOfKids == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Education == b && Poliz_Person[i].CostOfKids == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Education == b && Poliz_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Education == b && Poliz_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Education == b && Poliz_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Education == b && Poliz_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                //-----------------------------------------------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _periodS == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Sex == b && Poliz_Person[i].FamilyStatus == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _periodPo == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Sex == b && Poliz_Person[i].FamilyStatus == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Sex == b && Poliz_Person[i].CostOfKids == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Sex == b && Poliz_Person[i].CostOfKids == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Sex == b && Poliz_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Sex == b && Poliz_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Sex == b && Poliz_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Sex == b && Poliz_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].FamilyStatus == b && Poliz_Person[i].CostOfKids == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].FamilyStatus == b && Poliz_Person[i].CostOfKids == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].FamilyStatus == b && Poliz_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].FamilyStatus == b && Poliz_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].FamilyStatus == b && Poliz_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].FamilyStatus == b && Poliz_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                //----------------------------------------------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].CostOfKids == b && Poliz_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].CostOfKids == b && Poliz_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].CostOfKids == b && Poliz_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].CostOfKids == b && Poliz_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }
                //-----------------------------------------------------------------------------------------------------------------------------------------------
                else if (_familyComposition == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].FamilyComposition == b && Poliz_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].FamilyComposition == b && Poliz_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }
                //----------------------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Poliz_Person[i].RegionCenterBLR == b && data == c && data1 == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Poliz_Person[i].Sex == b && data == c && data1 == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Poliz_Person[i].FamilyStatus == b && data == c && data1 == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Poliz_Person[i].CostOfKids == b && data == c && data1 == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Poliz_Person[i].FamilyComposition == b && data == c && data1 == d)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_education == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Poliz_Person[i].Education == b && data == c && data1 == d)
                        {
                            poliz.Add(Poliz_Person[i]);
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
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyStatus == d
                            && Alco_Person[i].CostOfKids == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyStatus == d
                            && Alco_Person[i].FamilyComposition == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyStatus == d
                            && Alco_Person[i].Education == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].CostOfKids == d
                            && Alco_Person[i].FamilyComposition == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].CostOfKids == d
                            && Alco_Person[i].Education == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyComposition == d
                            && Alco_Person[i].Education == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].CostOfKids == d
                            && Alco_Person[i].FamilyComposition == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].CostOfKids == d
                            && Alco_Person[i].Education == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].FamilyComposition == d
                            && Alco_Person[i].Education == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].CostOfKids == c
                            && Alco_Person[i].FamilyComposition == d
                            && Alco_Person[i].Education == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].CostOfKids == d
                            && Alco_Person[i].FamilyComposition == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].CostOfKids == d
                            && Alco_Person[i].Education == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].FamilyComposition == d
                            && Alco_Person[i].Education == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].CostOfKids == c
                            && Alco_Person[i].FamilyComposition == d
                            && Alco_Person[i].Education == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].FamilyStatus == b
                            && Alco_Person[i].CostOfKids == c
                            && Alco_Person[i].FamilyComposition == d
                            && Alco_Person[i].Education == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }
                
                //дата -------------------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodS == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyStatus == d
                            && data == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus== d &&_periodPo == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b 
                            && Alco_Person[i].Sex == c 
                            && Alco_Person[i].FamilyStatus == d
                            && data == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                    
                }

                else if (_regionCenterBLR == b && _sex == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                    
                }

                else if (_regionCenterBLR == b && _sex == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && data == d
                            && data1 == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                    
                }
                //-----------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                    
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                    
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                    
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                    
                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                    
                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                    
                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].FamilyStatus == c
                            && data == d
                            && data1 == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                    
                }
                //------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].FamilyStatus == b
                            && Alco_Person[i].CostOfKids == c
                            && Alco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                    
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].FamilyStatus == b
                            && Alco_Person[i].CostOfKids == c
                            && Alco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                    
                }

                else if (_familyStatus == b && _costOfKids == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].FamilyStatus == b
                            && Alco_Person[i].CostOfKids == c
                            && Alco_Person[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                    
                }

                else if (_familyStatus == b && _costOfKids == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].FamilyStatus == b
                            && Alco_Person[i].CostOfKids == c
                            && Alco_Person[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                    
                }

                else if (_familyStatus == b && _costOfKids == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco_Person[i].FamilyStatus == b
                            && Alco_Person[i].CostOfKids == c
                            && data == d
                            && data1 == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                    
                }
                //-----------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].CostOfKids == b
                            && Alco_Person[i].FamilyComposition == c
                            && Alco_Person[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                    
                }

                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].CostOfKids == b
                            && Alco_Person[i].FamilyComposition == c
                            && Alco_Person[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco_Person[i].CostOfKids == b
                            && Alco_Person[i].FamilyComposition == c
                            && data == d
                            && data1 == e)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }
                //-----------------------------------------------------------------------------------------------------------------------------------
                else if (_familyComposition == b && _education == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco_Person[i].FamilyComposition == b
                            && Alco_Person[i].Education == c
                            && data == d
                            && data1 == e)
                        {
                            alco.Add(Alco_Person[i]);
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
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyStatus == d
                            && Narco_Person[i].CostOfKids == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyStatus == d
                            && Narco_Person[i].FamilyComposition == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyStatus == d
                            && Narco_Person[i].Education == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].CostOfKids == d
                            && Narco_Person[i].FamilyComposition == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].CostOfKids == d
                            && Narco_Person[i].Education == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyComposition == d
                            && Narco_Person[i].Education == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].CostOfKids == d
                            && Narco_Person[i].FamilyComposition == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].CostOfKids == d
                            && Narco_Person[i].Education == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].FamilyComposition == d
                            && Narco_Person[i].Education == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].CostOfKids == c
                            && Narco_Person[i].FamilyComposition == d
                            && Narco_Person[i].Education == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].CostOfKids == d
                            && Narco_Person[i].FamilyComposition == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].CostOfKids == d
                            && Narco_Person[i].Education == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].FamilyComposition == d
                            && Narco_Person[i].Education == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_sex == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].CostOfKids == c
                            && Narco_Person[i].FamilyComposition == d
                            && Narco_Person[i].Education == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].FamilyStatus == b
                            && Narco_Person[i].CostOfKids == c
                            && Narco_Person[i].FamilyComposition == d
                            && Narco_Person[i].Education == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                //дата -------------------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodS == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyStatus == d
                            && data == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodPo == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyStatus == d
                            && data == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && data == d
                            && data1 == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }
                //-----------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].FamilyStatus == c
                            && data == d
                            && data1 == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }
                //------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].FamilyStatus == b
                            && Narco_Person[i].CostOfKids == c
                            && Narco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].FamilyStatus == b
                            && Narco_Person[i].CostOfKids == c
                            && Narco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_familyStatus == b && _costOfKids == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].FamilyStatus == b
                            && Narco_Person[i].CostOfKids == c
                            && Narco_Person[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_familyStatus == b && _costOfKids == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].FamilyStatus == b
                            && Narco_Person[i].CostOfKids == c
                            && Narco_Person[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_familyStatus == b && _costOfKids == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narco_Person[i].FamilyStatus == b
                            && Narco_Person[i].CostOfKids == c
                            && data == d
                            && data1 == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }
                //-----------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].CostOfKids == b
                            && Narco_Person[i].FamilyComposition == c
                            && Narco_Person[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].CostOfKids == b
                            && Narco_Person[i].FamilyComposition == c
                            && Narco_Person[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                   
                }

                else if (_costOfKids == b && _familyComposition == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narco_Person[i].CostOfKids == b
                            && Narco_Person[i].FamilyComposition == c
                            && data == d
                            && data1 == e)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }
                //-----------------------------------------------------------------------------------------------------------------------------------
                else if (_familyComposition == b && _education == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narco_Person[i].FamilyComposition == b
                            && Narco_Person[i].Education == c
                            && data == d
                            && data1 == e)
                        {
                            narco.Add(Narco_Person[i]);
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
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyStatus == d
                            && Poliz_Person[i].CostOfKids == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                    DataGrid.ItemsSource = poliz;
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyStatus == d
                            && Poliz_Person[i].FamilyComposition == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyStatus == d
                            && Poliz_Person[i].Education == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].CostOfKids == d
                            && Poliz_Person[i].FamilyComposition == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].CostOfKids == d
                            && Poliz_Person[i].Education == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyComposition == d
                            && Poliz_Person[i].Education == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].CostOfKids == d
                            && Poliz_Person[i].FamilyComposition == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].CostOfKids == d
                            && Poliz_Person[i].Education == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].FamilyComposition == d
                            && Poliz_Person[i].Education == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].CostOfKids == c
                            && Poliz_Person[i].FamilyComposition == d
                            && Poliz_Person[i].Education == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].CostOfKids == d
                            && Poliz_Person[i].FamilyComposition == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].CostOfKids == d
                            && Poliz_Person[i].Education == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].FamilyComposition == d
                            && Poliz_Person[i].Education == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_sex == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].CostOfKids == c
                            && Poliz_Person[i].FamilyComposition == d
                            && Poliz_Person[i].Education == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].FamilyStatus == b
                            && Poliz_Person[i].CostOfKids == c
                            && Poliz_Person[i].FamilyComposition == d
                            && Poliz_Person[i].Education == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                //дата -------------------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodS == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyStatus == d
                            && data == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodPo == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyStatus == d
                            && data == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].CostOfKids == d
                            && data == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].CostOfKids == d
                            && data == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].CostOfKids == d
                            && data == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].CostOfKids == d
                            && data == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && data == d
                            && data1 == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }
                //-----------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].CostOfKids == d
                            && data == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].CostOfKids == d
                            && data == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].FamilyStatus == c
                            && data == d
                            && data1 == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }
                //------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].FamilyStatus == b
                            && Poliz_Person[i].CostOfKids == c
                            && Poliz_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].FamilyStatus == b
                            && Poliz_Person[i].CostOfKids == c
                            && Poliz_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_familyStatus == b && _costOfKids == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].FamilyStatus == b
                            && Poliz_Person[i].CostOfKids == c
                            && Poliz_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_familyStatus == b && _costOfKids == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].FamilyStatus == b
                            && Poliz_Person[i].CostOfKids == c
                            && Poliz_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_familyStatus == b && _costOfKids == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Poliz_Person[i].FamilyStatus == b
                            && Poliz_Person[i].CostOfKids == c
                            && data == d
                            && data1 == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }
                //-----------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].CostOfKids == b
                            && Poliz_Person[i].FamilyComposition == c
                            && Poliz_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].CostOfKids == b
                            && Poliz_Person[i].FamilyComposition == c
                            && Poliz_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                 
                }

                else if (_costOfKids == b && _familyComposition == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Poliz_Person[i].CostOfKids == b
                            && Poliz_Person[i].FamilyComposition == c
                            && data == d
                            && data1 == e)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }
                //-----------------------------------------------------------------------------------------------------------------------------------
                else if (_familyComposition == b && _education == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Poliz_Person[i].FamilyComposition == b
                            && Poliz_Person[i].Education == c
                            && data == d
                            && data1 == e)
                        {
                            poliz.Add(Poliz_Person[i]);
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
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyStatus == d
                            && Alco_Person[i].CostOfKids == e
                            && Alco_Person[i].FamilyComposition == f)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _education == f)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyStatus == d
                            && Alco_Person[i].CostOfKids == e
                            && Alco_Person[i].Education == f)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].CostOfKids == d
                            && Alco_Person[i].FamilyComposition == e
                            && Alco_Person[i].Education == f)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                    
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].CostOfKids == d
                            && Alco_Person[i].FamilyComposition == e
                            && Alco_Person[i].Education == f)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyStatus == d
                            && Alco_Person[i].FamilyComposition == e
                            && Alco_Person[i].Education == f)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].CostOfKids == d
                            && Alco_Person[i].FamilyComposition == e
                            && Alco_Person[i].Education == f)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }
                //дата ------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _periodS == f)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyStatus == d
                            && Alco_Person[i].CostOfKids == e
                            && data == f)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyStatus == d
                            && Alco_Person[i].CostOfKids == e
                            && data == f)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _periodS == f)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyStatus == d
                            && Alco_Person[i].FamilyComposition == e
                            && data == f)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyStatus == d
                            && Alco_Person[i].FamilyComposition == e
                            && data == f)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyStatus == d
                            && Alco_Person[i].Education == e
                            && data == f)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyStatus == d
                            && Alco_Person[i].Education == e
                            && data == f)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {

                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyStatus == d
                            && data == e
                            && data1 == f)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _periodS == f)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].CostOfKids == d
                            && Alco_Person[i].FamilyComposition == e
                            && data == f)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].CostOfKids == d
                            && Alco_Person[i].FamilyComposition == e
                            && data == f)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].CostOfKids == d
                            && Alco_Person[i].Education == e
                            && data == f)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].CostOfKids == d
                            && Alco_Person[i].Education == e
                            && data == f)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas[2];
                        if (Alco_Person[i].Sex == b
                            && Alco_Person[i].FamilyStatus == c
                            && Alco_Person[i].CostOfKids == d
                            && data == e
                            && data1 == f)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].FamilyStatus == b
                            && Alco_Person[i].CostOfKids == c
                            && Alco_Person[i].FamilyComposition == d
                            && Alco_Person[i].Education == e
                            && data == f)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco_Person[i].CostOfKids == b
                            && Alco_Person[i].FamilyComposition == c
                            && Alco_Person[i].Education == d
                            && data == e
                            && data1 == f)
                        {
                            alco.Add(Alco_Person[i]);
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
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyStatus == d
                            && Narco_Person[i].CostOfKids == e
                            && Narco_Person[i].FamilyComposition == f)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _education == f)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyStatus == d
                            && Narco_Person[i].CostOfKids == e
                            && Narco_Person[i].Education == f)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].CostOfKids == d
                            && Narco_Person[i].FamilyComposition == e
                            && Narco_Person[i].Education == f)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].CostOfKids == d
                            && Narco_Person[i].FamilyComposition == e
                            && Narco_Person[i].Education == f)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyStatus == d
                            && Narco_Person[i].FamilyComposition == e
                            && Narco_Person[i].Education == f)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].CostOfKids == d
                            && Narco_Person[i].FamilyComposition == e
                            && Narco_Person[i].Education == f)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }
                //дата ---------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _periodS == f)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyStatus == d
                            && Narco_Person[i].CostOfKids == e
                            && data == f)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _periodPo == f)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyStatus == d
                            && Narco_Person[i].CostOfKids == e
                            && data == f)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _periodS == f)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyStatus == d
                            && Narco_Person[i].FamilyComposition == e
                            && data == f)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _periodPo == f)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyStatus == d
                            && Narco_Person[i].FamilyComposition == e
                            && data == f)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyStatus == d
                            && Narco_Person[i].Education == e
                            && data == f)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e && _periodPo == f)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyStatus == d
                            && Narco_Person[i].Education == e
                            && data == f)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {

                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyStatus == d
                            && data == e
                            && data1 == f)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _periodS == f)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].CostOfKids == d
                            && Narco_Person[i].FamilyComposition == e
                            && data == f)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _periodPo == f)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].CostOfKids == d
                            && Narco_Person[i].FamilyComposition == e
                            && data == f)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].CostOfKids == d
                            && Narco_Person[i].Education == e
                            && data == f)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e && _periodPo == f)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].CostOfKids == d
                            && Narco_Person[i].Education == e
                            && data == f)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas[2];
                        if (Narco_Person[i].Sex == b
                            && Narco_Person[i].FamilyStatus == c
                            && Narco_Person[i].CostOfKids == d
                            && data == e
                            && data1 == f)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].FamilyStatus == b
                            && Narco_Person[i].CostOfKids == c
                            && Narco_Person[i].FamilyComposition == d
                            && Narco_Person[i].Education == e
                            && data == f)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }
                //------------------------------------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narco_Person[i].CostOfKids == b
                            && Narco_Person[i].FamilyComposition == c
                            && Narco_Person[i].Education == d
                            && data == e
                            && data1 == f)
                        {
                            narco.Add(Narco_Person[i]);
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
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyStatus == d
                            && Poliz_Person[i].CostOfKids == e
                            && Poliz_Person[i].FamilyComposition == f)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _education == f)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyStatus == d
                            && Poliz_Person[i].CostOfKids == e
                            && Poliz_Person[i].Education == f)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].CostOfKids == d
                            && Poliz_Person[i].FamilyComposition == e
                            && Poliz_Person[i].Education == f)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].CostOfKids == d
                            && Poliz_Person[i].FamilyComposition == e
                            && Poliz_Person[i].Education == f)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyStatus == d
                            && Poliz_Person[i].FamilyComposition == e
                            && Poliz_Person[i].Education == f)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].CostOfKids == d
                            && Poliz_Person[i].FamilyComposition == e
                            && Poliz_Person[i].Education == f)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }
                //Дата-------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _periodS == f)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyStatus == d
                            && Poliz_Person[i].CostOfKids == e
                            && data == f)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _periodPo == f)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyStatus == d
                            && Poliz_Person[i].CostOfKids == e
                            && data == f)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _periodS == f)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyStatus == d
                            && Poliz_Person[i].FamilyComposition == e
                            && data == f)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _periodPo == f)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyStatus == d
                            && Poliz_Person[i].FamilyComposition == e
                            && data == f)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyStatus == d
                            && Poliz_Person[i].Education == e
                            && data == f)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e && _periodPo == f)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyStatus == d
                            && Poliz_Person[i].Education == e
                            && data == f)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {

                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyStatus == d
                            && data == e
                            && data1 == f)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _periodS == f)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].CostOfKids == d
                            && Poliz_Person[i].FamilyComposition == e
                            && data == f)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _periodPo == f)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].CostOfKids == d
                            && Poliz_Person[i].FamilyComposition == e
                            && data == f)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].CostOfKids == d
                            && Poliz_Person[i].Education == e
                            && data == f)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e && _periodPo == f)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].CostOfKids == d
                            && Poliz_Person[i].Education == e
                            && data == f)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas[2];
                        if (Poliz_Person[i].Sex == b
                            && Poliz_Person[i].FamilyStatus == c
                            && Poliz_Person[i].CostOfKids == d
                            && data == e
                            && data1 == f)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].FamilyStatus == b
                            && Poliz_Person[i].CostOfKids == c
                            && Poliz_Person[i].FamilyComposition == d
                            && Poliz_Person[i].Education == e
                            && data == f)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }
                //------------------------------------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Poliz_Person[i].CostOfKids == b
                            && Poliz_Person[i].FamilyComposition == c
                            && Poliz_Person[i].Education == d
                            && data == e
                            && data1 == f)
                        {
                            poliz.Add(Poliz_Person[i]);
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
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyStatus == d
                            && Alco_Person[i].CostOfKids == e
                            && Alco_Person[i].FamilyComposition == f
                            && Alco_Person[i].Education == g)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _periodS == g)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyStatus == d
                            && Alco_Person[i].CostOfKids == e
                            && Alco_Person[i].FamilyComposition == f
                            && data == g)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _periodPo == g)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyStatus == d
                            && Alco_Person[i].CostOfKids == e
                            && Alco_Person[i].FamilyComposition == f
                            && data == g)
                        {
                            alco.Add(Alco_Person[i]);
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
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyStatus == d
                            && Narco_Person[i].CostOfKids == e
                            && Narco_Person[i].FamilyComposition == f
                            && Narco_Person[i].Education == g)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _periodS == g)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyStatus == d
                            && Narco_Person[i].CostOfKids == e
                            && Narco_Person[i].FamilyComposition == f
                            && data == g)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _periodPo == g)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyStatus == d
                            && Narco_Person[i].CostOfKids == e
                            && Narco_Person[i].FamilyComposition == f
                            && data == g)
                        {
                            narco.Add(Narco_Person[i]);
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
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyStatus == d
                            && Poliz_Person[i].CostOfKids == e
                            && Poliz_Person[i].FamilyComposition == f
                            && Poliz_Person[i].Education == g)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _periodS == g)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyStatus == d
                            && Poliz_Person[i].CostOfKids == e
                            && Poliz_Person[i].FamilyComposition == f
                            && data == g)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _periodPo == g)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyStatus == d
                            && Poliz_Person[i].CostOfKids == e
                            && Poliz_Person[i].FamilyComposition == f
                            && data == g)
                        {
                            poliz.Add(Poliz_Person[i]);
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
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyStatus == d
                            && Alco_Person[i].CostOfKids == e
                            && Alco_Person[i].FamilyComposition == f
                            && Alco_Person[i].Education == g
                            && data == h)
                        {
                            alco.Add(Alco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g && _periodPo == h)
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyStatus == d
                            && Alco_Person[i].CostOfKids == e
                            && Alco_Person[i].FamilyComposition == f
                            && Alco_Person[i].Education == g
                            && data == h)
                        {
                            alco.Add(Alco_Person[i]);
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
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyStatus == d
                            && Narco_Person[i].CostOfKids == e
                            && Narco_Person[i].FamilyComposition == f
                            && Narco_Person[i].Education == g
                            && data == h)
                        {
                            narco.Add(Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g && _periodPo == h)
                {
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyStatus == d
                            && Narco_Person[i].CostOfKids == e
                            && Narco_Person[i].FamilyComposition == f
                            && Narco_Person[i].Education == g
                            && data == h)
                        {
                            narco.Add(Narco_Person[i]);
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
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyStatus == d
                            && Poliz_Person[i].CostOfKids == e
                            && Poliz_Person[i].FamilyComposition == f
                            && Poliz_Person[i].Education == g
                            && data == h)
                        {
                            poliz.Add(Poliz_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g && _periodPo == h)
                {
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyStatus == d
                            && Poliz_Person[i].CostOfKids == e
                            && Poliz_Person[i].FamilyComposition == f
                            && Poliz_Person[i].Education == g
                            && data == h)
                        {
                            poliz.Add(Poliz_Person[i]);
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
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        string[] mas = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas[2];
                        if (Alco_Person[i].RegionCenterBLR == b
                            && Alco_Person[i].Sex == c
                            && Alco_Person[i].FamilyStatus == d
                            && Alco_Person[i].CostOfKids == e
                            && Alco_Person[i].FamilyComposition == f
                            && Alco_Person[i].Education == g
                            && data == h
                            && data1 == k)
                        {
                            alco.Add(Alco_Person[i]);
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
                    for (int i = 0; i < Narco_Person.Count; i++)
                    {
                        string[] mas = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas[2];
                        if (Narco_Person[i].RegionCenterBLR == b
                            && Narco_Person[i].Sex == c
                            && Narco_Person[i].FamilyStatus == d
                            && Narco_Person[i].CostOfKids == e
                            && Narco_Person[i].FamilyComposition == f
                            && Narco_Person[i].Education == g
                            && data == h
                            && data1 == k)
                        {
                            narco.Add(Narco_Person[i]);
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
                    for (int i = 0; i < Poliz_Person.Count; i++)
                    {
                        string[] mas = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Poliz_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas[2];
                        if (Poliz_Person[i].RegionCenterBLR == b
                            && Poliz_Person[i].Sex == c
                            && Poliz_Person[i].FamilyStatus == d
                            && Poliz_Person[i].CostOfKids == e
                            && Poliz_Person[i].FamilyComposition == f
                            && Poliz_Person[i].Education == g
                            && data == h
                            && data1 == k)
                        {
                            poliz.Add(Poliz_Person[i]);
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
        /// Сформировать отчет 
        /// </summary>
        private void Excel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //сформировать отчет по алкогольной зависимости
                if (_typeOfAddiction == "Алкогольная")
                {
                    ExcelDataServis.Save_Report_Excel_Alco(alco);
                }
                //сформировать отчет по наркозависимости
                else if (_typeOfAddiction == "Наркотическая")
                {
                    ExcelDataServis.Save_Report_Excel_Narco(narco);
                }
                //сформировать отчет по полизависимости
                else if (_typeOfAddiction == "Полизависимость")
                {
                    ExcelDataServis.Save_Report_Excel_Poliz(poliz);
                }

                Close();
            }

            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// Клавиша Показать диаграммы 
        /// </summary>
        private void Diagramm_Click(object sender, RoutedEventArgs e)
        {
            Diagramm diag = new Diagramm();
            diag.Show();  

        }
    }
}