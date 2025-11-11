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
    /// Lógica de interacción para Sortu_eta_editatu.xaml
    /// </summary>
    public partial class Sortu_eta_editatu : Window
    {

        public Erabiltzaileak erabiltzailea_berria { get; set; }

        public Sortu_eta_editatu(string izena, string pazahitza, string mota, bool editatu)
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            this.ShowInTaskbar = false;
            this.ResizeMode = ResizeMode.NoResize;
            if (editatu)
            {
                Izena_TextBox.Text = izena;
                Pazahitza_TextBox.Text = pazahitza;
                combobox.Text = mota;
            }
        }

        private void Sortu_Click(object sender, RoutedEventArgs e)
        {
            erabiltzailea_berria = new Erabiltzaileak
            {
                Izena = Izena_TextBox.Text,
                Pazahitza = Pazahitza_TextBox.Text,
                Mota = combobox.Text
            };

            this.DialogResult = true;
        }

        
    }
}
