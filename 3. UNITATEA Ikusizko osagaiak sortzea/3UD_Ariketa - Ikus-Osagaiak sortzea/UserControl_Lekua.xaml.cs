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
using System.Text.Json;
using System.IO;

namespace _3UD_Ariketa___Ikus_Osagaiak_sortzea
{
    /// <summary>
    /// Interaction logic for UserControl_Lekua.xaml
    /// </summary>
    public partial class UserControl_Lekua : UserControl
    {

        public bool Lekua1Okatuta { get; set; } = false;
        public bool Lekua2Okatuta { get; set; } = false;
        public bool Lekua3Okatuta { get; set; } = false;
        public bool Lekua4Okatuta { get; set; } = false;
        public bool Lekua5Okatuta { get; set; } = false;
        public bool Lekua6Okatuta { get; set; } = false;
        public bool Lekua7Okatuta { get; set; } = false;
        public bool Lekua8Okatuta { get; set; } = false;
        public bool Lekua9Okatuta { get; set; } = false;
        public bool Lekua10Okatuta { get; set; } = false;

        public string jsonKokapena;
        public Dictionary<string, List<LekuaData>> json;
        Data_Dialog dataDialog = new Data_Dialog();

        public static readonly DependencyProperty JsonFileNameProperty =
        DependencyProperty.Register("JsonFileName", typeof(string), typeof(UserControl_Lekua));

        public string JsonFileName
        {
            get { return (string)GetValue(JsonFileNameProperty); }
            set { SetValue(JsonFileNameProperty, value); }
        }

        public class LekuaData
        {
            public bool ocupatuta { get; set; }
            public string data { get; set; }
        }

