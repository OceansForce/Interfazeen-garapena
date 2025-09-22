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

namespace Ariketa8
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

        private void Button_Ejecutar(object sender, RoutedEventArgs e)
        {
            DateTime fecha_hora = DateTime.Now;
            Ahora.Text = fecha_hora.ToString();

            string[] fecha_hora_dividir = Convert.ToString(fecha_hora).Split(" ");

            Hoy.Text = fecha_hora_dividir[0];
            Hora_Hoy.Text = fecha_hora_dividir[1];

            WindowSuma a = new WindowSuma();
            WindowSuma2 b = new WindowSuma2();
            a.ShowDialog();

            if (a.DialogResult == true)
            {
                b.ShowDialog();

                if (b.DialogResult== true) {

                    string fecha = a.TextoIngresado;
                    string meses = b.TextoIngresado;
                    string[] fecha_suma = Convert.ToDateTime(fecha).AddMonths(Convert.ToInt32(meses)).ToString().Split(" ");

                    Suma_Fecha.Text = "Fecha Inicio: "+ fecha + ", Meses a sumar: "+meses+", Nueva Fecha: "+ fecha_suma[0];

                }
            }
        }

        private void Suma_Fecha_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}