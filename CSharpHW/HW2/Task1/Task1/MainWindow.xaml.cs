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
        private string _rbType="";
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement c in layoutStackPanelTypes.Children)
            {
                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked += RadioButtonType_Checked;
                }
                
            }
            button1.Click += Button_Click;
            
        }
        private void RadioButtonType_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            _rbType = pressed.Content.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (_rbType)
            {

                case "sbyte":
                    maxValue.Content = sbyte.MaxValue.ToString();
                    minValue.Content = sbyte.MinValue.ToString();
                    defaultValue.Content = default(sbyte).ToString();
                    break;
                case "byte":
                    maxValue.Content = byte.MaxValue.ToString();
                    minValue.Content = byte.MinValue.ToString();
                    defaultValue.Content = default(byte).ToString();
                    break;
                case "short":
                    maxValue.Content = short.MaxValue.ToString();
                    minValue.Content = short.MinValue.ToString();
                    defaultValue.Content = default(short).ToString();
                    break;
                case "ushort":
                    maxValue.Content = ushort.MaxValue.ToString();
                    minValue.Content = ushort.MinValue.ToString();
                    defaultValue.Content = default(ushort).ToString();
                    break;
                case "int":
                    maxValue.Content = int.MaxValue.ToString();
                    minValue.Content = int.MinValue.ToString();
                    defaultValue.Content = default(int).ToString();
                    break;
                case "uint":
                    maxValue.Content = uint.MaxValue.ToString();
                    minValue.Content = uint.MinValue.ToString();
                    defaultValue.Content = default(uint).ToString();
                    break;
                case "long":
                    maxValue.Content = long.MaxValue.ToString();
                    minValue.Content = long.MinValue.ToString();
                    defaultValue.Content = default(long).ToString();
                    break;
                case "ulong":
                    maxValue.Content = ulong.MaxValue.ToString();
                    minValue.Content = ulong.MinValue.ToString();
                    defaultValue.Content = default(ulong).ToString();
                    break;
                case "float":
                    maxValue.Content = float.MaxValue.ToString();
                    minValue.Content = float.MinValue.ToString();
                    defaultValue.Content = default(float).ToString();
                    break;
                case "double":
                    maxValue.Content = double.MaxValue.ToString();
                    minValue.Content = double.MinValue.ToString();
                    defaultValue.Content = default(double).ToString();
                    break;
                case "decimal":
                    maxValue.Content = decimal.MaxValue.ToString();
                    minValue.Content = decimal.MinValue.ToString();
                    defaultValue.Content = default(decimal).ToString();
                    break;
                default:
                    MessageBox.Show("");
                    break;
            }
        }

      

    }
}
