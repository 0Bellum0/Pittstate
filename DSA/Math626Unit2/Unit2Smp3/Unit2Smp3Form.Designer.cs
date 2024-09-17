namespace Unit2Smp3
{
    partial class Unit2Smp3Form
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
            this.stringLengthLabel = new System.Windows.Forms.Label();
            this.numOfLettersLabel = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.numLettersTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.numCallsLabel = new System.Windows.Forms.Label();
            this.numStringsLabel = new System.Windows.Forms.Label();
            this.recursiveCallsTextBox = new System.Windows.Forms.TextBox();
            this.numStringsTextBox = new System.Windows.Forms.TextBox();
            this.outputTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // stringLengthLabel
            // 
            this.stringLengthLabel.AutoSize = true;
            this.stringLengthLabel.Location = new System.Drawing.Point(12, 23);
            this.stringLengthLabel.Name = "stringLengthLabel";
            this.stringLengthLabel.Size = new System.Drawing.Size(78, 15);
            this.stringLengthLabel.TabIndex = 0;
            this.stringLengthLabel.Text = "String length:";
            // 
            // numOfLettersLabel
            // 
            this.numOfLettersLabel.AutoSize = true;
            this.numOfLettersLabel.Location = new System.Drawing.Point(12, 58);
            this.numOfLettersLabel.Name = "numOfLettersLabel";
            this.numOfLettersLabel.Size = new System.Drawing.Size(103, 15);
            this.numOfLettersLabel.TabIndex = 1;
            this.numOfLettersLabel.Text = "Number of letters:";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(121, 20);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(39, 23);
            this.lengthTextBox.TabIndex = 2;
            // 
            // numLettersTextBox
            // 
            this.numLettersTextBox.Location = new System.Drawing.Point(121, 55);
            this.numLettersTextBox.Name = "numLettersTextBox";
            this.numLettersTextBox.Size = new System.Drawing.Size(39, 23);
            this.numLettersTextBox.TabIndex = 3;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(14, 84);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(146, 23);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Generate Strings";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // numCallsLabel
            // 
            this.numCallsLabel.AutoSize = true;
            this.numCallsLabel.Location = new System.Drawing.Point(166, 23);
            this.numCallsLabel.Name = "numCallsLabel";
            this.numCallsLabel.Size = new System.Drawing.Size(144, 15);
            this.numCallsLabel.TabIndex = 5;
            this.numCallsLabel.Text = "Number of recursive calls:";
            // 
            // numStringsLabel
            // 
            this.numStringsLabel.AutoSize = true;
            this.numStringsLabel.Location = new System.Drawing.Point(204, 58);
            this.numStringsLabel.Name = "numStringsLabel";
            this.numStringsLabel.Size = new System.Drawing.Size(106, 15);
            this.numStringsLabel.TabIndex = 6;
            this.numStringsLabel.Text = "Number of strings:";
            // 
            // recursiveCallsTextBox
            // 
            this.recursiveCallsTextBox.Location = new System.Drawing.Point(316, 20);
            this.recursiveCallsTextBox.Name = "recursiveCallsTextBox";
            this.recursiveCallsTextBox.ReadOnly = true;
            this.recursiveCallsTextBox.Size = new System.Drawing.Size(100, 23);
            this.recursiveCallsTextBox.TabIndex = 7;
            // 
            // numStringsTextBox
            // 
            this.numStringsTextBox.Location = new System.Drawing.Point(316, 55);
            this.numStringsTextBox.Name = "numStringsTextBox";
            this.numStringsTextBox.ReadOnly = true;
            this.numStringsTextBox.Size = new System.Drawing.Size(100, 23);
            this.numStringsTextBox.TabIndex = 8;
            // 
            // outputTextbox
            // 
            this.outputTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.outputTextbox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputTextbox.Location = new System.Drawing.Point(192, 84);
            this.outputTextbox.Multiline = true;
            this.outputTextbox.Name = "outputTextbox";
            this.outputTextbox.ReadOnly = true;
            this.outputTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputTextbox.Size = new System.Drawing.Size(224, 376);
            this.outputTextbox.TabIndex = 9;
            this.outputTextbox.WordWrap = false;
            // 
            // Unit2Smp3Form
            // 
            this.AcceptButton = this.generateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 472);
            this.Controls.Add(this.outputTextbox);
            this.Controls.Add(this.numStringsTextBox);
            this.Controls.Add(this.recursiveCallsTextBox);
            this.Controls.Add(this.numStringsLabel);
            this.Controls.Add(this.numCallsLabel);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.numLettersTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.numOfLettersLabel);
            this.Controls.Add(this.stringLengthLabel);
            this.MaximizeBox = false;
            this.Name = "Unit2Smp3Form";
            this.Text = "Unit2Smp3 - Generate Strings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label stringLengthLabel;
        private Label numOfLettersLabel;
        private TextBox lengthTextBox;
        private TextBox numLettersTextBox;
        private Button generateButton;
        private Label numCallsLabel;
        private Label numStringsLabel;
        private TextBox recursiveCallsTextBox;
        private TextBox numStringsTextBox;
        private TextBox outputTextbox;
    }
}