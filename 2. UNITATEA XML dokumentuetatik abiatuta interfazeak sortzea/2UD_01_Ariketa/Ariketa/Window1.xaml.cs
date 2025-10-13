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

namespace Ariketa
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public Ataza ataza1 { get; set; }

        public Window1(string titulua, string lehentasuna1, string azken_eguna, bool egina1, bool editatu)
        {
            InitializeComponent();

            if (editatu)
            {
                tituloa.Text = titulua;
                lehentasuna.Text = lehentasuna1;
                data.Text = azken_eguna;
                egina.IsChecked = egina1;
            } 
        }


        private void gorde_Click(object sender, RoutedEventArgs e)
        {
            ataza1 = new Ataza();
            ataza1.Titulua = tituloa.Text;
            ataza1.Lehentasuna = lehentasuna.Text;
            ataza1.Azken_eguna = data.Text;
            ataza1.Egina = (bool)egina.IsChecked;

            this.DialogResult = true;
        }
    }
}
