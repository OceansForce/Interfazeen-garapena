using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace _3UD_Ariketa___Ikus_Osagaiak_sortzea
{
    /// <summary>
    /// Interaction logic for Data_Dialog.xaml
    /// </summary>
    public partial class Data_Dialog : Window
    {

        public string data { get;  set; }
        public Data_Dialog()
        {
            InitializeComponent();
        }

        private void Ongi_Click(object sender, RoutedEventArgs e)
        {
            bool esFecha = DateTime.TryParseExact(
                        fecha.Text,
                        "dd/MM/yyyy",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out _);

            if (!esFecha) { 
            
                MessageBox.Show("Sartu data egokia (DD/MM/YYYY)","Errorea",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            else
            {
                data = fecha.Text;
                this.DialogResult = true;
            }

        }

        private void Ezeztatu_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
