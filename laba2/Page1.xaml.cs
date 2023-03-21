using laba2.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
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
        disciplinesssTableAdapter dis = new disciplinesssTableAdapter();
        teachersssTableAdapter teachers = new teachersssTableAdapter();
        tab1 window;
        int id;

        public Page1(tab1 window)
        {
            this.window = window;
            var item = window.Table.SelectedItem as DataRowView;
            InitializeComponent();
            this.Visibility = Visibility.Visible;
            discip_id.ItemsSource = dis.GetData();
            discip_id.DisplayMemberPath = "name_of_discipline";
            discip_id.SelectedValuePath = "id";
            id = (int)item.Row[0];
            if (window.IsUpdating == true)
            {

                name.Text = (string)item.Row[1];
                surname.Text = (string)item.Row[2];
                lastname.Text = (string)item.Row[3];
                discip_id.SelectedValue = (int)item.Row[4];
                Create.Content = "Обновить";
            }
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (window.IsUpdating == false)
                teachers.InsertQuery(name.Text, surname.Text, lastname.Text,
                (int)discip_id.SelectedValue);
            else
                teachers.UpdateQuery(name.Text, surname.Text, lastname.Text,
                (int)discip_id.SelectedValue,id);
            window.Table.ItemsSource = teachers.GetData();
            this.Content = null;
            this.Visibility = Visibility.Hidden;

        }

    }
}
