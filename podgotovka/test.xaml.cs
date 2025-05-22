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
    /// Логика взаимодействия для test.xaml
    /// </summary>
    public partial class test : Window
    {
        MasterFloor2Entities db = new MasterFloor2Entities();
        public test()
        {
            InitializeComponent();
            partnerid partnerid = new partnerid();
            var partner = db.partners.FirstOrDefault(x=>x.id == partnerid.id);
            var partnerphone = db.partnerContact.FirstOrDefault(x=>x.id == partner.id_contact);

            nomer.Text = partnerphone.telephone;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vivod window = new vivod();
            window.Show();
            this.Close();
        }
    }
}
