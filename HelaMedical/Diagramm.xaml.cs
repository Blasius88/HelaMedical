using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using HelaMedical.Class;
using HelaMedical.Excep;

namespace HelaMedical
{
    /// <summary>
    /// Логика взаимодействия для Diagramm.xaml
    /// </summary>
    public partial class Diagramm : Window
    {
        ApplicationContext db;

        /// <summary>
        /// с какого деня поставлен на учет
        /// </summary>        
        private int dataDay_S { get; set; }
        
        /// <summary>
        /// с какого месяца поставлен на учет
        /// </summary>        
        private int dataMonth_S { get; set; }

        /// <summary>
        /// с какого год поставлен на учет
        /// </summary>        
        private int dataYaer_S { get; set; }

        /// <summary>
        /// по какой день поставлен на учет 
        /// </summary>
        private int dataDay_Po { get; set; }

        /// <summary>
        /// по какой месяц поставлен на учет
        /// </summary>
        private int dataMonth_Po { get; set; }
        
        /// <summary>
        /// по какой год поставлен на учет 
        /// </summary>
        private int dataYaer_Po { get; set; }

        /// <summary>
        /// построение диаграммы по х
        /// </summary>
        private double rectSpace { get; set; }
        
        /// <summary>
        /// построение диарамы по y
        /// </summary>
        private double rectWidth { get; set; }

        /// <summary>
        /// Вид зависимости
        /// </summary>
        private string typeOfAddiction ="";

        /// <summary>
        /// Региональный центр
        /// </summary>
        private string regionCenterBLR = "";

        /// <summary>
        /// период с 
        /// </summary>
        private string periodS = "";

        /// <summary>
        /// период по
        /// </summary>
        private string periodPo = "";

        private List<Alco> alco = new List<Alco>();
        private List<Alco> Alco_Person = new List<Alco>();

        private List<Narcoman> narco = new List<Narcoman>();
        private List<Narcoman> Narco_Person = new List<Narcoman>();

        private List<Polizavis> poliz = new List<Polizavis>();
        private List<Polizavis> Poliz_Person = new List<Polizavis>();

        public Diagramm()
        {
            db = new ApplicationContext();
            InitializeComponent();
            this.Closing += Closing_Click;
        }

        /// <summary>
        /// Property for datasource for chart
        /// </summary>
        private static readonly DependencyProperty dataSource = DependencyProperty.Register("dataSource", typeof(string), typeof(Diagramm));
        public string DataSource
        {
            get { return (string)this.GetValue(dataSource); }
            set { this.SetValue(dataSource, value); }
        }

        /// <summary>
        /// chart bars color
        /// </summary>
        private static readonly DependencyProperty barsColor = DependencyProperty.Register("barsColor", typeof(Brush), typeof(Diagramm));
        public Brush BarsColor
        {
            get { return (Brush)this.GetValue(barsColor); }
            set { this.SetValue(barsColor, value); }
        }

