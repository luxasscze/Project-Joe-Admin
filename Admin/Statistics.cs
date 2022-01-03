using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            gaugeTest.To = 10;
            
            gaugeTest.FromColor = System.Windows.Media.Color.FromRgb(255, 255, 255);
            gaugeTest.ToColor = System.Windows.Media.Color.FromRgb(255, 255, 255);
            gaugeTest.Uses360Mode = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gaugeTest.Value += 1;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
