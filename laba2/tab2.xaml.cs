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
using System.Windows.Shapes;

namespace laba2
{
    /// <summary>
    /// Логика взаимодействия для tab2.xaml
    /// </summary>
    public partial class tab2 : Window
    {
        public tab2()
        {
            InitializeComponent();
        }

        private void Add2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new Page2(this);
        }
    }
}
