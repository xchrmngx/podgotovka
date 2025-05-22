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

namespace podgotovka
{
    /// <summary>
    /// Логика взаимодействия для vivod.xaml
    /// </summary>
    public partial class vivod : Window
    {
        MasterFloor2Entities db = new MasterFloor2Entities();
        public vivod()
        {
            InitializeComponent();
            listbox.ItemsSource = db.partners.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var partner = db.partners.FirstOrDefault(x => x.id == (int)listbox.SelectedValue);
            partnerid.id = partner.id;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (listbox.SelectedValue == null)
            {
                MessageBox.Show("выбери");
            }
            else
            {
                test window = new test();
                window.Show();
                this.Close();
            }
        }
    }
}
