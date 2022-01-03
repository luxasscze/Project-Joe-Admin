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
    public partial class Staff : Form
    {
        
        public List<string> searchedStaff = new List<string>();
        public List<StaffClass> staffs = new List<StaffClass>();
        
        public Staff()
        {
            InitializeComponent();
            RefreshList();
            if(staffList.Items.Count == 0)
            {
                staffNameText.Text = String.Empty;
                departmentText.Text = String.Empty;
                contractText.Text = String.Empty;
                salaryText.Text = String.Empty;
                notesTextBox.Text = String.Empty;
                hiredText.Text = String.Empty;
            }
            else
            {
                staffList.SelectedIndex = 0;
            }
        }

        public void RefreshList()
        {
            staffList.Items.Clear();
            searchedStaff.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SELECT Surname FROM Staff ORDER BY Surname ASC",

                        Connection = connection
                    };
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        staffList.Items.Add(reader["Surname"].ToString());
                        searchedStaff.Add(reader["Surname"].ToString().ToLower());
                    }

                    connection.Close();

                }
                if(staffList.Items.Count == 0)
                {
                    staffNameText.Text = String.Empty;
                    departmentText.Text = String.Empty;
                    contractText.Text = String.Empty;
                    salaryText.Text = String.Empty;
                    notesTextBox.Text = String.Empty;
                    hiredText.Text = String.Empty;
                }
                else
                {
                    staffList.SelectedIndex = 0;
                }


            }
            catch (Exception)
            {
                this.Opacity = 0.8;
                DialogWindow alertBox = new DialogWindow("DATABASE CONNECTION ERROR", "PLEASE CHECK YOUR DATABSE SETTINGS...\nMAKE SURE YOU ARE CONNECTED TO THE INTERNET.", "alert");
                alertBox.ShowDialog();
                this.Opacity = 1;
            }
        }

        public void LoadStaff(string surname)
        {

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "SELECT * FROM Staff WHERE Surname='" + surname + "'",

                    Connection = connection
                };
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    staffNameText.Text = reader["FirstName"].ToString() + " " + reader["Surname"].ToString();
                    departmentText.Text = "Department: " + reader["Department"].ToString();
                    contractText.Text = "Contract: " + reader["Contract"].ToString();
                    salaryText.Text = "Salary: £" + reader["Salary"].ToString();
                    notesTextBox.Text = reader["Notes"].ToString();
                    hiredText.Text = "Hired: " + DateTime.Parse(reader["Hired"].ToString()).ToString("dd/MM/yyyy");
                }
                connection.Close();
            }

           


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string search = searchTextBox.Text;

            
                if (String.IsNullOrEmpty(search))
                {
                    staffList.Items.Clear();
                    staffList.Items.AddRange(searchedStaff.ToArray());
                }

                var items = (from a in searchedStaff where a.Contains(search) select a).ToArray<String>();

                staffList.Items.Clear();
                staffList.Items.AddRange(items);          
            
            
        }

        private void staffList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStaff(staffList.SelectedItem.ToString());
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (staffList.Items.Count == 0)
            {

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to permanently delete staff: " + staffNameText.Text + "?", "Delete Staff", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {



                    DeleteStaff(staffList.SelectedItem.ToString());

                    DialogWindow alertBox = new DialogWindow(staffNameText.Text + " - " + departmentText.Text, "USER HAS BEEN PERMANENTLY DELETED!", "warning");
                    alertBox.ShowDialog();

                    RefreshList();

                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void newStaffButton_Click(object sender, EventArgs e)
        {
            NewStaff NSForm = new NewStaff();
            NSForm.ShowDialog();
        }
    }
}
