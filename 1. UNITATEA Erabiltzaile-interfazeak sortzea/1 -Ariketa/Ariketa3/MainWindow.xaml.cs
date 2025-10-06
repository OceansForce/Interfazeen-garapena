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

namespace Ariketa3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public int kont = 0;
        public int[] zenbs = new int[4];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Siguiente(object sender, RoutedEventArgs e)
        {
            if (kont<4) {
                zenbs[kont] = int.Parse(Textbox.Text);
                Textbox.Text = "";

                lavel.Content = "Numero " + (kont + 1);
            }
            kont++;

            if (kont == 4)
            {
                Textbox.Text = ((zenbs[0] + (zenbs[0] * zenbs[1]) + (zenbs[1] * zenbs[2]) + (zenbs[2] * zenbs[3]))/4).ToString();

                lavel.Content = "Resultado";
                Textbox.IsEnabled = false;
                Siguiente.Content = "Limpiar";
            }
            else if (kont == 5)
            {
                lavel.Content = "Numero 1";
                Textbox.IsEnabled = true;
                Siguiente.Content = "Siguiente";
                kont = 0;
                Textbox.Text = "";
            }
        }

        private void Salir(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}