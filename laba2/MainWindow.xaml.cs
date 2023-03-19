using laba2.DataSet1TableAdapters;
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

namespace laba2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        teachersssTableAdapter table1 = new teachersssTableAdapter();
        practiseeeTableAdapter table2 = new practiseeeTableAdapter();
        disciplinesssTableAdapter table3 = new disciplinesssTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void tab1_Click(object sender, RoutedEventArgs e)
        {
            tab1 tab1 = new tab1();
            tab1.Table.ItemsSource = table1.GetData();
            tab1.Show();
        }

        private void tab2_Click(object sender, RoutedEventArgs e)
        {
            tab2 tab2 = new tab2();
            tab2.Table.ItemsSource = table2.GetData();
            tab2.Show();
        }

        private void tab3_Click(object sender, RoutedEventArgs e)
        {
            tab3 tab3 = new tab3();
            tab3.Table.ItemsSource = table3.GetData();
            tab3.Show();
        }
    }
}
