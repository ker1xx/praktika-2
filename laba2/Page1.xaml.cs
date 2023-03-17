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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        disciplinesTableAdapter dis = new disciplinesTableAdapter();
        teachersTableAdapter teachers = new teachersTableAdapter();
        tab1 window;
        public Page1(tab1 window)
        {
            this.window = window;
            InitializeComponent();
            this.Visibility = Visibility.Visible;
            discip_id.ItemsSource = dis.GetData();
            discip_id.DisplayMemberPath = "name_of_discipline";
            discip_id.SelectedValuePath = "id";
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            teachers.InsertQuery(name.Text,surname.Text,lastname.Text,
                (int)discip_id.SelectedValue);
            window.Table.ItemsSource = teachers.GetData();
            this.Content = null;
            this.Visibility = Visibility.Hidden;

        }
    }
}
