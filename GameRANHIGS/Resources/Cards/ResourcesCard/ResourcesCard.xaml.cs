using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using GameRANHIGS.Classes;
using GameRANHIGS.Classes.StaticClasses;

namespace GameRANHIGS.Resources.Cards.ResourcesCard
{
    /// <summary>
    /// Логика взаимодействия для ResourcesCard.xaml
    /// </summary>

    //класс для определения типа ресурса
   

    public partial class ResourcesCard : Window
    {
        GameResourcesType resources = new GameResourcesType();
        public ResourcesCard()
        {
            InitializeComponent();
            Random random = new Random();
            resources = ResourcesList.resourcesList[random.Next(ResourcesList.resourcesList.Count())];
            switch (resources.ResourcesType)
            {
                case ("Специалист"):
                    ResourcesImage.Source = new BitmapImage(new Uri(@"/Resources/Images/specialist.png", UriKind.Relative));
                    ResourcesText.Text = resources.ResourcesValue;
                    break;
                case ("Деньги"):
                    ResourcesImage.Source = new BitmapImage(new Uri(@"/Resources/Images/ruble_sign.png", UriKind.Relative));
                    ResourcesText.Text = resources.ResourcesValue;
                    break;
                default:
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ResourcesWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            switch (resources.ResourcesType)
            {
                case ("Специалист"):
                    AddSpecialist();
                    break;
                case ("Деньги"):
                    OpekResCounter();
                    break;
                default:
                    break;
            }

        }

        //Метод для добавления спеаицлистов в чек-листе
        public void AddSpecialist()
        {
            MainWindow owner = Owner as MainWindow;
            switch (resources.ResourcesValue)
            {
                case ("Младший Специалист"): 
                    if(owner.LowSpecOpek.IsChecked == false)
                    {
                        owner.LowSpecOpek.IsChecked = true;
                    }
                    else if (owner.LowSpecOrg.IsChecked == false)
                    {
                        owner.LowSpecOrg.IsChecked = true;
                    }
                    else
                    {
                        owner.LowSpecBlag.IsChecked = true;
                    }
                    break;
                case ("Специалист"):
                    if (owner.SpecOpec.IsChecked == false)
                    {
                        owner.SpecOpec.IsChecked = true;
                    }
                    else if (owner.SpecOrg.IsChecked == false)
                    {
                        owner.SpecOrg.IsChecked = true;
                    }
                    else
                    {
                        owner.SpecBlag.IsChecked = true;
                    }
                    break;
                case ("Старший Специалист"):
                    if (owner.HighSpecOpec.IsChecked == false)
                    {
                        owner.HighSpecOpec.IsChecked = true;
                    }
                    else if (owner.HighSpecOrg.IsChecked == false)
                    {
                        owner.HighSpecOrg.IsChecked = true;
                    }
                    else
                    {
                        owner.HighSpecBlag.IsChecked = true;
                    }
                    break;
                default:
                    break;
            }
        }

        int maxManeyValue = 1000;

        public void OpekResCounter()
        {
            MainWindow owner = (Owner as MainWindow);
            ConvertMoney convertMoney = new ConvertMoney();
            if (SaverCounter.OpekaCounter + Convert.ToInt32(resources.ResourcesValue) < maxManeyValue)
            {
                SaverCounter.OpekaCounter += Convert.ToInt32(resources.ResourcesValue);
                owner.opekCounterText.Text = convertMoney.ConvertValue(SaverCounter.OpekaCounter);
            }
            else if(SaverCounter.OpekaCounter < 1000)
            {
                SaverCounter.OpekaCounter += Convert.ToInt32(resources.ResourcesValue);
                int ostat = SaverCounter.OpekaCounter % maxManeyValue;
                SaverCounter.OpekaCounter -= ostat;
                owner.opekCounterText.Text = convertMoney.ConvertValue(SaverCounter.OpekaCounter);
                OrgResCounter(ostat);
            }
            else
            {
                OrgResCounter(Convert.ToInt32(resources.ResourcesValue));
            }
            
        }
        public void OrgResCounter(int value)
        {
            MainWindow owner = (Owner as MainWindow);
            ConvertMoney convertMoney = new ConvertMoney();
            if (SaverCounter.OrgCounter + value < maxManeyValue)
            {
                SaverCounter.OrgCounter += value;
                owner.orgCounterText.Text = convertMoney.ConvertValue(SaverCounter.OrgCounter);
            }
            else if (SaverCounter.OrgCounter < maxManeyValue)
            {
                SaverCounter.OrgCounter += value;
                int ostat = SaverCounter.OrgCounter % maxManeyValue;
                SaverCounter.OrgCounter -= ostat;
                owner.orgCounterText.Text = convertMoney.ConvertValue(SaverCounter.OrgCounter);
                BlagResCounter(ostat);
            }
            else
            {
                BlagResCounter(Convert.ToInt32(resources.ResourcesValue));
            }
        }
        public void BlagResCounter(int value)
        {
            MainWindow owner = (Owner as MainWindow);
            ConvertMoney convertMoney = new ConvertMoney();
            SaverCounter.BlagCounter += value;
            owner.blagCounterText.Text = convertMoney.ConvertValue(SaverCounter.BlagCounter);
        }
    }
}
