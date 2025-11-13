using System;
using System.Collections.Generic;
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
    /// <summary>
    /// Interaction logic for Erabiltzaile.xaml
    /// </summary>
    public partial class Erabiltzaile : Window
    {
        MySQLHelper msql = new MySQLHelper();

        bool hasiera = false;
        private string erabiltzailea;

        public Erabiltzaile(string erabiltzailea)
        {
            InitializeComponent();
            SesioKudeatzailea.Sartu(erabiltzailea);
            this.erabiltzailea = erabiltzailea;
            datak_kargatu();
            
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

            DateTime fechaBase = DateTime.Today.AddDays(1);

            for (int i = 0; i < 5; i++)
            {
                DateTime fecha = fechaBase.AddDays(i);
               
                string fechaFormateada = fecha.ToString("yyyy-MM-dd");
                datak.Items.Add(fechaFormateada);
            }

            if (datak.Items.Count > 0)
                datak.SelectedIndex = 0;

            Mesa1.data_Box = datak.Text;
            Mesa2.data_Box = datak.Text;
            Mesa3.data_Box = datak.Text;
            Mesa4.data_Box = datak.Text;
            Mesa5.data_Box = datak.Text;
            Mesa6.data_Box = datak.Text;
            eguneratu("Bazkaria", datak.Text);
        }

        private void datak_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (hasiera)
            {
                
                Mesa1.data_Box = datak.Text;
                Mesa2.data_Box = datak.Text;
                Mesa3.data_Box = datak.Text;
                Mesa4.data_Box = datak.Text;
                Mesa5.data_Box = datak.Text;
                Mesa6.data_Box = datak.Text;
                
            }
            else
            {
                hasiera = true;
            }
        }

        public void eguneratu(string mota, string data)
        {
            MessageBox.Show(mota +"  "+data);
            string query = $"SELECT * From mahiak WHERE mota = '{mota}' AND data = '{data}';";
        
            DataTable emaitza = msql.ExecuteQuery(query);

            if (emaitza.Rows.Count > 0)
            {
                
                foreach (DataRow row in emaitza.Rows)
                {
                    string mahia = row["mahia"]?.ToString();
                    string erabiltzaileaDb = row["erabiltzailea"]?.ToString();

                    switch (row["mahia"]?.ToString()) { 
                    
                        case "1":
                            if (row["erabiltzailea"]?.ToString()==erabiltzailea)
                            {
                                Mesa1.aldatu_egoera();
                            }else
                            {
                                Mesa1.desaktibatu();
                            }
                            break;
                        case "2":
                            if (row["erabiltzailea"]?.ToString() == erabiltzailea)
                            {
                                Mesa2.aldatu_egoera();
                            }
                            else
                            {
                                Mesa2.desaktibatu();
                            }
                            break;
                        case "3":
                            if (row["erabiltzailea"]?.ToString() == erabiltzailea)
                            {
                                Mesa3.aldatu_egoera();
                            }
                            else
                            {
                                Mesa3.desaktibatu();
                            }
                            break;
                        case "4":
                            if (row["erabiltzailea"]?.ToString() == erabiltzailea)
                            {
                                Mesa4.aldatu_egoera();
                            }
                            else
                            {
                                Mesa4.desaktibatu();
                            }
                            break;
                        case "5":
                            if (row["erabiltzailea"]?.ToString() == erabiltzailea)
                            {
                                Mesa5.aldatu_egoera();
                            }
                            else
                            {
                                Mesa5.desaktibatu();
                            }
                            break;
                        case "6":
                            if (row["erabiltzailea"]?.ToString() == erabiltzailea)
                            {
                                Mesa6.aldatu_egoera();
                            }
                            else
                            {
                                Mesa6.desaktibatu();
                            }
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontraron filas en la tabla mahiak");
            }
        }
    }
}
