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

namespace Admin
{
    public partial class Categories : Form
    {
        public string CategoryName { get; set; }
        public string CategoryType { get; set; }
        
        public Categories()
        {
            InitializeComponent();
        }

        public void LoadCategory(string name)
        {

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                Cursor = Cursors.WaitCursor;
                connection.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "SELECT * FROM Categories WHERE Name='" + name + "'",

                    Connection = connection
                };
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    CategoryName = reader["Name"].ToString();
                    CategoryType = reader["Type"].ToString();

                }
                connection.Close();
                Cursor = Cursors.Default;
                
            }





        }

        public void RefreshList()
        {
            allergensList.Items.Clear();

            try
            {
                Cursor = Cursors.WaitCursor;
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SELECT Name FROM Categories ORDER BY Name ASC",

                        Connection = connection
                    };
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        allergensList.Items.Add(reader["Name"].ToString());
                        
                    }

                    if (allergensList.Items.Count == 0)
                    {

                    }
                    else
                    {
                        allergensList.SelectedIndex = 0;
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewCategory NCForm = new NewCategory();
            NCForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*DialogResult dialogResult = MessageBox.Show("Are you sure to delete category " + CategoryName + "?", "Delete Category", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {*/

                Cursor = Cursors.WaitCursor;
                DeleteCategory(CategoryName);
                RefreshList();
                Cursor = Cursors.Default;

            //}
            //else if (dialogResult == DialogResult.No)
            //{

            //}

            
        }

        private void OnCategoriesActivated(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            RefreshList();
            Cursor = Cursors.Default;
        }

        private void allergensList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadCategory(allergensList.SelectedItem.ToString());
            typeText.Text = CategoryType.ToUpper();
            Cursor = Cursors.Default;
        }

        private void Categories_Load(object sender, EventArgs e)
        {

        }
    }
}
