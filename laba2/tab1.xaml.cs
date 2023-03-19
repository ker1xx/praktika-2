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
    
    public partial class tab1 : Window
    {
        teachersssTableAdapter teachers = new teachersssTableAdapter();
        public tab1()
        {
            InitializeComponent();
        }

        private void Add1_Click(object sender, RoutedEventArgs e)
        {
            a1.Content = new Page1(this);
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            teachers.DeleteQuery((int)(Table.SelectedItem as DataRowView).Row[0]);
            Table.ItemsSource = teachers.GetData();
        }
    }
}
