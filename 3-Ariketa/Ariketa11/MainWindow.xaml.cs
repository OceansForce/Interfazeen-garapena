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
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Ariketa11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            aldagaiak.izena= Nombre.Text;
            aldagaiak.abizena1= Apellido1.Text;
            aldagaiak.abizena2= Apellido2.Text;
            aldagaiak.Dni= DNI.Text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();

            window1.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}