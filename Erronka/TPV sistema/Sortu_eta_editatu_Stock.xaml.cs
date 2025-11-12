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
using System.Windows.Shapes;

namespace TPV_sistema
{
    /// <summary>
    /// Lógica de interacción para Sortu_eta_editatu_Stock.xaml
    /// </summary>
    public partial class Sortu_eta_editatu_Stock : Window
    {

        public Stock stock_berria { get; set; }
        public Sortu_eta_editatu_Stock(string izena, int kantitatea, float prezio, bool editatu)
        {
            InitializeComponent();

            this.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            this.ShowInTaskbar = false;
            this.ResizeMode = ResizeMode.NoResize;
            if (editatu)
            {
                Izena_TextBox.Text = izena;
                Kantitatea_TextBox.Text =  kantitatea.ToString();
                Prezioa_TextBox.Text = prezio.ToString();
            }

        }

        private void Sortu_Click(object sender, RoutedEventArgs e)
        {
            stock_berria = new Stock
            {
                Izena = Izena_TextBox.Text,
                Kantitatea = int.Parse(Kantitatea_TextBox.Text),
                Prezioa = float.Parse(Prezioa_TextBox.Text)
            };

            this.DialogResult = true;
        }
    }
}
