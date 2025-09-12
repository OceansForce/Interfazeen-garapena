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

namespace Ariketa4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Aceptar(object sender, RoutedEventArgs e)
        {
            string usuario = Usuario.Text;
            string contraseña = Contraseña.Password;

            if (usuario == "Informatica" && contraseña == "123")
            {
               label_mezua.Content = "Ongi etorri sistemara";
            }
            else
            {
               label_mezua.Content = "Identifikatu gabeko erabiltzailea";
            }
        }

        private void Button_Limpiar(object sender, RoutedEventArgs e)
        {
            label_mezua.Content = "";
            Usuario.Text = "";
            Contraseña.Password = "";
        }

        private void Button_Salir(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}