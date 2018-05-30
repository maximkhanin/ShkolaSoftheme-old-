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

namespace Task2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Run(int day, int month, int year, Image image, Label label)
        {
            if (month == 1 && day >= 20 || month == 2 && day <= 18)
            {
                label.Content = "Aquarius";
                image.Source = new BitmapImage(new Uri(@"aquarius.jpg", UriKind.Relative));

            }
            else if (month == 2 && day >= 19 || month == 3 && day <= 20)
            {
                label.Content = "Pisces";
                image.Source = new BitmapImage(new Uri(@"pisces.jpg", UriKind.Relative));
            }
            else if (month == 3 && day >= 21 || month == 4 && day <= 19)
            {
                label.Content = "Aries";
                image.Source = new BitmapImage(new Uri(@"aries.jpg", UriKind.Relative));
            }
            else if (month == 4 && day >= 20 || month == 5 && day <= 20)
            {
                label.Content = "Taurus";
                image.Source = new BitmapImage(new Uri(@"taurus.jpg", UriKind.Relative));
            }
            else if (month == 5 && day >= 21 || month == 6 && day <= 21)
            {
                label.Content = "Gemini";
                image.Source = new BitmapImage(new Uri(@"gemini.jpg", UriKind.Relative));
            }
            else if (month == 6 && day >= 22 || month == 7 && day <= 22)
            {
                label.Content = "Cancer";
                image.Source = new BitmapImage(new Uri(@"cancer.jpg", UriKind.Relative));
            }
            else if (month == 7 && day >= 23 || month == 8 && day <= 22)
            {
                label.Content = "Leo";
                image.Source = new BitmapImage(new Uri(@"leo.jpg", UriKind.Relative));
            }
            else if (month == 8 && day >= 23 || month == 9 && day <= 22)
            {
                label.Content = "Virgo";
                image.Source = new BitmapImage(new Uri(@"virgo.jpg", UriKind.Relative));
            }
            else if (month == 9 && day >= 23 || month == 10 && day <= 22)
            {
                label.Content = "Libra";
                image.Source = new BitmapImage(new Uri(@"libra.jpg", UriKind.Relative));
            }
            else if (month == 10 && day >= 23 || month == 11 && day <= 21)
            {
                label.Content = "Scorpio";
                image.Source = new BitmapImage(new Uri(@"scorpio.jpg", UriKind.Relative));
            }
            else if (month == 11 && day >= 22 || month == 12 && day <= 21)
            {
                label.Content = "Sagittarius";
                image.Source = new BitmapImage(new Uri(@"sagittarius.jpg", UriKind.Relative));
            }
            else if (month == 12 && day >= 22 || month == 1 && day <= 19)
            {
                label.Content = "Capricorn";
                image.Source = new BitmapImage(new Uri(@"capricorn.jpg", UriKind.Relative));
            }
            else
            {
                label.Content = "Invalid Data";
               
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Run(int.Parse(day.Text), int.Parse(month.Text), int.Parse(year.Text), zodiacSignsImage, zodiacSignsText);
        }
    }
}
