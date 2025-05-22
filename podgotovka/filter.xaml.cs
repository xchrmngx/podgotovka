using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace podgotovka
{
    /// <summary>
    /// Логика взаимодействия для filter.xaml
    /// </summary>
    public partial class filter : Window
    {
        knigersEntities db = new knigersEntities();
        public filter()
        {
            InitializeComponent();
            datagrid.ItemsSource = db.Пользователь.ToList();
            combobox.ItemsSource = db.Тип_Пользователя.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = db.Пользователь.ToList();
            combobox.SelectedItem = null;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Тип_Пользователя type = combobox.SelectedItem as Тип_Пользователя;

            if (type != null)
            {
                List<Пользователь> users = db.Пользователь.Where(x => x.Тип_Пользователя == type.Код).ToList();
                datagrid.ItemsSource = users;
            }
        }
    }
}
