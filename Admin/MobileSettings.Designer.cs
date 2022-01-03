
namespace Admin
{
    partial class MobileSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.mobileAppBG = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mobileAppBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newProductCaption
            // 
            this.newProductCaption.AutoSize = true;
            this.newProductCaption.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProductCaption.ForeColor = System.Drawing.Color.White;
            this.newProductCaption.Location = new System.Drawing.Point(614, 9);
            this.newProductCaption.Name = "newProductCaption";
            this.newProductCaption.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newProductCaption.Size = new System.Drawing.Size(336, 45);
            this.newProductCaption.TabIndex = 30;
            this.newProductCaption.Text = "MOBILE APP SETTINGS";
            this.newProductCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(821, 509);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(129, 52);
            this.closeButton.TabIndex = 68;
            this.closeButton.Text = "CLOSE";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(116, 42);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(163, 34);
            this.label1.TabIndex = 71;
            this.label1.Text = "BACKGROUND";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(32, 70);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(338, 23);
            this.label2.TabIndex = 72;
            this.label2.Text = "ASPECT RATIO: 9:16 | RESOLUTION: 1080x1920";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imageOpenDialog
            // 
            this.imageOpenDialog.FileName = "openFileDialog1";
            this.imageOpenDialog.Filter = "JPG IMAGES|*.jpg";
            this.imageOpenDialog.Title = "Select background image | ASPECT RATIO: 9:16 | RESOLUTION: 1080x1920";
            // 
            // mobileAppBG
            // 
            this.mobileAppBG.InitialImage = global::Admin.Properties.Resources.loading1;
            this.mobileAppBG.Location = new System.Drawing.Point(120, 163);
            this.mobileAppBG.Name = "mobileAppBG";
            this.mobileAppBG.Size = new System.Drawing.Size(188, 394);
            this.mobileAppBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mobileAppBG.TabIndex = 70;
            this.mobileAppBG.TabStop = false;
            this.mobileAppBG.Click += new System.EventHandler(this.mobileAppBG_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Admin.Properties.Resources.PhoneFrameTrans;
            this.pictureBox1.Location = new System.Drawing.Point(-120, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 525);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(400, 23);
            this.label3.TabIndex = 73;
            this.label3.Text = "Background image can take up to 24hrs to change";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MobileSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(962, 621);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mobileAppBG);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.newProductCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MobileSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobile Settings";
            ((System.ComponentModel.ISupportInitialize)(this.mobileAppBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newProductCaption;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox mobileAppBG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog imageOpenDialog;
        private System.Windows.Forms.Label label3;
    }
}