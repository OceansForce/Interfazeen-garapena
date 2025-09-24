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

namespace Ariketa8
{
    /// <summary>
    /// Interaction logic for WindowGeiketa.xaml
    /// </summary>
    public partial class WindowGeiketa : Window
    {

        public string TextoIngresado { get; private set; }

        public WindowGeiketa()
        {
            InitializeComponent();
        }

        private void Button_Aceptar(object sender, RoutedEventArgs e)
        {

            bool esFecha = DateTime.TryParseExact(
                        fecha1.Text,
                        "dd/MM/yyyy",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out _);
            if (!esFecha)
            {

                MessageBox.Show("Introduzca los datos correctamente o pulse Salir");
                this.DialogResult = false;
            }
            else
            {
                TextoIngresado = fecha1.Text;
                this.DialogResult = true;
            }

            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
