
namespace Admin
{
    partial class EditAllergens
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
            this.captionText = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.allergensList = new System.Windows.Forms.CheckedListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // captionText
            // 
            this.captionText.AutoSize = true;
            this.captionText.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionText.ForeColor = System.Drawing.Color.White;
            this.captionText.Location = new System.Drawing.Point(12, 9);
            this.captionText.Name = "captionText";
            this.captionText.Size = new System.Drawing.Size(246, 45);
            this.captionText.TabIndex = 30;
            this.captionText.Text = "EDIT ALLERGENS";
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(231, 398);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(81, 40);
            this.closeButton.TabIndex = 29;
            this.closeButton.Text = "CANCEL";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(21, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 26);
            this.label13.TabIndex = 98;
            this.label13.Text = "ALLERGENS";
            // 
            // allergensList
            // 
            this.allergensList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.allergensList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allergensList.CheckOnClick = true;
            this.allergensList.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allergensList.ForeColor = System.Drawing.Color.White;
            this.allergensList.FormattingEnabled = true;
            this.allergensList.Items.AddRange(new object[] {
            "CELERY",
            "CEREALS CONTAINING GLUTEN",
            "CRUSTACEANS",
            "EGGS",
            "FISH",
            "LUPIN",
            "MILK",
            "MOLLUSCS",
            "MUSTARD",
            "PEANUTS",
            "SESAME",
            "SOYBEANS",
            "SULPHUR DIOXIDE",
            "SULPHITES"});
            this.allergensList.Location = new System.Drawing.Point(20, 84);
            this.allergensList.Name = "allergensList";
            this.allergensList.Size = new System.Drawing.Size(292, 308);
            this.allergensList.TabIndex = 97;
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.GreenYellow;
            this.saveButton.Location = new System.Drawing.Point(20, 398);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(205, 40);
            this.saveButton.TabIndex = 99;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // EditAllergens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(335, 454);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.allergensList);
            this.Controls.Add(this.captionText);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditAllergens";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Allergens";
            this.Load += new System.EventHandler(this.EditAllergens_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label captionText;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox allergensList;
        private System.Windows.Forms.Button saveButton;
    }
}