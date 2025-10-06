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

namespace Ariketa2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string v_frase1;
        public string v_frase2;
        public string v_frase3;
        public string v_frase4;
        public string v_frase5;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Text.Clear();
            v_frase1 = Text.Text;
            Frase2.IsEnabled = true;
            Frase1.IsEnabled = false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Text.Clear();
            v_frase2 = Text.Text;
            Frase3.IsEnabled = true;
            Frase2.IsEnabled = false;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Text.Clear();
            v_frase3 = Text.Text;
            Frase4.IsEnabled = true;
            Frase3.IsEnabled = false;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Text.Clear();
            v_frase4 = Text.Text;
            Frase5.IsEnabled = true;
            Frase4.IsEnabled = false;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Text.Clear();
            v_frase5 = Text.Text;
            Unir.IsEnabled = true;
            Frase5.IsEnabled = false;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            string textu_osoa= v_frase1 + " " + v_frase2 + " " + v_frase3 + " " + v_frase4 + " " + v_frase5;
            Text.Text = textu_osoa;

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Unir.IsEnabled = false;
            Frase1.IsEnabled = true;
            Text.Clear();
            v_frase1 = "";
            v_frase2 = "";
            v_frase3 = "";
            v_frase4 = "";
            v_frase5 = "";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}