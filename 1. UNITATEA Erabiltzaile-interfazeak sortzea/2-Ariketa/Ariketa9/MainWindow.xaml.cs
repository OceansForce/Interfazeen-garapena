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

namespace Ariketa9
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Añadir(object sender, RoutedEventArgs e)
        {
            if (amigo.Text != "")
            {
                lista.Items.Add(amigo.Text);
                amigo.Clear();
            }
            else
            {
                MessageBox.Show("Introduzca datos para poder añadirlos");
            }
        }

        private void lista_seleccionar(object sender, MouseButtonEventArgs e)
        {
            if (lista.SelectedItem != null){
                mostrar_amigo.Text=lista.SelectedItem.ToString();
            }
        }

        private void Button_Eliminar(object sender, RoutedEventArgs e)
        {
            var seleccionados = lista.SelectedItems.Cast<object>().ToList();

            if (seleccionados.Count != 0)
            {
               
                foreach (var item in seleccionados)
                {
                    lista.Items.Remove(item);
                }

            }
            else
            {
                MessageBox.Show("Seleccione datos para poder eliminarlos");
            }
        }

        private void Button_BorrarL(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
        }

        private void Button_Salir(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}