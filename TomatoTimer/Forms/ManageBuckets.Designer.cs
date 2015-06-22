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
            this.gridBuckets = new System.Windows.Forms.DataGridView();
            this.bucketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridBuckets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(323, 301);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // gridBuckets
            // 
            this.gridBuckets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBuckets.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.gridBuckets.Location = new System.Drawing.Point(12, 25);
            this.gridBuckets.Name = "gridBuckets";
            this.gridBuckets.Size = new System.Drawing.Size(240, 150);
            this.gridBuckets.TabIndex = 1;
            // 
            // bucketBindingSource
            // 
            this.bucketBindingSource.DataSource = typeof(TomatoTimer.Entities.Bucket);
            // 
            // ManageBuckets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 336);
            this.Controls.Add(this.gridBuckets);
            this.Controls.Add(this.cmdClose);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageBuckets";
            this.Text = "ManageBuckets";
            ((System.ComponentModel.ISupportInitialize)(this.gridBuckets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucketBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bucketBindingSource;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.DataGridView gridBuckets;


    }
}