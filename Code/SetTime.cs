using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SetTime : Form
    {
        public SetTime()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            numericUpDownHour.Minimum = 0;
            numericUpDownHour.Maximum = 23;
            numericUpDownMin.Minimum = 0;
            numericUpDownSec.Maximum = 59;
            numericUpDownSec.Minimum = 0;
            numericUpDownSec.Maximum = 59;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public delegate void delSetTime(string timestring);
        public event delSetTime delSetTimeHandler;

        private void btSetTime_Click(object sender, EventArgs e)
        {
            delSetTimeHandler((numericUpDownHour.Text.Length < 2 ? "0" + numericUpDownHour.Text : numericUpDownHour.Text) + ":" + (numericUpDownMin.Text.Length < 2 ? "0" + numericUpDownMin.Text : numericUpDownMin.Text) + ":" + (numericUpDownSec.Text.Length < 2 ? "0" + numericUpDownSec.Text : numericUpDownSec.Text));
            this.Close();
        }
    }
}
