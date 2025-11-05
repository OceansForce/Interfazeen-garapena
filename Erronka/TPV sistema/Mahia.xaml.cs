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

        public static readonly DependencyProperty id_mahaia =
        DependencyProperty.Register("id_mahia", typeof(string), typeof(Mahia));

        public string mahia_id
        {
            get { return (string)GetValue(id_mahaia); }
            set { SetValue(id_mahaia, value); }
        }
      

        public Mahia()
        {
            InitializeComponent();
            Mahaia.Content = "Mahaia "+ this.mahia_id;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
