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
            this.cboBuckets = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelBuckets = new System.Windows.Forms.FlowLayoutPanel();
            this.timerUI = new System.Windows.Forms.Timer(this.components);
            this.cmdManageBuckets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(247, 352);
            this.cmdExit.Margin = new System.Windows.Forms.Padding(4);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(111, 34);
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
            this.lblTimer.Location = new System.Drawing.Point(19, 11);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(317, 111);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "17 : 56";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(275, 139);
            this.cmdStop.Margin = new System.Windows.Forms.Padding(4);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(83, 28);
            this.cmdStop.TabIndex = 2;
            this.cmdStop.Text = "Stop";
            this.cmdStop.UseVisualStyleBackColor = true;
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(87, 172);
            this.cmdStart.Margin = new System.Windows.Forms.Padding(4);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(180, 28);
            this.cmdStart.TabIndex = 3;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cboBuckets
            // 
            this.cboBuckets.FormattingEnabled = true;
            this.cboBuckets.Location = new System.Drawing.Point(87, 139);
            this.cboBuckets.Margin = new System.Windows.Forms.Padding(4);
            this.cboBuckets.Name = "cboBuckets";
            this.cboBuckets.Size = new System.Drawing.Size(179, 24);
            this.cboBuckets.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bucket :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(371, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panelBuckets
            // 
            this.panelBuckets.BackColor = System.Drawing.Color.Red;
            this.panelBuckets.Location = new System.Drawing.Point(39, 222);
            this.panelBuckets.Margin = new System.Windows.Forms.Padding(4);
            this.panelBuckets.Name = "panelBuckets";
            this.panelBuckets.Size = new System.Drawing.Size(319, 123);
            this.panelBuckets.TabIndex = 7;
            // 
            // timerUI
            // 
            this.timerUI.Interval = 200;
            this.timerUI.Tick += new System.EventHandler(this.timerUI_Tick);
            // 
            // cmdManageBuckets
            // 
            this.cmdManageBuckets.Location = new System.Drawing.Point(38, 363);
            this.cmdManageBuckets.Name = "cmdManageBuckets";
            this.cmdManageBuckets.Size = new System.Drawing.Size(75, 23);
            this.cmdManageBuckets.TabIndex = 8;
            this.cmdManageBuckets.Text = "Manage Buckets";
            this.cmdManageBuckets.UseVisualStyleBackColor = true;
            this.cmdManageBuckets.Click += new System.EventHandler(this.cmdManageBuckets_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 422);
            this.Controls.Add(this.cmdManageBuckets);
            this.Controls.Add(this.panelBuckets);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBuckets);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.cmdExit);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ComboBox cboBuckets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.FlowLayoutPanel panelBuckets;
        private System.Windows.Forms.Timer timerUI;
        private System.Windows.Forms.Button cmdManageBuckets;
    }
}

