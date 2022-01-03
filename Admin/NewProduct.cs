using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static Admin.SQL;
using static Admin.GlobalVar;
using System.Data.SqlClient;
using FluentFTP;

namespace Admin
{
    public partial class NewProduct : Form
    {


        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool IsAvailable { get; set; }

        public string ProductCategory { get; set; }
        public string ProductType { get; set; }



        public List<CategoriesClass> Categories = new List<CategoriesClass>();


        

        
        public NewProduct()
        {
            InitializeComponent();
            productCaption.Text = String.Empty;
            InitializeColors();
            LoadCategories();            
            IsVegetarian = false;
            IsVegan = false;
            IsAvailable = true;
            categoryTypeImage.Image = null;

        }

        public void LoadCategories()
        {

            Categories.Clear();
            categoryComboBox.Items.Clear();
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "SELECT * FROM Categories",

                    Connection = connection
                };
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    Categories.Add(new CategoriesClass { CategoryName = reader["Name"].ToString(), CategoryType = reader["Type"].ToString() });

                }
                connection.Close();


            }

            for (int i = 0; i < Categories.Count; i++)
            {
                categoryComboBox.Items.Add(Categories[i].CategoryName.ToString());
            }



        }

        public void InitializeColors()
        {
            vegetarianYesButton.BackColor = Color.Transparent;
            vegetarianYesButton.ForeColor = Color.Gray;

            veganYesButton.BackColor = Color.Transparent;
            veganYesButton.ForeColor = Color.Gray;

            vegetarianNoButton.BackColor = Color.White;
            vegetarianNoButton.ForeColor = Color.Black;

            veganNoButton.BackColor = Color.White;
            veganNoButton.ForeColor = Color.Black;

            availabilityYesButton.BackColor = Color.White;
            availabilityYesButton.ForeColor = Color.Black;

            availabilityNoButton.BackColor = Color.Transparent;
            availabilityNoButton.ForeColor = Color.Gray;


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void productImage_Click(object sender, EventArgs e)
        {
            if (imageOpenDialog.ShowDialog() == DialogResult.OK)
            {
                productImage.Image = new Bitmap(imageOpenDialog.FileName);
                
            }
        }

        private void productNameTextBox_TextChanged(object sender, EventArgs e)
        {
            productCaption.Text = productNameTextBox.Text.Replace("'", "´").ToUpper();
        }

        private void vegetarianYesButton_Click(object sender, EventArgs e)
        {
            IsVegetarian = true;
            vegetarianYesButton.BackColor = Color.White;
            vegetarianYesButton.ForeColor = Color.Black;

            vegetarianNoButton.BackColor = Color.Transparent;
            vegetarianNoButton.ForeColor = Color.Gray;
        }

        private void vegetarianNoButton_Click(object sender, EventArgs e)
        {
            IsVegetarian = false;
            vegetarianYesButton.BackColor = Color.Transparent;
            vegetarianYesButton.ForeColor = Color.Gray;

            vegetarianNoButton.BackColor = Color.White;
            vegetarianNoButton.ForeColor = Color.Black;
        }

        private void veganYesButton_Click(object sender, EventArgs e)
        {
            IsVegan = true;
            veganYesButton.BackColor = Color.White;
            veganYesButton.ForeColor = Color.Black;

            veganNoButton.BackColor = Color.Transparent;
            veganNoButton.ForeColor = Color.Gray;
        }

        private void veganNoButton_Click(object sender, EventArgs e)
        {
            IsVegan = false;
            veganYesButton.BackColor = Color.Transparent;
            veganYesButton.ForeColor = Color.Gray;

            veganNoButton.BackColor = Color.White;
            veganNoButton.ForeColor = Color.Black;
        }

        public string GetSelectedAllergens()
        {
            List<String> allergens = new List<string>();
            string output = String.Empty;

            for (int i = 0; i < allergensList.CheckedItems.Count; i++)
            {
                allergens.Add(allergensList.CheckedItems[i].ToString());
                output = output + allergens[i].ToString() + ";";
            }

            return output;
        }

        private void productAddButton_Click(object sender, EventArgs e)
        {
            if (productNameTextBox.Text == String.Empty || categoryComboBox.SelectedIndex == -1 || shortDescriptionTextBox.Text == String.Empty || longDescriptionTextBox.Text == String.Empty
                || imageOpenDialog == null || sellPriceTextBox.Text == String.Empty || buyPriceTextBox.Text == String.Empty)
            {
                DialogWindow DWin = new DialogWindow("I WOULD LIKE TO SAVE IT, BUT...", "SOME PRODUCT INFORMATION IS MISSING.\nPLEASE CHECK YOUR INPUTS.", "alert");
                DWin.ShowDialog();
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                using (FtpClient ftp = new FtpClient(_FTPServer, _FTPUsername, _FTPPassword))
                {
                    ftp.Connect();
                    ftp.UploadFile(imageOpenDialog.FileName, _FTPLocation + imageOpenDialog.SafeFileName, FtpRemoteExists.Skip); 
                    ftp.Disconnect();
                }
                AddProduct(productNameTextBox.Text.Replace("'", "´"), ProductCategory, shortDescriptionTextBox.Text.Replace("'", "´"), longDescriptionTextBox.Text.Replace("'", "´"), imageOpenDialog.SafeFileName.ToString(),
                            decimal.Parse(sellPriceTextBox.Text), decimal.Parse(buyPriceTextBox.Text), GetSelectedAllergens(), IsVegetarian, IsVegan, ProductType,
                            remarksTextBox.Text, availableFrom.Value.ToString("HH:mm"), availableTo.Value.ToString("HH:mm"));
                Cursor = Cursors.Default;

                DialogWindow DWin = new DialogWindow(productNameTextBox.Text.ToUpper() + " ADDED", "PRODUCT HAS BEEN SUCCESSFULLY ADDED.", "info");
                DWin.ShowDialog();

                this.Close();
            }

        }

        private void categoryAddButton_Click(object sender, EventArgs e)
        {
            Categories CForm = new Categories();
            CForm.ShowDialog();
        }

        private void OnNewProductActivated(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           if(Categories[categoryComboBox.SelectedIndex].CategoryType == "Food")
           {
                categoryTypeImage.Image = Properties.Resources.foodicon;
                ProductType = "Food";
           }
           else if(Categories[categoryComboBox.SelectedIndex].CategoryType == "Drink")
           {
                categoryTypeImage.Image = Properties.Resources.drink_2_icon;
                ProductType = "Drink";
           }

            ProductCategory = categoryComboBox.SelectedItem.ToString();
            
        }

        private void NewProduct_Load(object sender, EventArgs e)
        {

        }

        private void availabilityYesButton_Click(object sender, EventArgs e)
        {
            IsAvailable = true;
            availabilityYesButton.BackColor = Color.White;
            availabilityYesButton.ForeColor = Color.Black;

            availabilityNoButton.BackColor = Color.Transparent;
            availabilityNoButton.ForeColor = Color.Gray;
        }

        private void availabilityNoButton_Click(object sender, EventArgs e)
        {
            IsAvailable = false;
            availabilityYesButton.BackColor = Color.Transparent;
            availabilityYesButton.ForeColor = Color.Gray;

            availabilityNoButton.BackColor = Color.White;
            availabilityNoButton.ForeColor = Color.Black;
        }
    }
}
