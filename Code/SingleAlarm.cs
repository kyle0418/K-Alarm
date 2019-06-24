using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SingleAlarm : UserControl
    {
        public SingleAlarm()
        {
            InitializeComponent();
            this.ContextMenuStrip = cmsOtherOptions;
        }

        public void SetTime(string time)
        {
            this.SettedTime.Text = time;
        }

        private void SingleAlarm_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("The alarm time is" + SettedTime.Text);
        }

        private void SingleAlarm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmsOtherOptions.Show(this, e.Location);
            }
        }

        public bool IsChecked()
        {
            if(OnOrOff.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DateTime GetAlarmTime()
        {
            return Convert.ToDateTime(SettedTime.Text);
        }

        //public void get()
        //{
        //    Console.WriteLine(SettedTime.Text);
        //}

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
