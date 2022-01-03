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
using FluentFTP;
using static Admin.GlobalVar;
using static Admin.SQL;
using System.IO;
using LoadingIndicator.WinForms;

namespace Admin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadSettings();




        }

        public void ReadSettings()
        {
            if (!File.Exists("./Settings/Settings.dat"))
            {
                
            }
            else
            {
                _SQLServer = DecryptString(_keySQL, SettingsData(0));
                _SQLDatabase = DecryptString(_keySQL, SettingsData(1));
                _SQLUsername = DecryptString(_keySQL, SettingsData(2));
                _SQLPassword = DecryptString(_keySQL, SettingsData(3));
                _EmailServer = DecryptString(_keyEmail, SettingsData(4));
                _EmailUsername = DecryptString(_keyEmail, SettingsData(5));
                _EmailPassword = DecryptString(_keyEmail, SettingsData(6));
                _isSSL = bool.Parse(DecryptString(_keyEmail, SettingsData(7)));
                _EmailPort = int.Parse(DecryptString(_keyEmail, SettingsData(8)));
                _CompanyName = DecryptString(_keyCompany, SettingsData(9));
                _CompanyOwner = DecryptString(_keyCompany, SettingsData(10));
                _CompanyPhone = DecryptString(_keyCompany, SettingsData(11));
                _ImageUriPath = DecryptString(_keySQL, SettingsData(12));
                _AppPassword = DecryptString(_keySQL, SettingsData(13));
                
                _FTPServer = DecryptString(_keySQL, SettingsData(14));
                _FTPUsername = DecryptString(_keySQL, SettingsData(15));
                _FTPPassword = DecryptString(_keySQL, SettingsData(16));
                _FTPLocation = DecryptString(_keySQL, SettingsData(17));
            }           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //loadingBox.Visible = false;
            
             if (File.Exists("./Settings/Settings.dat"))
             {
                    

                Login LForm = new Login();
                LForm.ShowDialog();
                if (_LoginState)
                {
                    companyNameTitleText.Text = _CompanyName.ToUpper() + " - ADMIN";
                }
                else
                {
                    this.Close();
                }

             }
             else
             {

                DialogWindow alertBox = new DialogWindow("WELCOME TO THE FUTURE!", "IT LOOKS LIKE THIS IS YOUR FIRST TIME WITH THE APP\nLET'S SET UP YOUR BUSINESS...", "info");
                alertBox.ShowDialog();
                Settings SetForm = new Settings();
                SetForm.ShowDialog();


             }

           
            
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists("./Settings/Settings.dat"))
            {
                Settings SetForm = new Settings();
                SetForm.ShowDialog();
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                Customers CForm = new Customers();
                CForm.ShowDialog();
                Cursor = Cursors.Default;
            }
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists("./Settings/Settings.dat"))
            {
                Settings SetForm = new Settings();
                SetForm.ShowDialog();
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                Orders OForm = new Orders();
                this.Visible = false;
                OForm.ShowDialog();
                this.Visible = true;
                Cursor = Cursors.Default;
            }
            
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {

            if (!File.Exists("./Settings/Settings.dat"))
            {
                Settings SetForm = new Settings();
                SetForm.ShowDialog();
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                Statistics SForm = new Statistics();
                SForm.ShowDialog();
                Cursor = Cursors.Default;
            }
            
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Settings SetForm = new Settings();
            SetForm.ShowDialog();
            Cursor = Cursors.Default;
        }

        public void LoadProductManagement()
        {
            if (!File.Exists("./Settings/Settings.dat"))
            {
                Settings SetForm = new Settings();
                SetForm.ShowDialog();
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                ProductManagement PMForm = new ProductManagement();
                PMForm.ShowDialog();
                Cursor = Cursors.Default;
            }
        }

       

        private void productManagementButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists("./Settings/Settings.dat"))
            {
                Settings SetForm = new Settings();
                SetForm.ShowDialog();
            }
            else
            {
                LongOperation _longOperation;
                _longOperation = new LongOperation(this);
                

                using (_longOperation.Start())
                {
                    Cursor = Cursors.WaitCursor; 
                    LoadProductManagement();
                    Cursor = Cursors.Default;
                }
               
                
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void staffButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists("./Settings/Settings.dat"))
            {
                Cursor = Cursors.WaitCursor;
                Settings setForm = new Settings();
                setForm.ShowDialog();
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                Staff StaffForm = new Staff();
                StaffForm.ShowDialog();
                Cursor = Cursors.Default;
            }
        }

        private void tierRulesButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists("./Settings/Settings.dat"))
            {
                Settings setForm = new Settings();
                setForm.ShowDialog();
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                TierRules TRForm = new TierRules();
                TRForm.ShowDialog();
                Cursor = Cursors.Default;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MobileSettings MSForm = new MobileSettings();
            MSForm.ShowDialog();
        }
    }
}
