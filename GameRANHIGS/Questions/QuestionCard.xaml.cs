using GameRANHIGS.Classes;
using GameRANHIGS.Classes.StaticClasses;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace GameRANHIGS.Questions
{
    /// <summary>
    /// Логика взаимодействия для QuestionCard.xaml
    /// </summary>
    public partial class QuestionCard : Window
    {
        string path;
        public QuestionCard()
        {
            InitializeComponent();
            var rand = new Random();
            var files = Directory.GetFiles(@"..\..\Questions\Tasks");
            string test;
            path = files[rand.Next(files.Count())];


            using (StreamReader reader = new StreamReader(path))
            {
                QuestionTextBlock.Text = reader.ReadLine();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }





        
        int maxManeyValue = 1000;
        public void OpekResCounterAdd(int value)
        {
            MainWindow owner = Owner as MainWindow;
            ConvertMoney convertMoney = new ConvertMoney();
            if (SaverCounter.OpekaCounter + Convert.ToInt32(value) < maxManeyValue)
            {
                SaverCounter.OpekaCounter += Convert.ToInt32(value);
                owner.opekCounterText.Text = convertMoney.ConvertValue(SaverCounter.OpekaCounter);
            }
            else if (SaverCounter.OpekaCounter < 1000)
            {
                SaverCounter.OpekaCounter += Convert.ToInt32(value);
                int ostat = SaverCounter.OpekaCounter % maxManeyValue;
                SaverCounter.OpekaCounter -= ostat;
                owner.opekCounterText.Text = convertMoney.ConvertValue(SaverCounter.OpekaCounter);
                OrgResCounter(ostat);
            }
            else
            {
                OrgResCounter(Convert.ToInt32(value));
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
                BlagResCounter(Convert.ToInt32(value));
            }
        }
        public void BlagResCounter(int value)
        {
            MainWindow owner = (Owner as MainWindow);
            ConvertMoney convertMoney = new ConvertMoney();
            SaverCounter.BlagCounter += value;
            owner.blagCounterText.Text = convertMoney.ConvertValue(SaverCounter.BlagCounter);
        }




        public void AddSpecialist(string value)
        {
            MainWindow owner = Owner as MainWindow;
            switch (value)
            {
                case ("Младший специалист"):
                    if (owner.LowSpecOpek.IsChecked == false)
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
                case ("Старший специалист"):
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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow owner = Owner as MainWindow;
            ConvertMoney convertMoney = new ConvertMoney();



           
            using (StreamReader reader = new StreamReader(path))
            {
                QuestionTextBlock.Text = reader.ReadLine();
                string fileName = System.IO.Path.GetFileName(path);
                string changeValue = reader.ReadLine();
                if (fileName.Split('_')[1] == "Money")
                {
                    if (fileName.Split('_')[0] == "Addition")
                    {
                        OpekResCounterAdd(Convert.ToInt32(changeValue));
                    }
                    else
                    {
                        if (SaverCounter.BlagCounter != 0)
                        {
                            SaverCounter.BlagCounter -= Convert.ToInt32(changeValue);
                            owner.blagCounterText.Text = convertMoney.ConvertValue(SaverCounter.BlagCounter);
                        }
                        else if (SaverCounter.BlagCounter == 0)
                        {
                            if (SaverCounter.OrgCounter != 0)
                            {
                                SaverCounter.OrgCounter -= Convert.ToInt32(changeValue);
                                owner.opekCounterText.Text = convertMoney.ConvertValue(SaverCounter.OrgCounter);
                            }
                            else
                            {
                                if (SaverCounter.OrgCounter == 0)
                                {
                                    SaverCounter.OpekaCounter -= Convert.ToInt32(changeValue);
                                    owner.opekCounterText.Text = convertMoney.ConvertValue(SaverCounter.OpekaCounter);
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (fileName.Split('_')[0] == "Subtraction")
                    {

                        if (changeValue == "Младший специалист")
                        {
                            if (owner.LowSpecBlag.IsChecked == true)
                            {
                                owner.LowSpecBlag.IsChecked = false;
                            }
                            else if (owner.LowSpecOrg.IsChecked == true)
                            {
                                owner.LowSpecOrg.IsChecked = false;
                            }
                            else
                            {
                                owner.LowSpecOpek.IsChecked = false;
                            }
                        }
                        else if (changeValue == "Старший специалист")
                        {
                            if (owner.HighSpecBlag.IsChecked == true)
                            {
                                owner.HighSpecBlag.IsChecked = false;
                            }
                            else if (owner.HighSpecOrg.IsChecked == true)
                            {
                                owner.HighSpecOrg.IsChecked = false;
                            }
                            else
                            {
                                owner.HighSpecOpec.IsChecked = false;
                            }
                        }
                        else
                        {
                            if (owner.SpecBlag.IsChecked == true)
                            {
                                owner.SpecBlag.IsChecked = false;
                            }
                            else if (owner.SpecOrg.IsChecked == true)
                            {
                                owner.SpecOrg.IsChecked = false;
                            }
                            else
                            {
                                owner.SpecOpec.IsChecked = false;
                            }
                        }
                    }
                    else
                    {
                        AddSpecialist(changeValue);
                    }
                }
            }
        }
    }




}
