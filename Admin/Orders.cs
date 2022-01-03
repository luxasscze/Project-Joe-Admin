using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static Admin.GlobalVar;

namespace Admin
{
    public partial class Orders : Form
    {
        public List<string> searchList = new List<string>();
        
        public Orders()
        {
            InitializeComponent();          
            howManyCombobox.SelectedIndex = 3;            
            ordersUpdateTimer.Start();
            LoadOrders(int.Parse(howManyCombobox.SelectedItem.ToString()));
            
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }

        private void firstNameText_Click(object sender, EventArgs e)
        {

        }

        private void ordersUpdateTimer_Tick(object sender, EventArgs e)
        {
            LoadOrders(int.Parse(howManyCombobox.SelectedItem.ToString()));
        }

        public void LoadOrders(int howMany)
        {
            
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "SELECT TOP " + howMany + " * FROM Orders ORDER BY Created DESC",

                    Connection = connection
                };



                SqlDataReader reader = cmd.ExecuteReader();
                _Orders.Clear();                               
                dataGridView1.Rows.Clear();
                inTheKitchenList.Rows.Clear();
                onTheWayList.Rows.Clear();
                finishedList.Rows.Clear();
                
                while (reader.Read())
                {



                    
                    
                        _Orders.Add(new Order
                        {
                            Created = DateTime.Parse(reader["Created"].ToString()),
                            Customer = reader["Customer"].ToString(),
                            DeliveryAddress = reader["DeliveryAddress"].ToString(),
                            DeliveryPostCode = reader["DeliveryPostCode"].ToString(),
                            DeliveryFee = decimal.Parse(reader["DeliveryFee"].ToString()),
                            IsActive = bool.Parse(reader["IsActive"].ToString()),
                            Items = reader["Items"].ToString(),
                            OrderId = int.Parse(reader["Id"].ToString()),
                            Status = reader["Status"].ToString(),
                            TotalAmount = decimal.Parse(reader["TotalAmount"].ToString())
                        });


                    if (reader["Status"].ToString() == "NewOrder")
                    {
                        dataGridView1.Rows.Add(reader["Customer"].ToString() + "\nOrder ID: " + reader["Id"].ToString() + "\nTotal: £" + reader["TotalAmount"].ToString() + "\n Created: " + reader["Created"].ToString() + "\n");
                    }
                    else if (reader["Status"].ToString() == "InTheKitchen")
                    {
                        inTheKitchenList.Rows.Add(reader["Customer"].ToString() + "\nOrder ID: " + reader["Id"].ToString() + "\nTotal: £" + reader["TotalAmount"].ToString() + "\n Created: " + reader["Created"].ToString() + "\n");
                    }
                    else if (reader["Status"].ToString() == "OnTheWay")
                    {
                        onTheWayList.Rows.Add(reader["Customer"].ToString() + "\nOrder ID: " + reader["Id"].ToString() + "\nTotal: £" + reader["TotalAmount"].ToString() + "\n Created: " + reader["Created"].ToString() + "\n");
                    }
                    else if (reader["Status"].ToString() == "Finished")
                    {
                        finishedList.Rows.Add(reader["Customer"].ToString() + "\nOrder ID: " + reader["Id"].ToString() + "\nTotal: £" + reader["TotalAmount"].ToString() + "\n Created: " + reader["Created"].ToString() + "\n");
                    }


                    statusText.Text = "LAST REFRESH: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                };

                


                connection.Close();

                

                

            }

            
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadOrders(int.Parse(howManyCombobox.SelectedItem.ToString()));
            
            Cursor = Cursors.Default;
        }

        private void howManyCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadOrders(int.Parse(howManyCombobox.SelectedItem.ToString()));

            Cursor = Cursors.Default;
        }

        private void orderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadOrders(int.Parse(howManyCombobox.SelectedItem.ToString()));

            Cursor = Cursors.Default;
        }

        private void OnDoubleClick(object sender, MouseEventArgs e)
        {

            Cursor = Cursors.WaitCursor;
            OrderDetail ODForm = new OrderDetail(dataGridView1.SelectedCells[0].Value.ToString());
            this.Opacity = 0.3;
            Cursor = Cursors.Default;
            ODForm.ShowDialog();
            this.Opacity = 1;
        }

        private void OnInTheKitchenDoubleClick(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            OrderDetail ODForm = new OrderDetail(inTheKitchenList.SelectedCells[0].Value.ToString());
            this.Opacity = 0.3;
            Cursor = Cursors.Default;
            ODForm.ShowDialog();
            this.Opacity = 1;
        }

        private void OnOnTheWayDoubleClick(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            OrderDetail ODForm = new OrderDetail(onTheWayList.SelectedCells[0].Value.ToString());
            this.Opacity = 0.3;
            Cursor = Cursors.Default;
            ODForm.ShowDialog();
            this.Opacity = 1;
        }

        private void OnFinishedDoubleClick(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            OrderDetail ODForm = new OrderDetail(finishedList.SelectedCells[0].Value.ToString());
            this.Opacity = 0.3;
            Cursor = Cursors.Default;
            ODForm.ShowDialog();
            this.Opacity = 1;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string search = searchTextBox.Text;

           
            
                if (String.IsNullOrEmpty(search))
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(_Orders.ToArray());
                }

                var items2 = (from a in searchList where a.Contains(search) select a).ToArray<String>();

                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(items2);
            
            
        }
    }
}
