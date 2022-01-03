
namespace Admin
{
    partial class OrderDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.captionText = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.customerNameText = new System.Windows.Forms.Label();
            this.customerEmailText = new System.Windows.Forms.Label();
            this.customerPhoneText = new System.Windows.Forms.Label();
            this.customerAddressText = new System.Windows.Forms.Label();
            this.customerPostCodeText = new System.Windows.Forms.Label();
            this.customerDetailText = new System.Windows.Forms.Label();
            this.orderCreatedText = new System.Windows.Forms.Label();
            this.orderStatusText = new System.Windows.Forms.Label();
            this.productList = new System.Windows.Forms.DataGridView();
            this.ProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDeliveryFeeText = new System.Windows.Forms.Label();
            this.orderTotalText = new System.Windows.Forms.Label();
            this.orderJustTotalText = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.inTheKitchenButton = new System.Windows.Forms.Button();
            this.onTheWayButton = new System.Windows.Forms.Button();
            this.finishedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productList)).BeginInit();
            this.SuspendLayout();
            // 
            // captionText
            // 
            this.captionText.AutoSize = true;
            this.captionText.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionText.ForeColor = System.Drawing.Color.White;
            this.captionText.Location = new System.Drawing.Point(498, 0);
            this.captionText.Name = "captionText";
            this.captionText.Size = new System.Drawing.Size(217, 45);
            this.captionText.TabIndex = 73;
            this.captionText.Text = "ORDER DETAIL";
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(605, 389);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(146, 52);
            this.closeButton.TabIndex = 74;
            this.closeButton.Text = "CLOSE";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 34);
            this.label5.TabIndex = 101;
            this.label5.Text = "CUSTOMER";
            // 
            // customerNameText
            // 
            this.customerNameText.AutoSize = true;
            this.customerNameText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameText.ForeColor = System.Drawing.Color.DarkOrange;
            this.customerNameText.Location = new System.Drawing.Point(14, 47);
            this.customerNameText.Name = "customerNameText";
            this.customerNameText.Size = new System.Drawing.Size(144, 23);
            this.customerNameText.TabIndex = 102;
            this.customerNameText.Text = "CUSTOMER_NAME";
            // 
            // customerEmailText
            // 
            this.customerEmailText.AutoSize = true;
            this.customerEmailText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerEmailText.ForeColor = System.Drawing.Color.DarkGray;
            this.customerEmailText.Location = new System.Drawing.Point(14, 119);
            this.customerEmailText.Name = "customerEmailText";
            this.customerEmailText.Size = new System.Drawing.Size(146, 23);
            this.customerEmailText.TabIndex = 103;
            this.customerEmailText.Text = "CUSTOMER_EMAIL";
            // 
            // customerPhoneText
            // 
            this.customerPhoneText.AutoSize = true;
            this.customerPhoneText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPhoneText.ForeColor = System.Drawing.Color.DimGray;
            this.customerPhoneText.Location = new System.Drawing.Point(14, 142);
            this.customerPhoneText.Name = "customerPhoneText";
            this.customerPhoneText.Size = new System.Drawing.Size(152, 23);
            this.customerPhoneText.TabIndex = 104;
            this.customerPhoneText.Text = "CUSTOMER_PHONE";
            // 
            // customerAddressText
            // 
            this.customerAddressText.AutoSize = true;
            this.customerAddressText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddressText.ForeColor = System.Drawing.Color.DarkGray;
            this.customerAddressText.Location = new System.Drawing.Point(14, 165);
            this.customerAddressText.Name = "customerAddressText";
            this.customerAddressText.Size = new System.Drawing.Size(172, 23);
            this.customerAddressText.TabIndex = 105;
            this.customerAddressText.Text = "CUSTOMER_ADDRESS";
            // 
            // customerPostCodeText
            // 
            this.customerPostCodeText.AutoSize = true;
            this.customerPostCodeText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPostCodeText.ForeColor = System.Drawing.Color.DimGray;
            this.customerPostCodeText.Location = new System.Drawing.Point(14, 188);
            this.customerPostCodeText.Name = "customerPostCodeText";
            this.customerPostCodeText.Size = new System.Drawing.Size(182, 23);
            this.customerPostCodeText.TabIndex = 106;
            this.customerPostCodeText.Text = "CUSTOMER_POSTCODE";
            // 
            // customerDetailText
            // 
            this.customerDetailText.AutoSize = true;
            this.customerDetailText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDetailText.ForeColor = System.Drawing.Color.DimGray;
            this.customerDetailText.Location = new System.Drawing.Point(14, 70);
            this.customerDetailText.Name = "customerDetailText";
            this.customerDetailText.Size = new System.Drawing.Size(151, 23);
            this.customerDetailText.TabIndex = 107;
            this.customerDetailText.Text = "CUSTOMER_DETAIL";
            // 
            // orderCreatedText
            // 
            this.orderCreatedText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orderCreatedText.AutoSize = true;
            this.orderCreatedText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCreatedText.ForeColor = System.Drawing.Color.DimGray;
            this.orderCreatedText.Location = new System.Drawing.Point(502, 70);
            this.orderCreatedText.Name = "orderCreatedText";
            this.orderCreatedText.Size = new System.Drawing.Size(135, 23);
            this.orderCreatedText.TabIndex = 108;
            this.orderCreatedText.Text = "ORDER_CREATED";
            this.orderCreatedText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // orderStatusText
            // 
            this.orderStatusText.AutoSize = true;
            this.orderStatusText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderStatusText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.orderStatusText.Location = new System.Drawing.Point(502, 47);
            this.orderStatusText.Name = "orderStatusText";
            this.orderStatusText.Size = new System.Drawing.Size(125, 23);
            this.orderStatusText.TabIndex = 109;
            this.orderStatusText.Text = "ORDER_STATUS";
            // 
            // productList
            // 
            this.productList.AllowUserToAddRows = false;
            this.productList.AllowUserToDeleteRows = false;
            this.productList.AllowUserToResizeColumns = false;
            this.productList.AllowUserToResizeRows = false;
            this.productList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.productList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.productList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductColumn,
            this.QuantityColumn,
            this.PriceColumn,
            this.TotalColumn});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productList.DefaultCellStyle = dataGridViewCellStyle14;
            this.productList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productList.EnableHeadersVisualStyles = false;
            this.productList.GridColor = System.Drawing.Color.Black;
            this.productList.Location = new System.Drawing.Point(18, 225);
            this.productList.MultiSelect = false;
            this.productList.Name = "productList";
            this.productList.ReadOnly = true;
            this.productList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.productList.RowHeadersVisible = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productList.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.productList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.productList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.productList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.productList.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productList.Size = new System.Drawing.Size(571, 216);
            this.productList.TabIndex = 110;
            this.productList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onTheWayList_CellContentClick);
            // 
            // ProductColumn
            // 
            this.ProductColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductColumn.HeaderText = "Product";
            this.ProductColumn.Name = "ProductColumn";
            this.ProductColumn.ReadOnly = true;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            // 
            // TotalColumn
            // 
            this.TotalColumn.HeaderText = "Total";
            this.TotalColumn.Name = "TotalColumn";
            this.TotalColumn.ReadOnly = true;
            // 
            // orderDeliveryFeeText
            // 
            this.orderDeliveryFeeText.AutoSize = true;
            this.orderDeliveryFeeText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDeliveryFeeText.ForeColor = System.Drawing.Color.DarkGray;
            this.orderDeliveryFeeText.Location = new System.Drawing.Point(502, 142);
            this.orderDeliveryFeeText.Name = "orderDeliveryFeeText";
            this.orderDeliveryFeeText.Size = new System.Drawing.Size(161, 23);
            this.orderDeliveryFeeText.TabIndex = 111;
            this.orderDeliveryFeeText.Text = "ORDER_DELIVERYFEE";
            // 
            // orderTotalText
            // 
            this.orderTotalText.AutoSize = true;
            this.orderTotalText.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTotalText.ForeColor = System.Drawing.Color.White;
            this.orderTotalText.Location = new System.Drawing.Point(500, 179);
            this.orderTotalText.Name = "orderTotalText";
            this.orderTotalText.Size = new System.Drawing.Size(77, 34);
            this.orderTotalText.TabIndex = 112;
            this.orderTotalText.Text = "TOTAL";
            // 
            // orderJustTotalText
            // 
            this.orderJustTotalText.AutoSize = true;
            this.orderJustTotalText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderJustTotalText.ForeColor = System.Drawing.Color.DimGray;
            this.orderJustTotalText.Location = new System.Drawing.Point(502, 119);
            this.orderJustTotalText.Name = "orderJustTotalText";
            this.orderJustTotalText.Size = new System.Drawing.Size(113, 23);
            this.orderJustTotalText.TabIndex = 113;
            this.orderJustTotalText.Text = "ORDER_TOTAL";
            // 
            // newOrderButton
            // 
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.ForeColor = System.Drawing.Color.DimGray;
            this.newOrderButton.Location = new System.Drawing.Point(605, 225);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(146, 35);
            this.newOrderButton.TabIndex = 114;
            this.newOrderButton.Text = "NEW ORDER";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // inTheKitchenButton
            // 
            this.inTheKitchenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inTheKitchenButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inTheKitchenButton.ForeColor = System.Drawing.Color.DimGray;
            this.inTheKitchenButton.Location = new System.Drawing.Point(605, 266);
            this.inTheKitchenButton.Name = "inTheKitchenButton";
            this.inTheKitchenButton.Size = new System.Drawing.Size(146, 35);
            this.inTheKitchenButton.TabIndex = 115;
            this.inTheKitchenButton.Text = "IN THE KITCHEN";
            this.inTheKitchenButton.UseVisualStyleBackColor = true;
            this.inTheKitchenButton.Click += new System.EventHandler(this.inTheKitchenButton_Click);
            // 
            // onTheWayButton
            // 
            this.onTheWayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onTheWayButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onTheWayButton.ForeColor = System.Drawing.Color.DimGray;
            this.onTheWayButton.Location = new System.Drawing.Point(605, 307);
            this.onTheWayButton.Name = "onTheWayButton";
            this.onTheWayButton.Size = new System.Drawing.Size(146, 35);
            this.onTheWayButton.TabIndex = 116;
            this.onTheWayButton.Text = "ON THE WAY";
            this.onTheWayButton.UseVisualStyleBackColor = true;
            this.onTheWayButton.Click += new System.EventHandler(this.onTheWayButton_Click);
            // 
            // finishedButton
            // 
            this.finishedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishedButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishedButton.ForeColor = System.Drawing.Color.DimGray;
            this.finishedButton.Location = new System.Drawing.Point(605, 348);
            this.finishedButton.Name = "finishedButton";
            this.finishedButton.Size = new System.Drawing.Size(146, 35);
            this.finishedButton.TabIndex = 117;
            this.finishedButton.Text = "FINISHED";
            this.finishedButton.UseVisualStyleBackColor = true;
            this.finishedButton.Click += new System.EventHandler(this.finishedButton_Click);
            // 
            // OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(763, 453);
            this.Controls.Add(this.finishedButton);
            this.Controls.Add(this.onTheWayButton);
            this.Controls.Add(this.inTheKitchenButton);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.orderJustTotalText);
            this.Controls.Add(this.orderTotalText);
            this.Controls.Add(this.orderDeliveryFeeText);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.orderStatusText);
            this.Controls.Add(this.orderCreatedText);
            this.Controls.Add(this.customerDetailText);
            this.Controls.Add(this.customerPostCodeText);
            this.Controls.Add(this.customerAddressText);
            this.Controls.Add(this.customerPhoneText);
            this.Controls.Add(this.customerEmailText);
            this.Controls.Add(this.customerNameText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.captionText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Detail";
            this.Load += new System.EventHandler(this.OrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label captionText;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label customerNameText;
        private System.Windows.Forms.Label customerEmailText;
        private System.Windows.Forms.Label customerPhoneText;
        private System.Windows.Forms.Label customerAddressText;
        private System.Windows.Forms.Label customerPostCodeText;
        private System.Windows.Forms.Label customerDetailText;
        private System.Windows.Forms.Label orderCreatedText;
        private System.Windows.Forms.Label orderStatusText;
        private System.Windows.Forms.DataGridView productList;
        private System.Windows.Forms.Label orderDeliveryFeeText;
        private System.Windows.Forms.Label orderTotalText;
        private System.Windows.Forms.Label orderJustTotalText;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalColumn;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button inTheKitchenButton;
        private System.Windows.Forms.Button onTheWayButton;
        private System.Windows.Forms.Button finishedButton;
    }
}