using GameRANHIGS.Classes;
using Newtonsoft.Json;
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

namespace GameRANHIGS.Resources.Cards.TaskCard
{
    /// <summary>
    /// Логика взаимодействия для TaskWindow.xaml
    /// </summary>
    public partial class TaskWindow : Window
    {
        //Переменная для хранения кейс-задания
        CaseEntities caseEntities;
        public TaskWindow()
        {
            InitializeComponent();

            //Десереализцаия json файла
            string fileName = @"..\..\Resources\Cards\TaskCard\Tasks\Case_1.json";
            string jsonString = File.ReadAllText(fileName);
            List<CaseEntities> rootobject = JsonConvert.DeserializeObject<List<CaseEntities>>(jsonString);

            //Выбор случайного кейс-задания
            Random random = new Random();
            caseEntities = rootobject[random.Next(rootobject.Count())];

            //Заполнения текста кейс-задания и вопроса к нему 
            TaskText.Text = caseEntities.taskCase;
            TaskQuestionText.Text = caseEntities.questionTask;
            explanationText.Text = caseEntities.explanation;

            //Вывод ответов с помощью элемента RadioButton
            foreach(var item in caseEntities.answers)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Content = item.answerText;
                radioButton.Checked += RadioButton_Checked;

                answerList.Children.Add(radioButton);
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var goodAnswer = caseEntities.answers.Where(t => t.correctAnswer == true).Select(t => t).FirstOrDefault();
            //блокируем возможность изменения значения
            foreach (var item in answerList.Children)
            {
                (item as RadioButton).IsEnabled = false;
                if((item as RadioButton).Content.ToString() == goodAnswer.answerText)
                {
                    (item as RadioButton).Foreground = Brushes.Green;
                }
            }

            RadioButton radio = (RadioButton)sender;
            var test = caseEntities.answers.Where(t => t.answerText == radio.Content.ToString()).Select(t => t.correctAnswer).First();

            MainWindow owner = Owner as MainWindow;

            if (test)
            {
                radio.Foreground = Brushes.Green;
                foreach(var item in owner.CaseStack.Children)
                {
                    if(item is CheckBox)
                    {
                        if((item as CheckBox).IsChecked == true)
                        {
                            continue;
                        }
                        else
                        {
                            (item as CheckBox).IsChecked = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                radio.Foreground= Brushes.Red;
            }
            explanationText.IsEnabled = true;
            ExitButton.IsEnabled = true;
            //foreach(var item in caseEntities.answers)
            //{
            //    if(item.answerText == radio.Content.ToString() && item.correctAnswer == true)
            //    {
            //        MessageBox.Show("Вы выбрали правильный ответ");
            //        break;
            //    }
            //    else if(item.answerText == radio.Content.ToString() && item.correctAnswer == false)
            //    {
            //        MessageBox.Show("Вы выбрали неправильное значение");
            //        break;
            //    }
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
