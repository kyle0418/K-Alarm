﻿namespace WindowsFormsApp1
{
    partial class Alarm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarm));
            this.btAddAlarm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAddAlarm
            // 
            this.btAddAlarm.Location = new System.Drawing.Point(116, 12);
            this.btAddAlarm.Name = "btAddAlarm";
            this.btAddAlarm.Size = new System.Drawing.Size(27, 23);
            this.btAddAlarm.TabIndex = 0;
            this.btAddAlarm.Text = "+";
            this.btAddAlarm.UseVisualStyleBackColor = true;
            this.btAddAlarm.Click += new System.EventHandler(this.btAddAlarm_Click);
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(260, 450);
            this.Controls.Add(this.btAddAlarm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alarm";
            this.Text = "K-Alarm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            
        }
        #endregion

        private System.Windows.Forms.Button btAddAlarm;
    }
}

