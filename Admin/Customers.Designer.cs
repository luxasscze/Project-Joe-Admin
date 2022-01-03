
namespace Admin
{
    partial class Customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customersList = new System.Windows.Forms.ListBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.activeCustomersText = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.Label();
            this.tierCaption = new System.Windows.Forms.Label();
            this.statusActiveButton = new System.Windows.Forms.Button();
            this.statusInactiveButton = new System.Windows.Forms.Button();
            this.statusBannedButton = new System.Windows.Forms.Button();
            this.statusSuspendedButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.statusChangedText = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.RichTextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.inactiveCustomersText = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.suspendedCustomersText = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.bannedCustomersText = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.newCustomerButton = new System.Windows.Forms.Button();
            this.ordersText = new System.Windows.Forms.Label();
            this.tierText = new System.Windows.Forms.Label();
            this.ordersCaption = new System.Windows.Forms.Label();
            this.telephoneText = new System.Windows.Forms.Label();
            this.registeredText = new System.Windows.Forms.Label();
            this.lastActiveText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tierProgressBar = new System.Windows.Forms.ProgressBar();
            this.addressCaption = new System.Windows.Forms.Label();
            this.address1Text = new System.Windows.Forms.Label();
            this.address2Text = new System.Windows.Forms.Label();
            this.address3Text = new System.Windows.Forms.Label();
            this.postCodeText = new System.Windows.Forms.Label();
            this.emailButton = new System.Windows.Forms.Button();
            this.resetPasswordButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.spentCaption = new System.Windows.Forms.Label();
            this.guestSpendingText = new System.Windows.Forms.Label();
            
