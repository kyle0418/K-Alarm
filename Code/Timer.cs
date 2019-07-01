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
    public partial class Timer : UserControl
    {
        public static Timer timer;
        private System.Timers.Timer myTimer;

        int hour;
        int minute;
        int second;

        public Timer()
        {
            InitializeComponent();
            timer = this;
        }

        private void panelTime_Click(object sender, EventArgs e)
        {
            SetTime setTime = new SetTime();
            setTime.delSetTimeHandler += SetTime;
            setTime.StartPosition = FormStartPosition.CenterParent;
            setTime.ShowDialog();
        }

        List<string> spacelist;
        List<int> time = new List<int>();

        private void SetTime(string timestring)
        {
            List<string> timelist = timestring.Split(':').ToList();
            spacelist = timelist;
            lbHour.Text = timelist[0] + ":";
            lbMinute.Text = timelist[1] + ":";
            lbSecond.Text = timelist[2];
            hour = Convert.ToInt32(lbHour.Text.Substring(0, 2));
            minute = Convert.ToInt32(lbMinute.Text.Substring(0, 2));
            second = Convert.ToInt32(lbSecond.Text.Substring(0, 2));
            time.Add(hour);
            time.Add(minute);
            time.Add(second);

            string lbTimeText = (hour.ToString().Length < 2 ? "0" + hour.ToString() : hour.ToString()) + ":" +
            (minute.ToString().Length < 2 ? "0" + minute.ToString() : minute.ToString()) + ":" +
            (second.ToString().Length < 2 ? "0" + second.ToString() : second.ToString());

            lbTime.Text = lbTimeText;
        }

        private void btTimertoAlarm_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Alarm.form1.Text = "Alarm";
        }

        private void btTimertoWacth_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StopWatch.stopWatch.Visible = true;
            Alarm.form1.Text = "StopWatch";
        }

        private void Timer_Load(object sender, EventArgs e)
        {
            lbHour.Text = "00:";
            lbMinute.Text = "00:";
            lbSecond.Text = "00";

            this.myTimer = new System.Timers.Timer(1000);
            this.myTimer.Elapsed += new System.Timers.ElapsedEventHandler(myTimer_Elapsed);
            this.myTimer.AutoReset = true;
        }

        private void btStartStop_Click(object sender, EventArgs e)
        {
            if (btStartStop.Text == "Start")
            {
                myTimer.Start();
                btStartStop.Text = "Stop";
            }
            else if (btStartStop.Text == "Stop")
            {
                myTimer.Stop();
                btStartStop.Text = "Start";
            }
        }

        private void myTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (hour == 0 && minute == 0 && second == 0)
            {
                myTimer.Stop();
                btStartStop.Text = "Start";
                MessageBox.Show("pass");
                return;
            }
            second--;

            if (second < 1 && (hour != 0 || minute != 0))
            {
                second = 59;
                minute--;
                if (minute < 1 && hour != 0)
                {
                    minute = 59;
                    hour--;
                }
            }

            lbHour.Text = (hour.ToString().Length < 2 ? "0" + hour.ToString() : hour.ToString()) + ":";
            lbMinute.Text = (minute.ToString().Length < 2 ? "0" + minute.ToString() : minute.ToString()) + ":";
            lbSecond.Text = (second.ToString().Length < 2 ? "0" + second.ToString() : second.ToString());
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            lbHour.Text = spacelist[0] + ":";
            lbMinute.Text = spacelist[1] + ":";
            lbSecond.Text = spacelist[2];
            myTimer.Stop();
            hour = time[0];
            minute = time[1];
            second = time[2];
            btStartStop.Text = "Start";
        }

        private void panelTime_MouseHover(object sender, EventArgs e)
        {
            panelTime.BackColor = Color.Silver;
        }

        private void panelTime_MouseLeave(object sender, EventArgs e)
        {
            panelTime.BackColor = Color.Transparent;
        }
    }
}
