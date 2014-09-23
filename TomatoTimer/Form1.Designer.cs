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
            this.SuspendLayout();
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(185, 286);
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
            this.cmdStop.Location = new System.Drawing.Point(206, 113);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(62, 23);
            this.cmdStop.TabIndex = 2;
            this.cmdStop.Text = "Stop";
            this.cmdStop.UseVisualStyleBackColor = true;
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(65, 140);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(135, 23);
            this.cmdStart.TabIndex = 3;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cboBuckets
            // 
            this.cboBuckets.FormattingEnabled = true;
            this.cboBuckets.Location = new System.Drawing.Point(65, 113);
            this.cboBuckets.Name = "cboBuckets";
            this.cboBuckets.Size = new System.Drawing.Size(135, 21);
            this.cboBuckets.TabIndex = 4;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 321);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(278, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panelBuckets
            // 
            this.panelBuckets.BackColor = System.Drawing.Color.Red;
            this.panelBuckets.Location = new System.Drawing.Point(29, 180);
            this.panelBuckets.Name = "panelBuckets";
            this.panelBuckets.Size = new System.Drawing.Size(239, 100);
            this.panelBuckets.TabIndex = 7;
            // 
            // timerUI
            // 
            this.timerUI.Interval = 200;
            this.timerUI.Tick += new System.EventHandler(this.timerUI_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 343);
            this.Controls.Add(this.panelBuckets);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBuckets);
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
        private System.Windows.Forms.ComboBox cboBuckets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.FlowLayoutPanel panelBuckets;
        private System.Windows.Forms.Timer timerUI;
    }
}

