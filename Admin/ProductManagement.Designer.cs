
namespace Admin
{
    partial class ProductManagement
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
            this.closeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.productList = new System.Windows.Forms.ListBox();
            this.foodButton = new System.Windows.Forms.Button();
            this.drinkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.productNameText = new System.Windows.Forms.Label();
            this.categoryText = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shortDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.longDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.availableYesButton = new System.Windows.Forms.Button();
            this.availableNoButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.soldText = new System.Windows.Forms.Label();
            this.newProductButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.lastSoldText = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.availableFrom = new System.Windows.Forms.DateTimePicker();
            this.availableTo = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.allergensList = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buyPriceTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.productImage = new System.Windows.Forms.PictureBox();
            this.categoryAddButton = new System.Windows.Forms.Button();
            this.vegetarianNoButton = new System.Windows.Forms.Button();
            this.vegetarianYesButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.veganNoButton = new System.Windows.Forms.Button();
            this.veganYesButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.Label();
            this.statusInfoIcon = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusInfoIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(942, 560);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(154, 52);
            this.closeButton.TabIndex = 28;
            this.closeButton.Text = "CLOSE";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(734, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(362, 45);
            this.label4.TabIndex = 55;
            this.label4.Text = "PRODUCT MANAGEMENT";
            // 
            // productList
            // 
            this.productList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productList.ForeColor = System.Drawing.Color.White;
            this.productList.FormattingEnabled = true;
            this.productList.ItemHeight = 20;
            this.productList.Location = new System.Drawing.Point(12, 91);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(297, 500);
            this.productList.TabIndex = 56;
            this.productList.SelectedIndexChanged += new System.EventHandler(this.productList_SelectedIndexChanged);
            // 
            // foodButton
            // 
            this.foodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foodButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodButton.ForeColor = System.Drawing.Color.White;
            this.foodButton.Location = new System.Drawing.Point(12, 13);
            this.foodButton.Name = "foodButton";
            this.foodButton.Size = new System.Drawing.Size(150, 52);
            this.foodButton.TabIndex = 57;
            this.foodButton.Text = "FOOD";
            this.foodButton.UseVisualStyleBackColor = true;
            this.foodButton.Click += new System.EventHandler(this.foodButton_Click);
            // 
            // drinkButton
            // 
            this.drinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drinkButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkButton.ForeColor = System.Drawing.Color.White;
            this.drinkButton.Location = new System.Drawing.Point(168, 13);
            this.drinkButton.Name = "drinkButton";
            this.drinkButton.Size = new System.Drawing.Size(141, 52);
            this.drinkButton.TabIndex = 58;
            this.drinkButton.Text = "DRINK";
            this.drinkButton.UseVisualStyleBackColor = true;
            this.drinkButton.Click += new System.EventHandler(this.drinkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 60;
            this.label1.Text = "Search:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.searchTextBox.Location = new System.Drawing.Point(72, 71);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(237, 19);
            this.searchTextBox.TabIndex = 59;
            this.searchTextBox.TextChanged += new System.EventHandler(this.OnSearchTextChanged);
            // 
            // productNameText
            // 
            this.productNameText.AutoSize = true;
            this.productNameText.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameText.ForeColor = System.Drawing.Color.White;
            this.productNameText.Location = new System.Drawing.Point(326, 71);
            this.productNameText.Name = "productNameText";
            this.productNameText.Size = new System.Drawing.Size(244, 45);
            this.productNameText.TabIndex = 61;
            this.productNameText.Text = "PRODUCT NAME";
            // 
            // categoryText
            // 
            this.categoryText.AutoSize = true;
            this.categoryText.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryText.ForeColor = System.Drawing.Color.DimGray;
            this.categoryText.Location = new System.Drawing.Point(326, 116);
            this.categoryText.Name = "categoryText";
            this.categoryText.Size = new System.Drawing.Size(243, 36);
            this.categoryText.TabIndex = 62;
            this.categoryText.Text = "PRODUCT CATEGORY";
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTextBox.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.ForeColor = System.Drawing.Color.White;
            this.priceTextBox.Location = new System.Drawing.Point(629, 356);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(82, 33);
            this.priceTextBox.TabIndex = 63;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            this.priceTextBox.Leave += new System.EventHandler(this.OnSellPriceLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(583, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 45);
            this.label2.TabIndex = 64;
            this.label2.Text = "£";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // shortDescriptionTextBox
            // 
            this.shortDescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.shortDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shortDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortDescriptionTextBox.ForeColor = System.Drawing.Color.White;
            this.shortDescriptionTextBox.Location = new System.Drawing.Point(498, 185);
            this.shortDescriptionTextBox.Name = "shortDescriptionTextBox";
            this.shortDescriptionTextBox.Size = new System.Drawing.Size(429, 19);
            this.shortDescriptionTextBox.TabIndex = 65;
            this.shortDescriptionTextBox.TextChanged += new System.EventHandler(this.shortDescriptionTextBox_TextChanged);
            this.shortDescriptionTextBox.Leave += new System.EventHandler(this.OnShortDescriptionLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(330, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 23);
            this.label3.TabIndex = 66;
            this.label3.Text = "SHORT DESCRIPTION";
            // 
            // longDescriptionTextBox
            // 
            this.longDescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.longDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.longDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longDescriptionTextBox.ForeColor = System.Drawing.Color.White;
            this.longDescriptionTextBox.Location = new System.Drawing.Point(498, 210);
            this.longDescriptionTextBox.Name = "longDescriptionTextBox";
            this.longDescriptionTextBox.Size = new System.Drawing.Size(429, 63);
            this.longDescriptionTextBox.TabIndex = 67;
            this.longDescriptionTextBox.Text = "";
            this.longDescriptionTextBox.TextChanged += new System.EventHandler(this.longDescriptionTextBox_TextChanged);
            this.longDescriptionTextBox.Leave += new System.EventHandler(this.OnLongDescriptionLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(343, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 23);
            this.label5.TabIndex = 68;
            this.label5.Text = "LONG DESCRIPTION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(408, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 70;
            this.label6.Text = "AVAILABLE";
            // 
            // availableYesButton
            // 
            this.availableYesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availableYesButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableYesButton.ForeColor = System.Drawing.Color.White;
            this.availableYesButton.Location = new System.Drawing.Point(498, 304);
            this.availableYesButton.Name = "availableYesButton";
            this.availableYesButton.Size = new System.Drawing.Size(82, 34);
            this.availableYesButton.TabIndex = 71;
            this.availableYesButton.Text = "YES";
            this.availableYesButton.UseVisualStyleBackColor = true;
            this.availableYesButton.Click += new System.EventHandler(this.availableYesButton_Click);
            // 
            // availableNoButton
            // 
            this.availableNoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availableNoButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableNoButton.ForeColor = System.Drawing.Color.White;
            this.availableNoButton.Location = new System.Drawing.Point(586, 304);
            this.availableNoButton.Name = "availableNoButton";
            this.availableNoButton.Size = new System.Drawing.Size(82, 34);
            this.availableNoButton.TabIndex = 72;
            this.availableNoButton.Text = "NO";
            this.availableNoButton.UseVisualStyleBackColor = true;
            this.availableNoButton.Click += new System.EventHandler(this.availableNoButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(411, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 74;
            this.label7.Text = "REMARKS";
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.remarksTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.remarksTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarksTextBox.ForeColor = System.Drawing.Color.White;
            this.remarksTextBox.Location = new System.Drawing.Point(498, 279);
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(429, 19);
            this.remarksTextBox.TabIndex = 73;
            this.remarksTextBox.TextChanged += new System.EventHandler(this.remarksTextBox_TextChanged);
            this.remarksTextBox.Leave += new System.EventHandler(this.OnRemarksLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(992, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 36);
            this.label8.TabIndex = 75;
            this.label8.Text = "SOLD";
            // 
            // soldText
            // 
            this.soldText.AutoSize = true;
            this.soldText.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldText.ForeColor = System.Drawing.Color.DimGray;
            this.soldText.Location = new System.Drawing.Point(932, 54);
            this.soldText.Name = "soldText";
            this.soldText.Size = new System.Drawing.Size(51, 60);
            this.soldText.TabIndex = 76;
            this.soldText.Text = "0";
            // 
            // newProductButton
            // 
            this.newProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newProductButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProductButton.ForeColor = System.Drawing.Color.White;
            this.newProductButton.Location = new System.Drawing.Point(942, 502);
            this.newProductButton.Name = "newProductButton";
            this.newProductButton.Size = new System.Drawing.Size(154, 52);
            this.newProductButton.TabIndex = 77;
            this.newProductButton.Text = "NEW PRODUCT";
            this.newProductButton.UseVisualStyleBackColor = true;
            this.newProductButton.Click += new System.EventHandler(this.newProductButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.IndianRed;
            this.deleteButton.Location = new System.Drawing.Point(942, 444);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(154, 52);
            this.deleteButton.TabIndex = 78;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // lastSoldText
            // 
            this.lastSoldText.AutoSize = true;
            this.lastSoldText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastSoldText.ForeColor = System.Drawing.Color.DimGray;
            this.lastSoldText.Location = new System.Drawing.Point(938, 139);
            this.lastSoldText.Name = "lastSoldText";
            this.lastSoldText.Size = new System.Drawing.Size(20, 23);
            this.lastSoldText.TabIndex = 80;
            this.lastSoldText.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(938, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 23);
            this.label10.TabIndex = 79;
            this.label10.Text = "LAST SOLD";
            // 
            // availableFrom
            // 
            this.availableFrom.AllowDrop = true;
            this.availableFrom.CalendarFont = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableFrom.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.availableFrom.Checked = false;
            this.availableFrom.CustomFormat = "HH:mm";
            this.availableFrom.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.availableFrom.Location = new System.Drawing.Point(726, 304);
            this.availableFrom.Name = "availableFrom";
            this.availableFrom.ShowUpDown = true;
            this.availableFrom.Size = new System.Drawing.Size(78, 31);
            this.availableFrom.TabIndex = 81;
            this.availableFrom.ValueChanged += new System.EventHandler(this.availableFrom_ValueChanged);
            // 
            // availableTo
            // 
            this.availableTo.AllowDrop = true;
            this.availableTo.CalendarFont = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableTo.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.availableTo.Checked = false;
            this.availableTo.CustomFormat = "HH:mm";
            this.availableTo.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.availableTo.Location = new System.Drawing.Point(849, 304);
            this.availableTo.Name = "availableTo";
            this.availableTo.ShowUpDown = true;
            this.availableTo.Size = new System.Drawing.Size(78, 31);
            this.availableTo.TabIndex = 82;
            this.availableTo.ValueChanged += new System.EventHandler(this.availableTo_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(674, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 23);
            this.label9.TabIndex = 83;
            this.label9.Text = "FROM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(814, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 23);
            this.label11.TabIndex = 84;
            this.label11.Text = "TO";
            // 
            // allergensList
            // 
            this.allergensList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.allergensList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allergensList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allergensList.ForeColor = System.Drawing.Color.White;
            this.allergensList.FormattingEnabled = true;
            this.allergensList.ItemHeight = 15;
            this.allergensList.Location = new System.Drawing.Point(942, 205);
            this.allergensList.Name = "allergensList";
            this.allergensList.Size = new System.Drawing.Size(154, 225);
            this.allergensList.TabIndex = 85;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(799, 347);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 45);
            this.label12.TabIndex = 87;
            this.label12.Text = "£";
            // 
            // buyPriceTextBox
            // 
            this.buyPriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buyPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.buyPriceTextBox.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyPriceTextBox.ForeColor = System.Drawing.Color.White;
            this.buyPriceTextBox.Location = new System.Drawing.Point(845, 356);
            this.buyPriceTextBox.Name = "buyPriceTextBox";
            this.buyPriceTextBox.Size = new System.Drawing.Size(82, 33);
            this.buyPriceTextBox.TabIndex = 86;
            this.buyPriceTextBox.Leave += new System.EventHandler(this.OnBuyPriceLeave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(717, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 23);
            this.label13.TabIndex = 88;
            this.label13.Text = "BUY PRICE";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(494, 365);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 23);
            this.label14.TabIndex = 89;
            this.label14.Text = "SELL PRICE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(938, 182);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 23);
            this.label15.TabIndex = 90;
            this.label15.Text = "ALLERGENS";
            // 
            // productImage
            // 
            this.productImage.Location = new System.Drawing.Point(498, 395);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(429, 217);
            this.productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productImage.TabIndex = 69;
            this.productImage.TabStop = false;
            this.productImage.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.OnProductImageLoadComplete);
            // 
            // categoryAddButton
            // 
            this.categoryAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryAddButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryAddButton.ForeColor = System.Drawing.Color.GreenYellow;
            this.categoryAddButton.Location = new System.Drawing.Point(1033, 164);
            this.categoryAddButton.Name = "categoryAddButton";
            this.categoryAddButton.Size = new System.Drawing.Size(63, 35);
            this.categoryAddButton.TabIndex = 91;
            this.categoryAddButton.Text = "EDIT";
            this.categoryAddButton.UseVisualStyleBackColor = true;
            this.categoryAddButton.Click += new System.EventHandler(this.categoryAddButton_Click);
            // 
            // vegetarianNoButton
            // 
            this.vegetarianNoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vegetarianNoButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vegetarianNoButton.ForeColor = System.Drawing.Color.White;
            this.vegetarianNoButton.Location = new System.Drawing.Point(402, 391);
            this.vegetarianNoButton.Name = "vegetarianNoButton";
            this.vegetarianNoButton.Size = new System.Drawing.Size(82, 34);
            this.vegetarianNoButton.TabIndex = 94;
            this.vegetarianNoButton.Text = "NO";
            this.vegetarianNoButton.UseVisualStyleBackColor = true;
            this.vegetarianNoButton.Click += new System.EventHandler(this.vegetarianNoButton_Click);
            // 
            // vegetarianYesButton
            // 
            this.vegetarianYesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vegetarianYesButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vegetarianYesButton.ForeColor = System.Drawing.Color.White;
            this.vegetarianYesButton.Location = new System.Drawing.Point(315, 391);
            this.vegetarianYesButton.Name = "vegetarianYesButton";
            this.vegetarianYesButton.Size = new System.Drawing.Size(81, 34);
            this.vegetarianYesButton.TabIndex = 93;
            this.vegetarianYesButton.Text = "YES";
            this.vegetarianYesButton.UseVisualStyleBackColor = true;
            this.vegetarianYesButton.Click += new System.EventHandler(this.vegetarianYesButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(359, 365);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 23);
            this.label16.TabIndex = 92;
            this.label16.Text = "VEGETARIAN";
            // 
            // veganNoButton
            // 
            this.veganNoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.veganNoButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veganNoButton.ForeColor = System.Drawing.Color.White;
            this.veganNoButton.Location = new System.Drawing.Point(402, 467);
            this.veganNoButton.Name = "veganNoButton";
            this.veganNoButton.Size = new System.Drawing.Size(82, 34);
            this.veganNoButton.TabIndex = 97;
            this.veganNoButton.Text = "NO";
            this.veganNoButton.UseVisualStyleBackColor = true;
            this.veganNoButton.Click += new System.EventHandler(this.veganNoButton_Click);
            // 
            // veganYesButton
            // 
            this.veganYesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.veganYesButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veganYesButton.ForeColor = System.Drawing.Color.White;
            this.veganYesButton.Location = new System.Drawing.Point(315, 467);
            this.veganYesButton.Name = "veganYesButton";
            this.veganYesButton.Size = new System.Drawing.Size(81, 34);
            this.veganYesButton.TabIndex = 96;
            this.veganYesButton.Text = "YES";
            this.veganYesButton.UseVisualStyleBackColor = true;
            this.veganYesButton.Click += new System.EventHandler(this.veganYesButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(373, 441);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 23);
            this.label17.TabIndex = 95;
            this.label17.Text = "VEGAN";
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusText.ForeColor = System.Drawing.Color.White;
            this.statusText.Location = new System.Drawing.Point(47, 601);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(87, 19);
            this.statusText.TabIndex = 98;
            this.statusText.Text = "STATUS_TEXT";
            // 
            // statusInfoIcon
            // 
            this.statusInfoIcon.Image = global::Admin.Properties.Resources.info;
            this.statusInfoIcon.Location = new System.Drawing.Point(12, 596);
            this.statusInfoIcon.Name = "statusInfoIcon";
            this.statusInfoIcon.Size = new System.Drawing.Size(29, 30);
            this.statusInfoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusInfoIcon.TabIndex = 99;
            this.statusInfoIcon.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(402, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 43);
            this.button1.TabIndex = 115;
            this.button1.Text = "SPECIALS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1108, 624);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusInfoIcon);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.veganNoButton);
            this.Controls.Add(this.veganYesButton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.vegetarianNoButton);
            this.Controls.Add(this.vegetarianYesButton);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.categoryAddButton);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buyPriceTextBox);
            this.Controls.Add(this.allergensList);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.availableTo);
            this.Controls.Add(this.availableFrom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lastSoldText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.newProductButton);
            this.Controls.Add(this.soldText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.remarksTextBox);
            this.Controls.Add(this.availableNoButton);
            this.Controls.Add(this.availableYesButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.longDescriptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shortDescriptionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.categoryText);
            this.Controls.Add(this.productNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.drinkButton);
            this.Controls.Add(this.foodButton);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.productImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Management";
            this.Activated += new System.EventHandler(this.OnProductManagementActivated);
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusInfoIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox productList;
        private System.Windows.Forms.Button foodButton;
        private System.Windows.Forms.Button drinkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label productNameText;
        private System.Windows.Forms.Label categoryText;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox shortDescriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox longDescriptionTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button availableYesButton;
        private System.Windows.Forms.Button availableNoButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label soldText;
        private System.Windows.Forms.Button newProductButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label lastSoldText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker availableFrom;
        private System.Windows.Forms.DateTimePicker availableTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox allergensList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox buyPriceTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button categoryAddButton;
        private System.Windows.Forms.Button vegetarianNoButton;
        private System.Windows.Forms.Button vegetarianYesButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button veganNoButton;
        private System.Windows.Forms.Button veganYesButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.PictureBox statusInfoIcon;
        private System.Windows.Forms.Button button1;
    }
}