using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using Microsoft.Data.SqlClient;

namespace WpfResponsive
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string connStr = "Server=(localdb)\\mssqllocaldb;Database=Northwind;Trusted_Connection=True;MultipleActiveResultSets=true";
        private const string sql = "WAITFOR DELAY '00:00:05'; SELECT EmployeeId, FirstName, LastName FROM Employees";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnEmplSynchBtnClick(object sender, RoutedEventArgs e)
        { 
            Stopwatch sw = Stopwatch.StartNew();
            using (SqlConnection conn = new SqlConnection(connStr))
            { 
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string empl = string.Format("{0}: {1} {2}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                    EmpListBox.Items.Add(empl);
                }
                reader.Close();
                conn.Close();
            }
            EmpListBox.Items.Add($"Sync : {sw.ElapsedMilliseconds:N0}ms");
        }

        private async void OnEmplAsynchBtnClick(object sender, RoutedEventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = await cmd.ExecuteReaderAsync();
                while (reader.Read())
                {
                    string empl = string.Format("{0}: {1} {2}", await reader.GetFieldValueAsync<int>(0), 
                                                                await reader.GetFieldValueAsync<string>(1), 
                                                                await reader.GetFieldValueAsync<string>(2));
                    EmpListBox.Items.Add(empl);
                }
                await reader.CloseAsync();
                await conn.CloseAsync();
            }
            EmpListBox.Items.Add($"Async : {sw.ElapsedMilliseconds:N0}ms");
        }

        //elustaring use of "yield". It is for returning each element in a time when using "await"
        async static IAsyncEnumerable<int> GetNumberAsync()
        {
            Random random = new Random();
            await Task.Delay(random.Next(1500, 300));
            yield return random.Next(0, 1001);

            await Task.Delay(random.Next(1500, 300));
            yield return random.Next(0, 1001);

            await Task.Delay(random.Next(1500, 300));
            yield return random.Next(0, 1001);

        }

    }
}
