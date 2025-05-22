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

namespace podgotovka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        knigersEntities db = new knigersEntities();
        public MainWindow()
        {
            InitializeComponent();
            datagrid.ItemsSource = db.Пользователь.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            filter window = new filter();
            window.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            vivod window = new vivod();
            window.Show();
            this.Close();
        }

        private void textbox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key < Key.D0 || e.Key > Key.D9) && e.Key != Key.OemPlus && e.Key != Key.Back)
            {
                e.Handled = true;
            }
        }
    }
}
