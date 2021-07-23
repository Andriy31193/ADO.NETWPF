using Caffe.Models;
using Dapper;
using System;
using System.Data.SqlClient;
using System.Windows;
using System.Collections.Generic;
using System.Linq;

namespace ADO.NETWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static SqlConnection _sqlConnection;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            _sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\restoran.mdf;Integrated Security=True;Connect Timeout=30");
            _sqlConnection.Open();
            StatusLabel.Content = "Connected.";
            ConnectButton.IsEnabled = false;
            DisconnectButton.IsEnabled = true;
            LoadContentButton.IsEnabled = true;
        }
        private void DisconnectButton_Click(object sender, RoutedEventArgs e)
        {
            _sqlConnection.Close();
            _sqlConnection.Dispose();
            StatusLabel.Content = "Ready for connection.";
            ConnectButton.IsEnabled = true;
            DisconnectButton.IsEnabled = false;
            LoadContentButton.IsEnabled = false;
        }
        private void LoadContentButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                IEnumerable<User> waitDapper = _sqlConnection.Query<User>("select * from Waiters");
                foreach (var item in waitDapper)
                    dbContent.Items.Add(new { Id = item.Id, Name = item.Name });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (_sqlConnection != null)
                    DisconnectButton_Click(null, null);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (var dbCtx = new CaffeDbContext())
            {
                var waiters = dbCtx.Waiters.ToArray();
                dbContent.ItemsSource = waiters;
            }
        }
    }
}
