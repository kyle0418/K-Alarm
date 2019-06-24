namespace WindowsFormsApp1
{
    partial class SubSetAlarm
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
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.lbHour = new System.Windows.Forms.Label();
            this.lbMinute = new System.Windows.Forms.Label();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.btSubAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.Location = new System.Drawing.Point(52, 30);
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownHour.TabIndex = 0;
            // 
            // lbHour
            // 
            this.lbHour.AutoSize = true;
            this.lbHour.Location = new System.Drawing.Point(13, 32);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(33, 13);
            this.lbHour.TabIndex = 1;
            this.lbHour.Text = "Hour:";
            // 
            // lbMinute
            // 
            this.lbMinute.AutoSize = true;
            this.lbMinute.Location = new System.Drawing.Point(12, 68);
            this.lbMinute.Name = "lbMinute";
            this.lbMinute.Size = new System.Drawing.Size(42, 13);
            this.lbMinute.TabIndex = 2;
            this.lbMinute.Text = "Minute:";
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Location = new System.Drawing.Point(52, 66);
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownMin.TabIndex = 3;
            // 
            // btSubAdd
            // 
            this.btSubAdd.Location = new System.Drawing.Point(164, 48);
            this.btSubAdd.Name = "btSubAdd";
            this.btSubAdd.Size = new System.Drawing.Size(75, 23);
            this.btSubAdd.TabIndex = 4;
            this.btSubAdd.Text = "Add Alarm";
            this.btSubAdd.UseVisualStyleBackColor = true;
            this.btSubAdd.Click += new System.EventHandler(this.btSubAdd_Click);
            // 
            // SubSetAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 110);
            this.Controls.Add(this.btSubAdd);
            this.Controls.Add(this.numericUpDownMin);
            this.Controls.Add(this.lbMinute);
            this.Controls.Add(this.lbHour);
            this.Controls.Add(this.numericUpDownHour);
            this.Name = "SubSetAlarm";
            this.Text = "SubSetAlarm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.Label lbMinute;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.Button btSubAdd;
    }
}