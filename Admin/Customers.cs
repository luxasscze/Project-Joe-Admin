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
using static Admin.SQL;
using static Admin.GlobalVar;
using System.Net.Mail;
using System.Net;

namespace Admin
{
    public partial class Customers : Form
    {
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Tier { get; set; }
        public string Phone { get; set; }
        public int Orders { get; set; }
        public int ActiveCustomers { get; set; }
        public string Status { get; set; }
        public DateTime StatusChanged { get; set; }
        public DateTime Registered { get; set; }
        public DateTime LastActive { get; set; }

        public int ActiveC { get; set; }
        public int InactiveC { get; set; }
        public int SuspendedC { get; set; }
        public int BannedC { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string PostCode { get; set; }

        public List<string> items = new List<string>();


        public static Random randomPassword = new Random();


        public string Notes { get; set; }

        public bool IsPasswordReset { get; set; }

        public string TemporaryPassword { get; set; }
        public decimal CustomerSpending { get; set; }








        public Customers()
        {
            InitializeComponent();
            Cursor = Cursors.WaitCursor;
            RefreshList();
            //ActiveCustomers = customersList.Items.Count;
            activeCustomersText.Text = ActiveCustomers.ToString();
            SetStatusButtonsColor("na");
            GetCustomersStats();
            //ReadSettings();
            tierProgressBar.Value = 0;
            tierProgressBar.Visible = false;
            address1Text.Visible = false;
            address2Text.Visible = false;
            address3Text.Visible = false;
            postCodeText.Visible = false;
            addressCaption.Visible = false;
            ordersCaption.Visible = false;
            tierCaption.Visible = false;
            registeredText.Visible = false;
            lastActiveText.Visible = false;
            spentCaption.Visible = false;
            guestSpendingText.Visible = false;
            Cursor = Cursors.Default;


            
                                   
        }

        public void SetTierProgressBar()
        {
            tierProgressBar.Visible = true;

            

            if(Tier == 0)
            {
                int tierProgress = Orders;
                tierProgressBar.Value = tierProgress;
            }
            else if(Tier == 1)
            {
                int tierProgress = Orders - 10;
                tierProgressBar.Value = tierProgress;
            }
            else if(Tier == 2)
            {
                int tierProgress = Orders - 20;
                tierProgressBar.Value = tierProgress;
            }
            else if(Tier == 3)
            {
                int tierProgress = Orders - 30;
                tierProgressBar.Value = tierProgress;
            }
            else if(Tier == 4)
            {
                int tierProgress = Orders - 40;
                tierProgressBar.Value = tierProgress;
            }
            else if(Tier == 5)
            {
                if (Orders > 50)
                {
                    tierText.Text = "MAX";
                    tierProgressBar.Value = 10;
                }
                else
                {
                    int tierProgress = Orders - 50;
                    tierProgressBar.Value = tierProgress;
                }
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            if(customersList.Items.Count == 0)
            {

            }
            else
            {
                customersList.SelectedIndex = 0;
                
            }
        }

        public void SetStatusButtonsColor(string activeButton)
        {
            if(activeButton == "Active")
            {
                statusActiveButton.BackColor = Color.GreenYellow;
                statusActiveButton.ForeColor = Color.Black;
                
                statusInactiveButton.BackColor = Color.Transparent;
                statusInactiveButton.ForeColor = Color.White;

                statusSuspendedButton.BackColor = Color.Transparent;
                statusSuspendedButton.ForeColor = Color.Orange;

                statusBannedButton.BackColor = Color.Transparent;
                statusBannedButton.ForeColor = Color.IndianRed;
            }
            else if(activeButton == "Inactive")
            {
                statusActiveButton.BackColor = Color.Transparent;
                statusActiveButton.ForeColor = Color.GreenYellow;

                statusInactiveButton.BackColor = Color.White;
                statusInactiveButton.ForeColor = Color.Black;

                statusSuspendedButton.BackColor = Color.Transparent;
                statusSuspendedButton.ForeColor = Color.Orange;

                statusBannedButton.BackColor = Color.Transparent;
                statusBannedButton.ForeColor = Color.IndianRed;
            }
            else if(activeButton == "Suspended")
            {
                statusActiveButton.BackColor = Color.Transparent;
                statusActiveButton.ForeColor = Color.GreenYellow;

                statusInactiveButton.BackColor = Color.Transparent;
                statusInactiveButton.ForeColor = Color.White;

                statusSuspendedButton.BackColor = Color.Orange;
                statusSuspendedButton.ForeColor = Color.Black;

                statusBannedButton.BackColor = Color.Transparent;
                statusBannedButton.ForeColor = Color.IndianRed;
            }
            else if(activeButton == "Banned")
            {
                statusActiveButton.BackColor = Color.Transparent;
                statusActiveButton.ForeColor = Color.GreenYellow;

                statusInactiveButton.BackColor = Color.Transparent;
                statusInactiveButton.ForeColor = Color.White;

                statusSuspendedButton.BackColor = Color.Transparent;
                statusSuspendedButton.ForeColor = Color.Orange;

                statusBannedButton.BackColor = Color.IndianRed;
                statusBannedButton.ForeColor = Color.Black;
            }
            else
            {
                statusActiveButton.BackColor = Color.Transparent;
                statusActiveButton.ForeColor = Color.GreenYellow;

                statusInactiveButton.BackColor = Color.Transparent;
                statusInactiveButton.ForeColor = Color.White;

                statusSuspendedButton.BackColor = Color.Transparent;
                statusSuspendedButton.ForeColor = Color.Orange;

                statusBannedButton.BackColor = Color.Transparent;
                statusBannedButton.ForeColor = Color.IndianRed;
            }
        }

        public void LoadCustomer(string email)
        {

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "SELECT * FROM Customers WHERE Email='" + email + "'",

                    Connection = connection
                };
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Surname = reader["Surname"].ToString();
                    FirstName = reader["FirstName"].ToString();
                    Email = reader["Email"].ToString();
                    Password = reader["Password"].ToString();
                    Tier = int.Parse(reader["Tier"].ToString());
                    Phone = reader["Phone"].ToString();
                    Orders = int.Parse(reader["Orders"].ToString());
                    Status = reader["Status"].ToString();
                    StatusChanged = DateTime.Parse(reader["StatusChanged"].ToString());
                    Registered = DateTime.Parse(reader["Registered"].ToString());
                    LastActive = DateTime.Parse(reader["LastActive"].ToString());
                    Notes = reader["Notes"].ToString();
                    Address1 = reader["Address1"].ToString();
                    Address2 = reader["Address2"].ToString();
                    Address3 = reader["Address3"].ToString();
                    PostCode = reader["PostCode"].ToString();
                    IsPasswordReset = bool.Parse(reader["IsPasswordReset"].ToString());
                    TemporaryPassword = reader["Password"].ToString();
                    CustomerSpending = decimal.Parse(reader["TotalSpending"].ToString());
                }
                connection.Close();
            }

