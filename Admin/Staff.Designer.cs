
namespace Admin
{
    partial class Staff
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
            this.firstNameText = new System.Windows.Forms.Label();
            this.staffList = new System.Windows.Forms.ListBox();
            this.departmentText = new System.Windows.Forms.Label();
            this.staffNameText = new System.Windows.Forms.Label();
            this.newStaffButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.staffPicture = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.RichTextBox();
            this.contractText = new System.Windows.Forms.Label();
            this.salaryText = new System.Windows.Forms.Label();
            this.hiredText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.staffPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(772, 373);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(146, 52);
            this.closeButton.TabIndex = 27;
            this.closeButton.Text = "CLOSE";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // firstNameText
            // 
            this.firstNameText.AutoSize = true;
            this.firstNameText.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameText.ForeColor = System.Drawing.Color.White;
            this.firstNameText.Location = new System.Drawing.Point(608, 9);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(310, 45);
            this.firstNameText.TabIndex = 70;
            this.firstNameText.Text = "STAFF MANAGEMENT";
            // 
            // staffList
            // 
            this.staffList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.staffList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffList.ForeColor = System.Drawing.Color.White;
            this.staffList.FormattingEnabled = true;
            this.staffList.ItemHeight = 20;
            this.staffList.Location = new System.Drawing.Point(12, 45);
            this.staffList.Name = "staffList";
            this.staffList.Size = new System.Drawing.Size(297, 380);
            this.staffList.TabIndex = 71;
            this.staffList.SelectedIndexChanged += new System.EventHandler(this.staffList_SelectedIndexChanged);
            // 
            // departmentText
            // 
            this.departmentText.AutoSize = true;
            this.departmentText.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentText.ForeColor = System.Drawing.Color.DimGray;
            this.departmentText.Location = new System.Drawing.Point(315, 110);
            this.departmentText.Name = "departmentText";
            this.departmentText.Size = new System.Drawing.Size(162, 36);
            this.departmentText.TabIndex = 73;
            this.departmentText.Text = "DEPARTMENT";
            // 
            // staffNameText
            // 
            this.staffNameText.AutoSize = true;
            this.staffNameText.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffNameText.ForeColor = System.Drawing.Color.White;
            this.staffNameText.Location = new System.Drawing.Point(315, 65);
            this.staffNameText.Name = "staffNameText";
            this.staffNameText.Size = new System.Drawing.Size(192, 45);
            this.staffNameText.TabIndex = 72;
            this.staffNameText.Text = "STAFF NAME";
            // 
            // newStaffButton
            // 
            this.newStaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newStaffButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newStaffButton.ForeColor = System.Drawing.Color.White;
            this.newStaffButton.Location = new System.Drawing.Point(772, 315);
            this.newStaffButton.Name = "newStaffButton";
            this.newStaffButton.Size = new System.Drawing.Size(146, 52);
            this.newStaffButton.TabIndex = 78;
            this.newStaffButton.Text = "NEW STAFF";
            this.newStaffButton.UseVisualStyleBackColor = true;
            this.newStaffButton.Click += new System.EventHandler(this.newStaffButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.IndianRed;
            this.deleteButton.Location = new System.Drawing.Point(772, 257);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(146, 52);
            this.deleteButton.TabIndex = 79;
            this.deleteButton.Text = "DELETE STAFF";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 81;
            this.label1.Text = "Search:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.searchTextBox.Location = new System.Drawing.Point(72, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(237, 19);
            this.searchTextBox.TabIndex = 80;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // staffPicture
            // 
            this.staffPicture.BackgroundImage = global::Admin.Properties.Resources.loading;
            this.staffPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.staffPicture.Image = global::Admin.Properties.Resources.loading;
            this.staffPicture.Location = new System.Drawing.Point(772, 81);
            this.staffPicture.Name = "staffPicture";
            this.staffPicture.Size = new System.Drawing.Size(146, 131);
            this.staffPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.staffPicture.TabIndex = 82;
            this.staffPicture.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(505, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "Notes";
            // 
            // notesTextBox
            // 
            this.notesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.notesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notesTextBox.ForeColor = System.Drawing.Color.White;
            this.notesTextBox.Location = new System.Drawing.Point(315, 356);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(438, 69);
            this.notesTextBox.TabIndex = 83;
            this.notesTextBox.Text = "";
            // 
            // contractText
            // 
            this.contractText.AutoSize = true;
            this.contractText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractText.ForeColor = System.Drawing.Color.DimGray;
            this.contractText.Location = new System.Drawing.Point(317, 146);
            this.contractText.Name = "contractText";
            this.contractText.Size = new System.Drawing.Size(89, 23);
            this.contractText.TabIndex = 85;
            this.contractText.Text = "CONTRACT";
            // 
            // salaryText
            // 
            this.salaryText.AutoSize = true;
            this.salaryText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryText.ForeColor = System.Drawing.Color.DimGray;
            this.salaryText.Location = new System.Drawing.Point(317, 169);
            this.salaryText.Name = "salaryText";
            this.salaryText.Size = new System.Drawing.Size(64, 23);
            this.salaryText.TabIndex = 86;
            this.salaryText.Text = "SALARY";
            // 
            // hiredText
            // 
            this.hiredText.AutoSize = true;
            this.hiredText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiredText.ForeColor = System.Drawing.Color.DimGray;
            this.hiredText.Location = new System.Drawing.Point(319, 192);
            this.hiredText.Name = "hiredText";
            this.hiredText.Size = new System.Drawing.Size(55, 23);
            this.hiredText.TabIndex = 87;
            this.hiredText.Text = "HIRED";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(930, 437);
            this.Controls.Add(this.hiredText);
            this.Controls.Add(this.salaryText);
            this.Controls.Add(this.contractText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.staffPicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.newStaffButton);
            this.Controls.Add(this.departmentText);
            this.Controls.Add(this.staffNameText);
            this.Controls.Add(this.staffList);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label firstNameText;
        private System.Windows.Forms.ListBox staffList;
        private System.Windows.Forms.Label departmentText;
        private System.Windows.Forms.Label staffNameText;
        private System.Windows.Forms.Button newStaffButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.PictureBox staffPicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox notesTextBox;
        private System.Windows.Forms.Label contractText;
        private System.Windows.Forms.Label salaryText;
        private System.Windows.Forms.Label hiredText;
    }
}