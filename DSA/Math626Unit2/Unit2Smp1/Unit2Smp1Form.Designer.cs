namespace Unit2Smp1
{
    partial class Unit2Smp1Form
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
            this.nLabel = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.iterativeLabel = new System.Windows.Forms.Label();
            this.recursiveLabel = new System.Windows.Forms.Label();
            this.iterativeTextBox = new System.Windows.Forms.TextBox();
            this.recursiveTextBox = new System.Windows.Forms.TextBox();
            this.iterativeTimeTextBox = new System.Windows.Forms.TextBox();
            this.executionTimeLabel = new System.Windows.Forms.Label();
            this.recursiveTimeTextBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(3, 12);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(28, 15);
            this.nLabel.TabIndex = 0;
            this.nLabel.Text = "n = ";
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(32, 9);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(55, 23);
            this.nTextBox.TabIndex = 1;
            // 
            // iterativeLabel
            // 
            this.iterativeLabel.AutoSize = true;
            this.iterativeLabel.Location = new System.Drawing.Point(5, 52);
            this.iterativeLabel.Name = "iterativeLabel";
            this.iterativeLabel.Size = new System.Drawing.Size(84, 15);
            this.iterativeLabel.TabIndex = 2;
            this.iterativeLabel.Text = "(iterative) n! = ";
            // 
            // recursiveLabel
            // 
            this.recursiveLabel.AutoSize = true;
            this.recursiveLabel.Location = new System.Drawing.Point(1, 87);
            this.recursiveLabel.Name = "recursiveLabel";
            this.recursiveLabel.Size = new System.Drawing.Size(86, 15);
            this.recursiveLabel.TabIndex = 3;
            this.recursiveLabel.Text = "(recursive) n! =";
            // 
            // iterativeTextBox
            // 
            this.iterativeTextBox.Location = new System.Drawing.Point(84, 52);
            this.iterativeTextBox.Name = "iterativeTextBox";
            this.iterativeTextBox.ReadOnly = true;
            this.iterativeTextBox.Size = new System.Drawing.Size(204, 23);
            this.iterativeTextBox.TabIndex = 4;
            // 
            // recursiveTextBox
            // 
            this.recursiveTextBox.Location = new System.Drawing.Point(84, 81);
            this.recursiveTextBox.Name = "recursiveTextBox";
            this.recursiveTextBox.ReadOnly = true;
            this.recursiveTextBox.Size = new System.Drawing.Size(204, 23);
            this.recursiveTextBox.TabIndex = 5;
            // 
            // iterativeTimeTextBox
            // 
            this.iterativeTimeTextBox.Location = new System.Drawing.Point(299, 52);
            this.iterativeTimeTextBox.Name = "iterativeTimeTextBox";
            this.iterativeTimeTextBox.ReadOnly = true;
            this.iterativeTimeTextBox.Size = new System.Drawing.Size(100, 23);
            this.iterativeTimeTextBox.TabIndex = 6;
            // 
            // executionTimeLabel
            // 
            this.executionTimeLabel.AutoSize = true;
            this.executionTimeLabel.Location = new System.Drawing.Point(299, 29);
            this.executionTimeLabel.Name = "executionTimeLabel";
            this.executionTimeLabel.Size = new System.Drawing.Size(86, 15);
            this.executionTimeLabel.TabIndex = 7;
            this.executionTimeLabel.Text = "Execution time";
            // 
            // recursiveTimeTextBox
            // 
            this.recursiveTimeTextBox.Location = new System.Drawing.Point(299, 81);
            this.recursiveTimeTextBox.Name = "recursiveTimeTextBox";
            this.recursiveTimeTextBox.ReadOnly = true;
            this.recursiveTimeTextBox.Size = new System.Drawing.Size(100, 23);
            this.recursiveTimeTextBox.TabIndex = 8;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(93, 9);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 9;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click_1);
            // 
            // Unit2Smp1Form
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 132);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.recursiveTimeTextBox);
            this.Controls.Add(this.executionTimeLabel);
            this.Controls.Add(this.iterativeTimeTextBox);
            this.Controls.Add(this.recursiveTextBox);
            this.Controls.Add(this.iterativeTextBox);
            this.Controls.Add(this.recursiveLabel);
            this.Controls.Add(this.iterativeLabel);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.nLabel);
            this.MaximizeBox = false;
            this.Name = "Unit2Smp1Form";
            this.Text = "Unit2Smp1 - Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nLabel;
        private TextBox nTextBox;
        private Label iterativeLabel;
        private Label recursiveLabel;
        private TextBox iterativeTextBox;
        private TextBox recursiveTextBox;
        private TextBox iterativeTimeTextBox;
        private Label executionTimeLabel;
        private TextBox recursiveTimeTextBox;
        private Button calcButton;
    }
}