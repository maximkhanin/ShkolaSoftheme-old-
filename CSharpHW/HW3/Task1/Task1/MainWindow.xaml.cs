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

namespace Task1
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
        private bool NameCheck(string text)
        {
            if (text.Length < 255)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (!(Char.IsLetter(text[i]))){
                        return false;
                    }
                }
                return true;
            }
            else return false;
            
        }

        private bool BirthCheck(string text)
        {
            string[] dateOfBirth = text.Split('/');
            try
            {
                if ((int.Parse(dateOfBirth[0]) > 0 && int.Parse(dateOfBirth[0]) < 32) && (int.Parse(dateOfBirth[1]) > 0 && int.Parse(dateOfBirth[1]) < 13)
                    && (int.Parse(dateOfBirth[2]) > 1900 && int.Parse(dateOfBirth[2]) < int.Parse(DateTime.Now.Year.ToString())))
                {
                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
            }

        }

        private bool GenderCheck(string text)
        {
            if (text == "male" || text == "Male" || text == "Female" || text == "female")
            {
                return true;
            }
            else return false;
        }

        private bool EmailCheck(string text)
        {
            if (text.Length < 255 && text.Contains("@"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool PhNumberCheck(string text)
        {
            if (text.Length == 12)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (!(Char.IsDigit(text[i])))
                    {
                        return false;
                    }
                }
                return true;
            }
            else return false;
        }

        private bool AdInfoCheck (string text)
        {
            if (text.Length < 2000)
            {
                return true;
            }
            else return false;
        }

        private void Run()
        {
            if (NameCheck(firstName.Text) && NameCheck(lastName.Text)
                && BirthCheck(birthDate.Text) && GenderCheck(gender.Text) &&
                EmailCheck(email.Text) && PhNumberCheck(phNumber.Text)&&
                AdInfoCheck(addInfo.Text)){
                MessageBox.Show("Data is valid", "Task1");
            }
            else
            {
                MessageBox.Show("Data is invalid", "Task1");
            }
        }


        private void check_Click(object sender, RoutedEventArgs e)
        {
            Run();
        }
    }
}
