namespace Unit1Smp3
{
    partial class Unit1Smp3Form
    {
      
        private System.ComponentModel.IContainer components = null;
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
            this.infixLabel = new System.Windows.Forms.Label();
            this.infixTextBox = new System.Windows.Forms.TextBox();
            this.postfixLabel = new System.Windows.Forms.Label();
            this.postfixTextBox = new System.Windows.Forms.TextBox();
            this.parseButton = new System.Windows.Forms.Button();
            this.cautionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infixLabel
            // 
            this.infixLabel.AutoSize = true;
            this.infixLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.infixLabel.Location = new System.Drawing.Point(12, 19);
            this.infixLabel.Name = "infixLabel";
            this.infixLabel.Size = new System.Drawing.Size(135, 21);
            this.infixLabel.TabIndex = 0;
            this.infixLabel.Text = "Infix expression:";
            // 
            // infixTextBox
            // 
            this.infixTextBox.Location = new System.Drawing.Point(171, 21);
            this.infixTextBox.Name = "infixTextBox";
            this.infixTextBox.Size = new System.Drawing.Size(381, 23);
            this.infixTextBox.TabIndex = 1;
            // 
            // postfixLabel
            // 
            this.postfixLabel.AutoSize = true;
            this.postfixLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.postfixLabel.Location = new System.Drawing.Point(12, 72);
            this.postfixLabel.Name = "postfixLabel";
            this.postfixLabel.Size = new System.Drawing.Size(153, 21);
            this.postfixLabel.TabIndex = 2;
            this.postfixLabel.Text = "Postfix expression:";
            // 
            // postfixTextBox
            // 
            this.postfixTextBox.Location = new System.Drawing.Point(171, 74);
            this.postfixTextBox.Name = "postfixTextBox";
            this.postfixTextBox.ReadOnly = true;
            this.postfixTextBox.Size = new System.Drawing.Size(381, 23);
            this.postfixTextBox.TabIndex = 3;
            // 
            // parseButton
            // 
            this.parseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.parseButton.Location = new System.Drawing.Point(12, 116);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(95, 36);
            this.parseButton.TabIndex = 4;
            this.parseButton.Text = "Parse";
            this.parseButton.UseVisualStyleBackColor = true;
            this.parseButton.Click += new System.EventHandler(this.parseButton_Click);
            // 
            // cautionLabel
            // 
            this.cautionLabel.AutoSize = true;
            this.cautionLabel.BackColor = System.Drawing.SystemColors.Control;
            this.cautionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cautionLabel.ForeColor = System.Drawing.Color.Red;
            this.cautionLabel.Location = new System.Drawing.Point(12, 47);
            this.cautionLabel.Name = "cautionLabel";
            this.cautionLabel.Size = new System.Drawing.Size(202, 15);
            this.cautionLabel.TabIndex = 5;
            this.cautionLabel.Text = "Only +,*.-,/ are supported operations";
            // 
            // Unit1Smp3Form
            // 
            this.AcceptButton = this.parseButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 172);
            this.Controls.Add(this.cautionLabel);
            this.Controls.Add(this.parseButton);
            this.Controls.Add(this.postfixTextBox);
            this.Controls.Add(this.postfixLabel);
            this.Controls.Add(this.infixTextBox);
            this.Controls.Add(this.infixLabel);
            this.MaximizeBox = false;
            this.Name = "Unit1Smp3Form";
            this.Text = "Unit1Smp3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label infixLabel;
        private TextBox infixTextBox;
        private Label postfixLabel;
        private TextBox postfixTextBox;
        private Button parseButton;
        private Label cautionLabel;
    }
}