namespace Unit1Prb5
{
    partial class Unit1Prb5Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numberOfJobsLabel = new System.Windows.Forms.Label();
            this.jobQueueLabel = new System.Windows.Forms.Label();
            this.queueTextBox = new System.Windows.Forms.TextBox();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.newJobButton = new System.Windows.Forms.Button();
            this.releaseJobButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberOfJobsLabel
            // 
            this.numberOfJobsLabel.AutoSize = true;
            this.numberOfJobsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberOfJobsLabel.Location = new System.Drawing.Point(12, 20);
            this.numberOfJobsLabel.Name = "numberOfJobsLabel";
            this.numberOfJobsLabel.Size = new System.Drawing.Size(133, 21);
            this.numberOfJobsLabel.TabIndex = 0;
            this.numberOfJobsLabel.Text = "Number of jobs:";
            // 
            // jobQueueLabel
            // 
            this.jobQueueLabel.AutoSize = true;
            this.jobQueueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jobQueueLabel.Location = new System.Drawing.Point(12, 56);
            this.jobQueueLabel.Name = "jobQueueLabel";
            this.jobQueueLabel.Size = new System.Drawing.Size(91, 21);
            this.jobQueueLabel.TabIndex = 1;
            this.jobQueueLabel.Text = "Job Queue";
            // 
            // queueTextBox
            // 
            this.queueTextBox.Location = new System.Drawing.Point(12, 90);
            this.queueTextBox.Multiline = true;
            this.queueTextBox.Name = "queueTextBox";
            this.queueTextBox.ReadOnly = true;
            this.queueTextBox.Size = new System.Drawing.Size(253, 334);
            this.queueTextBox.TabIndex = 2;
            this.queueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numTextBox
            // 
            this.numTextBox.Location = new System.Drawing.Point(140, 22);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.ReadOnly = true;
            this.numTextBox.Size = new System.Drawing.Size(25, 23);
            this.numTextBox.TabIndex = 3;
            this.numTextBox.Text = "0";
            this.numTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // newJobButton
            // 
            this.newJobButton.Location = new System.Drawing.Point(109, 56);
            this.newJobButton.Name = "newJobButton";
            this.newJobButton.Size = new System.Drawing.Size(75, 23);
            this.newJobButton.TabIndex = 4;
            this.newJobButton.Text = "New Job";
            this.newJobButton.UseVisualStyleBackColor = true;
            this.newJobButton.Click += new System.EventHandler(this.newJobButton_Click);
            // 
            // releaseJobButton
            // 
            this.releaseJobButton.Location = new System.Drawing.Point(190, 57);
            this.releaseJobButton.Name = "releaseJobButton";
            this.releaseJobButton.Size = new System.Drawing.Size(75, 23);
            this.releaseJobButton.TabIndex = 5;
            this.releaseJobButton.Text = "Release Job";
            this.releaseJobButton.UseVisualStyleBackColor = true;
            this.releaseJobButton.Click += new System.EventHandler(this.releaseJobButton_Click);
            // 
            // Unit1Prb5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 450);
            this.Controls.Add(this.releaseJobButton);
            this.Controls.Add(this.newJobButton);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(this.queueTextBox);
            this.Controls.Add(this.jobQueueLabel);
            this.Controls.Add(this.numberOfJobsLabel);
            this.Name = "Unit1Prb5Form";
            this.Text = "Unit1Prb5 - Thuong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label numberOfJobsLabel;
        private Label jobQueueLabel;
        private TextBox queueTextBox;
        private TextBox numTextBox;
        private Button newJobButton;
        private Button releaseJobButton;
    }
}