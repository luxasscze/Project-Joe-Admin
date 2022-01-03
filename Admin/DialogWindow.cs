using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class DialogWindow : Form
    {
        public DialogWindow(string alertCaption, string AlertText, string type)
        {
            InitializeComponent();
            this.Opacity = 0.95;
            if (type == "alert")
            {
                this.BackColor = Color.FromArgb(32, 8, 8);
                alertCaptionControl.ForeColor = Color.IndianRed;                
                alertTextControl.ForeColor = Color.White;
                lineText.ForeColor = Color.IndianRed;
                secondLineText.ForeColor = Color.IndianRed;
                closeButton.ForeColor = Color.IndianRed;
                alertCaptionControl.Text = alertCaption;
                iconImage.Image = Properties.Resources.alert;
                alertTextControl.Text = AlertText;
            }
            else if (type == "info")
            {
                this.BackColor = Color.FromArgb(8, 32, 8);
                alertCaptionControl.ForeColor = Color.LawnGreen;
                lineText.ForeColor = Color.LawnGreen;
                secondLineText.ForeColor = Color.LawnGreen;
                closeButton.ForeColor = Color.LawnGreen;
                alertTextControl.ForeColor = Color.White;
                alertCaptionControl.Text = alertCaption;
                iconImage.Image = Properties.Resources.info;
                alertTextControl.Text = AlertText;
            }
            else if (type == "warning")
            {
                this.BackColor = Color.FromArgb(32, 32, 8);
                alertCaptionControl.ForeColor = Color.DarkOrange;
                lineText.ForeColor = Color.DarkOrange;
                secondLineText.ForeColor = Color.DarkOrange;
                closeButton.ForeColor = Color.DarkOrange;
                alertTextControl.ForeColor = Color.White;
                alertCaptionControl.Text = alertCaption;
                iconImage.Image = Properties.Resources.warning;
                alertTextControl.Text = AlertText;
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DialogWindow_Load(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
