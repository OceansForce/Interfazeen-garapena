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

namespace Ariketa5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Boolean negrita=false;
        public Boolean cursiva=false;
        public int tamaño=20;




        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Cs(object sender, RoutedEventArgs e)
        {
            Texto_cambiante.FontFamily = new FontFamily("Comic Sans MS");
        }

        private void Button_Negrita(object sender, RoutedEventArgs e)
        {
            if (!negrita)
            {
                Texto_cambiante.FontWeight = FontWeights.Bold;
                negrita = true;
            }
            else
            {
                Texto_cambiante.FontWeight = FontWeights.Light;
                negrita = false;
            }
            
        }

        private void Button_Tachado(object sender, RoutedEventArgs e)
        {
            Texto_cambiante.TextDecorations = TextDecorations.Strikethrough;
        }

        private void Button_Tamaño_minus(object sender, RoutedEventArgs e)
        {
            Texto_cambiante.FontSize = tamaño - 5;
        }

        private void Button_Courier(object sender, RoutedEventArgs e)
        {
            Texto_cambiante.FontFamily = new FontFamily("Courier New");
        }

        private void Button_Cursiva(object sender, RoutedEventArgs e)
        {
            if (!cursiva)
            {
                Texto_cambiante.FontStyle = FontStyles.Italic;
                cursiva = true;
            }
            else
            {
                Texto_cambiante.FontStyle = FontStyles.Normal;
                cursiva = false;
            }

        }

        private void Button_Subrayado(object sender, RoutedEventArgs e)
        {
            Texto_cambiante.TextDecorations = TextDecorations.Underline;
        }

        private void Button_Tamaño_plus(object sender, RoutedEventArgs e)
        {
            Texto_cambiante.FontSize = tamaño + 5;
        }

        private void Button_Seleccionar(object sender, RoutedEventArgs e)
        {
            string palabra= Texto.SelectedText;
            Mensaje.Content = "El texto tiene "+palabra.Length+" caracteres, y el texto seleccionado es: "+palabra;
        }

        private void Button_Salir(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}