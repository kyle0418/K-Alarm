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
    public partial class ShowAlarm : Form
    {
        public ShowAlarm(string time)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            string hour;
            string minute;
            if (time.Split(':')[0].Length < 2)
            {
                hour = "0" + time.Split(':')[0];
            }
            else
            {
                hour = time.Split(':')[0];
            }
            if (time.Split(':')[1].Length < 2)
            {
                minute = "0" + time.Split(':')[1];
            }
            else
            {
                minute = time.Split(':')[1];
            }
            lbAlarm.Text = hour + ":" + minute;
        }
    }
}
