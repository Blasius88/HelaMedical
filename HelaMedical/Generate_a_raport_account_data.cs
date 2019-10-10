using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using HelaMedical.Class;
using HelaMedical.Excep;

namespace HelaMedical
{
    public class Generate_a_raport_account_data
    {
        public static void Generate_a_raport(List<Alco> alco, List<Narcoman> narco, List<Polizavis> poliz, String data, String type)
        {
            try
            {
                bool flag = false;
                if (type == "Алкогольная")
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].DataInfo == data)
                            alco.Add(Alco.AlcoholismPersona[i]);
                    }
                    ExcelDataServis.Save_Report_Excel_Alco(alco);
                    flag = true;
                }
                else if (type == "Наркотическая")
                {

                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].DataInfo == data)
                            narco.Add(Narcoman.Drug_Addiction[i]);
                    }
                    ExcelDataServis.Save_Report_Excel_Narco(narco);
                    flag = true;
                }
                else if (type == "Полизависимость")
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].DataInfo == data)
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                    }
                    ExcelDataServis.Save_Report_Excel_Poliz(poliz);
                    flag = true;
                }
                if (flag)
                {
                    MessageBox.Show("Данные записаны");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ExcepLog.Excep(ex);
            }
        }
    }
}
