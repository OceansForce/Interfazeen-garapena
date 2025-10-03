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

namespace Ariketa13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string texto = "";

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Salir(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Cortar(object sender, RoutedEventArgs e)
        {
            texto = textBox.Text;
            textBox.Text = "";
        }
        private void Copiar(object sender, RoutedEventArgs e)
        {
            texto = textBox.Text;
        }
        private void Pegar(object sender, RoutedEventArgs e)
        {
            textBox.Text = texto;
        }
        private void Eliminar(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
        }

        private void Arial(object sender, RoutedEventArgs e)
        {
            textBox.FontFamily = new FontFamily("Arial");
        }
        private void Courier(object sender, RoutedEventArgs e)
        {
            textBox.FontFamily = new FontFamily("Courier New");
        }
        private void Impact(object sender, RoutedEventArgs e)
        {
            textBox.FontFamily = new FontFamily("Impact");
        }
        private void Symbol(object sender, RoutedEventArgs e)
        {
            textBox.FontFamily = new FontFamily("Symbol");
        }
    }
}