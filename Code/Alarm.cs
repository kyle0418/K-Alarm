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

        private System.Timers.Timer myTimer;

        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}
