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

        private void SingleAlarm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmsOtherOptions.Show(this, e.Location);
            }
        }

        public bool IsChecked()
        {
            if (OnOrOff.Checked == true)
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

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubSetAlarm subSetAlarm = new SubSetAlarm(this);
            subSetAlarm.StartPosition = FormStartPosition.CenterParent;
            subSetAlarm.Text = "Modify";
            subSetAlarm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point point = this.Location;
            Alarm.form1.Controls.Remove(this);
            foreach (Control control in Alarm.form1.Controls)
            {
                if (control is SingleAlarm)
                {
                    if (control.Location.Y > point.Y)
                    {
                        control.Location = new Point(point.X, control.Location.Y - 38);
                        if (control.BackColor == Color.WhiteSmoke)
                        {
                            control.BackColor = Color.White;
                        }
                        else
                        {
                            control.BackColor = Color.WhiteSmoke;
                        }
                    }
                }
            }
        }
    }
}