        /// <summary>
        /// Method for drawing bars /Rectangles
        /// </summary>        
        public void DrawBars(string a, string b, string c, string d)
        {
            try
            {
                //счетчик количества людей согласно условию
                int Cat1Value = 0;
                //счетчик по годам
                int Cat2Value = 0;
                if (a == "Алкогольная")
                {
                    for (int i = 0; i < Alco_Person.Count; i++)
                    {
                        if (b == Alco_Person[i].RegionCenterBLR)
                        {
                            string[] data = Alco_Person[i].DataOfRegistration.Split('.',',','/',';');
                            int dataDay = Convert.ToInt32(data[0]);
                            int dataMonth = Convert.ToInt32(data[1]);
                            int dataYaer = Convert.ToInt32(data[2]);
                            if (dataYaer_S <= dataYaer && dataYaer <= dataYaer_Po)
                            {
                                if (dataMonth_S <= dataMonth && dataMonth <= dataMonth_Po)
                                {
                                    if (dataDay_S <= dataDay && dataDay <= dataDay_Po)
                                    {
                                        Cat1Value++;

                                        //Image(Cat1Value, Cat2Value);
                                        //determine section depends on amount of Data
                                        double section = 1300 / Cat1Value;
                                        rectSpace = (section * 20) / 100;
                                        rectWidth = (section * 80) / 100;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (a == "Наркотическая")
                {
                    
                }
                else if (a == "Полизависимость")
                {
                    
                }



                

                //string Data = File.ReadAllText(DataSource);
                //string[] valueData = Data.Split(';');
                //string[] Cat1Value = valueData[0].Split(',');
                //string[] Cat2Value = valueData[1].Split(',');
                ////determine section depends on amount of Data
                //double section = 525 / Cat1Value.Length;
                ////space between bars, 20% of section  
                //rectSpace = (section * 20) / 100;
                ////bars width
                //rectWidth = (section * 80) / 100;

                ////Actual Drawing
                //// Рисует графики 
                //for (int i = 0; i < Cat1Value.Length; i++)
                //{
                //    Rectangle rec = new Rectangle();
                //    rec.Width = rectWidth;
                //    rec.Height = Convert.ToDouble(Cat1Value[i]);
                //    rec.Margin = new Thickness(rectSpace, (385 - rec.Height), 0, 25);
                //    rec.Fill = BarsColor;
                //    wPanel.Children.Add(rec);

                //    //Effect or animation 
                //    DoubleAnimation ani = new DoubleAnimation
                //    {
                //        From = 0,
                //        To = Convert.ToDouble(Cat1Value[i]),
                //        Duration = new TimeSpan(0, 0, 2)
                //    };

                //    // add animation
                //    ani.FillBehavior = FillBehavior.HoldEnd;
                //    rec.BeginAnimation(HeightProperty, ani);
                //    rec.Effect = new DropShadowEffect
                //    {
                //        Color = new Color { A = 1, R = 0, G = 139, B = 139 },
                //        Direction = 45,
                //        ShadowDepth = 10,
                //        Opacity = 0.8,
                //        BlurRadius = 10
                //    };

                //    // add exis Label 
                //    // добавляет подписи для графиков 
                //    Label label = new Label();
                //    label.Content = Cat2Value[i].ToString();
                //    label.Background = Brushes.Transparent;
                //    label.Foreground = Brushes.Black;
                //    label.Margin = new Thickness(rectSpace, 350, 0, 0);
                //    label.FontSize = 20 - Cat2Value.Length;
                //    label.Width = rec.Width;
                //    label.HorizontalAlignment = HorizontalAlignment.Center;
                //    label.Height = 30;
                //    stkPanel.Children.Add(label);

                //    //Show value on mouse hover 
                //    rec.MouseEnter += Rec_MouseEnter;
                //}

                //// add side lines/scale lines? each separated by value of 20
                //// рисует линие градиента 
                //for (int i = 20; i < 400; i += 20)
                //{
                //    Line line = new Line();
                //    line.X1 = 5;
                //    line.Y1 = i;
                //    line.X2 = 25;
                //    line.Y2 = i;
                //    line.Stroke = Brushes.SkyBlue;
                //    line.StrokeThickness = 1;
                //    grid.Children.Add(line);
                //}
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        public void Image(int Cat1Value, int Cat2Value)
        {

        }
        //загружаем инфу из бд
        public void DownLoad_Database(string a)
        {
            try
            {
                if (a == "Алкогольная")
                {
                    db = new ApplicationContext();
                    db.Alcos.Load();
                    foreach (var AlcoPer in db.Alcos)
                    {
                        Alco_Person.Add(AlcoPer);
                    }
                }
                else if (a == "Наркотическая")
                {
                    db = new ApplicationContext();
                    db.Narcomans.Load();
                    foreach (var NarcPer in db.Narcomans)
                    {
                        Narco_Person.Add(NarcPer);
                    }
                }
                else if (a == "Полизависимость")
                {
                    db = new ApplicationContext();
                    db.Polizaviss.Load();
                    foreach (var PoliPers in db.Polizaviss)
                    {
                        Poliz_Person.Add(PoliPers);
                    }
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// сортировка даты
        /// </summary>
        private void Sortirovka_Data(string a, string b)
        {
            try
            {
                string[] data = a.Split(';', ',', '.');
                int dataDay = int.Parse(data[0]);
                int dataMonth = int.Parse(data[1]);
                int dataYear = int.Parse(data[3]);
                if (dataDay > 31 && dataMonth > 12 && dataYear < 1900)
                {
                    MessageBox.Show("Не правельно ввели дату");
                    PeriodS.BorderThickness = new Thickness(3);
                    PeriodS.BorderBrush = Brushes.Red;
                    return;
                }
                else
                {
                    dataDay_S = Convert.ToInt32(dataDay);
                    dataMonth_S = Convert.ToInt32(dataMonth);
                    dataYaer_S = Convert.ToInt32(dataYear);
                }
                data = b.Split(';', ',', '.');
                dataDay = int.Parse(data[0]);
                dataMonth = int.Parse(data[1]);
                dataYear = int.Parse(data[3]);
                if (dataDay > 31 && dataMonth > 12 && dataYear < 1800)
                {
                    MessageBox.Show("Не правельно ввели дату");
                    PeriodPo.BorderThickness = new Thickness(3);
                    PeriodPo.BorderBrush = Brushes.Red;
                    return;
                }
                else
                {
                    dataDay_Po = Convert.ToInt32(dataDay);
                    dataMonth_Po = Convert.ToInt32(dataMonth);
                    dataYaer_Po = Convert.ToInt32(dataYear);
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        // обработчик на нажатие мышки 
        private void Rec_MouseEnter(object sender, MouseEventArgs e)
        {
            try
            {
                // Включает анимацию на появление значение Value
                DoubleAnimation anim = new DoubleAnimation
                {
                    From = 0.7,
                    To = 1,
                    Duration = new TimeSpan(0, 0, 1)
                };
                ((Rectangle)sender).BeginAnimation(OpacityProperty, anim);
                //-----------------------------------------------------------------------------------
                //обработка заначения Value
                popWindow.ClearValue(Popup.IsOpenProperty);
                popWindow.IsOpen = true;
                lblPopup.Content = "Value: " + ((Rectangle)sender).Height.ToString();
                //--------------------------------------------------------------------------------------
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        private void Closing_Click(object sender, CancelEventArgs e)
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

        private void Grafik_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                typeOfAddiction = TypeOfAddiction.Text;
                regionCenterBLR = RegionCenterBLR.Text;
                periodS = PeriodS.Text;
                periodPo = PeriodPo.Text;

                Sortirovka_Data(periodS, periodPo);

                DownLoad_Database(typeOfAddiction);
                DrawBars(typeOfAddiction, regionCenterBLR, periodS, periodPo);
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }
    }
}
