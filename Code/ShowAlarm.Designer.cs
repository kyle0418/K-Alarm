namespace WindowsFormsApp1
{
    partial class ShowAlarm
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
            this.lbAlarm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAlarm
            // 
            this.lbAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbAlarm.Location = new System.Drawing.Point(67, 42);
            this.lbAlarm.Name = "lbAlarm";
            this.lbAlarm.Size = new System.Drawing.Size(141, 58);
            this.lbAlarm.TabIndex = 0;
            this.lbAlarm.Text = "00:00";
            // 
            // ShowAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 142);
            this.Controls.Add(this.lbAlarm);
            this.Name = "ShowAlarm";
            this.Text = "ShowAlarm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbAlarm;
    }
}