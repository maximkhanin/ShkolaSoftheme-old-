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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int counter = 2;
        private int number2;
        public MainWindow()
        {
            InitializeComponent();
            counterLabel.Content = "Number of attempts - " + counter;
            number2 = GenerateNumber();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = textBox.Text;
            try
            {
                int number1 = int.Parse(text);
                if (CheckAnswer(number1, number2))
                {
                    MessageBox.Show("You guessed", "Task1");
                    textBox.Text = "";
                    counter = 2;
                    number2 = GenerateNumber();
                    counterLabel.Content = "Number of attempts - " + counter;
                }
                else
                {
                    counter -= 1;
                    textBox.Text = "";
                    MessageBox.Show("Try again", "Task1");
                    counterLabel.Content = "number of attempts - " + counter;
                }
                if (counter == 0)
                {
                    MessageBox.Show("You loose", "Task1");
                    textBox.Text = "";
                    counter = 2;
                    counterLabel.Content = "Number of attempts - " + counter;
                    number2 = GenerateNumber();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Task1");
            }

        }
        private int GenerateNumber()
        {
            Random rnd = new Random();
            return rnd.Next(1, 11);
        }
        private bool CheckAnswer(int number1, int number2)
        {
            if (number1 == number2)
            {
                return true;
            }
            else return false;
        }
    }
}
