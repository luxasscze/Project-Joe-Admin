using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static Admin.GlobalVar;
using static Admin.SQL;

namespace Admin
{
    public partial class OrderDetail : Form
    {
        public string[] Items { get; set; }
        public int OrderId { get; set; }
        public bool IsFinished { get; set; }

        
        public OrderDetail(string order)
        {
            InitializeComponent();
            
            string[] orderData = order.Replace("\n", ";").Replace("Order ID: ", "").Replace("Total: £", "").Replace("Created: ", "").Split(';');
            OrderId = int.Parse(orderData[1]);
            LoadCustomer(orderData[0]);
            LoadOrder(orderData[1]);
            captionText.Text = "ORDER #" + orderData[1];
            orderCreatedText.Text = "Created: " + orderData[3];
            if(IsFinished)
            {
                newOrderButton.Visible = false;
                inTheKitchenButton.Visible = false;
                onTheWayButton.Visible = false;
                finishedButton.Visible = false;
            }
            
            for(int i = 0; i < Items.Length / 3; i++)
            {

                productList.Rows.Add(Items[i * 3], Items[i * 3 + 1], Items[i * 3 + 2], (decimal.Parse(Items[i * 3 + 1]) * decimal.Parse(Items[i * 3 + 2])));
                
            }
        }

        public void LoadCustomer(string email)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "SELECT * FROM Customers WHERE Email='" + email + "'",

                    Connection = connection
                };
                SqlDataReader reader = cmd.ExecuteReader();             
                
                while (reader.Read())
                {

                    customerNameText.Text = reader["FirstName"].ToString() + " " + reader["Surname"].ToString();
                    customerDetailText.Text = "Tier: " + reader["Tier"].ToString() + " | Orders: " + reader["Orders"].ToString() + " | Spending: £" + reader["TotalSpending"].ToString();
                    customerEmailText.Text = "Email: " + reader["Email"].ToString();
                    customerPhoneText.Text = "Phone: " + reader["Phone"].ToString();
                    customerAddressText.Text = "Address: " + reader["Address1"].ToString() + ", " + reader["Address2"].ToString() + ", " + reader["Address3"].ToString();
                    customerPostCodeText.Text = "Post code: " + reader["PostCode"].ToString();

                };

                connection.Close();
                
            }
        }

        public void LoadOrder(string id)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "SELECT * FROM Orders WHERE Id='" + id + "'",

                    Connection = connection
                };
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    orderStatusText.Text = reader["Status"].ToString();
                    orderDeliveryFeeText.Text = "Delivery: £" + reader["DeliveryFee"].ToString();
                    orderJustTotalText.Text = "Order: £" + reader["TotalAmount"].ToString();
                    orderTotalText.Text = "TOTAL: £" + (decimal.Parse(reader["TotalAmount"].ToString()) + decimal.Parse(reader["DeliveryFee"].ToString()));
                    Items = reader["Items"].ToString().Split(';');
                    IsFinished = !bool.Parse(reader["IsActive"].ToString());
                };
                 
                connection.Close();

            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {
            
        }

        private void onTheWayList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus(OrderId, "NewOrder");
        }

        private void inTheKitchenButton_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus(OrderId, "InTheKitchen");
        }

        private void onTheWayButton_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus(OrderId, "OnTheWay");
        }

        private void finishedButton_Click(object sender, EventArgs e)
        {
            IsFinished = true;
            UpdateOrderStatus(OrderId, "Finished");
            //UpdateOrderIsActive(OrderId, "False");
            UpdateCustomerOrdersAmount(_Orders[0].Customer);
            UpdateCustomer(_Orders[0].Customer, "HasActiveOrder", "False");
            UpdateCustomerTotalSpending(_Orders[0].Customer, _Orders[0].TotalAmount.ToString());

            newOrderButton.Enabled = false;
            inTheKitchenButton.Enabled = false;
            onTheWayButton.Enabled = false;
            finishedButton.Enabled = false;
        }
    }
}