            this.SuspendLayout();
            // 
            // customersList
            // 
            this.customersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersList.ForeColor = System.Drawing.Color.White;
            this.customersList.FormattingEnabled = true;
            this.customersList.ItemHeight = 20;
            this.customersList.Location = new System.Drawing.Point(19, 33);
            this.customersList.Name = "customersList";
            this.customersList.Size = new System.Drawing.Size(259, 460);
            this.customersList.TabIndex = 1;
            this.customersList.SelectedIndexChanged += new System.EventHandler(this.customersList_SelectedIndexChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.searchTextBox.Location = new System.Drawing.Point(76, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(202, 19);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.TextChanged += new System.EventHandler(this.OnSearchTextChanged);
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnSearchKeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(55, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Active customers";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // activeCustomersText
            // 
            this.activeCustomersText.AutoSize = true;
            this.activeCustomersText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeCustomersText.ForeColor = System.Drawing.Color.GreenYellow;
            this.activeCustomersText.Location = new System.Drawing.Point(14, 502);
            this.activeCustomersText.Name = "activeCustomersText";
            this.activeCustomersText.Size = new System.Drawing.Size(20, 23);
            this.activeCustomersText.TabIndex = 5;
            this.activeCustomersText.Text = "0";
            // 
            // firstNameText
            // 
            this.firstNameText.AutoSize = true;
            this.firstNameText.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameText.ForeColor = System.Drawing.Color.DimGray;
            this.firstNameText.Location = new System.Drawing.Point(451, 60);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(345, 45);
            this.firstNameText.TabIndex = 7;
            this.firstNameText.Text = "<--- SELECT CUSTOMER";
            // 
            // emailText
            // 
            this.emailText.AutoSize = true;
            this.emailText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.ForeColor = System.Drawing.Color.White;
            this.emailText.Location = new System.Drawing.Point(454, 103);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(153, 23);
            this.emailText.TabIndex = 8;
            this.emailText.Text = "Change the world!";
            // 
            // tierCaption
            // 
            this.tierCaption.AutoSize = true;
            this.tierCaption.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tierCaption.ForeColor = System.Drawing.Color.Gray;
            this.tierCaption.Location = new System.Drawing.Point(285, 135);
            this.tierCaption.Name = "tierCaption";
            this.tierCaption.Size = new System.Drawing.Size(46, 26);
            this.tierCaption.TabIndex = 11;
            this.tierCaption.Text = "Tier";
            // 
            // statusActiveButton
            // 
            this.statusActiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusActiveButton.ForeColor = System.Drawing.Color.White;
            this.statusActiveButton.Location = new System.Drawing.Point(801, 357);
            this.statusActiveButton.Name = "statusActiveButton";
            this.statusActiveButton.Size = new System.Drawing.Size(117, 23);
            this.statusActiveButton.TabIndex = 18;
            this.statusActiveButton.Text = "ACTIVE";
            this.statusActiveButton.UseVisualStyleBackColor = true;
            this.statusActiveButton.Click += new System.EventHandler(this.statusActiveButton_Click);
            // 
            // statusInactiveButton
            // 
            this.statusInactiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusInactiveButton.ForeColor = System.Drawing.Color.White;
            this.statusInactiveButton.Location = new System.Drawing.Point(801, 386);
            this.statusInactiveButton.Name = "statusInactiveButton";
            this.statusInactiveButton.Size = new System.Drawing.Size(117, 23);
            this.statusInactiveButton.TabIndex = 19;
            this.statusInactiveButton.Text = "INACTIVE";
            this.statusInactiveButton.UseVisualStyleBackColor = true;
            this.statusInactiveButton.Click += new System.EventHandler(this.statusInactiveButton_Click);
            // 
            // statusBannedButton
            // 
            this.statusBannedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusBannedButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.statusBannedButton.Location = new System.Drawing.Point(802, 444);
            this.statusBannedButton.Name = "statusBannedButton";
            this.statusBannedButton.Size = new System.Drawing.Size(116, 23);
            this.statusBannedButton.TabIndex = 21;
            this.statusBannedButton.Text = "BANNED";
            this.statusBannedButton.UseVisualStyleBackColor = true;
            this.statusBannedButton.Click += new System.EventHandler(this.statusBannedButton_Click);
            // 
            // statusSuspendedButton
            // 
            this.statusSuspendedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusSuspendedButton.ForeColor = System.Drawing.Color.White;
            this.statusSuspendedButton.Location = new System.Drawing.Point(802, 415);
            this.statusSuspendedButton.Name = "statusSuspendedButton";
            this.statusSuspendedButton.Size = new System.Drawing.Size(116, 23);
            this.statusSuspendedButton.TabIndex = 20;
            this.statusSuspendedButton.Text = "SUSPENDED";
            this.statusSuspendedButton.UseVisualStyleBackColor = true;
            this.statusSuspendedButton.Click += new System.EventHandler(this.statusSuspendedButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.label9.Location = new System.Drawing.Point(294, 454);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Status changed:";
            // 
            // statusChangedText
            // 
            this.statusChangedText.AutoSize = true;
            this.statusChangedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusChangedText.ForeColor = System.Drawing.Color.DarkKhaki;
            this.statusChangedText.Location = new System.Drawing.Point(379, 454);
            this.statusChangedText.Name = "statusChangedText";
            this.statusChangedText.Size = new System.Drawing.Size(0, 13);
            this.statusChangedText.TabIndex = 23;
            // 
            // notesTextBox
            // 
            this.notesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.notesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notesTextBox.ForeColor = System.Drawing.Color.White;
            this.notesTextBox.Location = new System.Drawing.Point(546, 383);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(250, 84);
            this.notesTextBox.TabIndex = 25;
            this.notesTextBox.Text = "";
            this.notesTextBox.Leave += new System.EventHandler(this.OnNotesLeave);
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(925, 473);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(146, 52);
            this.closeButton.TabIndex = 26;
            this.closeButton.Text = "CLOSE";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(291, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Registered";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(293, 424);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Last Active";
            // 
            // exportButton
            // 
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.ForeColor = System.Drawing.Color.White;
            this.exportButton.Location = new System.Drawing.Point(925, 415);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(146, 52);
            this.exportButton.TabIndex = 31;
            this.exportButton.Text = "EXPORT";
            this.exportButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.DarkSalmon;
            this.deleteButton.Location = new System.Drawing.Point(802, 492);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(116, 33);
            this.deleteButton.TabIndex = 32;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // inactiveCustomersText
            // 
            this.inactiveCustomersText.AutoSize = true;
            this.inactiveCustomersText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inactiveCustomersText.ForeColor = System.Drawing.Color.White;
            this.inactiveCustomersText.Location = new System.Drawing.Point(207, 502);
            this.inactiveCustomersText.Name = "inactiveCustomersText";
            this.inactiveCustomersText.Size = new System.Drawing.Size(20, 23);
            this.inactiveCustomersText.TabIndex = 34;
            this.inactiveCustomersText.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(248, 509);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 19);
            this.label14.TabIndex = 33;
            this.label14.Text = "Inactive customers";
            // 
            // suspendedCustomersText
            // 
            this.suspendedCustomersText.AutoSize = true;
            this.suspendedCustomersText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suspendedCustomersText.ForeColor = System.Drawing.Color.Orange;
            this.suspendedCustomersText.Location = new System.Drawing.Point(413, 502);
            this.suspendedCustomersText.Name = "suspendedCustomersText";
            this.suspendedCustomersText.Size = new System.Drawing.Size(20, 23);
            this.suspendedCustomersText.TabIndex = 36;
            this.suspendedCustomersText.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Orange;
            this.label16.Location = new System.Drawing.Point(454, 509);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 19);
            this.label16.TabIndex = 35;
            this.label16.Text = "Suspended customers";
            // 
            // bannedCustomersText
            // 
            this.bannedCustomersText.AutoSize = true;
            this.bannedCustomersText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannedCustomersText.ForeColor = System.Drawing.Color.IndianRed;
            this.bannedCustomersText.Location = new System.Drawing.Point(628, 502);
            this.bannedCustomersText.Name = "bannedCustomersText";
            this.bannedCustomersText.Size = new System.Drawing.Size(20, 23);
            this.bannedCustomersText.TabIndex = 38;
            this.bannedCustomersText.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.IndianRed;
            this.label18.Location = new System.Drawing.Point(669, 509);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 19);
            this.label18.TabIndex = 37;
            this.label18.Text = "Banned customers";
            // 
            // newCustomerButton
            // 
            this.newCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newCustomerButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustomerButton.ForeColor = System.Drawing.Color.White;
            this.newCustomerButton.Location = new System.Drawing.Point(925, 357);
            this.newCustomerButton.Name = "newCustomerButton";
            this.newCustomerButton.Size = new System.Drawing.Size(146, 52);
            this.newCustomerButton.TabIndex = 39;
            this.newCustomerButton.Text = "NEW CUSTOMER";
            this.newCustomerButton.UseVisualStyleBackColor = true;
            this.newCustomerButton.Click += new System.EventHandler(this.newCustomerButton_Click);
            // 
            // ordersText
            // 
            this.ordersText.AutoSize = true;
            this.ordersText.BackColor = System.Drawing.Color.Transparent;
            this.ordersText.Font = new System.Drawing.Font("Impact", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ordersText.Location = new System.Drawing.Point(285, 38);
            this.ordersText.Name = "ordersText";
            this.ordersText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ordersText.Size = new System.Drawing.Size(37, 65);
            this.ordersText.TabIndex = 40;
            this.ordersText.Text = " ";
            this.ordersText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tierText
            // 
            this.tierText.AutoSize = true;
            this.tierText.BackColor = System.Drawing.Color.Transparent;
            this.tierText.Font = new System.Drawing.Font("Impact", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tierText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tierText.Location = new System.Drawing.Point(318, 103);
            this.tierText.Name = "tierText";
            this.tierText.Size = new System.Drawing.Size(37, 65);
            this.tierText.TabIndex = 41;
            this.tierText.Text = " ";
            // 
            // ordersCaption
            // 
            this.ordersCaption.AutoSize = true;
            this.ordersCaption.BackColor = System.Drawing.Color.Transparent;
            this.ordersCaption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersCaption.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersCaption.ForeColor = System.Drawing.Color.Gray;
            this.ordersCaption.Location = new System.Drawing.Point(352, 70);
            this.ordersCaption.Name = "ordersCaption";
            this.ordersCaption.Size = new System.Drawing.Size(71, 26);
            this.ordersCaption.TabIndex = 10;
            this.ordersCaption.Text = "Orders";
            this.ordersCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telephoneText
            // 
            this.telephoneText.AutoSize = true;
            this.telephoneText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneText.ForeColor = System.Drawing.Color.White;
            this.telephoneText.Location = new System.Drawing.Point(454, 128);
            this.telephoneText.Name = "telephoneText";
            this.telephoneText.Size = new System.Drawing.Size(0, 23);
            this.telephoneText.TabIndex = 42;
            // 
            // registeredText
            // 
            this.registeredText.AutoSize = true;
            this.registeredText.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registeredText.ForeColor = System.Drawing.Color.White;
            this.registeredText.Location = new System.Drawing.Point(378, 389);
            this.registeredText.Name = "registeredText";
            this.registeredText.Size = new System.Drawing.Size(81, 20);
            this.registeredText.TabIndex = 43;
            this.registeredText.Text = "Registered";
            // 
            // lastActiveText
            // 
            this.lastActiveText.AutoSize = true;
            this.lastActiveText.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastActiveText.ForeColor = System.Drawing.Color.White;
            this.lastActiveText.Location = new System.Drawing.Point(378, 424);
            this.lastActiveText.Name = "lastActiveText";
            this.lastActiveText.Size = new System.Drawing.Size(81, 20);
            this.lastActiveText.TabIndex = 44;
            this.lastActiveText.Text = "Registered";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(649, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Notes";
            // 
            // tierProgressBar
            // 
            this.tierProgressBar.ForeColor = System.Drawing.Color.GreenYellow;
            this.tierProgressBar.Location = new System.Drawing.Point(290, 171);
            this.tierProgressBar.Maximum = 10;
            this.tierProgressBar.Name = "tierProgressBar";
            this.tierProgressBar.Size = new System.Drawing.Size(780, 10);
            this.tierProgressBar.Step = 1;
            this.tierProgressBar.TabIndex = 46;
            this.tierProgressBar.Value = 10;
            // 
            // addressCaption
            // 
            this.addressCaption.AutoSize = true;
            this.addressCaption.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressCaption.ForeColor = System.Drawing.Color.Gray;
            this.addressCaption.Location = new System.Drawing.Point(293, 199);
            this.addressCaption.Name = "addressCaption";
            this.addressCaption.Size = new System.Drawing.Size(141, 23);
            this.addressCaption.TabIndex = 47;
            this.addressCaption.Text = "Delivery Address";
            // 
            // address1Text
            // 
            this.address1Text.AutoSize = true;
            this.address1Text.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1Text.ForeColor = System.Drawing.Color.White;
            this.address1Text.Location = new System.Drawing.Point(293, 225);
            this.address1Text.Name = "address1Text";
            this.address1Text.Size = new System.Drawing.Size(68, 20);
            this.address1Text.TabIndex = 48;
            this.address1Text.Text = "Address1";
            // 
            // address2Text
            // 
            this.address2Text.AutoSize = true;
            this.address2Text.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2Text.ForeColor = System.Drawing.Color.White;
            this.address2Text.Location = new System.Drawing.Point(293, 250);
            this.address2Text.Name = "address2Text";
            this.address2Text.Size = new System.Drawing.Size(70, 20);
            this.address2Text.TabIndex = 49;
            this.address2Text.Text = "Address2";
            // 
            // address3Text
            // 
            this.address3Text.AutoSize = true;
            this.address3Text.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address3Text.ForeColor = System.Drawing.Color.White;
            this.address3Text.Location = new System.Drawing.Point(293, 281);
            this.address3Text.Name = "address3Text";
            this.address3Text.Size = new System.Drawing.Size(70, 20);
            this.address3Text.TabIndex = 50;
            this.address3Text.Text = "Address3";
            // 
            // postCodeText
            // 
            this.postCodeText.AutoSize = true;
            this.postCodeText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postCodeText.ForeColor = System.Drawing.Color.White;
            this.postCodeText.Location = new System.Drawing.Point(291, 316);
            this.postCodeText.Name = "postCodeText";
            this.postCodeText.Size = new System.Drawing.Size(86, 23);
            this.postCodeText.TabIndex = 51;
            this.postCodeText.Text = "PostCode";
            // 
            // emailButton
            // 
            this.emailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailButton.ForeColor = System.Drawing.Color.White;
            this.emailButton.Location = new System.Drawing.Point(925, 299);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(146, 52);
            this.emailButton.TabIndex = 52;
            this.emailButton.Text = "EMAIL";
            this.emailButton.UseVisualStyleBackColor = true;
            // 
            // resetPasswordButton
            // 
            this.resetPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetPasswordButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPasswordButton.ForeColor = System.Drawing.Color.White;
            this.resetPasswordButton.Location = new System.Drawing.Point(925, 241);
            this.resetPasswordButton.Name = "resetPasswordButton";
            this.resetPasswordButton.Size = new System.Drawing.Size(146, 52);
            this.resetPasswordButton.TabIndex = 53;
            this.resetPasswordButton.Text = "RESET PASSWORD";
            this.resetPasswordButton.UseVisualStyleBackColor = true;
            this.resetPasswordButton.Click += new System.EventHandler(this.resetPasswordButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(873, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 45);
            this.label4.TabIndex = 54;
            this.label4.Text = "CUSTOMERS";
            // 
            // spentCaption
            // 
            this.spentCaption.AutoSize = true;
            this.spentCaption.BackColor = System.Drawing.Color.Transparent;
            this.spentCaption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spentCaption.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spentCaption.ForeColor = System.Drawing.Color.Gray;
            this.spentCaption.Location = new System.Drawing.Point(999, 135);
            this.spentCaption.Name = "spentCaption";
            this.spentCaption.Size = new System.Drawing.Size(62, 26);
            this.spentCaption.TabIndex = 55;
            this.spentCaption.Text = "Spent";
            this.spentCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guestSpendingText
            // 
            this.guestSpendingText.AutoSize = true;
            this.guestSpendingText.BackColor = System.Drawing.Color.Transparent;
            this.guestSpendingText.Font = new System.Drawing.Font("Impact", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestSpendingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guestSpendingText.Location = new System.Drawing.Point(821, 103);
            this.guestSpendingText.Name = "guestSpendingText";
            this.guestSpendingText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guestSpendingText.Size = new System.Drawing.Size(37, 65);
            this.guestSpendingText.TabIndex = 56;
            this.guestSpendingText.Text = " ";
            this.guestSpendingText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gStaticMap1
            // 
            
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1083, 539);
            
            this.Controls.Add(this.spentCaption);
            this.Controls.Add(this.guestSpendingText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resetPasswordButton);
            this.Controls.Add(this.emailButton);
            this.Controls.Add(this.postCodeText);
            this.Controls.Add(this.address3Text);
            this.Controls.Add(this.address2Text);
            this.Controls.Add(this.address1Text);
            this.Controls.Add(this.addressCaption);
            this.Controls.Add(this.tierProgressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastActiveText);
            this.Controls.Add(this.registeredText);
            this.Controls.Add(this.telephoneText);
            this.Controls.Add(this.tierCaption);
            this.Controls.Add(this.tierText);
            this.Controls.Add(this.ordersCaption);
            this.Controls.Add(this.ordersText);
            this.Controls.Add(this.newCustomerButton);
            this.Controls.Add(this.bannedCustomersText);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.suspendedCustomersText);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.inactiveCustomersText);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.statusChangedText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.statusBannedButton);
            this.Controls.Add(this.statusSuspendedButton);
            this.Controls.Add(this.statusInactiveButton);
            this.Controls.Add(this.statusActiveButton);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.activeCustomersText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.customersList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Activated += new System.EventHandler(this.OnCustomersActivated);
            this.Load += new System.EventHandler(this.Customers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox customersList;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label activeCustomersText;
        private System.Windows.Forms.Label firstNameText;
        private System.Windows.Forms.Label emailText;
        private System.Windows.Forms.Label tierCaption;
        private System.Windows.Forms.Button statusActiveButton;
        private System.Windows.Forms.Button statusInactiveButton;
        private System.Windows.Forms.Button statusBannedButton;
        private System.Windows.Forms.Button statusSuspendedButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label statusChangedText;
        private System.Windows.Forms.RichTextBox notesTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label inactiveCustomersText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label suspendedCustomersText;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label bannedCustomersText;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button newCustomerButton;
        private System.Windows.Forms.Label ordersText;
        private System.Windows.Forms.Label tierText;
        private System.Windows.Forms.Label ordersCaption;
        private System.Windows.Forms.Label telephoneText;
        private System.Windows.Forms.Label registeredText;
        private System.Windows.Forms.Label lastActiveText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar tierProgressBar;
        private System.Windows.Forms.Label addressCaption;
        private System.Windows.Forms.Label address1Text;
        private System.Windows.Forms.Label address2Text;
        private System.Windows.Forms.Label address3Text;
        private System.Windows.Forms.Label postCodeText;
        private System.Windows.Forms.Button emailButton;
        private System.Windows.Forms.Button resetPasswordButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label spentCaption;
        private System.Windows.Forms.Label guestSpendingText;
        
    }
}