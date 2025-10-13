using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ariketa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ObservableCollection<Ataza> atazak = new ObservableCollection<Ataza>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Berria_sortu(object sender, RoutedEventArgs e)
        {
            Window1 sortu = new Window1("","","",false,false);
            sortu.ShowDialog();

            if (sortu.DialogResult == true) {

                atazak.Add(sortu.ataza1);
               
                Lista.ItemsSource = atazak;

            }
        }
        private void Button_editatu(object sender, RoutedEventArgs e)
        {
            if (Lista.SelectedItem is Ataza ataza) {

                Window1 editatu = new Window1(ataza.Titulua, ataza.Lehentasuna, ataza.Azken_eguna, ataza.Egina, true);
                editatu.ShowDialog();

                if (editatu.DialogResult == true) {

                    ataza.Titulua = editatu.ataza1.Titulua;
                    ataza.Lehentasuna = editatu.ataza1.Lehentasuna;
                    ataza.Azken_eguna = editatu.ataza1.Azken_eguna;
                    ataza.Egina = editatu.ataza1.Egina;

                    Lista.Items.Refresh();
                }
                

            }
        }
        private void Button_Ezabatu(object sender, RoutedEventArgs e)
        {
            if (Lista.SelectedItem is Ataza ataza) {

                atazak.Remove(ataza);
            
            }
        }
        private void Button_irten(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}