            SetNameColor();

           
        }

        public void SetNameColor()
        {
            if (Status == "Active")
            {
                firstNameText.ForeColor = Color.GreenYellow;
            }
            else if (Status == "Inactive")
            {
                firstNameText.ForeColor = Color.White;
            }
            else if (Status == "Suspended")
            {
                firstNameText.ForeColor = Color.Orange;
            }
            else if (Status == "Banned")
            {
                firstNameText.ForeColor = Color.IndianRed;
            }

            if(IsPasswordReset)
            {
                resetPasswordButton.BackColor = Color.Red;
            }
            else
            {
                resetPasswordButton.BackColor = Color.Transparent;
            }
        }

        public void RefreshList()
        {
            customersList.Items.Clear();
            items.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SELECT Email FROM Customers ORDER BY Email ASC",

                        Connection = connection
                    };
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        customersList.Items.Add(reader["Email"].ToString());
                        items.Add(reader["Email"].ToString());
                    }

                    connection.Close();

                }


            }
            catch(Exception)
            {
                this.Opacity = 0.8;
                DialogWindow alertBox = new DialogWindow("DATABASE CONNECTION ERROR", "PLEASE CHECK YOUR DATABSE SETTINGS...\nMAKE SURE YOU ARE CONNECTED TO THE INTERNET.", "alert");
                alertBox.ShowDialog();
                this.Opacity = 1;
            }
        }

        public void GetCustomersStats()
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SELECT COUNT(Email) FROM Customers WHERE Status='Active'",

                        Connection = connection
                    };

                    SqlCommand cmd1 = new SqlCommand
                    {
                        CommandText = "SELECT COUNT(Email) FROM Customers WHERE Status='Inactive'",

                        Connection = connection
                    };

                    SqlCommand cmd2 = new SqlCommand
                    {
                        CommandText = "SELECT COUNT(Email) FROM Customers WHERE Status='Suspended'",

                        Connection = connection
                    };

                    SqlCommand cmd3 = new SqlCommand
                    {
                        CommandText = "SELECT COUNT(Email) FROM Customers WHERE Status='Banned'",

                        Connection = connection
                    };

                    ActiveC = int.Parse(cmd.ExecuteScalar().ToString());
                    InactiveC = int.Parse(cmd1.ExecuteScalar().ToString());
                    SuspendedC = int.Parse(cmd2.ExecuteScalar().ToString());
                    BannedC = int.Parse(cmd3.ExecuteScalar().ToString());

                    connection.Close();

                }
            }
            catch(Exception)
            {
                this.Opacity = 0.8;
                DialogWindow alertBox = new DialogWindow("DATABASE CONNECTION ERROR", "PLEASE CHECK YOUR DATABASE SETTINGS...\nMAKE SURE YOU ARE CONNECTED TO THE INTERNET.", "alert");
                alertBox.ShowDialog();
                this.Opacity = 1;
            }

            activeCustomersText.Text = ActiveC.ToString();
            inactiveCustomersText.Text = InactiveC.ToString();
            suspendedCustomersText.Text = SuspendedC.ToString();
            bannedCustomersText.Text = BannedC.ToString();


        }

        private void OnSearchKeyPress(object sender, KeyPressEventArgs e)
        {
              
        }

        private void customersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadCustomer(customersList.SelectedItem.ToString());
            
            firstNameText.Text = FirstName + " " + Surname;
            emailText.Text = Email;
            telephoneText.Text = Phone;
            notesTextBox.Text = Notes;
            statusChangedText.Text = StatusChanged.ToString();
            ordersText.Text = Orders.ToString();
            tierText.Text = Tier.ToString();
            registeredText.Text = Registered.ToString();
            lastActiveText.Text = LastActive.ToString();
            SetStatusButtonsColor(Status);
            //SetTierProgressBar();
            address1Text.Visible = true;
            address2Text.Visible = true;
            address3Text.Visible = true;
            postCodeText.Visible = true;
            registeredText.Visible = true;
            lastActiveText.Visible = true;
            spentCaption.Visible = true;
            guestSpendingText.Visible = true;

            guestSpendingText.Text = "£" + CustomerSpending.ToString();

            address1Text.Text = Address1;
            address2Text.Text = Address2;
            address3Text.Text = Address3;
            postCodeText.Text = PostCode;

            addressCaption.Visible = true;
            ordersCaption.Visible = true;
            tierCaption.Visible = true;
            if(IsPasswordReset)
            {
                resetPasswordButton.BackColor = Color.Orange;
                resetPasswordButton.ForeColor = Color.Black;
                resetPasswordButton.Text = "RESET PASSWORD\n" + TemporaryPassword;
            }
            else
            {
                resetPasswordButton.BackColor = Color.Transparent;
                resetPasswordButton.ForeColor = Color.White;
                resetPasswordButton.Text = "RESET PASSWORD";
            }
            Cursor = Cursors.Default;
        }

        

        public void SendEmail(string subject, string htmlString)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(_EmailUsername);
                message.To.Add(new MailAddress(Email));
                message.Subject = subject;
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = htmlString;
                smtp.Port = _EmailPort;
                smtp.Host = _EmailServer; //for gmail host  
                smtp.EnableSsl = _isSSL;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(_EmailUsername, _EmailPassword);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                Cursor = Cursors.Default;
            }
            catch (Exception) 
            {
                this.Opacity = 0.8;
                DialogWindow alertBox = new DialogWindow("ERROR SENDING EMAIL", "PLEASE CHECK YOUR EMAIL SETTINGS...\nMAKE SURE YOU ARE CONNECTED TO THE INTERNET.", "alert");
                alertBox.ShowDialog();
                this.Opacity = 1;
            }
        }

        private void statusActiveButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SetStatusButtonsColor("Active");
            UpdateCustomer(Email, "Status", "Active");
            StatusChanged = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            statusChangedText.Text = StatusChanged.ToString();
            UpdateCustomer(Email, "StatusChanged", StatusChanged.ToString());
            GetCustomersStats();
            firstNameText.ForeColor = Color.GreenYellow;
            Cursor = Cursors.Default;
        }

        private void statusInactiveButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SetStatusButtonsColor("Inactive");
            UpdateCustomer(Email, "Status", "Inactive");
            StatusChanged = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            statusChangedText.Text = StatusChanged.ToString();            
            UpdateCustomer(Email, "StatusChanged", StatusChanged.ToString());
            GetCustomersStats();
            firstNameText.ForeColor = Color.White;
            Cursor = Cursors.Default;
        }

        private void statusSuspendedButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SetStatusButtonsColor("Suspended");
            UpdateCustomer(Email, "Status", "Suspended");
            StatusChanged = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            statusChangedText.Text = StatusChanged.ToString();
            UpdateCustomer(Email, "StatusChanged", StatusChanged.ToString());
            GetCustomersStats();
            firstNameText.ForeColor = Color.Orange;
            Cursor = Cursors.Default;
        }

        private void statusBannedButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SetStatusButtonsColor("Banned");
            UpdateCustomer(Email, "Status", "Banned");
            StatusChanged = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            statusChangedText.Text = StatusChanged.ToString();
            UpdateCustomer(Email, "StatusChanged", StatusChanged.ToString());
            GetCustomersStats();
            firstNameText.ForeColor = Color.IndianRed;
            Cursor = Cursors.Default;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnNotesLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            UpdateCustomer(Email, "Notes", notesTextBox.Text);
            Cursor = Cursors.Default;
        }

        private void OnSearchTextChanged(object sender, EventArgs e)
        {

            string search = searchTextBox.Text;

            if (String.IsNullOrEmpty(search))
            {
                customersList.Items.Clear();
                customersList.Items.AddRange(items.ToArray());
            }

            var items2 = (from a in items where a.Contains(search) select a).ToArray<String>();

            customersList.Items.Clear();
            customersList.Items.AddRange(items2);

            


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
             DialogResult dialogResult = MessageBox.Show("Are you sure to permanently delete customer with email: " + Email + "?\n\nAll customer's data will be lost!", "Delete Customer", MessageBoxButtons.YesNo);
             if (dialogResult == DialogResult.Yes)
             {


                Cursor = Cursors.WaitCursor;
                DeleteCustomer(Email);
               
                DialogWindow alertBox = new DialogWindow(Email, "USER HAS BEEN PERMANENTLY DELETED!", "warning");
                alertBox.ShowDialog();
                
                RefreshList();
                GetCustomersStats();
                Cursor = Cursors.Default;

             }
             else if (dialogResult == DialogResult.No)
             {

             }
        }

        public static string RandomPassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[randomPassword.Next(s.Length)]).ToArray());
        }

       

        private void ResetPassword(string email) 
        {
            string newPassword = RandomPassword(12);


            Cursor = Cursors.WaitCursor;
            UpdateCustomer(email, "Password", newPassword);
            UpdateCustomer(email, "IsPasswordReset", "True");
            SendEmail(_CompanyName + " - PASSWORD RESET", "<h1 style=\"font-size:42px; font-family:impact; color: #d66a00\">Hi " + FirstName + ",</h1><br>" +
                                         "<h2 style=\"font-size:14px\">Your password has been resetted.<br>" +
                                        "Enter temporary password in the app to complete password reset.<br><br>" +
                                         "Temporary password: </h2><h3 style=\"font-size:20px; color: #d66a00\">" + newPassword + "<br><br></h3><h2>Password reset requested by owner.</h2><br><br>" +
                                         "<h4 style=\"font-size:12px\">If you didn't request password resetting, please contact us as soon as possible at " + _CompanyPhone + ", or at " + _EmailUsername + "</h4><br><br>" +
                                         "<h5 style=\"font-size:14px\">Yours " + _CompanyOwner + "<br>" + _CompanyName + "</h5>");
            resetPasswordButton.BackColor = Color.Orange;
            resetPasswordButton.ForeColor = Color.Black;
            resetPasswordButton.Text = "RESET PASSWORD\n" + newPassword;
            Cursor = Cursors.Default;
            //MessageBox.Show("Password Changed!\nNew temporary password: " + newPassword, "Password reset");
            
        }

        private void newCustomerButton_Click(object sender, EventArgs e)
        {
            NewCustomer NCForm = new NewCustomer();
            NCForm.ShowDialog();
        }

        private void OnCustomersActivated(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            RefreshList();
            GetCustomersStats();
            searchTextBox.Text = String.Empty;
            Cursor = Cursors.Default;
        }

        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ResetPassword(Email);
            Cursor = Cursors.Default;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gStaticMap1_Load(object sender, EventArgs e)
        {

        }
    }
}
