using GameRANHIGS.Classes;
using GameRANHIGS.Classes.StaticClasses;
using GameRANHIGS.Questions;
using GameRANHIGS.Resources.Cards.ResourcesCard;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameRANHIGS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        bool starter = false;



        public MainWindow()
        {
            InitializeComponent();
            ConvertMoney convertMoney = new ConvertMoney();
            opekCounterText.Text = convertMoney.ConvertValue(SaverCounter.OpekaCounter);
            orgCounterText.Text = convertMoney.ConvertValue(SaverCounter.OrgCounter);
            blagCounterText.Text = convertMoney.ConvertValue(SaverCounter.OpekaCounter);
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.Height = e.NewSize.Width / 2;

        }
        int gamerPlace = 0;
        private void Cube_Click(object sender, RoutedEventArgs e)
        
        {
            Random random = new Random();
            for (int i = 0; i < random.Next(1, 6); i++)
            {
                TestMethod();
            }
            var windowOpener = (FindName("Card_" + gamerPlace) as Border).Background.ToString();
            switch (windowOpener)
            {
                case ("#FFF9B4B4"):
                    MessageBox.Show("TaskWIndow");
                    break;
                case ("#FFFFFF92"):
                    QuestionCard questionCard = new QuestionCard();
                    questionCard.Owner = this;
                    questionCard.ShowDialog();
                    break;
                case ("#FFC8C8C8"):
                    ResourcesCard resourcesCard = new ResourcesCard();
                    resourcesCard.Owner = this;
                    resourcesCard.ShowDialog();
                    break;
                default:
                    break;
            }
        }
        public void TestMethod()
        {
            if (gamerPlace < 39)
            {
                (FindName("Card_" + gamerPlace) as Border).BorderBrush = Brushes.Black;
                (FindName("Card_" + gamerPlace) as Border).BorderThickness = new Thickness(3);
                gamerPlace++;
                (FindName("Card_" + gamerPlace) as Border).BorderBrush = Brushes.Green;
                (FindName("Card_" + gamerPlace) as Border).BorderThickness = new Thickness(5);

                var windowOpener = (FindName("Card_" + gamerPlace) as Border).Background.ToString();
            }
            else
            {
                (FindName("Card_" + gamerPlace) as Border).BorderBrush = Brushes.Black;
                (FindName("Card_" + gamerPlace) as Border).BorderThickness = new Thickness(3);
                gamerPlace = 0;
                (FindName("Card_" + gamerPlace) as Border).BorderBrush = Brushes.Green;
                (FindName("Card_" + gamerPlace) as Border).BorderThickness = new Thickness(5);
            }

        }
    }
}
