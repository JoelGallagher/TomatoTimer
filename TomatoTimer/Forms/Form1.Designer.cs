namespace TomatoTimer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cmdExit = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelBuckets = new System.Windows.Forms.FlowLayoutPanel();
            this.timerUI = new System.Windows.Forms.Timer(this.components);
            this.cmdManageBuckets = new System.Windows.Forms.Button();
            this.cmdPause = new System.Windows.Forms.Button();
            this.lblFormState = new System.Windows.Forms.Label();
            this.lstBuckets = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(183, 286);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(83, 28);
            this.cmdExit.TabIndex = 0;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTimer.Font = new System.Drawing.Font("Segoe Script", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(14, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(254, 90);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "17 : 56";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(111, 179);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(78, 70);
            this.cmdStop.TabIndex = 2;
            this.cmdStop.Text = "Stop";
            this.cmdStop.UseVisualStyleBackColor = true;
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(12, 179);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(93, 70);
            this.cmdStart.TabIndex = 3;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bucket :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 321);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(278, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panelBuckets
            // 
            this.panelBuckets.BackColor = System.Drawing.Color.Red;
            this.panelBuckets.Location = new System.Drawing.Point(29, 255);
            this.panelBuckets.Name = "panelBuckets";
            this.panelBuckets.Size = new System.Drawing.Size(239, 25);
            this.panelBuckets.TabIndex = 7;
            this.panelBuckets.Visible = false;
            // 
            // timerUI
            // 
            this.timerUI.Interval = 200;
            this.timerUI.Tick += new System.EventHandler(this.timerUI_Tick);
            // 
            // cmdManageBuckets
            // 
            this.cmdManageBuckets.Location = new System.Drawing.Point(194, 116);
            this.cmdManageBuckets.Margin = new System.Windows.Forms.Padding(2);
            this.cmdManageBuckets.Name = "cmdManageBuckets";
            this.cmdManageBuckets.Size = new System.Drawing.Size(72, 43);
            this.cmdManageBuckets.TabIndex = 8;
            this.cmdManageBuckets.Text = "Manage Buckets";
            this.cmdManageBuckets.UseVisualStyleBackColor = true;
            this.cmdManageBuckets.Click += new System.EventHandler(this.cmdManageBuckets_Click);
            // 
            // cmdPause
            // 
            this.cmdPause.Location = new System.Drawing.Point(195, 179);
            this.cmdPause.Name = "cmdPause";
            this.cmdPause.Size = new System.Drawing.Size(73, 70);
            this.cmdPause.TabIndex = 9;
            this.cmdPause.Text = "Pause";
            this.cmdPause.UseVisualStyleBackColor = true;
            this.cmdPause.Click += new System.EventHandler(this.cmdPause_Click);
            // 
            // lblFormState
            // 
            this.lblFormState.AutoSize = true;
            this.lblFormState.Location = new System.Drawing.Point(34, 294);
            this.lblFormState.Name = "lblFormState";
            this.lblFormState.Size = new System.Drawing.Size(58, 13);
            this.lblFormState.TabIndex = 10;
            this.lblFormState.Text = "(formState)";
            // 
            // lstBuckets
            // 
            this.lstBuckets.DisplayMember = "Name";
            this.lstBuckets.FormattingEnabled = true;
            this.lstBuckets.Location = new System.Drawing.Point(62, 116);
            this.lstBuckets.Name = "lstBuckets";
            this.lstBuckets.Size = new System.Drawing.Size(127, 43);
            this.lstBuckets.TabIndex = 11;
            this.lstBuckets.ValueMember = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 343);
            this.Controls.Add(this.lstBuckets);
            this.Controls.Add(this.lblFormState);
            this.Controls.Add(this.cmdPause);
            this.Controls.Add(this.cmdManageBuckets);
            this.Controls.Add(this.panelBuckets);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.cmdExit);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tomato Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.FlowLayoutPanel panelBuckets;
        private System.Windows.Forms.Timer timerUI;
        private System.Windows.Forms.Button cmdManageBuckets;
        private System.Windows.Forms.Button cmdPause;
        private System.Windows.Forms.Label lblFormState;
        private System.Windows.Forms.ListBox lstBuckets;
    }
}

