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
    public partial class EditAllergens : Form
    {
        public EditAllergens(string product, string[] currentAllergens)
        {
            InitializeComponent();
            captionText.Text = product;
            if(currentAllergens.Contains("CELERY"))
            {
                allergensList.SetItemChecked(0, true);
            }
            if (currentAllergens.Contains("CEREALS CONTAINING GLUTEN"))
            {
                allergensList.SetItemChecked(1, true);
            }
            if (currentAllergens.Contains("CRUSTACEANS"))
            {
                allergensList.SetItemChecked(2, true);
            }
            if (currentAllergens.Contains("EGGS"))
            {
                allergensList.SetItemChecked(3, true);
            }
            if (currentAllergens.Contains("FISH"))
            {
                allergensList.SetItemChecked(4, true);
            }
            if (currentAllergens.Contains("LUPIN"))
            {
                allergensList.SetItemChecked(5, true);
            }
            if (currentAllergens.Contains("MILK"))
            {
                allergensList.SetItemChecked(6, true);
            }
            if (currentAllergens.Contains("MOLLUSCS"))
            {
                allergensList.SetItemChecked(7, true);
            }
            if (currentAllergens.Contains("MUSTARD"))
            {
                allergensList.SetItemChecked(8, true);
            }
            if (currentAllergens.Contains("PEANUTS"))
            {
                allergensList.SetItemChecked(9, true);
            }
            if (currentAllergens.Contains("SESAME"))
            {
                allergensList.SetItemChecked(10, true);
            }
            if (currentAllergens.Contains("SOYBEANS"))
            {
                allergensList.SetItemChecked(11, true);
            }
            if (currentAllergens.Contains("SULPHUR DIOXIDE"))
            {
                allergensList.SetItemChecked(12, true);
            }
            if (currentAllergens.Contains("SULPHITES"))
            {
                allergensList.SetItemChecked(13, true);
            }
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            UpdateProduct(captionText.Text, "Allergens", GetSelectedAllergens());
            this.Close();
        }

        private void EditAllergens_Load(object sender, EventArgs e)
        {

        }
    }
}
