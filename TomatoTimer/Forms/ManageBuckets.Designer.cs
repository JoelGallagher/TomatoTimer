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
            this.btnNewBucket = new System.Windows.Forms.Button();
            this.bucketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblFormState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bucketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(177, 258);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bucket : ";
            // 
            // txtBucketName
            // 
            this.txtBucketName.Location = new System.Drawing.Point(88, 191);
            this.txtBucketName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBucketName.Name = "txtBucketName";
            this.txtBucketName.Size = new System.Drawing.Size(164, 20);
            this.txtBucketName.TabIndex = 3;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(194, 222);
            this.cmdDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(56, 19);
            this.cmdDelete.TabIndex = 4;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(133, 222);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(56, 19);
            this.cmdSave.TabIndex = 6;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // pnlBuckets
            // 
            this.pnlBuckets.AutoScroll = true;
            this.pnlBuckets.Location = new System.Drawing.Point(14, 10);
            this.pnlBuckets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBuckets.Name = "pnlBuckets";
            this.pnlBuckets.Size = new System.Drawing.Size(238, 136);
            this.pnlBuckets.TabIndex = 7;
            // 
            // btnNewBucket
            // 
            this.btnNewBucket.Location = new System.Drawing.Point(14, 150);
            this.btnNewBucket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewBucket.Name = "btnNewBucket";
            this.btnNewBucket.Size = new System.Drawing.Size(56, 19);
            this.btnNewBucket.TabIndex = 8;
            this.btnNewBucket.Text = "New";
            this.btnNewBucket.UseVisualStyleBackColor = true;
            this.btnNewBucket.Click += new System.EventHandler(this.btnNewBucket_Click);
            // 
            // bucketBindingSource
            // 
            this.bucketBindingSource.DataSource = typeof(TomatoTimer.Entities.Bucket);
            // 
            // lblFormState
            // 
            this.lblFormState.AutoSize = true;
            this.lblFormState.Location = new System.Drawing.Point(76, 152);
            this.lblFormState.Name = "lblFormState";
            this.lblFormState.Size = new System.Drawing.Size(59, 13);
            this.lblFormState.TabIndex = 9;
            this.lblFormState.Text = "(form state)";
            // 
            // ManageBuckets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 293);
            this.Controls.Add(this.lblFormState);
            this.Controls.Add(this.btnNewBucket);
            this.Controls.Add(this.pnlBuckets);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.txtBucketName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdClose);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label lblFormState;


    }
}