        public UserControl_Lekua()
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(this.JsonFileName))
            {
                string jsonPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, this.JsonFileName);
                jsonKokapena = File.ReadAllText(jsonPath);
                json = JsonSerializer.Deserialize<Dictionary<string, List<LekuaData>>>(jsonKokapena);
                botoiakEguneratu();
            }
        }

        private void botoia1_Click(object sender, RoutedEventArgs e)
        {
            dataDialog.ShowDialog();

            if (!Lekua1Okatuta) {
                if (dataDialog.DialogResult == true)
                {
                    botoia1.Background = Brushes.Red;
                    botoia1.Content = "Lekua 1 okupatuta";
                    Lekua1Okatuta = true;
                    json["Lekua1"][0].data = dataDialog.data.ToString();
                }
            }
            else {
                botoia1.Background = Brushes.Green;
                botoia1.Content = "Lekua 1";
                Lekua1Okatuta = false;
                json["Lekua1"][0].data = "";
            }

            json["Lekua1"][0].ocupatuta = Lekua1Okatuta;
            GordeJSONa(); 
        }

        private void botoia2_Click(object sender, RoutedEventArgs e)
        {
            dataDialog.ShowDialog();

            if (!Lekua2Okatuta)
            {
                if (dataDialog.DialogResult == true)
                {
                    botoia2.Background = Brushes.Red;
                    botoia2.Content = "Lekua 2 okupatuta";
                    Lekua2Okatuta = true;
                    json["Lekua2"][0].data = dataDialog.data.ToString();
                }
            }
            else
            {
                botoia2.Background = Brushes.Green;
                botoia2.Content = "Lekua 2";
                Lekua2Okatuta = false;
                json["Lekua2"][0].data = "";
            }

            json["Lekua2"][0].ocupatuta = Lekua2Okatuta;
            GordeJSONa();
        }

        private void botoia3_Click(object sender, RoutedEventArgs e)
        {
            dataDialog.ShowDialog();

            if (!Lekua3Okatuta)
            {
                if (dataDialog.DialogResult == true)
                {
                    botoia3.Background = Brushes.Red;
                    botoia3.Content = "Lekua 3 okupatuta";
                    Lekua3Okatuta = true;
                    json["Lekua3"][0].data = dataDialog.data.ToString();
                }
            }
            else
            {
                botoia3.Background = Brushes.Green;
                botoia3.Content = "Lekua 3";
                Lekua3Okatuta = false;
                json["Lekua3"][0].data = "";
            }

            json["Lekua3"][0].ocupatuta = Lekua3Okatuta;
            GordeJSONa();
        }

        private void botoia4_Click(object sender, RoutedEventArgs e)
        {
            dataDialog.ShowDialog();

            if (!Lekua4Okatuta)
            {
                if (dataDialog.DialogResult == true)
                {
                    botoia4.Background = Brushes.Red;
                    botoia4.Content = "Lekua 4 okupatuta";
                    Lekua4Okatuta = true;
                    json["Lekua4"][0].data = dataDialog.data.ToString();
                }
            }
            else
            {
                botoia4.Background = Brushes.Green;
                botoia4.Content = "Lekua 4";
                Lekua4Okatuta = false;
                json["Lekua4"][0].data = "";
            }

            json["Lekua4"][0].ocupatuta = Lekua4Okatuta;
            GordeJSONa();
        }

        private void botoia5_Click(object sender, RoutedEventArgs e)
        {
            dataDialog.ShowDialog();

            if (!Lekua5Okatuta)
            {
                if (dataDialog.DialogResult == true)
                {
                    botoia5.Background = Brushes.Red;
                    botoia5.Content = "Lekua 5 okupatuta";
                    Lekua5Okatuta = true;
                    json["Lekua5"][0].data = dataDialog.data.ToString();
                }
            }
            else
            {
                botoia5.Background = Brushes.Green;
                botoia5.Content = "Lekua 5";
                Lekua5Okatuta = false;
                json["Lekua5"][0].data = "";
            }

            json["Lekua5"][0].ocupatuta = Lekua5Okatuta;
            GordeJSONa();
        }

        private void botoia6_Click(object sender, RoutedEventArgs e)
        {
            dataDialog.ShowDialog();

            if (!Lekua6Okatuta)
            {
                if (dataDialog.DialogResult == true)
                {
                    botoia6.Background = Brushes.Red;
                    botoia6.Content = "Lekua 6 okupatuta";
                    Lekua6Okatuta = true;
                    json["Lekua6"][0].data = dataDialog.data.ToString();
                }
            }
            else
            {
                botoia6.Background = Brushes.Green;
                botoia6.Content = "Lekua 6";
                Lekua6Okatuta = false;
                json["Lekua6"][0].data = "";
            }

            json["Lekua6"][0].ocupatuta = Lekua6Okatuta;
            GordeJSONa();
        }

        private void botoia7_Click(object sender, RoutedEventArgs e)
        {
            dataDialog.ShowDialog();

            if (!Lekua7Okatuta)
            {
                if (dataDialog.DialogResult == true)
                {
                    botoia7.Background = Brushes.Red;
                    botoia7.Content = "Lekua 7 okupatuta";
                    Lekua7Okatuta = true;
                    json["Lekua7"][0].data = dataDialog.data.ToString();
                }
            }
            else
            {
                botoia7.Background = Brushes.Green;
                botoia7.Content = "Lekua 7";
                Lekua7Okatuta = false;
                json["Lekua7"][0].data = "";
            }

            json["Lekua7"][0].ocupatuta = Lekua7Okatuta;
            GordeJSONa();
        }

        private void botoia8_Click(object sender, RoutedEventArgs e)
        {
            dataDialog.ShowDialog();

            if (!Lekua8Okatuta)
            {
                if (dataDialog.DialogResult == true)
                {
                    botoia8.Background = Brushes.Red;
                    botoia8.Content = "Lekua 8 okupatuta";
                    Lekua8Okatuta = true;
                    json["Lekua8"][0].data = dataDialog.data.ToString();
                }
            }
            else
            {
                botoia8.Background = Brushes.Green;
                botoia8.Content = "Lekua 8";
                Lekua8Okatuta = false;
                json["Lekua8"][0].data = "";
            }

            json["Lekua8"][0].ocupatuta = Lekua8Okatuta;
            GordeJSONa();
        }

        private void botoia9_Click(object sender, RoutedEventArgs e)
        {
            dataDialog.ShowDialog();

            if (!Lekua9Okatuta)
            {
                if (dataDialog.DialogResult == true)
                {
                    botoia9.Background = Brushes.Red;
                    botoia9.Content = "Lekua 9 okupatuta";
                    Lekua9Okatuta = true;
                    json["Lekua9"][0].data = dataDialog.data.ToString();
                }
            }
            else
            {
                botoia9.Background = Brushes.Green;
                botoia9.Content = "Lekua 9";
                Lekua9Okatuta = false;
                json["Lekua9"][0].data = "";
            }

            json["Lekua9"][0].ocupatuta = Lekua9Okatuta;
            GordeJSONa();
        }

        private void botoia10_Click(object sender, RoutedEventArgs e)
        {
            dataDialog.ShowDialog();

            if (!Lekua10Okatuta)
            {
                if (dataDialog.DialogResult == true)
                {
                    botoia10.Background = Brushes.Red;
                    botoia10.Content = "Lekua 10 okupatuta";
                    Lekua10Okatuta = true;
                    json["Lekua10"][0].data = dataDialog.data.ToString();
                }
            }
            else
            {
                botoia10.Background = Brushes.Green;
                botoia10.Content = "Lekua 10";
                Lekua10Okatuta = false;
                json["Lekua10"][0].data = "";
            }

            json["Lekua10"][0].ocupatuta = Lekua10Okatuta;
            GordeJSONa();
        }

        private void GordeJSONa()
        {
            try
            {
                string jsonPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, this.JsonFileName);
                string jsonString = JsonSerializer.Serialize(json, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(jsonPath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errorea JSON gordetzean: {ex.Message}");
            }
        }

        private void botoiakEguneratu() { 
        
            for (int i=1; i<json.Count+1; i++) {

                switch (i)
                {
                    case 1:
                        if (json["Lekua1"][0].ocupatuta)
                        {
                            botoia1.Background = Brushes.Red;
                            botoia1.Content = "Lekua 1 okupatuta";
                            Lekua1Okatuta = true;
                        }
                        break;
                    
                    case 2:
                        if (json["Lekua2"][0].ocupatuta)
                        {
                            botoia2.Background = Brushes.Red;
                            botoia2.Content = "Lekua 2 okupatuta";
                            Lekua2Okatuta = true;
                        }
                        break;

                    case 3:
                        if (json["Lekua3"][0].ocupatuta)
                        {
                            botoia3.Background = Brushes.Red;
                            botoia3.Content = "Lekua 3 okupatuta";
                            Lekua3Okatuta = true;
                        }
                        break;

                    case 4:
                        if (json["Lekua4"][0].ocupatuta)
                        {
                            botoia4.Background = Brushes.Red;
                            botoia4.Content = "Lekua 4 okupatuta";
                            Lekua4Okatuta = true;
                        }
                        break;

                    case 5:
                        if (json["Lekua5"][0].ocupatuta)
                        {
                            botoia5.Background = Brushes.Red;
                            botoia5.Content = "Lekua 5 okupatuta";
                            Lekua5Okatuta = true;
                        }
                        break;

                    case 6:
                        if (json["Lekua6"][0].ocupatuta)
                        {
                            botoia6.Background = Brushes.Red;
                            botoia6.Content = "Lekua 6 okupatuta";
                            Lekua6Okatuta = true;
                        }
                        break;

                    case 7:
                        if (json["Lekua7"][0].ocupatuta)
                        {
                            botoia7.Background = Brushes.Red;
                            botoia7.Content = "Lekua 7 okupatuta";
                            Lekua7Okatuta = true;
                        }
                        break;

                    case 8:
                        if (json["Lekua8"][0].ocupatuta)
                        {
                            botoia8.Background = Brushes.Red;
                            botoia8.Content = "Lekua 8 okupatuta";
                            Lekua8Okatuta = true;
                        }
                        break;

                    case 9:
                        if (json["Lekua9"][0].ocupatuta)
                        {
                            botoia9.Background = Brushes.Red;
                            botoia9.Content = "Lekua 9 okupatuta";
                            Lekua9Okatuta = true;
                        }
                        break;

                    case 10:
                        if (json["Lekua10"][0].ocupatuta)
                        {
                            botoia10.Background = Brushes.Red;
                            botoia10.Content = "Lekua 10 okupatuta";
                            Lekua10Okatuta = true;
                        }
                        break;
                }
            }
        }
    }
}
