
using System.Windows;
using System.Windows.Controls;


namespace Ariketa1
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
               
                double zenb1 = double.Parse(textBox1.Text);
                double zenb2 = double.Parse(textBox2.Text);
                double zenb3 = double.Parse(textBox3.Text);
                double zenb4 = double.Parse(textBox4.Text);

              
                double suma = (zenb1 + zenb2 + zenb3 + zenb4) /4;

               
                textBox5.Text = suma.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Sartu zenbakiak");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textBox5.Clear();
            textBox1.Focus();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_5(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}