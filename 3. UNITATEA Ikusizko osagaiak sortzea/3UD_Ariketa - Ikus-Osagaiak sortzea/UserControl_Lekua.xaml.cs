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
        public Dictionary<string, bool> json;

        public UserControl_Lekua()
        {
            InitializeComponent();

            string jsonPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bus.json");
            jsonKokapena = File.ReadAllText(jsonPath);
            json = JsonSerializer.Deserialize<Dictionary<string, bool>>(jsonKokapena);

            botoiakEguneratu();
        }

        private void botoia1_Click(object sender, RoutedEventArgs e)
        {
            if (!Lekua1Okatuta)
            {
                botoia1.Background = Brushes.Red;
                botoia1.Content = "Lekua 1 okupatuta";
                Lekua1Okatuta= true;
            }
            else {
                botoia1.Background = Brushes.Green;
                botoia1.Content = "Lekua 1";
                Lekua1Okatuta= false;
            }
            json["Lekua1"] = Lekua1Okatuta;
            GordeJSONa();
        }

        private void botoia2_Click(object sender, RoutedEventArgs e)
        {
            if (!Lekua2Okatuta)
            {
                botoia2.Background = Brushes.Red;
                botoia2.Content = "Lekua 2 okupatuta";
                Lekua2Okatuta= true;
            }
            else
            {
                botoia2.Background = Brushes.Green;
                botoia2.Content = "Lekua 2";
                Lekua2Okatuta = false;
            }
            json["Lekua2"] = Lekua2Okatuta;
            GordeJSONa();
        }

        private void botoia3_Click(object sender, RoutedEventArgs e)
        {
            if (!Lekua3Okatuta)
            {
                botoia3.Background = Brushes.Red;
                botoia3.Content = "Lekua 3 okupatuta";
                Lekua3Okatuta = true;
            }
            else
            {
                botoia3.Background = Brushes.Green;
                botoia3.Content = "Lekua 3";
                Lekua3Okatuta = false;
            }
            json["Lekua3"] = Lekua3Okatuta;
            GordeJSONa();
        }

        private void botoia4_Click(object sender, RoutedEventArgs e)
        {
            if (!Lekua4Okatuta)
            {
                botoia4.Background = Brushes.Red;
                botoia4.Content = "Lekua 4 okupatuta";
                Lekua4Okatuta = true;
            }
            else
            {
                botoia4.Background = Brushes.Green;
                botoia4.Content = "Lekua 4";
                Lekua4Okatuta = false;
            }
            json["Lekua4"] = Lekua4Okatuta;
            GordeJSONa();
        }

        private void botoia5_Click(object sender, RoutedEventArgs e)
        {
            if (!Lekua5Okatuta)
            {
                botoia5.Background = Brushes.Red;
                botoia5.Content = "Lekua 5 okupatuta";
                Lekua5Okatuta = true;
            }
            else
            {
                botoia5.Background = Brushes.Green;
                botoia5.Content = "Lekua 5";
                Lekua5Okatuta = false;
            }
            json["Lekua5"] = Lekua5Okatuta;
            GordeJSONa();
        }

        private void botoia6_Click(object sender, RoutedEventArgs e)
        {
            if (!Lekua6Okatuta)
            {
                botoia6.Background = Brushes.Red;
                botoia6.Content = "Lekua 6 okupatuta";
                Lekua6Okatuta = true;
            }
            else
            {
                botoia6.Background = Brushes.Green;
                botoia6.Content = "Lekua 6";
                Lekua6Okatuta = false;
            }
            json["Lekua6"] = Lekua6Okatuta;
            GordeJSONa();
        }

        private void botoia7_Click(object sender, RoutedEventArgs e)
        {
            if (!Lekua7Okatuta)
            {
                botoia7.Background = Brushes.Red;
                botoia7.Content = "Lekua 7 okupatuta";
                Lekua7Okatuta = true;
            }
            else
            {
                botoia7.Background = Brushes.Green;
                botoia7.Content = "Lekua 7";
                Lekua7Okatuta = false;
            }
            json["Lekua7"] = Lekua7Okatuta;
            GordeJSONa();
        }

        private void botoia8_Click(object sender, RoutedEventArgs e)
        {
            if (!Lekua8Okatuta)
            {
                botoia8.Background = Brushes.Red;
                botoia8.Content = "Lekua 8 okupatuta";
                Lekua8Okatuta = true;
            }
            else
            {
                botoia8.Background = Brushes.Green;
                botoia8.Content = "Lekua 8";
                Lekua8Okatuta = false;
            }
            json["Lekua8"] = Lekua8Okatuta;
            GordeJSONa();
        }

        private void botoia9_Click(object sender, RoutedEventArgs e)
        {
            if (!Lekua9Okatuta)
            {
                botoia9.Background = Brushes.Red;
                botoia9.Content = "Lekua 9 okupatuta";
                Lekua9Okatuta = true;
            }
            else
            {
                botoia9.Background = Brushes.Green;
                botoia9.Content = "Lekua 9";
                Lekua9Okatuta = false;
            }
            json["Lekua9"] = Lekua9Okatuta;
        }

        private void botoia10_Click(object sender, RoutedEventArgs e)
        {
            if (!Lekua10Okatuta)
            {
                botoia10.Background = Brushes.Red;
                botoia10.Content = "Lekua 10 okupatuta";
                Lekua10Okatuta = true;
            }
            else
            {
                botoia10.Background = Brushes.Green;
                botoia10.Content = "Lekua 10";
                Lekua10Okatuta = false;
            }
            json["Lekua10"] = Lekua10Okatuta;
            GordeJSONa();
        }

        private void GordeJSONa()
        {
            try
            {
                string jsonPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bus.json");
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
                        if (json["Lekua1"])
                        {
                            botoia1.Background = Brushes.Red;
                            botoia1.Content = "Lekua 1 okupatuta";
                            Lekua1Okatuta = true;
                        }
                        break;
                    
                    case 2:
                        if (json["Lekua2"])
                        {
                            botoia2.Background = Brushes.Red;
                            botoia2.Content = "Lekua 2 okupatuta";
                            Lekua2Okatuta = true;
                        }
                        break;

                    case 3:
                        if (json["Lekua3"])
                        {
                            botoia3.Background = Brushes.Red;
                            botoia3.Content = "Lekua 3 okupatuta";
                            Lekua3Okatuta = true;
                        }
                        break;

                    case 4:
                        if (json["Lekua4"])
                        {
                            botoia4.Background = Brushes.Red;
                            botoia4.Content = "Lekua 4 okupatuta";
                            Lekua4Okatuta = true;
                        }
                        break;

                    case 5:
                        if (json["Lekua5"])
                        {
                            botoia5.Background = Brushes.Red;
                            botoia5.Content = "Lekua 5 okupatuta";
                            Lekua5Okatuta = true;
                        }
                        break;

                    case 6:
                        if (json["Lekua6"])
                        {
                            botoia6.Background = Brushes.Red;
                            botoia6.Content = "Lekua 6 okupatuta";
                            Lekua6Okatuta = true;
                        }
                        break;

                    case 7:
                        if (json["Lekua7"])
                        {
                            botoia7.Background = Brushes.Red;
                            botoia7.Content = "Lekua 7 okupatuta";
                            Lekua7Okatuta = true;
                        }
                        break;

                    case 8:
                        if (json["Lekua8"])
                        {
                            botoia8.Background = Brushes.Red;
                            botoia8.Content = "Lekua 8 okupatuta";
                            Lekua8Okatuta = true;
                        }
                        break;

                    case 9:
                        if (json["Lekua9"])
                        {
                            botoia9.Background = Brushes.Red;
                            botoia9.Content = "Lekua 9 okupatuta";
                            Lekua9Okatuta = true;
                        }
                        break;

                    case 10:
                        if (json["Lekua10"])
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
