
namespace Admin
{
    partial class DialogWindow
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
            this.alertTextControl = new System.Windows.Forms.Label();
            this.alertCaptionControl = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.lineText = new System.Windows.Forms.Label();
            this.secondLineText = new System.Windows.Forms.Label();
            this.iconImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconImage)).BeginInit();
            this.SuspendLayout();
            // 
            // alertTextControl
            // 
            this.alertTextControl.AutoSize = true;
            this.alertTextControl.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertTextControl.ForeColor = System.Drawing.Color.White;
            this.alertTextControl.Location = new System.Drawing.Point(12, 68);
            this.alertTextControl.Name = "alertTextControl";
            this.alertTextControl.Size = new System.Drawing.Size(91, 23);
            this.alertTextControl.TabIndex = 57;
            this.alertTextControl.Text = "ALERT TEXT";
            // 
            // alertCaptionControl
            // 
            this.alertCaptionControl.AutoSize = true;
            this.alertCaptionControl.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertCaptionControl.ForeColor = System.Drawing.Color.Brown;
            this.alertCaptionControl.Location = new System.Drawing.Point(61, 5);
            this.alertCaptionControl.Name = "alertCaptionControl";
            this.alertCaptionControl.Size = new System.Drawing.Size(175, 34);
            this.alertCaptionControl.TabIndex = 58;
            this.alertCaptionControl.Text = "ALERT CAPTION";
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(447, 142);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(81, 32);
            this.closeButton.TabIndex = 68;
            this.closeButton.Text = "OK";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // lineText
            // 
            this.lineText.AutoSize = true;
            this.lineText.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineText.ForeColor = System.Drawing.Color.Brown;
            this.lineText.Location = new System.Drawing.Point(12, 20);
            this.lineText.Name = "lineText";
            this.lineText.Size = new System.Drawing.Size(525, 34);
            this.lineText.TabIndex = 69;
            this.lineText.Text = "__________________________________";
            // 
            // secondLineText
            // 
            this.secondLineText.AutoSize = true;
            this.secondLineText.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLineText.ForeColor = System.Drawing.Color.Brown;
            this.secondLineText.Location = new System.Drawing.Point(12, 105);
            this.secondLineText.Name = "secondLineText";
            this.secondLineText.Size = new System.Drawing.Size(525, 34);
            this.secondLineText.TabIndex = 70;
            this.secondLineText.Text = "__________________________________";
            // 
            // iconImage
            // 
            this.iconImage.BackColor = System.Drawing.Color.Transparent;
            this.iconImage.Image = global::Admin.Properties.Resources.warning;
            this.iconImage.Location = new System.Drawing.Point(1, -2);
            this.iconImage.Name = "iconImage";
            this.iconImage.Size = new System.Drawing.Size(67, 49);
            this.iconImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconImage.TabIndex = 71;
            this.iconImage.TabStop = false;
            this.iconImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DialogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(547, 186);
            this.Controls.Add(this.alertCaptionControl);
            this.Controls.Add(this.iconImage);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.alertTextControl);
            this.Controls.Add(this.lineText);
            this.Controls.Add(this.secondLineText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DialogWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogWindow";
            this.Load += new System.EventHandler(this.DialogWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alertTextControl;
        private System.Windows.Forms.Label alertCaptionControl;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label lineText;
        private System.Windows.Forms.Label secondLineText;
        private System.Windows.Forms.PictureBox iconImage;
    }
}