using System;
using System.Collections;
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
        MySQLHelper msql = new MySQLHelper();
        public static readonly DependencyProperty id_mahiaProperty =
           DependencyProperty.Register("id_mahia", typeof(string), typeof(Mahia));

        public bool erreserbatua = false;
        public string data_Box { get; set; }

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
            string[] zatitu= id_mahia.Split('_');
            string id= zatitu[0];
            string mota= zatitu[1];
            string erabiltzailea = SesioKudeatzailea.ErabiltzaileIzena;
            string query = "";

            aldatu_egoera();

            if (erreserbatua) {
                query = $"INSERT INTO `ig_db`.`mahiak` ( `mahia`, `erreserbatua`, `data`, `mota`, `erabiltzailea`) VALUES ( '{id}', {true}, '{data_Box}', '{mota}', '{erabiltzailea}');";
            }
            else{
                query = $"DELETE FROM `ig_db`.`mahiak` WHERE `mahia` = '{id}' AND `data` = '{data_Box}' AND `mota` = '{mota}';";
            }

            msql.ExecuteNonQuery(query);

        }

        public void aldatu_egoera()
        {
            if (!erreserbatua)
            {
                MahiaId.Background = Brushes.Red;
                erreserbatua = true;
            }
            else
            {
                MahiaId.Background = SystemColors.ControlBrush;
                erreserbatua = false;
            }
        }

        public void desaktibatu() {
            if (!erreserbatua)
            {
                MahiaId.IsEnabled = false;
                erreserbatua = true;
            }
            else {
                MahiaId.IsEnabled = true;
                erreserbatua = false;
            }
        }
    }
}
