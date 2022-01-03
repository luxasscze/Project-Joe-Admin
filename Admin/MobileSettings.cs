using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentFTP;
using static Admin.GlobalVar;

namespace Admin
{
    public partial class MobileSettings : Form
    {
        public MobileSettings()
        {
            InitializeComponent();
            mobileAppBG.ImageLocation = _ImageUriPath + "/AppImages/bg.jpg";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void mobileAppBG_Click(object sender, EventArgs e)
        {
            if (imageOpenDialog.ShowDialog() == DialogResult.OK)
            {
                mobileAppBG.Image = new Bitmap(imageOpenDialog.FileName);

                using (FtpClient ftp = new FtpClient(_FTPServer, _FTPUsername, _FTPPassword))
                {
                    ftp.Connect();
                    await ftp.UploadFileAsync(imageOpenDialog.FileName, _FTPLocation + "AppImages/bg.jpg", FtpRemoteExists.Overwrite);
                    ftp.Disconnect(); // This function need to be implemented as soon as possibel
                }

            }
        }
    }
}
