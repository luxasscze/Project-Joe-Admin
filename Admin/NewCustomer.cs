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
    public partial class NewCustomer : Form
    {
        
        public bool isValid { get; set; }

        
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void OnEmailTextBoxLeave(object sender, EventArgs e)
        {
            if(!emailTextBox.Text.Contains("@") || !emailTextBox.Text.Contains("."))
            {
                emailTextBox.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                emailTextBox.BackColor = Color.FromArgb(64, 64, 64);
                isValid = true;
            }
        }

        private void OnRetypeLeave(object sender, EventArgs e)
        {
            if(passwordTextBox.Text != retypePasswordTextBox.Text)
            {
                passwordTextBox.BackColor = Color.Red;
                retypePasswordTextBox.BackColor = Color.Red;
                passwordStatusText.Visible = true;

                isValid = false;


            }
            else
            {
                isValid = true;

                passwordTextBox.BackColor = Color.FromArgb(64, 64, 64);
                retypePasswordTextBox.BackColor = Color.FromArgb(64, 64, 64);
                passwordStatusText.Visible = false;
            }

            
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {
            passwordStatusText.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(surnameTextBox.Text == String.Empty || firstNameTextBox.Text == String.Empty || phoneTextBox.Text == String.Empty || emailTextBox.Text == String.Empty || !isValid 
                || retypePasswordTextBox.Text == String.Empty || address1TextBox.Text == String.Empty || address2TextBox.Text == String.Empty || postCodeTextBox.Text == String.Empty 
                || passwordTextBox.Text != retypePasswordTextBox.Text || !emailTextBox.Text.Contains("@") || !emailTextBox.Text.Contains("."))
            {
                if(surnameTextBox.Text == String.Empty)
                {
                    surnameTextBox.BackColor = Color.Red;
                    isValid = false;
                }
                else
                {
                    surnameTextBox.BackColor = Color.FromArgb(64, 64, 64);
                    isValid = true;
                }

                if(firstNameTextBox.Text == String.Empty)
                {
                    firstNameTextBox.BackColor = Color.Red;
                    isValid = false;
                }
                else
                {
                    firstNameTextBox.BackColor = Color.FromArgb(64, 64, 64);
                    isValid = true;
                }

                if(phoneTextBox.Text == String.Empty)
                {
                    phoneTextBox.BackColor = Color.Red;
                    isValid = false;
                }
                else
                {
                    phoneTextBox.BackColor = Color.FromArgb(64, 64, 64);
                    isValid = true;
                }

                if (emailTextBox.Text == String.Empty)
                {
                    emailTextBox.BackColor = Color.Red;
                    isValid = false;
                }
                else
                {
                    if (!emailTextBox.Text.Contains("@") || !emailTextBox.Text.Contains("."))
                    {
                        emailTextBox.BackColor = Color.Red;
                        isValid = false;
                    }
                    else
                    {
                        emailTextBox.BackColor = Color.FromArgb(64, 64, 64);
                        isValid = true;
                    }

                   
                }

                if(retypePasswordTextBox.Text == String.Empty)
                {
                    passwordTextBox.BackColor = Color.Red;
                    retypePasswordTextBox.BackColor = Color.Red;

                    isValid = false;
                }
                else
                {
                    if(passwordTextBox.Text != retypePasswordTextBox.Text)
                    {
                        passwordStatusText.Visible = true;
                        passwordTextBox.BackColor = Color.Red;
                        retypePasswordTextBox.BackColor = Color.Red;

                        isValid = false;
                    }
                    else
                    {
                        passwordStatusText.Visible = false;
                        passwordTextBox.BackColor = Color.FromArgb(64, 64, 64);
                        retypePasswordTextBox.BackColor = Color.FromArgb(64, 64, 64);
                        isValid = true;
                    }
                }

                if(address1TextBox.Text == String.Empty)
                {
                    address1TextBox.BackColor = Color.Red;
                    isValid = false;
                }
                else
                {
                    address1TextBox.BackColor = Color.FromArgb(64, 64, 64);
                    isValid = true;
                }

                if(address2TextBox.Text == String.Empty)
                {
                    address2TextBox.BackColor = Color.Red;
                    isValid = false;
                }
                else
                {
                    address2TextBox.BackColor = Color.FromArgb(64, 64, 64);
                    isValid = true;
                }

                if(postCodeTextBox.Text == String.Empty)
                {
                    postCodeTextBox.BackColor = Color.Red;
                    isValid = false;
                }
                else
                {
                    postCodeTextBox.BackColor = Color.FromArgb(64, 64, 64);
                    isValid = true;
                }
                //MessageBox.Show("Please, double check your entries...");
            }
            else
            {
                if (CheckUserExists(emailTextBox.Text))
                {
                   
                    DialogWindow alertBox = new DialogWindow("CUSTOMER ALREADY EXISTS", "USER WITH EMAIL " + emailTextBox.Text + "\n HAS BEEN ALREADY REGISTERED.", "warning");
                    alertBox.ShowDialog();
                   
                }
                else
                {
                    NewCustomer(emailTextBox.Text, surnameTextBox.Text, firstNameTextBox.Text, phoneTextBox.Text, retypePasswordTextBox.Text, notesTextBox.Text, 
                                address1TextBox.Text, address2TextBox.Text, address3TextBox.Text, postCodeTextBox.Text);
                    this.Close();
                }
            }
        }
    }
}
