using System;
using System.Windows;
using HelaMedical.Class;
using System.Windows.Media;
using HelaMedical.Excep;

namespace HelaMedical
{
    /// <summary>
    /// Логика взаимодействия для OtherHosp.xaml
    /// </summary>
    public partial class OtherHosp : Window
    {

        //Бреская область 
        private bool oblPsiNerDisp = false;
        private bool ploska = false;
        private bool oblNarcoDis = false;
        private bool mogilevci = false;
        private bool krivoschin = false;
        private bool goroditshe = false;
        private bool skorajaPomotsch = false;
        private bool oblBolnica = false;
        private bool gorodHospCentr = false;
        private bool detOblHosp = false;
        private bool oblProtivTuberDisp = false;
        private bool verhovichi = false;
        private bool berezCentrRaionHosp = false;
        private bool gancevichCentrRaionHosp = false;
        private bool drochinCentrRaionHosp = false;
        private bool zabinovskajaCentRaion = false;
        private bool ivanovskajaCentrRaionHosp = false;
        private bool ivacevichskajaCentrRaionHosp = false;
        private bool kameneckajaCentRaionHosp = false;
        private bool kobrinskajaCentrRaionHosp = false;
        private bool lunineckiCentrRaionHosp = false;
        private bool ljahovichiCentrRaionHosp = false;
        private bool maloritskajaCentrRaionHosp = false;
        private bool pruzanskajaCentrRaionHosp = false;
        private bool stolinskajaCentrRaionHosp = false;
        private bool baranMezRaionNarcoDis = false;
        private bool pinskMezRaionNarcoDis = false;
        private bool baranoviciGorHos = false;
        private bool pinskaCenterHosp = false;

        //Гомельская область 
        private bool gomelOblKlinBol = false;
        private bool gomelGorKlinBol1 = false;
        private bool gomelGorKlinBol2 = false;
        private bool gomelGorKlinBol3 = false;
        private bool gomelGorBol4 = false;
        private bool gomelGorKlinBolSkorMedPom = false;
        private bool gomelOblInfekcKlinBol = false;
        private bool gomelOblKlinPsihBol = false;
        private bool gomelOblSpecKlinBol = false;
        private bool gomelOblTuberKlinBol = false;
        private bool gomelIOV = false;
        private bool gomelOblKlinKardioCentr = false;
        private bool gomelOblKlinOnkoDis = false;
        private bool braginCentrRaionBol = false;
        private bool buda_KoshelCentrBol = false;
        private bool vetkovsCentrBol = false;
        private bool dobrushCentrBol = false;
        private bool elskajaCentrBol = false;
        private bool zitkovsCentrBol = false;
        private bool zlobiCentrBol = false;
        private bool kalinkovCentrBol = false;
        private bool kormjanskCentrBol = false;
        private bool lelcicCentrBol = false;
        private bool loevskCentrBol = false;
        private bool mozirCentrGorPolic = false;
        private bool narovlCentrBol = false;
        private bool oktjabrCentrBol = false;
        private bool petrikovCentrBol = false;
        private bool recickajaCentBol = false;
        private bool rogacevCentrBol = false;
        private bool svetlagorCentrBol = false;
        private bool hoinikCentrBol = false;
        private bool cecerskajaCentrBol = false;
        public string hospOtherName = "";


