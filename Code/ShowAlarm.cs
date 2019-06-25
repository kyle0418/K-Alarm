﻿using System;
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
            lbAlarm.Text = time;
        }
    }
}
