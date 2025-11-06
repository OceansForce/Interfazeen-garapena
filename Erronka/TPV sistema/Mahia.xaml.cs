using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TPV_sistema
{
    /// <summary>
    /// Interaction logic for Mahia.xaml
    /// </summary>
    public partial class Mahia : UserControl
    {

        public static readonly DependencyProperty id_mahiaProperty =
           DependencyProperty.Register("id_mahia", typeof(string), typeof(Mahia));

        public string id_mahia
        {
            get { return (string)GetValue(id_mahiaProperty); }
            set { SetValue(id_mahiaProperty, value); }
        }


        public Mahia()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
