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
    /// Interaction logic for WindowDiferencia.xaml
    /// </summary>
    public partial class WindowDiferencia : Window
    {

        private int count = 0;
        private string fecha1;
        private string fecha2;

        public string TextoIngresado { get; private set; }

        public WindowDiferencia()
        {
            InitializeComponent();
        }

        private void Button_Aceptar(object sender, RoutedEventArgs e)
        {
            if (count == 0)
            {
                
                bool esFecha = DateTime.TryParseExact(
                        fecha.Text,                       
                        "dd/MM/yyyy",          
                        CultureInfo.InvariantCulture, 
                        DateTimeStyles.None,         
                        out _);
                if (!esFecha) { 
                    
                    MessageBox.Show("Introduzca los datos correctamente o pulse Salir");
                    this.DialogResult = false;
                }else{
                    fecha1 = fecha.Text;
                    count++;
                    fecha.Text = " ";
                }
            }
            else if (count == 1)
            {
                
                fecha2 = fecha.Text;
                TextoIngresado = "Desde " + fecha1 + " hasta " + fecha2 + " hay " + (Convert.ToDateTime(fecha2) - Convert.ToDateTime(fecha1)).TotalDays.ToString();
                count = 0;
                this.DialogResult = true;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
