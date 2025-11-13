using MySql.Data.MySqlClient;
using System.Data;
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

namespace TPV_sistema
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MySQLHelper msql= new MySQLHelper();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Longi(object sender, RoutedEventArgs e)
        {
            DataTable emaitza = GetUserById(izena.Text, pazahitza.Text);

            if (emaitza.Rows.Count > 0)
            {
                string mota = emaitza.Rows[0]["Mota"].ToString();
                if (mota == "Admin") { 
                
                    Admin admin = new Admin();
                    admin.Show();
                    this.Close();

                }
                else if (mota == "Erabiltzaile")
                {
                    Erabiltzaile erabiltzaile = new Erabiltzaile(izena.Text);
                    erabiltzaile.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Erabiltzailea ez da aurkitu.");

            }
        }

        public DataTable GetUserById(string izena, string pazahitza)
        {
            string query = "SELECT Mota FROM Erabiltzaileak WHERE Izena = @izena AND Pazahitza = @pazahitza";

            using (MySqlConnection connection = new MySqlConnection(msql.connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@izena", izena);
                command.Parameters.AddWithValue("@pazahitza", pazahitza);
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