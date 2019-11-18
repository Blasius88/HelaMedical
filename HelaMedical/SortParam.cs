using HelaMedical.Excep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HelaMedical
{
    class SortParam : Generate_A_Report
    {
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

    }
}
