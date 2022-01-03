using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Admin.SQL;

namespace Admin
{
    public partial class NewCategory : Form
    {
        public string type { get; set; }
        
        public NewCategory()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NewCategory_Load(object sender, EventArgs e)
        {
            type = "Food";
            foodButton.BackColor = Color.White;
            foodButton.ForeColor = Color.Black;

            drinkButton.BackColor = Color.Transparent;
            drinkButton.ForeColor = Color.Gray;
        }

        private void foodButton_Click(object sender, EventArgs e)
        {
            type = "Food";
            foodButton.BackColor = Color.White;
            foodButton.ForeColor = Color.Black;

            drinkButton.BackColor = Color.Transparent;
            drinkButton.ForeColor = Color.Gray;
        }

        private void drinkButton_Click(object sender, EventArgs e)
        {
            type = "Drink";
            foodButton.BackColor = Color.Transparent;
            foodButton.ForeColor = Color.Gray;

            drinkButton.BackColor = Color.White;
            drinkButton.ForeColor = Color.Black;
        }

        private void categoryAddButton_Click(object sender, EventArgs e)
        {
            AddCategory(categoryNameTextBox.Text, type);
            this.Close();
        }
    }
}
