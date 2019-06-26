namespace WindowsFormsApp1
{
    partial class SingleAlarm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SettedTime = new System.Windows.Forms.Label();
            this.OnOrOff = new System.Windows.Forms.CheckBox();
            this.cmsOtherOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsOtherOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettedTime
            // 
            this.SettedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettedTime.Location = new System.Drawing.Point(15, 9);
            this.SettedTime.Name = "SettedTime";
            this.SettedTime.Size = new System.Drawing.Size(100, 23);
            this.SettedTime.TabIndex = 0;
            this.SettedTime.Text = "\"time\"";
            // 
            // OnOrOff
            // 
            this.OnOrOff.AutoSize = true;
            this.OnOrOff.Location = new System.Drawing.Point(225, 18);
            this.OnOrOff.Name = "OnOrOff";
            this.OnOrOff.Size = new System.Drawing.Size(15, 14);
            this.OnOrOff.TabIndex = 1;
            this.OnOrOff.UseVisualStyleBackColor = true;
            // 
            // cmsOtherOptions
            // 
            this.cmsOtherOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsOtherOptions.Name = "cmsOtherOptions";
            this.cmsOtherOptions.Size = new System.Drawing.Size(108, 48);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // SingleAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.OnOrOff);
            this.Controls.Add(this.SettedTime);
            this.Name = "SingleAlarm";
            this.Size = new System.Drawing.Size(260, 38);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SingleAlarm_MouseUp);
            this.cmsOtherOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SettedTime;
        private System.Windows.Forms.CheckBox OnOrOff;
        private System.Windows.Forms.ContextMenuStrip cmsOtherOptions;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