        public OtherHosp()
        {
            InitializeComponent();
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

        private void CloseOtherHosp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AddOtherHosp_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Бресткая область
                bool check = true;
                hospOtherName = "";
                if (oblPsiNerDisp == true)
                {
                    hospOtherName += "УЗ «Брестский областной психоневрологический диспансер»";
                    if (OblPsiNerDisp_Col.Text == "")
                    {
                        check = false;
                        OblPsiNerDisp_Col.BorderThickness = new Thickness(3);
                        OblPsiNerDisp_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + OblPsiNerDisp_Col.Text + " раз. ";
                }
                if (ploska == true)
                {
                    hospOtherName += "УЗ «Брестский областной психиатрический стационар «Плоска»";
                    if (Ploska_Col.Text == "")
                    {
                        check = false;
                        Ploska_Col.BorderThickness = new Thickness(3);
                        Ploska_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + Ploska_Col.Text + " раз. ";
                }
                if (oblNarcoDis == true)
                {
                    hospOtherName += "УЗ «Брестский областной наркологический диспансер»";
                    if (OblNarcoDis_Col.Text == "")
                    {
                        check = false;
                        OblNarcoDis_Col.BorderThickness = new Thickness(3);
                        OblNarcoDis_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + OblNarcoDis_Col.Text + "раз. ";
                }
                if (mogilevci == true)
                {
                    hospOtherName += "УЗ «Брестская областная психиатрическая больница «Могилевцы»";
                    if (Mogilevci_Col.Text == "")
                    {
                        check = false;
                        Mogilevci_Col.BorderThickness = new Thickness(3);
                        Mogilevci_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + Mogilevci_Col.Text + " раз. ";
                }
                if (krivoschin == true)
                {
                    hospOtherName += "УЗ «Брестская областная психиатрическая больница «Кривошин»";
                    if (Krivoschin_Col.Text == "")
                    {
                        check = false;
                        Krivoschin_Col.BorderThickness = new Thickness(3);
                        Krivoschin_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + Krivoschin_Col.Text + " раз. ";
                }
                if (goroditshe == true)
                {
                    hospOtherName += "УЗ «Брестская областная психиатрическая больница «Городище»";
                    if (Goroditsche_Col.Text == "")
                    {
                        check = false;
                        Goroditsche_Col.BorderThickness = new Thickness(3);
                        Goroditsche_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + Goroditsche_Col.Text + " раз. ";
                }
                if (skorajaPomotsch == true)
                {
                    hospOtherName += "УЗ «Брестская городская больница скорой медицинской помощи (отд. реанимации)";
                    if (ScorajaPomotsch_Col.Text == "")
                    {
                        check = false;
                        ScorajaPomotsch_Col.BorderThickness = new Thickness(3);
                        ScorajaPomotsch_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + ScorajaPomotsch_Col.Text + " раз. ";
                }
                if (oblBolnica == true)
                {
                    hospOtherName += "УЗ «Брестская областная больница»";
                    if (OblBolnica_Col.Text == "")
                    {
                        check = false;
                        OblBolnica_Col.BorderThickness = new Thickness(3);
                        OblBolnica_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + OblBolnica_Col.Text + " раз. ";
                }
                if (gorodHospCentr == true)
                {
                    hospOtherName += "УЗ «Брестская центральная городская больница» (отд. реанимации)";
                    if (GorodHospCentr_Col.Text == "")
                    {
                        check = false;
                        GorodHospCentr_Col.BorderThickness = new Thickness(3);
                        GorodHospCentr_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + GorodHospCentr_Col.Text + " раз. ";
                }
                if (detOblHosp == true)
                {
                    hospOtherName += "УЗ «Брестская детская областная больница» (отд. реанимации)";
                    if (DetOblHosp_Col.Text == "")
                    {
                        check = false;
                        DetOblHosp_Col.BorderThickness = new Thickness(3);
                        DetOblHosp_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + DetOblHosp_Col.Text + " раз. ";

                }
                if (oblProtivTuberDisp == true)
                {
                    hospOtherName += "УЗ «Брестский областной противотуберкулезный диспансер»";
                    if (OblProtivTuberkDisp_Col.Text == "")
                    {
                        check = false;
                        OblProtivTuberkDisp_Col.BorderThickness = new Thickness(3);
                        OblProtivTuberkDisp_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + OblProtivTuberkDisp_Col.Text + " раз. ";
                }
                if (verhovichi == true)
                {
                    hospOtherName += "УЗ «Брестская областная туберкулезная больница «Верховичи»|";
                    if (Verhovichi_Col.Text == "")
                    {
                        check = false;
                        Verhovichi_Col.BorderThickness = new Thickness(3);
                        Verhovichi_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + OblProtivTuberkDisp_Col.Text + " раз. ";
                }
                if (berezCentrRaionHosp == true)
                {
                    hospOtherName += "УЗ «Березовская центральная районная больница»|";
                    if (BerezCentrRaionHosp_Col.Text == "")
                    {
                        check = false;
                        BerezCentrRaionHosp_Col.BorderThickness = new Thickness(3);
                        BerezCentrRaionHosp_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + BerezCentrRaionHosp_Col.Text + " раз. ";
                }
                if (gancevichCentrRaionHosp == true)
                {
                    hospOtherName += "УЗ «Ганцевичская центральная районная больница»|";
                    if (GancevichCentrRaionHosp_Col.Text == "")
                    {
                        check = false;
                        GancevichCentrRaionHosp_Col.BorderThickness = new Thickness(3);
                        GancevichCentrRaionHosp_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + GancevichCentrRaionHosp_Col.Text + " раз. ";
                }
                if (drochinCentrRaionHosp == true)
                {
                    hospOtherName += "УЗ «Дрогичинская центральная больница»";
                    if (DrochinCentrHosp_Col.Text == "")
                    {
                        check = false;
                        DrochinCentrHosp_Col.BorderThickness = new Thickness(3);
                        DrochinCentrHosp_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + DrochinCentrHosp_Col.Text + " раз. ";
                }
                if (zabinovskajaCentRaion == true)
                {
                    hospOtherName += "УЗ «Жабинковская центральная районная больница»";
                    if (ZabinovskajaCentRaion_Col.Text == "")
                    {
                        check = false;
                        ZabinovskajaCentRaion_Col.BorderThickness = new Thickness(3);
                        ZabinovskajaCentRaion_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + ZabinovskajaCentRaion_Col.Text + " раз. ";
                }
                if (ivanovskajaCentrRaionHosp == true)
                {
                    hospOtherName += "УЗ «Ивановская центральная районная больница»";
                    if (IvanovskajaCentrRaionHosp_Col.Text == "")
                    {
                        check = false;
                        IvanovskajaCentrRaionHosp_Col.BorderThickness = new Thickness(3);
                        IvanovskajaCentrRaionHosp_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + IvanovskajaCentrRaionHosp_Col.Text + " раз. ";
                }
                if (ivacevichskajaCentrRaionHosp == true)
                {
                    hospOtherName += "УЗ «Ивацевичская центральная районная больница»";
                    if (IvacevichskajaCentrRaionHosp_Col.Text == "")
                    {
                        check = false;
                        IvacevichskajaCentrRaionHosp_Col.BorderThickness = new Thickness(3);
                        IvacevichskajaCentrRaionHosp_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + IvacevichskajaCentrRaionHosp_Col.Text + " раз. ";
                }
                if (kameneckajaCentRaionHosp == true)
                {
                    hospOtherName += "УЗ «Каменецкая центральная районная больница»|";
                    if (KameneckajaCentRaionHosp_Col.Text == "")
                    {
                        check = false;
                        KameneckajaCentRaionHosp_Col.BorderThickness = new Thickness(3);
                        KameneckajaCentRaionHosp_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + KameneckajaCentRaionHosp_Col.Text + " раз. ";
                }
                if (kobrinskajaCentrRaionHosp == true)
                {
                    hospOtherName += "УЗ «Кобринская центральная районная больница»";
                    if (KobrinskajaCentrRaionHosp_Col.Text == "")
                    {
                        check = false;
                        KobrinskajaCentrRaionHosp_Col.BorderThickness = new Thickness(3);
                        KobrinskajaCentrRaionHosp_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + KobrinskajaCentrRaionHosp_Col.Text + " раз. ";
                }
                if (lunineckiCentrRaionHosp == true)
                {
                    hospOtherName += "УЗ «Лунинецкая центральная районная больница»";
                    if (LunineckiCentrRaionHosp_Col.Text == "")
                    {
                        check = false;
                        LunineckiCentrRaionHosp_Col.BorderThickness = new Thickness(3);
                        LunineckiCentrRaionHosp_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + LunineckiCentrRaionHosp_Col.Text + " раз. ";
                }
                if (ljahovichiCentrRaionHosp == true)
                {
                    hospOtherName += "УЗ «Ляховичская центральная районная больница»";
                    if (LjahovichiCentrRaionHosp_Col.Text == "")
                    {
                        check = false;
                        LjahovichiCentrRaionHosp_Col.BorderThickness = new Thickness(3);
                        LjahovichiCentrRaionHosp_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + LjahovichiCentrRaionHosp_Col.Text + " раз. ";
                }
                if (maloritskajaCentrRaionHosp == true)
                {
                    hospOtherName += "УЗ «Малоритская центральная районная больница»";
                    if (MaloritskajaCentrRaionHosp_Col.Text == "")
                    {
                        check = false;
                        MaloritskajaCentrRaionHosp_Col.BorderThickness = new Thickness(3);
                        MaloritskajaCentrRaionHosp_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + MaloritskajaCentrRaionHosp_Col.Text + " раз. ";
                }
                if (pruzanskajaCentrRaionHosp == true)
                {
                    hospOtherName += "УЗ «Пружанская центральная районная больница»";
                    if (PruzanskajaCentrRaionHosp_Col.Text == "")
                    {
                        check = false;
                        PruzanskajaCentrRaionHosp_Col.BorderThickness = new Thickness(3);
                        PruzanskajaCentrRaionHosp_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + PruzanskajaCentrRaionHosp_Col.Text + " раз. ";
                }
                if (stolinskajaCentrRaionHosp == true)
                {
                    hospOtherName += "УЗ «Столинская центральная районная больница»";
                    if (StolinskajaCentrRaionHosp_Col.Text == "")
                    {
                        check = false;
                        StolinskajaCentrRaionHosp_Col.BorderThickness = new Thickness(3);
                        StolinskajaCentrRaionHosp_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + StolinskajaCentrRaionHosp_Col.Text + " раз. ";
                }
                if (baranMezRaionNarcoDis == true)
                {
                    hospOtherName += "УЗ «Барановичский межрайонный наркологический диспансер»";
                    if (BaranMezRaionNarcoDis_Col.Text == "")
                    {
                        check = false;
                        BaranMezRaionNarcoDis_Col.BorderThickness = new Thickness(3);
                        BaranMezRaionNarcoDis_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + BaranMezRaionNarcoDis_Col.Text + " раз. ";
                }
                if (pinskMezRaionNarcoDis == true)
                {
                    hospOtherName += "УЗ «Пинский межрайонный психоневрологический диспансер»";
                    if (PinskMezRaionNarcoDis_Col.Text == "")
                    {
                        check = false;
                        PinskMezRaionNarcoDis_Col.BorderThickness = new Thickness(3);
                        PinskMezRaionNarcoDis_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + PinskMezRaionNarcoDis_Col.Text + " раз. ";
                }
                if (baranoviciGorHos == true)
                {
                    hospOtherName += "УЗ «Барановичская городская больница»";
                    if (BaranoviciGorHos_Col.Text == "")
                    {
                        check = false;
                        BaranoviciGorHos_Col.BorderThickness = new Thickness(3);
                        BaranoviciGorHos_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + BaranoviciGorHos_Col.Text + " раз. ";
                }
                if (pinskaCenterHosp == true)
                {
                    hospOtherName += "УЗ «Барановичская городская больница»";
                    if (PinskaCenterHosp_Col.Text == "")
                    {
                        check = false;
                        PinskaCenterHosp_Col.BorderThickness = new Thickness(3);
                        PinskaCenterHosp_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + PinskaCenterHosp_Col.Text + " раз. ";
                }

                //Гомельская область 
                if (gomelOblKlinBol == true)
                {
                    hospOtherName = "УЗ «Гомельская областная клиническая больница»";
                    if (GomelOblKlinBol_Col.Text == "")
                    {
                        check = false;
                        GomelOblKlinBol_Col.BorderThickness = new Thickness(3);
                        GomelOblKlinBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + GomelOblKlinBol_Col.Text + " раз. ";
                }
                if (gomelGorKlinBol1 == true)
                {
                    hospOtherName = "ГУЗ «Гомельская городская клиническая больница №1»";
                    if (GomelGorKlinBol1_Col.Text == "")
                    {
                        check = false;
                        GomelGorKlinBol1_Col.BorderThickness = new Thickness(3);
                        GomelGorKlinBol1_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + GomelGorKlinBol1_Col.Text + " раз. ";
                }
                if (gomelGorKlinBol2 == true)
                {
                    hospOtherName = "УЗ «Гомельская городская клиническая больница №2»";
                    if (GomelGorKlinBol1_Col.Text == "")
                    {
                        check = false;
                        GomelGorKlinBol2_Col.BorderThickness = new Thickness(3);
                        GomelGorKlinBol2_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + GomelGorKlinBol2_Col.Text + " раз. ";
                }
                if (gomelGorKlinBol3 == true)
                {
                    hospOtherName = "УЗ «Гомельская городская клиническая больница №3»";
                    if (GomelGorKlinBol3_Col.Text == "")
                    {
                        check = false;
                        GomelGorKlinBol3_Col.BorderThickness = new Thickness(3);
                        GomelGorKlinBol3_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + GomelGorKlinBol3_Col.Text + " раз. ";
                }
                if (gomelGorBol4 == true)
                {
                    hospOtherName = "ГУЗ «Гомельская городская больница №4»";
                    if (GomelGorBol4_Col.Text == "")
                    {
                        check = false;
                        GomelGorBol4_Col.BorderThickness = new Thickness(3);
                        GomelGorBol4_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + GomelGorBol4_Col.Text + " раз. ";
                }
                if (gomelGorKlinBolSkorMedPom == true)
                {
                    hospOtherName = "ГУЗ «Гомельская городская клиническая больница скорой медицинской помощи»";
                    if (GomelGorKlinBolSkorMedPom_Col.Text == "")
                    {
                        check = false;
                        GomelGorKlinBolSkorMedPom_Col.BorderThickness = new Thickness(3);
                        GomelGorKlinBolSkorMedPom_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + GomelGorKlinBolSkorMedPom_Col.Text + " раз. ";

                }
                if (gomelOblInfekcKlinBol == true)
                {
                    hospOtherName = "УЗ «Гомельская областная инфекционная клиническая больница»";
                    if (GomelOblInfekcKlinBol_Col.Text == "")
                    {
                        check = false;
                        GomelOblInfekcKlinBol_Col.BorderThickness = new Thickness(3);
                        GomelOblInfekcKlinBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + GomelOblInfekcKlinBol_Col.Text + " раз. ";
                }
                if (gomelOblKlinPsihBol == true)
                {
                    hospOtherName = "УЗ «Гомельская областная клиническая психиатрическая больница»";
                    if (GomelOblKlinPsihBol_Col.Text == "")
                    {
                        check = false;
                        GomelOblKlinPsihBol_Col.BorderThickness = new Thickness(3);
                        GomelOblKlinPsihBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + GomelOblKlinPsihBol_Col.Text + " раз. ";
                }
                if (gomelOblSpecKlinBol == true)
                {
                    hospOtherName = "УЗ «Гомельская областная специализированная клиническая больница»";
                    if (GomelOblSpecKlinBol_Col.Text == "")
                    {
                        check = false;
                        GomelOblSpecKlinBol_Col.BorderThickness = new Thickness(3);
                        GomelOblSpecKlinBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + GomelOblSpecKlinBol_Col.Text + " раз. ";
                }
                if (gomelOblTuberKlinBol == true)
                {
                    hospOtherName = "УЗ «Гомельская областная туберкулезная клиническая больница»";
                    if (GomelOblTuberKlinBol_Col.Text == "")
                    {
                        check = false;
                        GomelOblTuberKlinBol_Col.BorderThickness = new Thickness(3);
                        GomelOblTuberKlinBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + GomelOblTuberKlinBol_Col.Text + " раз. ";
                }
                if (gomelIOV == true)
                {
                    hospOtherName = "УЗ «Гомельский областной клинический госпиталь ИОВ»";
                    if (GomelIOV_Col.Text == "")
                    {
                        check = false;
                        GomelIOV_Col.BorderThickness = new Thickness(3);
                        GomelIOV_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + GomelIOV_Col.Text + " раз. ";
                }
                if (gomelOblKlinKardioCentr == true)
                {
                    hospOtherName = "УЗ «Гомельский областной клинический кардиологический центр»";
                    if (GomelIOV_Col.Text == "")
                    {
                        check = false;
                        GomelOblKlinKardioCentr_Col.BorderThickness = new Thickness(3);
                        GomelOblKlinKardioCentr_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + GomelOblKlinKardioCentr_Col.Text + " раз. ";
                }
                if (gomelOblKlinOnkoDis == true)
                {
                    hospOtherName = "УЗ «Гомельский областной клинический онкологический диспансер»";
                    if (GomelIOV_Col.Text == "")
                    {
                        check = false;
                        GomelOblKlinOnkoDis_Col.BorderThickness = new Thickness(3);
                        GomelOblKlinOnkoDis_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + GomelOblKlinOnkoDis_Col.Text + " раз. ";
                }
                if (braginCentrRaionBol == true)
                {
                    hospOtherName = "УЗ «Брагинская центральная районная больница»";
                    if (BraginCentrRaionBol_Col.Text == "")
                    {
                        check = false;
                        BraginCentrRaionBol_Col.BorderThickness = new Thickness(3);
                        BraginCentrRaionBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + BraginCentrRaionBol_Col.Text + " раз. ";
                }
                if (buda_KoshelCentrBol == true)
                {
                    hospOtherName = "УЗ «Буда-Кошелевская  центральная районная больница»";
                    if (Buda_KoshelCentrBol_Col.Text == "")
                    {
                        check = false;
                        Buda_KoshelCentrBol_Col.BorderThickness = new Thickness(3);
                        Buda_KoshelCentrBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + Buda_KoshelCentrBol_Col.Text + " раз. ";
                }
                if (vetkovsCentrBol == true)
                {
                    hospOtherName = "УЗ «Ветковская центральная районная больница»";
                    if (VetkovsCentrBol_Col.Text == "")
                    {
                        check = false;
                        VetkovsCentrBol_Col.BorderThickness = new Thickness(3);
                        VetkovsCentrBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + VetkovsCentrBol_Col.Text + " раз. ";
                }
                if (dobrushCentrBol == true)
                {
                    hospOtherName = "УЗ «Добрушская центральная районная больница»";
                    if (DobrushCentrBol_Col.Text == "")
                    {
                        check = false;
                        DobrushCentrBol_Col.BorderThickness = new Thickness(3);
                        DobrushCentrBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + DobrushCentrBol_Col.Text + " раз. ";
                }
                if (elskajaCentrBol == true)
                {
                    hospOtherName = "УЗ «Ельская центральная районная больница»";
                    if (ElskajaCentrBol_Col.Text == "")
                    {
                        check = false;
                        ElskajaCentrBol_Col.BorderThickness = new Thickness(3);
                        ElskajaCentrBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + ElskajaCentrBol_Col.Text + " раз. ";
                }
                if(zitkovsCentrBol == true)
                {
                    hospOtherName = "УЗ «Житковичская центральная районная больница»";
                    if (ZitkovsCentrBol_Col.Text == "")
                    {
                        check = false;
                        ZitkovsCentrBol_Col.BorderThickness = new Thickness(3);
                        ZitkovsCentrBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + ZitkovsCentrBol_Col.Text + " раз. ";
                }
                if (zlobiCentrBol == true)
                {
                    hospOtherName = "УЗ «Жлобинская центральная районная больница»";
                    if (ZlobiCentrBol_Col.Text == "")
                    {
                        check = false;
                        ZlobiCentrBol_Col.BorderThickness = new Thickness(3);
                        ZlobiCentrBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + ZlobiCentrBol_Col.Text + " раз. ";
                }
                if (kalinkovCentrBol == true)
                {
                    hospOtherName = "УЗ «Калинковичская центральная районная больница»";
                    if (KalinkovCentrBol_Col.Text == "")
                    {
                        check = false;
                        KalinkovCentrBol_Col.BorderThickness = new Thickness(3);
                        KalinkovCentrBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + KalinkovCentrBol_Col.Text + " раз. ";
                }
                if (kormjanskCentrBol == true)
                {
                    hospOtherName = "УЗ «Кормянская центральная районная больница»";
                    if (KormjanskCentrBol_Col.Text == "")
                    {
                        check = false;
                        KormjanskCentrBol_Col.BorderThickness = new Thickness(3);
                        KormjanskCentrBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + KormjanskCentrBol_Col.Text + " раз. ";
                }
                if (lelcicCentrBol == true)
                {
                    hospOtherName = "УЗ «Лельчицкая центральная районная больница»";
                    if (LelcicCentrBol_Col.Text == "")
                    {
                        check = false;
                        LelcicCentrBol_Col.BorderThickness = new Thickness(3);
                        LelcicCentrBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + LelcicCentrBol_Col.Text + " раз. ";
                }
                if (loevskCentrBol == true)
                {
                    hospOtherName = "УЗ «Лоевская центральная районная больница»";
                    if (LoevskCentrBol_Col.Text == "")
                    {
                        check = false;
                        LoevskCentrBol_Col.BorderThickness = new Thickness(3);
                        LoevskCentrBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + LoevskCentrBol_Col.Text + " раз. ";
                }
                if (mozirCentrGorPolic == true)
                {
                    hospOtherName = "ГУЗ «Мозырская центральная городская поликлиника»";
                    if (MozirCentrGorPolic_Col.Text == "")
                    {
                        check = false;
                        MozirCentrGorPolic_Col.BorderThickness = new Thickness(3);
                        MozirCentrGorPolic_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + MozirCentrGorPolic_Col.Text + " раз. ";
                }
                if (narovlCentrBol == true)
                {
                    hospOtherName = "УЗ «Наровлянская центральная районная больница»";
                    if (NarovlCentrBol_Col.Text == "")
                    {
                        check = false;
                        NarovlCentrBol_Col.BorderThickness = new Thickness(3);
                        NarovlCentrBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + NarovlCentrBol_Col.Text + " раз. ";
                }
                if (oktjabrCentrBol == true)
                {
                    hospOtherName = "УЗ «Октябрьская центральная районная больница»";
                    if (OktjabrCentrBol_Col.Text == "")
                    {
                        check = false;
                        OktjabrCentrBol_Col.BorderThickness = new Thickness(3);
                        OktjabrCentrBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + OktjabrCentrBol_Col.Text + " раз. ";
                }
                if (petrikovCentrBol == true)
                {
                    hospOtherName = "УЗ «Петриковская центральная районная больница»";
                    if (PetrikovCentrBol_Col.Text == "")
                    {
                        check = false;
                        PetrikovCentrBol_Col.BorderThickness = new Thickness(3);
                        PetrikovCentrBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + PetrikovCentrBol_Col.Text + " раз. ";
                }
                if (recickajaCentBol == true)
                {
                    hospOtherName = "УЗ «Речицкая центральная районная больница»";
                    if (RecickajaCentBol_Col.Text == "")
                    {
                        check = false;
                        RecickajaCentBol_Col.BorderThickness = new Thickness(3);
                        RecickajaCentBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + RecickajaCentBol_Col.Text + " раз. ";
                }
                if (rogacevCentrBol == true)
                {
                    hospOtherName = "УЗ «Рогачевская центральная районная больница»";
                    if (RogacevCentrBol_Col.Text == "")
                    {
                        check = false;
                        RogacevCentrBol_Col.BorderThickness = new Thickness(3);
                        RogacevCentrBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + RogacevCentrBol_Col.Text + " раз. ";
                }
                if (svetlagorCentrBol == true)
                {
                    hospOtherName = "УЗ «Светлогорская центральная районная больница»";
                    if (SvetlagorCentrBol_Col.Text == "")
                    {
                        check = false;
                        SvetlagorCentrBol_Col.BorderThickness = new Thickness(3);
                        SvetlagorCentrBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + SvetlagorCentrBol_Col.Text + " раз. ";
                }
                if (hoinikCentrBol == true)
                {
                    hospOtherName = "УЗ «Хойникская центральная районная больница»";
                    if (HoinikCentrBol_Col.Text == "")
                    {
                        check = false;
                        HoinikCentrBol_Col.BorderThickness = new Thickness(3);
                        HoinikCentrBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + HoinikCentrBol_Col.Text + " раз. ";
                }
                if (cecerskajaCentrBol == true)
                {
                    hospOtherName = "УЗ «Чечерская центральная районная больница»";
                    if (CecerskajaCentrBol_Col.Text == "")
                    {
                        check = false;
                        CecerskajaCentrBol_Col.BorderThickness = new Thickness(3);
                        CecerskajaCentrBol_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + CecerskajaCentrBol_Col.Text + " раз. ";
                }
                string otherHosTextBox = OtherHospTextBox.Text;
                if (otherHosTextBox != "")
                {
                    hospOtherName += otherHosTextBox;
                    if (OtherHospTextBox_Col.Text == "")
                    {
                        check = false;
                        OtherHospTextBox_Col.BorderThickness = new Thickness(3);
                        OtherHospTextBox_Col.BorderBrush = Brushes.Red;
                    }
                    else hospOtherName += " " + OtherHospTextBox_Col.Text + " раз. ";
                }

                if (check == true)
                {
                    UnionData(hospOtherName);
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
        public void UnionData(string hospitelOther)
        {
            Other.HospitelOther = hospitelOther;
        }


        private void OblPsiNerDisp_Checked(object sender, RoutedEventArgs e)
        {
            oblPsiNerDisp = true;
        }
        private void OblPsiNerDisp_UnChecked(object sender, RoutedEventArgs e)
        {
            oblPsiNerDisp = false;
        }

        private void Ploska_Checked(object sender, RoutedEventArgs e)
        {
            ploska = true;
        }
        private void Ploska_UnChecked(object sender, RoutedEventArgs e)
        {
            ploska = false;
        }

        private void OblNarcoDis_Checked(object sender, RoutedEventArgs e)
        {
            oblNarcoDis = true;
        }
        private void OblNarcoDis_UnChecked(object sender, RoutedEventArgs e)
        {
            oblNarcoDis = false;
        }

        private void Mogilevci_Checked(object sender, RoutedEventArgs e)
        {
            mogilevci = true;
        }
        private void Mogilevci_UnChecked(object sender, RoutedEventArgs e)
        {
            mogilevci = false;
        }

        private void Krivoschin_Checked(object sender, RoutedEventArgs e)
        {
            krivoschin = true;
        }
        private void Krivoschin_UnChecked(object sender, RoutedEventArgs e)
        {
            krivoschin = false;
        }

        private void Goroditsche_Checked(object sender, RoutedEventArgs e)
        {
            goroditshe = true;
        }
        private void Goroditsche_UnChecked(object sender, RoutedEventArgs e)
        {
            goroditshe = false;
        }

        private void ScorajaPomotsch_Checked(object sender, RoutedEventArgs e)
        {
            skorajaPomotsch = true;
        }
        private void ScorajaPomotsch_UnChecked(object sender, RoutedEventArgs e)
        {
            skorajaPomotsch = false;
        }

        private void OblBolnica_Checked(object sender, RoutedEventArgs e)
        {
            oblBolnica = true;
        }
        private void OblBolnica_UnChecked(object sender, RoutedEventArgs e)
        {
            oblBolnica = false;
        }

        private void GorodHospCentr_Checked(object sender, RoutedEventArgs e)
        {
            gorodHospCentr = true;
        }
        private void GorodHospCentr_UnChecked(object sender, RoutedEventArgs e)
        {
            gorodHospCentr = false;
        }

        private void DetOblHosp_Checked(object sender, RoutedEventArgs e)
        {
            detOblHosp = true;
        }
        private void DetOblHosp_UnChecked(object sender, RoutedEventArgs e)
        {
            detOblHosp = false;
        }

        private void OblProtivTuberkDisp_Checked(object sender, RoutedEventArgs e)
        {
            oblProtivTuberDisp = true;
        }
        private void OblProtivTuberkDisp_UnChecked(object sender, RoutedEventArgs e)
        {
            oblProtivTuberDisp = false;
        }

        private void Verhovichi_Checked(object sender, RoutedEventArgs e)
        {
            verhovichi = true;
        }
        private void Verchovichi_UnChecked(object sender, RoutedEventArgs e)
        {
            verhovichi = false;
        }

        private void BerezCentrRaionHosp_Checked(object sender, RoutedEventArgs e)
        {
            berezCentrRaionHosp = true;
        }
        private void BerezCentrRaionHosp_UnChecked(object sender, RoutedEventArgs e)
        {
            berezCentrRaionHosp = false;
        }

        private void GancevichCentrRaionHosp_Checked(object sender, RoutedEventArgs e)
        {
            gancevichCentrRaionHosp = true;
        }
        private void GancevichCentrRaionHosp_UnChecked(object sender, RoutedEventArgs e)
        {
            gancevichCentrRaionHosp = false;
        }

        private void DrochinCentrHosp_Checked(object sender, RoutedEventArgs e)
        {
            drochinCentrRaionHosp = true;
        }
        private void DrochinCentrHosp_UnChecked(object sender, RoutedEventArgs e)
        {
            drochinCentrRaionHosp = false;
        }

        private void ZabinovskajaCentRaion_Checked(object sender, RoutedEventArgs e)
        {
            zabinovskajaCentRaion = true;
        }
        private void ZabinovskajaCentRaion_UnChecked(object sender, RoutedEventArgs e)
        {
            zabinovskajaCentRaion = false;
        }

        private void IvanovskajaCentrRaionHosp_Checked(object sender, RoutedEventArgs e)
        {
            ivanovskajaCentrRaionHosp = true;
        }
        private void IvanovskajaCentrRaionHosp_UnChecked(object sender, RoutedEventArgs e)
        {
            ivanovskajaCentrRaionHosp = false;
        }

        private void IvacevichskajaCentrRaionHosp_Checked(object sender, RoutedEventArgs e)
        {
            ivacevichskajaCentrRaionHosp = true;
        }
        private void IvacevichskajaCentrRaionHosp_UnChecked(object sender, RoutedEventArgs e)
        {
            ivacevichskajaCentrRaionHosp = false;
        }

        private void KameneckajaCentRaionHosp_Checked(object sender, RoutedEventArgs e)
        {
            kameneckajaCentRaionHosp = true;
        }
        private void KameneckajaCentRaionHosp_UnChecked(object sender, RoutedEventArgs e)
        {
            kameneckajaCentRaionHosp = false;
        }

        private void KobrinskajaCentrRaionHosp_Checked(object sender, RoutedEventArgs e)
        {
            kobrinskajaCentrRaionHosp = true;
        }
        private void KobrinskajaCentrRaionHosp_UnChecked(object sender, RoutedEventArgs e)
        {
            kobrinskajaCentrRaionHosp = false;
        }

        private void LunineckiCentrRaionHosp_Checked(object sender, RoutedEventArgs e)
        {
            lunineckiCentrRaionHosp = true;
        }
        private void LunineckiCentrRaionHosp_UnChecked(object sender, RoutedEventArgs e)
        {
            lunineckiCentrRaionHosp = false;
        }

        private void LjahovichiCentrRaionHosp_Checked(object sender, RoutedEventArgs e)
        {
            ljahovichiCentrRaionHosp = true;
        }
        private void LjahovichiCentrRaionHosp_UnChecked(object sender, RoutedEventArgs e)
        {
            ljahovichiCentrRaionHosp = false;
        }

        private void MaloritskajaCentrRaionHosp_Checked(object sender, RoutedEventArgs e)
        {
            maloritskajaCentrRaionHosp = true;
        }
        private void MaloritskajaCentrRaionHosp_UnChecked(object sender, RoutedEventArgs e)
        {
            maloritskajaCentrRaionHosp = false;
        }

        private void PruzanskajaCentrRaionHosp_Checked(object sender, RoutedEventArgs e)
        {
            pruzanskajaCentrRaionHosp = true;
        }
        private void PruzanskajaCentrRaionHosp_UnChecked(object sender, RoutedEventArgs e)
        {
            pruzanskajaCentrRaionHosp = false;
        }

        private void StolinskajaCentrRaionHosp_Checked(object sender, RoutedEventArgs e)
        {
            stolinskajaCentrRaionHosp = true;
        }
        private void StolinskajaCentrRaionHosp_UnChecked(object sender, RoutedEventArgs e)
        {
            stolinskajaCentrRaionHosp = false;
        }

        private void BaranMezRaionNarcoDis_Checked(object sender, RoutedEventArgs e)
        {
            baranMezRaionNarcoDis = true;
        }
        private void BaranMezRaionNarcoDis_UnChecked(object sender, RoutedEventArgs e)
        {
            baranMezRaionNarcoDis = false;
        }

        private void PinskMezRaionNarcoDis_Checked(object sender, RoutedEventArgs e)
        {
            pinskMezRaionNarcoDis = true;
        }
        private void PinskMezRaionNarcoDis_UnChecked(object sender, RoutedEventArgs e)
        {
            pinskMezRaionNarcoDis = false;
        }

        private void BaranoviciGorHos_Checked(object sender, RoutedEventArgs e)
        {
            baranoviciGorHos = true;
        }
        private void BaranoviciGorHos_UnChecked(object sender, RoutedEventArgs e)
        {
            baranoviciGorHos = false;
        }

        private void PinskaCenterHosp_Checked(object sender, RoutedEventArgs e)
        {
            pinskaCenterHosp = true;
        }
        private void PinskaCenterHosp_UnChecked(object sender, RoutedEventArgs e)
        {
            pinskaCenterHosp = false;
        }


        //Гомельская область 
        private void GomelOblKlinBol_Checked(object sender, RoutedEventArgs e)
        {
            gomelOblKlinBol = true;
        }
        private void GomelOblKlinBol_UnChecked(object sender, RoutedEventArgs e)
        {
            gomelOblKlinBol = false;
        }

        private void GomelGorKlinBol1_Checked(object sender, RoutedEventArgs e)
        {
            gomelGorKlinBol1 = true;
        }
        private void GomelGorKlinBol1_UnChecked(object sender, RoutedEventArgs e)
        {
            gomelGorKlinBol1 = false;
        }

        private void GomelGorKlinBol2_Checked(object sender, RoutedEventArgs e)
        {
            gomelGorKlinBol2 = true;
        }
        private void GomelGorKlinBol2_UnChecked(object sender, RoutedEventArgs e)
        {
            gomelGorKlinBol2 = false;
        }

        private void GomelGorKlinBol3_Checked(object sender, RoutedEventArgs e)
        {
            gomelGorKlinBol3 = true;
        }
        private void GomelGorKlinBol3_UnChecked(object sender, RoutedEventArgs e)
        {
            gomelGorKlinBol3 = false;
        }

        private void GomelGorBol4_Checked(object sender, RoutedEventArgs e)
        {
            gomelGorBol4 = true;
        }
        private void GomelGorBol4_UnChecked(object sender, RoutedEventArgs e)
        {
            gomelGorBol4 = false;
        }

        private void GomelGorKlinBolSkorMedPom_Checked(object sender, RoutedEventArgs e)
        {
            gomelGorKlinBolSkorMedPom = true;
        }
        private void GomelGorKlinBolSkorMedPom_UnChecked(object sender, RoutedEventArgs e)
        {
            gomelGorKlinBolSkorMedPom = false;
        }

        private void GomelOblInfekcKlinBol_Checked(object sender, RoutedEventArgs e)
        {
            gomelOblInfekcKlinBol = true;
        }
        private void GomelOblInfekcKlinBol_UnChecked(object sender, RoutedEventArgs e)
        {
            gomelOblInfekcKlinBol = false;
        }

        private void GomelOblKlinPsihBol_Checked(object sender, RoutedEventArgs e)
        {
            gomelOblKlinPsihBol = true;
        }
        private void GomelOblKlinPsihBol_UnChecked(object sender, RoutedEventArgs e)
        {
            gomelOblKlinPsihBol = false;
        }

        private void GomelOblSpecKlinBol_Checked(object sender, RoutedEventArgs e)
        {
            gomelOblSpecKlinBol = true;
        }
        private void GomelOblSpecKlinBol_UnChecked(object sender, RoutedEventArgs e)
        {
            gomelOblSpecKlinBol = false;
        }

        private void GomelOblTuberKlinBol_Checked(object sender, RoutedEventArgs e)
        {
            gomelOblTuberKlinBol = true;
        }
        private void GomelOblTuberKlinBol_UnChecked(object sender, RoutedEventArgs e)
        {
            gomelOblTuberKlinBol = false;
        }

        private void GomelIOV_Checked(object sender, RoutedEventArgs e)
        {
            gomelIOV = true;
        }
        private void GomelIOV_UnChecked(object sender, RoutedEventArgs e)
        {
            gomelIOV = false;
        }

        private void GomelOblKlinKardioCentr_Checked(object sender, RoutedEventArgs e)
        {
            gomelOblKlinKardioCentr = true;
        }
        private void GomelOblKlinKardioCentr_UnChecked(object sender, RoutedEventArgs e)
        {
            gomelOblKlinKardioCentr = false;
        }

        private void GomelOblKlinOnkoDis_Checked(object sender, RoutedEventArgs e)
        {
            gomelOblKlinOnkoDis = true;
        }
        private void GomelOblKlinOnkoDis_UnChecked(object sender, RoutedEventArgs e)
        {
            gomelOblKlinOnkoDis = false;
        }

        private void BraginCentrRaionBol_Checked(object sender, RoutedEventArgs e)
        {
            braginCentrRaionBol = true;
        }
        private void BraginCentrRaionBol_UnChecked(object sender, RoutedEventArgs e)
        {
            braginCentrRaionBol = false;
        }

        private void Buda_KoshelCentrBol_Checked(object sender, RoutedEventArgs e)
        {
            buda_KoshelCentrBol = true;
        }
        private void Buda_KoshelCentrBol_UnChecked(object sender, RoutedEventArgs e)
        {
            buda_KoshelCentrBol = false;
        }

        private void VetkovsCentrBol_Checked(object sender, RoutedEventArgs e)
        {
            vetkovsCentrBol = true;
        }
        private void VetkovsCentrBol_UnChecked(object sender, RoutedEventArgs e)
        {
            vetkovsCentrBol = false;
        }

        private void DobrushCentrBol_Checked(object sender, RoutedEventArgs e)
        {
            dobrushCentrBol = true;
        }
        private void DobrushCentrBol_UnChecked(object sender, RoutedEventArgs e)
        {
            dobrushCentrBol = false;
        }

        private void ElskajaCentrBol_Checked(object sender, RoutedEventArgs e)
        {
            elskajaCentrBol = true;
        }
        private void ElskajaCentrBol_UnChecked(object sender, RoutedEventArgs e)
        {
            elskajaCentrBol = false;
        }

        private void ZitkovsCentrBol_Checked(object sender, RoutedEventArgs e)
        {
            zitkovsCentrBol = true;
        }
        private void ZitkovsCentrBol_UnChecked(object sender, RoutedEventArgs e)
        {
            zitkovsCentrBol = false;
        }

        private void ZlobiCentrBol_Checked(object sender, RoutedEventArgs e)
        {
            zlobiCentrBol = true;
        }
        private void ZlobiCentrBol_UnChecked(object sender, RoutedEventArgs e)
        {
            zlobiCentrBol = false;
        }

        private void KalinkovCentrBol_Checked(object sender, RoutedEventArgs e)
        {
            kalinkovCentrBol = true;
        }
        private void KalinkovCentrBol_UnChecked(object sender, RoutedEventArgs e)
        {
            kalinkovCentrBol = false;
        }

        private void KormjanskCentrBol_Checked(object sender, RoutedEventArgs e)
        {
            kormjanskCentrBol = true;
        }
        private void KormjanskCentrBol_UnChecked(object sender, RoutedEventArgs e)
        {
            kormjanskCentrBol = false;
        }

        private void LelcicCentrBol_Checked(object sender, RoutedEventArgs e)
        {
            lelcicCentrBol = true;
        }
        private void LelcicCentrBol_UnChecked(object sender, RoutedEventArgs e)
        {
            lelcicCentrBol = false;
        }

        private void LoevskCentrBol_Checked(object sender, RoutedEventArgs e)
        {
            loevskCentrBol = true;
        }
        private void LoevskCentrBol_UnChecked(object sender, RoutedEventArgs e)
        {
            loevskCentrBol = false;
        }

        private void MozirCentrGorPolic_Checked(object sender, RoutedEventArgs e)
        {
            mozirCentrGorPolic = true;
        }
        private void MozirCentrGorPolic_UnChecked(object sender, RoutedEventArgs e)
        {
            mozirCentrGorPolic = false;
        }

        private void NarovlCentrBol_Checked(object sender, RoutedEventArgs e)
        {
            narovlCentrBol = true;
        }
        private void NarovlCentrBol_UnChecked(object sender, RoutedEventArgs e)
        {
            narovlCentrBol = false;
        }

        private void OktjabrCentrBol_Checked(object sender, RoutedEventArgs e)
        {
            oktjabrCentrBol = true;
        }
        private void OktjabrCentrBol_UnChecked(object sender, RoutedEventArgs e)
        {
            oktjabrCentrBol = false;
        }

        private void PetrikovCentrBol_Checked(object sender, RoutedEventArgs e)
        {
            petrikovCentrBol = true;
        }
        private void PetrikovCentrBol_UnChecked(object sender, RoutedEventArgs e)
        {
            petrikovCentrBol = false;
        }

        private void RecickajaCentBol_Checked(object sender, RoutedEventArgs e)
        {
            recickajaCentBol = true;
        }
        private void RecickajaCentBol_UnChecked(object sender, RoutedEventArgs e)
        {
            recickajaCentBol = false;
        }

        private void RogacevCentrBol_Checked(object sender, RoutedEventArgs e)
        {
            rogacevCentrBol = true;
        }
        private void RogacevCentrBol_UnChecked(object sender, RoutedEventArgs e)
        {
            rogacevCentrBol = false;
        }

        private void SvetlagorCentrBol_Checked(object sender, RoutedEventArgs e)
        {
            svetlagorCentrBol = true;
        }
        private void SvetlagorCentrBol_UnChecked(object sender, RoutedEventArgs e)
        {
            svetlagorCentrBol = false;
        }

        private void HoinikCentrBol_Checked(object sender, RoutedEventArgs e)
        {
            hoinikCentrBol = true;
        }
        private void HoinikCentrBol_UnChecked(object sender, RoutedEventArgs e)
        {
            hoinikCentrBol = false;
        }

        private void CecerskajaCentrBol_Checked(object sender, RoutedEventArgs e)
        {
            cecerskajaCentrBol = true;
        }
        private void CecerskajaCentrBol_UnChecked(object sender, RoutedEventArgs e)
        {
            cecerskajaCentrBol = false;
        }
    }
}
