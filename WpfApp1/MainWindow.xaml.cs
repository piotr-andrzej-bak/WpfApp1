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

namespace WpfApp1
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

        private void buttonOne_Click(object sender, RoutedEventArgs e)
        {
            labelOne.Content = "HEJO!";
            progressBar.Value = 1;
        }

        private void buttonTwo_Click(object sender, RoutedEventArgs e)
        {
            labelOne.Content = "";
            progressBar.Value = 2;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            progressBarSlider.Value = sliderControl.Value;
        }
        private void checkBox_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(checkBox.IsChecked == true)
            {
                progressBar.Value = 0;
            }
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            progressBar.Value = 0;
        }

        private void buttonUpdate_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "kliknąłeś!";
        }
    }
}
