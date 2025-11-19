using Google.Protobuf.WellKnownTypes;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TPV_sistema
{
    /// <summary>
    /// Interaction logic for Erabiltzaile.xaml
    /// </summary>
    public partial class Erabiltzaile : Window
    {
        MySQLHelper msql = new MySQLHelper();
        private ObservableCollection<Stock> stock_taula = new ObservableCollection<Stock>();

        bool hasiera = false;
        private string erabiltzailea;
        Dictionary<string, float> produktuak = new Dictionary<string, float>();
        Dictionary<string, int> produktuak_kant = new Dictionary<string, int>();

        public float Total { get; set; }

        public Erabiltzaile(string erabiltzailea)
        {
            InitializeComponent();
            SesioKudeatzailea.Sartu(erabiltzailea);
            this.erabiltzailea = erabiltzailea;
            datak_kargatu();
            datuak_kargatu_stock();
        }

        private void longin_click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
            this.Close();
        }

        private void datak_kargatu()
        {
            datak.Items.Clear();
            datak_2.Items.Clear();

            DateTime fechaBase = DateTime.Today.AddDays(1);

            for (int i = 0; i < 5; i++)
            {
                DateTime fecha = fechaBase.AddDays(i);
               
                string fechaFormateada = fecha.ToString("yyyy-MM-dd");
                datak.Items.Add(fechaFormateada);
                datak_2.Items.Add(fechaFormateada);
            }

            if (datak.Items.Count > 0)
                datak.SelectedIndex = 0;

            if (datak_2.Items.Count > 0)
                datak_2.SelectedIndex = 0;

            Mesa1.data_Box = datak.Text;
            Mesa2.data_Box = datak.Text;
            Mesa3.data_Box = datak.Text;
            Mesa4.data_Box = datak.Text;
            Mesa5.data_Box = datak.Text;
            Mesa6.data_Box = datak.Text;
            Mesa7.data_Box = datak.Text;
            Mesa8.data_Box = datak.Text;
            Mesa9.data_Box = datak.Text;
            Mesa10.data_Box = datak.Text;
            Mesa11.data_Box = datak.Text;
            Mesa12.data_Box = datak.Text;

            eguneratu("Bazkaria", datak.Text);
            eguneratu("Afaria", datak_2.Text);
        }

        private void datak_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {
            if (hasiera && datak.SelectedItem != null)
            {
                string selectedValue = datak.SelectedItem.ToString();

                Mesa1.data_Box = selectedValue;
                Mesa2.data_Box = selectedValue;
                Mesa3.data_Box = selectedValue;
                Mesa4.data_Box = selectedValue;
                Mesa5.data_Box = selectedValue;
                Mesa6.data_Box = selectedValue;

               
                eguneratu("Bazkaria", selectedValue);
            }
            else
            {
                hasiera = true;
            }
        }

        private void datak_SelectionChanged2(object sender, SelectionChangedEventArgs e)
        {
            if (hasiera && datak_2.SelectedItem != null)
            {
                string selectedValue = datak_2.SelectedItem.ToString();

                Mesa7.data_Box = selectedValue;
                Mesa8.data_Box = selectedValue;
                Mesa9.data_Box = selectedValue;
                Mesa10.data_Box = selectedValue;
                Mesa11.data_Box = selectedValue;
                Mesa12.data_Box = selectedValue;

                
                eguneratu("Afaria", selectedValue);
            }
            else
            {
                hasiera = true;
            }
        }

        public void eguneratu(string mota, string data)
        {
            string query = $"SELECT * From Mahiak WHERE mota = '{mota}' AND data = '{data}';";
        
            DataTable emaitza = msql.ExecuteQuery(query);

            if (mota=="Bazkaria") {
                Mesa1.neutral();
                Mesa2.neutral();
                Mesa3.neutral();
                Mesa4.neutral();
                Mesa5.neutral();
                Mesa6.neutral();
                if (emaitza.Rows.Count > 0)
                {

                    foreach (DataRow row in emaitza.Rows)
                    {
                        string mahia = row["mahia"]?.ToString();
                        string erabiltzaileaDb = row["erabiltzailea"]?.ToString();

                        DateTime dataDb = DateTime.Parse(row["data"].ToString());
                        string dataDbStr = dataDb.ToString("yyyy-MM-dd");

                        switch (row["mahia"]?.ToString())
                        {

                            case "1":
                                if (dataDbStr == data && row["erabiltzailea"]?.ToString() == erabiltzailea)
                                {
                                    Mesa1.aldatu_egoera();
                                }
                                else if (row["erabiltzailea"]?.ToString() != erabiltzailea)
                                {
                                   /* bool a = dataDbStr == data && row["erabiltzailea"]?.ToString() == erabiltzailea;
                                    bool b2 = dataDbStr == data;
                                    bool c2 = row["erabiltzailea"]?.ToString() == erabiltzailea;*/

                                    Mesa1.desaktibatu();
                                }
                                break;
                            case "2":
                                if (dataDbStr == data && row["erabiltzailea"]?.ToString() == erabiltzailea)
                                {
                                    Mesa2.aldatu_egoera();
                                }
                                else if (row["erabiltzailea"]?.ToString() != erabiltzailea)
                                {
                                    Mesa2.desaktibatu();
                                }
                                break;
                            case "3":
                                if (dataDbStr == data && row["erabiltzailea"]?.ToString() == erabiltzailea)
                                {
                                    Mesa3.aldatu_egoera();
                                }
                                else if (row["erabiltzailea"]?.ToString() != erabiltzailea)
                                {
                                    Mesa3.desaktibatu();
                                }
                                break;
                            case "4":
                                if (dataDbStr == data && row["erabiltzailea"]?.ToString() == erabiltzailea)
                                {
                                    Mesa4.aldatu_egoera();
                                }
                                else if (row["erabiltzailea"]?.ToString() != erabiltzailea)
                                {
                                    Mesa4.desaktibatu();
                                }
                                break;
                            case "5":
                                if (dataDbStr == data && row["erabiltzailea"]?.ToString() == erabiltzailea)
                                {
                                    Mesa5.aldatu_egoera();
                                }
                                else if (row["erabiltzailea"]?.ToString() != erabiltzailea)
                                {
                                    Mesa5.desaktibatu();
                                }
                                break;
                            case "6":
                                if (dataDbStr == data && row["erabiltzailea"]?.ToString() == erabiltzailea)
                                {
                                    Mesa6.aldatu_egoera();
                                }
                                else if (row["erabiltzailea"]?.ToString() != erabiltzailea)
                                {
                                    Mesa6.desaktibatu();
                                }
                                break;
                        }
                    }
                }
                else
                {
                    Mesa1.neutral();
                    Mesa2.neutral();
                    Mesa3.neutral();
                    Mesa4.neutral();
                    Mesa5.neutral();
                    Mesa6.neutral();
                   // MessageBox.Show("No se encontraron filas en la tabla mahiak");
                }
            }
            else if (mota=="Afaria") {
                Mesa7.neutral();
                Mesa8.neutral();
                Mesa9.neutral();
                Mesa10.neutral();
                Mesa11.neutral();
                Mesa12.neutral();
                if (emaitza.Rows.Count > 0)
                {

                    foreach (DataRow row in emaitza.Rows)
                    {
                        string mahia = row["mahia"]?.ToString();
                        string erabiltzaileaDb = row["erabiltzailea"]?.ToString();

                        DateTime dataDb = DateTime.Parse(row["data"].ToString());
                        string dataDbStr = dataDb.ToString("yyyy-MM-dd");

                        switch (row["mahia"]?.ToString())
                        {

                            case "1":
                                if (dataDbStr == data && row["erabiltzailea"]?.ToString() == erabiltzailea)
                                {
                                    Mesa7.aldatu_egoera();
                                }
                                else if (row["erabiltzailea"]?.ToString() != erabiltzailea)
                                {
                                    Mesa7.desaktibatu();
                                }
                                break;
                            case "2":
                                if (dataDbStr == data && row["erabiltzailea"]?.ToString() == erabiltzailea)
                                {
                                    Mesa8.aldatu_egoera();
                                }
                                else if (row["erabiltzailea"]?.ToString() != erabiltzailea)
                                {
                                    Mesa8.desaktibatu();
                                }
                                break;
                            case "3":
                                if (dataDbStr == data && row["erabiltzailea"]?.ToString() == erabiltzailea)
                                {
                                    Mesa9.aldatu_egoera();
                                }
                                else if (row["erabiltzailea"]?.ToString() != erabiltzailea)
                                {
                                    Mesa9.desaktibatu();
                                }
                                break;
                            case "4":
                                if (dataDbStr == data && row["erabiltzailea"]?.ToString() == erabiltzailea)
                                {
                                    Mesa10.aldatu_egoera();
                                }
                                else if (row["erabiltzailea"]?.ToString() != erabiltzailea)
                                {
                                    Mesa10.desaktibatu();
                                }
                                break;
                            case "5":
                                if (dataDbStr == data && row["erabiltzailea"]?.ToString() == erabiltzailea)
                                {
                                    Mesa11.aldatu_egoera();
                                }
                                else if (row["erabiltzailea"]?.ToString() != erabiltzailea)
                                {
                                    Mesa11.desaktibatu();
                                }
                                break;
                            case "6":
                                if (dataDbStr == data && row["erabiltzailea"]?.ToString() == erabiltzailea)
                                {
                                    Mesa12.aldatu_egoera();
                                }
                                else if (row["erabiltzailea"]?.ToString() != erabiltzailea)
                                {
                                    Mesa12.desaktibatu();
                                }
                                break;
                        }
                    }
                }
                else
                {
                    Mesa7.neutral();
                    Mesa8.neutral();
                    Mesa9.neutral();
                    Mesa10.neutral();
                    Mesa11.neutral();
                    Mesa12.neutral();
                    //MessageBox.Show("No se encontraron filas en la tabla mahiak");
                }
            }
            
        }

        private void datuak_kargatu_stock()
        {

            string query = "SELECT Izena, Kantitatea, Prezioa FROM Biltegia";
            DataTable emaitza = msql.ExecuteQuery(query);


            if (emaitza.Rows.Count > 0)
            {

                stock_taula.Clear();
                produktuak.Clear();
                produktuak_kant.Clear();
                erosi.Items.Clear();
                for (int i = 0; i < emaitza.Rows.Count; i++)
                {
                    Stock stock = new Stock();

                    stock.Izena = emaitza.Rows[i]["Izena"].ToString();
                    stock.Kantitatea = Convert.ToInt32(emaitza.Rows[i]["Kantitatea"]);
                    stock.Prezioa = Convert.ToSingle(emaitza.Rows[i]["Prezioa"]);

                    produktuak.Add(stock.Izena, stock.Prezioa);
                    stock_taula.Add(stock);
                }
                Lista1.ItemsSource = stock_taula;
            }
            else
            {
                Lista1.ItemsSource = null;
            }
        }

        private void Button_sartu(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Kantitatea.Text, out int result))
            {
                if (Lista1.SelectedItem is Stock stock) {

                    if (stock.Kantitatea >= int.Parse(Kantitatea.Text))
                    {

                        for (int i = erosi.Items.Count - 1; i >= 0; i--)
                        {
                            string item = erosi.Items[i] as string;
                            string[] zatitu = item.Split("--");
                            string prezioa_zatitu = zatitu[2].Replace("€", "");
                            
                            if (item != null && item.Contains(stock.Izena))
                            {
                                Total -= (float)Math.Round(float.Parse(prezioa_zatitu),2);
                                Total = (float)Math.Round(Total, 2);
                                erosi.Items.RemoveAt(i);
                            }
                        }


                        float total_prezio = (float)Math.Round(int.Parse(Kantitatea.Text) * stock.Prezioa, 2);
                        erosi.Items.Add(stock.Izena + "--" + Kantitatea.Text + "--" + total_prezio + "€");

                        
                        for (int i = erosi.Items.Count - 1; i >= 0; i--)
                        {
                            string[] item2 = erosi.Items[i].ToString().Split("--");
                            if (item2.Contains(stock.Izena))
                            {
                                int kantitatea = int.Parse(item2[1]);

                                total_prezio = (float)Math.Round(int.Parse(Kantitatea.Text) * stock.Prezioa, 2);

                                Total += total_prezio;
                               
                                Total = (float)Math.Round(Total, 2);
                                produktuak_kant[stock.Izena] = kantitatea;
                            }
                        }
                        
                        Totala.Text = Total.ToString() + " €";
                    }
                    else
                    {
                        MessageBox.Show("Ez dago stock nahikorik.");
                    }

                }
            }
            else
            {
                MessageBox.Show("Zenbakia izan behar da.");
            }
        }

        private void Button_baieztatu(object sender, RoutedEventArgs e)
        {
            foreach (var item in produktuak_kant)
            {
                string query = $"UPDATE `Biltegia` SET `Kantitatea` = `Kantitatea`-{item.Value} WHERE `Izena` = '{item.Key}'";
                msql.ExecuteNonQuery(query);
            }
            datuak_kargatu_stock();
        }

        private void Button_Ezabatu(object sender, RoutedEventArgs e)
        {
            if (erosi.SelectedIndex != -1)
            {
                string item = erosi.SelectedItem.ToString();
                string[] zatitu = item.Split("--");
                string prezioa_zatitu = zatitu[2].Replace("€", "");

                erosi.Items.RemoveAt(erosi.SelectedIndex);

                Total -= (float)Math.Round(float.Parse(prezioa_zatitu), 2);
                Total = (float)Math.Round(Total, 2);
                Totala.Text = Total.ToString() + " €";
                produktuak_kant.Remove(zatitu[0]);
            }
        }
    }
}
