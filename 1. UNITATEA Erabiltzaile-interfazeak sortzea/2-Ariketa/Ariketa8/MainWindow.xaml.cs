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

            WindowGeiketa a = new WindowGeiketa();
            WindowGeiketa2 b = new WindowGeiketa2();
            WindowDiferencia c = new WindowDiferencia();
            a.ShowDialog();

            if (a.DialogResult == true)
            {
                b.ShowDialog();

                if (b.DialogResult== true) {

                    string fecha = a.TextoIngresado;
                    string meses = b.TextoIngresado;
                    string[] fecha_suma = Convert.ToDateTime(fecha).AddMonths(Convert.ToInt32(meses)).ToString().Split(" ");

                    Suma_Fecha.Text = "Fecha Inicio: "+ fecha + ", Meses a sumar: "+meses+", Nueva Fecha: "+ fecha_suma[0];

                    c.ShowDialog();
                    if (c.DialogResult==true)
                    {
                        string diferencia = c.TextoIngresado;
                        Diferencia_Fecha.Text = diferencia;
                    }
                }
            }
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Limpiar(object sender, RoutedEventArgs e)
        {
            Ahora.Clear();
            Hoy.Clear();
            Hora_Hoy.Clear();
            Suma_Fecha.Clear();
            Diferencia_Fecha.Clear();
        }
    }
}