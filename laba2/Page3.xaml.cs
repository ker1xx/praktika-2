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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        disciplinesssTableAdapter disciplines = new disciplinesssTableAdapter();
        tab3 window;
        public Page3(tab3 window)
        {
            this.window = window;
            InitializeComponent();
            this.Visibility = Visibility.Visible;
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            disciplines.InsertQuery(Discipline.Text);
            window.Table.ItemsSource = disciplines.GetData(); 
            this.Visibility = Visibility.Hidden;

        }
    }
}
