using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Admin.GlobalVar;

namespace Admin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Opacity = 0.95;
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            _LoginState = false;
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            passwordText.Text = "Password: " + _AppPassword;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == _AppPassword)
            {
                _LoginState = true;
                this.Close();
            }
            else
            {
                this.Opacity = 0.6;
                DialogWindow alertBox = new DialogWindow("LOGIN ALERT", "WRONG PASSWORD!", "alert");
                alertBox.ShowDialog();
                this.Opacity = 0.8;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnLoginKeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void OnLoginKeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void OnLoginKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (passwordTextBox.Text == _AppPassword)
                {
                    _LoginState = true;
                    this.Close();
                }
                else
                {
                    this.Opacity = 0.6;
                    DialogWindow alertBox = new DialogWindow("LOGIN ALERT", "WRONG PASSWORD!", "alert");
                    alertBox.ShowDialog();
                    this.Opacity = 0.8;
                }
            }
        }
    }
}
