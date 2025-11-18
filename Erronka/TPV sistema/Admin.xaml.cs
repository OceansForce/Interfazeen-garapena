using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
   

    public partial class Admin : Window
    {
        MySQLHelper msql = new MySQLHelper();
        private ObservableCollection<Stock> stock_taula = new ObservableCollection<Stock>();
        private ObservableCollection<Erabiltzaileak> erabiltzaileak_taula = new ObservableCollection<Erabiltzaileak>();

        public Admin()
        {
            InitializeComponent();
            datuak_kargatu_stock();
            datuak_kargatu_erabil();
        }

        private void Button_berria_erabil(object sender, RoutedEventArgs e)
        {
            Sortu_eta_editatu sortu_window = new Sortu_eta_editatu("", "", "", false);
           
            if (sortu_window.ShowDialog() == true)
            {
                create_User(sortu_window.erabiltzailea_berria.Izena, sortu_window.erabiltzailea_berria.Pazahitza, sortu_window.erabiltzailea_berria.Mota);
                datuak_kargatu_erabil();
            }
        }

        private void Button_editatu_erabil(object sender, RoutedEventArgs e)
        {
            if (Lista2.SelectedItem is Erabiltzaileak erabiltzaie ) { 

                Sortu_eta_editatu editatu_window = new Sortu_eta_editatu(erabiltzaie.Izena, erabiltzaie.Pazahitza, erabiltzaie.Mota, true);

                if (editatu_window.ShowDialog() == true)
                {
                    string query = $"UPDATE `Erabiltzaileak` SET `Izena` = '{editatu_window.erabiltzailea_berria.Izena}', `Pazahitza` = '{editatu_window.erabiltzailea_berria.Pazahitza}', `Mota` = '{editatu_window.erabiltzailea_berria.Mota}' WHERE `Izena` = '{erabiltzaie.Izena}';";
                    msql.ExecuteNonQuery(query);
                    datuak_kargatu_erabil();
                }
            }

        }

        private void Button_Ezabatu_erabil(object sender, RoutedEventArgs e)
        {
            if (Lista2.SelectedItem is Erabiltzaileak erabiltzaie)
            {
                string query = $"DELETE FROM `Erabiltzaileak` WHERE `Izena` = '{erabiltzaie.Izena}';";
                msql.ExecuteNonQuery(query);
                datuak_kargatu_erabil();
            }
        }

        private void Button_berria_stock(object sender, RoutedEventArgs e)
        {
            Sortu_eta_editatu_Stock sortu_window = new Sortu_eta_editatu_Stock("", 0, 0, false);

            if (sortu_window.ShowDialog() == true)
            {
                create_Stock(sortu_window.stock_berria.Izena, sortu_window.stock_berria.Kantitatea, sortu_window.stock_berria.Prezioa);
                datuak_kargatu_stock();
            }
        }

        private void Button_editatu_stock(object sender, RoutedEventArgs e)
        {
            if (Lista1.SelectedItem is Stock stock)
            {

                Sortu_eta_editatu_Stock editatu_window = new Sortu_eta_editatu_Stock(stock.Izena, stock.Kantitatea, stock.Prezioa, true);

                if (editatu_window.ShowDialog() == true)
                {
                    string query = @"UPDATE `Biltegia` SET `Izena` = @izena_berria, `Kantitatea` = @kantitatea, `Prezioa` = @prezioa WHERE `Izena` = @izena_original";

                    MySqlParameter[] parameters = {
                        new MySqlParameter("@izena_berria", editatu_window.stock_berria.Izena),
                        new MySqlParameter("@kantitatea", editatu_window.stock_berria.Kantitatea),
                        new MySqlParameter("@prezioa", editatu_window.stock_berria.Prezioa),
                        new MySqlParameter("@izena_original", stock.Izena)
                    };

                    int result = msql.ExecuteNonQuery(query, parameters);


                    datuak_kargatu_stock();
                }
            }

        }

        private void Button_Ezabatu_stock(object sender, RoutedEventArgs e)
        {
            if (Lista1.SelectedItem is Stock stock)
            {
                string query = $"DELETE FROM `Biltegia` WHERE `Izena` = '{stock.Izena}';";
                msql.ExecuteNonQuery(query);

                datuak_kargatu_stock();
            }
        }

        private void datuak_kargatu_stock() {

            string query = "SELECT Izena, Kantitatea, Prezioa FROM Biltegia";
            DataTable emaitza= msql.ExecuteQuery(query);


            if (emaitza.Rows.Count > 0)
            {

                stock_taula.Clear();

                for (int i = 0; i < emaitza.Rows.Count; i++)
                {
                    Stock stock = new Stock();

                    stock.Izena = emaitza.Rows[i]["Izena"].ToString();
                    stock.Kantitatea = Convert.ToInt32(emaitza.Rows[i]["Kantitatea"]);
                    stock.Prezioa = Convert.ToSingle(emaitza.Rows[i]["Prezioa"]);                   
                   

                    stock_taula.Add(stock);
                }
                Lista1.ItemsSource = stock_taula;
            }
            else { 
                Lista1.ItemsSource=null;
            }
        }

        private void datuak_kargatu_erabil()
        {
            string query = "SELECT Izena, Pazahitza, Mota FROM Erabiltzaileak";

            DataTable emaitza = msql.ExecuteQuery(query);

            if (emaitza.Rows.Count > 0)
            {

                erabiltzaileak_taula.Clear();

                for (int i = 0; i < emaitza.Rows.Count; i++)
                {
                    Erabiltzaileak erabiltzaileak = new Erabiltzaileak();

                    erabiltzaileak.Izena = emaitza.Rows[i]["Izena"].ToString();
                    erabiltzaileak.Pazahitza = emaitza.Rows[i]["Pazahitza"].ToString();
                    erabiltzaileak.Mota = emaitza.Rows[i]["Mota"].ToString();

                    erabiltzaileak_taula.Add(erabiltzaileak);

                }
                Lista2.ItemsSource = erabiltzaileak_taula;
            }
            else
            {
                Lista2.ItemsSource=null;
            }


        }

        public void create_User(string izena, string pazahitza, string mota)
        {
            string query = $"INSERT INTO `Erabiltzaileak` (`Izena`, `Pazahitza`, `Mota`) VALUES ('{izena}', '{pazahitza}', '{mota}');";

            msql.ExecuteNonQuery(query);
        }

        public void create_Stock(string izena, int kantitatea, float prezioa)
        {
            string query = @"INSERT INTO `Biltegia` (`Izena`, `Kantitatea`, `Prezioa`) 
                 VALUES (@izena, @kantitatea, @prezioa, @img)";

            MySqlParameter[] parameters = {
                new MySqlParameter("@izena", izena),
                new MySqlParameter("@kantitatea", kantitatea),
                new MySqlParameter("@prezioa", prezioa),
            };

            msql.ExecuteNonQuery(query, parameters);
        }

        private void Button_irten(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
