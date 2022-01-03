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
using static Admin.SQL;
using FluentFTP;

namespace Admin
{
    public partial class ProductManagement : Form
    {

        List<ProductFood> foodList = new List<ProductFood>();

        public List<string> itemsFood = new List<string>();
        public List<string> itemsDrink = new List<string>();

        public string allergens;

        public string[] separatedAllergens;

        public string ProductType { get; set; }

        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }



        public ProductManagement()
        {
            InitializeComponent();
            foodButton.BackColor = Color.White;
            foodButton.ForeColor = Color.Black;
            drinkButton.BackColor = Color.Transparent;
            drinkButton.ForeColor = Color.Gray;
            statusText.Visible = false;
            statusInfoIcon.Visible = false;
            ProductType = "Food";
            
            RefreshFoodList();
            
            if(productList.Items.Count == 0)
            {

            }
            else
            {
                productList.SelectedIndex = 0;
                LoadProduct(productList.SelectedItem.ToString());
            }
            
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        public void LoadProduct(string name)
        {

            statusText.Visible = false;
            statusInfoIcon.Visible = false;
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "SELECT * FROM Products WHERE Name='" + name + "'",

                    Connection = connection
                };
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    productNameText.Text = reader["Name"].ToString();
                    categoryText.Text = reader["Category"].ToString();
                    priceTextBox.Text = reader["SellPrice"].ToString();
                    buyPriceTextBox.Text = reader["BuyPrice"].ToString();
                    shortDescriptionTextBox.Text = reader["ShortDescription"].ToString();
                    longDescriptionTextBox.Text = reader["LongDescription"].ToString();
                    productImage.LoadAsync(_ImageUriPath + reader["Image"].ToString()); 
                    remarksTextBox.Text = reader["Remarks"].ToString();
                    soldText.Text = reader["AmountSold"].ToString();
                    lastSoldText.Text = reader["LastSold"].ToString();
                    availableFrom.Checked = true;
                    availableTo.Checked = true;

                    availableFrom.Value = DateTime.Parse(reader["TimeFrom"].ToString());
                    availableTo.Value = DateTime.Parse(reader["TimeTo"].ToString());
                    allergens = reader["Allergens"].ToString();
                    IsVegetarian = bool.Parse(reader["IsVegetarian"].ToString());
                    IsVegan = bool.Parse(reader["IsVegan"].ToString());
                    
                    
                    if(lastSoldText.Text == String.Empty)
                    {
                        lastSoldText.Text = "NOT SOLD YET!";
                        lastSoldText.ForeColor = Color.IndianRed;
                    }
                    if(bool.Parse(reader["IsAvailable"].ToString()))
                    {
                        availableYesButton.BackColor = Color.White;
                        availableYesButton.ForeColor = Color.Black;

                        availableNoButton.BackColor = Color.Transparent;
                        availableNoButton.ForeColor = Color.Gray;
                    }
                    else
                    {
                        availableYesButton.BackColor = Color.Transparent;
                        availableYesButton.ForeColor = Color.Gray;

                        availableNoButton.BackColor = Color.White;
                        availableNoButton.ForeColor = Color.Black;
                    }

                    if(IsVegetarian)
                    {
                        vegetarianYesButton.BackColor = Color.White;
                        vegetarianYesButton.ForeColor = Color.Black;
                        vegetarianNoButton.BackColor = Color.Transparent;
                        vegetarianNoButton.ForeColor = Color.Gray;

                    }
                    else
                    {
                        vegetarianYesButton.BackColor = Color.Transparent;
                        vegetarianYesButton.ForeColor = Color.Gray;
                        vegetarianNoButton.BackColor = Color.White;
                        vegetarianNoButton.ForeColor = Color.Black;
                    }

                    if(IsVegan)
                    {
                        veganYesButton.BackColor = Color.White;
                        veganYesButton.ForeColor = Color.Black;
                        veganNoButton.BackColor = Color.Transparent;
                        veganNoButton.ForeColor = Color.Gray;
                    }
                    else
                    {
                        veganYesButton.BackColor = Color.Transparent;
                        veganYesButton.ForeColor = Color.Gray;
                        veganNoButton.BackColor = Color.White;
                        veganNoButton.ForeColor = Color.Black;
                    }
                    
                }
                connection.Close();

