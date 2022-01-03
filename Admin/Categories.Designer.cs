
namespace Admin
{
    partial class Categories
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
            this.newProductCaption = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.allergensList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.typeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newProductCaption
            // 
            this.newProductCaption.AutoSize = true;
            this.newProductCaption.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProductCaption.ForeColor = System.Drawing.Color.White;
            this.newProductCaption.Location = new System.Drawing.Point(12, 9);
            this.newProductCaption.Name = "newProductCaption";
            this.newProductCaption.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newProductCaption.Size = new System.Drawing.Size(194, 45);
            this.newProductCaption.TabIndex = 30;
            this.newProductCaption.Text = "CATEGORIES";
            this.newProductCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(217, 370);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(159, 52);
            this.closeButton.TabIndex = 68;
            this.closeButton.Text = "CLOSE";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // allergensList
            // 
            this.allergensList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.allergensList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allergensList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allergensList.ForeColor = System.Drawing.Color.White;
            this.allergensList.FormattingEnabled = true;
            this.allergensList.ItemHeight = 20;
            this.allergensList.Location = new System.Drawing.Point(12, 62);
            this.allergensList.Name = "allergensList";
            this.allergensList.Size = new System.Drawing.Size(199, 360);
            this.allergensList.TabIndex = 86;
            this.allergensList.SelectedIndexChanged += new System.EventHandler(this.allergensList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(217, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 52);
            this.button1.TabIndex = 87;
            this.button1.Text = "REMOVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.GreenYellow;
            this.button2.Location = new System.Drawing.Point(217, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 52);
            this.button2.TabIndex = 88;
            this.button2.Text = "NEW";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // typeText
            // 
            this.typeText.AutoSize = true;
            this.typeText.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.typeText.Location = new System.Drawing.Point(232, 62);
            this.typeText.Name = "typeText";
            this.typeText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.typeText.Size = new System.Drawing.Size(123, 60);
            this.typeText.TabIndex = 89;
            this.typeText.Text = "FOOD";
            this.typeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(388, 433);
            this.Controls.Add(this.typeText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.allergensList);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.newProductCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            this.Activated += new System.EventHandler(this.OnCategoriesActivated);
            this.Load += new System.EventHandler(this.Categories_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newProductCaption;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListBox allergensList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label typeText;
    }
}