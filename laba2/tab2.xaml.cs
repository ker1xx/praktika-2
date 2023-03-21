using laba2.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace laba2
{
    /// <summary>
    /// Логика взаимодействия для tab2.xaml
    /// </summary>
    public partial class tab2 : Window
    {
        practiseeeTableAdapter prac = new practiseeeTableAdapter();
        public bool IsUpdating;
        public tab2()
        {
            InitializeComponent();
        }


        private void Delete_Click(object sender, RoutedEventArgs e)
        {

            prac.DeleteQuery((int)(Table.SelectedItem as DataRowView).Row[0]);
            Table.ItemsSource = prac.takenameeee();
        }

        private void Add1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new Page2(this);
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            IsUpdating = true;
            Frame.Content = new Page2(this);
        }
    }
}
