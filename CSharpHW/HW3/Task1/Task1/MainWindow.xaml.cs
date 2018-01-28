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
        private string _rbType="sbyte";
        private string _rbValue = "MaxValue";
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
            foreach (UIElement c in layoutStackPanelValues.Children)
            {
                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked += RadioButtonValue_Checked;
                }

            }
            
            button1.Click += Button_Click;
            
        }
        private void RadioButtonType_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            _rbType = pressed.Content.ToString();
        }


        private void RadioButtonValue_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            _rbValue = pressed.Content.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (_rbType)
            {
                case "sbyte":
                    if (valueCheck(_rbValue) == true)
                    {
                        valueType.Content = sbyte.MaxValue;
                    }
                    else
                    {
                        valueType.Content = sbyte.MinValue;
                    }
                    break;
                case "byte":
                    if (valueCheck(_rbValue) == true)
                    {
                        valueType.Content = byte.MaxValue;
                    }
                    else
                    {
                        valueType.Content = byte.MinValue;
                    }
                    break;
                case "short":
                    if (valueCheck(_rbValue) == true)
                    {
                        valueType.Content = short.MaxValue;
                    }
                    else
                    {
                        valueType.Content = short.MinValue;
                    }
                    break;
                case "ushort":
                    if (valueCheck(_rbValue) == true)
                    {
                        valueType.Content = ushort.MaxValue;
                    }
                    else
                    {
                        valueType.Content = ushort.MinValue;
                    }
                    break;
                case "int":
                    if (valueCheck(_rbValue) == true)
                    {
                        valueType.Content = int.MaxValue;
                    }
                    else
                    {
                        valueType.Content = int.MinValue;
                    }
                    break;
                case "uint":
                    if (valueCheck(_rbValue) == true)
                    {
                        valueType.Content = uint.MaxValue;
                    }
                    else
                    {
                        valueType.Content = uint.MinValue;
                    }
                    break;
                case "long":
                    if (valueCheck(_rbValue) == true)
                    {
                        valueType.Content = long.MaxValue;
                    }
                    else
                    {
                        valueType.Content = long.MinValue;
                    }
                    break;
                case "ulong":
                    if (valueCheck(_rbValue) == true)
                    {
                        valueType.Content = ulong.MaxValue;
                    }
                    else
                    {
                        valueType.Content = ulong.MinValue;
                    }
                    break;
                case "float":
                    if (valueCheck(_rbValue) == true)
                    {
                        valueType.Content = float.MaxValue;
                    }
                    else
                    {
                        valueType.Content = float.MinValue;
                    }
                    break;
                case "double":
                    if (valueCheck(_rbValue) == true)
                    {
                        valueType.Content = double.MaxValue;
                    }
                    else
                    {
                        valueType.Content = double.MinValue;
                    }
                    break;
                case "decimal":
                    if (valueCheck(_rbValue) == true)
                    {
                        valueType.Content = decimal.MaxValue;
                    }
                    else
                    {
                        valueType.Content = decimal.MinValue;
                    }
                    break;
            }
        }

        private bool valueCheck(string value)
        {
            if (value == "MaxValue"){
                return true;
            }
            else
            {
                return false;
            }       
         }

    }
}
