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

namespace Ariketa7
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


        private string kalkulo_mota = "";

        private void Button_7(object sender, RoutedEventArgs e)
        {
            if (Textua.Text == "0.")
            {
                Textua.Text = "7";
            }
            else
            {
                Textua.Text += "7";
            }
        }

        private void Button_8(object sender, RoutedEventArgs e)
        {
            if (Textua.Text == "0.")
            {
                Textua.Text = "8";
            }
            else
            {
                Textua.Text += "8";
            }
        }

        private void Button_9(object sender, RoutedEventArgs e)
        {
            if (Textua.Text == "0.")
            {
                Textua.Text = "9";
            }
            else
            {
                Textua.Text += "9";
            }
        }

        private void Button_4(object sender, RoutedEventArgs e)
        {
            if (Textua.Text == "0.")
            {
                Textua.Text = "4";
            }
            else
            {
                Textua.Text += "4";
            }
        }

        private void Button_5(object sender, RoutedEventArgs e)
        {
            if (Textua.Text == "0.")
            {
                Textua.Text = "5";
            }
            else
            {
                Textua.Text += "5";
            }
        }

        private void Button_6(object sender, RoutedEventArgs e)
        {
            if (Textua.Text == "0.")
            {
                Textua.Text = "6";
            }
            else
            {
                Textua.Text += "6";
            }
        }

        private void Button_1(object sender, RoutedEventArgs e)
        {
            if (Textua.Text == "0.")
            {
                Textua.Text = "1";
            }
            else
            {
                Textua.Text += "1";
            }
        }

        private void Button_2(object sender, RoutedEventArgs e)
        {
            if (Textua.Text == "0.")
            {
                Textua.Text = "2";
            }
            else
            {
                Textua.Text += "2";
            }
        }

        private void Button_3(object sender, RoutedEventArgs e)
        {
            if (Textua.Text == "0.")
            {
                Textua.Text = "3";
            }
            else
            {
                Textua.Text += "3";
            }
        }

        private void Button_0(object sender, RoutedEventArgs e)
        {
            if (Textua.Text != "0.")
            {
                Textua.Text += "0";
            } 
                
        }

        private void Button_Coma(object sender, RoutedEventArgs e)
        {
            Textua.Text += ",";
        }

        private void Button_C(object sender, RoutedEventArgs e)
        {
            string text = Textua.Text;
            string[] parts = text.Split();
            string lastPart = parts[parts.Length - 1];

           
            parts[parts.Length - 1]="";
            Textua.Text = string.Join(" ", parts);
        }

        private void Button_CE(object sender, RoutedEventArgs e)
        {
            Textua.Text = "";
        }

        private void Button_Zatitu(object sender, RoutedEventArgs e)
        {
            string text = Textua.Text;
            string[] parts = text.Split();
            string lastPart = parts[parts.Length - 1];

            if (!lastPart.Equals("/")) {
                kalkulo_mota = "/";
                parts[parts.Length - 1] = " / ";
                Textua.Text = string.Join(" ", parts);
            }
            else
            {
                Textua.Text = " / ";
            }

        }

        private void Button_Kenketa(object sender, RoutedEventArgs e)
        {
            string text = Textua.Text;
            string[] parts = text.Split();
            string lastPart = parts[parts.Length - 1];

            if (!lastPart.Equals("-"))
            {
                kalkulo_mota = "-";
                parts[parts.Length - 1] = " - ";
                Textua.Text = string.Join(" ", parts);
            }
            else
            {
                Textua.Text = " - ";
            }
        }

        private void Button_Biderketa(object sender, RoutedEventArgs e)
        {
            string text = Textua.Text;
            string[] parts = text.Split();
            string lastPart = parts[parts.Length - 1];

            if (!lastPart.Equals("x"))
            {
                kalkulo_mota = "x";
                parts[parts.Length - 1] = " x ";
                Textua.Text = string.Join(" ", parts);
            }
            else
            {
                Textua.Text = " x ";
            }
        }

        private void Button_Gehiketa(object sender, RoutedEventArgs e)
        {
            string text = Textua.Text;
            string[] parts = text.Split();
            string lastPart = parts[parts.Length - 1];

            if (!lastPart.Equals("+"))
            {
                kalkulo_mota = "+";
                parts[parts.Length - 1] = " + ";
                Textua.Text = string.Join(" ", parts);
            }
            else
            {
                Textua.Text = " + ";
            }
        }

        private void Button_Erantzuna(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Portzentaila(object sender, RoutedEventArgs e)
        {
            string text = Textua.Text;
            string[] parts = text.Split();
            string lastPart = parts[parts.Length - 1];

            if (!lastPart.Equals("%"))
            {
                kalkulo_mota = "%";
                parts[parts.Length - 1] = " % ";
                Textua.Text = string.Join(" ", parts);
            }
            else
            {
                Textua.Text = " % ";
            }
        }

        private void kalkuloa() {
            string kalkulo= Textua.Text;
            string kalkulo2 = "";
            string[] parts = kalkulo.Split();

            double zenb1 = 0;
            double zenb2 = 0;


            for (int x  = 0; x  < parts.Length-1; x ++)
            {
                string part1 = parts[x].Trim();
                if (part1.Equals("%"))
                {
                   zenb1= double.Parse(parts[x - 1]);
                   kalkulo2 += (zenb1 / 100).ToString();

                }
                else if (part1.Equals("/") && part1.Equals("x") && part1.Equals("-") && part1.Equals("+"))
                {
                    kalkulo2 +=  parts[x];
                }
            }
            parts= kalkulo2.Split();

            for (int a = 0; a < parts.Length - 1; a++)
            {
                string part2 = parts[a].Trim();
                if (part2.Equals("x") || part2.Equals("/"))
                {
                    zenb1 = double.Parse(parts[a - 1]);
                    zenb2 = double.Parse(parts[a + 1]);

                    if (part2.Equals("x"))
                    {
                        kalkulo2 += (zenb1 * zenb2).ToString();
                    }
                    else if (part2.Equals("/"))
                    {
                        kalkulo2 += (zenb1 / zenb2).ToString();
                    }

                }
                else if (part2.Equals("-") && part2.Equals("+"))
                {
                    kalkulo2 += parts[a-1]+ part2;
                }
            }
        }
    }
}