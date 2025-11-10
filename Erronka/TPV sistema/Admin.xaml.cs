using MySql.Data.MySqlClient;
using System;
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

        private void datuak_kargatu_stock() {
           DataTable emaitza= GetStock();

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
            

        }

        private void datuak_kargatu_erabil()
        {
            DataTable emaitza = GetUser();

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


        }

        public DataTable GetStock()
        {
            string query = "SELECT Izena, Kantitatea, Prezioa FROM Biltegia";

            using (MySqlConnection connection = new MySqlConnection(msql.connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
               
                connection.Open();

                DataTable dataTable = new DataTable();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                return dataTable;
            }
        }
        public DataTable GetUser()
        {
            string query = "SELECT Izena, Pazahitza, Mota FROM erabiltzaileak";

            using (MySqlConnection connection = new MySqlConnection(msql.connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {

                connection.Open();

                DataTable dataTable = new DataTable();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                return dataTable;
            }
        }

    }
}
