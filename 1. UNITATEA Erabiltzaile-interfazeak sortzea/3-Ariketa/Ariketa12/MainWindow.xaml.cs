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

namespace Ariketa12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public double dietas=0, viajes=0, trabajo=0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            check1.IsChecked = false;
            check2.IsChecked = false;
            check3.IsChecked = false;
            textKM.Text = "";
            textHoras1.Text = "";
            textHoras2.Text = "";
            dietasTEXT.Text = "";
            viajesTEXT.Text = "";
            trabajosTEXT.Text = "";
            erantzuna.Text = "";
        }

        private void enter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (check1.IsChecked== true) {
                    dietas += 3;
                }
                if (check2.IsChecked == true){
                    dietas += 9;
                }
                if (check3.IsChecked == true){
                    dietas += 15.5;
                }

                dietasTEXT.Text = dietas.ToString() + " €";

                viajes = (Convert.ToDouble(textKM.Text) * 0.25)+(Convert.ToDouble(textHoras1.Text) *18);
                viajesTEXT.Text = viajes.ToString() + " €";

                trabajo = Convert.ToDouble(textHoras2.Text) * 42;
                trabajosTEXT.Text = trabajo.ToString() + " €";

                erantzuna.Text = (dietas + viajes + trabajo).ToString() + " €";
            }
        }
    }
}