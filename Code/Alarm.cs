using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Alarm : Form
    {
        public static Alarm form1;
        public Alarm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            form1 = this;
        }

        public Button AddButton
        {
            get { return btAddAlarm; }
        }

        private System.Timers.Timer myTimer;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettedAlarm();
            stopWatch.Visible = false;
            timer.Visible = false;

            this.myTimer = new System.Timers.Timer(1000);
            this.myTimer.Elapsed += new System.Timers.ElapsedEventHandler(myTimer_Elapsed);
            this.myTimer.AutoReset = true;
            this.myTimer.Enabled = true;
            this.myTimer.Start();
        }

        void SetAlarmFromSub(SingleAlarm sa)
        {
            this.Controls.Add(sa);
        }

        private void btAddAlarm_Click(object sender, EventArgs e)
        {
            SubSetAlarm subSetAlarm = new SubSetAlarm();
            subSetAlarm.StartPosition = FormStartPosition.CenterParent;
            subSetAlarm.delSetAlarmHandler += SetAlarmFromSub;
            subSetAlarm.Text = "Set";
            subSetAlarm.ShowDialog();
        }

        string comparestring = "";

        private void ToBeAlarm()
        {
            Console.WriteLine("====" + count++ + "==================");
            DateTime timeNow = DateTime.Now;
            string stringnow = timeNow.Hour + ":" + timeNow.Minute;
            foreach (var c in this.Controls)
            {
                if (c is SingleAlarm)
                {
                    SingleAlarm singleAlarm = c as SingleAlarm;
                    DateTime timeAlarm = singleAlarm.GetAlarmTime();
                    string stringalarm = timeAlarm.Hour + ":" + timeAlarm.Minute;
                    if (singleAlarm.IsChecked())
                    {
                        if (stringalarm == stringnow)
                        {
                            if (comparestring != stringnow)
                            {
                                comparestring = stringnow;
                                ShowAlarm showAlarm = new ShowAlarm(stringalarm);
                                showAlarm.ShowDialog();
                            }
                        }
                    }
                }
            }
        }

        int count = 0;
        private void myTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            ToBeAlarm();
        }

        private void Alarm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.TimeSetting = "";
            Settings.Default.CheckSetting = "";
            foreach (Control control in this.Controls)
            {
                if (control is SingleAlarm)
                {
                    Settings.Default.TimeSetting += (control as SingleAlarm).GetTime() + ",";
                    Settings.Default.CheckSetting += (control as SingleAlarm).IsChecked().ToString() + ",";
                }
            }
            Settings.Default.Save();
        }

        private void LoadSettedAlarm()
        {
            bool flag = true;

            List<string> timelist = Settings.Default.TimeSetting.Split(',').ToList<string>();
            List<string> checklist = Settings.Default.CheckSetting.Split(',').ToList<string>();
            int positionY =0;
            for(int i = 0;i< timelist.Count -1;i++)
            {
                SingleAlarm singleAlarm = new SingleAlarm(timelist[i], Convert.ToBoolean(checklist[i]));
                singleAlarm.Location = new Point(0, positionY);
                if(flag)
                    singleAlarm.BackColor = Color.White;
                else
                    singleAlarm.BackColor = Color.WhiteSmoke;
                flag = !flag;
                this.Controls.Add(singleAlarm);
                positionY += 38;
            }

            AddButton.Location = new Point(116, positionY + 5);
        }

        private void btStopWatch_Click(object sender, EventArgs e)
        {
            stopWatch.Visible = true;
            this.Text = "StopWatch";
        }

        private void btTimer_Click(object sender, EventArgs e)
        {
            timer.Visible = true;
            this.Text = "Timer";
        }
    }
}
