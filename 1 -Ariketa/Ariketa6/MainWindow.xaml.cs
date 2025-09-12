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

namespace Ariketa6
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

        public int textbox=1;
        public string testua;

        public void Enter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (textbox == 1)
                {
                    testua = Text1.Text;
                    textbox++;
                    Text1.Clear();
                    Text2.Text = testua;
                }
                else if (textbox == 2)
                {
                    testua = Text2.Text;
                    textbox++;
                    Text2.Clear();
                    Text3.Text = testua;
                }
                else
                {
                    testua = Text3.Text;
                    textbox = 1;
                    Text3.Clear();
                    Text1.Text = testua;
                }
                    
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Text1.Clear();
            Text2.Clear();
            Text3.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

   
}