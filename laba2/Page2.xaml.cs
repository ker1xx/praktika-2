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
using System.Xml.Linq;

namespace laba2
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        teachersTableAdapter teachers = new teachersTableAdapter();
        practiseTableAdapter practise = new practiseTableAdapter();
        tab2 window;
        public Page2(tab2 window)
        {
            this.window = window;
            InitializeComponent();
            this.Visibility = Visibility.Visible;
            teacher_id.ItemsSource = teachers.GetData();
            teacher_id.DisplayMemberPath = "surname";
            teacher_id.SelectedValuePath = "id";
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            practise.InsertQuery((int)teacher_id.SelectedValue, BeginDate.Text, EndDate.Text, Convert.ToInt16(CountOfHours.Text));
            window.Table.ItemsSource = teachers.GetData();
            this.Visibility = Visibility.Hidden;
        }
    }
}
