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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Npgsql;

namespace TheFuture.Pages
{
    /// <summary>
    /// Interaction logic for Networth.xaml
    /// </summary>
    public partial class Networth : Page
    {
        private string connstring = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", "localhost", 5432, "postgres", "kucing123", "thefuturedb");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private int rowIndex = -1;

        public Networth()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            Select();
        }

        private void Select()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM st_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dvData.ItemsSource = null;
                dvData.ItemsSource = dt.DefaultView;
            }
            catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: "+ex.Message);
            }
        }

        private void dvData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*object item = dvData.SelectedItem as object;
            if(item != null)
            {
                rowIndex= (int)item;
                name.Text = (dvData.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                value.Text = (dvData.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                string txt = (dvData.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

                MessageBox.Show(txt);
            }*/
            //string id = Convert.ToString(item.Id);

            /*DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if(row_selected != null)
            {
                name.Text = row_selected["Name"].ToString();
                value.Text = row_selected["Value"].ToString();

            }*/


        }

        private void btn_insert(object sender, RoutedEventArgs e)
        {
            /*rowIndex = -1;
            name.IsEnabled = value.IsEnabled = true;
            name.Text = value.Text = null;
            Select();*/
        }

        private void btn_update(object sender, RoutedEventArgs e)
        {
            /*if(rowIndex < 0)
            {
                MessageBox.Show("Please choose any row to update");
                return;
            }
            name.IsEnabled = value.IsEnabled = true;*/
        }

        private void btn_delete(object sender, RoutedEventArgs e)
        {
            /*if (rowIndex < 0)
            {
                MessageBox.Show("Please choose any row to delete");
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from st_delete(:_nwid)";
                cmd = new NpgsqlCommand(sql, conn);
                object item = dvData.SelectedItem;
                cmd.Parameters.AddWithValue("_nwid", int.Parse((dvData.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Delete data successfully");
                    rowIndex = -1;
                    Select();
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show("Deleted fail. Error: "+ex.Message);
            }*/
        }

        private void btn_save(object sender, RoutedEventArgs e)
        {
            /*int result = 0;
            if(rowIndex < 0)
            {
                try
                {
                    conn.Open();
                    sql = @"select * from st_insert(:_names,:_values)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_names", name.Text);
                    cmd.Parameters.AddWithValue("_values", name.Text);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Inserted successfully");
                        Select();
                    }
                    else
                    {
                        MessageBox.Show("Inserted failed");
                    }
                    
                }
                catch(Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Inserted fail. Error: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    conn.Open();
                    sql = @"select * from st_update(:_nwid,:_names,:_values)";
                    cmd = new NpgsqlCommand(sql, conn);
                    object item = dvData.SelectedItem;
                    cmd.Parameters.AddWithValue("_nwid", int.Parse((dvData.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text));
                    cmd.Parameters.AddWithValue("_names", name.Text);
                    cmd.Parameters.AddWithValue("_values", name.Text);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if(result == 1)
                    {
                        MessageBox.Show("Updated successfully");
                        Select();
                    }
                    else
                    {
                        MessageBox.Show("Updated failed");
                    }
                    
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Updated fail. Error: " + ex.Message);
                }
                
            }
            result = 0;
            name.Text = value.Text = null;
            name.IsEnabled = value.IsEnabled = false;*/
        }

        private void btn_add(object sender, RoutedEventArgs e)
        {
            Add ad = new Add();
            ad.Show();
            //MessageBox.Show("Hello MessageBox", "Confirmation");
        }

    }
}
