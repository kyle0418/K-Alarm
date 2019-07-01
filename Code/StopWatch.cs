using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace WindowsFormsApp1
{
    public partial class StopWatch : UserControl
    {
        public static StopWatch stopWatch;
        public StopWatch()
        {
            InitializeComponent();
            stopWatch = this;
        }

        private System.Timers.Timer myTimer;
        int millisecond = 0;
        int second = 0;
        int minute = 0;
        int hour = 0;

        private void btStartStop_Click(object sender, EventArgs e)
        {
            if (btStartStop.Text == "Start")
            {
                btStartStop.Text = "Stop";
                btResetLaps.Text = "Laps";
                this.myTimer.Start();
            }
            else if (btStartStop.Text == "Stop")
            {
                btStartStop.Text = "Start";
                this.myTimer.Stop();
                btResetLaps.Text = "Reset";
            }
        }

        int lapsCount = 0;

        private void btResetLaps_Click(object sender, EventArgs e)
        {
            if (btResetLaps.Text == "Reset")
            {
                lbHour.Text = "00:";
                lbMinute.Text = "00:";
                lbSecond.Text = "00.";
                lbMillisecond.Text = "00";
                hour = 0;
                minute = 0;
                second = 0;
                millisecond = 0;
                listBoxLaps.Visible = false;
                listBoxLaps.Items.Clear();
                lapsCount = 0;
            }
            if (btResetLaps.Text == "Laps")
            {
                listBoxLaps.Visible = true;
                listBoxLaps.Items.Add((lapsCount++ < 9 ? "0" + lapsCount.ToString() : lapsCount.ToString()) + "/ " + lbHour.Text + lbMinute.Text + lbSecond.Text + lbMillisecond.Text);
                int visibleItems = listBoxLaps.ClientSize.Height / listBoxLaps.ItemHeight;
                listBoxLaps.TopIndex = Math.Max(listBoxLaps.Items.Count - visibleItems + 1, 0);
            }
        }

        private void btWatchtoAlarm_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Alarm.form1.Text = "Alarm";
        }

        private void myTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            millisecond++;
            if (millisecond > 99)
            {
                millisecond -= 100;
                second++;
                if (second > 59)
                {
                    second -= 60;
                    minute++;
                    if (minute > 59)
                    {
                        minute -= 60;
                        hour++;
                    }
                }
            }
            try
            {
                lbHour.Text = (hour < 10 ? "0" + hour.ToString() : hour.ToString()) + ":";
                lbMinute.Text = (minute < 10 ? "0" + minute.ToString() : minute.ToString()) + ":";
                lbSecond.Text = (second < 10 ? "0" + second.ToString() : second.ToString()) + ".";
                lbMillisecond.Text = (millisecond < 10 ? "0" + millisecond.ToString() : millisecond.ToString());
            }
            catch { }
        }

        private void StopWatch_Load(object sender, EventArgs e)
        {
            lbHour.Text = "00:";
            lbMinute.Text = "00:";
            lbSecond.Text = "00.";
            lbMillisecond.Text = "00";
            listBoxLaps.Visible = false;
            listBoxLaps.Font = new Font("Microsoft Sans Serif", 14);

            this.myTimer = new System.Timers.Timer(1);
            this.myTimer.Elapsed += new System.Timers.ElapsedEventHandler(myTimer_Elapsed);
            this.myTimer.AutoReset = true;
        }

        private void btWatchtoTimer_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Timer.timer.Visible = true;
            Alarm.form1.Text = "Timer";
        }
    }
}
