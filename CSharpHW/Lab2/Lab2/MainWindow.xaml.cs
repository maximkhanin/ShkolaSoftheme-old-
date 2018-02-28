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
using LiveCharts;
using LiveCharts.Wpf;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Annotations;
using System.Text.RegularExpressions;
using Lab2.Libs;
using System.Windows.Controls.Primitives;

namespace Lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent(); 
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GenerateRandomArrays generateRandomArrays = new GenerateRandomArrays(int.Parse(minSize.Text),
                int.Parse(maxSize.Text), int.Parse(minRange.Text), int.Parse(maxRange.Text), int.Parse(count.Text));
            
            List<double[]> list = generateRandomArrays.GenArrays();
            var k = 1;

            var myModel = new PlotModel { Title = "O(nlog(n))" };

            var functionSeries = new FunctionSeries();


            foreach (var item in list)
            {
                result.Text += "Unsorted array " + k +'\n' + String.Join(" ", item.Select(s => s.ToString()).ToArray());
                var time = BinInsertSort.Sort(item);
                result.Text += '\n' + "Sorted array" + k + '\n'+ String.Join(" ", item.Select(s => s.ToString()).ToArray()) +'\n'+"Time:" + time +'\n';
                k += 1;
                
                functionSeries.Points.Add(new DataPoint(item.Length,time));
    
            }


           var sortedUsers = from u in functionSeries.Points
                             orderby u.X
                             select u;
            
            var functionSeries1 = new FunctionSeries();
            foreach (DataPoint u in sortedUsers)
                functionSeries1.Points.Add(u);

            myModel.Series.Add(functionSeries1);
            timeComplexity.Model = myModel;

        }


     
    }








    public class MainViewModel
    {
        public MainViewModel()
        {
            MyModel = new PlotModel { Title = "O(nlog(n))" };
            ///Create Graphic
           /// MyModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
            /// Create Point
           ///MyModel.Annotations.Add(new PointAnnotation { X = 3, Y = 0.5, Size = 2, Fill = OxyColor.FromRgb(255,0,0) });

            double i = 0;
            var functionSeries = new FunctionSeries();
            while (i<=100)
            {
                functionSeries.Points.Add(new DataPoint(i, i * Math.Log10(i)));
                i += 0.01;
            }
            MyModel.Series.Add(functionSeries);
        }
        
        public PlotModel MyModel { get; private set; }
    }
}
