namespace Unit1Prb5
{
    partial class addForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.numLabel = new System.Windows.Forms.Label();
            this.uNameLabel = new System.Windows.Forms.Label();
            this.jobNumTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 67);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add Job";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(93, 67);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Location = new System.Drawing.Point(12, 9);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(75, 15);
            this.numLabel.TabIndex = 2;
            this.numLabel.Text = "Job Number:";
            // 
            // uNameLabel
            // 
            this.uNameLabel.AutoSize = true;
            this.uNameLabel.Location = new System.Drawing.Point(19, 35);
            this.uNameLabel.Name = "uNameLabel";
            this.uNameLabel.Size = new System.Drawing.Size(68, 15);
            this.uNameLabel.TabIndex = 3;
            this.uNameLabel.Text = "User Name:";
            // 
            // jobNumTextBox
            // 
            this.jobNumTextBox.Location = new System.Drawing.Point(93, 6);
            this.jobNumTextBox.Name = "jobNumTextBox";
            this.jobNumTextBox.Size = new System.Drawing.Size(100, 23);
            this.jobNumTextBox.TabIndex = 4;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(93, 32);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.userNameTextBox.TabIndex = 5;
            // 
            // addForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(225, 110);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.jobNumTextBox);
            this.Controls.Add(this.uNameLabel);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.MaximizeBox = false;
            this.Name = "addForm";
            this.Text = "New Job";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addButton;
        private Button cancelButton;
        private Label numLabel;
        private Label uNameLabel;
        private TextBox jobNumTextBox;
        private TextBox userNameTextBox;
    }
}