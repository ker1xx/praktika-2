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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace laba2
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        teachersssTableAdapter teachers = new teachersssTableAdapter();
        practiseeeTableAdapter practise = new practiseeeTableAdapter();
        tab2 window;
        int id;
        public Page2(tab2 window)
        {
            this.window = window;
            var item = window.Table.SelectedItem as DataRowView;
            InitializeComponent();
            this.Visibility = Visibility.Visible;
            teacher_id.ItemsSource = teachers.GetData();
            teacher_id.DisplayMemberPath = "surname";
            teacher_id.SelectedValuePath = "surname";
            id = (int)item.Row[3];
            if (window.IsUpdating == true)
            {
                teacher_id.SelectedValue = item.Row[4] as string;
                BeginDate.Text = (string)item.Row[0];
                EndDate.Text = (string)item.Row[1];
                CountOfHours.Text = Convert.ToString((int)item.Row[2]);
            }
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {

            if (window.IsUpdating == false)
                practise.InsertQuery((int)teacher_id.SelectedValue,
                BeginDate.Text, EndDate.Text, Convert.ToInt16(CountOfHours.Text));
            else
                practise.UpdateQuery((int)teacher_id.SelectedValue,
                BeginDate.Text, EndDate.Text, Convert.ToInt16(CountOfHours.Text), id);
            window.Table.ItemsSource = practise.GetData();
            this.Visibility = Visibility.Hidden;
        }
    }
}
