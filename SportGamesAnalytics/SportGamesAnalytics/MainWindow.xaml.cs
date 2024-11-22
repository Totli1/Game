using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Configuration;
using System.IO;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Convert;


namespace SportGamesAnalytics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        
     


       
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var configuration = new ConfigurationBuilder()
     .SetBasePath(Directory.GetCurrentDirectory())
     .AddJsonFile("appsettings.json")
     .Build();
            string connString = configuration.GetConnectionString("DefaultConnection");
            using (var conn = new NpgsqlConnection(connString))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();
                using (var command = new NpgsqlCommand("SELECT name_sports FROM politech.data", conn))
                using (var reader = command.ExecuteReader())
                {
                        using (StreamWriter writer = new StreamWriter($"{Environment.CurrentDirectory}\\name_sports.txt", false))
                        {
                    while (reader.Read())
                    {
                             writer.WriteLine(reader.GetString(0));
                    }
                        }
                }
                using (var command = new NpgsqlCommand("SELECT complexity_sports FROM politech.data", conn))
                using (var reader = command.ExecuteReader())
                {
                    using (StreamWriter writer = new StreamWriter($"{Environment.CurrentDirectory}\\complexity_sports.txt", false))
                    {
                        while (reader.Read())
                        {
                            writer.WriteLine(reader.GetInt32(0));
                        }
                    }
                }
                using (var command = new NpgsqlCommand("SELECT name_theme FROM politech.data", conn))
                using (var reader = command.ExecuteReader())
                {
                    using (StreamWriter writer = new StreamWriter($"{Environment.CurrentDirectory}\\name_theme.txt", false))
                    {
                        while (reader.Read())
                        {
                            writer.WriteLine(reader.GetString(0));
                        }
                    }
                }
                using (var command = new NpgsqlCommand("SELECT complexity_theme FROM politech.data", conn))
                using (var reader = command.ExecuteReader())
                {
                    using (StreamWriter writer = new StreamWriter($"{Environment.CurrentDirectory}\\complexity_theme.txt", false))
                    {
                        while (reader.Read())
                        {
                            writer.WriteLine(reader.GetInt32(0));
                        }
                    }
                }
                name_sports.ItemsSource=(File.ReadAllLines($"{Environment.CurrentDirectory}\\name_sports.txt",Encoding.Default));
                name_theme.ItemsSource= (File.ReadAllLines($"{Environment.CurrentDirectory}\\name_theme.txt", Encoding.Default));
            }
        }

        private void dropBorder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => DragMove();

        #region Логика алгоритма

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(ToInt32(complexity_sports.Text)+5+ToInt32(complexity_theme.Text)-(date_session.SelectedDate.Value-date_games.SelectedDate.Value).TotalDays<-10)
            {
                MessageBox.Show("");
            }
        }


        #endregion


    }
}