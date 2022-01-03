
namespace Admin
{
    partial class NewCategory
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
            this.categoryAddButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.newProductCaption = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drinkButton = new System.Windows.Forms.Button();
            this.foodButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categoryAddButton
            // 
            this.categoryAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryAddButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryAddButton.ForeColor = System.Drawing.Color.GreenYellow;
            this.categoryAddButton.Location = new System.Drawing.Point(63, 177);
            this.categoryAddButton.Name = "categoryAddButton";
            this.categoryAddButton.Size = new System.Drawing.Size(157, 52);
            this.categoryAddButton.TabIndex = 70;
            this.categoryAddButton.Text = "ADD";
            this.categoryAddButton.UseVisualStyleBackColor = true;
            this.categoryAddButton.Click += new System.EventHandler(this.categoryAddButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(226, 177);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(129, 52);
            this.closeButton.TabIndex = 69;
            this.closeButton.Text = "CLOSE";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // newProductCaption
            // 
            this.newProductCaption.AutoSize = true;
            this.newProductCaption.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProductCaption.ForeColor = System.Drawing.Color.White;
            this.newProductCaption.Location = new System.Drawing.Point(117, 9);
            this.newProductCaption.Name = "newProductCaption";
            this.newProductCaption.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newProductCaption.Size = new System.Drawing.Size(238, 45);
            this.newProductCaption.TabIndex = 71;
            this.newProductCaption.Text = "NEW CATEGORY";
            this.newProductCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 26);
            this.label2.TabIndex = 77;
            this.label2.Text = "NAME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.categoryNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoryNameTextBox.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNameTextBox.ForeColor = System.Drawing.Color.White;
            this.categoryNameTextBox.Location = new System.Drawing.Point(75, 76);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(280, 26);
            this.categoryNameTextBox.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(16, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 78;
            this.label1.Text = "TYPE";
            // 
            // drinkButton
            // 
            this.drinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drinkButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkButton.ForeColor = System.Drawing.Color.White;
            this.drinkButton.Location = new System.Drawing.Point(243, 116);
            this.drinkButton.Name = "drinkButton";
            this.drinkButton.Size = new System.Drawing.Size(112, 40);
            this.drinkButton.TabIndex = 107;
            this.drinkButton.Text = "DRINK";
            this.drinkButton.UseVisualStyleBackColor = true;
            this.drinkButton.Click += new System.EventHandler(this.drinkButton_Click);
            // 
            // foodButton
            // 
            this.foodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foodButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodButton.ForeColor = System.Drawing.Color.White;
            this.foodButton.Location = new System.Drawing.Point(125, 116);
            this.foodButton.Name = "foodButton";
            this.foodButton.Size = new System.Drawing.Size(112, 40);
            this.foodButton.TabIndex = 106;
            this.foodButton.Text = "FOOD";
            this.foodButton.UseVisualStyleBackColor = true;
            this.foodButton.Click += new System.EventHandler(this.foodButton_Click);
            // 
            // NewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(375, 244);
            this.Controls.Add(this.drinkButton);
            this.Controls.Add(this.foodButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryNameTextBox);
            this.Controls.Add(this.newProductCaption);
            this.Controls.Add(this.categoryAddButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Category";
            this.Load += new System.EventHandler(this.NewCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button categoryAddButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label newProductCaption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button drinkButton;
        private System.Windows.Forms.Button foodButton;
    }
}