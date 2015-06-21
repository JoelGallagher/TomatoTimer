namespace TomatoTimer.Forms
{
    partial class ManageBuckets
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
            this.cmdHitRepo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdHitRepo
            // 
            this.cmdHitRepo.Location = new System.Drawing.Point(193, 149);
            this.cmdHitRepo.Name = "cmdHitRepo";
            this.cmdHitRepo.Size = new System.Drawing.Size(192, 155);
            this.cmdHitRepo.TabIndex = 0;
            this.cmdHitRepo.Text = "cmdHitRepo";
            this.cmdHitRepo.UseVisualStyleBackColor = true;
            this.cmdHitRepo.Click += new System.EventHandler(this.cmdHitRepo_Click);
            // 
            // ManageBuckets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 413);
            this.Controls.Add(this.cmdHitRepo);
            this.Name = "ManageBuckets";
            this.Text = "ManageBuckets";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdHitRepo;

    }
}