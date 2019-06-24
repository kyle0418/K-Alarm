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
    public partial class SubSetAlarm : Form
    {
        public SubSetAlarm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            numericUpDownHour.Minimum = 0;
            numericUpDownHour.Maximum = 23;
            numericUpDownMin.Minimum = 0;
            numericUpDownMin.Maximum = 59;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        //int alarmCount = 0;

        public delegate void delSetAlarm(SingleAlarm sa);
        public event delSetAlarm delSetAlarmHandler;


        private void btSubAdd_Click(object sender, EventArgs e)
        {
            int count = 0;
            int height = 0;
            foreach (Control c in Alarm.form1.Controls)
            {
                if (c is SingleAlarm)
                {
                    count++;
                    height += 38;
                }
            }
            if(count >= 11)
            {
                MessageBox.Show("The count of alarms reaches the upper limit");
                return;
            }
            //count++;
            SingleAlarm sa = new SingleAlarm();
            sa.Location = new Point(0, height);
            string hour = numericUpDownHour.Value.ToString();
            if(hour.Length == 1)
            {
                hour = "0" + hour;
            }
            string minute = numericUpDownMin.Value.ToString();
            if(minute.Length == 1)
            {
                minute = "0" + minute;
            }
            sa.SetTime(hour + ":" + minute);
            if (count % 2 == 0)
            {
                sa.BackColor = Color.White;
            }
            else
            {
                sa.BackColor = Color.WhiteSmoke;
            }
            delSetAlarmHandler(sa);
            height += 38;
            count++;
            //alarmCount += 1;
        }
    }
}
