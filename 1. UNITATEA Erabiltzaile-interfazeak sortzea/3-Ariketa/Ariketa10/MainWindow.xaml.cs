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

namespace Ariketa10
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

        private void combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (combobox.SelectedIndex)
            {

                case 0:
                    img1.Visibility = Visibility.Visible;
                    img2.Visibility = Visibility.Hidden;
                    img3.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    img1.Visibility = Visibility.Hidden;
                    img2.Visibility = Visibility.Visible;
                    img3.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    img1.Visibility = Visibility.Hidden;
                    img2.Visibility = Visibility.Hidden;
                    img3.Visibility = Visibility.Visible;
                    break;

            }         
        }

        private void check4_Checked(object sender, RoutedEventArgs e)
        {
            img4.Visibility = Visibility.Visible;
        }

        private void check4_Unchecked(object sender, RoutedEventArgs e)
        {
            img4.Visibility = Visibility.Hidden;
        }

        private void check5_Checked(object sender, RoutedEventArgs e)
        {
            img5.Visibility = Visibility.Visible;
        }

        private void check5_Unchecked(object sender, RoutedEventArgs e)
        {
            img5.Visibility = Visibility.Hidden;
        }


        private void check6_Checked(object sender, RoutedEventArgs e)
        {
            img6.Visibility = Visibility.Visible;
        }

        private void check6_Unchecked(object sender, RoutedEventArgs e)
        {
            img6.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}