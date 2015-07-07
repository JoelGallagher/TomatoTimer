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
            this.components = new System.ComponentModel.Container();
            this.cmdClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBucketName = new System.Windows.Forms.TextBox();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.pnlBuckets = new System.Windows.Forms.FlowLayoutPanel();
            this.bucketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNewBucket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bucketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(236, 317);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(4);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(100, 28);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bucket : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBucketName
            // 
            this.txtBucketName.Location = new System.Drawing.Point(118, 235);
            this.txtBucketName.Name = "txtBucketName";
            this.txtBucketName.Size = new System.Drawing.Size(218, 22);
            this.txtBucketName.TabIndex = 3;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(258, 273);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 4;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(177, 273);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 6;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            // 
            // pnlBuckets
            // 
            this.pnlBuckets.AutoScroll = true;
            this.pnlBuckets.Location = new System.Drawing.Point(19, 12);
            this.pnlBuckets.Name = "pnlBuckets";
            this.pnlBuckets.Size = new System.Drawing.Size(317, 167);
            this.pnlBuckets.TabIndex = 7;
            // 
            // bucketBindingSource
            // 
            this.bucketBindingSource.DataSource = typeof(TomatoTimer.Entities.Bucket);
            // 
            // btnNewBucket
            // 
            this.btnNewBucket.Location = new System.Drawing.Point(19, 185);
            this.btnNewBucket.Name = "btnNewBucket";
            this.btnNewBucket.Size = new System.Drawing.Size(75, 23);
            this.btnNewBucket.TabIndex = 8;
            this.btnNewBucket.Text = "New";
            this.btnNewBucket.UseVisualStyleBackColor = true;
            this.btnNewBucket.Click += new System.EventHandler(this.btnNewBucket_Click);
            // 
            // ManageBuckets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 361);
            this.Controls.Add(this.btnNewBucket);
            this.Controls.Add(this.pnlBuckets);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.txtBucketName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdClose);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageBuckets";
            this.Text = "ManageBuckets";
            ((System.ComponentModel.ISupportInitialize)(this.bucketBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bucketBindingSource;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBucketName;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.FlowLayoutPanel pnlBuckets;
        private System.Windows.Forms.Button btnNewBucket;


    }
}