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
using System.IO;
using FluentFTP;

namespace Admin
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            //CheckDocOnServer();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {

            if (SettingsData(0) == null)
            {
                sqlServerTextBox.Text = "";
            }
            else
            {
                sqlServerTextBox.Text = DecryptString(_keySQL, SettingsData(0));
            }

            if (SettingsData(1) == null)
            {
                sqlDatabaseTextBox.Text = "";
            }
            else
            {
                sqlDatabaseTextBox.Text = DecryptString(_keySQL, SettingsData(1));
            }

            if (SettingsData(2) == null)
            {
                sqlUserNameTextBox.Text = "";
            }
            else
            {
                sqlUserNameTextBox.Text = DecryptString(_keySQL, SettingsData(2));
            }

            if (SettingsData(3) == null)
            {
                sqlPasswordText.Text = "";
            }
            else
            {
                sqlPasswordText.Text = DecryptString(_keySQL, SettingsData(3));
            }

            if (SettingsData(4) == null)
            {
                emailServerTextBox.Text = "";
            }
            else
            {
                emailServerTextBox.Text = DecryptString(_keyEmail, SettingsData(4));
            }
            if (SettingsData(5) == null)
            {
                emailUsernameTextBox.Text = "";
            }
            else
            {
                emailUsernameTextBox.Text = DecryptString(_keyEmail, SettingsData(5));
            }

            if (SettingsData(6) == null)
            {
                emailPasswordTextBox.Text = "";
            }
            else
            {
                emailPasswordTextBox.Text = DecryptString(_keyEmail, SettingsData(6));
            }
            if (SettingsData(7) == null)
            {
                _isSSL = false;
            }
            else
            {
                _isSSL = bool.Parse(DecryptString(_keyEmail, SettingsData(7)));
            }


            if (_isSSL)
            {
                sslYesButton.BackColor = Color.White;
                sslYesButton.ForeColor = Color.Black;
                sslNoButton.BackColor = Color.Transparent;
                sslNoButton.ForeColor = Color.Gray;
            }
            else
            {
                sslYesButton.BackColor = Color.Transparent;
                sslYesButton.ForeColor = Color.Gray;
                sslNoButton.BackColor = Color.White;
                sslNoButton.ForeColor = Color.Black;
            }

            if (SettingsData(8) == null)
            {
                emailPortTextBox.Text = "";
            }
            else
            {
                emailPortTextBox.Text = DecryptString(_keyEmail, SettingsData(8));
            }

            if (SettingsData(9) == null)
            {
                companyNameTextBox.Text = "";
            }
            else
            {
                companyNameTextBox.Text = DecryptString(_keyCompany, SettingsData(9));
            }

            if (SettingsData(10) == null)
            {
                companyOwnerTextBox.Text = "";
            }
            else
            {
                companyOwnerTextBox.Text = DecryptString(_keyCompany, SettingsData(10));
            }

            if (SettingsData(11) == null)
            {
                companyPhoneTextBox.Text = "";
            }
            else
            {
                companyPhoneTextBox.Text = DecryptString(_keyCompany, SettingsData(11));
            }

            if (SettingsData(12) == null)
            {
                imageUriPath.Text = "";
            }
            else
            {
                imageUriPath.Text = DecryptString(_keySQL, SettingsData(12));
            }

            if (SettingsData(13) == null)
            {
                appPasswordTextBox.Text = "";
                appPasswordRetypeTextBox.Text = "";
            }
            else
            {

                appPasswordTextBox.Text = DecryptString(_keySQL, SettingsData(13));
                appPasswordRetypeTextBox.Text = DecryptString(_keySQL, SettingsData(13));
            }

            if(SettingsData(14) == null)
            {
                ftpServerTextBox.Text = "";
            }
            else
            {
                ftpServerTextBox.Text = DecryptString(_keySQL, SettingsData(14));
            }

            if(SettingsData(15) == null)
            {
                ftpUserNameTextBox.Text = "";
            }
            else
            {
                ftpUserNameTextBox.Text = DecryptString(_keySQL, SettingsData(15));
            }

            if(SettingsData(16) == null)
            {
                ftpPasswordTextBox.Text = "";
            }
            else
            {
                ftpPasswordTextBox.Text = DecryptString(_keySQL, SettingsData(16));
            }

            if(SettingsData(17) == null)
            {
                locationPathTextBox.Text = "";
            }
            else
            {
                locationPathTextBox.Text = DecryptString(_keySQL, SettingsData(17));
            }
        }

        private void sslYesButton_Click(object sender, EventArgs e)
        {
            _isSSL = true;
            sslYesButton.BackColor = Color.White;
            sslYesButton.ForeColor = Color.Black;
            sslNoButton.BackColor = Color.Transparent;
            sslNoButton.ForeColor = Color.Gray;
        }

        private void sslNoButton_Click(object sender, EventArgs e)
        {
            _isSSL = false;
            sslYesButton.BackColor = Color.Transparent;
            sslYesButton.ForeColor = Color.Gray;
            sslNoButton.BackColor = Color.White;
            sslNoButton.ForeColor = Color.Black;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (sqlServerTextBox.Text == String.Empty || sqlDatabaseTextBox.Text == String.Empty || sqlUserNameTextBox.Text == String.Empty || sqlPasswordText.Text == String.Empty
               || emailServerTextBox.Text == String.Empty || emailPortTextBox.Text == String.Empty || emailUsernameTextBox.Text == String.Empty ||emailPasswordTextBox.Text == String.Empty 
               || companyNameTextBox.Text == String.Empty || companyOwnerTextBox.Text == String.Empty || companyPhoneTextBox.Text == String.Empty || imageUriPath.Text == String.Empty
               || appPasswordTextBox.Text == String.Empty || appPasswordRetypeTextBox.Text == String.Empty || appPasswordTextBox.Text.Length < 6 || ftpServerTextBox.Text == String.Empty
               || ftpUserNameTextBox.Text == String.Empty || ftpPasswordTextBox.Text == String.Empty || locationPathTextBox.Text == String.Empty)
            {
                
                DialogWindow alertBox = new DialogWindow("I WOULD LIKE TO SAVE IT, BUT...", "● ALL FIELDS AND DOCUMENTS ARE MANDATORY\n● PASSWORD NEEDS TO BE AT LEAST 6 CHARACTER LONG", "alert");
                alertBox.ShowDialog();
                
            }
            else
            {
                if (appPasswordTextBox.Text != appPasswordRetypeTextBox.Text)
                {
                    
                    DialogWindow alertBox = new DialogWindow("PASSWORD ISSUE", "● PASSWORDS ARE NOT IN MATCH!", "alert");
                    alertBox.ShowDialog();
                    
                }
                else
                {
                    if (!Directory.Exists("./Settings"))
                    {
                        Directory.CreateDirectory("./Settings");
                    }


                    File.WriteAllText("./Settings/Settings.dat", EncryptString(_keySQL, sqlServerTextBox.Text) + ";" + EncryptString(_keySQL, sqlDatabaseTextBox.Text) + ";" + EncryptString(_keySQL, sqlUserNameTextBox.Text) +
                                        ";" + EncryptString(_keySQL, sqlPasswordText.Text) + ";" + EncryptString(_keyEmail, emailServerTextBox.Text) + ";" + EncryptString(_keyEmail, emailUsernameTextBox.Text) + ";" +
                                        EncryptString(_keyEmail, emailPasswordTextBox.Text) + ";" + EncryptString(_keyEmail, _isSSL.ToString()) + ";" + EncryptString(_keyEmail, emailPortTextBox.Text) + ";" +
                                        EncryptString(_keyCompany, companyNameTextBox.Text) + ";" + EncryptString(_keyCompany, companyOwnerTextBox.Text) + ";" + EncryptString(_keyCompany, companyPhoneTextBox.Text) +
                                        ";" + EncryptString(_keySQL, imageUriPath.Text) + ";" + EncryptString(_keySQL, appPasswordRetypeTextBox.Text) + ";" + EncryptString(_keySQL, ftpServerTextBox.Text) + 
                                        ";" + EncryptString(_keySQL, ftpUserNameTextBox.Text) + ";" + EncryptString(_keySQL, ftpPasswordTextBox.Text) + ";" + EncryptString(_keySQL, locationPathTextBox.Text));


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

                    this.Close();
                }
            }
        }

        public void CheckDocOnServer()
        {
            if (File.Exists("./Settings/Settings.dat"))
            {
                using (FtpClient ftp = new FtpClient(_FTPServer, _FTPUsername, _FTPPassword))
                {
                    ftp.Connect();
                    if (ftp.FileExists(_FTPLocation + "/DOC/GDPR.txt"))
                    {
                        button1.BackColor = Color.GreenYellow;
                        button1.ForeColor = Color.Black;
                        button1.Text = "GDPR uploaded";
                    }
                    else
                    {
                        button1.BackColor = Color.Transparent;
                        button1.ForeColor = Color.Gray;
                        button1.Text = "Upload GDPR";
                    }

                    if (ftp.FileExists(_FTPLocation + "/DOC/TC.txt"))
                    {
                        button2.BackColor = Color.GreenYellow;
                        button2.ForeColor = Color.Black;
                        button2.Text = "T&Cs uploaded";
                    }
                    else
                    {
                        button2.BackColor = Color.Transparent;
                        button2.ForeColor = Color.Gray;
                        button2.Text = "Upload T&Cs";
                    }

                    if (ftp.FileExists(_FTPLocation + "/DOC/COMPDESC.txt"))
                    {
                        button3.BackColor = Color.GreenYellow;
                        button3.ForeColor = Color.Black;
                        button3.Text = "COMP DESC uploaded";
                    }
                    else
                    {
                        button3.BackColor = Color.Transparent;
                        button3.ForeColor = Color.Gray;
                        button3.Text = "Upload COMP DESC";
                    }
                    ftp.Disconnect();


                }
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDocument.FileName = "";
            openFileDocument.Title = "Please, select your GDPR document";
            if (openFileDocument.ShowDialog() == DialogResult.OK)
            {
                using (FtpClient ftp = new FtpClient(_FTPServer, _FTPUsername, _FTPPassword))
                {
                    ftp.Connect();
                    ftp.UploadFile(openFileDocument.FileName, _FTPLocation + "/DOC/GDPR.txt", FtpRemoteExists.Overwrite);
                    ftp.Disconnect();

                    
                }

                button1.Text = "GDPR uploaded";
                button1.BackColor = Color.GreenYellow;
                button1.ForeColor = Color.Black;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDocument.FileName = "*.txt";
            openFileDocument.Title = "Please, select your Terms&Conditions document";
            

            if (openFileDocument.ShowDialog() == DialogResult.OK)
            {
                using (FtpClient ftp = new FtpClient(_FTPServer, _FTPUsername, _FTPPassword))
                {
                    ftp.Connect();
                    ftp.UploadFile(openFileDocument.FileName, _FTPLocation + "/DOC/TC.txt", FtpRemoteExists.Overwrite);
                    ftp.Disconnect();


                }

                button2.Text = "T&C uploaded";
                button2.BackColor = Color.GreenYellow;
                button2.ForeColor = Color.Black;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDocument.FileName = "*.txt";
            openFileDocument.Title = "Please, select your Company Description document";
            

            if (openFileDocument.ShowDialog() == DialogResult.OK)
            {
                using (FtpClient ftp = new FtpClient(_FTPServer, _FTPUsername, _FTPPassword))
                {
                    ftp.Connect();
                    ftp.UploadFile(openFileDocument.FileName, _FTPLocation + "/DOC/COMPDESC.txt", FtpRemoteExists.Overwrite);
                    ftp.Disconnect();


                }

                button3.Text = "T&C uploaded";
                button3.BackColor = Color.GreenYellow;
                button3.ForeColor = Color.Black;

            }
        }

        private void imageUriPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