                separatedAllergens = allergens.Split(';');
                allergensList.Items.Clear();

                if (separatedAllergens.Length != 0)
                {
                    for (int i = 0; i < separatedAllergens.Length; i++)
                    {
                        allergensList.Items.Add(separatedAllergens[i]);
                    }
                }
                else
                {
                   
                }
            }


           
            

        }

        public void RefreshFoodList()
        {
            foodList.Clear();
            productList.Items.Clear();
            itemsFood.Clear();
            
            statusText.Visible = false;
            statusInfoIcon.Visible = false;

            try
            {
                Cursor = Cursors.WaitCursor;
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SELECT Name FROM Products WHERE Type='Food' ORDER BY Category, Name ASC",

                        Connection = connection
                    };
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        productList.Items.Add(reader["Name"].ToString());
                        itemsFood.Add(reader["Name"].ToString().ToLower());
                    }

                    if(productList.Items.Count == 0)
                    {

                    }
                    else
                    {
                        productList.SelectedIndex = 0;
                    }

                    connection.Close();

                }

                
            }
            catch (Exception)
            {
                DialogWindow alertBox = new DialogWindow("DATABASE CONNECTION ERROR", "PLEASE CHECK YOUR DATABASE SETTINGS...\nMAKE SURE YOU ARE CONNECTED TO THE INTERNET.", "alert");
                alertBox.ShowDialog();

            }
            finally
            {
                
                Cursor = Cursors.Default;
            }
        }

        public void RefreshDrinkList()
        {
            
            productList.Items.Clear();
            itemsDrink.Clear();
            statusText.Visible = false;
            statusInfoIcon.Visible = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SELECT Name FROM Products WHERE Type='Drink' ORDER BY Category, Name ASC",

                        Connection = connection
                    };
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        productList.Items.Add(reader["Name"].ToString());
                        itemsDrink.Add(reader["Name"].ToString().ToLower());
                    }

                    connection.Close();

                    if (productList.Items.Count == 0)
                    {

                    }
                    else
                    {
                        productList.SelectedIndex = 0;
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString());
            }
        }

        private void foodButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            foodButton.BackColor = Color.White;
            foodButton.ForeColor = Color.Black;
            drinkButton.BackColor = Color.Transparent;
            drinkButton.ForeColor = Color.Gray;
            searchTextBox.Text = String.Empty;
            ProductType = "Food";
            RefreshFoodList();
            Cursor = Cursors.Default;
        }

        private void drinkButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            foodButton.BackColor = Color.Transparent;
            foodButton.ForeColor = Color.Gray;
            drinkButton.BackColor = Color.White;
            drinkButton.ForeColor = Color.Black;
            searchTextBox.Text = String.Empty;
            ProductType = "Drink";
            RefreshDrinkList();
            Cursor = Cursors.Default;
        }

        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            productImage.Visible = false;
            productImage.Tag = "Loading...";
            LoadProduct(productList.SelectedItem.ToString());
            //productImage.Visible = true;
            Cursor = Cursors.Default;
        }

        private void availableYesButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            UpdateProduct(productNameText.Text, "IsAvailable", "True");

            availableYesButton.BackColor = Color.White;
            availableYesButton.ForeColor = Color.Black;

            availableNoButton.BackColor = Color.Transparent;
            availableNoButton.ForeColor = Color.Gray;
            statusText.Visible = true;
            statusInfoIcon.Visible = true;
            statusText.Text = productNameText.Text.ToUpper() + " IS AVAILABLE NOW!";
            Cursor = Cursors.Default;

        }

        private void availableNoButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            UpdateProduct(productNameText.Text, "IsAvailable", "False");

            availableYesButton.BackColor = Color.Transparent;
            availableYesButton.ForeColor = Color.Gray;

            availableNoButton.BackColor = Color.White;
            availableNoButton.ForeColor = Color.Black;
            statusText.Visible = true;
            statusInfoIcon.Visible = true;
            statusText.Text = productNameText.Text.ToUpper() + " IS NOT AVAILABLE!";
            Cursor = Cursors.Default;
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            
        }

        private void newProductButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            NewProduct NPForm = new NewProduct();
            NPForm.ShowDialog();
            Cursor = Cursors.Default;

        }

        private void OnSearchTextChanged(object sender, EventArgs e)
        {
            string search = searchTextBox.Text;

            if (ProductType == "Food")
            {
                if (String.IsNullOrEmpty(search))
                {
                    productList.Items.Clear();
                    productList.Items.AddRange(itemsFood.ToArray());
                }

                var items2 = (from a in itemsFood where a.Contains(search) select a).ToArray<String>();

                productList.Items.Clear();
                productList.Items.AddRange(items2);
            }
            else if(ProductType == "Drink")
            {
                if (String.IsNullOrEmpty(search))
                {
                    productList.Items.Clear();
                    productList.Items.AddRange(itemsDrink.ToArray());
                }

                var items2 = (from a in itemsDrink where a.Contains(search) select a).ToArray<String>();

                productList.Items.Clear();
                productList.Items.AddRange(items2);
            }
        }

        private void availableFrom_ValueChanged(object sender, EventArgs e)
        {
            
            UpdateProduct(productNameText.Text, "TimeFrom", availableFrom.Value.ToString("HH:mm"));
            statusText.Visible = true;
            statusInfoIcon.Visible = true;
            statusText.Text = productNameText.Text.ToUpper() + " IS NOW AVAILABLE FROM " + availableFrom.Value.ToString("HH:mm");
        }

        private void availableTo_ValueChanged(object sender, EventArgs e)
        {
            
            UpdateProduct(productNameText.Text, "TimeTo", availableTo.Value.ToString("HH:mm"));
            statusText.Visible = true;
            statusInfoIcon.Visible = true;
            statusText.Text = productNameText.Text.ToUpper() + " IS NOW AVAILABLE TO " + availableTo.Value.ToString("HH:mm");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnSellPriceLeave(object sender, EventArgs e)
        {
            UpdateProduct(productNameText.Text, "SellPrice", priceTextBox.Text);
            statusText.Visible = true;
            statusInfoIcon.Visible = true;
            statusText.Text = productNameText.Text.ToUpper() + " HAS NOW NEW SELL PRICE: £" + priceTextBox.Text;
        }

        private void OnBuyPriceLeave(object sender, EventArgs e)
        {
            UpdateProduct(productNameText.Text, "BuyPrice", buyPriceTextBox.Text);
            statusText.Visible = true;
            statusInfoIcon.Visible = true;
            statusText.Text = productNameText.Text.ToUpper() + " HAS NOW NEW BUY PRICE: £" + buyPriceTextBox.Text;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DeleteProduct(productNameText.Text);            
            
            searchTextBox.Text = String.Empty;
            if (ProductType == "Food")
            {
                foodButton.BackColor = Color.White;
                foodButton.ForeColor = Color.Black;
                drinkButton.BackColor = Color.Transparent;
                drinkButton.ForeColor = Color.Gray;
                ProductType = "Food";
                RefreshFoodList();
            }
            else
            {
                foodButton.BackColor = Color.Transparent;
                foodButton.ForeColor = Color.Gray;
                drinkButton.BackColor = Color.White;
                drinkButton.ForeColor = Color.Black;
                RefreshDrinkList();
            }
            Cursor = Cursors.Default;
        }

        private void OnProductManagementActivated(object sender, EventArgs e)
        {

            Cursor = Cursors.WaitCursor;
            foodButton.BackColor = Color.White;
            foodButton.ForeColor = Color.Black;
            drinkButton.BackColor = Color.Transparent;
            drinkButton.ForeColor = Color.Gray;
            searchTextBox.Text = String.Empty;
            ProductType = "Food";
            RefreshFoodList();
            Cursor = Cursors.Default;
        }

        private void vegetarianYesButton_Click(object sender, EventArgs e)
        {
            IsVegetarian = true;
            UpdateProduct(productNameText.Text, "IsVegetarian", "True");

            vegetarianYesButton.BackColor = Color.White;
            vegetarianYesButton.ForeColor = Color.Black;
            vegetarianNoButton.BackColor = Color.Transparent;
            vegetarianNoButton.ForeColor = Color.Gray;
            statusText.Visible = true;
            statusInfoIcon.Visible = true;
            statusText.Text = productNameText.Text.ToUpper() + " IS VEGETARIAN!";
        }

        private void vegetarianNoButton_Click(object sender, EventArgs e)
        {
            IsVegetarian = false;
            UpdateProduct(productNameText.Text, "IsVegetarian", "False");

            vegetarianYesButton.BackColor = Color.Transparent;
            vegetarianYesButton.ForeColor = Color.Gray;
            vegetarianNoButton.BackColor = Color.White;
            vegetarianNoButton.ForeColor = Color.Black;
            statusText.Visible = true;
            statusInfoIcon.Visible = true;
            statusText.Text = productNameText.Text.ToUpper() + " IS NOT VEGETARIAN!";
        }

        private void veganYesButton_Click(object sender, EventArgs e)
        {
            IsVegan = true;
            UpdateProduct(productNameText.Text, "IsVegan", "True");

            veganYesButton.BackColor = Color.White;
            veganYesButton.ForeColor = Color.Black;
            veganNoButton.BackColor = Color.Transparent;
            veganNoButton.ForeColor = Color.Gray;
            statusText.Visible = true;
            statusInfoIcon.Visible = true;
            statusText.Text = productNameText.Text.ToUpper() + " IS VEGAN!";
        }

        private void veganNoButton_Click(object sender, EventArgs e)
        {
            IsVegan = false;
            UpdateProduct(productNameText.Text, "IsVegan", "False");

            veganYesButton.BackColor = Color.Transparent;
            veganYesButton.ForeColor = Color.Gray;
            veganNoButton.BackColor = Color.White;
            veganNoButton.ForeColor = Color.Black;
            statusText.Visible = true;
            statusInfoIcon.Visible = true;
            statusText.Text = productNameText.Text.ToUpper() + " IS NOT VEGAN!";
        }

        private void categoryAddButton_Click(object sender, EventArgs e)
        {
            EditAllergens EAForm = new EditAllergens(productNameText.Text, separatedAllergens);
            EAForm.ShowDialog();
           
        }

        private void shortDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            statusText.Visible = true;
            statusText.Text = "Short description has been changed".ToUpper();
        }

        private void OnShortDescriptionLeave(object sender, EventArgs e)
        {
            UpdateProduct(productNameText.Text, "ShortDescription", shortDescriptionTextBox.Text);
        }

        private void longDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            statusText.Visible = true;
            statusText.Text = "Long description has been changed".ToUpper();
        }

        private void OnLongDescriptionLeave(object sender, EventArgs e)
        {
            UpdateProduct(productNameText.Text, "LongDescription", longDescriptionTextBox.Text);
        }

        private void remarksTextBox_TextChanged(object sender, EventArgs e)
        {
            statusText.Visible = true;
            statusText.Text = "Remarks has been changed".ToUpper();
        }

        private void OnRemarksLeave(object sender, EventArgs e)
        {
            UpdateProduct(productNameText.Text, "Remarks", remarksTextBox.Text);
        }

        private void OnProductImageLoadComplete(object sender, AsyncCompletedEventArgs e)
        {
            productImage.Visible = true;
        }
    }
}
