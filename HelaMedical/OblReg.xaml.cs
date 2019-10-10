using System;
using System.Windows;
using HelaMedical.Class;
using HelaMedical.Excep;

namespace HelaMedical
{
    /// <summary>
    /// Логика взаимодействия для OblReg.xaml
    /// </summary>
    public partial class OblReg : Window
    {
        public OblReg()
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

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Other.Obl == "" || Other.Reg == ""|| Other.Obl == null || Other.Reg == null)
                {
                    MessageBox.Show("Не выбрали район");
                    return;
                }
                else Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
                return;
            }

        }

        private void Brest1_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Бресткая обл";
            Other.Reg = "Барановичский р-н";
        }

        private void Brest2_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Бресткая обл";
            Other.Reg = "Берёзовский р-н";
        }

        private void Brest3_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Бресткая обл";
            Other.Reg = "Брестский р-н";
        }

        private void Brest4_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Бресткая обл";
            Other.Reg = "Ганцевичский р-н";
        }

        private void Brest5_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Бресткая обл";
            Other.Reg = "Дрогичинский р-н";
        }

        private void Brest6_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Бресткая обл";
            Other.Reg = "Жабинковский р-н";
        }

        private void Brest7_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Бресткая обл";
            Other.Reg = "Ивановский р-н";
        }

        private void Brest8_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Бресткая обл";
            Other.Reg = "Ивацевичский р-н";
        }

        private void Brest9_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Бресткая обл";
            Other.Reg = "Каменецкий р-н";
        }

        private void Brest10_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Бресткая обл";
            Other.Reg = "Кобринский р-н";
        }

        private void Brest11_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Бресткая обл";
            Other.Reg = "Лунинецкий р-н";
        }
        private void Brest12_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Бресткая обл";
            Other.Reg = "Ляховичский р-н";
        }

        private void Brest13_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Бресткая обл";
            Other.Reg = "Малоритский р-н";
        }

        private void Brest14_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Бресткая обл";
            Other.Reg = "Пинский р-н";
        }

        private void Brest15_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Бресткая обл";
            Other.Reg = "Пружанский р-н";
        }

        private void Brest16_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Бресткая обл";
            Other.Reg = "Столинский р-н";
        }

     

        private void Vitebsk1_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Витебская обл";
            Other.Reg = "Бешенковичский р-н";
        }

        private void Vitebsk2_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Витебская обл";
            Other.Reg = "Браславский р-н";
        }

        private void Vitebsk3_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Витебская обл";
            Other.Reg = "Верхнедвинский р-н";

        }

        private void Vitebsk4_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Витебская обл";
            Other.Reg = "Витебский р-н";

        }

        private void Vitebsk5_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Витебская обл";
            Other.Reg = "Глубокский р-н";

        }

        private void Vitebsk6_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Витебская обл";
            Other.Reg = "Городокский р-н";

        }

        private void Vitebsk7_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Витебская обл";
            Other.Reg = "Докшицкий р-н";

        }

        private void Vitebsk8_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Витебская обл";
            Other.Reg = "Дубровенский р-н";

        }

        private void Vitebsk9_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Витебская обл";
            Other.Reg = "Лепельский р-н";

        }

        private void Vitebsk10_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Витебская обл";
            Other.Reg = "Лиозненский р-н";

        }

        private void Vitebsk11_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Витебская обл";
            Other.Reg = "Миорский р-н";

        }

        private void Vitebsk12_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Витебская обл";
            Other.Reg = "Оршанский р-н";

        }

        private void Vitebsk13_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Витебская обл";
            Other.Reg = "Полоцкий р-н";

        }

        private void Vitebsk14_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Витебская обл";
            Other.Reg = "Поставский р-н";

        }

        private void Vitebsk15_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Витебская обл";
            Other.Reg = "Россонский р-н";

        }

        private void Vitebsk16_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Витебская обл";
            Other.Reg = "Сенненский р-н";

        }

        private void Vitebsk17_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Витебская обл";
            Other.Reg = "Толочинский р-н";

        }

        private void Vitebsk18_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Витебская обл";
            Other.Reg = "Ушачский р-н";


        }

        private void Vitebsk19_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Витебская обл";
            Other.Reg = "Чашникский р-н";

        }

        private void Vitebsk20_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Витебская обл";
            Other.Reg = "Шарковщинский р-н";

        }

        private void Vitebsk21_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Витебская обл";
            Other.Reg = "Шумилинский р-н";

        }

        private void Gomel1_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гомельская обл";
            Other.Reg = "Брагинский р-н";
        }

        private void Gomel2_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гомельская обл";
            Other.Reg = "Буда-Кошелевский р-н";
        }

        private void Gomel3_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гомельская обл";
            Other.Reg = "Ветковский р-н";

        }

        private void Gomel4_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гомельская обл";
            Other.Reg = "Гомельский р-н";

        }

        private void Gomel5_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гомельская обл";
            Other.Reg = "Добрушский р-н";

        }

        private void Gomel6_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гомельская обл";
            Other.Reg = "Ельский р-н";

        }

        private void Gomel7_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гомельская обл";
            Other.Reg = "Житковичский р-н";

        }

        private void Gomel8_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гомельская обл";
            Other.Reg = "Жлобинский р-н";

        }

        private void Gomel9_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гомельская обл";
            Other.Reg = "Калинковичский р-н";

        }

        private void Gomel10_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гомельская обл";
            Other.Reg = "Кормянский р-н";

        }

        private void Gomel11_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гомельская обл";
            Other.Reg = "Лельчицкий р-н";

        }

        private void Gomel12_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гомельская обл";
            Other.Reg = "Лоевский р-н";

        }

        private void Gomel13_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гомельская обл";
            Other.Reg = "Мозырский р-н";

        }

        private void Gomel14_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гомельская обл";
            Other.Reg = "Наровлянский р-н";

        }

        private void Gomel15_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гомельская обл";
            Other.Reg = "Октябрьский р-н";

        }

        private void Gomel16_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гомельская обл";
            Other.Reg = "Петриковский р-н";

        }

        private void Gomel17_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гомельская обл";
            Other.Reg = "Речицкий р-н";

        }

        private void Gomel18_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гомельская обл";
            Other.Reg = "Рогачевский р-н";

        }

        private void Gomel19_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гомельская обл";
            Other.Reg = "Светлогорский р-н";

        }

        private void Gomel20_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гомельская обл";
            Other.Reg = "Хойникский р-н";

        }

        private void Gomel21_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гомельская обл";
            Other.Reg = "Чечерский р-н";

        }

        private void Grodno1_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гродненская обл";
            Other.Reg = "Берестовицкий р-н";

        }

        private void Grodno2_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гродненская обл";
            Other.Reg = "Волковысский р-н";
        }

        private void Grodno3_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гродненская обл";
            Other.Reg = "Вороновский р-н";
        }

        private void Grodno4_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гродненская обл";
            Other.Reg = "Гродненский р-н";
        }

        private void Grodno5_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гродненская обл";
            Other.Reg = "Дятловский р-н";
        }

        private void Grodno6_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гродненская обл";
            Other.Reg = "Зельвенский р-н";
        }

        private void Grodno7_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гродненская обл";
            Other.Reg = "Ивьевский р-н";
        }

        private void Grodno8_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гродненская обл";
            Other.Reg = "Кореличский р-н";
        }

        private void Grodno9_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гродненская обл";
            Other.Reg = "Лидский р-н";
        }

        private void Grodno10_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гродненская обл";
            Other.Reg = "Мостовский р-н";
        }

        private void Grodno11_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гродненская обл";
            Other.Reg = "Новогрудский р-н";
        }

        private void Grodno12_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гродненская обл";
            Other.Reg = "Островецкий р-н";
        }

        private void Grodno13_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гродненская обл";
            Other.Reg = "Ошмянский р-н";
        }

        private void Grodno14_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гродненская обл";
            Other.Reg = "Свислочский р-н";
        }

        private void Grodno15_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гродненская обл";
            Other.Reg = "Слонимский р-н";
        }

        private void Grodno16_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гродненская обл";
            Other.Reg = "Сморгонский р-н";
        }

        private void Grodno17_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Гродненская обл";
            Other.Reg = "Щучинский р-н";
        }

        private void Minsk1_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Минская обл";
            Other.Reg = "Березинский р-н";
        }

        private void Minsk2_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Минская обл";
            Other.Reg = "Борисовский р-н";

        }

        private void Minsk3_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Минская обл";
            Other.Reg = "Вилейский р-н";

        }

        private void Minsk4_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Минская обл";
            Other.Reg = "Воложинский р-н";

        }

        private void Minsk5_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Минская обл";
            Other.Reg = "Дзержинский р-н";

        }

        private void Minsk6_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Минская обл";
            Other.Reg = "Клецкий р-н";

        }

        private void Minsk7_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Минская обл";
            Other.Reg = "Копыльский р-н";

        }

        private void Minsk8_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Минская обл";
            Other.Reg = "Крупский р-н";

        }

        private void Minsk9_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Минская обл";
            Other.Reg = "Логойский р-н";

        }

        private void Minsk10_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Минская обл";
            Other.Reg = "Любанский р-н";

        }

        private void Minsk11_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Минская обл";
            Other.Reg = "Минский р-н";

        }

        private void Minsk12_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Минская обл";
            Other.Reg = "Молодечненский р-н";

        }

        private void Minsk13_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Минская обл";
            Other.Reg = "Мядельский р-н";

        }

        private void Minsk14_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Минская обл";
            Other.Reg = "Несвижский р-н";

        }

        private void Minsk15_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Минская обл";
            Other.Reg = "Пуховичский р-н";

        }

        private void Minsk16_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Минская обл";
            Other.Reg = "Слуцкий р-н";

        }

        private void Minsk17_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Минская обл";
            Other.Reg = "Смолевичский р-н";

        }

        private void Minsk18_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Минская обл";
            Other.Reg = "Солигорский р-н";

        }

        private void Minsk19_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Минская обл";
            Other.Reg = "Стародорожский р-н";

        }

        private void Minsk20_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Минская обл";
            Other.Reg = "Столбцовский р-н";

        }

        private void Minsk21_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Минская обл";
            Other.Reg = "Узденский р-н";

        }

        private void Minsk22_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Минская обл";
            Other.Reg = "Червенский р-н";

        }

        private void Mogilev1_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Могилевская обл";
            Other.Reg = "Белыничский р-н";
        }

        private void Mogilev2_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Могилевская обл";
            Other.Reg = "Бобруйский р-н";

        }

        private void Mogilev3_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Могилевская обл";
            Other.Reg = "Быховский р-н";

        }

        private void Mogilev4_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Могилевская обл";
            Other.Reg = "Глусский р-н";

        }

        private void Mogilev5_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Могилевская обл";
            Other.Reg = "Горецкий р-н";

        }

        private void Mogilev6_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Могилевская обл";
            Other.Reg = "Дрибинский р-н";

        }

        private void Mogilev7_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Могилевская обл";
            Other.Reg = "Кировский р-н";

        }

        private void Mogilev8_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Могилевская обл";
            Other.Reg = "Климовичский р-н";

        }

        private void Mogilev9_Checked(object sender, RoutedEventArgs e)
        {

            Other.Obl = "Могилевская обл";
            Other.Reg = "Кличевский р-н";
        }

        private void Mogilev10_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Могилевская обл";
            Other.Reg = "Костюковичский р-н";

        }

        private void Mogilev11_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Могилевская обл";
            Other.Reg = "Краснопольский р-н";
        }

        private void Mogilev12_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Могилевская обл";
            Other.Reg = "Кричевский р-н";
        }

        private void Mogilev13_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Могилевская обл";
            Other.Reg = "Круглянский р-н";
        }

        private void Mogilev14_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Могилевская обл";
            Other.Reg = "Могилевский р-н";
        }

        private void Mogilev15_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Могилевская обл";
            Other.Reg = "Мстиславский р-н";
        }

        private void Mogilev16_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Могилевская обл";
            Other.Reg = "Осиповичский р-н";
        }

        private void Mogilev17_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Могилевская обл";
            Other.Reg = "Славгородский р-н";
        }

        private void Mogilev18_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Могилевская обл";
            Other.Reg = "Хотимский р-н";
        }

        private void Mogilev19_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Могилевская обл";
            Other.Reg = "Чаусский р-н";
        }

        private void Mogilev20_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Могилевская обл";
            Other.Reg = "Чериковский р-н";
        }

        private void Mogilev21_Checked(object sender, RoutedEventArgs e)
        {
            Other.Obl = "Могилевская обл";
            Other.Reg = "Шкловский р-н";
        }
    }
}
